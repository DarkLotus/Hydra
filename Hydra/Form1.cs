﻿// Copyright (C) 2013 Iker Ruiz Arnauda
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;

using HydraLib.Nodes;
using HydraLib.Nodes.NodeTypes;
using HYDRA.Properties;

namespace HYDRA
{
    public partial class Form1 : Form
    {
        //Used to store logic nodes.
        private List<DrawableNode> _LogicNodes = new List<DrawableNode>();

        //Store all nodes using GUID as key and ONode as value.
        //Todo: should be only one list, requires some more refactoring.
        private Dictionary<Guid, Node> AllNodes = new Dictionary<Guid, Node>();
        private Dictionary<Guid, DrawableNode> AllDrawableNodes = new Dictionary<Guid, DrawableNode>();

        //Used as a stack for tool selection menu
        private List<ToolStripButton> lastSelectedTool = new List<ToolStripButton>();

        //Stores the TYPE of the node that its being drawed/selected
        private Type _selectedNodeType;

        //Context menu for drawPanel, this is used to add nodes into the drawPanel.
        private ToolStripDropDownMenu drawPanelCtxMenu;

        //List used to link the ContextMenu selected item with the proper Node Type the user wants to use.
        private List<ComboBoxObject> usuableNodeList = new List<ComboBoxObject>();

        public Form1()
        {
            InitializeComponent();
            CreateDrawPanelCtxMenu();
            ExecuteLoop.Interval = 1000;
        }

        //Connector Button
        #region Connector_Button
        private void ConnectorToolButton_Click(object sender, EventArgs e)
        {
            switch (ConnectorToolButton.Checked)
            {
                case true:
                    ConnectorToolButton.Checked = false;
                    break;
                case false:
                    if (lastSelectedTool.Count > 0)
                    {
                        lastSelectedTool[0].Checked = false;
                        lastSelectedTool.RemoveAt(0);
                    }
                    _selectedNodeType = null;
                    ConnectorToolButton.Checked = true;
                    lastSelectedTool.Add((sender) as ToolStripButton);
                    break;
            }
        }
        #endregion

        //Execute Button
        #region Execute Button
        private void ExecuteToolButton_MouseClick(object sender, EventArgs e)
        {
            if (ExecuteLoop.Enabled)
                ExecuteLoop.Enabled = false;
            else
                ExecuteLoop.Enabled = true;
        }

        //Execute.
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (DrawableNode a in _LogicNodes)
            {
                a.Process(AllNodes);
                try
                {
                    if (a.GetNode().isBool)
                        listVarWatch.FindItemWithText(a.GUID.ToString()).SubItems[1].Text = Convert.ToBoolean(a.Value).ToString();
                    else
                        listVarWatch.FindItemWithText(a.GUID.ToString()).SubItems[1].Text = a.Value.ToString();
                }
                catch { }
            }
        }
        #endregion

        //Draws || Interact with the graph panel.
        #region Graph_Panel
        private void drawPanel_MouseClick(object sender, MouseEventArgs e)
        {
            //Make the center of the node appear on mouse position.
            var _placementPos = new Point(e.Location.X - 15, e.Location.Y - 15);

            //Context Menu
            if (e.Button == MouseButtons.Right)
            {
                drawPanelCtxMenu.Show(this, _placementPos);
            }

            else if (e.Button == MouseButtons.Left)
            {
                //Node Drawing
                if (_selectedNodeType != null)
                {
                    var node = new DrawableNode(getNode(), drawPanel, listVarWatch);
                    node.Draw(_placementPos);
                    //Deploy log into the bottom textlog.
                    ConsoleLogTextBox.Text += node.Log();
                    // Adds the node to all our lists
                    addNode(node, true);
                    // Switch back to arrow cursor
                    this.Cursor = DefaultCursor;
                    // Null Node selection
                    _selectedNodeType = null;
                    //Scroll Console Log
                    ConsoleLogTextBox.SelectionStart = ConsoleLogTextBox.TextLength;
                    ConsoleLogTextBox.ScrollToCaret();
                    return;
                }
            }
        }
        #endregion

        /// <summary>
        /// Helper function to create the drawPanel Context Menu
        /// Also fills the usuableNodeList which we will use to link the CtxMenu selection with the proper type of Object the user wants to draw.
        /// </summary>
        private void CreateDrawPanelCtxMenu()
        {
            drawPanelCtxMenu = new ToolStripDropDownMenu();
            ResourceManager rm = Resources.ResourceManager; //Used to gran the node Image..

            foreach (var nodeSubClass in FindSubClassesOf<Node>())
            {
                //Todo: Remove ComboBoxObject and apply a new implementation.

                //First we make a list with all the avialable nodes in our program.
                usuableNodeList.Add(new ComboBoxObject(nodeSubClass, nodeSubClass.Name));
            }

            //We sort it A-Z
            usuableNodeList.Sort((x, y) => string.Compare(x._name, y._name));

            //Add it to the CtxMenu in drawPanel
            foreach (var node in usuableNodeList)
            {
                //In order to grab the correct image I need to trim the name and remove the "Node" part because when we find the subclasses they return the name as AdditionNode when we only need "Addition".
                //So yeah, we need to make this right at osme point.
                string _removeTheWordNode = node._name.Replace("Node", null);
                Bitmap _nodeImage = (Bitmap)rm.GetObject(_removeTheWordNode);
                drawPanelCtxMenu.Items.Add(node._name, _nodeImage, DrawPanelCtxMenu_SelectedtItemChanged);
            }
        }

        /// <summary>
        /// Helper function to add a node to appropriate lists
        /// </summary>
        /// <param name="node">The Drawable node to add</param>
        /// <param name="isLogic">True if this is a logic node</param>
        private void addNode(DrawableNode node, bool isLogic)
        {
            AllDrawableNodes.Add(node.GUID, node);
            AllNodes.Add(node.GUID, node.GetNode());
            if (isLogic)
                _LogicNodes.Add(node); //Add to a node List.

            node.onNodeClick += node_onNodeClick; // Grab the onclick event, and send to node_onNodeClick
        }

        /// <summary>
        /// Handles event for when a Node is clicked on in the graphPanel
        /// </summary>
        /// <param name="sender">The clicked on node</param>
        /// <param name="e">MouseEventArgs</param>
        void node_onNodeClick(DrawableNode sender, MouseEventArgs e)
        {
            //Return if not using Connector tool, and not left clicking.
            if (!ConnectorToolButton.Checked || e.Button != MouseButtons.Left)
                return;

            if (Connector.TailMouseOverGuid != Guid.Empty)
            {
                Connector.HeadOverGuid = sender.GUID;
                DrawAbleConnector con = new DrawAbleConnector(Connector.TailMouseOverGuid, Connector.HeadOverGuid);
                sender.Input.Add(con); //Add the connection to the destination node Input list.
                con.Draw(drawPanel.CreateGraphics(), AllDrawableNodes);//Draw the connector
                //Debug
                Console.WriteLine("Log: " + sender.Name + "|| Input count: " + sender.Input.Count + " || Output count: " + sender.Output.Count);
                return;
            }

            Connector.TailMouseOverGuid = sender.GUID;
            //MessageBox.Show("Stablished TAIL");
        }

        /// <summary>
        /// Helper function to get all super types of a class in the assembly
        /// </summary>
        /// <typeparam name="TBaseType"></typeparam>
        /// <returns></returns>
        public IEnumerable<Type> FindSubClassesOf<TBaseType>()
        {
            var baseType = typeof(TBaseType);
            var assembly = baseType.Assembly;

            return assembly.GetTypes().Where(t => t.IsSubclassOf(baseType));
        }

        /// <summary>
        /// Sets the current type to the currently selected node type from the drawPanelContexMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawPanelCtxMenu_SelectedtItemChanged(object sender, EventArgs e)
        {
            //Custom cursor to preview the node.
            Bitmap _nodePlacement = new Bitmap(HYDRA.Properties.Resources.NodePlacement);
            Cursor cursor = new Cursor(_nodePlacement.GetHicon());
            this.Cursor = cursor;

            //We find the index of the selected node over the ContextMenu in our usuableNodeList.
            var index = usuableNodeList.FindIndex(_nodeInList => _nodeInList._name.Equals((sender as ToolStripItem).Text, StringComparison.Ordinal));
            //Define the Object using our list.
            ComboBoxObject a = (ComboBoxObject)usuableNodeList[index];
            //Set the selected NodeType from the selected Object.
            _selectedNodeType = a._nodeType;
        }

        /// <summary>
        /// Creates a new node instance of the given type, calling the Nodes default constructor with a new GUID
        /// </summary>
        /// <returns></returns>
        public Node getNode()
        {
            return (Node)Activator.CreateInstance(_selectedNodeType, new object[] { Guid.NewGuid() });
        }

    }
}

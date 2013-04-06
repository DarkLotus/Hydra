﻿namespace HYDRA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.graphPanel = new System.Windows.Forms.Panel();
            this.ConsoleLogTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ConstantToolButton = new System.Windows.Forms.ToolStripButton();
            this.AdditionToolButton = new System.Windows.Forms.ToolStripButton();
            this.SubstractionToolButton = new System.Windows.Forms.ToolStripButton();
            this.MultiplicationToolButton = new System.Windows.Forms.ToolStripButton();
            this.DivisionToolButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ConnectorToolButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExecuteToolButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripToolSelectorComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.listVarWatch = new System.Windows.Forms.ListView();
            this.Var = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelVarWatch = new System.Windows.Forms.Label();
            this.labelLogConsole = new System.Windows.Forms.Label();
            this.labelDrawPanel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // graphPanel
            // 
            this.graphPanel.BackColor = System.Drawing.Color.White;
            this.graphPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphPanel.Location = new System.Drawing.Point(11, 62);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(708, 396);
            this.graphPanel.TabIndex = 0;
            this.graphPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphPanel_MouseClick);
            // 
            // ConsoleLogTextBox
            // 
            this.ConsoleLogTextBox.BackColor = System.Drawing.Color.SteelBlue;
            this.ConsoleLogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsoleLogTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ConsoleLogTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleLogTextBox.ForeColor = System.Drawing.Color.White;
            this.ConsoleLogTextBox.Location = new System.Drawing.Point(12, 488);
            this.ConsoleLogTextBox.Multiline = true;
            this.ConsoleLogTextBox.Name = "ConsoleLogTextBox";
            this.ConsoleLogTextBox.ReadOnly = true;
            this.ConsoleLogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ConsoleLogTextBox.Size = new System.Drawing.Size(1066, 147);
            this.ConsoleLogTextBox.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 652);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1090, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(105, 17);
            this.toolStripStatusLabel1.Text = "Node Testing 2013";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConstantToolButton,
            this.AdditionToolButton,
            this.SubstractionToolButton,
            this.MultiplicationToolButton,
            this.DivisionToolButton,
            this.toolStripSeparator2,
            this.ConnectorToolButton,
            this.toolStripSeparator1,
            this.ExecuteToolButton,
            this.toolStripSeparator3,
            this.toolStripToolSelectorComboBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1090, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // ConstantToolButton
            // 
            this.ConstantToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ConstantToolButton.Image = global::HYDRA.Properties.Resources.Constant;
            this.ConstantToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConstantToolButton.Name = "ConstantToolButton";
            this.ConstantToolButton.Size = new System.Drawing.Size(36, 36);
            this.ConstantToolButton.Text = "Constant";
            this.ConstantToolButton.Click += new System.EventHandler(this.ConstantToolButton_Click);
            this.ConstantToolButton.MouseEnter += new System.EventHandler(this.ConstantToolButton_MouseEnter);
            this.ConstantToolButton.MouseLeave += new System.EventHandler(this.ConstantToolButton_MouseLeave);
            // 
            // AdditionToolButton
            // 
            this.AdditionToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AdditionToolButton.Image = global::HYDRA.Properties.Resources.Addition;
            this.AdditionToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AdditionToolButton.Name = "AdditionToolButton";
            this.AdditionToolButton.Size = new System.Drawing.Size(36, 36);
            this.AdditionToolButton.Text = "Addition";
            this.AdditionToolButton.Click += new System.EventHandler(this.AdditionToolButton_Click);
            this.AdditionToolButton.MouseEnter += new System.EventHandler(this.AdditionToolButton_MouseEnter);
            this.AdditionToolButton.MouseLeave += new System.EventHandler(this.AdditionToolButton_MouseLeave);
            // 
            // SubstractionToolButton
            // 
            this.SubstractionToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SubstractionToolButton.Image = global::HYDRA.Properties.Resources.Substraction;
            this.SubstractionToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SubstractionToolButton.Name = "SubstractionToolButton";
            this.SubstractionToolButton.Size = new System.Drawing.Size(36, 36);
            this.SubstractionToolButton.Text = "Substraction";
            this.SubstractionToolButton.Click += new System.EventHandler(this.SubstractionToolButton_Click);
            this.SubstractionToolButton.MouseEnter += new System.EventHandler(this.SubstractionToolButton_MouseEnter);
            this.SubstractionToolButton.MouseLeave += new System.EventHandler(this.SubstractionToolButton_MouseLeave);
            // 
            // MultiplicationToolButton
            // 
            this.MultiplicationToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MultiplicationToolButton.Image = global::HYDRA.Properties.Resources.Multiplication;
            this.MultiplicationToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MultiplicationToolButton.Name = "MultiplicationToolButton";
            this.MultiplicationToolButton.Size = new System.Drawing.Size(36, 36);
            this.MultiplicationToolButton.Text = "Multiplication";
            this.MultiplicationToolButton.Click += new System.EventHandler(this.MultiplicationToolButton_Click);
            // 
            // DivisionToolButton
            // 
            this.DivisionToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DivisionToolButton.Image = global::HYDRA.Properties.Resources.Division;
            this.DivisionToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DivisionToolButton.Name = "DivisionToolButton";
            this.DivisionToolButton.Size = new System.Drawing.Size(36, 36);
            this.DivisionToolButton.Text = "Division";
            this.DivisionToolButton.Click += new System.EventHandler(this.DivisionToolButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.Red;
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.Red;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            this.toolStripSeparator2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // ConnectorToolButton
            // 
            this.ConnectorToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ConnectorToolButton.Image = global::HYDRA.Properties.Resources.Connector;
            this.ConnectorToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConnectorToolButton.Name = "ConnectorToolButton";
            this.ConnectorToolButton.Size = new System.Drawing.Size(36, 36);
            this.ConnectorToolButton.Text = "Connector";
            this.ConnectorToolButton.Click += new System.EventHandler(this.ConnectorToolButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            this.toolStripSeparator1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // ExecuteToolButton
            // 
            this.ExecuteToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExecuteToolButton.Image = global::HYDRA.Properties.Resources.execute;
            this.ExecuteToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExecuteToolButton.Name = "ExecuteToolButton";
            this.ExecuteToolButton.Size = new System.Drawing.Size(36, 36);
            this.ExecuteToolButton.Text = "Execute";
            this.ExecuteToolButton.Click += new System.EventHandler(this.ExecuteToolButton_MouseClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            this.toolStripSeparator3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripToolSelectorComboBox
            // 
            this.toolStripToolSelectorComboBox.Name = "toolStripToolSelectorComboBox";
            this.toolStripToolSelectorComboBox.Size = new System.Drawing.Size(121, 39);
            this.toolStripToolSelectorComboBox.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.toolStripToolSelectorComboBox.SelectedIndexChanged += new System.EventHandler(this.toolsComboBox_SelectedIndexChanged);
            // 
            // listVarWatch
            // 
            this.listVarWatch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listVarWatch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Var,
            this.Value,
            this.Id});
            this.listVarWatch.GridLines = true;
            this.listVarWatch.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listVarWatch.Location = new System.Drawing.Point(725, 62);
            this.listVarWatch.MultiSelect = false;
            this.listVarWatch.Name = "listVarWatch";
            this.listVarWatch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listVarWatch.Size = new System.Drawing.Size(365, 396);
            this.listVarWatch.TabIndex = 2;
            this.listVarWatch.UseCompatibleStateImageBehavior = false;
            this.listVarWatch.View = System.Windows.Forms.View.Details;
            // 
            // Var
            // 
            this.Var.Text = "Var";
            this.Var.Width = 86;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 63;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 212;
            // 
            // labelVarWatch
            // 
            this.labelVarWatch.AutoSize = true;
            this.labelVarWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVarWatch.Location = new System.Drawing.Point(888, 46);
            this.labelVarWatch.Name = "labelVarWatch";
            this.labelVarWatch.Size = new System.Drawing.Size(67, 13);
            this.labelVarWatch.TabIndex = 3;
            this.labelVarWatch.Text = "Var Watch";
            // 
            // labelLogConsole
            // 
            this.labelLogConsole.AutoSize = true;
            this.labelLogConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogConsole.Location = new System.Drawing.Point(12, 472);
            this.labelLogConsole.Name = "labelLogConsole";
            this.labelLogConsole.Size = new System.Drawing.Size(77, 13);
            this.labelLogConsole.TabIndex = 4;
            this.labelLogConsole.Text = "Log Console";
            // 
            // labelDrawPanel
            // 
            this.labelDrawPanel.AutoSize = true;
            this.labelDrawPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrawPanel.Location = new System.Drawing.Point(12, 46);
            this.labelDrawPanel.Name = "labelDrawPanel";
            this.labelDrawPanel.Size = new System.Drawing.Size(72, 13);
            this.labelDrawPanel.TabIndex = 5;
            this.labelDrawPanel.Text = "Draw Panel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 674);
            this.Controls.Add(this.listVarWatch);
            this.Controls.Add(this.labelDrawPanel);
            this.Controls.Add(this.labelLogConsole);
            this.Controls.Add(this.labelVarWatch);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ConsoleLogTextBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.graphPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Node Testing 2013";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AdditionToolButton;
        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.TextBox ConsoleLogTextBox;
        private System.Windows.Forms.ToolStripButton ConstantToolButton;
        private System.Windows.Forms.ToolStripButton ExecuteToolButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ConnectorToolButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton SubstractionToolButton;
        private System.Windows.Forms.ToolStripButton MultiplicationToolButton;
        private System.Windows.Forms.ToolStripButton DivisionToolButton;
        private System.Windows.Forms.Label labelVarWatch;
        private System.Windows.Forms.Label labelLogConsole;
        private System.Windows.Forms.Label labelDrawPanel;
        private System.Windows.Forms.ListView listVarWatch;
        private System.Windows.Forms.ColumnHeader Var;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ToolStripComboBox toolStripToolSelectorComboBox;
    }
}

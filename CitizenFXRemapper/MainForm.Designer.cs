
namespace CitizenFXRemapper
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.customTabControl1 = new CitizenFXRemapper.Controls.CustomTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.KeybindList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KeybindBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PreviewRichtextbox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ActionTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.keylist = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.PaddingCuzFuckYou = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.FormHeader = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FormTitle = new System.Windows.Forms.Label();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.BottomToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.LoadedConfig = new System.Windows.Forms.ToolStripComboBox();
            this.KeybindListContextmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addItemAboneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemBelowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel.SuspendLayout();
            this.customTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.KeybindBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.FormHeader.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.BottomToolStrip.SuspendLayout();
            this.KeybindListContextmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.customTabControl1);
            this.mainPanel.Controls.Add(this.TopPanel);
            this.mainPanel.Controls.Add(this.BottomToolStrip);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1427, 684);
            this.mainPanel.TabIndex = 0;
            // 
            // customTabControl1
            // 
            this.customTabControl1.Controls.Add(this.tabPage1);
            this.customTabControl1.Controls.Add(this.tabPage2);
            this.customTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTabControl1.ItemSize = new System.Drawing.Size(150, 30);
            this.customTabControl1.Location = new System.Drawing.Point(0, 33);
            this.customTabControl1.Multiline = true;
            this.customTabControl1.Name = "customTabControl1";
            this.customTabControl1.SelectedIndex = 0;
            this.customTabControl1.Size = new System.Drawing.Size(1427, 626);
            this.customTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.customTabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.tabPage1.Controls.Add(this.KeybindList);
            this.tabPage1.Controls.Add(this.KeybindBox);
            this.tabPage1.Location = new System.Drawing.Point(0, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1427, 596);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Keybinds";
            // 
            // KeybindList
            // 
            this.KeybindList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.KeybindList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeybindList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.KeybindList.ContextMenuStrip = this.KeybindListContextmenu;
            this.KeybindList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeybindList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.KeybindList.ForeColor = System.Drawing.Color.White;
            this.KeybindList.FullRowSelect = true;
            this.KeybindList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.KeybindList.HideSelection = false;
            this.KeybindList.Location = new System.Drawing.Point(3, 3);
            this.KeybindList.MultiSelect = false;
            this.KeybindList.Name = "KeybindList";
            this.KeybindList.Size = new System.Drawing.Size(1421, 467);
            this.KeybindList.TabIndex = 1;
            this.KeybindList.UseCompatibleStateImageBehavior = false;
            this.KeybindList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Bindcmd";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Inputmethod";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Key";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Action";
            // 
            // KeybindBox
            // 
            this.KeybindBox.Controls.Add(this.label6);
            this.KeybindBox.Controls.Add(this.label5);
            this.KeybindBox.Controls.Add(this.label4);
            this.KeybindBox.Controls.Add(this.label3);
            this.KeybindBox.Controls.Add(this.PreviewRichtextbox);
            this.KeybindBox.Controls.Add(this.label2);
            this.KeybindBox.Controls.Add(this.ActionTextbox);
            this.KeybindBox.Controls.Add(this.label1);
            this.KeybindBox.Controls.Add(this.keylist);
            this.KeybindBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.KeybindBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.KeybindBox.ForeColor = System.Drawing.Color.White;
            this.KeybindBox.Location = new System.Drawing.Point(3, 470);
            this.KeybindBox.Name = "KeybindBox";
            this.KeybindBox.Size = new System.Drawing.Size(1421, 123);
            this.KeybindBox.TabIndex = 0;
            this.KeybindBox.TabStop = false;
            this.KeybindBox.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Preview";
            // 
            // PreviewRichtextbox
            // 
            this.PreviewRichtextbox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PreviewRichtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PreviewRichtextbox.Location = new System.Drawing.Point(91, 86);
            this.PreviewRichtextbox.Multiline = false;
            this.PreviewRichtextbox.Name = "PreviewRichtextbox";
            this.PreviewRichtextbox.ReadOnly = true;
            this.PreviewRichtextbox.Size = new System.Drawing.Size(668, 26);
            this.PreviewRichtextbox.TabIndex = 15;
            this.PreviewRichtextbox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Action";
            // 
            // ActionTextbox
            // 
            this.ActionTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionTextbox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ActionTextbox.Location = new System.Drawing.Point(91, 54);
            this.ActionTextbox.Name = "ActionTextbox";
            this.ActionTextbox.Size = new System.Drawing.Size(668, 26);
            this.ActionTextbox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Key";
            // 
            // keylist
            // 
            this.keylist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.keylist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keylist.ForeColor = System.Drawing.Color.White;
            this.keylist.FormattingEnabled = true;
            this.keylist.Location = new System.Drawing.Point(91, 18);
            this.keylist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.keylist.Name = "keylist";
            this.keylist.Size = new System.Drawing.Size(668, 28);
            this.keylist.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.PaddingCuzFuckYou);
            this.tabPage2.Location = new System.Drawing.Point(0, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1427, 596);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Raw Config";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(30, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1394, 590);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // PaddingCuzFuckYou
            // 
            this.PaddingCuzFuckYou.Dock = System.Windows.Forms.DockStyle.Left;
            this.PaddingCuzFuckYou.Location = new System.Drawing.Point(3, 3);
            this.PaddingCuzFuckYou.Name = "PaddingCuzFuckYou";
            this.PaddingCuzFuckYou.Size = new System.Drawing.Size(27, 590);
            this.PaddingCuzFuckYou.TabIndex = 1;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.FormHeader);
            this.TopPanel.Controls.Add(this.panel3);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1427, 33);
            this.TopPanel.TabIndex = 14;
            // 
            // FormHeader
            // 
            this.FormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(67)))));
            this.FormHeader.Controls.Add(this.MinimizeButton);
            this.FormHeader.Controls.Add(this.CloseButton);
            this.FormHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormHeader.Location = new System.Drawing.Point(287, 0);
            this.FormHeader.Name = "FormHeader";
            this.FormHeader.Size = new System.Drawing.Size(1140, 33);
            this.FormHeader.TabIndex = 13;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(1048, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(46, 33);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(1094, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(46, 33);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "x";
            this.CloseButton.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(62)))), ((int)(((byte)(67)))));
            this.panel3.Controls.Add(this.FormTitle);
            this.panel3.Controls.Add(this.iconBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 33);
            this.panel3.TabIndex = 15;
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormTitle.ForeColor = System.Drawing.Color.White;
            this.FormTitle.Location = new System.Drawing.Point(44, 9);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(153, 20);
            this.FormTitle.TabIndex = 15;
            this.FormTitle.Text = "CitizenFXRemapper";
            // 
            // iconBox
            // 
            this.iconBox.BackColor = System.Drawing.Color.Transparent;
            this.iconBox.Cursor = System.Windows.Forms.Cursors.Help;
            this.iconBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconBox.Image = ((System.Drawing.Image)(resources.GetObject("iconBox.Image")));
            this.iconBox.Location = new System.Drawing.Point(0, 0);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(45, 33);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBox.TabIndex = 7;
            this.iconBox.TabStop = false;
            // 
            // BottomToolStrip
            // 
            this.BottomToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.BottomToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BottomToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.LoadedConfig});
            this.BottomToolStrip.Location = new System.Drawing.Point(0, 659);
            this.BottomToolStrip.Name = "BottomToolStrip";
            this.BottomToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.BottomToolStrip.Size = new System.Drawing.Size(1427, 25);
            this.BottomToolStrip.TabIndex = 18;
            this.BottomToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(81, 22);
            this.toolStripLabel1.Text = "Load Config : ";
            // 
            // LoadedConfig
            // 
            this.LoadedConfig.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LoadedConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.LoadedConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoadedConfig.ForeColor = System.Drawing.Color.White;
            this.LoadedConfig.Name = "LoadedConfig";
            this.LoadedConfig.Size = new System.Drawing.Size(1333, 25);
            // 
            // KeybindListContextmenu
            // 
            this.KeybindListContextmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem,
            this.toolStripSeparator2,
            this.addItemAboneToolStripMenuItem,
            this.addItemBelowToolStripMenuItem,
            this.toolStripSeparator1,
            this.editItemToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.toolStripSeparator3,
            this.clearAllToolStripMenuItem});
            this.KeybindListContextmenu.Name = "contextMenuStrip1";
            this.KeybindListContextmenu.Size = new System.Drawing.Size(181, 176);
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addItemToolStripMenuItem.Text = "Add Keybind";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // addItemAboneToolStripMenuItem
            // 
            this.addItemAboneToolStripMenuItem.Name = "addItemAboneToolStripMenuItem";
            this.addItemAboneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addItemAboneToolStripMenuItem.Text = "Add Keybind abowe";
            // 
            // addItemBelowToolStripMenuItem
            // 
            this.addItemBelowToolStripMenuItem.Name = "addItemBelowToolStripMenuItem";
            this.addItemBelowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addItemBelowToolStripMenuItem.Text = "Add Keybind below";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editItemToolStripMenuItem.Text = "Edit keybind";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem.Text = "Remove Keybind";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearAllToolStripMenuItem.Text = "Remove All";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1427, 684);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.customTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.KeybindBox.ResumeLayout(false);
            this.KeybindBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.FormHeader.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.BottomToolStrip.ResumeLayout(false);
            this.BottomToolStrip.PerformLayout();
            this.KeybindListContextmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel FormHeader;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.Label FormTitle;
        private Controls.CustomTabControl customTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel PaddingCuzFuckYou;
        private System.Windows.Forms.ToolStrip BottomToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox LoadedConfig;
        private System.Windows.Forms.GroupBox KeybindBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox PreviewRichtextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ActionTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox keylist;
        private System.Windows.Forms.ListView KeybindList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip KeybindListContextmenu;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addItemAboneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemBelowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
    }
}
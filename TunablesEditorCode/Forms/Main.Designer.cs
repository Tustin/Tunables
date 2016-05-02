namespace TunablesEditorCode
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.MessagesStrip = new System.Windows.Forms.StatusStrip();
            this.MessagesLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.EditMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pokeValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveTunable = new System.Windows.Forms.ToolStripMenuItem();
            this.TogglesMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.freeStuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noKickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableDLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.christmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valentinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.independenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshTunables = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutOpen = new System.Windows.Forms.Button();
            this.Manage = new System.Windows.Forms.Button();
            this.Alert = new System.Windows.Forms.ToolTip(this.components);
            this.dasTunables = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dasSearch = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.currentTunable = new System.Windows.Forms.GroupBox();
            this.tunableValue = new System.Windows.Forms.TextBox();
            this.pokeTunable = new System.Windows.Forms.Button();
            this.RegionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectBLUS = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectBLES = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectToPS3 = new System.Windows.Forms.ToolStripMenuItem();
            this.CCAPIConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.TMAPIConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MessagesStrip.SuspendLayout();
            this.EditMenu.SuspendLayout();
            this.TogglesMenu.SuspendLayout();
            this.currentTunable.SuspendLayout();
            this.ManageMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Selected: none";
            // 
            // MessagesStrip
            // 
            this.MessagesStrip.BackColor = System.Drawing.Color.Azure;
            this.MessagesStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MessagesLabel});
            this.MessagesStrip.Location = new System.Drawing.Point(0, 312);
            this.MessagesStrip.Name = "MessagesStrip";
            this.MessagesStrip.Size = new System.Drawing.Size(521, 22);
            this.MessagesStrip.SizingGrip = false;
            this.MessagesStrip.TabIndex = 34;
            this.MessagesStrip.Text = "statusStrip1";
            // 
            // MessagesLabel
            // 
            this.MessagesLabel.Image = ((System.Drawing.Image)(resources.GetObject("MessagesLabel.Image")));
            this.MessagesLabel.Name = "MessagesLabel";
            this.MessagesLabel.Size = new System.Drawing.Size(42, 17);
            this.MessagesLabel.Text = "Idle";
            // 
            // EditMenu
            // 
            this.EditMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokeValueToolStripMenuItem,
            this.RemoveTunable});
            this.EditMenu.Name = "contextMenuStrip1";
            this.EditMenu.Size = new System.Drawing.Size(68, 48);
            // 
            // pokeValueToolStripMenuItem
            // 
            this.pokeValueToolStripMenuItem.Name = "pokeValueToolStripMenuItem";
            this.pokeValueToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // RemoveTunable
            // 
            this.RemoveTunable.Name = "RemoveTunable";
            this.RemoveTunable.Size = new System.Drawing.Size(67, 22);
            // 
            // TogglesMenu
            // 
            this.TogglesMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TogglesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.freeStuffToolStripMenuItem,
            this.noKickToolStripMenuItem,
            this.enableDLCToolStripMenuItem});
            this.TogglesMenu.Name = "contextMenuStrip3";
            this.TogglesMenu.Size = new System.Drawing.Size(70, 70);
            // 
            // freeStuffToolStripMenuItem
            // 
            this.freeStuffToolStripMenuItem.Name = "freeStuffToolStripMenuItem";
            this.freeStuffToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            // 
            // noKickToolStripMenuItem
            // 
            this.noKickToolStripMenuItem.Name = "noKickToolStripMenuItem";
            this.noKickToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            // 
            // enableDLCToolStripMenuItem
            // 
            this.enableDLCToolStripMenuItem.Name = "enableDLCToolStripMenuItem";
            this.enableDLCToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            // 
            // christmasToolStripMenuItem
            // 
            this.christmasToolStripMenuItem.Name = "christmasToolStripMenuItem";
            this.christmasToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // valentinesToolStripMenuItem
            // 
            this.valentinesToolStripMenuItem.Name = "valentinesToolStripMenuItem";
            this.valentinesToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // independenceToolStripMenuItem
            // 
            this.independenceToolStripMenuItem.Name = "independenceToolStripMenuItem";
            this.independenceToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // RefreshTunables
            // 
            this.RefreshTunables.Name = "RefreshTunables";
            this.RefreshTunables.Size = new System.Drawing.Size(61, 4);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // AboutOpen
            // 
            this.AboutOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutOpen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AboutOpen.FlatAppearance.BorderSize = 0;
            this.AboutOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AboutOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AboutOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutOpen.Image = ((System.Drawing.Image)(resources.GetObject("AboutOpen.Image")));
            this.AboutOpen.Location = new System.Drawing.Point(65, 1);
            this.AboutOpen.Name = "AboutOpen";
            this.AboutOpen.Size = new System.Drawing.Size(82, 28);
            this.AboutOpen.TabIndex = 28;
            this.AboutOpen.Text = "About";
            this.AboutOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AboutOpen.UseVisualStyleBackColor = true;
            this.AboutOpen.Click += new System.EventHandler(this.AboutOpen_Click);
            // 
            // Manage
            // 
            this.Manage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Manage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Manage.FlatAppearance.BorderSize = 0;
            this.Manage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Manage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Manage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Manage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage.Image = ((System.Drawing.Image)(resources.GetObject("Manage.Image")));
            this.Manage.Location = new System.Drawing.Point(4, 1);
            this.Manage.Name = "Manage";
            this.Manage.Size = new System.Drawing.Size(55, 28);
            this.Manage.TabIndex = 30;
            this.Manage.Text = "PS3";
            this.Manage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Manage.UseVisualStyleBackColor = true;
            this.Manage.Click += new System.EventHandler(this.Manage_Click);
            // 
            // dasTunables
            // 
            this.dasTunables.Enabled = false;
            this.dasTunables.FormattingEnabled = true;
            this.dasTunables.Location = new System.Drawing.Point(4, 72);
            this.dasTunables.Name = "dasTunables";
            this.dasTunables.Size = new System.Drawing.Size(508, 186);
            this.dasTunables.TabIndex = 36;
            this.dasTunables.SelectedIndexChanged += new System.EventHandler(this.dasTunables_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Search:";
            // 
            // dasSearch
            // 
            this.dasSearch.Enabled = false;
            this.dasSearch.Location = new System.Drawing.Point(51, 50);
            this.dasSearch.Name = "dasSearch";
            this.dasSearch.Size = new System.Drawing.Size(458, 20);
            this.dasSearch.TabIndex = 38;
            this.dasSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dasSearch_KeyUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(586, 403);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 39;
            // 
            // currentTunable
            // 
            this.currentTunable.Controls.Add(this.tunableValue);
            this.currentTunable.Controls.Add(this.pokeTunable);
            this.currentTunable.Location = new System.Drawing.Point(4, 264);
            this.currentTunable.Name = "currentTunable";
            this.currentTunable.Size = new System.Drawing.Size(508, 44);
            this.currentTunable.TabIndex = 40;
            this.currentTunable.TabStop = false;
            this.currentTunable.Text = "Edit";
            // 
            // tunableValue
            // 
            this.tunableValue.Enabled = false;
            this.tunableValue.Location = new System.Drawing.Point(8, 19);
            this.tunableValue.Name = "tunableValue";
            this.tunableValue.Size = new System.Drawing.Size(281, 20);
            this.tunableValue.TabIndex = 2;
            // 
            // pokeTunable
            // 
            this.pokeTunable.Enabled = false;
            this.pokeTunable.Location = new System.Drawing.Point(425, 15);
            this.pokeTunable.Name = "pokeTunable";
            this.pokeTunable.Size = new System.Drawing.Size(75, 23);
            this.pokeTunable.TabIndex = 1;
            this.pokeTunable.Text = "Poke";
            this.pokeTunable.UseVisualStyleBackColor = true;
            this.pokeTunable.Click += new System.EventHandler(this.pokeTunable_Click);
            // 
            // RegionMenu
            // 
            this.RegionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectBLUS,
            this.SelectBLES});
            this.RegionMenu.Image = ((System.Drawing.Image)(resources.GetObject("RegionMenu.Image")));
            this.RegionMenu.Name = "RegionMenu";
            this.RegionMenu.Size = new System.Drawing.Size(182, 24);
            this.RegionMenu.Text = "Region...";
            this.RegionMenu.Visible = false;
            this.RegionMenu.Click += new System.EventHandler(this.RegionMenu_Click);
            // 
            // SelectBLUS
            // 
            this.SelectBLUS.Name = "SelectBLUS";
            this.SelectBLUS.Size = new System.Drawing.Size(152, 24);
            this.SelectBLUS.Text = "BLUS";
            this.SelectBLUS.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // SelectBLES
            // 
            this.SelectBLES.Name = "SelectBLES";
            this.SelectBLES.Size = new System.Drawing.Size(152, 24);
            this.SelectBLES.Text = "BLES";
            this.SelectBLES.Click += new System.EventHandler(this.SelectBLES_Click);
            // 
            // ConnectToPS3
            // 
            this.ConnectToPS3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CCAPIConnect,
            this.TMAPIConnect});
            this.ConnectToPS3.Enabled = false;
            this.ConnectToPS3.Image = ((System.Drawing.Image)(resources.GetObject("ConnectToPS3.Image")));
            this.ConnectToPS3.Name = "ConnectToPS3";
            this.ConnectToPS3.Size = new System.Drawing.Size(182, 24);
            this.ConnectToPS3.Text = "Connect to PS3...";
            // 
            // CCAPIConnect
            // 
            this.CCAPIConnect.Name = "CCAPIConnect";
            this.CCAPIConnect.Size = new System.Drawing.Size(156, 24);
            this.CCAPIConnect.Text = "CCAPI (CEX)";
            this.CCAPIConnect.Click += new System.EventHandler(this.cCAPICEXToolStripMenuItem_Click);
            // 
            // TMAPIConnect
            // 
            this.TMAPIConnect.Name = "TMAPIConnect";
            this.TMAPIConnect.Size = new System.Drawing.Size(156, 24);
            this.TMAPIConnect.Text = "TMAPI (DEX)";
            this.TMAPIConnect.Click += new System.EventHandler(this.TMAPIConnect_Click);
            // 
            // ManageMenu
            // 
            this.ManageMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ManageMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegionMenu,
            this.ConnectToPS3});
            this.ManageMenu.Name = "contextMenuStrip2";
            this.ManageMenu.Size = new System.Drawing.Size(183, 52);
            this.ManageMenu.Text = "Manager";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(521, 334);
            this.Controls.Add(this.currentTunable);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dasSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dasTunables);
            this.Controls.Add(this.MessagesStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AboutOpen);
            this.Controls.Add(this.Manage);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GTA V Tunables Editor 1.26 | Tustin";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MessagesStrip.ResumeLayout(false);
            this.MessagesStrip.PerformLayout();
            this.EditMenu.ResumeLayout(false);
            this.TogglesMenu.ResumeLayout(false);
            this.currentTunable.ResumeLayout(false);
            this.currentTunable.PerformLayout();
            this.ManageMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AboutOpen;
        private System.Windows.Forms.Button Manage;
        private System.Windows.Forms.StatusStrip MessagesStrip;
        private System.Windows.Forms.ContextMenuStrip EditMenu;
        private System.Windows.Forms.ToolStripMenuItem pokeValueToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip TogglesMenu;
        private System.Windows.Forms.ToolStripMenuItem freeStuffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noKickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableDLCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem christmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valentinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem independenceToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel MessagesLabel;
        private System.Windows.Forms.ContextMenuStrip RefreshTunables;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveTunable;
        private System.Windows.Forms.ToolTip Alert;
        private System.Windows.Forms.ListBox dasTunables;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dasSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox currentTunable;
        private System.Windows.Forms.Button pokeTunable;
        private System.Windows.Forms.TextBox tunableValue;
        private System.Windows.Forms.ToolStripMenuItem RegionMenu;
        private System.Windows.Forms.ToolStripMenuItem SelectBLUS;
        private System.Windows.Forms.ToolStripMenuItem SelectBLES;
        private System.Windows.Forms.ToolStripMenuItem ConnectToPS3;
        private System.Windows.Forms.ToolStripMenuItem CCAPIConnect;
        private System.Windows.Forms.ToolStripMenuItem TMAPIConnect;
        private System.Windows.Forms.ContextMenuStrip ManageMenu;
    }
}


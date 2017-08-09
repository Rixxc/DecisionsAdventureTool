namespace DescisionsAdventureTool
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fortsetzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ändernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hildeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fehlerMeldenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bekannteFehlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbCAdventures = new System.Windows.Forms.TabControl();
            this.tbPList = new System.Windows.Forms.TabPage();
            this.lvwAdventures = new System.Windows.Forms.ListView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeDetail = new System.Windows.Forms.TreeView();
            this.tbCDetail = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCopyAdventure = new System.Windows.Forms.Button();
            this.btnDeleteAdventure = new System.Windows.Forms.Button();
            this.btnSaveAdventure = new System.Windows.Forms.Button();
            this.btnNewAdventure = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tbCAdventures.SuspendLayout();
            this.tbPList.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbCDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.einstellungToolStripMenuItem,
            this.hildeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.fortsetzenToolStripMenuItem,
            this.exportierenToolStripMenuItem,
            this.kopierenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            this.neuToolStripMenuItem.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
            // 
            // fortsetzenToolStripMenuItem
            // 
            this.fortsetzenToolStripMenuItem.Name = "fortsetzenToolStripMenuItem";
            this.fortsetzenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.fortsetzenToolStripMenuItem.Text = "Fortsetzen";
            // 
            // exportierenToolStripMenuItem
            // 
            this.exportierenToolStripMenuItem.Name = "exportierenToolStripMenuItem";
            this.exportierenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exportierenToolStripMenuItem.Text = "Exportieren";
            this.exportierenToolStripMenuItem.Click += new System.EventHandler(this.exportierenToolStripMenuItem_Click);
            // 
            // kopierenToolStripMenuItem
            // 
            this.kopierenToolStripMenuItem.Name = "kopierenToolStripMenuItem";
            this.kopierenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.kopierenToolStripMenuItem.Text = "Kopieren";
            this.kopierenToolStripMenuItem.Click += new System.EventHandler(this.kopierenToolStripMenuItem_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ändernToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // ändernToolStripMenuItem
            // 
            this.ändernToolStripMenuItem.Name = "ändernToolStripMenuItem";
            this.ändernToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.ändernToolStripMenuItem.Text = "Ändern";
            this.ändernToolStripMenuItem.Click += new System.EventHandler(this.ändernToolStripMenuItem_Click);
            // 
            // einstellungToolStripMenuItem
            // 
            this.einstellungToolStripMenuItem.Name = "einstellungToolStripMenuItem";
            this.einstellungToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.einstellungToolStripMenuItem.Text = "Einstellung";
            // 
            // hildeToolStripMenuItem
            // 
            this.hildeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fehlerMeldenToolStripMenuItem,
            this.versionsToolStripMenuItem,
            this.bekannteFehlerToolStripMenuItem});
            this.hildeToolStripMenuItem.Name = "hildeToolStripMenuItem";
            this.hildeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hildeToolStripMenuItem.Text = "Hilfe";
            // 
            // fehlerMeldenToolStripMenuItem
            // 
            this.fehlerMeldenToolStripMenuItem.Name = "fehlerMeldenToolStripMenuItem";
            this.fehlerMeldenToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.fehlerMeldenToolStripMenuItem.Text = "Fehler melden";
            // 
            // versionsToolStripMenuItem
            // 
            this.versionsToolStripMenuItem.Name = "versionsToolStripMenuItem";
            this.versionsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.versionsToolStripMenuItem.Text = "Versionshinweise";
            // 
            // bekannteFehlerToolStripMenuItem
            // 
            this.bekannteFehlerToolStripMenuItem.Name = "bekannteFehlerToolStripMenuItem";
            this.bekannteFehlerToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.bekannteFehlerToolStripMenuItem.Text = "Bekannte Fehler";
            // 
            // tbCAdventures
            // 
            this.tbCAdventures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCAdventures.Controls.Add(this.tbPList);
            this.tbCAdventures.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCAdventures.Location = new System.Drawing.Point(13, 79);
            this.tbCAdventures.Name = "tbCAdventures";
            this.tbCAdventures.SelectedIndex = 0;
            this.tbCAdventures.Size = new System.Drawing.Size(254, 466);
            this.tbCAdventures.TabIndex = 1;
            // 
            // tbPList
            // 
            this.tbPList.Controls.Add(this.lvwAdventures);
            this.tbPList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPList.Location = new System.Drawing.Point(4, 22);
            this.tbPList.Name = "tbPList";
            this.tbPList.Padding = new System.Windows.Forms.Padding(3);
            this.tbPList.Size = new System.Drawing.Size(246, 440);
            this.tbPList.TabIndex = 0;
            this.tbPList.Text = "Abenteuer";
            this.tbPList.UseVisualStyleBackColor = true;
            // 
            // lvwAdventures
            // 
            this.lvwAdventures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwAdventures.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwAdventures.HideSelection = false;
            this.lvwAdventures.Location = new System.Drawing.Point(3, 3);
            this.lvwAdventures.Name = "lvwAdventures";
            this.lvwAdventures.Size = new System.Drawing.Size(240, 434);
            this.lvwAdventures.TabIndex = 0;
            this.lvwAdventures.UseCompatibleStateImageBehavior = false;
            this.lvwAdventures.View = System.Windows.Forms.View.List;
            this.lvwAdventures.SelectedIndexChanged += new System.EventHandler(this.lvwAdventures_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeDetail);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(524, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Einzelschritte";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // treeDetail
            // 
            this.treeDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeDetail.Location = new System.Drawing.Point(3, 3);
            this.treeDetail.Name = "treeDetail";
            this.treeDetail.Size = new System.Drawing.Size(518, 434);
            this.treeDetail.TabIndex = 0;
            // 
            // tbCDetail
            // 
            this.tbCDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCDetail.Controls.Add(this.tabPage1);
            this.tbCDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCDetail.Location = new System.Drawing.Point(269, 79);
            this.tbCDetail.Name = "tbCDetail";
            this.tbCDetail.SelectedIndex = 0;
            this.tbCDetail.Size = new System.Drawing.Size(532, 466);
            this.tbCDetail.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCopyAdventure);
            this.panel1.Controls.Add(this.btnDeleteAdventure);
            this.panel1.Controls.Add(this.btnSaveAdventure);
            this.panel1.Controls.Add(this.btnNewAdventure);
            this.panel1.Location = new System.Drawing.Point(13, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 46);
            this.panel1.TabIndex = 3;
            // 
            // btnCopyAdventure
            // 
            this.btnCopyAdventure.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCopyAdventure.BackgroundImage")));
            this.btnCopyAdventure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopyAdventure.Location = new System.Drawing.Point(141, 3);
            this.btnCopyAdventure.Name = "btnCopyAdventure";
            this.btnCopyAdventure.Size = new System.Drawing.Size(40, 40);
            this.btnCopyAdventure.TabIndex = 3;
            this.btnCopyAdventure.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAdventure
            // 
            this.btnDeleteAdventure.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteAdventure.BackgroundImage")));
            this.btnDeleteAdventure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteAdventure.Location = new System.Drawing.Point(95, 3);
            this.btnDeleteAdventure.Name = "btnDeleteAdventure";
            this.btnDeleteAdventure.Size = new System.Drawing.Size(40, 40);
            this.btnDeleteAdventure.TabIndex = 2;
            this.btnDeleteAdventure.UseVisualStyleBackColor = true;
            // 
            // btnSaveAdventure
            // 
            this.btnSaveAdventure.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveAdventure.BackgroundImage")));
            this.btnSaveAdventure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveAdventure.Location = new System.Drawing.Point(49, 3);
            this.btnSaveAdventure.Name = "btnSaveAdventure";
            this.btnSaveAdventure.Size = new System.Drawing.Size(40, 40);
            this.btnSaveAdventure.TabIndex = 1;
            this.btnSaveAdventure.UseVisualStyleBackColor = true;
            // 
            // btnNewAdventure
            // 
            this.btnNewAdventure.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewAdventure.BackgroundImage")));
            this.btnNewAdventure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewAdventure.Location = new System.Drawing.Point(3, 3);
            this.btnNewAdventure.Name = "btnNewAdventure";
            this.btnNewAdventure.Size = new System.Drawing.Size(40, 40);
            this.btnNewAdventure.TabIndex = 0;
            this.btnNewAdventure.UseVisualStyleBackColor = true;
            this.btnNewAdventure.Click += new System.EventHandler(this.btnNewAdventure_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 557);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbCDetail);
            this.Controls.Add(this.tbCAdventures);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(829, 596);
            this.MinimumSize = new System.Drawing.Size(829, 596);
            this.Name = "frmMain";
            this.Text = "Decisions Adventure Tool 1.0.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbCAdventures.ResumeLayout(false);
            this.tbPList.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tbCDetail.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hildeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fortsetzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ändernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fehlerMeldenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bekannteFehlerToolStripMenuItem;
        private System.Windows.Forms.TabControl tbCAdventures;
        private System.Windows.Forms.TabPage tbPList;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tbCDetail;
        private System.Windows.Forms.ListView lvwAdventures;
        private System.Windows.Forms.TreeView treeDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewAdventure;
        private System.Windows.Forms.Button btnSaveAdventure;
        private System.Windows.Forms.Button btnDeleteAdventure;
        private System.Windows.Forms.Button btnCopyAdventure;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


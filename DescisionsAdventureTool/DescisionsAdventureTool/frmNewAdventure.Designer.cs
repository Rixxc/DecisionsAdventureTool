namespace DescisionsAdventureTool
{
    partial class frmNewAdventure
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
            this.tbCTree = new System.Windows.Forms.TabControl();
            this.tbPTree = new System.Windows.Forms.TabPage();
            this.treeChoices = new System.Windows.Forms.TreeView();
            this.tbCTextEditor = new System.Windows.Forms.TabControl();
            this.tbPText = new System.Windows.Forms.TabPage();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.tbCData = new System.Windows.Forms.TabControl();
            this.tbPData = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSectionTitel = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnNewPath = new System.Windows.Forms.Button();
            this.btnDeletePath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lvwOptions = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbSectionID = new System.Windows.Forms.ComboBox();
            this.tbCTree.SuspendLayout();
            this.tbPTree.SuspendLayout();
            this.tbCTextEditor.SuspendLayout();
            this.tbPText.SuspendLayout();
            this.tbCData.SuspendLayout();
            this.tbPData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCTree
            // 
            this.tbCTree.Controls.Add(this.tbPTree);
            this.tbCTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCTree.Location = new System.Drawing.Point(13, 13);
            this.tbCTree.Name = "tbCTree";
            this.tbCTree.SelectedIndex = 0;
            this.tbCTree.Size = new System.Drawing.Size(183, 617);
            this.tbCTree.TabIndex = 0;
            // 
            // tbPTree
            // 
            this.tbPTree.Controls.Add(this.treeChoices);
            this.tbPTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPTree.Location = new System.Drawing.Point(4, 22);
            this.tbPTree.Name = "tbPTree";
            this.tbPTree.Padding = new System.Windows.Forms.Padding(3);
            this.tbPTree.Size = new System.Drawing.Size(175, 591);
            this.tbPTree.TabIndex = 0;
            this.tbPTree.Text = "Wege";
            this.tbPTree.UseVisualStyleBackColor = true;
            // 
            // treeChoices
            // 
            this.treeChoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeChoices.Location = new System.Drawing.Point(3, 3);
            this.treeChoices.Name = "treeChoices";
            this.treeChoices.Size = new System.Drawing.Size(169, 585);
            this.treeChoices.TabIndex = 0;
            // 
            // tbCTextEditor
            // 
            this.tbCTextEditor.Controls.Add(this.tbPText);
            this.tbCTextEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCTextEditor.Location = new System.Drawing.Point(215, 13);
            this.tbCTextEditor.Name = "tbCTextEditor";
            this.tbCTextEditor.SelectedIndex = 0;
            this.tbCTextEditor.Size = new System.Drawing.Size(396, 617);
            this.tbCTextEditor.TabIndex = 1;
            // 
            // tbPText
            // 
            this.tbPText.Controls.Add(this.txtEditor);
            this.tbPText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPText.Location = new System.Drawing.Point(4, 22);
            this.tbPText.Name = "tbPText";
            this.tbPText.Padding = new System.Windows.Forms.Padding(3);
            this.tbPText.Size = new System.Drawing.Size(388, 591);
            this.tbPText.TabIndex = 0;
            this.tbPText.Text = "Text Editor";
            this.tbPText.UseVisualStyleBackColor = true;
            // 
            // txtEditor
            // 
            this.txtEditor.Location = new System.Drawing.Point(6, 6);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(376, 582);
            this.txtEditor.TabIndex = 0;
            // 
            // tbCData
            // 
            this.tbCData.Controls.Add(this.tbPData);
            this.tbCData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCData.Location = new System.Drawing.Point(617, 13);
            this.tbCData.Name = "tbCData";
            this.tbCData.SelectedIndex = 0;
            this.tbCData.Size = new System.Drawing.Size(186, 547);
            this.tbCData.TabIndex = 4;
            // 
            // tbPData
            // 
            this.tbPData.Controls.Add(this.cmbSectionID);
            this.tbPData.Controls.Add(this.button2);
            this.tbPData.Controls.Add(this.button1);
            this.tbPData.Controls.Add(this.lvwOptions);
            this.tbPData.Controls.Add(this.label4);
            this.tbPData.Controls.Add(this.cmbSex);
            this.tbPData.Controls.Add(this.label3);
            this.tbPData.Controls.Add(this.label2);
            this.tbPData.Controls.Add(this.txtSectionTitel);
            this.tbPData.Controls.Add(this.label1);
            this.tbPData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPData.Location = new System.Drawing.Point(4, 22);
            this.tbPData.Name = "tbPData";
            this.tbPData.Padding = new System.Windows.Forms.Padding(3);
            this.tbPData.Size = new System.Drawing.Size(178, 521);
            this.tbPData.TabIndex = 0;
            this.tbPData.Text = "Daten";
            this.tbPData.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(617, 601);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Fertig Stellen";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(713, 601);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 29);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Beenden";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abschnitt Titel:";
            // 
            // txtSectionTitel
            // 
            this.txtSectionTitel.Location = new System.Drawing.Point(6, 23);
            this.txtSectionTitel.Name = "txtSectionTitel";
            this.txtSectionTitel.Size = new System.Drawing.Size(166, 20);
            this.txtSectionTitel.TabIndex = 1;
            // 
            // toolTip
            // 
            this.toolTip.ShowAlways = true;
            // 
            // btnNewPath
            // 
            this.btnNewPath.Location = new System.Drawing.Point(617, 566);
            this.btnNewPath.Name = "btnNewPath";
            this.btnNewPath.Size = new System.Drawing.Size(86, 29);
            this.btnNewPath.TabIndex = 7;
            this.btnNewPath.Text = "Neuer Weg";
            this.btnNewPath.UseVisualStyleBackColor = true;
            // 
            // btnDeletePath
            // 
            this.btnDeletePath.Location = new System.Drawing.Point(713, 566);
            this.btnDeletePath.Name = "btnDeletePath";
            this.btnDeletePath.Size = new System.Drawing.Size(86, 29);
            this.btnDeletePath.TabIndex = 8;
            this.btnDeletePath.Text = "Weg löschen";
            this.btnDeletePath.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Abschnitt-ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Geschlecht";
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "Männlich",
            "Weiblich"});
            this.cmbSex.Location = new System.Drawing.Point(6, 122);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(166, 21);
            this.cmbSex.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mögliche Optionen:";
            // 
            // lvwOptions
            // 
            this.lvwOptions.Location = new System.Drawing.Point(6, 170);
            this.lvwOptions.Name = "lvwOptions";
            this.lvwOptions.Size = new System.Drawing.Size(166, 310);
            this.lvwOptions.TabIndex = 7;
            this.lvwOptions.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Hinzufügen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "Entfernen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmbSectionID
            // 
            this.cmbSectionID.FormattingEnabled = true;
            this.cmbSectionID.Location = new System.Drawing.Point(6, 73);
            this.cmbSectionID.Name = "cmbSectionID";
            this.cmbSectionID.Size = new System.Drawing.Size(166, 21);
            this.cmbSectionID.TabIndex = 11;
            // 
            // frmNewAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 642);
            this.Controls.Add(this.btnDeletePath);
            this.Controls.Add(this.btnNewPath);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbCData);
            this.Controls.Add(this.tbCTextEditor);
            this.Controls.Add(this.tbCTree);
            this.MaximumSize = new System.Drawing.Size(831, 681);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(831, 681);
            this.Name = "frmNewAdventure";
            this.Text = "Neues Abenteuer";
            this.tbCTree.ResumeLayout(false);
            this.tbPTree.ResumeLayout(false);
            this.tbCTextEditor.ResumeLayout(false);
            this.tbPText.ResumeLayout(false);
            this.tbPText.PerformLayout();
            this.tbCData.ResumeLayout(false);
            this.tbPData.ResumeLayout(false);
            this.tbPData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCTree;
        private System.Windows.Forms.TabPage tbPTree;
        private System.Windows.Forms.TreeView treeChoices;
        private System.Windows.Forms.TabControl tbCTextEditor;
        private System.Windows.Forms.TabPage tbPText;
        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.TabControl tbCData;
        private System.Windows.Forms.TabPage tbPData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSectionTitel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnNewPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeletePath;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvwOptions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSectionID;
    }
}
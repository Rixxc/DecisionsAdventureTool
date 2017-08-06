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
            this.txtSectionID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSectionTitel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSetting = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdventureName = new System.Windows.Forms.TextBox();
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
            this.tbCTree.Size = new System.Drawing.Size(598, 227);
            this.tbCTree.TabIndex = 0;
            // 
            // tbPTree
            // 
            this.tbPTree.Controls.Add(this.treeChoices);
            this.tbPTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPTree.Location = new System.Drawing.Point(4, 22);
            this.tbPTree.Name = "tbPTree";
            this.tbPTree.Padding = new System.Windows.Forms.Padding(3);
            this.tbPTree.Size = new System.Drawing.Size(590, 201);
            this.tbPTree.TabIndex = 0;
            this.tbPTree.Text = "Wege";
            this.tbPTree.UseVisualStyleBackColor = true;
            // 
            // treeChoices
            // 
            this.treeChoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeChoices.HideSelection = false;
            this.treeChoices.Location = new System.Drawing.Point(3, 3);
            this.treeChoices.Name = "treeChoices";
            this.treeChoices.Size = new System.Drawing.Size(584, 195);
            this.treeChoices.TabIndex = 0;
            this.treeChoices.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeChoices_AfterSelect);
            // 
            // tbCTextEditor
            // 
            this.tbCTextEditor.Controls.Add(this.tbPText);
            this.tbCTextEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCTextEditor.Location = new System.Drawing.Point(12, 246);
            this.tbCTextEditor.Name = "tbCTextEditor";
            this.tbCTextEditor.SelectedIndex = 0;
            this.tbCTextEditor.Size = new System.Drawing.Size(595, 384);
            this.tbCTextEditor.TabIndex = 1;
            // 
            // tbPText
            // 
            this.tbPText.Controls.Add(this.txtEditor);
            this.tbPText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPText.Location = new System.Drawing.Point(4, 22);
            this.tbPText.Name = "tbPText";
            this.tbPText.Padding = new System.Windows.Forms.Padding(3);
            this.tbPText.Size = new System.Drawing.Size(587, 358);
            this.tbPText.TabIndex = 0;
            this.tbPText.Text = "Text Editor";
            this.tbPText.UseVisualStyleBackColor = true;
            // 
            // txtEditor
            // 
            this.txtEditor.Location = new System.Drawing.Point(4, 6);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(577, 346);
            this.txtEditor.TabIndex = 0;
            this.txtEditor.TextChanged += new System.EventHandler(this.txtEditor_TextChanged);
            // 
            // tbCData
            // 
            this.tbCData.Controls.Add(this.tbPData);
            this.tbCData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCData.Location = new System.Drawing.Point(617, 13);
            this.tbCData.Name = "tbCData";
            this.tbCData.SelectedIndex = 0;
            this.tbCData.Size = new System.Drawing.Size(186, 582);
            this.tbCData.TabIndex = 4;
            // 
            // tbPData
            // 
            this.tbPData.Controls.Add(this.txtAdventureName);
            this.tbPData.Controls.Add(this.label5);
            this.tbPData.Controls.Add(this.cmbSetting);
            this.tbPData.Controls.Add(this.label4);
            this.tbPData.Controls.Add(this.txtSectionID);
            this.tbPData.Controls.Add(this.button2);
            this.tbPData.Controls.Add(this.button1);
            this.tbPData.Controls.Add(this.cmbSex);
            this.tbPData.Controls.Add(this.label3);
            this.tbPData.Controls.Add(this.label2);
            this.tbPData.Controls.Add(this.txtSectionTitel);
            this.tbPData.Controls.Add(this.label1);
            this.tbPData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPData.Location = new System.Drawing.Point(4, 22);
            this.tbPData.Name = "tbPData";
            this.tbPData.Padding = new System.Windows.Forms.Padding(3);
            this.tbPData.Size = new System.Drawing.Size(178, 556);
            this.tbPData.TabIndex = 0;
            this.tbPData.Text = "Daten";
            this.tbPData.UseVisualStyleBackColor = true;
            // 
            // txtSectionID
            // 
            this.txtSectionID.Enabled = false;
            this.txtSectionID.Location = new System.Drawing.Point(6, 73);
            this.txtSectionID.Name = "txtSectionID";
            this.txtSectionID.Size = new System.Drawing.Size(166, 20);
            this.txtSectionID.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 521);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "Entfernen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Hinzufügen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Geschlecht";
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
            // txtSectionTitel
            // 
            this.txtSectionTitel.Location = new System.Drawing.Point(6, 23);
            this.txtSectionTitel.Name = "txtSectionTitel";
            this.txtSectionTitel.Size = new System.Drawing.Size(166, 20);
            this.txtSectionTitel.TabIndex = 1;
            this.txtSectionTitel.TextChanged += new System.EventHandler(this.txtSectionTitel_TextChanged);
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(617, 601);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Fertig Stellen";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // toolTip
            // 
            this.toolTip.ShowAlways = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Szenario";
            // 
            // cmbSetting
            // 
            this.cmbSetting.FormattingEnabled = true;
            this.cmbSetting.Location = new System.Drawing.Point(6, 170);
            this.cmbSetting.Name = "cmbSetting";
            this.cmbSetting.Size = new System.Drawing.Size(165, 21);
            this.cmbSetting.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Abenteuer Name";
            // 
            // txtAdventureName
            // 
            this.txtAdventureName.Location = new System.Drawing.Point(6, 219);
            this.txtAdventureName.Name = "txtAdventureName";
            this.txtAdventureName.Size = new System.Drawing.Size(165, 20);
            this.txtAdventureName.TabIndex = 15;
            // 
            // frmNewAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 642);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbCData);
            this.Controls.Add(this.tbCTextEditor);
            this.Controls.Add(this.tbCTree);
            this.MaximumSize = new System.Drawing.Size(831, 681);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(831, 681);
            this.Name = "frmNewAdventure";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSectionID;
        private System.Windows.Forms.TextBox txtAdventureName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSetting;
        private System.Windows.Forms.Label label4;
    }
}
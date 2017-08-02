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
            this.tbCRequirement = new System.Windows.Forms.TabControl();
            this.tbRequirement = new System.Windows.Forms.TabPage();
            this.checkStrength = new System.Windows.Forms.CheckBox();
            this.numStrength = new System.Windows.Forms.NumericUpDown();
            this.numEndurance = new System.Windows.Forms.NumericUpDown();
            this.checkEndurance = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkIntelligence = new System.Windows.Forms.CheckBox();
            this.numDexterity = new System.Windows.Forms.NumericUpDown();
            this.checkDexterity = new System.Windows.Forms.CheckBox();
            this.numBrave = new System.Windows.Forms.NumericUpDown();
            this.checkBrave = new System.Windows.Forms.CheckBox();
            this.tbCInventory = new System.Windows.Forms.TabControl();
            this.tbPInventoryRequirements = new System.Windows.Forms.TabPage();
            this.tbCData = new System.Windows.Forms.TabControl();
            this.tbPData = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSectionTitel = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnNewPath = new System.Windows.Forms.Button();
            this.btnDeletePath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSectionID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbCTree.SuspendLayout();
            this.tbPTree.SuspendLayout();
            this.tbCTextEditor.SuspendLayout();
            this.tbPText.SuspendLayout();
            this.tbCRequirement.SuspendLayout();
            this.tbRequirement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndurance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDexterity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrave)).BeginInit();
            this.tbCInventory.SuspendLayout();
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
            // tbCRequirement
            // 
            this.tbCRequirement.Controls.Add(this.tbRequirement);
            this.tbCRequirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCRequirement.Location = new System.Drawing.Point(628, 13);
            this.tbCRequirement.Name = "tbCRequirement";
            this.tbCRequirement.SelectedIndex = 0;
            this.tbCRequirement.Size = new System.Drawing.Size(200, 285);
            this.tbCRequirement.TabIndex = 2;
            // 
            // tbRequirement
            // 
            this.tbRequirement.Controls.Add(this.numBrave);
            this.tbRequirement.Controls.Add(this.checkBrave);
            this.tbRequirement.Controls.Add(this.numDexterity);
            this.tbRequirement.Controls.Add(this.checkDexterity);
            this.tbRequirement.Controls.Add(this.numericUpDown1);
            this.tbRequirement.Controls.Add(this.checkIntelligence);
            this.tbRequirement.Controls.Add(this.numEndurance);
            this.tbRequirement.Controls.Add(this.checkEndurance);
            this.tbRequirement.Controls.Add(this.numStrength);
            this.tbRequirement.Controls.Add(this.checkStrength);
            this.tbRequirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRequirement.Location = new System.Drawing.Point(4, 22);
            this.tbRequirement.Name = "tbRequirement";
            this.tbRequirement.Padding = new System.Windows.Forms.Padding(3);
            this.tbRequirement.Size = new System.Drawing.Size(192, 259);
            this.tbRequirement.TabIndex = 0;
            this.tbRequirement.Text = "Attribut Vorraussetzungen";
            this.tbRequirement.UseVisualStyleBackColor = true;
            // 
            // checkStrength
            // 
            this.checkStrength.AutoSize = true;
            this.checkStrength.Location = new System.Drawing.Point(7, 7);
            this.checkStrength.Name = "checkStrength";
            this.checkStrength.Size = new System.Drawing.Size(57, 17);
            this.checkStrength.TabIndex = 0;
            this.checkStrength.Text = "Stärke";
            this.checkStrength.UseVisualStyleBackColor = true;
            // 
            // numStrength
            // 
            this.numStrength.Location = new System.Drawing.Point(39, 30);
            this.numStrength.Name = "numStrength";
            this.numStrength.Size = new System.Drawing.Size(48, 20);
            this.numStrength.TabIndex = 1;
            // 
            // numEndurance
            // 
            this.numEndurance.Location = new System.Drawing.Point(39, 79);
            this.numEndurance.Name = "numEndurance";
            this.numEndurance.Size = new System.Drawing.Size(48, 20);
            this.numEndurance.TabIndex = 3;
            // 
            // checkEndurance
            // 
            this.checkEndurance.AutoSize = true;
            this.checkEndurance.Location = new System.Drawing.Point(7, 56);
            this.checkEndurance.Name = "checkEndurance";
            this.checkEndurance.Size = new System.Drawing.Size(71, 17);
            this.checkEndurance.TabIndex = 2;
            this.checkEndurance.Text = "Ausdauer";
            this.checkEndurance.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(39, 128);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // checkIntelligence
            // 
            this.checkIntelligence.AutoSize = true;
            this.checkIntelligence.Location = new System.Drawing.Point(7, 105);
            this.checkIntelligence.Name = "checkIntelligence";
            this.checkIntelligence.Size = new System.Drawing.Size(73, 17);
            this.checkIntelligence.TabIndex = 4;
            this.checkIntelligence.Text = "Intelligenz";
            this.checkIntelligence.UseVisualStyleBackColor = true;
            // 
            // numDexterity
            // 
            this.numDexterity.Location = new System.Drawing.Point(39, 177);
            this.numDexterity.Name = "numDexterity";
            this.numDexterity.Size = new System.Drawing.Size(48, 20);
            this.numDexterity.TabIndex = 7;
            // 
            // checkDexterity
            // 
            this.checkDexterity.AutoSize = true;
            this.checkDexterity.Location = new System.Drawing.Point(7, 154);
            this.checkDexterity.Name = "checkDexterity";
            this.checkDexterity.Size = new System.Drawing.Size(104, 17);
            this.checkDexterity.TabIndex = 6;
            this.checkDexterity.Text = "Geschicklichkeit";
            this.checkDexterity.UseVisualStyleBackColor = true;
            // 
            // numBrave
            // 
            this.numBrave.Location = new System.Drawing.Point(39, 226);
            this.numBrave.Name = "numBrave";
            this.numBrave.Size = new System.Drawing.Size(48, 20);
            this.numBrave.TabIndex = 9;
            // 
            // checkBrave
            // 
            this.checkBrave.AutoSize = true;
            this.checkBrave.Location = new System.Drawing.Point(7, 203);
            this.checkBrave.Name = "checkBrave";
            this.checkBrave.Size = new System.Drawing.Size(44, 17);
            this.checkBrave.TabIndex = 8;
            this.checkBrave.Text = "Mut";
            this.checkBrave.UseVisualStyleBackColor = true;
            // 
            // tbCInventory
            // 
            this.tbCInventory.Controls.Add(this.tbPInventoryRequirements);
            this.tbCInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCInventory.Location = new System.Drawing.Point(628, 305);
            this.tbCInventory.Name = "tbCInventory";
            this.tbCInventory.SelectedIndex = 0;
            this.tbCInventory.Size = new System.Drawing.Size(200, 325);
            this.tbCInventory.TabIndex = 3;
            // 
            // tbPInventoryRequirements
            // 
            this.tbPInventoryRequirements.Location = new System.Drawing.Point(4, 22);
            this.tbPInventoryRequirements.Name = "tbPInventoryRequirements";
            this.tbPInventoryRequirements.Padding = new System.Windows.Forms.Padding(3);
            this.tbPInventoryRequirements.Size = new System.Drawing.Size(192, 299);
            this.tbPInventoryRequirements.TabIndex = 0;
            this.tbPInventoryRequirements.Text = "Inventar Vorrausetzungen";
            this.tbPInventoryRequirements.UseVisualStyleBackColor = true;
            // 
            // tbCData
            // 
            this.tbCData.Controls.Add(this.tbPData);
            this.tbCData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCData.Location = new System.Drawing.Point(852, 13);
            this.tbCData.Name = "tbCData";
            this.tbCData.SelectedIndex = 0;
            this.tbCData.Size = new System.Drawing.Size(186, 547);
            this.tbCData.TabIndex = 4;
            // 
            // tbPData
            // 
            this.tbPData.Controls.Add(this.comboBox1);
            this.tbPData.Controls.Add(this.label3);
            this.tbPData.Controls.Add(this.txtSectionID);
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
            this.btnSave.Location = new System.Drawing.Point(852, 601);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Fertig Stellen";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(948, 601);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 29);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Beenden";
            this.btnCancel.UseVisualStyleBackColor = true;
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
            this.btnNewPath.Location = new System.Drawing.Point(852, 566);
            this.btnNewPath.Name = "btnNewPath";
            this.btnNewPath.Size = new System.Drawing.Size(86, 29);
            this.btnNewPath.TabIndex = 7;
            this.btnNewPath.Text = "Neuer Weg";
            this.btnNewPath.UseVisualStyleBackColor = true;
            // 
            // btnDeletePath
            // 
            this.btnDeletePath.Location = new System.Drawing.Point(948, 566);
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
            // txtSectionID
            // 
            this.txtSectionID.Location = new System.Drawing.Point(6, 72);
            this.txtSectionID.Name = "txtSectionID";
            this.txtSectionID.Size = new System.Drawing.Size(166, 20);
            this.txtSectionID.TabIndex = 3;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Männlich",
            "Weiblich"});
            this.comboBox1.Location = new System.Drawing.Point(6, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // frmNewAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 642);
            this.Controls.Add(this.btnDeletePath);
            this.Controls.Add(this.btnNewPath);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbCData);
            this.Controls.Add(this.tbCInventory);
            this.Controls.Add(this.tbCRequirement);
            this.Controls.Add(this.tbCTextEditor);
            this.Controls.Add(this.tbCTree);
            this.Name = "frmNewAdventure";
            this.Text = "Neues Abenteuer";
            this.tbCTree.ResumeLayout(false);
            this.tbPTree.ResumeLayout(false);
            this.tbCTextEditor.ResumeLayout(false);
            this.tbPText.ResumeLayout(false);
            this.tbPText.PerformLayout();
            this.tbCRequirement.ResumeLayout(false);
            this.tbRequirement.ResumeLayout(false);
            this.tbRequirement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndurance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDexterity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrave)).EndInit();
            this.tbCInventory.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tbCRequirement;
        private System.Windows.Forms.TabPage tbRequirement;
        private System.Windows.Forms.NumericUpDown numBrave;
        private System.Windows.Forms.CheckBox checkBrave;
        private System.Windows.Forms.NumericUpDown numDexterity;
        private System.Windows.Forms.CheckBox checkDexterity;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkIntelligence;
        private System.Windows.Forms.NumericUpDown numEndurance;
        private System.Windows.Forms.CheckBox checkEndurance;
        private System.Windows.Forms.NumericUpDown numStrength;
        private System.Windows.Forms.CheckBox checkStrength;
        private System.Windows.Forms.TabControl tbCInventory;
        private System.Windows.Forms.TabPage tbPInventoryRequirements;
        private System.Windows.Forms.TabControl tbCData;
        private System.Windows.Forms.TabPage tbPData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSectionTitel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnNewPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeletePath;
        private System.Windows.Forms.TextBox txtSectionID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}
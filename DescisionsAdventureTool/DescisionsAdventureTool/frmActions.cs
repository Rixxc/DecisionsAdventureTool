﻿using System;
using System.Linq;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace DescisionsAdventureTool
{
    public partial class frmActions : Form
    {
        //int IDCounter;
        clsActions Action;
        int intActionCounter;
        string Connection;
        MySqlConnection con;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable dt;
        public frmActions(int ID)
        {
            InitializeComponent();
            #region Init
            intActionCounter = ID;
            Connection = @"host=localhost;user=root;database=itemsystem";
            con = new MySqlConnection(Connection);
            command = new MySqlCommand("SELECT name AS Name, typ AS Typ FROM items", con);
            adapter = new MySqlDataAdapter(command);
            dt = new DataTable();
            Action = new clsActions();
            try
            {
                con.OpenAsync();
                adapter.Fill(dt);
            }
            catch (Exception)
            {

                throw;
            }
            //IDCounter = 0;
            #endregion
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool failed = false;
            #region Check for attribute requirement

            if (checkBrave.Checked)
            {
                Action.intBraveReq = Convert.ToInt32(numBrave.Value);
            }

            if (checkDexterity.Checked)
            {
                Action.intDexterityReq = Convert.ToInt32(numDexterity.Value);
            }

            if (checkEndurance.Checked)
            {
                Action.intEnduranceReq = Convert.ToInt32(numEndurance.Value);
            }

            if (checkIntelligence.Checked)
            {
                Action.intIntelligenceReq = Convert.ToInt32(numIntelligence.Value);
            }

            if (checkStrength.Checked)
            {
                Action.intStrengthReq = Convert.ToInt32(numStrength.Value);
            }
            #endregion
            #region Data
            if (txtSectionID.Text == "")
            {
                for (int i = 0; i < 1000; i++)
                {
                    if (frmNewAdventure.Actions[i,0] == intActionCounter)
                    {
                        intActionCounter++;
                        i = -1;
                    }
                }
                Action.intActionID = intActionCounter;
                intActionCounter++;
            }
            else
            {
                for (int i = 0; i < 1000; i++)
                {
                    if (frmNewAdventure.Actions[i, 0] == Convert.ToInt32(txtSectionID.Text))
                    {
                        MessageBox.Show("Die ID wird bereits von einem Weg verwendet.");
                        failed = true;
                    }
                    else if(Convert.ToInt32(txtSectionID.Text) == 0)
                    {
                        MessageBox.Show("Die ID der Action darf nicht 0 sein.");
                        failed = true;
                    }
                }
                Action.intActionID = Convert.ToInt32(txtSectionID.Text);
            }

            if (txtActionTitle.Text == "")
            {
                MessageBox.Show("Das Feld Aktion darf nicht Leer sein da diese im Spiel angezeigt wird");
                failed = true;
            }
            else
            {
                for (int i = 0; i < 1000; i++)
                {
                    if (frmNewAdventure.ActionTitles[i] == txtActionTitle.Text)
                    {
                        MessageBox.Show("Der Titel wird bereits von einem Weg verwendet.");
                        failed = true;
                    }
                }
                Action.strActionName = txtActionTitle.Text;
            }
            #endregion
            if (failed == false)
            {
                frmNewAdventure.flag = true;
                this.setActions();
                this.Close();
            }
        }

        private void txtSectionID_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (!Char.IsNumber(txtSectionID.Text.Last()))
                {
                    txtSectionID.Text = txtSectionID.Text.Remove(txtSectionID.Text.Length - 1, 1);
                    txtSectionID.SelectionStart = txtSectionID.Text.Length;
                }
            }
            catch
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void setActions()
        {
            frmNewAdventure.Actions[frmNewAdventure.PathCounter, 0] = Action.intActionID;
            frmNewAdventure.Actions[frmNewAdventure.PathCounter, 1] = Action.intStrengthReq;
            frmNewAdventure.Actions[frmNewAdventure.PathCounter, 2] = Action.intEnduranceReq;
            frmNewAdventure.Actions[frmNewAdventure.PathCounter, 3] = Action.intIntelligenceReq;
            frmNewAdventure.Actions[frmNewAdventure.PathCounter, 4] = Action.intDexterityReq;
            frmNewAdventure.Actions[frmNewAdventure.PathCounter, 5] = Action.intBraveReq;
            frmNewAdventure.ActionTitles[frmNewAdventure.PathCounter] = Action.strActionName;
            if (checkBacktracking.Checked)
            {
                frmNewAdventure.BackTrack = true;
            }
        }
    }
}

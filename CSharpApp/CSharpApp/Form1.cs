using CSharpApp.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpApp
{
    public partial class Form1 : Form
    {
        private Color PANEL_COLOR = System.Drawing.ColorTranslator.FromHtml("#032a68");
        private Color PANEL_COLOR_CLICK = System.Drawing.ColorTranslator.FromHtml("#0147b5");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DB.Initialize();
            setUi();
            fillInformations();
        }

        private void fillInformations()
        {
            // ComboBox styles
            CMB_AddStage_Entreprise.DropDownStyle = ComboBoxStyle.DropDownList;
            CMB_AddStage_Moniteur.DropDownStyle   = ComboBoxStyle.DropDownList;
            CMB_AddStage_Stagiaire.DropDownStyle  = ComboBoxStyle.DropDownList;
            CMB_ChooseEntreprise1.DropDownStyle   = ComboBoxStyle.DropDownList;

            // ComboBox event
            CMB_AddStage_Entreprise.TextChanged += CMB_AddStage_Entreprise_Text_Changed;

            // Disable buttons         
            BTN_ModifyDescription.Enabled = false;
            BTN_DeleteStage2.Enabled = false;
            BTN_AddStage.Enabled = false;
            
            // Set text listeners
            RTB_Description.TextChanged += RTB_Description_Text_Changed;
            RTB_AddStage_Description.TextChanged += RTB_AddStage_Text_Changed;
            RTB_AddStage_Langages.TextChanged += RTB_AddStage_Text_Changed;
            RTB_AddStage_Plateforme.TextChanged += RTB_AddStage_Text_Changed;
            RTB_AddStage_TypeStg.TextChanged += RTB_AddStage_Text_Changed;
            CMB_AddStage_Entreprise.TextChanged += RTB_AddStage_Text_Changed;
            CMB_AddStage_Moniteur.TextChanged += RTB_AddStage_Text_Changed;
            CMB_AddStage_Stagiaire.TextChanged += RTB_AddStage_Text_Changed;

            // Fill ComboBoxes
            DB.getMoniteurs(CMB_AddStage_Moniteur);
            DB.getEntreprises(CMB_AddStage_Entreprise);
            DB.getStagiaires(CMB_AddStage_Stagiaire);
            DB.getEntreprises(CMB_ChooseEntreprise1);

            // Set selected indexes
            CMB_AddStage_Entreprise.SelectedIndex = 0;
            CMB_AddStage_Moniteur.SelectedIndex = 0;
            CMB_AddStage_Stagiaire.SelectedIndex = 0;
            CMB_ChooseEntreprise1.SelectedIndex = 0;

            // Set label value
            LBL_NbStages.Text = DB.getNbStagesByEntreprise(Int32.Parse((CMB_ChooseEntreprise1.SelectedItem as ComboBoxItem).Value.ToString())).ToString();

            // Set DGVs Contents
            DB.getStagesDGV(DGV_Panel1);
            DB.getEtudiants(DGV_Etudiants);
            DB.getStagesFromEntreprise((CMB_ChooseEntreprise1.SelectedItem as ComboBoxItem).Text.ToString(), DGV_StagesEntreprise);
            DB.getStagesDGV(DGV_DeleteStage);
        }

        #region UI

        public void setUi()
        {
            // Set panel header colors
            PNL_Header1.BackColor = PANEL_COLOR;
            PNL_Header2.BackColor = PANEL_COLOR;
            PNL_Header3.BackColor = PANEL_COLOR;
            PNL_Header4.BackColor = PANEL_COLOR;
            PNL_Header5.BackColor = PANEL_COLOR;
            PNL_Header5.BackColor = PANEL_COLOR;

            // Set panel content colors
            PNL_Content1.BackColor = PANEL_COLOR;
            PNL_Content2.BackColor = PANEL_COLOR;
            PNL_Content3.BackColor = PANEL_COLOR;
            PNL_Content4.BackColor = PANEL_COLOR;
            PNL_Content5.BackColor = PANEL_COLOR;
            PNL_Content5.BackColor = PANEL_COLOR;

            // Set form back color
            this.BackColor = Color.Black;

            // Set panel visibility for panel1
            PNL_Header1_Click(PNL_Header1, EventArgs.Empty);
        }

        private void setVisiblePanel(bool panel1,bool panel2,bool panel3,bool panel4,bool panel5,bool panel6)
        {
            // Set visibility of panels
            PNL_Content1.Visible = panel1;
            PNL_Content2.Visible = panel2;
            PNL_Content3.Visible = panel3;
            PNL_Content4.Visible = panel4;
            PNL_Content5.Visible = panel5;
            PNL_Content5.Visible = panel6;
        }

        private void PNL_Header1_Click(object sender, EventArgs e)
        {
            PNL_Header1.BackColor = PANEL_COLOR_CLICK;
            PNL_Header2.BackColor = PANEL_COLOR;
            PNL_Header3.BackColor = PANEL_COLOR;
            PNL_Header4.BackColor = PANEL_COLOR;
            PNL_Header5.BackColor = PANEL_COLOR;
            PNL_Header5.BackColor = PANEL_COLOR;

            PNL_Content2.Hide();
            PNL_Content3.Hide();
            PNL_Content4.Hide();
            PNL_Content5.Hide();
            PNL_Content5.Hide();
            PNL_Content1.Show();
            PNL_Content1.BringToFront();
        }

        private void PNL_Header2_Click(object sender, EventArgs e)
        {
            PNL_Header1.BackColor = PANEL_COLOR;
            PNL_Header2.BackColor = PANEL_COLOR_CLICK;
            PNL_Header3.BackColor = PANEL_COLOR;
            PNL_Header4.BackColor = PANEL_COLOR;
            PNL_Header5.BackColor = PANEL_COLOR;
            PNL_Header5.BackColor = PANEL_COLOR;

            PNL_Content3.Hide();
            PNL_Content4.Hide();
            PNL_Content5.Hide();
            PNL_Content5.Hide();
            PNL_Content2.Show();
            PNL_Content2.BringToFront();
        }

        private void PNL_Header3_Click(object sender, EventArgs e)
        {
            PNL_Header1.BackColor = PANEL_COLOR;
            PNL_Header2.BackColor = PANEL_COLOR;
            PNL_Header3.BackColor = PANEL_COLOR_CLICK;
            PNL_Header4.BackColor = PANEL_COLOR;
            PNL_Header5.BackColor = PANEL_COLOR;
            PNL_Header5.BackColor = PANEL_COLOR;

            PNL_Content4.Hide();
            PNL_Content5.Hide();
            PNL_Content5.Hide();
            PNL_Content2.Show();
            PNL_Content3.Show();
            PNL_Content3.BringToFront();
        }

        private void PNL_Header4_Click(object sender, EventArgs e)
        {
            PNL_Header1.BackColor = PANEL_COLOR;
            PNL_Header2.BackColor = PANEL_COLOR;
            PNL_Header3.BackColor = PANEL_COLOR;
            PNL_Header4.BackColor = PANEL_COLOR_CLICK;
            PNL_Header5.BackColor = PANEL_COLOR;
            PNL_Header5.BackColor = PANEL_COLOR;

            PNL_Content5.Hide();
            PNL_Content5.Hide();
            PNL_Content2.Show();
            PNL_Content3.Show();
            PNL_Content4.Show();
            PNL_Content4.BringToFront();
        }

        private void PNL_Header5_Click(object sender, EventArgs e)
        {
            PNL_Header1.BackColor = PANEL_COLOR;
            PNL_Header2.BackColor = PANEL_COLOR;
            PNL_Header3.BackColor = PANEL_COLOR;
            PNL_Header4.BackColor = PANEL_COLOR;
            PNL_Header5.BackColor = PANEL_COLOR_CLICK;

            PNL_Content2.Show();
            PNL_Content3.Show();
            PNL_Content4.Show();
            PNL_Content5.Show();
            PNL_Content5.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            PNL_Header1_Click(PNL_Header1, EventArgs.Empty);
        }

        private void LBL_DeleteStage_Click(object sender, EventArgs e)
        {
            PNL_Header2_Click(PNL_Header2, EventArgs.Empty);
        }

        private void LBL_AddStage_Click(object sender, EventArgs e)
        {
            PNL_Header3_Click(PNL_Header3, EventArgs.Empty);
        }

        private void LBL_StagesParEntreprises_Click(object sender, EventArgs e)
        {
            PNL_Header4_Click(PNL_Header4, EventArgs.Empty);
        }

        private void LBL_NbStagesParEntreprise_Click(object sender, EventArgs e)
        {
            PNL_Header5_Click(PNL_Header5, EventArgs.Empty);
        }

        #endregion

        #region Button Clicks events

        private void BTN_ModifyDescription_Click(object sender, EventArgs e)
        {
            // Get selected row data
            var data = DGV_Panel1.SelectedRows[0];
            // Update description of stage in database
            DB.updateDescription(new Database.Models.Stage(data,RTB_Description.Text));
            // Rerun query to get all stages (updated)
            DB.getStagesDGV(DGV_Panel1);
            // Empty the description rich text box.
            RTB_Description.Text = "";
            // Reload DGVs
            DB.getStagesDGV(DGV_Panel1);
            DB.getEtudiants(DGV_Etudiants);
            DB.getStagesFromEntreprise((CMB_ChooseEntreprise1.SelectedItem as ComboBoxItem).Text.ToString(), DGV_StagesEntreprise);
            DB.getStagesDGV(DGV_DeleteStage);
        }

        private void BTN_DeleteStage_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Êtes vous sûr de vouloir supprimer ce stage?", "Supprimer stage",
                                                        MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                // Get row data
                var data = DGV_DeleteStage.SelectedRows[0];
                // Delete stage in database
                DB.deleteStage(new Database.Models.Stage(data));
                // Reload data in dgv
                DB.getStagesDGV(DGV_DeleteStage);
                // Disable buttons
                BTN_DeleteStage2.Enabled = false;
                // Reload DGVs
                DB.getStagesDGV(DGV_Panel1);
                DB.getEtudiants(DGV_Etudiants);
                DB.getStagesFromEntreprise((CMB_ChooseEntreprise1.SelectedItem as ComboBoxItem).Text.ToString(), DGV_StagesEntreprise);
                DB.getStagesDGV(DGV_DeleteStage);
            }
        }

        private void BTN_AddStage_Click(object sender, EventArgs e)
        {
            // Add stage in database
            DB.addStage(new Database.Models.Stage(
                                                  RTB_AddStage_Description.Text,
                                                  RTB_AddStage_TypeStg.Text,
                                                  RTB_AddStage_Langages.Text,
                                                  RTB_AddStage_Plateforme.Text,
                                                  Int32.Parse((CMB_AddStage_Entreprise.SelectedItem as ComboBoxItem).Value.ToString()),
                                                  Int32.Parse((CMB_AddStage_Moniteur.SelectedItem as ComboBoxItem).Value.ToString()),
                                                  Int32.Parse((CMB_AddStage_Stagiaire.SelectedItem as ComboBoxItem).Value.ToString())
                                                 )
            );
            // Reset UI
            RTB_AddStage_Description.Text = "";
            RTB_AddStage_Langages.Text = "";
            RTB_AddStage_Plateforme.Text = "";
            RTB_AddStage_TypeStg.Text = "";
            BTN_AddStage.Enabled = false;
            // Reload DGVs
            DB.getStagesDGV(DGV_Panel1);
            DB.getEtudiants(DGV_Etudiants);
            DB.getStagesFromEntreprise((CMB_ChooseEntreprise1.SelectedItem as ComboBoxItem).Text.ToString(), DGV_StagesEntreprise);
            DB.getStagesDGV(DGV_DeleteStage);
        }

        #endregion

        #region Combobox Selected Event Changed events

        private void CMB_ChooseEntreprise1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set label value
            LBL_NbStages.Text = DB.getNbStagesByEntreprise(Int32.Parse((CMB_ChooseEntreprise1.SelectedItem as ComboBoxItem).Value.ToString())).ToString();
            // Set dgv content
            DB.getStagesFromEntreprise((CMB_ChooseEntreprise1.SelectedItem as ComboBoxItem).Text.ToString(), DGV_StagesEntreprise);
        }

        private void CMB_AddStage_Entreprise_Text_Changed(object sender, EventArgs e)
        {
            if (CMB_AddStage_Entreprise.Items.Count > 0)
            {
                // Update moniteurs combobox
                DB.getMoniteursFromEntreprise(CMB_AddStage_Moniteur, Int32.Parse((CMB_AddStage_Entreprise.SelectedItem as ComboBoxItem).Value.ToString()));
            }
        }

        #endregion

        #region DGV Selection Changed events

        private void DGV_Etudiants_SelectionChanged(object sender, EventArgs e)
        {
            // No need to do anything.
        }

        private void DGV_StagesEntreprise_SelectionChanged(object sender, EventArgs e)
        {
            // No need to do anything.
        }

        private void DGV_DeleteStage_SelectionChanged(object sender, EventArgs e)
        {
            BTN_DeleteStage2.Enabled = DGV_DeleteStage.SelectedRows.Count == 1;
        }

        private void DGV_Panel1_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_Panel1.SelectedRows.Count == 1)
            {
                // Get selected row to access its content
                var row = DGV_Panel1.SelectedRows[0];
                // Put description in RTB
                RTB_Description.Text = row.Cells[1].Value.ToString();
            }
            else RTB_Description.Text = "";
        }

        #endregion

        #region Text Listeners
        void RTB_Description_Text_Changed(object sender, EventArgs e)
        {
            BTN_ModifyDescription.Enabled = !String.IsNullOrEmpty(((RichTextBox)sender).Text) && 
                                            DGV_Panel1.SelectedRows.Count == 1;
        }

        void RTB_AddStage_Text_Changed(object sender, EventArgs e)
        {
            BTN_AddStage.Enabled = !String.IsNullOrEmpty(RTB_AddStage_Description.Text) && 
                                   !String.IsNullOrEmpty(RTB_AddStage_Langages.Text) &&
                                   !String.IsNullOrEmpty(RTB_AddStage_Plateforme.Text) &&
                                   !String.IsNullOrEmpty(RTB_AddStage_TypeStg.Text) &&
                                   !String.IsNullOrEmpty(CMB_AddStage_Entreprise.Text) &&
                                   !String.IsNullOrEmpty(CMB_AddStage_Moniteur.Text) &&
                                   !String.IsNullOrEmpty(CMB_AddStage_Stagiaire.Text);
        }

        #endregion
    }
}
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
            fillEtudiants();
        }

        private void fillEtudiants()
        {
            DB.getEtudiants(DGV_Etudiants); 
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

        }

        private void BTN_DeleteStage_Click(object sender, EventArgs e)
        {

        }

        private void BTN_AddStage_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Combobox Selected Event Changed events

        private void CMB_ChooseEntreprise1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region DGV Selection Changed events

        private void DGV_Etudiants_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void DGV_StagesEntreprise_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void DGV_DeleteStage_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void DGV_Panel1_SelectionChanged(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
namespace CSharpApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.PNL_Header1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PNL_Header2 = new System.Windows.Forms.Panel();
            this.LBL_DeleteStage = new System.Windows.Forms.Label();
            this.PNL_Header3 = new System.Windows.Forms.Panel();
            this.LBL_AddStage = new System.Windows.Forms.Label();
            this.PNL_Header4 = new System.Windows.Forms.Panel();
            this.LBL_StagesParEntreprises = new System.Windows.Forms.Label();
            this.PNL_Content1 = new System.Windows.Forms.Panel();
            this.PNL_Content2 = new System.Windows.Forms.Panel();
            this.BTN_DeleteStage2 = new System.Windows.Forms.Button();
            this.BTN_DeleteStage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DGV_DeleteStage = new System.Windows.Forms.DataGridView();
            this.BTN_ModifyDescription = new System.Windows.Forms.Button();
            this.RTB_Description = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Panel1 = new System.Windows.Forms.DataGridView();
            this.PNL_Content3 = new System.Windows.Forms.Panel();
            this.PNL_Content4 = new System.Windows.Forms.Panel();
            this.PNL_Content5 = new System.Windows.Forms.Panel();
            this.DGV_Etudiants = new System.Windows.Forms.DataGridView();
            this.LBL_Etudiants = new System.Windows.Forms.Label();
            this.LBL_NbStages = new System.Windows.Forms.Label();
            this.LBL_NbStagesHeader = new System.Windows.Forms.Label();
            this.CMB_ChooseEntreprise1 = new System.Windows.Forms.ComboBox();
            this.LBL_ChooseEntreprise = new System.Windows.Forms.Label();
            this.DGV_StagesEntreprise = new System.Windows.Forms.DataGridView();
            this.CMB_AddStage_Moniteur = new System.Windows.Forms.ComboBox();
            this.CMB_AddStage_Entreprise = new System.Windows.Forms.ComboBox();
            this.CMB_AddStage_Stagiaire = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RTB_AddStage_Plateforme = new System.Windows.Forms.RichTextBox();
            this.RTB_AddStage_Langages = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RTB_AddStage_TypeStg = new System.Windows.Forms.RichTextBox();
            this.LBL_AddStage_TypeStg = new System.Windows.Forms.Label();
            this.LBL_AddStage_Description = new System.Windows.Forms.Label();
            this.RTB_AddStage_Description = new System.Windows.Forms.RichTextBox();
            this.BTN_AddStage = new System.Windows.Forms.Button();
            this.PNL_Header5 = new System.Windows.Forms.Panel();
            this.LBL_ = new System.Windows.Forms.Label();
            this.PNL_Header1.SuspendLayout();
            this.PNL_Header2.SuspendLayout();
            this.PNL_Header3.SuspendLayout();
            this.PNL_Header4.SuspendLayout();
            this.PNL_Content1.SuspendLayout();
            this.PNL_Content2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DeleteStage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Panel1)).BeginInit();
            this.PNL_Content3.SuspendLayout();
            this.PNL_Content4.SuspendLayout();
            this.PNL_Content5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Etudiants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_StagesEntreprise)).BeginInit();
            this.PNL_Header5.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_Header1
            // 
            this.PNL_Header1.Controls.Add(this.label2);
            this.PNL_Header1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PNL_Header1.Location = new System.Drawing.Point(4, 5);
            this.PNL_Header1.Name = "PNL_Header1";
            this.PNL_Header1.Size = new System.Drawing.Size(280, 162);
            this.PNL_Header1.TabIndex = 0;
            this.PNL_Header1.Click += new System.EventHandler(this.PNL_Header1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modifier description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PNL_Header2
            // 
            this.PNL_Header2.Controls.Add(this.LBL_DeleteStage);
            this.PNL_Header2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PNL_Header2.Location = new System.Drawing.Point(290, 5);
            this.PNL_Header2.Name = "PNL_Header2";
            this.PNL_Header2.Size = new System.Drawing.Size(280, 162);
            this.PNL_Header2.TabIndex = 1;
            this.PNL_Header2.Click += new System.EventHandler(this.PNL_Header2_Click);
            // 
            // LBL_DeleteStage
            // 
            this.LBL_DeleteStage.AutoSize = true;
            this.LBL_DeleteStage.ForeColor = System.Drawing.Color.White;
            this.LBL_DeleteStage.Location = new System.Drawing.Point(46, 71);
            this.LBL_DeleteStage.Name = "LBL_DeleteStage";
            this.LBL_DeleteStage.Size = new System.Drawing.Size(199, 25);
            this.LBL_DeleteStage.TabIndex = 2;
            this.LBL_DeleteStage.Text = "Supprimer un stage";
            this.LBL_DeleteStage.Click += new System.EventHandler(this.LBL_DeleteStage_Click);
            // 
            // PNL_Header3
            // 
            this.PNL_Header3.Controls.Add(this.LBL_AddStage);
            this.PNL_Header3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PNL_Header3.Location = new System.Drawing.Point(576, 5);
            this.PNL_Header3.Name = "PNL_Header3";
            this.PNL_Header3.Size = new System.Drawing.Size(280, 162);
            this.PNL_Header3.TabIndex = 2;
            this.PNL_Header3.Click += new System.EventHandler(this.PNL_Header3_Click);
            // 
            // LBL_AddStage
            // 
            this.LBL_AddStage.AutoSize = true;
            this.LBL_AddStage.ForeColor = System.Drawing.Color.White;
            this.LBL_AddStage.Location = new System.Drawing.Point(56, 71);
            this.LBL_AddStage.Name = "LBL_AddStage";
            this.LBL_AddStage.Size = new System.Drawing.Size(169, 25);
            this.LBL_AddStage.TabIndex = 0;
            this.LBL_AddStage.Text = "Ajouter un stage";
            this.LBL_AddStage.Click += new System.EventHandler(this.LBL_AddStage_Click);
            // 
            // PNL_Header4
            // 
            this.PNL_Header4.Controls.Add(this.LBL_StagesParEntreprises);
            this.PNL_Header4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PNL_Header4.Location = new System.Drawing.Point(862, 5);
            this.PNL_Header4.Name = "PNL_Header4";
            this.PNL_Header4.Size = new System.Drawing.Size(280, 162);
            this.PNL_Header4.TabIndex = 3;
            this.PNL_Header4.Click += new System.EventHandler(this.PNL_Header4_Click);
            // 
            // LBL_StagesParEntreprises
            // 
            this.LBL_StagesParEntreprises.AutoSize = true;
            this.LBL_StagesParEntreprises.ForeColor = System.Drawing.Color.White;
            this.LBL_StagesParEntreprises.Location = new System.Drawing.Point(20, 71);
            this.LBL_StagesParEntreprises.Name = "LBL_StagesParEntreprises";
            this.LBL_StagesParEntreprises.Size = new System.Drawing.Size(239, 25);
            this.LBL_StagesParEntreprises.TabIndex = 3;
            this.LBL_StagesParEntreprises.Text = "Stages selon entreprise";
            this.LBL_StagesParEntreprises.Click += new System.EventHandler(this.LBL_StagesParEntreprises_Click);
            // 
            // PNL_Content1
            // 
            this.PNL_Content1.Controls.Add(this.PNL_Content2);
            this.PNL_Content1.Controls.Add(this.BTN_ModifyDescription);
            this.PNL_Content1.Controls.Add(this.RTB_Description);
            this.PNL_Content1.Controls.Add(this.label3);
            this.PNL_Content1.Controls.Add(this.label1);
            this.PNL_Content1.Controls.Add(this.DGV_Panel1);
            this.PNL_Content1.Location = new System.Drawing.Point(4, 173);
            this.PNL_Content1.Name = "PNL_Content1";
            this.PNL_Content1.Size = new System.Drawing.Size(1424, 676);
            this.PNL_Content1.TabIndex = 2;
            // 
            // PNL_Content2
            // 
            this.PNL_Content2.Controls.Add(this.BTN_DeleteStage2);
            this.PNL_Content2.Controls.Add(this.BTN_DeleteStage);
            this.PNL_Content2.Controls.Add(this.label4);
            this.PNL_Content2.Controls.Add(this.DGV_DeleteStage);
            this.PNL_Content2.Location = new System.Drawing.Point(0, 0);
            this.PNL_Content2.Name = "PNL_Content2";
            this.PNL_Content2.Size = new System.Drawing.Size(1424, 676);
            this.PNL_Content2.TabIndex = 3;
            // 
            // BTN_DeleteStage2
            // 
            this.BTN_DeleteStage2.Location = new System.Drawing.Point(1205, 576);
            this.BTN_DeleteStage2.Name = "BTN_DeleteStage2";
            this.BTN_DeleteStage2.Size = new System.Drawing.Size(210, 75);
            this.BTN_DeleteStage2.TabIndex = 20;
            this.BTN_DeleteStage2.Text = "Supprimer";
            this.BTN_DeleteStage2.UseVisualStyleBackColor = true;
            this.BTN_DeleteStage2.Click += new System.EventHandler(this.BTN_DeleteStage_Click);
            // 
            // BTN_DeleteStage
            // 
            this.BTN_DeleteStage.Location = new System.Drawing.Point(1480, 578);
            this.BTN_DeleteStage.Name = "BTN_DeleteStage";
            this.BTN_DeleteStage.Size = new System.Drawing.Size(210, 75);
            this.BTN_DeleteStage.TabIndex = 9;
            this.BTN_DeleteStage.Text = "Supprimer";
            this.BTN_DeleteStage.UseVisualStyleBackColor = true;
            this.BTN_DeleteStage.Click += new System.EventHandler(this.BTN_DeleteStage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sélectionner un stage";
            // 
            // DGV_DeleteStage
            // 
            this.DGV_DeleteStage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DeleteStage.Location = new System.Drawing.Point(8, 66);
            this.DGV_DeleteStage.Name = "DGV_DeleteStage";
            this.DGV_DeleteStage.RowTemplate.Height = 33;
            this.DGV_DeleteStage.Size = new System.Drawing.Size(1407, 488);
            this.DGV_DeleteStage.TabIndex = 4;
            this.DGV_DeleteStage.SelectionChanged += new System.EventHandler(this.DGV_DeleteStage_SelectionChanged);
            // 
            // BTN_ModifyDescription
            // 
            this.BTN_ModifyDescription.Location = new System.Drawing.Point(1192, 576);
            this.BTN_ModifyDescription.Name = "BTN_ModifyDescription";
            this.BTN_ModifyDescription.Size = new System.Drawing.Size(210, 75);
            this.BTN_ModifyDescription.TabIndex = 8;
            this.BTN_ModifyDescription.Text = "Modifier";
            this.BTN_ModifyDescription.UseVisualStyleBackColor = true;
            this.BTN_ModifyDescription.Click += new System.EventHandler(this.BTN_ModifyDescription_Click);
            // 
            // RTB_Description
            // 
            this.RTB_Description.Location = new System.Drawing.Point(731, 66);
            this.RTB_Description.Name = "RTB_Description";
            this.RTB_Description.Size = new System.Drawing.Size(675, 488);
            this.RTB_Description.TabIndex = 7;
            this.RTB_Description.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(726, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "2- Donner une nouvelle description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "1- Choisir le stage";
            // 
            // DGV_Panel1
            // 
            this.DGV_Panel1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Panel1.Location = new System.Drawing.Point(13, 66);
            this.DGV_Panel1.Name = "DGV_Panel1";
            this.DGV_Panel1.RowTemplate.Height = 33;
            this.DGV_Panel1.Size = new System.Drawing.Size(676, 576);
            this.DGV_Panel1.TabIndex = 4;
            this.DGV_Panel1.SelectionChanged += new System.EventHandler(this.DGV_Panel1_SelectionChanged);
            // 
            // PNL_Content3
            // 
            this.PNL_Content3.Controls.Add(this.PNL_Content4);
            this.PNL_Content3.Controls.Add(this.CMB_AddStage_Moniteur);
            this.PNL_Content3.Controls.Add(this.CMB_AddStage_Entreprise);
            this.PNL_Content3.Controls.Add(this.CMB_AddStage_Stagiaire);
            this.PNL_Content3.Controls.Add(this.label9);
            this.PNL_Content3.Controls.Add(this.label8);
            this.PNL_Content3.Controls.Add(this.label7);
            this.PNL_Content3.Controls.Add(this.label6);
            this.PNL_Content3.Controls.Add(this.RTB_AddStage_Plateforme);
            this.PNL_Content3.Controls.Add(this.RTB_AddStage_Langages);
            this.PNL_Content3.Controls.Add(this.label5);
            this.PNL_Content3.Controls.Add(this.RTB_AddStage_TypeStg);
            this.PNL_Content3.Controls.Add(this.LBL_AddStage_TypeStg);
            this.PNL_Content3.Controls.Add(this.LBL_AddStage_Description);
            this.PNL_Content3.Controls.Add(this.RTB_AddStage_Description);
            this.PNL_Content3.Controls.Add(this.BTN_AddStage);
            this.PNL_Content3.Location = new System.Drawing.Point(4, 173);
            this.PNL_Content3.Name = "PNL_Content3";
            this.PNL_Content3.Size = new System.Drawing.Size(1424, 676);
            this.PNL_Content3.TabIndex = 3;
            // 
            // PNL_Content4
            // 
            this.PNL_Content4.Controls.Add(this.PNL_Content5);
            this.PNL_Content4.Controls.Add(this.LBL_NbStages);
            this.PNL_Content4.Controls.Add(this.LBL_NbStagesHeader);
            this.PNL_Content4.Controls.Add(this.CMB_ChooseEntreprise1);
            this.PNL_Content4.Controls.Add(this.LBL_ChooseEntreprise);
            this.PNL_Content4.Controls.Add(this.DGV_StagesEntreprise);
            this.PNL_Content4.Location = new System.Drawing.Point(0, 0);
            this.PNL_Content4.Name = "PNL_Content4";
            this.PNL_Content4.Size = new System.Drawing.Size(1424, 676);
            this.PNL_Content4.TabIndex = 3;
            // 
            // PNL_Content5
            // 
            this.PNL_Content5.Controls.Add(this.DGV_Etudiants);
            this.PNL_Content5.Controls.Add(this.LBL_Etudiants);
            this.PNL_Content5.Location = new System.Drawing.Point(0, 0);
            this.PNL_Content5.Name = "PNL_Content5";
            this.PNL_Content5.Size = new System.Drawing.Size(1424, 676);
            this.PNL_Content5.TabIndex = 4;
            // 
            // DGV_Etudiants
            // 
            this.DGV_Etudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Etudiants.Location = new System.Drawing.Point(8, 69);
            this.DGV_Etudiants.Name = "DGV_Etudiants";
            this.DGV_Etudiants.RowTemplate.Height = 33;
            this.DGV_Etudiants.Size = new System.Drawing.Size(1410, 599);
            this.DGV_Etudiants.TabIndex = 1;
            this.DGV_Etudiants.SelectionChanged += new System.EventHandler(this.DGV_Etudiants_SelectionChanged);
            // 
            // LBL_Etudiants
            // 
            this.LBL_Etudiants.AutoSize = true;
            this.LBL_Etudiants.ForeColor = System.Drawing.Color.White;
            this.LBL_Etudiants.Location = new System.Drawing.Point(8, 26);
            this.LBL_Etudiants.Name = "LBL_Etudiants";
            this.LBL_Etudiants.Size = new System.Drawing.Size(102, 25);
            this.LBL_Etudiants.TabIndex = 0;
            this.LBL_Etudiants.Text = "Étudiants";
            // 
            // LBL_NbStages
            // 
            this.LBL_NbStages.AutoSize = true;
            this.LBL_NbStages.ForeColor = System.Drawing.Color.White;
            this.LBL_NbStages.Location = new System.Drawing.Point(633, 69);
            this.LBL_NbStages.Name = "LBL_NbStages";
            this.LBL_NbStages.Size = new System.Drawing.Size(24, 25);
            this.LBL_NbStages.TabIndex = 8;
            this.LBL_NbStages.Text = "0";
            // 
            // LBL_NbStagesHeader
            // 
            this.LBL_NbStagesHeader.AutoSize = true;
            this.LBL_NbStagesHeader.ForeColor = System.Drawing.Color.White;
            this.LBL_NbStagesHeader.Location = new System.Drawing.Point(434, 69);
            this.LBL_NbStagesHeader.Name = "LBL_NbStagesHeader";
            this.LBL_NbStagesHeader.Size = new System.Drawing.Size(193, 25);
            this.LBL_NbStagesHeader.TabIndex = 7;
            this.LBL_NbStagesHeader.Text = "Nombre de stages:";
            // 
            // CMB_ChooseEntreprise1
            // 
            this.CMB_ChooseEntreprise1.FormattingEnabled = true;
            this.CMB_ChooseEntreprise1.Location = new System.Drawing.Point(13, 66);
            this.CMB_ChooseEntreprise1.Name = "CMB_ChooseEntreprise1";
            this.CMB_ChooseEntreprise1.Size = new System.Drawing.Size(391, 33);
            this.CMB_ChooseEntreprise1.TabIndex = 6;
            this.CMB_ChooseEntreprise1.SelectedIndexChanged += new System.EventHandler(this.CMB_ChooseEntreprise1_SelectedIndexChanged);
            // 
            // LBL_ChooseEntreprise
            // 
            this.LBL_ChooseEntreprise.AutoSize = true;
            this.LBL_ChooseEntreprise.ForeColor = System.Drawing.Color.White;
            this.LBL_ChooseEntreprise.Location = new System.Drawing.Point(8, 23);
            this.LBL_ChooseEntreprise.Name = "LBL_ChooseEntreprise";
            this.LBL_ChooseEntreprise.Size = new System.Drawing.Size(190, 25);
            this.LBL_ChooseEntreprise.TabIndex = 5;
            this.LBL_ChooseEntreprise.Text = "Choisir l\'entreprise";
            // 
            // DGV_StagesEntreprise
            // 
            this.DGV_StagesEntreprise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_StagesEntreprise.Location = new System.Drawing.Point(8, 138);
            this.DGV_StagesEntreprise.Name = "DGV_StagesEntreprise";
            this.DGV_StagesEntreprise.RowTemplate.Height = 33;
            this.DGV_StagesEntreprise.Size = new System.Drawing.Size(1408, 530);
            this.DGV_StagesEntreprise.TabIndex = 4;
            this.DGV_StagesEntreprise.SelectionChanged += new System.EventHandler(this.DGV_StagesEntreprise_SelectionChanged);
            // 
            // CMB_AddStage_Moniteur
            // 
            this.CMB_AddStage_Moniteur.FormattingEnabled = true;
            this.CMB_AddStage_Moniteur.Location = new System.Drawing.Point(481, 598);
            this.CMB_AddStage_Moniteur.Name = "CMB_AddStage_Moniteur";
            this.CMB_AddStage_Moniteur.Size = new System.Drawing.Size(436, 33);
            this.CMB_AddStage_Moniteur.TabIndex = 18;
            // 
            // CMB_AddStage_Entreprise
            // 
            this.CMB_AddStage_Entreprise.FormattingEnabled = true;
            this.CMB_AddStage_Entreprise.Location = new System.Drawing.Point(481, 397);
            this.CMB_AddStage_Entreprise.Name = "CMB_AddStage_Entreprise";
            this.CMB_AddStage_Entreprise.Size = new System.Drawing.Size(436, 33);
            this.CMB_AddStage_Entreprise.TabIndex = 17;
            // 
            // CMB_AddStage_Stagiaire
            // 
            this.CMB_AddStage_Stagiaire.FormattingEnabled = true;
            this.CMB_AddStage_Stagiaire.Location = new System.Drawing.Point(479, 501);
            this.CMB_AddStage_Stagiaire.Name = "CMB_AddStage_Stagiaire";
            this.CMB_AddStage_Stagiaire.Size = new System.Drawing.Size(438, 33);
            this.CMB_AddStage_Stagiaire.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(476, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Stagiaire";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(477, 557);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Moniteur";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(476, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Entreprise";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Plateforme";
            // 
            // RTB_AddStage_Plateforme
            // 
            this.RTB_AddStage_Plateforme.Location = new System.Drawing.Point(8, 400);
            this.RTB_AddStage_Plateforme.Name = "RTB_AddStage_Plateforme";
            this.RTB_AddStage_Plateforme.Size = new System.Drawing.Size(435, 232);
            this.RTB_AddStage_Plateforme.TabIndex = 10;
            this.RTB_AddStage_Plateforme.Text = "";
            // 
            // RTB_AddStage_Langages
            // 
            this.RTB_AddStage_Langages.Location = new System.Drawing.Point(958, 66);
            this.RTB_AddStage_Langages.Name = "RTB_AddStage_Langages";
            this.RTB_AddStage_Langages.Size = new System.Drawing.Size(457, 232);
            this.RTB_AddStage_Langages.TabIndex = 9;
            this.RTB_AddStage_Langages.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(953, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Langages";
            // 
            // RTB_AddStage_TypeStg
            // 
            this.RTB_AddStage_TypeStg.Location = new System.Drawing.Point(482, 66);
            this.RTB_AddStage_TypeStg.Name = "RTB_AddStage_TypeStg";
            this.RTB_AddStage_TypeStg.Size = new System.Drawing.Size(435, 232);
            this.RTB_AddStage_TypeStg.TabIndex = 7;
            this.RTB_AddStage_TypeStg.Text = "";
            // 
            // LBL_AddStage_TypeStg
            // 
            this.LBL_AddStage_TypeStg.AutoSize = true;
            this.LBL_AddStage_TypeStg.ForeColor = System.Drawing.Color.White;
            this.LBL_AddStage_TypeStg.Location = new System.Drawing.Point(477, 23);
            this.LBL_AddStage_TypeStg.Name = "LBL_AddStage_TypeStg";
            this.LBL_AddStage_TypeStg.Size = new System.Drawing.Size(174, 25);
            this.LBL_AddStage_TypeStg.TabIndex = 6;
            this.LBL_AddStage_TypeStg.Text = "Type(s) de stage";
            // 
            // LBL_AddStage_Description
            // 
            this.LBL_AddStage_Description.AutoSize = true;
            this.LBL_AddStage_Description.ForeColor = System.Drawing.Color.White;
            this.LBL_AddStage_Description.Location = new System.Drawing.Point(8, 23);
            this.LBL_AddStage_Description.Name = "LBL_AddStage_Description";
            this.LBL_AddStage_Description.Size = new System.Drawing.Size(120, 25);
            this.LBL_AddStage_Description.TabIndex = 5;
            this.LBL_AddStage_Description.Text = "Description";
            // 
            // RTB_AddStage_Description
            // 
            this.RTB_AddStage_Description.Location = new System.Drawing.Point(8, 66);
            this.RTB_AddStage_Description.Name = "RTB_AddStage_Description";
            this.RTB_AddStage_Description.Size = new System.Drawing.Size(435, 232);
            this.RTB_AddStage_Description.TabIndex = 4;
            this.RTB_AddStage_Description.Text = "";
            // 
            // BTN_AddStage
            // 
            this.BTN_AddStage.Location = new System.Drawing.Point(1194, 579);
            this.BTN_AddStage.Name = "BTN_AddStage";
            this.BTN_AddStage.Size = new System.Drawing.Size(210, 75);
            this.BTN_AddStage.TabIndex = 19;
            this.BTN_AddStage.Text = "Ajouter";
            this.BTN_AddStage.UseVisualStyleBackColor = true;
            this.BTN_AddStage.Click += new System.EventHandler(this.BTN_AddStage_Click);
            // 
            // PNL_Header5
            // 
            this.PNL_Header5.Controls.Add(this.LBL_);
            this.PNL_Header5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PNL_Header5.Location = new System.Drawing.Point(1148, 5);
            this.PNL_Header5.Name = "PNL_Header5";
            this.PNL_Header5.Size = new System.Drawing.Size(280, 162);
            this.PNL_Header5.TabIndex = 5;
            this.PNL_Header5.Click += new System.EventHandler(this.PNL_Header5_Click);
            // 
            // LBL_
            // 
            this.LBL_.AutoSize = true;
            this.LBL_.ForeColor = System.Drawing.Color.White;
            this.LBL_.Location = new System.Drawing.Point(45, 71);
            this.LBL_.Name = "LBL_";
            this.LBL_.Size = new System.Drawing.Size(193, 25);
            this.LBL_.TabIndex = 4;
            this.LBL_.Text = "Liste des étudiants";
            this.LBL_.Click += new System.EventHandler(this.LBL_NbStagesParEntreprise_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1434, 853);
            this.Controls.Add(this.PNL_Content3);
            this.Controls.Add(this.PNL_Header5);
            this.Controls.Add(this.PNL_Header4);
            this.Controls.Add(this.PNL_Header3);
            this.Controls.Add(this.PNL_Header2);
            this.Controls.Add(this.PNL_Header1);
            this.Controls.Add(this.PNL_Content1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP#2BD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PNL_Header1.ResumeLayout(false);
            this.PNL_Header1.PerformLayout();
            this.PNL_Header2.ResumeLayout(false);
            this.PNL_Header2.PerformLayout();
            this.PNL_Header3.ResumeLayout(false);
            this.PNL_Header3.PerformLayout();
            this.PNL_Header4.ResumeLayout(false);
            this.PNL_Header4.PerformLayout();
            this.PNL_Content1.ResumeLayout(false);
            this.PNL_Content1.PerformLayout();
            this.PNL_Content2.ResumeLayout(false);
            this.PNL_Content2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DeleteStage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Panel1)).EndInit();
            this.PNL_Content3.ResumeLayout(false);
            this.PNL_Content3.PerformLayout();
            this.PNL_Content4.ResumeLayout(false);
            this.PNL_Content4.PerformLayout();
            this.PNL_Content5.ResumeLayout(false);
            this.PNL_Content5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Etudiants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_StagesEntreprise)).EndInit();
            this.PNL_Header5.ResumeLayout(false);
            this.PNL_Header5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Header1;
        private System.Windows.Forms.Panel PNL_Header2;
        private System.Windows.Forms.Panel PNL_Header3;
        private System.Windows.Forms.Panel PNL_Header4;
        private System.Windows.Forms.Panel PNL_Content1;
        private System.Windows.Forms.Panel PNL_Content2;
        private System.Windows.Forms.Panel PNL_Content3;
        private System.Windows.Forms.Panel PNL_Content4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBL_DeleteStage;
        private System.Windows.Forms.Label LBL_AddStage;
        private System.Windows.Forms.Label LBL_StagesParEntreprises;
        private System.Windows.Forms.Panel PNL_Header5;
        private System.Windows.Forms.Label LBL_;
        private System.Windows.Forms.DataGridView DGV_Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_ModifyDescription;
        private System.Windows.Forms.RichTextBox RTB_Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PNL_Content5;
        private System.Windows.Forms.Button BTN_DeleteStage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGV_DeleteStage;
        private System.Windows.Forms.Label LBL_AddStage_Description;
        private System.Windows.Forms.RichTextBox RTB_AddStage_Description;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox RTB_AddStage_Plateforme;
        private System.Windows.Forms.RichTextBox RTB_AddStage_Langages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox RTB_AddStage_TypeStg;
        private System.Windows.Forms.Label LBL_AddStage_TypeStg;
        private System.Windows.Forms.ComboBox CMB_AddStage_Moniteur;
        private System.Windows.Forms.ComboBox CMB_AddStage_Entreprise;
        private System.Windows.Forms.ComboBox CMB_AddStage_Stagiaire;
        private System.Windows.Forms.Button BTN_AddStage;
        private System.Windows.Forms.ComboBox CMB_ChooseEntreprise1;
        private System.Windows.Forms.Label LBL_ChooseEntreprise;
        private System.Windows.Forms.DataGridView DGV_StagesEntreprise;
        private System.Windows.Forms.Label LBL_NbStages;
        private System.Windows.Forms.Label LBL_NbStagesHeader;
        private System.Windows.Forms.Button BTN_DeleteStage2;
        private System.Windows.Forms.Label LBL_Etudiants;
        public System.Windows.Forms.DataGridView DGV_Etudiants;
    }
}


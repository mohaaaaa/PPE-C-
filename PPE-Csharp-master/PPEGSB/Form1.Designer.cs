namespace PPEGSB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabConnexion = new System.Windows.Forms.TabPage();
            this.btnConnecter = new System.Windows.Forms.Button();
            this.txtMdpUser = new System.Windows.Forms.TextBox();
            this.txtIdUser = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tabVisiteur = new System.Windows.Forms.TabPage();
            this.dgvVisiteurs = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEmbauche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSupprimerVisiteur = new System.Windows.Forms.Button();
            this.btnModifierVisiteur = new System.Windows.Forms.Button();
            this.btnAjouterVisiteur = new System.Windows.Forms.Button();
            this.dtpNaissance = new System.Windows.Forms.DateTimePicker();
            this.dtpEmbauche = new System.Windows.Forms.DateTimePicker();
            this.txtPrenomVisiteur = new System.Windows.Forms.TextBox();
            this.txtNomVisiteur = new System.Windows.Forms.TextBox();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.lblDateEmbauche = new System.Windows.Forms.Label();
            this.lblPrenomVisiteur = new System.Windows.Forms.Label();
            this.lblNomVisiteur = new System.Windows.Forms.Label();
            this.tabProduit = new System.Windows.Forms.TabPage();
            this.dgvProduits = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSupprimerProduit = new System.Windows.Forms.Button();
            this.btnModifierProduit = new System.Windows.Forms.Button();
            this.btnAjouterProduit = new System.Windows.Forms.Button();
            this.txtLibelleProduit = new System.Windows.Forms.TextBox();
            this.tabGestion = new System.Windows.Forms.TabPage();
            this.dgvVisiteurCompetences = new System.Windows.Forms.DataGridView();
            this.idVisCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomVisCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomVisCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblChoixVisiteur = new System.Windows.Forms.Label();
            this.grpCompetences = new System.Windows.Forms.GroupBox();
            this.lblCompetencesVisiteur = new System.Windows.Forms.Label();
            this.lblCompetencesDispo = new System.Windows.Forms.Label();
            this.chkCompetencesVisiteur = new System.Windows.Forms.CheckedListBox();
            this.btnSupprCompetences = new System.Windows.Forms.Button();
            this.btnAjoutCompetences = new System.Windows.Forms.Button();
            this.chkCompetencesDispo = new System.Windows.Forms.CheckedListBox();
            this.tabVisParProd = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabVisiteurAge = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblBienvenue = new System.Windows.Forms.Label();
            this.lblNomUserConnecte = new System.Windows.Forms.Label();
            this.lblFonctionUser = new System.Windows.Forms.Label();
            this.btnDeconnecter = new System.Windows.Forms.Button();
            this.picLogoPrincipal = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabConnexion.SuspendLayout();
            this.tabVisiteur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurs)).BeginInit();
            this.tabProduit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).BeginInit();
            this.tabGestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurCompetences)).BeginInit();
            this.grpCompetences.SuspendLayout();
            this.tabVisParProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabVisiteurAge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabConnexion);
            this.tabControl.Controls.Add(this.tabVisiteur);
            this.tabControl.Controls.Add(this.tabProduit);
            this.tabControl.Controls.Add(this.tabGestion);
            this.tabControl.Controls.Add(this.tabVisParProd);
            this.tabControl.Controls.Add(this.tabVisiteurAge);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(21, 93);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(826, 511);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabConnexion
            // 
            this.tabConnexion.BackColor = System.Drawing.Color.SeaShell;
            this.tabConnexion.Controls.Add(this.btnConnecter);
            this.tabConnexion.Controls.Add(this.txtMdpUser);
            this.tabConnexion.Controls.Add(this.txtIdUser);
            this.tabConnexion.Controls.Add(this.lblMdp);
            this.tabConnexion.Controls.Add(this.lblId);
            this.tabConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConnexion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabConnexion.Location = new System.Drawing.Point(4, 25);
            this.tabConnexion.Name = "tabConnexion";
            this.tabConnexion.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnexion.Size = new System.Drawing.Size(818, 482);
            this.tabConnexion.TabIndex = 0;
            this.tabConnexion.Text = "Connexion";
            // 
            // btnConnecter
            // 
            this.btnConnecter.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConnecter.Location = new System.Drawing.Point(359, 326);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(141, 31);
            this.btnConnecter.TabIndex = 4;
            this.btnConnecter.Text = "Se connecter";
            this.btnConnecter.UseVisualStyleBackColor = false;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // txtMdpUser
            // 
            this.txtMdpUser.Location = new System.Drawing.Point(216, 235);
            this.txtMdpUser.MaxLength = 25;
            this.txtMdpUser.Name = "txtMdpUser";
            this.txtMdpUser.PasswordChar = '*';
            this.txtMdpUser.Size = new System.Drawing.Size(284, 20);
            this.txtMdpUser.TabIndex = 3;
            this.txtMdpUser.UseSystemPasswordChar = true;
            // 
            // txtIdUser
            // 
            this.txtIdUser.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdUser.Location = new System.Drawing.Point(216, 152);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.Size = new System.Drawing.Size(284, 20);
            this.txtIdUser.TabIndex = 2;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(77, 240);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(80, 13);
            this.lblMdp.TabIndex = 1;
            this.lblMdp.Text = "Mot de passe : ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(102, 159);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(62, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Identifiant : ";
            // 
            // tabVisiteur
            // 
            this.tabVisiteur.BackColor = System.Drawing.Color.SeaShell;
            this.tabVisiteur.Controls.Add(this.dgvVisiteurs);
            this.tabVisiteur.Controls.Add(this.btnSupprimerVisiteur);
            this.tabVisiteur.Controls.Add(this.btnModifierVisiteur);
            this.tabVisiteur.Controls.Add(this.btnAjouterVisiteur);
            this.tabVisiteur.Controls.Add(this.dtpNaissance);
            this.tabVisiteur.Controls.Add(this.dtpEmbauche);
            this.tabVisiteur.Controls.Add(this.txtPrenomVisiteur);
            this.tabVisiteur.Controls.Add(this.txtNomVisiteur);
            this.tabVisiteur.Controls.Add(this.lblDateNaissance);
            this.tabVisiteur.Controls.Add(this.lblDateEmbauche);
            this.tabVisiteur.Controls.Add(this.lblPrenomVisiteur);
            this.tabVisiteur.Controls.Add(this.lblNomVisiteur);
            this.tabVisiteur.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVisiteur.Location = new System.Drawing.Point(4, 25);
            this.tabVisiteur.Name = "tabVisiteur";
            this.tabVisiteur.Padding = new System.Windows.Forms.Padding(3);
            this.tabVisiteur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabVisiteur.Size = new System.Drawing.Size(818, 482);
            this.tabVisiteur.TabIndex = 1;
            this.tabVisiteur.Text = "Les visiteurs";
            // 
            // dgvVisiteurs
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgvVisiteurs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVisiteurs.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvVisiteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.nom,
            this.prenom,
            this.dateEmbauche,
            this.dateNaissance});
            this.dgvVisiteurs.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvVisiteurs.Location = new System.Drawing.Point(101, 273);
            this.dgvVisiteurs.Name = "dgvVisiteurs";
            this.dgvVisiteurs.RowTemplate.Height = 28;
            this.dgvVisiteurs.Size = new System.Drawing.Size(598, 160);
            this.dgvVisiteurs.TabIndex = 11;
            this.dgvVisiteurs.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVisiteurs_RowHeaderMouseClick);
            // 
            // num
            // 
            this.num.HeaderText = "ID";
            this.num.Name = "num";
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prenom";
            this.prenom.Name = "prenom";
            // 
            // dateEmbauche
            // 
            this.dateEmbauche.HeaderText = "Date d\'embauche";
            this.dateEmbauche.Name = "dateEmbauche";
            // 
            // dateNaissance
            // 
            this.dateNaissance.HeaderText = "Date de naissance";
            this.dateNaissance.Name = "dateNaissance";
            // 
            // btnSupprimerVisiteur
            // 
            this.btnSupprimerVisiteur.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSupprimerVisiteur.Location = new System.Drawing.Point(598, 205);
            this.btnSupprimerVisiteur.Name = "btnSupprimerVisiteur";
            this.btnSupprimerVisiteur.Size = new System.Drawing.Size(101, 35);
            this.btnSupprimerVisiteur.TabIndex = 10;
            this.btnSupprimerVisiteur.Text = "Supprimer";
            this.btnSupprimerVisiteur.UseVisualStyleBackColor = false;
            this.btnSupprimerVisiteur.Click += new System.EventHandler(this.btnSupprimerVisiteur_Click);
            // 
            // btnModifierVisiteur
            // 
            this.btnModifierVisiteur.BackColor = System.Drawing.Color.Gainsboro;
            this.btnModifierVisiteur.Location = new System.Drawing.Point(357, 205);
            this.btnModifierVisiteur.Name = "btnModifierVisiteur";
            this.btnModifierVisiteur.Size = new System.Drawing.Size(101, 35);
            this.btnModifierVisiteur.TabIndex = 9;
            this.btnModifierVisiteur.Text = "Modifier";
            this.btnModifierVisiteur.UseVisualStyleBackColor = false;
            this.btnModifierVisiteur.Click += new System.EventHandler(this.btnModifierVisiteur_Click);
            // 
            // btnAjouterVisiteur
            // 
            this.btnAjouterVisiteur.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAjouterVisiteur.Location = new System.Drawing.Point(90, 205);
            this.btnAjouterVisiteur.Name = "btnAjouterVisiteur";
            this.btnAjouterVisiteur.Size = new System.Drawing.Size(101, 35);
            this.btnAjouterVisiteur.TabIndex = 8;
            this.btnAjouterVisiteur.Text = "Ajouter";
            this.btnAjouterVisiteur.UseVisualStyleBackColor = false;
            this.btnAjouterVisiteur.Click += new System.EventHandler(this.btnAjouterVisiteur_Click);
            // 
            // dtpNaissance
            // 
            this.dtpNaissance.Location = new System.Drawing.Point(274, 153);
            this.dtpNaissance.MaxDate = new System.DateTime(1998, 12, 12, 0, 0, 0, 0);
            this.dtpNaissance.Name = "dtpNaissance";
            this.dtpNaissance.Size = new System.Drawing.Size(252, 20);
            this.dtpNaissance.TabIndex = 7;
            this.dtpNaissance.Value = new System.DateTime(1998, 12, 12, 0, 0, 0, 0);
            // 
            // dtpEmbauche
            // 
            this.dtpEmbauche.Location = new System.Drawing.Point(274, 112);
            this.dtpEmbauche.MaxDate = new System.DateTime(2016, 12, 6, 0, 0, 0, 0);
            this.dtpEmbauche.Name = "dtpEmbauche";
            this.dtpEmbauche.Size = new System.Drawing.Size(252, 20);
            this.dtpEmbauche.TabIndex = 6;
            this.dtpEmbauche.Value = new System.DateTime(2016, 11, 17, 0, 0, 0, 0);
            // 
            // txtPrenomVisiteur
            // 
            this.txtPrenomVisiteur.Location = new System.Drawing.Point(274, 70);
            this.txtPrenomVisiteur.Name = "txtPrenomVisiteur";
            this.txtPrenomVisiteur.Size = new System.Drawing.Size(252, 20);
            this.txtPrenomVisiteur.TabIndex = 5;
            // 
            // txtNomVisiteur
            // 
            this.txtNomVisiteur.Location = new System.Drawing.Point(274, 31);
            this.txtNomVisiteur.Name = "txtNomVisiteur";
            this.txtNomVisiteur.Size = new System.Drawing.Size(252, 20);
            this.txtNomVisiteur.TabIndex = 4;
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.Location = new System.Drawing.Point(102, 158);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(102, 13);
            this.lblDateNaissance.TabIndex = 3;
            this.lblDateNaissance.Text = "Date de naissance :";
            // 
            // lblDateEmbauche
            // 
            this.lblDateEmbauche.AutoSize = true;
            this.lblDateEmbauche.Location = new System.Drawing.Point(109, 118);
            this.lblDateEmbauche.Name = "lblDateEmbauche";
            this.lblDateEmbauche.Size = new System.Drawing.Size(97, 13);
            this.lblDateEmbauche.TabIndex = 2;
            this.lblDateEmbauche.Text = "Date d\'embauche :";
            // 
            // lblPrenomVisiteur
            // 
            this.lblPrenomVisiteur.AutoSize = true;
            this.lblPrenomVisiteur.Location = new System.Drawing.Point(180, 73);
            this.lblPrenomVisiteur.Name = "lblPrenomVisiteur";
            this.lblPrenomVisiteur.Size = new System.Drawing.Size(50, 13);
            this.lblPrenomVisiteur.TabIndex = 1;
            this.lblPrenomVisiteur.Text = "Prenom :";
            // 
            // lblNomVisiteur
            // 
            this.lblNomVisiteur.AutoSize = true;
            this.lblNomVisiteur.Location = new System.Drawing.Point(202, 34);
            this.lblNomVisiteur.Name = "lblNomVisiteur";
            this.lblNomVisiteur.Size = new System.Drawing.Size(35, 13);
            this.lblNomVisiteur.TabIndex = 0;
            this.lblNomVisiteur.Text = "Nom :";
            // 
            // tabProduit
            // 
            this.tabProduit.BackColor = System.Drawing.Color.SeaShell;
            this.tabProduit.Controls.Add(this.label1);
            this.tabProduit.Controls.Add(this.dgvProduits);
            this.tabProduit.Controls.Add(this.btnSupprimerProduit);
            this.tabProduit.Controls.Add(this.btnModifierProduit);
            this.tabProduit.Controls.Add(this.btnAjouterProduit);
            this.tabProduit.Controls.Add(this.txtLibelleProduit);
            this.tabProduit.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProduit.Location = new System.Drawing.Point(4, 25);
            this.tabProduit.Name = "tabProduit";
            this.tabProduit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabProduit.Size = new System.Drawing.Size(818, 482);
            this.tabProduit.TabIndex = 2;
            this.tabProduit.Text = "Les produits";
            // 
            // dgvProduits
            // 
            this.dgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.libelle});
            this.dgvProduits.Location = new System.Drawing.Point(145, 219);
            this.dgvProduits.Name = "dgvProduits";
            this.dgvProduits.RowTemplate.Height = 28;
            this.dgvProduits.Size = new System.Drawing.Size(389, 154);
            this.dgvProduits.TabIndex = 6;
            this.dgvProduits.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProduits_RowHeaderMouseClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // libelle
            // 
            this.libelle.HeaderText = "Libelle";
            this.libelle.Name = "libelle";
            // 
            // btnSupprimerProduit
            // 
            this.btnSupprimerProduit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSupprimerProduit.Location = new System.Drawing.Point(433, 119);
            this.btnSupprimerProduit.Name = "btnSupprimerProduit";
            this.btnSupprimerProduit.Size = new System.Drawing.Size(101, 35);
            this.btnSupprimerProduit.TabIndex = 5;
            this.btnSupprimerProduit.Text = "Supprimer";
            this.btnSupprimerProduit.UseVisualStyleBackColor = false;
            this.btnSupprimerProduit.Click += new System.EventHandler(this.btnSupprimerProduit_Click);
            // 
            // btnModifierProduit
            // 
            this.btnModifierProduit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnModifierProduit.Location = new System.Drawing.Point(289, 119);
            this.btnModifierProduit.Name = "btnModifierProduit";
            this.btnModifierProduit.Size = new System.Drawing.Size(101, 35);
            this.btnModifierProduit.TabIndex = 4;
            this.btnModifierProduit.Text = "Modifier";
            this.btnModifierProduit.UseVisualStyleBackColor = false;
            this.btnModifierProduit.Click += new System.EventHandler(this.btnModifierProduit_Click);
            // 
            // btnAjouterProduit
            // 
            this.btnAjouterProduit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAjouterProduit.Location = new System.Drawing.Point(145, 119);
            this.btnAjouterProduit.Name = "btnAjouterProduit";
            this.btnAjouterProduit.Size = new System.Drawing.Size(101, 35);
            this.btnAjouterProduit.TabIndex = 3;
            this.btnAjouterProduit.Text = "Ajouter";
            this.btnAjouterProduit.UseVisualStyleBackColor = false;
            this.btnAjouterProduit.Click += new System.EventHandler(this.btnAjouterProduit_Click);
            // 
            // txtLibelleProduit
            // 
            this.txtLibelleProduit.Location = new System.Drawing.Point(412, 30);
            this.txtLibelleProduit.Name = "txtLibelleProduit";
            this.txtLibelleProduit.Size = new System.Drawing.Size(252, 20);
            this.txtLibelleProduit.TabIndex = 1;
            // 
            // tabGestion
            // 
            this.tabGestion.BackColor = System.Drawing.Color.SeaShell;
            this.tabGestion.Controls.Add(this.dgvVisiteurCompetences);
            this.tabGestion.Controls.Add(this.lblChoixVisiteur);
            this.tabGestion.Controls.Add(this.grpCompetences);
            this.tabGestion.Location = new System.Drawing.Point(4, 25);
            this.tabGestion.Name = "tabGestion";
            this.tabGestion.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestion.Size = new System.Drawing.Size(818, 482);
            this.tabGestion.TabIndex = 3;
            this.tabGestion.Text = "Gestion des competences";
            // 
            // dgvVisiteurCompetences
            // 
            this.dgvVisiteurCompetences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteurCompetences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVisCom,
            this.nomVisCom,
            this.prenomVisCom});
            this.dgvVisiteurCompetences.Location = new System.Drawing.Point(218, 42);
            this.dgvVisiteurCompetences.Name = "dgvVisiteurCompetences";
            this.dgvVisiteurCompetences.RowTemplate.Height = 28;
            this.dgvVisiteurCompetences.Size = new System.Drawing.Size(393, 165);
            this.dgvVisiteurCompetences.TabIndex = 3;
            this.dgvVisiteurCompetences.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVisiteurCompetences_RowHeaderMouseClick);
            // 
            // idVisCom
            // 
            this.idVisCom.HeaderText = "ID";
            this.idVisCom.Name = "idVisCom";
            // 
            // nomVisCom
            // 
            this.nomVisCom.HeaderText = "Nom";
            this.nomVisCom.Name = "nomVisCom";
            // 
            // prenomVisCom
            // 
            this.prenomVisCom.HeaderText = "Prenom";
            this.prenomVisCom.Name = "prenomVisCom";
            // 
            // lblChoixVisiteur
            // 
            this.lblChoixVisiteur.AutoSize = true;
            this.lblChoixVisiteur.Location = new System.Drawing.Point(52, 19);
            this.lblChoixVisiteur.Name = "lblChoixVisiteur";
            this.lblChoixVisiteur.Size = new System.Drawing.Size(125, 13);
            this.lblChoixVisiteur.TabIndex = 2;
            this.lblChoixVisiteur.Text = "Selectionnez un visiteur :";
            // 
            // grpCompetences
            // 
            this.grpCompetences.Controls.Add(this.lblCompetencesVisiteur);
            this.grpCompetences.Controls.Add(this.lblCompetencesDispo);
            this.grpCompetences.Controls.Add(this.chkCompetencesVisiteur);
            this.grpCompetences.Controls.Add(this.btnSupprCompetences);
            this.grpCompetences.Controls.Add(this.btnAjoutCompetences);
            this.grpCompetences.Controls.Add(this.chkCompetencesDispo);
            this.grpCompetences.Location = new System.Drawing.Point(56, 213);
            this.grpCompetences.Name = "grpCompetences";
            this.grpCompetences.Size = new System.Drawing.Size(710, 226);
            this.grpCompetences.TabIndex = 0;
            this.grpCompetences.TabStop = false;
            this.grpCompetences.Text = "Les competences";
            // 
            // lblCompetencesVisiteur
            // 
            this.lblCompetencesVisiteur.AutoSize = true;
            this.lblCompetencesVisiteur.Location = new System.Drawing.Point(432, 41);
            this.lblCompetencesVisiteur.Name = "lblCompetencesVisiteur";
            this.lblCompetencesVisiteur.Size = new System.Drawing.Size(62, 13);
            this.lblCompetencesVisiteur.TabIndex = 5;
            this.lblCompetencesVisiteur.Text = "Acquise(s) :";
            // 
            // lblCompetencesDispo
            // 
            this.lblCompetencesDispo.AutoSize = true;
            this.lblCompetencesDispo.Location = new System.Drawing.Point(22, 42);
            this.lblCompetencesDispo.Name = "lblCompetencesDispo";
            this.lblCompetencesDispo.Size = new System.Drawing.Size(73, 13);
            this.lblCompetencesDispo.TabIndex = 4;
            this.lblCompetencesDispo.Text = "Disponible(s) :";
            // 
            // chkCompetencesVisiteur
            // 
            this.chkCompetencesVisiteur.FormattingEnabled = true;
            this.chkCompetencesVisiteur.Location = new System.Drawing.Point(432, 68);
            this.chkCompetencesVisiteur.Name = "chkCompetencesVisiteur";
            this.chkCompetencesVisiteur.Size = new System.Drawing.Size(250, 124);
            this.chkCompetencesVisiteur.TabIndex = 3;
            // 
            // btnSupprCompetences
            // 
            this.btnSupprCompetences.Location = new System.Drawing.Point(318, 155);
            this.btnSupprCompetences.Name = "btnSupprCompetences";
            this.btnSupprCompetences.Size = new System.Drawing.Size(59, 43);
            this.btnSupprCompetences.TabIndex = 2;
            this.btnSupprCompetences.Text = "<<<";
            this.btnSupprCompetences.UseVisualStyleBackColor = true;
            this.btnSupprCompetences.Click += new System.EventHandler(this.btnSupprCompetences_Click);
            // 
            // btnAjoutCompetences
            // 
            this.btnAjoutCompetences.Location = new System.Drawing.Point(318, 68);
            this.btnAjoutCompetences.Name = "btnAjoutCompetences";
            this.btnAjoutCompetences.Size = new System.Drawing.Size(59, 43);
            this.btnAjoutCompetences.TabIndex = 1;
            this.btnAjoutCompetences.Text = ">>>";
            this.btnAjoutCompetences.UseVisualStyleBackColor = true;
            this.btnAjoutCompetences.Click += new System.EventHandler(this.btnAjoutCompetences_Click);
            // 
            // chkCompetencesDispo
            // 
            this.chkCompetencesDispo.FormattingEnabled = true;
            this.chkCompetencesDispo.Location = new System.Drawing.Point(22, 68);
            this.chkCompetencesDispo.Name = "chkCompetencesDispo";
            this.chkCompetencesDispo.Size = new System.Drawing.Size(250, 124);
            this.chkCompetencesDispo.TabIndex = 0;
            // 
            // tabVisParProd
            // 
            this.tabVisParProd.BackColor = System.Drawing.Color.SeaShell;
            this.tabVisParProd.Controls.Add(this.chart1);
            this.tabVisParProd.Location = new System.Drawing.Point(4, 25);
            this.tabVisParProd.Name = "tabVisParProd";
            this.tabVisParProd.Padding = new System.Windows.Forms.Padding(3);
            this.tabVisParProd.Size = new System.Drawing.Size(818, 482);
            this.tabVisParProd.TabIndex = 4;
            this.tabVisParProd.Text = "Visiteurs / produit";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(20, 16);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Nombre de visiteurs";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(780, 442);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabVisiteurAge
            // 
            this.tabVisiteurAge.BackColor = System.Drawing.Color.SeaShell;
            this.tabVisiteurAge.Controls.Add(this.chart2);
            this.tabVisiteurAge.Location = new System.Drawing.Point(4, 25);
            this.tabVisiteurAge.Name = "tabVisiteurAge";
            this.tabVisiteurAge.Padding = new System.Windows.Forms.Padding(3);
            this.tabVisiteurAge.Size = new System.Drawing.Size(818, 482);
            this.tabVisiteurAge.TabIndex = 5;
            this.tabVisiteurAge.Text = "Visiteurs / age";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(24, 21);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(768, 426);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Gainsboro;
            this.btnQuitter.Location = new System.Drawing.Point(686, 638);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(161, 43);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.AutoSize = true;
            this.lblBienvenue.Location = new System.Drawing.Point(29, 12);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(57, 13);
            this.lblBienvenue.TabIndex = 2;
            this.lblBienvenue.Text = "Bienvenue";
            // 
            // lblNomUserConnecte
            // 
            this.lblNomUserConnecte.AutoSize = true;
            this.lblNomUserConnecte.Location = new System.Drawing.Point(29, 31);
            this.lblNomUserConnecte.Name = "lblNomUserConnecte";
            this.lblNomUserConnecte.Size = new System.Drawing.Size(28, 13);
            this.lblNomUserConnecte.TabIndex = 3;
            this.lblNomUserConnecte.Text = "Nom";
            // 
            // lblFonctionUser
            // 
            this.lblFonctionUser.AutoSize = true;
            this.lblFonctionUser.Location = new System.Drawing.Point(29, 54);
            this.lblFonctionUser.Name = "lblFonctionUser";
            this.lblFonctionUser.Size = new System.Drawing.Size(48, 13);
            this.lblFonctionUser.TabIndex = 4;
            this.lblFonctionUser.Text = "Fonction";
            // 
            // btnDeconnecter
            // 
            this.btnDeconnecter.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDeconnecter.Location = new System.Drawing.Point(503, 638);
            this.btnDeconnecter.Name = "btnDeconnecter";
            this.btnDeconnecter.Size = new System.Drawing.Size(133, 43);
            this.btnDeconnecter.TabIndex = 5;
            this.btnDeconnecter.Text = "Se deconnecter";
            this.btnDeconnecter.UseVisualStyleBackColor = false;
            this.btnDeconnecter.Visible = false;
            this.btnDeconnecter.Click += new System.EventHandler(this.btnDeconnecter_Click);
            // 
            // picLogoPrincipal
            // 
            this.picLogoPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("picLogoPrincipal.Image")));
            this.picLogoPrincipal.Location = new System.Drawing.Point(437, 11);
            this.picLogoPrincipal.Name = "picLogoPrincipal";
            this.picLogoPrincipal.Size = new System.Drawing.Size(410, 75);
            this.picLogoPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoPrincipal.TabIndex = 5;
            this.picLogoPrincipal.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Libelle :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(886, 711);
            this.Controls.Add(this.picLogoPrincipal);
            this.Controls.Add(this.btnDeconnecter);
            this.Controls.Add(this.lblFonctionUser);
            this.Controls.Add(this.lblNomUserConnecte);
            this.Controls.Add(this.lblBienvenue);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Galaxy Swiss Bourdin - Gestion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabConnexion.ResumeLayout(false);
            this.tabConnexion.PerformLayout();
            this.tabVisiteur.ResumeLayout(false);
            this.tabVisiteur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurs)).EndInit();
            this.tabProduit.ResumeLayout(false);
            this.tabProduit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).EndInit();
            this.tabGestion.ResumeLayout(false);
            this.tabGestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurCompetences)).EndInit();
            this.grpCompetences.ResumeLayout(false);
            this.grpCompetences.PerformLayout();
            this.tabVisParProd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabVisiteurAge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabConnexion;
        private System.Windows.Forms.TabPage tabVisiteur;
        private System.Windows.Forms.TabPage tabProduit;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnConnecter;
        private System.Windows.Forms.TextBox txtMdpUser;
        private System.Windows.Forms.TextBox txtIdUser;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.Label lblNomUserConnecte;
        private System.Windows.Forms.Label lblFonctionUser;
        private System.Windows.Forms.Button btnDeconnecter;
        private System.Windows.Forms.DateTimePicker dtpNaissance;
        private System.Windows.Forms.DateTimePicker dtpEmbauche;
        private System.Windows.Forms.TextBox txtPrenomVisiteur;
        private System.Windows.Forms.TextBox txtNomVisiteur;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.Label lblDateEmbauche;
        private System.Windows.Forms.Label lblPrenomVisiteur;
        private System.Windows.Forms.Label lblNomVisiteur;
        private System.Windows.Forms.Button btnSupprimerVisiteur;
        private System.Windows.Forms.Button btnModifierVisiteur;
        private System.Windows.Forms.Button btnAjouterVisiteur;
        private System.Windows.Forms.DataGridView dgvVisiteurs;
        private System.Windows.Forms.TextBox txtLibelleProduit;
        private System.Windows.Forms.Button btnSupprimerProduit;
        private System.Windows.Forms.Button btnModifierProduit;
        private System.Windows.Forms.Button btnAjouterProduit;
        private System.Windows.Forms.PictureBox picLogoPrincipal;
        private System.Windows.Forms.TabPage tabGestion;
        private System.Windows.Forms.TabPage tabVisParProd;
        private System.Windows.Forms.GroupBox grpCompetences;
        private System.Windows.Forms.CheckedListBox chkCompetencesDispo;
        private System.Windows.Forms.Button btnAjoutCompetences;
        private System.Windows.Forms.DataGridView dgvProduits;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEmbauche;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNaissance;
        private System.Windows.Forms.Label lblChoixVisiteur;
        private System.Windows.Forms.CheckedListBox chkCompetencesVisiteur;
        private System.Windows.Forms.Button btnSupprCompetences;
        private System.Windows.Forms.DataGridView dgvVisiteurCompetences;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomVisCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomVisCom;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabVisiteurAge;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label lblCompetencesVisiteur;
        private System.Windows.Forms.Label lblCompetencesDispo;
        private System.Windows.Forms.Label label1;
    }
}


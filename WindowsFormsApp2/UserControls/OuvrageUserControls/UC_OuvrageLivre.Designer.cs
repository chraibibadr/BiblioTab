
namespace WindowsFormsApp2.UserControls.OuvrageUserControls
{
    partial class UC_OuvrageLivre
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.supprimerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.modifierBtn = new Guna.UI2.WinForms.Guna2Button();
            this.auteur = new Guna.UI2.WinForms.Guna2TextBox();
            this.ajouterBtn = new Guna.UI2.WinForms.Guna2Button();
            this.titre = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridLivres = new Guna.UI2.WinForms.Guna2DataGridView();
            this.editeur = new Guna.UI2.WinForms.Guna2TextBox();
            this.qte = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchName = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLivres)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 72);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gestion des livres";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // supprimerBtn
            // 
            this.supprimerBtn.Animated = true;
            this.supprimerBtn.AutoRoundedCorners = true;
            this.supprimerBtn.BackColor = System.Drawing.Color.Transparent;
            this.supprimerBtn.BorderRadius = 21;
            this.supprimerBtn.CheckedState.Parent = this.supprimerBtn;
            this.supprimerBtn.CustomImages.Parent = this.supprimerBtn;
            this.supprimerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supprimerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supprimerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supprimerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supprimerBtn.DisabledState.Parent = this.supprimerBtn;
            this.supprimerBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.supprimerBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.supprimerBtn.ForeColor = System.Drawing.Color.White;
            this.supprimerBtn.HoverState.Parent = this.supprimerBtn;
            this.supprimerBtn.IndicateFocus = true;
            this.supprimerBtn.Location = new System.Drawing.Point(453, 141);
            this.supprimerBtn.Name = "supprimerBtn";
            this.supprimerBtn.ShadowDecoration.Parent = this.supprimerBtn;
            this.supprimerBtn.Size = new System.Drawing.Size(129, 45);
            this.supprimerBtn.TabIndex = 15;
            this.supprimerBtn.Text = "Supprimer";
            this.supprimerBtn.Click += new System.EventHandler(this.supprimerBtn_Click);
            // 
            // modifierBtn
            // 
            this.modifierBtn.Animated = true;
            this.modifierBtn.AutoRoundedCorners = true;
            this.modifierBtn.BackColor = System.Drawing.Color.Transparent;
            this.modifierBtn.BorderRadius = 21;
            this.modifierBtn.CheckedState.Parent = this.modifierBtn;
            this.modifierBtn.CustomImages.Parent = this.modifierBtn;
            this.modifierBtn.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.modifierBtn.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.modifierBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.modifierBtn.DisabledState.ForeColor = System.Drawing.Color.Silver;
            this.modifierBtn.DisabledState.Parent = this.modifierBtn;
            this.modifierBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.modifierBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.modifierBtn.ForeColor = System.Drawing.Color.White;
            this.modifierBtn.HoverState.Parent = this.modifierBtn;
            this.modifierBtn.IndicateFocus = true;
            this.modifierBtn.Location = new System.Drawing.Point(318, 141);
            this.modifierBtn.Name = "modifierBtn";
            this.modifierBtn.ShadowDecoration.Parent = this.modifierBtn;
            this.modifierBtn.Size = new System.Drawing.Size(129, 45);
            this.modifierBtn.TabIndex = 14;
            this.modifierBtn.Text = "Modifier";
            this.modifierBtn.Click += new System.EventHandler(this.modifierBtn_Click);
            // 
            // auteur
            // 
            this.auteur.Animated = true;
            this.auteur.AutoRoundedCorners = true;
            this.auteur.BorderRadius = 17;
            this.auteur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.auteur.DefaultText = "";
            this.auteur.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.auteur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.auteur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.auteur.DisabledState.Parent = this.auteur;
            this.auteur.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.auteur.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.auteur.FocusedState.Parent = this.auteur;
            this.auteur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.auteur.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.auteur.HoverState.Parent = this.auteur;
            this.auteur.Location = new System.Drawing.Point(236, 83);
            this.auteur.Name = "auteur";
            this.auteur.PasswordChar = '\0';
            this.auteur.PlaceholderText = "L\'auteur";
            this.auteur.SelectedText = "";
            this.auteur.ShadowDecoration.Parent = this.auteur;
            this.auteur.Size = new System.Drawing.Size(146, 36);
            this.auteur.TabIndex = 12;
            this.auteur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ajouterBtn
            // 
            this.ajouterBtn.Animated = true;
            this.ajouterBtn.AutoRoundedCorners = true;
            this.ajouterBtn.BackColor = System.Drawing.Color.Transparent;
            this.ajouterBtn.BorderRadius = 21;
            this.ajouterBtn.CheckedState.Parent = this.ajouterBtn;
            this.ajouterBtn.CustomImages.Parent = this.ajouterBtn;
            this.ajouterBtn.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.ajouterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.ajouterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.ajouterBtn.DisabledState.ForeColor = System.Drawing.Color.Silver;
            this.ajouterBtn.DisabledState.Parent = this.ajouterBtn;
            this.ajouterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ajouterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ajouterBtn.ForeColor = System.Drawing.Color.White;
            this.ajouterBtn.HoverState.Parent = this.ajouterBtn;
            this.ajouterBtn.IndicateFocus = true;
            this.ajouterBtn.Location = new System.Drawing.Point(183, 141);
            this.ajouterBtn.Name = "ajouterBtn";
            this.ajouterBtn.ShadowDecoration.Parent = this.ajouterBtn;
            this.ajouterBtn.Size = new System.Drawing.Size(129, 45);
            this.ajouterBtn.TabIndex = 11;
            this.ajouterBtn.Text = "Ajouter";
            this.ajouterBtn.Click += new System.EventHandler(this.ajouterBtn_Click);
            // 
            // titre
            // 
            this.titre.Animated = true;
            this.titre.AutoRoundedCorners = true;
            this.titre.BorderRadius = 17;
            this.titre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.titre.DefaultText = "";
            this.titre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.titre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.titre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.titre.DisabledState.Parent = this.titre;
            this.titre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.titre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.titre.FocusedState.Parent = this.titre;
            this.titre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.titre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.titre.HoverState.Parent = this.titre;
            this.titre.Location = new System.Drawing.Point(84, 83);
            this.titre.Name = "titre";
            this.titre.PasswordChar = '\0';
            this.titre.PlaceholderText = "Le titre";
            this.titre.SelectedText = "";
            this.titre.ShadowDecoration.Parent = this.titre;
            this.titre.Size = new System.Drawing.Size(146, 36);
            this.titre.TabIndex = 10;
            this.titre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridLivres
            // 
            this.dataGridLivres.AllowUserToAddRows = false;
            this.dataGridLivres.AllowUserToDeleteRows = false;
            this.dataGridLivres.AllowUserToOrderColumns = true;
            this.dataGridLivres.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridLivres.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridLivres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridLivres.BackgroundColor = System.Drawing.Color.White;
            this.dataGridLivres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridLivres.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridLivres.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridLivres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridLivres.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridLivres.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridLivres.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridLivres.EnableHeadersVisualStyles = false;
            this.dataGridLivres.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridLivres.Location = new System.Drawing.Point(0, 202);
            this.dataGridLivres.Name = "dataGridLivres";
            this.dataGridLivres.ReadOnly = true;
            this.dataGridLivres.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridLivres.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridLivres.RowHeadersVisible = false;
            this.dataGridLivres.RowTemplate.Height = 25;
            this.dataGridLivres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLivres.Size = new System.Drawing.Size(771, 219);
            this.dataGridLivres.TabIndex = 9;
            this.dataGridLivres.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridLivres.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridLivres.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridLivres.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridLivres.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridLivres.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridLivres.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridLivres.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridLivres.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridLivres.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dataGridLivres.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridLivres.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridLivres.ThemeStyle.HeaderStyle.Height = 25;
            this.dataGridLivres.ThemeStyle.ReadOnly = true;
            this.dataGridLivres.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridLivres.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridLivres.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dataGridLivres.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridLivres.ThemeStyle.RowsStyle.Height = 25;
            this.dataGridLivres.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridLivres.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridLivres.Click += new System.EventHandler(this.dataGridLivres_Click);
            // 
            // editeur
            // 
            this.editeur.Animated = true;
            this.editeur.AutoRoundedCorners = true;
            this.editeur.BorderRadius = 17;
            this.editeur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editeur.DefaultText = "";
            this.editeur.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.editeur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.editeur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editeur.DisabledState.Parent = this.editeur;
            this.editeur.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editeur.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.editeur.FocusedState.Parent = this.editeur;
            this.editeur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editeur.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.editeur.HoverState.Parent = this.editeur;
            this.editeur.Location = new System.Drawing.Point(388, 83);
            this.editeur.Name = "editeur";
            this.editeur.PasswordChar = '\0';
            this.editeur.PlaceholderText = "L\'editeur";
            this.editeur.SelectedText = "";
            this.editeur.ShadowDecoration.Parent = this.editeur;
            this.editeur.Size = new System.Drawing.Size(146, 36);
            this.editeur.TabIndex = 17;
            this.editeur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // qte
            // 
            this.qte.Animated = true;
            this.qte.AutoRoundedCorners = true;
            this.qte.BorderRadius = 17;
            this.qte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qte.DefaultText = "";
            this.qte.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.qte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.qte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.qte.DisabledState.Parent = this.qte;
            this.qte.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.qte.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.qte.FocusedState.Parent = this.qte;
            this.qte.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.qte.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.qte.HoverState.Parent = this.qte;
            this.qte.Location = new System.Drawing.Point(540, 83);
            this.qte.Name = "qte";
            this.qte.PasswordChar = '\0';
            this.qte.PlaceholderText = "La quantite";
            this.qte.SelectedText = "";
            this.qte.ShadowDecoration.Parent = this.qte;
            this.qte.Size = new System.Drawing.Size(146, 36);
            this.qte.TabIndex = 13;
            this.qte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchName
            // 
            this.searchName.Animated = true;
            this.searchName.AutoRoundedCorners = true;
            this.searchName.BorderRadius = 12;
            this.searchName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchName.DefaultText = "";
            this.searchName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchName.DisabledState.Parent = this.searchName;
            this.searchName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.searchName.FocusedState.Parent = this.searchName;
            this.searchName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.searchName.HoverState.Parent = this.searchName;
            this.searchName.Location = new System.Drawing.Point(7, 170);
            this.searchName.Name = "searchName";
            this.searchName.PasswordChar = '\0';
            this.searchName.PlaceholderText = "Nom d\'ouvrage";
            this.searchName.SelectedText = "";
            this.searchName.ShadowDecoration.Parent = this.searchName;
            this.searchName.Size = new System.Drawing.Size(112, 26);
            this.searchName.TabIndex = 18;
            this.searchName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchName.TextChanged += new System.EventHandler(this.searchName_TextChanged);
            // 
            // UC_OuvrageLivre
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.searchName);
            this.Controls.Add(this.editeur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.supprimerBtn);
            this.Controls.Add(this.modifierBtn);
            this.Controls.Add(this.qte);
            this.Controls.Add(this.auteur);
            this.Controls.Add(this.ajouterBtn);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.dataGridLivres);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Name = "UC_OuvrageLivre";
            this.Size = new System.Drawing.Size(771, 421);
            this.Load += new System.EventHandler(this.UC_OuvrageLivre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLivres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button supprimerBtn;
        private Guna.UI2.WinForms.Guna2Button modifierBtn;
        private Guna.UI2.WinForms.Guna2TextBox auteur;
        private Guna.UI2.WinForms.Guna2Button ajouterBtn;
        private Guna.UI2.WinForms.Guna2TextBox titre;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridLivres;
        private Guna.UI2.WinForms.Guna2TextBox editeur;
        private Guna.UI2.WinForms.Guna2TextBox qte;
        private Guna.UI2.WinForms.Guna2TextBox searchName;
    }
}

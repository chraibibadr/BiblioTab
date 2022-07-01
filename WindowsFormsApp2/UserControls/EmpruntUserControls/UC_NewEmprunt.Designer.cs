
namespace WindowsFormsApp2.UserControls.EmpruntUserControls
{
    partial class UC_NewEmprunt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.emprunterBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cin = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridEmprunt = new Guna.UI2.WinForms.Guna2DataGridView();
            this.prenom = new Guna.UI2.WinForms.Guna2TextBox();
            this.tele = new Guna.UI2.WinForms.Guna2TextBox();
            this.nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.radioCD = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioPer = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioLivre = new Guna.UI2.WinForms.Guna2RadioButton();
            this.recherche = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateRP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmprunt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 42);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nouvel emprunt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emprunterBtn
            // 
            this.emprunterBtn.Animated = true;
            this.emprunterBtn.AutoRoundedCorners = true;
            this.emprunterBtn.BackColor = System.Drawing.Color.Transparent;
            this.emprunterBtn.BorderRadius = 17;
            this.emprunterBtn.CheckedState.Parent = this.emprunterBtn;
            this.emprunterBtn.CustomImages.Parent = this.emprunterBtn;
            this.emprunterBtn.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.emprunterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.emprunterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.emprunterBtn.DisabledState.ForeColor = System.Drawing.Color.Silver;
            this.emprunterBtn.DisabledState.Parent = this.emprunterBtn;
            this.emprunterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.emprunterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emprunterBtn.ForeColor = System.Drawing.Color.White;
            this.emprunterBtn.HoverState.Parent = this.emprunterBtn;
            this.emprunterBtn.IndicateFocus = true;
            this.emprunterBtn.Location = new System.Drawing.Point(322, 197);
            this.emprunterBtn.Name = "emprunterBtn";
            this.emprunterBtn.ShadowDecoration.Parent = this.emprunterBtn;
            this.emprunterBtn.Size = new System.Drawing.Size(129, 36);
            this.emprunterBtn.TabIndex = 7;
            this.emprunterBtn.Text = "Emprunter";
            this.emprunterBtn.Click += new System.EventHandler(this.emprunterBtn_Click);
            // 
            // cin
            // 
            this.cin.Animated = true;
            this.cin.AutoRoundedCorners = true;
            this.cin.BorderRadius = 17;
            this.cin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cin.DefaultText = "";
            this.cin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cin.DisabledState.Parent = this.cin;
            this.cin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.cin.FocusedState.Parent = this.cin;
            this.cin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.cin.HoverState.Parent = this.cin;
            this.cin.Location = new System.Drawing.Point(16, 149);
            this.cin.Name = "cin";
            this.cin.PasswordChar = '\0';
            this.cin.PlaceholderText = "CIN";
            this.cin.SelectedText = "";
            this.cin.ShadowDecoration.Parent = this.cin;
            this.cin.Size = new System.Drawing.Size(129, 36);
            this.cin.TabIndex = 2;
            this.cin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cin.TextChanged += new System.EventHandler(this.cin_TextChanged);
            // 
            // dataGridEmprunt
            // 
            this.dataGridEmprunt.AllowUserToAddRows = false;
            this.dataGridEmprunt.AllowUserToDeleteRows = false;
            this.dataGridEmprunt.AllowUserToOrderColumns = true;
            this.dataGridEmprunt.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridEmprunt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridEmprunt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmprunt.BackgroundColor = System.Drawing.Color.White;
            this.dataGridEmprunt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridEmprunt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridEmprunt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmprunt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridEmprunt.ColumnHeadersHeight = 25;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEmprunt.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridEmprunt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridEmprunt.EnableHeadersVisualStyles = false;
            this.dataGridEmprunt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridEmprunt.Location = new System.Drawing.Point(0, 239);
            this.dataGridEmprunt.Name = "dataGridEmprunt";
            this.dataGridEmprunt.ReadOnly = true;
            this.dataGridEmprunt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmprunt.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridEmprunt.RowHeadersVisible = false;
            this.dataGridEmprunt.RowTemplate.Height = 25;
            this.dataGridEmprunt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmprunt.Size = new System.Drawing.Size(771, 182);
            this.dataGridEmprunt.TabIndex = 11;
            this.dataGridEmprunt.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridEmprunt.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridEmprunt.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridEmprunt.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridEmprunt.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridEmprunt.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridEmprunt.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridEmprunt.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridEmprunt.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridEmprunt.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dataGridEmprunt.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridEmprunt.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridEmprunt.ThemeStyle.HeaderStyle.Height = 25;
            this.dataGridEmprunt.ThemeStyle.ReadOnly = true;
            this.dataGridEmprunt.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridEmprunt.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridEmprunt.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dataGridEmprunt.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridEmprunt.ThemeStyle.RowsStyle.Height = 25;
            this.dataGridEmprunt.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridEmprunt.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridEmprunt.Click += new System.EventHandler(this.dataGridEmprunt_Click);
            // 
            // prenom
            // 
            this.prenom.Animated = true;
            this.prenom.AutoRoundedCorners = true;
            this.prenom.BorderRadius = 17;
            this.prenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prenom.DefaultText = "";
            this.prenom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prenom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prenom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prenom.DisabledState.Parent = this.prenom;
            this.prenom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prenom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.prenom.FocusedState.Parent = this.prenom;
            this.prenom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prenom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.prenom.HoverState.Parent = this.prenom;
            this.prenom.Location = new System.Drawing.Point(322, 149);
            this.prenom.Name = "prenom";
            this.prenom.PasswordChar = '\0';
            this.prenom.PlaceholderText = "Prenom";
            this.prenom.SelectedText = "";
            this.prenom.ShadowDecoration.Parent = this.prenom;
            this.prenom.Size = new System.Drawing.Size(129, 36);
            this.prenom.TabIndex = 4;
            this.prenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tele
            // 
            this.tele.Animated = true;
            this.tele.AutoRoundedCorners = true;
            this.tele.BorderRadius = 17;
            this.tele.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tele.DefaultText = "";
            this.tele.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tele.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tele.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tele.DisabledState.Parent = this.tele;
            this.tele.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tele.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.tele.FocusedState.Parent = this.tele;
            this.tele.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tele.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.tele.HoverState.Parent = this.tele;
            this.tele.Location = new System.Drawing.Point(475, 149);
            this.tele.Name = "tele";
            this.tele.PasswordChar = '\0';
            this.tele.PlaceholderText = "Telephone";
            this.tele.SelectedText = "";
            this.tele.ShadowDecoration.Parent = this.tele;
            this.tele.Size = new System.Drawing.Size(129, 36);
            this.tele.TabIndex = 5;
            this.tele.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nom
            // 
            this.nom.Animated = true;
            this.nom.AutoRoundedCorners = true;
            this.nom.BorderRadius = 17;
            this.nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom.DefaultText = "";
            this.nom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom.DisabledState.Parent = this.nom;
            this.nom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.nom.FocusedState.Parent = this.nom;
            this.nom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.nom.HoverState.Parent = this.nom;
            this.nom.Location = new System.Drawing.Point(169, 149);
            this.nom.Name = "nom";
            this.nom.PasswordChar = '\0';
            this.nom.PlaceholderText = "Nom";
            this.nom.SelectedText = "";
            this.nom.ShadowDecoration.Parent = this.nom;
            this.nom.Size = new System.Drawing.Size(129, 36);
            this.nom.TabIndex = 3;
            this.nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioCD
            // 
            this.radioCD.AutoSize = true;
            this.radioCD.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.radioCD.CheckedState.BorderThickness = 0;
            this.radioCD.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.radioCD.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioCD.CheckedState.InnerOffset = -4;
            this.radioCD.Location = new System.Drawing.Point(255, 54);
            this.radioCD.Name = "radioCD";
            this.radioCD.Size = new System.Drawing.Size(50, 24);
            this.radioCD.TabIndex = 8;
            this.radioCD.Text = "CD";
            this.radioCD.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.radioCD.UncheckedState.BorderThickness = 2;
            this.radioCD.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioCD.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioCD.CheckedChanged += new System.EventHandler(this.radioCD_CheckedChanged);
            // 
            // radioPer
            // 
            this.radioPer.AutoSize = true;
            this.radioPer.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.radioPer.CheckedState.BorderThickness = 0;
            this.radioPer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.radioPer.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioPer.CheckedState.InnerOffset = -4;
            this.radioPer.Location = new System.Drawing.Point(341, 54);
            this.radioPer.Name = "radioPer";
            this.radioPer.Size = new System.Drawing.Size(106, 24);
            this.radioPer.TabIndex = 10;
            this.radioPer.Text = "Périodique";
            this.radioPer.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.radioPer.UncheckedState.BorderThickness = 2;
            this.radioPer.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioPer.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioPer.CheckedChanged += new System.EventHandler(this.radioPer_CheckedChanged);
            // 
            // radioLivre
            // 
            this.radioLivre.AutoSize = true;
            this.radioLivre.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.radioLivre.CheckedState.BorderThickness = 0;
            this.radioLivre.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.radioLivre.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioLivre.CheckedState.InnerOffset = -4;
            this.radioLivre.Location = new System.Drawing.Point(471, 54);
            this.radioLivre.Name = "radioLivre";
            this.radioLivre.Size = new System.Drawing.Size(62, 24);
            this.radioLivre.TabIndex = 9;
            this.radioLivre.Text = "Livre";
            this.radioLivre.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.radioLivre.UncheckedState.BorderThickness = 2;
            this.radioLivre.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioLivre.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioLivre.CheckedChanged += new System.EventHandler(this.radioLivre_CheckedChanged);
            // 
            // recherche
            // 
            this.recherche.Animated = true;
            this.recherche.AutoRoundedCorners = true;
            this.recherche.BorderRadius = 17;
            this.recherche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.recherche.DefaultText = "";
            this.recherche.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.recherche.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.recherche.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.recherche.DisabledState.Parent = this.recherche;
            this.recherche.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.recherche.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.recherche.FocusedState.Parent = this.recherche;
            this.recherche.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.recherche.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.recherche.HoverState.Parent = this.recherche;
            this.recherche.Location = new System.Drawing.Point(301, 89);
            this.recherche.Name = "recherche";
            this.recherche.PasswordChar = '\0';
            this.recherche.PlaceholderText = "Chercher l\'ouvrage";
            this.recherche.SelectedText = "";
            this.recherche.ShadowDecoration.Parent = this.recherche;
            this.recherche.Size = new System.Drawing.Size(177, 36);
            this.recherche.TabIndex = 1;
            this.recherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.recherche.TextChanged += new System.EventHandler(this.guna2TextBox4_TextChanged);
            // 
            // dateRP
            // 
            this.dateRP.Animated = true;
            this.dateRP.AutoRoundedCorners = true;
            this.dateRP.BackColor = System.Drawing.Color.Transparent;
            this.dateRP.BorderRadius = 17;
            this.dateRP.Checked = true;
            this.dateRP.CheckedState.FillColor = System.Drawing.Color.White;
            this.dateRP.CheckedState.Parent = this.dateRP;
            this.dateRP.FillColor = System.Drawing.Color.Empty;
            this.dateRP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateRP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.dateRP.HoverState.FillColor = System.Drawing.Color.Silver;
            this.dateRP.HoverState.Parent = this.dateRP;
            this.dateRP.IndicateFocus = true;
            this.dateRP.Location = new System.Drawing.Point(628, 149);
            this.dateRP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateRP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateRP.Name = "dateRP";
            this.dateRP.ShadowDecoration.Parent = this.dateRP;
            this.dateRP.Size = new System.Drawing.Size(129, 36);
            this.dateRP.TabIndex = 6;
            this.dateRP.UseTransparentBackground = true;
            this.dateRP.Value = new System.DateTime(2021, 12, 13, 0, 0, 0, 0);
            // 
            // UC_NewEmprunt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dateRP);
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.radioLivre);
            this.Controls.Add(this.radioPer);
            this.Controls.Add(this.radioCD);
            this.Controls.Add(this.tele);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emprunterBtn);
            this.Controls.Add(this.cin);
            this.Controls.Add(this.dataGridEmprunt);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Name = "UC_NewEmprunt";
            this.Size = new System.Drawing.Size(771, 421);
            this.Load += new System.EventHandler(this.UC_NewEmprunt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmprunt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button emprunterBtn;
        private Guna.UI2.WinForms.Guna2TextBox cin;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridEmprunt;
        private Guna.UI2.WinForms.Guna2TextBox prenom;
        private Guna.UI2.WinForms.Guna2TextBox tele;
        private Guna.UI2.WinForms.Guna2TextBox nom;
        private Guna.UI2.WinForms.Guna2RadioButton radioCD;
        private Guna.UI2.WinForms.Guna2RadioButton radioPer;
        private Guna.UI2.WinForms.Guna2RadioButton radioLivre;
        private Guna.UI2.WinForms.Guna2TextBox recherche;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateRP;
    }
}

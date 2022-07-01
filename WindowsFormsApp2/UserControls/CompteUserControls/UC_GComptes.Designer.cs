
namespace WindowsFormsApp2.UserControls.CompteUserControls
{
    partial class UC_GComptes
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
            this.role = new Guna.UI2.WinForms.Guna2ComboBox();
            this.password = new Guna.UI2.WinForms.Guna2TextBox();
            this.genererBtn = new Guna.UI2.WinForms.Guna2Button();
            this.username = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridComptes = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComptes)).BeginInit();
            this.SuspendLayout();
            // 
            // role
            // 
            this.role.AutoRoundedCorners = true;
            this.role.BackColor = System.Drawing.Color.Transparent;
            this.role.BorderRadius = 17;
            this.role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.role.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.role.FocusedState.Parent = this.role;
            this.role.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.role.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.role.HoverState.Parent = this.role;
            this.role.ItemHeight = 30;
            this.role.Items.AddRange(new object[] {
            "Role",
            "Administrateur",
            "Moderateur"});
            this.role.ItemsAppearance.Parent = this.role;
            this.role.Location = new System.Drawing.Point(211, 77);
            this.role.Name = "role";
            this.role.ShadowDecoration.Parent = this.role;
            this.role.Size = new System.Drawing.Size(140, 36);
            this.role.StartIndex = 0;
            this.role.TabIndex = 30;
            this.role.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password
            // 
            this.password.Animated = true;
            this.password.AutoRoundedCorners = true;
            this.password.BorderRadius = 17;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.DefaultText = "";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.Parent = this.password;
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.password.FocusedState.Parent = this.password;
            this.password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.password.HoverState.Parent = this.password;
            this.password.Location = new System.Drawing.Point(376, 141);
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.PlaceholderText = "Mot de passe";
            this.password.SelectedText = "";
            this.password.ShadowDecoration.Parent = this.password;
            this.password.Size = new System.Drawing.Size(146, 36);
            this.password.TabIndex = 29;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // genererBtn
            // 
            this.genererBtn.Animated = true;
            this.genererBtn.AutoRoundedCorners = true;
            this.genererBtn.BackColor = System.Drawing.Color.Transparent;
            this.genererBtn.BorderRadius = 17;
            this.genererBtn.CheckedState.Parent = this.genererBtn;
            this.genererBtn.CustomImages.Parent = this.genererBtn;
            this.genererBtn.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.genererBtn.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.genererBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.genererBtn.DisabledState.ForeColor = System.Drawing.Color.Silver;
            this.genererBtn.DisabledState.Parent = this.genererBtn;
            this.genererBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.genererBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.genererBtn.ForeColor = System.Drawing.Color.White;
            this.genererBtn.HoverState.Parent = this.genererBtn;
            this.genererBtn.IndicateFocus = true;
            this.genererBtn.Location = new System.Drawing.Point(400, 77);
            this.genererBtn.Name = "genererBtn";
            this.genererBtn.ShadowDecoration.Parent = this.genererBtn;
            this.genererBtn.Size = new System.Drawing.Size(140, 36);
            this.genererBtn.TabIndex = 28;
            this.genererBtn.Text = "Generer";
            this.genererBtn.Click += new System.EventHandler(this.genererBtn_Click);
            // 
            // username
            // 
            this.username.Animated = true;
            this.username.AutoRoundedCorners = true;
            this.username.BorderRadius = 17;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.DefaultText = "";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.Parent = this.username;
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.username.FocusedState.Parent = this.username;
            this.username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.username.HoverState.Parent = this.username;
            this.username.Location = new System.Drawing.Point(224, 141);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderText = "Nom d\'utilisateur";
            this.username.SelectedText = "";
            this.username.ShadowDecoration.Parent = this.username;
            this.username.Size = new System.Drawing.Size(146, 36);
            this.username.TabIndex = 27;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 72);
            this.label1.TabIndex = 31;
            this.label1.Text = "Génération des comptes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 17;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.Silver;
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(324, 186);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(94, 36);
            this.guna2Button1.TabIndex = 32;
            this.guna2Button1.Text = "Copier";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // dataGridComptes
            // 
            this.dataGridComptes.AllowUserToAddRows = false;
            this.dataGridComptes.AllowUserToDeleteRows = false;
            this.dataGridComptes.AllowUserToOrderColumns = true;
            this.dataGridComptes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridComptes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridComptes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridComptes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridComptes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridComptes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridComptes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridComptes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridComptes.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridComptes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridComptes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridComptes.EnableHeadersVisualStyles = false;
            this.dataGridComptes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridComptes.Location = new System.Drawing.Point(0, 248);
            this.dataGridComptes.Name = "dataGridComptes";
            this.dataGridComptes.ReadOnly = true;
            this.dataGridComptes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridComptes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridComptes.RowHeadersVisible = false;
            this.dataGridComptes.RowTemplate.Height = 25;
            this.dataGridComptes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridComptes.Size = new System.Drawing.Size(771, 173);
            this.dataGridComptes.TabIndex = 33;
            this.dataGridComptes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridComptes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridComptes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridComptes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridComptes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridComptes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridComptes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridComptes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridComptes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridComptes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dataGridComptes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridComptes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridComptes.ThemeStyle.HeaderStyle.Height = 25;
            this.dataGridComptes.ThemeStyle.ReadOnly = true;
            this.dataGridComptes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridComptes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridComptes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dataGridComptes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridComptes.ThemeStyle.RowsStyle.Height = 25;
            this.dataGridComptes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridComptes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridComptes.Click += new System.EventHandler(this.dataGridComptes_Click);
            // 
            // UC_GComptes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.dataGridComptes);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.role);
            this.Controls.Add(this.password);
            this.Controls.Add(this.genererBtn);
            this.Controls.Add(this.username);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Name = "UC_GComptes";
            this.Size = new System.Drawing.Size(771, 421);
            this.Load += new System.EventHandler(this.UC_GComptes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComptes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox role;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2Button genererBtn;
        private Guna.UI2.WinForms.Guna2TextBox username;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridComptes;
    }
}

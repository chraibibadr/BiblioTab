
namespace WindowsFormsApp2.UserControls.EmpruntUserControls
{
    partial class UC_GestionEmprunt
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
            this.validerEmpruntBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cin = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridEmprunt = new Guna.UI2.WinForms.Guna2DataGridView();
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
            this.label1.Size = new System.Drawing.Size(771, 72);
            this.label1.TabIndex = 20;
            this.label1.Text = "Gestion des emprunts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // validerEmpruntBtn
            // 
            this.validerEmpruntBtn.Animated = true;
            this.validerEmpruntBtn.AutoRoundedCorners = true;
            this.validerEmpruntBtn.BackColor = System.Drawing.Color.Transparent;
            this.validerEmpruntBtn.BorderRadius = 17;
            this.validerEmpruntBtn.CheckedState.Parent = this.validerEmpruntBtn;
            this.validerEmpruntBtn.CustomImages.Parent = this.validerEmpruntBtn;
            this.validerEmpruntBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.validerEmpruntBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.validerEmpruntBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.validerEmpruntBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.validerEmpruntBtn.DisabledState.Parent = this.validerEmpruntBtn;
            this.validerEmpruntBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.validerEmpruntBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.validerEmpruntBtn.ForeColor = System.Drawing.Color.White;
            this.validerEmpruntBtn.HoverState.Parent = this.validerEmpruntBtn;
            this.validerEmpruntBtn.IndicateFocus = true;
            this.validerEmpruntBtn.Location = new System.Drawing.Point(272, 141);
            this.validerEmpruntBtn.Name = "validerEmpruntBtn";
            this.validerEmpruntBtn.ShadowDecoration.Parent = this.validerEmpruntBtn;
            this.validerEmpruntBtn.Size = new System.Drawing.Size(200, 36);
            this.validerEmpruntBtn.TabIndex = 19;
            this.validerEmpruntBtn.Text = "Valider Emprunt";
            this.validerEmpruntBtn.UseTransparentBackground = true;
            this.validerEmpruntBtn.Click += new System.EventHandler(this.validerEmpruntBtn_Click);
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
            this.cin.Location = new System.Drawing.Point(272, 86);
            this.cin.Name = "cin";
            this.cin.PasswordChar = '\0';
            this.cin.PlaceholderText = "CIN du client a chercher";
            this.cin.SelectedText = "";
            this.cin.ShadowDecoration.Parent = this.cin;
            this.cin.Size = new System.Drawing.Size(200, 36);
            this.cin.TabIndex = 18;
            this.cin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cin.TextChanged += new System.EventHandler(this.cin_TextChanged);
            // 
            // dataGridEmprunt
            // 
            this.dataGridEmprunt.AllowUserToAddRows = false;
            this.dataGridEmprunt.AllowUserToDeleteRows = false;
            this.dataGridEmprunt.AllowUserToOrderColumns = true;
            this.dataGridEmprunt.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridEmprunt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridEmprunt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmprunt.BackgroundColor = System.Drawing.Color.White;
            this.dataGridEmprunt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridEmprunt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridEmprunt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmprunt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridEmprunt.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEmprunt.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridEmprunt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridEmprunt.EnableHeadersVisualStyles = false;
            this.dataGridEmprunt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridEmprunt.Location = new System.Drawing.Point(0, 200);
            this.dataGridEmprunt.Name = "dataGridEmprunt";
            this.dataGridEmprunt.ReadOnly = true;
            this.dataGridEmprunt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmprunt.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridEmprunt.RowHeadersVisible = false;
            this.dataGridEmprunt.RowTemplate.Height = 25;
            this.dataGridEmprunt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmprunt.Size = new System.Drawing.Size(771, 221);
            this.dataGridEmprunt.TabIndex = 21;
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
            this.dataGridEmprunt.Click += new System.EventHandler(this.dataGridEmprunt_Click_1);
            // 
            // UC_GestionEmprunt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dataGridEmprunt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.validerEmpruntBtn);
            this.Controls.Add(this.cin);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Name = "UC_GestionEmprunt";
            this.Size = new System.Drawing.Size(771, 421);
            this.Load += new System.EventHandler(this.UC_GestionEmprunt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmprunt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button validerEmpruntBtn;
        private Guna.UI2.WinForms.Guna2TextBox cin;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridEmprunt;
    }
}

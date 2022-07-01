
namespace WindowsFormsApp2.UserControls.EmpruntUserControls
{
    partial class CU_GEmprunt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.ajouterBtn = new Guna.UI2.WinForms.Guna2Button();
            this.titre = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridCD = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCD)).BeginInit();
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
            this.label1.Text = "Gestion des emprunts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ajouterBtn
            // 
            this.ajouterBtn.Animated = true;
            this.ajouterBtn.AutoRoundedCorners = true;
            this.ajouterBtn.BackColor = System.Drawing.Color.Transparent;
            this.ajouterBtn.BorderRadius = 17;
            this.ajouterBtn.CheckedState.Parent = this.ajouterBtn;
            this.ajouterBtn.CustomImages.Parent = this.ajouterBtn;
            this.ajouterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ajouterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ajouterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ajouterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ajouterBtn.DisabledState.Parent = this.ajouterBtn;
            this.ajouterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ajouterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ajouterBtn.ForeColor = System.Drawing.Color.White;
            this.ajouterBtn.HoverState.Parent = this.ajouterBtn;
            this.ajouterBtn.IndicateFocus = true;
            this.ajouterBtn.Location = new System.Drawing.Point(272, 141);
            this.ajouterBtn.Name = "ajouterBtn";
            this.ajouterBtn.ShadowDecoration.Parent = this.ajouterBtn;
            this.ajouterBtn.Size = new System.Drawing.Size(200, 36);
            this.ajouterBtn.TabIndex = 11;
            this.ajouterBtn.Text = "Chercher";
            this.ajouterBtn.UseTransparentBackground = true;
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
            this.titre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.titre.FocusedState.Parent = this.titre;
            this.titre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.titre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.titre.HoverState.Parent = this.titre;
            this.titre.Location = new System.Drawing.Point(272, 86);
            this.titre.Name = "titre";
            this.titre.PasswordChar = '\0';
            this.titre.PlaceholderText = "CIN du client";
            this.titre.SelectedText = "";
            this.titre.ShadowDecoration.Parent = this.titre;
            this.titre.Size = new System.Drawing.Size(200, 36);
            this.titre.TabIndex = 10;
            this.titre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridCD
            // 
            this.dataGridCD.AllowUserToAddRows = false;
            this.dataGridCD.AllowUserToDeleteRows = false;
            this.dataGridCD.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridCD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridCD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCD.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridCD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridCD.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCD.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridCD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridCD.EnableHeadersVisualStyles = false;
            this.dataGridCD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridCD.Location = new System.Drawing.Point(0, 202);
            this.dataGridCD.Name = "dataGridCD";
            this.dataGridCD.ReadOnly = true;
            this.dataGridCD.RowHeadersVisible = false;
            this.dataGridCD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCD.Size = new System.Drawing.Size(771, 219);
            this.dataGridCD.TabIndex = 9;
            this.dataGridCD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridCD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridCD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridCD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridCD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridCD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridCD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridCD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridCD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridCD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dataGridCD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridCD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridCD.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridCD.ThemeStyle.ReadOnly = true;
            this.dataGridCD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridCD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridCD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dataGridCD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridCD.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridCD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridCD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // CU_GEmprunt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ajouterBtn);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.dataGridCD);
            this.Name = "CU_GEmprunt";
            this.Size = new System.Drawing.Size(771, 421);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button ajouterBtn;
        private Guna.UI2.WinForms.Guna2TextBox titre;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridCD;
    }
}

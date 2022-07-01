
namespace WindowsFormsApp2.UserControls.CompteUserControls
{
    partial class UC_GestionComptes
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
            this.dataGridComptes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.stateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.usernameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComptes)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridComptes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridComptes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridComptes.EnableHeadersVisualStyles = false;
            this.dataGridComptes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridComptes.Location = new System.Drawing.Point(0, 195);
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
            this.dataGridComptes.Size = new System.Drawing.Size(771, 226);
            this.dataGridComptes.TabIndex = 34;
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
            this.dataGridComptes.SelectionChanged += new System.EventHandler(this.dataGridComptes_SelectionChanged);
            this.dataGridComptes.Click += new System.EventHandler(this.dataGridComptes_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 91);
            this.label1.TabIndex = 35;
            this.label1.Text = "Gestions des comptes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stateBtn
            // 
            this.stateBtn.Animated = true;
            this.stateBtn.AutoRoundedCorners = true;
            this.stateBtn.BackColor = System.Drawing.Color.Transparent;
            this.stateBtn.BorderRadius = 17;
            this.stateBtn.CheckedState.Parent = this.stateBtn;
            this.stateBtn.CustomImages.Parent = this.stateBtn;
            this.stateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.stateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.stateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.stateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.stateBtn.DisabledState.Parent = this.stateBtn;
            this.stateBtn.FillColor = System.Drawing.Color.IndianRed;
            this.stateBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stateBtn.ForeColor = System.Drawing.Color.White;
            this.stateBtn.HoverState.Parent = this.stateBtn;
            this.stateBtn.IndicateFocus = true;
            this.stateBtn.Location = new System.Drawing.Point(277, 149);
            this.stateBtn.Name = "stateBtn";
            this.stateBtn.ShadowDecoration.Parent = this.stateBtn;
            this.stateBtn.Size = new System.Drawing.Size(200, 36);
            this.stateBtn.TabIndex = 37;
            this.stateBtn.Text = "Desactiver le compte";
            this.stateBtn.UseTransparentBackground = true;
            this.stateBtn.Click += new System.EventHandler(this.stateBtn_Click);
            // 
            // usernameTxt
            // 
            this.usernameTxt.Animated = true;
            this.usernameTxt.AutoRoundedCorners = true;
            this.usernameTxt.BorderRadius = 17;
            this.usernameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTxt.DefaultText = "";
            this.usernameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTxt.DisabledState.Parent = this.usernameTxt;
            this.usernameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.usernameTxt.FocusedState.Parent = this.usernameTxt;
            this.usernameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.usernameTxt.HoverState.Parent = this.usernameTxt;
            this.usernameTxt.Location = new System.Drawing.Point(277, 94);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.PasswordChar = '\0';
            this.usernameTxt.PlaceholderText = "Nom d\'utilisateur a chercher";
            this.usernameTxt.SelectedText = "";
            this.usernameTxt.ShadowDecoration.Parent = this.usernameTxt;
            this.usernameTxt.Size = new System.Drawing.Size(200, 36);
            this.usernameTxt.TabIndex = 36;
            this.usernameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameTxt.TextChanged += new System.EventHandler(this.cin_TextChanged);
            // 
            // UC_GestionComptes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.stateBtn);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridComptes);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Name = "UC_GestionComptes";
            this.Size = new System.Drawing.Size(771, 421);
            this.Load += new System.EventHandler(this.UC_GestionComptes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComptes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridComptes;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button stateBtn;
        private Guna.UI2.WinForms.Guna2TextBox usernameTxt;
    }
}

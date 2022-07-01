
namespace WindowsFormsApp2.UserControls
{
    partial class UC_Ouvrage
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.livre = new Guna.UI2.WinForms.Guna2Button();
            this.cd = new Guna.UI2.WinForms.Guna2Button();
            this.periodique = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.livre);
            this.flowLayoutPanel1.Controls.Add(this.cd);
            this.flowLayoutPanel1.Controls.Add(this.periodique);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(771, 56);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // livre
            // 
            this.livre.BackColor = System.Drawing.Color.Transparent;
            this.livre.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.livre.Checked = true;
            this.livre.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(165)))), ((int)(((byte)(146)))));
            this.livre.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.livre.CheckedState.Parent = this.livre;
            this.livre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.livre.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.livre.CustomImages.Parent = this.livre;
            this.livre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.livre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.livre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.livre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.livre.DisabledState.Parent = this.livre;
            this.livre.FillColor = System.Drawing.Color.Transparent;
            this.livre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livre.ForeColor = System.Drawing.Color.Black;
            this.livre.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(165)))), ((int)(((byte)(146)))));
            this.livre.HoverState.Parent = this.livre;
            this.livre.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.livre.Location = new System.Drawing.Point(3, 3);
            this.livre.Name = "livre";
            this.livre.ShadowDecoration.Parent = this.livre;
            this.livre.Size = new System.Drawing.Size(250, 53);
            this.livre.TabIndex = 7;
            this.livre.Text = "Livre";
            this.livre.Click += new System.EventHandler(this.livre_Click);
            // 
            // cd
            // 
            this.cd.BackColor = System.Drawing.Color.Transparent;
            this.cd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.cd.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(165)))), ((int)(((byte)(146)))));
            this.cd.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cd.CheckedState.Parent = this.cd;
            this.cd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cd.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cd.CustomImages.Parent = this.cd;
            this.cd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cd.DisabledState.Parent = this.cd;
            this.cd.FillColor = System.Drawing.Color.Transparent;
            this.cd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd.ForeColor = System.Drawing.Color.Black;
            this.cd.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(165)))), ((int)(((byte)(146)))));
            this.cd.HoverState.Parent = this.cd;
            this.cd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cd.Location = new System.Drawing.Point(259, 3);
            this.cd.Name = "cd";
            this.cd.ShadowDecoration.Parent = this.cd;
            this.cd.Size = new System.Drawing.Size(250, 53);
            this.cd.TabIndex = 8;
            this.cd.Text = "CD";
            this.cd.Click += new System.EventHandler(this.cd_Click);
            // 
            // periodique
            // 
            this.periodique.BackColor = System.Drawing.Color.Transparent;
            this.periodique.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.periodique.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(165)))), ((int)(((byte)(146)))));
            this.periodique.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.periodique.CheckedState.Parent = this.periodique;
            this.periodique.Cursor = System.Windows.Forms.Cursors.Hand;
            this.periodique.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.periodique.CustomImages.Parent = this.periodique;
            this.periodique.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.periodique.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.periodique.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.periodique.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.periodique.DisabledState.Parent = this.periodique;
            this.periodique.FillColor = System.Drawing.Color.Transparent;
            this.periodique.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodique.ForeColor = System.Drawing.Color.Black;
            this.periodique.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(165)))), ((int)(((byte)(146)))));
            this.periodique.HoverState.Parent = this.periodique;
            this.periodique.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.periodique.Location = new System.Drawing.Point(515, 3);
            this.periodique.Name = "periodique";
            this.periodique.ShadowDecoration.Parent = this.periodique;
            this.periodique.Size = new System.Drawing.Size(250, 53);
            this.periodique.TabIndex = 9;
            this.periodique.Text = "Périodique";
            this.periodique.Click += new System.EventHandler(this.periodique_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 56);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(771, 421);
            this.panelContainer.TabIndex = 2;
            // 
            // UC_Ouvrage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UC_Ouvrage";
            this.Size = new System.Drawing.Size(771, 477);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button livre;
        private Guna.UI2.WinForms.Guna2Button cd;
        private Guna.UI2.WinForms.Guna2Button periodique;
        private System.Windows.Forms.Panel panelContainer;
    }
}

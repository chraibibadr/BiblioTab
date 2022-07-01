
namespace WindowsFormsApp2.UserControls
{
    partial class UC_Comptes
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
            this.generate = new Guna.UI2.WinForms.Guna2Button();
            this.comptes = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.generate);
            this.flowLayoutPanel1.Controls.Add(this.comptes);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(771, 56);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.Color.Transparent;
            this.generate.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.generate.Checked = true;
            this.generate.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(165)))), ((int)(((byte)(146)))));
            this.generate.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.generate.CheckedState.Parent = this.generate;
            this.generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generate.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.generate.CustomImages.Parent = this.generate;
            this.generate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generate.DisabledState.Parent = this.generate;
            this.generate.FillColor = System.Drawing.Color.Transparent;
            this.generate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.ForeColor = System.Drawing.Color.Black;
            this.generate.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(165)))), ((int)(((byte)(146)))));
            this.generate.HoverState.Parent = this.generate;
            this.generate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.generate.Location = new System.Drawing.Point(3, 3);
            this.generate.Name = "generate";
            this.generate.ShadowDecoration.Parent = this.generate;
            this.generate.Size = new System.Drawing.Size(373, 53);
            this.generate.TabIndex = 7;
            this.generate.Text = "Gestion des comptes";
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // comptes
            // 
            this.comptes.BackColor = System.Drawing.Color.Transparent;
            this.comptes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.comptes.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(165)))), ((int)(((byte)(146)))));
            this.comptes.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.comptes.CheckedState.Parent = this.comptes;
            this.comptes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comptes.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.comptes.CustomImages.Parent = this.comptes;
            this.comptes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.comptes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.comptes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.comptes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.comptes.DisabledState.Parent = this.comptes;
            this.comptes.FillColor = System.Drawing.Color.Transparent;
            this.comptes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comptes.ForeColor = System.Drawing.Color.Black;
            this.comptes.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(165)))), ((int)(((byte)(146)))));
            this.comptes.HoverState.Parent = this.comptes;
            this.comptes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.comptes.Location = new System.Drawing.Point(382, 3);
            this.comptes.Name = "comptes";
            this.comptes.ShadowDecoration.Parent = this.comptes;
            this.comptes.Size = new System.Drawing.Size(385, 53);
            this.comptes.TabIndex = 8;
            this.comptes.Text = "Generer un compte";
            this.comptes.Click += new System.EventHandler(this.comptes_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 56);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(771, 421);
            this.panelContainer.TabIndex = 1;
            // 
            // UC_Comptes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_Comptes";
            this.Size = new System.Drawing.Size(771, 477);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button generate;
        private Guna.UI2.WinForms.Guna2Button comptes;
        private System.Windows.Forms.Panel panelContainer;
    }
}

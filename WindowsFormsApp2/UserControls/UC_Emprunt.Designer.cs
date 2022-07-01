
namespace WindowsFormsApp2.UserControls
{
    partial class UC_Emprunt
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
            this.manageEmprunt = new Guna.UI2.WinForms.Guna2Button();
            this.addEmprunt = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.manageEmprunt);
            this.flowLayoutPanel1.Controls.Add(this.addEmprunt);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(771, 56);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // manageEmprunt
            // 
            this.manageEmprunt.BackColor = System.Drawing.Color.Transparent;
            this.manageEmprunt.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.manageEmprunt.Checked = true;
            this.manageEmprunt.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(165)))), ((int)(((byte)(146)))));
            this.manageEmprunt.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.manageEmprunt.CheckedState.Parent = this.manageEmprunt;
            this.manageEmprunt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageEmprunt.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.manageEmprunt.CustomImages.Parent = this.manageEmprunt;
            this.manageEmprunt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.manageEmprunt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.manageEmprunt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.manageEmprunt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.manageEmprunt.DisabledState.Parent = this.manageEmprunt;
            this.manageEmprunt.FillColor = System.Drawing.Color.Transparent;
            this.manageEmprunt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageEmprunt.ForeColor = System.Drawing.Color.Black;
            this.manageEmprunt.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(165)))), ((int)(((byte)(146)))));
            this.manageEmprunt.HoverState.Parent = this.manageEmprunt;
            this.manageEmprunt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.manageEmprunt.Location = new System.Drawing.Point(3, 3);
            this.manageEmprunt.Name = "manageEmprunt";
            this.manageEmprunt.ShadowDecoration.Parent = this.manageEmprunt;
            this.manageEmprunt.Size = new System.Drawing.Size(373, 53);
            this.manageEmprunt.TabIndex = 7;
            this.manageEmprunt.Text = "Gestion des emprunts";
            this.manageEmprunt.Click += new System.EventHandler(this.manageEmprunt_Click);
            // 
            // addEmprunt
            // 
            this.addEmprunt.BackColor = System.Drawing.Color.Transparent;
            this.addEmprunt.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.addEmprunt.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(165)))), ((int)(((byte)(146)))));
            this.addEmprunt.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.addEmprunt.CheckedState.Parent = this.addEmprunt;
            this.addEmprunt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmprunt.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.addEmprunt.CustomImages.Parent = this.addEmprunt;
            this.addEmprunt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addEmprunt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addEmprunt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addEmprunt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addEmprunt.DisabledState.Parent = this.addEmprunt;
            this.addEmprunt.FillColor = System.Drawing.Color.Transparent;
            this.addEmprunt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmprunt.ForeColor = System.Drawing.Color.Black;
            this.addEmprunt.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(165)))), ((int)(((byte)(146)))));
            this.addEmprunt.HoverState.Parent = this.addEmprunt;
            this.addEmprunt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addEmprunt.Location = new System.Drawing.Point(382, 3);
            this.addEmprunt.Name = "addEmprunt";
            this.addEmprunt.ShadowDecoration.Parent = this.addEmprunt;
            this.addEmprunt.Size = new System.Drawing.Size(385, 53);
            this.addEmprunt.TabIndex = 8;
            this.addEmprunt.Text = "Nouvel emprunt";
            this.addEmprunt.Click += new System.EventHandler(this.addEmprunt_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 56);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(771, 421);
            this.panelContainer.TabIndex = 2;
            // 
            // UC_Emprunt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UC_Emprunt";
            this.Size = new System.Drawing.Size(771, 477);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button manageEmprunt;
        private Guna.UI2.WinForms.Guna2Button addEmprunt;
        private System.Windows.Forms.Panel panelContainer;
    }
}

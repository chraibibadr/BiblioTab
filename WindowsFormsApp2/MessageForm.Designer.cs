
namespace WindowsFormsApp2
{
    partial class MessageForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.titre = new System.Windows.Forms.Label();
            this.yesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.noBtn = new Guna.UI2.WinForms.Guna2Button();
            this.message = new System.Windows.Forms.Label();
            this.okBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.guna2CircleButton1);
            this.panel1.Controls.Add(this.titre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 45);
            this.panel1.TabIndex = 0;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.Animated = true;
            this.guna2CircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.BorderColor = System.Drawing.Color.White;
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.DisabledState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Location = new System.Drawing.Point(349, 12);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(15, 15);
            this.guna2CircleButton1.TabIndex = 10;
            this.guna2CircleButton1.UseTransparentBackground = true;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // titre
            // 
            this.titre.Dock = System.Windows.Forms.DockStyle.Top;
            this.titre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.ForeColor = System.Drawing.Color.White;
            this.titre.Location = new System.Drawing.Point(0, 0);
            this.titre.Name = "titre";
            this.titre.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.titre.Size = new System.Drawing.Size(376, 45);
            this.titre.TabIndex = 9;
            this.titre.Text = "Suppression";
            this.titre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yesBtn
            // 
            this.yesBtn.Animated = true;
            this.yesBtn.BackColor = System.Drawing.Color.Transparent;
            this.yesBtn.BorderRadius = 5;
            this.yesBtn.CheckedState.Parent = this.yesBtn;
            this.yesBtn.CustomImages.Parent = this.yesBtn;
            this.yesBtn.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.yesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.yesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.yesBtn.DisabledState.ForeColor = System.Drawing.Color.Silver;
            this.yesBtn.DisabledState.Parent = this.yesBtn;
            this.yesBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.yesBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.yesBtn.ForeColor = System.Drawing.Color.White;
            this.yesBtn.HoverState.Parent = this.yesBtn;
            this.yesBtn.IndicateFocus = true;
            this.yesBtn.Location = new System.Drawing.Point(65, 126);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.ShadowDecoration.Parent = this.yesBtn;
            this.yesBtn.Size = new System.Drawing.Size(87, 34);
            this.yesBtn.TabIndex = 4;
            this.yesBtn.Text = "Oui";
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.Animated = true;
            this.noBtn.BackColor = System.Drawing.Color.Transparent;
            this.noBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.noBtn.BorderRadius = 5;
            this.noBtn.BorderThickness = 2;
            this.noBtn.CheckedState.Parent = this.noBtn;
            this.noBtn.CustomImages.Parent = this.noBtn;
            this.noBtn.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.noBtn.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.noBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.noBtn.DisabledState.ForeColor = System.Drawing.Color.Silver;
            this.noBtn.DisabledState.Parent = this.noBtn;
            this.noBtn.FillColor = System.Drawing.Color.Transparent;
            this.noBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.noBtn.ForeColor = System.Drawing.Color.Black;
            this.noBtn.HoverState.Parent = this.noBtn;
            this.noBtn.IndicateFocus = true;
            this.noBtn.Location = new System.Drawing.Point(218, 126);
            this.noBtn.Name = "noBtn";
            this.noBtn.ShadowDecoration.Parent = this.noBtn;
            this.noBtn.Size = new System.Drawing.Size(87, 34);
            this.noBtn.TabIndex = 5;
            this.noBtn.Text = "Non";
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // message
            // 
            this.message.Dock = System.Windows.Forms.DockStyle.Top;
            this.message.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.message.Location = new System.Drawing.Point(0, 45);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(376, 69);
            this.message.TabIndex = 9;
            this.message.Text = "Vouler vous supprimer ce cd ?";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okBtn
            // 
            this.okBtn.Animated = true;
            this.okBtn.BackColor = System.Drawing.Color.Transparent;
            this.okBtn.BorderRadius = 5;
            this.okBtn.CheckedState.Parent = this.okBtn;
            this.okBtn.CustomImages.Parent = this.okBtn;
            this.okBtn.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.okBtn.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.okBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.okBtn.DisabledState.ForeColor = System.Drawing.Color.Silver;
            this.okBtn.DisabledState.Parent = this.okBtn;
            this.okBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.okBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.okBtn.ForeColor = System.Drawing.Color.White;
            this.okBtn.HoverState.Parent = this.okBtn;
            this.okBtn.IndicateFocus = true;
            this.okBtn.Location = new System.Drawing.Point(105, 126);
            this.okBtn.Name = "okBtn";
            this.okBtn.ShadowDecoration.Parent = this.okBtn;
            this.okBtn.Size = new System.Drawing.Size(151, 34);
            this.okBtn.TabIndex = 10;
            this.okBtn.Text = "Ok";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(376, 171);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.message);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button yesBtn;
        private Guna.UI2.WinForms.Guna2Button noBtn;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Label message;
        private Guna.UI2.WinForms.Guna2Button okBtn;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}
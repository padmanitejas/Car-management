namespace Car_management
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel_Login = new System.Windows.Forms.Panel();
            this.Login = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panee_left = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Panel_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Login
            // 
            this.Panel_Login.Controls.Add(this.btnCancel);
            this.Panel_Login.Controls.Add(this.Login);
            this.Panel_Login.Controls.Add(this.axWindowsMediaPlayer1);
            this.Panel_Login.Controls.Add(this.panee_left);
            this.Panel_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Login.Location = new System.Drawing.Point(0, 0);
            this.Panel_Login.Name = "Panel_Login";
            this.Panel_Login.Size = new System.Drawing.Size(375, 136);
            this.Panel_Login.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(172, 101);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.AllowDrop = true;
            this.btnCancel.Location = new System.Drawing.Point(251, 101);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panee_left
            // 
            this.panee_left.BackgroundImage = global::Car_management.Properties.Resources.UserImage;
            this.panee_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panee_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panee_left.Location = new System.Drawing.Point(0, 0);
            this.panee_left.Name = "panee_left";
            this.panee_left.Size = new System.Drawing.Size(134, 136);
            this.panee_left.TabIndex = 1;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(134, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(241, 183);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 136);
            this.ControlBox = false;
            this.Controls.Add(this.Panel_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Panel_Login.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Login;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Panel panee_left;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}


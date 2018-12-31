namespace Zadaca2
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupBoxWelcome = new System.Windows.Forms.GroupBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonPotvrdiSif = new System.Windows.Forms.Button();
            this.textBoxSifra = new System.Windows.Forms.TextBox();
            this.labelSifra = new System.Windows.Forms.Label();
            this.errorProviderLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelError = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelNMK = new System.Windows.Forms.Label();
            this.groupBoxWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxWelcome
            // 
            this.groupBoxWelcome.BackColor = System.Drawing.Color.White;
            this.groupBoxWelcome.Controls.Add(this.labelUsername);
            this.groupBoxWelcome.Controls.Add(this.textBoxUsername);
            this.groupBoxWelcome.Controls.Add(this.buttonPotvrdiSif);
            this.groupBoxWelcome.Controls.Add(this.textBoxSifra);
            this.groupBoxWelcome.Controls.Add(this.labelSifra);
            this.groupBoxWelcome.Location = new System.Drawing.Point(210, 221);
            this.groupBoxWelcome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxWelcome.Name = "groupBoxWelcome";
            this.groupBoxWelcome.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxWelcome.Size = new System.Drawing.Size(358, 188);
            this.groupBoxWelcome.TabIndex = 5;
            this.groupBoxWelcome.TabStop = false;
            this.groupBoxWelcome.Text = "Dobro Dosli!";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(48, 53);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(64, 15);
            this.labelUsername.TabIndex = 7;
            this.labelUsername.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(123, 51);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(149, 22);
            this.textBoxUsername.TabIndex = 4;
            // 
            // buttonPotvrdiSif
            // 
            this.buttonPotvrdiSif.Location = new System.Drawing.Point(142, 145);
            this.buttonPotvrdiSif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPotvrdiSif.Name = "buttonPotvrdiSif";
            this.buttonPotvrdiSif.Size = new System.Drawing.Size(87, 26);
            this.buttonPotvrdiSif.TabIndex = 3;
            this.buttonPotvrdiSif.Text = "Potvrdi";
            this.buttonPotvrdiSif.UseVisualStyleBackColor = true;
            this.buttonPotvrdiSif.Click += new System.EventHandler(this.buttonPotvrdiSif_Click);
            // 
            // textBoxSifra
            // 
            this.textBoxSifra.Location = new System.Drawing.Point(123, 90);
            this.textBoxSifra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSifra.Name = "textBoxSifra";
            this.textBoxSifra.PasswordChar = '*';
            this.textBoxSifra.Size = new System.Drawing.Size(149, 22);
            this.textBoxSifra.TabIndex = 2;
            // 
            // labelSifra
            // 
            this.labelSifra.AutoSize = true;
            this.labelSifra.Location = new System.Drawing.Point(53, 90);
            this.labelSifra.Name = "labelSifra";
            this.labelSifra.Size = new System.Drawing.Size(34, 14);
            this.labelSifra.TabIndex = 0;
            this.labelSifra.Text = "Sifra:";
            // 
            // errorProviderLogin
            // 
            this.errorProviderLogin.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderLogin.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelError});
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(776, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelError
            // 
            this.toolStripStatusLabelError.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabelError.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelError.Name = "toolStripStatusLabelError";
            this.toolStripStatusLabelError.Size = new System.Drawing.Size(0, 17);
            // 
            // labelNMK
            // 
            this.labelNMK.AutoSize = true;
            this.labelNMK.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNMK.Location = new System.Drawing.Point(348, 86);
            this.labelNMK.Name = "labelNMK";
            this.labelNMK.Size = new System.Drawing.Size(59, 20);
            this.labelNMK.TabIndex = 8;
            this.labelNMK.Text = "NMK";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(776, 465);
            this.Controls.Add(this.labelNMK);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxWelcome);
            this.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_Paint);
            this.groupBoxWelcome.ResumeLayout(false);
            this.groupBoxWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxWelcome;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonPotvrdiSif;
        private System.Windows.Forms.TextBox textBoxSifra;
        private System.Windows.Forms.Label labelSifra;
        private System.Windows.Forms.ErrorProvider errorProviderLogin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelError;
        private System.Windows.Forms.Label labelNMK;
    }
}
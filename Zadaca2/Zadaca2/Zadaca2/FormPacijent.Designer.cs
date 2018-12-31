namespace Zadaca2
{
    partial class FormPacijent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPacijent));
            this.labelBracnoStanje = new System.Windows.Forms.Label();
            this.radioButtonSinglePac = new System.Windows.Forms.RadioButton();
            this.radioButtonUBrakuPac = new System.Windows.Forms.RadioButton();
            this.labelSpol = new System.Windows.Forms.Label();
            this.radioButtonZenskoPac = new System.Windows.Forms.RadioButton();
            this.radioButtonMuskoPac = new System.Windows.Forms.RadioButton();
            this.groupBoxSlika = new System.Windows.Forms.GroupBox();
            this.pictureBoxSlikaPacijenta = new System.Windows.Forms.PictureBox();
            this.textBoxAdresaPac = new System.Windows.Forms.TextBox();
            this.labelDatRo = new System.Windows.Forms.Label();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.dateTimePickerRodjenjePac = new System.Windows.Forms.DateTimePicker();
            this.textBoxJMBGPac = new System.Windows.Forms.TextBox();
            this.textBoxPrezimePac = new System.Windows.Forms.TextBox();
            this.textBoxImePac = new System.Windows.Forms.TextBox();
            this.labelJMBGPac = new System.Windows.Forms.Label();
            this.labelPrezimePac = new System.Windows.Forms.Label();
            this.labelImePac = new System.Windows.Forms.Label();
            this.menuStripPacijent = new System.Windows.Forms.MenuStrip();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripPacijent = new System.Windows.Forms.StatusStrip();
            this.tabControlLicniPodaciPac = new System.Windows.Forms.TabControl();
            this.tabPageLicniPod = new System.Windows.Forms.TabPage();
            this.tabPageKarton = new System.Windows.Forms.TabPage();
            this.groupBoxBolesti = new System.Windows.Forms.GroupBox();
            this.labeltrenbolesti = new System.Windows.Forms.Label();
            this.richTextBoxTrenBolesti = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAlergije = new System.Windows.Forms.RichTextBox();
            this.richTextBoxHistBolesti = new System.Windows.Forms.RichTextBox();
            this.richTextBoxPorodicneBol = new System.Windows.Forms.RichTextBox();
            this.labelPrevBolesti = new System.Windows.Forms.Label();
            this.labelAlergije = new System.Windows.Forms.Label();
            this.labelPorodicneBol = new System.Windows.Forms.Label();
            this.groupBoxTerapije = new System.Windows.Forms.GroupBox();
            this.richTextBoxPrevTer = new System.Windows.Forms.RichTextBox();
            this.richTextBoxTrenTer = new System.Windows.Forms.RichTextBox();
            this.labelSadasnjeTer = new System.Windows.Forms.Label();
            this.labelPrevTerapije = new System.Windows.Forms.Label();
            this.groupBoxSlika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaPacijenta)).BeginInit();
            this.menuStripPacijent.SuspendLayout();
            this.tabControlLicniPodaciPac.SuspendLayout();
            this.tabPageLicniPod.SuspendLayout();
            this.tabPageKarton.SuspendLayout();
            this.groupBoxBolesti.SuspendLayout();
            this.groupBoxTerapije.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBracnoStanje
            // 
            this.labelBracnoStanje.AutoSize = true;
            this.labelBracnoStanje.Location = new System.Drawing.Point(146, 400);
            this.labelBracnoStanje.Name = "labelBracnoStanje";
            this.labelBracnoStanje.Size = new System.Drawing.Size(81, 14);
            this.labelBracnoStanje.TabIndex = 11;
            this.labelBracnoStanje.Text = "Bracno stanje:";
            // 
            // radioButtonSinglePac
            // 
            this.radioButtonSinglePac.AutoCheck = false;
            this.radioButtonSinglePac.AutoSize = true;
            this.radioButtonSinglePac.Location = new System.Drawing.Point(524, 400);
            this.radioButtonSinglePac.Name = "radioButtonSinglePac";
            this.radioButtonSinglePac.Size = new System.Drawing.Size(56, 18);
            this.radioButtonSinglePac.TabIndex = 1;
            this.radioButtonSinglePac.TabStop = true;
            this.radioButtonSinglePac.Text = "Single";
            this.radioButtonSinglePac.UseVisualStyleBackColor = true;
            // 
            // radioButtonUBrakuPac
            // 
            this.radioButtonUBrakuPac.AutoCheck = false;
            this.radioButtonUBrakuPac.AutoSize = true;
            this.radioButtonUBrakuPac.Location = new System.Drawing.Point(347, 400);
            this.radioButtonUBrakuPac.Name = "radioButtonUBrakuPac";
            this.radioButtonUBrakuPac.Size = new System.Drawing.Size(68, 18);
            this.radioButtonUBrakuPac.TabIndex = 0;
            this.radioButtonUBrakuPac.TabStop = true;
            this.radioButtonUBrakuPac.Text = "U Braku";
            this.radioButtonUBrakuPac.UseVisualStyleBackColor = true;
            // 
            // labelSpol
            // 
            this.labelSpol.AutoSize = true;
            this.labelSpol.Location = new System.Drawing.Point(146, 281);
            this.labelSpol.Name = "labelSpol";
            this.labelSpol.Size = new System.Drawing.Size(32, 14);
            this.labelSpol.TabIndex = 10;
            this.labelSpol.Text = "Spol:";
            // 
            // radioButtonZenskoPac
            // 
            this.radioButtonZenskoPac.AutoCheck = false;
            this.radioButtonZenskoPac.AutoSize = true;
            this.radioButtonZenskoPac.Location = new System.Drawing.Point(518, 279);
            this.radioButtonZenskoPac.Name = "radioButtonZenskoPac";
            this.radioButtonZenskoPac.Size = new System.Drawing.Size(62, 18);
            this.radioButtonZenskoPac.TabIndex = 1;
            this.radioButtonZenskoPac.TabStop = true;
            this.radioButtonZenskoPac.Text = "Zensko";
            this.radioButtonZenskoPac.UseVisualStyleBackColor = true;
            // 
            // radioButtonMuskoPac
            // 
            this.radioButtonMuskoPac.AutoCheck = false;
            this.radioButtonMuskoPac.AutoSize = true;
            this.radioButtonMuskoPac.Location = new System.Drawing.Point(347, 279);
            this.radioButtonMuskoPac.Name = "radioButtonMuskoPac";
            this.radioButtonMuskoPac.Size = new System.Drawing.Size(60, 18);
            this.radioButtonMuskoPac.TabIndex = 0;
            this.radioButtonMuskoPac.TabStop = true;
            this.radioButtonMuskoPac.Text = "Musko";
            this.radioButtonMuskoPac.UseVisualStyleBackColor = true;
            // 
            // groupBoxSlika
            // 
            this.groupBoxSlika.Controls.Add(this.pictureBoxSlikaPacijenta);
            this.groupBoxSlika.Location = new System.Drawing.Point(271, 26);
            this.groupBoxSlika.Name = "groupBoxSlika";
            this.groupBoxSlika.Size = new System.Drawing.Size(136, 162);
            this.groupBoxSlika.TabIndex = 5;
            this.groupBoxSlika.TabStop = false;
            this.groupBoxSlika.Text = "Slika";
            // 
            // pictureBoxSlikaPacijenta
            // 
            this.pictureBoxSlikaPacijenta.Location = new System.Drawing.Point(13, 19);
            this.pictureBoxSlikaPacijenta.Name = "pictureBoxSlikaPacijenta";
            this.pictureBoxSlikaPacijenta.Size = new System.Drawing.Size(117, 136);
            this.pictureBoxSlikaPacijenta.TabIndex = 0;
            this.pictureBoxSlikaPacijenta.TabStop = false;
            // 
            // textBoxAdresaPac
            // 
            this.textBoxAdresaPac.Location = new System.Drawing.Point(347, 366);
            this.textBoxAdresaPac.Name = "textBoxAdresaPac";
            this.textBoxAdresaPac.ReadOnly = true;
            this.textBoxAdresaPac.Size = new System.Drawing.Size(233, 22);
            this.textBoxAdresaPac.TabIndex = 9;
            // 
            // labelDatRo
            // 
            this.labelDatRo.AutoSize = true;
            this.labelDatRo.Location = new System.Drawing.Point(146, 340);
            this.labelDatRo.Name = "labelDatRo";
            this.labelDatRo.Size = new System.Drawing.Size(95, 14);
            this.labelDatRo.TabIndex = 3;
            this.labelDatRo.Text = "Datum Rodjenja:";
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Location = new System.Drawing.Point(146, 369);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(47, 14);
            this.labelAdresa.TabIndex = 8;
            this.labelAdresa.Text = "Adresa:";
            // 
            // dateTimePickerRodjenjePac
            // 
            this.dateTimePickerRodjenjePac.Checked = false;
            this.dateTimePickerRodjenjePac.Location = new System.Drawing.Point(347, 338);
            this.dateTimePickerRodjenjePac.Name = "dateTimePickerRodjenjePac";
            this.dateTimePickerRodjenjePac.Size = new System.Drawing.Size(233, 22);
            this.dateTimePickerRodjenjePac.TabIndex = 7;
            // 
            // textBoxJMBGPac
            // 
            this.textBoxJMBGPac.Location = new System.Drawing.Point(347, 307);
            this.textBoxJMBGPac.Name = "textBoxJMBGPac";
            this.textBoxJMBGPac.ReadOnly = true;
            this.textBoxJMBGPac.Size = new System.Drawing.Size(233, 22);
            this.textBoxJMBGPac.TabIndex = 6;
            // 
            // textBoxPrezimePac
            // 
            this.textBoxPrezimePac.Location = new System.Drawing.Point(347, 250);
            this.textBoxPrezimePac.Name = "textBoxPrezimePac";
            this.textBoxPrezimePac.ReadOnly = true;
            this.textBoxPrezimePac.Size = new System.Drawing.Size(233, 22);
            this.textBoxPrezimePac.TabIndex = 5;
            // 
            // textBoxImePac
            // 
            this.textBoxImePac.Location = new System.Drawing.Point(347, 222);
            this.textBoxImePac.Name = "textBoxImePac";
            this.textBoxImePac.ReadOnly = true;
            this.textBoxImePac.Size = new System.Drawing.Size(233, 22);
            this.textBoxImePac.TabIndex = 4;
            // 
            // labelJMBGPac
            // 
            this.labelJMBGPac.AutoSize = true;
            this.labelJMBGPac.Location = new System.Drawing.Point(146, 311);
            this.labelJMBGPac.Name = "labelJMBGPac";
            this.labelJMBGPac.Size = new System.Drawing.Size(40, 14);
            this.labelJMBGPac.TabIndex = 2;
            this.labelJMBGPac.Text = "JMBG:";
            // 
            // labelPrezimePac
            // 
            this.labelPrezimePac.AutoSize = true;
            this.labelPrezimePac.Location = new System.Drawing.Point(146, 252);
            this.labelPrezimePac.Name = "labelPrezimePac";
            this.labelPrezimePac.Size = new System.Drawing.Size(53, 14);
            this.labelPrezimePac.TabIndex = 1;
            this.labelPrezimePac.Text = "Prezime:";
            // 
            // labelImePac
            // 
            this.labelImePac.AutoSize = true;
            this.labelImePac.Location = new System.Drawing.Point(146, 224);
            this.labelImePac.Name = "labelImePac";
            this.labelImePac.Size = new System.Drawing.Size(30, 14);
            this.labelImePac.TabIndex = 0;
            this.labelImePac.Text = "Ime:";
            // 
            // menuStripPacijent
            // 
            this.menuStripPacijent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(173)))), ((int)(((byte)(138)))));
            this.menuStripPacijent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odjavaToolStripMenuItem});
            this.menuStripPacijent.Location = new System.Drawing.Point(0, 0);
            this.menuStripPacijent.Name = "menuStripPacijent";
            this.menuStripPacijent.Size = new System.Drawing.Size(700, 24);
            this.menuStripPacijent.TabIndex = 3;
            this.menuStripPacijent.Text = "menuStrip1";
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // statusStripPacijent
            // 
            this.statusStripPacijent.Location = new System.Drawing.Point(0, 490);
            this.statusStripPacijent.Name = "statusStripPacijent";
            this.statusStripPacijent.Size = new System.Drawing.Size(700, 22);
            this.statusStripPacijent.TabIndex = 4;
            this.statusStripPacijent.Text = "statusStrip1";
            // 
            // tabControlLicniPodaciPac
            // 
            this.tabControlLicniPodaciPac.Controls.Add(this.tabPageLicniPod);
            this.tabControlLicniPodaciPac.Controls.Add(this.tabPageKarton);
            this.tabControlLicniPodaciPac.Location = new System.Drawing.Point(4, 27);
            this.tabControlLicniPodaciPac.Name = "tabControlLicniPodaciPac";
            this.tabControlLicniPodaciPac.SelectedIndex = 0;
            this.tabControlLicniPodaciPac.Size = new System.Drawing.Size(693, 459);
            this.tabControlLicniPodaciPac.TabIndex = 5;
            // 
            // tabPageLicniPod
            // 
            this.tabPageLicniPod.Controls.Add(this.labelBracnoStanje);
            this.tabPageLicniPod.Controls.Add(this.radioButtonSinglePac);
            this.tabPageLicniPod.Controls.Add(this.radioButtonUBrakuPac);
            this.tabPageLicniPod.Controls.Add(this.groupBoxSlika);
            this.tabPageLicniPod.Controls.Add(this.labelSpol);
            this.tabPageLicniPod.Controls.Add(this.labelImePac);
            this.tabPageLicniPod.Controls.Add(this.radioButtonZenskoPac);
            this.tabPageLicniPod.Controls.Add(this.labelPrezimePac);
            this.tabPageLicniPod.Controls.Add(this.radioButtonMuskoPac);
            this.tabPageLicniPod.Controls.Add(this.labelJMBGPac);
            this.tabPageLicniPod.Controls.Add(this.textBoxAdresaPac);
            this.tabPageLicniPod.Controls.Add(this.textBoxImePac);
            this.tabPageLicniPod.Controls.Add(this.labelDatRo);
            this.tabPageLicniPod.Controls.Add(this.textBoxPrezimePac);
            this.tabPageLicniPod.Controls.Add(this.labelAdresa);
            this.tabPageLicniPod.Controls.Add(this.textBoxJMBGPac);
            this.tabPageLicniPod.Controls.Add(this.dateTimePickerRodjenjePac);
            this.tabPageLicniPod.Location = new System.Drawing.Point(4, 23);
            this.tabPageLicniPod.Name = "tabPageLicniPod";
            this.tabPageLicniPod.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLicniPod.Size = new System.Drawing.Size(685, 432);
            this.tabPageLicniPod.TabIndex = 0;
            this.tabPageLicniPod.Text = "Licni Podaci";
            this.tabPageLicniPod.UseVisualStyleBackColor = true;
            // 
            // tabPageKarton
            // 
            this.tabPageKarton.Controls.Add(this.groupBoxBolesti);
            this.tabPageKarton.Controls.Add(this.groupBoxTerapije);
            this.tabPageKarton.Location = new System.Drawing.Point(4, 23);
            this.tabPageKarton.Name = "tabPageKarton";
            this.tabPageKarton.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKarton.Size = new System.Drawing.Size(685, 432);
            this.tabPageKarton.TabIndex = 1;
            this.tabPageKarton.Text = "Karton";
            this.tabPageKarton.UseVisualStyleBackColor = true;
            // 
            // groupBoxBolesti
            // 
            this.groupBoxBolesti.Controls.Add(this.labeltrenbolesti);
            this.groupBoxBolesti.Controls.Add(this.richTextBoxTrenBolesti);
            this.groupBoxBolesti.Controls.Add(this.richTextBoxAlergije);
            this.groupBoxBolesti.Controls.Add(this.richTextBoxHistBolesti);
            this.groupBoxBolesti.Controls.Add(this.richTextBoxPorodicneBol);
            this.groupBoxBolesti.Controls.Add(this.labelPrevBolesti);
            this.groupBoxBolesti.Controls.Add(this.labelAlergije);
            this.groupBoxBolesti.Controls.Add(this.labelPorodicneBol);
            this.groupBoxBolesti.Location = new System.Drawing.Point(16, 41);
            this.groupBoxBolesti.Name = "groupBoxBolesti";
            this.groupBoxBolesti.Size = new System.Drawing.Size(318, 368);
            this.groupBoxBolesti.TabIndex = 21;
            this.groupBoxBolesti.TabStop = false;
            this.groupBoxBolesti.Text = "Bolesti";
            // 
            // labeltrenbolesti
            // 
            this.labeltrenbolesti.AutoSize = true;
            this.labeltrenbolesti.Location = new System.Drawing.Point(24, 252);
            this.labeltrenbolesti.Name = "labeltrenbolesti";
            this.labeltrenbolesti.Size = new System.Drawing.Size(139, 14);
            this.labeltrenbolesti.TabIndex = 23;
            this.labeltrenbolesti.Text = "Trenutne bolesti i tegobe:";
            // 
            // richTextBoxTrenBolesti
            // 
            this.richTextBoxTrenBolesti.Location = new System.Drawing.Point(27, 268);
            this.richTextBoxTrenBolesti.Name = "richTextBoxTrenBolesti";
            this.richTextBoxTrenBolesti.ReadOnly = true;
            this.richTextBoxTrenBolesti.Size = new System.Drawing.Size(271, 64);
            this.richTextBoxTrenBolesti.TabIndex = 22;
            this.richTextBoxTrenBolesti.Text = "";
            // 
            // richTextBoxAlergije
            // 
            this.richTextBoxAlergije.Location = new System.Drawing.Point(27, 208);
            this.richTextBoxAlergije.Name = "richTextBoxAlergije";
            this.richTextBoxAlergije.ReadOnly = true;
            this.richTextBoxAlergije.Size = new System.Drawing.Size(271, 31);
            this.richTextBoxAlergije.TabIndex = 21;
            this.richTextBoxAlergije.Text = "";
            // 
            // richTextBoxHistBolesti
            // 
            this.richTextBoxHistBolesti.Location = new System.Drawing.Point(27, 127);
            this.richTextBoxHistBolesti.Name = "richTextBoxHistBolesti";
            this.richTextBoxHistBolesti.ReadOnly = true;
            this.richTextBoxHistBolesti.Size = new System.Drawing.Size(271, 55);
            this.richTextBoxHistBolesti.TabIndex = 20;
            this.richTextBoxHistBolesti.Text = "";
            // 
            // richTextBoxPorodicneBol
            // 
            this.richTextBoxPorodicneBol.Location = new System.Drawing.Point(27, 50);
            this.richTextBoxPorodicneBol.Name = "richTextBoxPorodicneBol";
            this.richTextBoxPorodicneBol.ReadOnly = true;
            this.richTextBoxPorodicneBol.Size = new System.Drawing.Size(271, 46);
            this.richTextBoxPorodicneBol.TabIndex = 19;
            this.richTextBoxPorodicneBol.Text = "";
            // 
            // labelPrevBolesti
            // 
            this.labelPrevBolesti.AutoSize = true;
            this.labelPrevBolesti.Location = new System.Drawing.Point(24, 111);
            this.labelPrevBolesti.Name = "labelPrevBolesti";
            this.labelPrevBolesti.Size = new System.Drawing.Size(96, 14);
            this.labelPrevBolesti.TabIndex = 18;
            this.labelPrevBolesti.Text = "Historijat bolesti:";
            // 
            // labelAlergije
            // 
            this.labelAlergije.AutoSize = true;
            this.labelAlergije.Location = new System.Drawing.Point(24, 192);
            this.labelAlergije.Name = "labelAlergije";
            this.labelAlergije.Size = new System.Drawing.Size(50, 14);
            this.labelAlergije.TabIndex = 17;
            this.labelAlergije.Text = "Alergije:";
            // 
            // labelPorodicneBol
            // 
            this.labelPorodicneBol.AutoSize = true;
            this.labelPorodicneBol.Location = new System.Drawing.Point(24, 33);
            this.labelPorodicneBol.Name = "labelPorodicneBol";
            this.labelPorodicneBol.Size = new System.Drawing.Size(100, 14);
            this.labelPorodicneBol.TabIndex = 16;
            this.labelPorodicneBol.Text = "Porodicne Bolesti:";
            // 
            // groupBoxTerapije
            // 
            this.groupBoxTerapije.Controls.Add(this.richTextBoxPrevTer);
            this.groupBoxTerapije.Controls.Add(this.richTextBoxTrenTer);
            this.groupBoxTerapije.Controls.Add(this.labelSadasnjeTer);
            this.groupBoxTerapije.Controls.Add(this.labelPrevTerapije);
            this.groupBoxTerapije.Location = new System.Drawing.Point(351, 114);
            this.groupBoxTerapije.Name = "groupBoxTerapije";
            this.groupBoxTerapije.Size = new System.Drawing.Size(319, 206);
            this.groupBoxTerapije.TabIndex = 20;
            this.groupBoxTerapije.TabStop = false;
            this.groupBoxTerapije.Text = "Terapije";
            // 
            // richTextBoxPrevTer
            // 
            this.richTextBoxPrevTer.Location = new System.Drawing.Point(30, 50);
            this.richTextBoxPrevTer.Name = "richTextBoxPrevTer";
            this.richTextBoxPrevTer.ReadOnly = true;
            this.richTextBoxPrevTer.Size = new System.Drawing.Size(271, 46);
            this.richTextBoxPrevTer.TabIndex = 19;
            this.richTextBoxPrevTer.Text = "";
            // 
            // richTextBoxTrenTer
            // 
            this.richTextBoxTrenTer.Location = new System.Drawing.Point(30, 135);
            this.richTextBoxTrenTer.Name = "richTextBoxTrenTer";
            this.richTextBoxTrenTer.ReadOnly = true;
            this.richTextBoxTrenTer.Size = new System.Drawing.Size(271, 46);
            this.richTextBoxTrenTer.TabIndex = 18;
            this.richTextBoxTrenTer.Text = "";
            // 
            // labelSadasnjeTer
            // 
            this.labelSadasnjeTer.AutoSize = true;
            this.labelSadasnjeTer.Location = new System.Drawing.Point(27, 118);
            this.labelSadasnjeTer.Name = "labelSadasnjeTer";
            this.labelSadasnjeTer.Size = new System.Drawing.Size(58, 14);
            this.labelSadasnjeTer.TabIndex = 16;
            this.labelSadasnjeTer.Text = "Trenutne:";
            // 
            // labelPrevTerapije
            // 
            this.labelPrevTerapije.AutoSize = true;
            this.labelPrevTerapije.Location = new System.Drawing.Point(27, 33);
            this.labelPrevTerapije.Name = "labelPrevTerapije";
            this.labelPrevTerapije.Size = new System.Drawing.Size(70, 14);
            this.labelPrevTerapije.TabIndex = 17;
            this.labelPrevTerapije.Text = "Dosadasnje:";
            // 
            // FormPacijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(700, 512);
            this.Controls.Add(this.tabControlLicniPodaciPac);
            this.Controls.Add(this.statusStripPacijent);
            this.Controls.Add(this.menuStripPacijent);
            this.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripPacijent;
            this.Name = "FormPacijent";
            this.Text = "Pacijent";
            this.Load += new System.EventHandler(this.FormPacijent_Load);
            this.groupBoxSlika.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaPacijenta)).EndInit();
            this.menuStripPacijent.ResumeLayout(false);
            this.menuStripPacijent.PerformLayout();
            this.tabControlLicniPodaciPac.ResumeLayout(false);
            this.tabPageLicniPod.ResumeLayout(false);
            this.tabPageLicniPod.PerformLayout();
            this.tabPageKarton.ResumeLayout(false);
            this.groupBoxBolesti.ResumeLayout(false);
            this.groupBoxBolesti.PerformLayout();
            this.groupBoxTerapije.ResumeLayout(false);
            this.groupBoxTerapije.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelBracnoStanje;
        private System.Windows.Forms.RadioButton radioButtonSinglePac;
        private System.Windows.Forms.RadioButton radioButtonUBrakuPac;
        private System.Windows.Forms.Label labelSpol;
        private System.Windows.Forms.RadioButton radioButtonZenskoPac;
        private System.Windows.Forms.RadioButton radioButtonMuskoPac;
        private System.Windows.Forms.GroupBox groupBoxSlika;
        private System.Windows.Forms.PictureBox pictureBoxSlikaPacijenta;
        private System.Windows.Forms.TextBox textBoxAdresaPac;
        private System.Windows.Forms.Label labelDatRo;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.DateTimePicker dateTimePickerRodjenjePac;
        private System.Windows.Forms.TextBox textBoxJMBGPac;
        private System.Windows.Forms.TextBox textBoxPrezimePac;
        private System.Windows.Forms.TextBox textBoxImePac;
        private System.Windows.Forms.Label labelJMBGPac;
        private System.Windows.Forms.Label labelPrezimePac;
        private System.Windows.Forms.Label labelImePac;
        private System.Windows.Forms.MenuStrip menuStripPacijent;
        private System.Windows.Forms.StatusStrip statusStripPacijent;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlLicniPodaciPac;
        private System.Windows.Forms.TabPage tabPageLicniPod;
        private System.Windows.Forms.TabPage tabPageKarton;
        private System.Windows.Forms.GroupBox groupBoxBolesti;
        private System.Windows.Forms.GroupBox groupBoxTerapije;
        private System.Windows.Forms.RichTextBox richTextBoxPrevTer;
        private System.Windows.Forms.RichTextBox richTextBoxTrenTer;
        private System.Windows.Forms.Label labelSadasnjeTer;
        private System.Windows.Forms.Label labelPrevTerapije;
        private System.Windows.Forms.Label labeltrenbolesti;
        private System.Windows.Forms.RichTextBox richTextBoxTrenBolesti;
        private System.Windows.Forms.RichTextBox richTextBoxAlergije;
        private System.Windows.Forms.RichTextBox richTextBoxHistBolesti;
        private System.Windows.Forms.RichTextBox richTextBoxPorodicneBol;
        private System.Windows.Forms.Label labelPrevBolesti;
        private System.Windows.Forms.Label labelAlergije;
        private System.Windows.Forms.Label labelPorodicneBol;
    }
}
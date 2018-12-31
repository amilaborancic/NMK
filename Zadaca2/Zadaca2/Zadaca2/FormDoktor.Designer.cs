namespace Zadaca2
{
    partial class FormDoktor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoktor));
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
            this.menuStripDoktor = new System.Windows.Forms.MenuStrip();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelJMBGPac = new System.Windows.Forms.Label();
            this.textBoxJMBG = new System.Windows.Forms.TextBox();
            this.buttonTrazi = new System.Windows.Forms.Button();
            this.errorProviderDoktor = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageKartonDoc = new System.Windows.Forms.TabPage();
            this.tabPageDodajPregled = new System.Windows.Forms.TabPage();
            this.groupBoxZeljeniPregledi = new System.Windows.Forms.GroupBox();
            this.checkBoxKardiologija = new System.Windows.Forms.CheckBox();
            this.checkBoxDerm = new System.Windows.Forms.CheckBox();
            this.checkBoxHitna = new System.Windows.Forms.CheckBox();
            this.checkBoxHirurgija = new System.Windows.Forms.CheckBox();
            this.checkBoxOpstaMed = new System.Windows.Forms.CheckBox();
            this.statusStripDoktor = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUspjeh = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonDodajPregled = new System.Windows.Forms.Button();
            this.statusStripDoktorKarton = new System.Windows.Forms.StatusStrip();
            this.buttonPotvrdiIzmjene = new System.Windows.Forms.Button();
            this.toolStripStatusLabelUspjehAgain = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxBolesti.SuspendLayout();
            this.groupBoxTerapije.SuspendLayout();
            this.menuStripDoktor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDoktor)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageKartonDoc.SuspendLayout();
            this.tabPageDodajPregled.SuspendLayout();
            this.groupBoxZeljeniPregledi.SuspendLayout();
            this.statusStripDoktor.SuspendLayout();
            this.statusStripDoktorKarton.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBolesti
            // 
            this.groupBoxBolesti.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxBolesti.Controls.Add(this.labeltrenbolesti);
            this.groupBoxBolesti.Controls.Add(this.richTextBoxTrenBolesti);
            this.groupBoxBolesti.Controls.Add(this.richTextBoxAlergije);
            this.groupBoxBolesti.Controls.Add(this.richTextBoxHistBolesti);
            this.groupBoxBolesti.Controls.Add(this.richTextBoxPorodicneBol);
            this.groupBoxBolesti.Controls.Add(this.labelPrevBolesti);
            this.groupBoxBolesti.Controls.Add(this.labelAlergije);
            this.groupBoxBolesti.Controls.Add(this.labelPorodicneBol);
            this.groupBoxBolesti.Location = new System.Drawing.Point(20, 24);
            this.groupBoxBolesti.Name = "groupBoxBolesti";
            this.groupBoxBolesti.Size = new System.Drawing.Size(324, 368);
            this.groupBoxBolesti.TabIndex = 23;
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
            this.richTextBoxTrenBolesti.Size = new System.Drawing.Size(271, 64);
            this.richTextBoxTrenBolesti.TabIndex = 22;
            this.richTextBoxTrenBolesti.Text = "";
            // 
            // richTextBoxAlergije
            // 
            this.richTextBoxAlergije.Location = new System.Drawing.Point(27, 208);
            this.richTextBoxAlergije.Name = "richTextBoxAlergije";
            this.richTextBoxAlergije.Size = new System.Drawing.Size(271, 31);
            this.richTextBoxAlergije.TabIndex = 21;
            this.richTextBoxAlergije.Text = "";
            // 
            // richTextBoxHistBolesti
            // 
            this.richTextBoxHistBolesti.Location = new System.Drawing.Point(27, 127);
            this.richTextBoxHistBolesti.Name = "richTextBoxHistBolesti";
            this.richTextBoxHistBolesti.Size = new System.Drawing.Size(271, 55);
            this.richTextBoxHistBolesti.TabIndex = 20;
            this.richTextBoxHistBolesti.Text = "";
            // 
            // richTextBoxPorodicneBol
            // 
            this.richTextBoxPorodicneBol.Location = new System.Drawing.Point(27, 50);
            this.richTextBoxPorodicneBol.Name = "richTextBoxPorodicneBol";
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
            this.groupBoxTerapije.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTerapije.Controls.Add(this.richTextBoxPrevTer);
            this.groupBoxTerapije.Controls.Add(this.richTextBoxTrenTer);
            this.groupBoxTerapije.Controls.Add(this.labelSadasnjeTer);
            this.groupBoxTerapije.Controls.Add(this.labelPrevTerapije);
            this.groupBoxTerapije.Location = new System.Drawing.Point(350, 24);
            this.groupBoxTerapije.Name = "groupBoxTerapije";
            this.groupBoxTerapije.Size = new System.Drawing.Size(319, 206);
            this.groupBoxTerapije.TabIndex = 22;
            this.groupBoxTerapije.TabStop = false;
            this.groupBoxTerapije.Text = "Terapije";
            // 
            // richTextBoxPrevTer
            // 
            this.richTextBoxPrevTer.Location = new System.Drawing.Point(30, 50);
            this.richTextBoxPrevTer.Name = "richTextBoxPrevTer";
            this.richTextBoxPrevTer.Size = new System.Drawing.Size(271, 46);
            this.richTextBoxPrevTer.TabIndex = 19;
            this.richTextBoxPrevTer.Text = "";
            // 
            // richTextBoxTrenTer
            // 
            this.richTextBoxTrenTer.Location = new System.Drawing.Point(30, 135);
            this.richTextBoxTrenTer.Name = "richTextBoxTrenTer";
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
            // menuStripDoktor
            // 
            this.menuStripDoktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(173)))), ((int)(((byte)(138)))));
            this.menuStripDoktor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odjavaToolStripMenuItem});
            this.menuStripDoktor.Location = new System.Drawing.Point(0, 0);
            this.menuStripDoktor.Name = "menuStripDoktor";
            this.menuStripDoktor.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripDoktor.Size = new System.Drawing.Size(716, 24);
            this.menuStripDoktor.TabIndex = 1;
            this.menuStripDoktor.Text = "menuStrip1";
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // labelJMBGPac
            // 
            this.labelJMBGPac.AutoSize = true;
            this.labelJMBGPac.Location = new System.Drawing.Point(25, 58);
            this.labelJMBGPac.Name = "labelJMBGPac";
            this.labelJMBGPac.Size = new System.Drawing.Size(52, 14);
            this.labelJMBGPac.TabIndex = 0;
            this.labelJMBGPac.Text = "Pacijent:";
            // 
            // textBoxJMBG
            // 
            this.textBoxJMBG.Location = new System.Drawing.Point(83, 55);
            this.textBoxJMBG.Name = "textBoxJMBG";
            this.textBoxJMBG.Size = new System.Drawing.Size(179, 22);
            this.textBoxJMBG.TabIndex = 2;
            // 
            // buttonTrazi
            // 
            this.buttonTrazi.Location = new System.Drawing.Point(296, 54);
            this.buttonTrazi.Name = "buttonTrazi";
            this.buttonTrazi.Size = new System.Drawing.Size(75, 23);
            this.buttonTrazi.TabIndex = 3;
            this.buttonTrazi.Text = "Trazi";
            this.buttonTrazi.UseVisualStyleBackColor = true;
            this.buttonTrazi.Click += new System.EventHandler(this.buttonTrazi_Click);
            // 
            // errorProviderDoktor
            // 
            this.errorProviderDoktor.ContainerControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageKartonDoc);
            this.tabControl1.Controls.Add(this.tabPageDodajPregled);
            this.tabControl1.Location = new System.Drawing.Point(12, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 467);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageKartonDoc
            // 
            this.tabPageKartonDoc.Controls.Add(this.buttonPotvrdiIzmjene);
            this.tabPageKartonDoc.Controls.Add(this.statusStripDoktorKarton);
            this.tabPageKartonDoc.Controls.Add(this.groupBoxBolesti);
            this.tabPageKartonDoc.Controls.Add(this.groupBoxTerapije);
            this.tabPageKartonDoc.Location = new System.Drawing.Point(4, 23);
            this.tabPageKartonDoc.Name = "tabPageKartonDoc";
            this.tabPageKartonDoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKartonDoc.Size = new System.Drawing.Size(696, 440);
            this.tabPageKartonDoc.TabIndex = 0;
            this.tabPageKartonDoc.Text = "Karton";
            this.tabPageKartonDoc.UseVisualStyleBackColor = true;
            // 
            // tabPageDodajPregled
            // 
            this.tabPageDodajPregled.Controls.Add(this.buttonDodajPregled);
            this.tabPageDodajPregled.Controls.Add(this.statusStripDoktor);
            this.tabPageDodajPregled.Controls.Add(this.groupBoxZeljeniPregledi);
            this.tabPageDodajPregled.Location = new System.Drawing.Point(4, 23);
            this.tabPageDodajPregled.Name = "tabPageDodajPregled";
            this.tabPageDodajPregled.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDodajPregled.Size = new System.Drawing.Size(696, 440);
            this.tabPageDodajPregled.TabIndex = 1;
            this.tabPageDodajPregled.Text = "Dodaj pregled";
            this.tabPageDodajPregled.UseVisualStyleBackColor = true;
            // 
            // groupBoxZeljeniPregledi
            // 
            this.groupBoxZeljeniPregledi.Controls.Add(this.checkBoxKardiologija);
            this.groupBoxZeljeniPregledi.Controls.Add(this.checkBoxDerm);
            this.groupBoxZeljeniPregledi.Controls.Add(this.checkBoxHitna);
            this.groupBoxZeljeniPregledi.Controls.Add(this.checkBoxHirurgija);
            this.groupBoxZeljeniPregledi.Controls.Add(this.checkBoxOpstaMed);
            this.groupBoxZeljeniPregledi.Location = new System.Drawing.Point(226, 58);
            this.groupBoxZeljeniPregledi.Name = "groupBoxZeljeniPregledi";
            this.groupBoxZeljeniPregledi.Size = new System.Drawing.Size(223, 269);
            this.groupBoxZeljeniPregledi.TabIndex = 6;
            this.groupBoxZeljeniPregledi.TabStop = false;
            this.groupBoxZeljeniPregledi.Text = "Pegledi";
            // 
            // checkBoxKardiologija
            // 
            this.checkBoxKardiologija.AutoSize = true;
            this.checkBoxKardiologija.Location = new System.Drawing.Point(23, 117);
            this.checkBoxKardiologija.Name = "checkBoxKardiologija";
            this.checkBoxKardiologija.Size = new System.Drawing.Size(88, 18);
            this.checkBoxKardiologija.TabIndex = 4;
            this.checkBoxKardiologija.Text = "Kardiologija";
            this.checkBoxKardiologija.UseVisualStyleBackColor = true;
            // 
            // checkBoxDerm
            // 
            this.checkBoxDerm.AutoSize = true;
            this.checkBoxDerm.Location = new System.Drawing.Point(23, 146);
            this.checkBoxDerm.Name = "checkBoxDerm";
            this.checkBoxDerm.Size = new System.Drawing.Size(99, 18);
            this.checkBoxDerm.TabIndex = 3;
            this.checkBoxDerm.Text = "Dermatologija";
            this.checkBoxDerm.UseVisualStyleBackColor = true;
            // 
            // checkBoxHitna
            // 
            this.checkBoxHitna.AutoSize = true;
            this.checkBoxHitna.Location = new System.Drawing.Point(23, 87);
            this.checkBoxHitna.Name = "checkBoxHitna";
            this.checkBoxHitna.Size = new System.Drawing.Size(56, 18);
            this.checkBoxHitna.TabIndex = 2;
            this.checkBoxHitna.Text = "Hitna";
            this.checkBoxHitna.UseVisualStyleBackColor = true;
            // 
            // checkBoxHirurgija
            // 
            this.checkBoxHirurgija.AutoSize = true;
            this.checkBoxHirurgija.Location = new System.Drawing.Point(23, 58);
            this.checkBoxHirurgija.Name = "checkBoxHirurgija";
            this.checkBoxHirurgija.Size = new System.Drawing.Size(74, 18);
            this.checkBoxHirurgija.TabIndex = 1;
            this.checkBoxHirurgija.Text = "Hirurgija";
            this.checkBoxHirurgija.UseVisualStyleBackColor = true;
            // 
            // checkBoxOpstaMed
            // 
            this.checkBoxOpstaMed.AutoSize = true;
            this.checkBoxOpstaMed.Location = new System.Drawing.Point(23, 30);
            this.checkBoxOpstaMed.Name = "checkBoxOpstaMed";
            this.checkBoxOpstaMed.Size = new System.Drawing.Size(109, 18);
            this.checkBoxOpstaMed.TabIndex = 0;
            this.checkBoxOpstaMed.Text = "Opsta medicina";
            this.checkBoxOpstaMed.UseVisualStyleBackColor = true;
            // 
            // statusStripDoktor
            // 
            this.statusStripDoktor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUspjeh});
            this.statusStripDoktor.Location = new System.Drawing.Point(3, 415);
            this.statusStripDoktor.Name = "statusStripDoktor";
            this.statusStripDoktor.Size = new System.Drawing.Size(690, 22);
            this.statusStripDoktor.TabIndex = 7;
            this.statusStripDoktor.Text = "statusStrip1";
            // 
            // toolStripStatusLabelUspjeh
            // 
            this.toolStripStatusLabelUspjeh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripStatusLabelUspjeh.Name = "toolStripStatusLabelUspjeh";
            this.toolStripStatusLabelUspjeh.Size = new System.Drawing.Size(0, 17);
            // 
            // buttonDodajPregled
            // 
            this.buttonDodajPregled.Location = new System.Drawing.Point(299, 333);
            this.buttonDodajPregled.Name = "buttonDodajPregled";
            this.buttonDodajPregled.Size = new System.Drawing.Size(75, 23);
            this.buttonDodajPregled.TabIndex = 5;
            this.buttonDodajPregled.Text = "Dodaj";
            this.buttonDodajPregled.UseVisualStyleBackColor = true;
            this.buttonDodajPregled.Click += new System.EventHandler(this.buttonDodajPregled_Click);
            // 
            // statusStripDoktorKarton
            // 
            this.statusStripDoktorKarton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUspjehAgain});
            this.statusStripDoktorKarton.Location = new System.Drawing.Point(3, 415);
            this.statusStripDoktorKarton.Name = "statusStripDoktorKarton";
            this.statusStripDoktorKarton.Size = new System.Drawing.Size(690, 22);
            this.statusStripDoktorKarton.TabIndex = 24;
            this.statusStripDoktorKarton.Text = "statusStrip1";
            // 
            // buttonPotvrdiIzmjene
            // 
            this.buttonPotvrdiIzmjene.Location = new System.Drawing.Point(594, 369);
            this.buttonPotvrdiIzmjene.Name = "buttonPotvrdiIzmjene";
            this.buttonPotvrdiIzmjene.Size = new System.Drawing.Size(75, 23);
            this.buttonPotvrdiIzmjene.TabIndex = 25;
            this.buttonPotvrdiIzmjene.Text = "Potvrdi Izmjene";
            this.buttonPotvrdiIzmjene.UseVisualStyleBackColor = true;
            this.buttonPotvrdiIzmjene.Click += new System.EventHandler(this.buttonPotvrdiIzmjene_Click);
            // 
            // toolStripStatusLabelUspjehAgain
            // 
            this.toolStripStatusLabelUspjehAgain.Name = "toolStripStatusLabelUspjehAgain";
            this.toolStripStatusLabelUspjehAgain.Size = new System.Drawing.Size(0, 17);
            // 
            // FormDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(716, 550);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonTrazi);
            this.Controls.Add(this.textBoxJMBG);
            this.Controls.Add(this.labelJMBGPac);
            this.Controls.Add(this.menuStripDoktor);
            this.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripDoktor;
            this.Name = "FormDoktor";
            this.Text = "FormDoktor";
            this.groupBoxBolesti.ResumeLayout(false);
            this.groupBoxBolesti.PerformLayout();
            this.groupBoxTerapije.ResumeLayout(false);
            this.groupBoxTerapije.PerformLayout();
            this.menuStripDoktor.ResumeLayout(false);
            this.menuStripDoktor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDoktor)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageKartonDoc.ResumeLayout(false);
            this.tabPageKartonDoc.PerformLayout();
            this.tabPageDodajPregled.ResumeLayout(false);
            this.tabPageDodajPregled.PerformLayout();
            this.groupBoxZeljeniPregledi.ResumeLayout(false);
            this.groupBoxZeljeniPregledi.PerformLayout();
            this.statusStripDoktor.ResumeLayout(false);
            this.statusStripDoktor.PerformLayout();
            this.statusStripDoktorKarton.ResumeLayout(false);
            this.statusStripDoktorKarton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripDoktor;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.Label labelJMBGPac;
        private System.Windows.Forms.TextBox textBoxJMBG;
        private System.Windows.Forms.GroupBox groupBoxBolesti;
        private System.Windows.Forms.Label labeltrenbolesti;
        private System.Windows.Forms.RichTextBox richTextBoxTrenBolesti;
        private System.Windows.Forms.RichTextBox richTextBoxAlergije;
        private System.Windows.Forms.RichTextBox richTextBoxHistBolesti;
        private System.Windows.Forms.RichTextBox richTextBoxPorodicneBol;
        private System.Windows.Forms.Label labelPrevBolesti;
        private System.Windows.Forms.Label labelAlergije;
        private System.Windows.Forms.Label labelPorodicneBol;
        private System.Windows.Forms.GroupBox groupBoxTerapije;
        private System.Windows.Forms.RichTextBox richTextBoxPrevTer;
        private System.Windows.Forms.RichTextBox richTextBoxTrenTer;
        private System.Windows.Forms.Label labelSadasnjeTer;
        private System.Windows.Forms.Label labelPrevTerapije;
        private System.Windows.Forms.Button buttonTrazi;
        private System.Windows.Forms.ErrorProvider errorProviderDoktor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageKartonDoc;
        private System.Windows.Forms.TabPage tabPageDodajPregled;
        private System.Windows.Forms.StatusStrip statusStripDoktor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUspjeh;
        private System.Windows.Forms.GroupBox groupBoxZeljeniPregledi;
        private System.Windows.Forms.CheckBox checkBoxKardiologija;
        private System.Windows.Forms.CheckBox checkBoxDerm;
        private System.Windows.Forms.CheckBox checkBoxHitna;
        private System.Windows.Forms.CheckBox checkBoxHirurgija;
        private System.Windows.Forms.CheckBox checkBoxOpstaMed;
        private System.Windows.Forms.Button buttonDodajPregled;
        private System.Windows.Forms.Button buttonPotvrdiIzmjene;
        private System.Windows.Forms.StatusStrip statusStripDoktorKarton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUspjehAgain;
    }
}
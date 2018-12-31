using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca2
{
    public partial class FormDoktor : Form
    {
        public FormDoktor()
        {
            InitializeComponent();
        }

        Pacijent p = new Pacijent();
        private void IzRichUListu(string text, List<string> lista)
        {
            if (string.IsNullOrEmpty(text)) return;
            for (int i = 0; i < text.Length;)
            {
                string a = text.Substring(i, text.IndexOf("\n"));
                i += a.Length + 1;
                lista.Add(a);
            }
        }
        private void IzRichUListuTerapija(string text, List<Terapija> lista)
        {
            if (string.IsNullOrEmpty(text)) return;
            for (int i = 0; i < text.Length;)
            {
                string b = text.Substring(i, text.IndexOf("\n"));
                Terapija a = new Terapija(b);
                i += b.Length + 1;
                lista.Add(a);
            }
        }
        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Login l = new Login();
            l.ShowDialog();
        }

        private void buttonTrazi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxJMBG.Text))
            {
                textBoxJMBG.Focus();
                errorProviderDoktor.SetError(textBoxJMBG, "Molimo unesite maticni broj pacijenta.");
            }
            else if (!TestoviIspravnosti.IspravnostJMBG(textBoxJMBG.Text))
            {
                textBoxJMBG.Focus();
                errorProviderDoktor.SetError(textBoxJMBG, "Unijeli ste neispravan JMBG.");
            }
            else errorProviderDoktor.Clear();
            string JMBG = textBoxJMBG.Text;
            p = Klinika.PretraziListuPacijenata(JMBG);
            if (string.IsNullOrEmpty(p.DajMaticni))
            {
                textBoxJMBG.Focus();
                errorProviderDoktor.SetError(textBoxJMBG, "Pacijent sa unesenim JMBG nije registrovan u klinici.");
            }

            Karton k = p.DajKarton;
            foreach (string s in k.BolestiUPorodici)
                richTextBoxPorodicneBol.AppendText(s + Environment.NewLine);
            richTextBoxHistBolesti.Lines = k.PrijasnjeBolesti.ToArray();
            foreach (string s in k.SadasnjeAlergije)
                richTextBoxAlergije.AppendText(s + Environment.NewLine);
            richTextBoxTrenBolesti.Lines = k.SadasnjeBolesti.ToArray();
            foreach (Terapija t in k.Trenutne)
                richTextBoxTrenTer.AppendText(t.OpisTerapije + "\n");
            foreach (Terapija t in k.PrijasnjeTerapije)
                richTextBoxPrevTer.AppendText(t.OpisTerapije + "\n");
        }
        private void buttonDodajPregled_Click(object sender, EventArgs e)
        {
            foreach (CheckBox c in groupBoxZeljeniPregledi.Controls)
            {
                if (c.Checked)    
                {
                    Ordinacija o = Klinika.PretraziOrdinacije(c.Text);
                    if(!p.Raspored.ContainsKey(o)) p.Raspored.Add(o,o.BrojPacijenata+1);
                }
                c.Checked = false;
            }
            toolStripStatusLabelUspjeh.Text = "Pregledi uspjesno dodani!";
        }

        private void buttonPotvrdiIzmjene_Click(object sender, EventArgs e)
        {
            Karton k = p.DajKarton;
            IzRichUListu(richTextBoxTrenBolesti.Text, k.SadasnjeBolesti);
            IzRichUListu(richTextBoxAlergije.Text, k.SadasnjeAlergije);
            IzRichUListu(richTextBoxHistBolesti.Text, k.PrijasnjeBolesti);
            IzRichUListu(richTextBoxPorodicneBol.Text, k.BolestiUPorodici);
            IzRichUListuTerapija(richTextBoxPrevTer.Text, k.PrijasnjeTerapije);
            IzRichUListuTerapija(richTextBoxTrenTer.Text, k.Trenutne);
            Klinika.DajKartone.Add(k);
            richTextBoxTrenBolesti.Clear();
            richTextBoxAlergije.Clear();
            richTextBoxHistBolesti.Clear();
            richTextBoxPorodicneBol.Clear();
            richTextBoxPrevTer.Clear();
            richTextBoxTrenTer.Clear();
            toolStripStatusLabelUspjehAgain.Text = "Karton uspjesno izmijenjen.";
        }
    }
}

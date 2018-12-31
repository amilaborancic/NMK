using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace Zadaca2
{

    public partial class FormTehnicar : Form
    {
        Pacijent p = new Pacijent();
        Karton k = new Karton();

        string slika;
        bool SpolChecked = false;
        bool BracnoStanjeChecked = false;
        public FormTehnicar()
        {
            InitializeComponent();
        }

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
        private void buttonOdaberi_Click(object sender, EventArgs e)
        {
            OpenFileDialog slikaPacijenta = new OpenFileDialog();
            if (slikaPacijenta.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxSlikaPac.ImageLocation = slikaPacijenta.FileName;
                    slika = slikaPacijenta.FileName;

                } catch (Exception) { slika = ""; }
            }
        }

        private void buttonPotvrdiReg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxImeReg.Text))
            {
                textBoxImeReg.Focus();
                errorProviderRegistracija.SetError(textBoxImeReg, "Niste unijeli ime pacijenta.");
            }
            else if (string.IsNullOrEmpty(textBoxPrezimeReg.Text))
            {
                textBoxPrezimeReg.Focus();
                errorProviderRegistracija.SetError(textBoxPrezimeReg, "Niste unijeli prezime pacijenta.");
            }
            else if (!SpolChecked)
            {
                groupBoxSpol.Focus();
                errorProviderRegistracija.SetError(groupBoxSpol, "Niste unijeli spol");
            }
            else if (!BracnoStanjeChecked)
            {
                groupBoxBracnoStanje.Focus();
                errorProviderRegistracija.SetError(groupBoxBracnoStanje, "Niste unijeli bracno stanje");
            }
            else if (slika == "")
            {
                groupBoxSlika.Focus();
                errorProviderRegistracija.SetError(groupBoxSlika, "Molimo odaberite sliku.");
            }
            else if (!TestoviIspravnosti.IspravnostJMBG(textBoxJMBGReg.Text))
            {
                textBoxJMBGReg.Focus();
                errorProviderRegistracija.SetError(textBoxJMBGReg, "Neispravan JMBG.");
            }
            else if (!TestoviIspravnosti.IspravnostJMBG(textBoxJMBGReg.Text, dateTimePickerRodjenje.Value))
            {
                dateTimePickerRodjenje.Focus();
                errorProviderRegistracija.SetError(dateTimePickerRodjenje, "Maticni broj i datum rodjenja nisu uskladjeni.");
            }
            else
            {
                errorProviderRegistracija.Clear();
            }
            p = Klinika.PretraziListuPacijenata(textBoxJMBGReg.Text);
            if (string.IsNullOrEmpty(p.DajMaticni))
            {
                p.Ime = textBoxImeReg.Text;
                p.Prezime = textBoxPrezimeReg.Text;
                p.jelZensko = radioButtonZensko.Checked;
                p.Adresa = textBoxAdresa.Text;
                p.DajMaticni = textBoxJMBGReg.Text;
                p.jelUBraku = radioButtonUBraku.Checked;
                p.DatumRodjenja = dateTimePickerRodjenje.Value;
                p.DatumRegistracije = DateTime.Today;
                p.Slika = slika;
                p.Br_dolazaka++;
            }
            if (richTextBoxHitnaPOmoc.Text != "")
            {
                Dictionary<Ordinacija, int> pom = p.Raspored;
                p = new HitniPacijent(p.Ime, p.Prezime, p.jelZensko,p.Adresa, 
                    p.DajMaticni, p.jelUBraku, p.DatumRodjenja, p.DatumRegistracije, richTextBoxHitnaPOmoc.Text);
                p.Slika = slika;
            }
            Klinika.DajListuPacijenata.Add(p);
            textBoxImeReg.Clear();
            textBoxPrezimeReg.Clear();
            textBoxJMBGReg.Clear();
            dateTimePickerRodjenje.Value = DateTime.Today;
            textBoxAdresa.Clear();
            richTextBoxHitnaPOmoc.Clear();
            slika = "";
            radioButtonMusko.Checked = false;
            radioButtonZensko.Checked = false;
            radioButtonSingle.Checked = false;
            radioButtonUBraku.Checked = false;
            SpolChecked = false;
            BracnoStanjeChecked = false;
        }

        private void checkBoxOpstaMed_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOpstaMed.Checked)
            {
                Ordinacija o = Klinika.OrdinacijeKlinike[0];
                p.Raspored.Add(o, o.BrojPacijenata + 1);
                Klinika.OrdinacijeKlinike[0].BrojPacijenata++;
            }
        }

        private void checkBoxHirurgija_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHirurgija.Checked)
            {
                Ordinacija o = Klinika.OrdinacijeKlinike[1];
                p.Raspored.Add(o, o.BrojPacijenata + 1);
                Klinika.OrdinacijeKlinike[1].BrojPacijenata++;
            }
        }

        private void checkBoxHitna_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHitna.Checked)
            {
                Ordinacija o = Klinika.OrdinacijeKlinike[3];
                p.Raspored.Add(o, o.BrojPacijenata + 1);
                Klinika.OrdinacijeKlinike[3].BrojPacijenata++;
            }
        }

        private void checkBoxKardiologija_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKardiologija.Checked)
            {
                Ordinacija o = Klinika.OrdinacijeKlinike[4];
                p.Raspored.Add(o, o.BrojPacijenata + 1);
                Klinika.OrdinacijeKlinike[4].BrojPacijenata++;
            }
        }

        private void checkBoxDerm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDerm.Checked)
            {
                Ordinacija o = Klinika.OrdinacijeKlinike[2];
                p.Raspored.Add(o, o.BrojPacijenata + 1);
                Klinika.OrdinacijeKlinike[2].BrojPacijenata++;
            }
        }

        private void textBoxJMBGReg_Validating(object sender, CancelEventArgs e)
        {
            if (!TestoviIspravnosti.IspravnostJMBG(textBoxJMBGReg.Text))
            {
                e.Cancel = true;
                textBoxJMBGReg.Focus();
                errorProviderRegistracija.SetError(textBoxJMBGReg, "Neispravan maticni broj.");
            }
            else
            {
                e.Cancel = false;
                errorProviderRegistracija.Clear();
            }
        }

        private void textBoxImeReg_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxImeReg.Text))
            {
                e.Cancel = true;
                textBoxImeReg.Focus();
                errorProviderRegistracija.SetError(textBoxImeReg, "Molimo unesite ime.");
            }
            else
            {
                e.Cancel = false;
                errorProviderRegistracija.Clear();
            }
        }

        private void radioButtonMusko_CheckedChanged(object sender, EventArgs e)
        {
            SpolChecked = true;
        }

        private void radioButtonZensko_CheckedChanged(object sender, EventArgs e)
        {
            SpolChecked = true;
        }

        private void radioButtonUBraku_CheckedChanged(object sender, EventArgs e)
        {
            BracnoStanjeChecked = true;
        }

        private void radioButtonSingle_CheckedChanged(object sender, EventArgs e)
        {
            BracnoStanjeChecked = true;
        }

        //kreiranje kartona
        private void buttonPotvrdiKarton_Click(object sender, EventArgs e)
        {
            IzRichUListu(richTextBoxTrenBolesti.Text, k.SadasnjeBolesti);
            IzRichUListu(richTextBoxAlergije.Text, k.SadasnjeAlergije);
            IzRichUListu(richTextBoxHistBolesti.Text, k.PrijasnjeBolesti);
            IzRichUListu(richTextBoxPorodicneBol.Text, k.BolestiUPorodici);
            IzRichUListuTerapija(richTextBoxPrevTer.Text, k.PrijasnjeTerapije);
            IzRichUListuTerapija(richTextBoxTrenTer.Text, k.Trenutne);
            string JMBG = textBoxJMBGKarton.Text;
            if (string.IsNullOrEmpty(JMBG))
            {
                textBoxJMBGKarton.Focus();
                errorProviderRegistracija.SetError(textBoxJMBGKarton, "Molimo unesite JMBG.");
            }
            else if (!TestoviIspravnosti.IspravnostJMBG(JMBG))
            {
                textBoxJMBGKarton.Focus();
                errorProviderRegistracija.SetError(textBoxJMBGKarton, "Unijeli ste neispravan JMBG.");
            }
            else errorProviderRegistracija.Clear();
            Klinika.PretraziListuPacijenata(JMBG).DajKarton = k;
            Klinika.DajKartone.Add(k);
            richTextBoxTrenBolesti.Clear();
            richTextBoxAlergije.Clear();
            richTextBoxHistBolesti.Clear();
            richTextBoxPorodicneBol.Clear();
            richTextBoxPrevTer.Clear();
            richTextBoxTrenTer.Clear();
            textBoxJMBGKarton.Clear();
            toolStripStatusLabeluspjeh.Visible = true;
        }
        //raspored
        private void textBoxJMBGRaspored_Validating(object sender, CancelEventArgs e)
        {
            if (!TestoviIspravnosti.IspravnostJMBG(textBoxJMBGRaspored.Text))
            {
                e.Cancel = true;
                textBoxJMBGRaspored.Focus();
                errorProviderRegistracija.SetError(textBoxJMBGRaspored, "Unijeli ste pogresan maticni broj.");
            }
            else
            {
                p = Klinika.PretraziListuPacijenata(textBoxJMBGRaspored.Text);
                if (p.DajMaticni == "")
                {
                    e.Cancel = true;
                    textBoxJMBGRaspored.Focus();
                    errorProviderRegistracija.SetError(textBoxJMBGRaspored, "Pacijent kojeg trazite ne postoji u klinici.");
                }
                else
                {
                    e.Cancel = false;
                    errorProviderRegistracija.Clear();
                }
            }
        }

        private void buttonOdaberiJMBG_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxJMBGRaspored.Text))
            {
                textBoxJMBGRaspored.Focus();
                errorProviderRegistracija.SetError(textBoxJMBGRaspored, "Molimo unesite maticni broj pacijenta.");
            }
            else if (!TestoviIspravnosti.IspravnostJMBG(textBoxJMBGRaspored.Text))
            {
                textBoxJMBGRaspored.Focus();
                errorProviderRegistracija.SetError(textBoxJMBGRaspored, "Unijeli ste neispravan JMBG.");
            }
            else errorProviderRegistracija.Clear();
            string JMBG = textBoxJMBGRaspored.Text;
            p = Klinika.PretraziListuPacijenata(JMBG);
            if (string.IsNullOrEmpty(p.DajMaticni))
            {
                textBoxJMBGRaspored.Focus();
                errorProviderRegistracija.SetError(textBoxJMBGRaspored, "Pacijent sa unesenim JMBG nije registrovan u klinici.");
            }
            else errorProviderRegistracija.Clear();
            foreach (Ordinacija i in p.Raspored.Keys)
            {
                string[] niz = new string[2];
                niz[0] = (p.Raspored[i]+1).ToString();
                niz[1] = i.Naziv;
                ListViewItem l = new ListViewItem(niz);
                listViewPrikazRasp.Items.Add(l);
            }
        }

        private void buttonClearRaspored_Click(object sender, EventArgs e)
        {
            listViewPrikazRasp.Clear();
            textBoxJMBGRaspored.Clear();
        }
        //odjava
        private void buttonObrisiOdjava_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMaticniUOdjavi.Text))
            {
                textBoxMaticniUOdjavi.Focus();
                errorProviderRegistracija.SetError(textBoxMaticniUOdjavi, "Niste unijeli JMBG.");
            }
            else errorProviderRegistracija.Clear();
            string jmbg = textBoxMaticniUOdjavi.Text;
            if (!TestoviIspravnosti.IspravnostJMBG(jmbg))
            {
                textBoxMaticniUOdjavi.Focus();
                errorProviderRegistracija.SetError(textBoxMaticniUOdjavi, "Unijeli ste neispravan JMBG.");
            }
            else errorProviderRegistracija.Clear();
            Pacijent n = Klinika.PretraziListuPacijenata(textBoxMaticniUOdjavi.Text);
            if (string.IsNullOrEmpty(n.DajMaticni))
            {
                textBoxMaticniUOdjavi.Focus();
                errorProviderRegistracija.SetError(textBoxMaticniUOdjavi, "Pacijent s unesenim JMBG nije registrovan u klinici.");
            }
            else errorProviderRegistracija.Clear();
            if (!string.IsNullOrEmpty(richTextBoxUzrokSmrti.Text))
            {
                Klinika.ListaPreminulih.Add(n, richTextBoxUzrokSmrti.Text);
                n.DatumSmrti = dateTimePickerSmrt.Value;
                n.DatumObdukcije = dateTimePickerObdukcija.Value;
            }
            Klinika.ObrisiPacijenta(jmbg);
            dateTimePickerObdukcija.Value = DateTime.Today;
            dateTimePickerSmrt.Value = DateTime.Today;
            richTextBoxUzrokSmrti.Clear();
        }
        //naplata
        private void textBoxJMBGPac_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxJMBGPac.Text))
            {
                textBoxJMBGPac.Focus();
                errorProviderRegistracija.SetError(textBoxJMBGPac, "Molimo unesite maticni broj pacijenta.");
            }
            else if (!TestoviIspravnosti.IspravnostJMBG(textBoxJMBGPac.Text))
            {
                textBoxJMBGPac.Focus();
                errorProviderRegistracija.SetError(textBoxJMBGPac, "Unijeli ste neispravan JMBG.");
            }
            else errorProviderRegistracija.Clear();
            Pacijent n = Klinika.PretraziListuPacijenata(textBoxJMBGPac.Text);
            if (string.IsNullOrEmpty(n.DajMaticni))
            {
                textBoxJMBGPac.Focus();
                errorProviderRegistracija.SetError(textBoxJMBGPac, "Pacijent s unesenim JMBG nije registrovan u klinici.");
            }
            else errorProviderRegistracija.Clear();

            foreach (Ordinacija i in n.Raspored.Keys)
            {
                string[] niz = new string[2];
                niz[0] = i.Naziv;
                niz[1] = i.CijenaPregleda.ToString();
                ListViewItem l = new ListViewItem(niz);
                listViewPrikazRasp.Items.Add(l);
            }

            double uplata = 0D;
            foreach (Ordinacija o in n.Raspored.Keys)
            {
                uplata += o.CijenaPregleda;
            }
            if (radioButtonRate.Checked && !n.DaLiJeRedovan())
            {
                textBoxDodatniTrosak.Text = "15%";
                uplata *= 1.15;
            }
            else if (radioButtonGotovina.Checked && n.DaLiJeRedovan())
            {
                textBoxSpecialCase.Text = "10%";
                uplata *= 0.99;
            }
            textBoxUkupno.Text = uplata.ToString();
            p = n;
        }

        private void buttonCLR_Click(object sender, EventArgs e)
        {
            textBoxUkupno.Clear();
            textBoxDodatniTrosak.Clear();
            textBoxSpecialCase.Clear();
            textBoxJMBGPac.Clear();
            radioButtonGotovina.Checked = false;
            radioButtonRate.Checked = false;
            listViewPlacanje.Clear();
            p.Raspored.Clear();
        }

        private void odjavaKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            errorProviderRegistracija.Clear();
            Close();
            Login l = new Login();
            l.ShowDialog();
        }
        
    }
}

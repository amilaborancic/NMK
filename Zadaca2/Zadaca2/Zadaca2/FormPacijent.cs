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
    public partial class FormPacijent : Form
    {
        private string user;
        public FormPacijent()
        {
            InitializeComponent();
        }
        public FormPacijent(string username)
        {
            user = username;
            InitializeComponent();
        }
        private void FormPacijent_Load(object sender, EventArgs e)
        {
            List<Pacijent> l = Klinika.DajListuPacijenata;
            Pacijent p = new Pacijent();
            foreach (Pacijent a in l)
            {
                if (a.Username == user)
                {
                    p = a;
                    break;
                }
            }
            pictureBoxSlikaPacijenta.ImageLocation = p.Slika;
            textBoxImePac.AppendText(p.Ime);
            textBoxPrezimePac.AppendText(p.Prezime);
            radioButtonMuskoPac.Checked = !p.jelZensko;
            radioButtonZenskoPac.Checked = p.jelZensko;
            textBoxJMBGPac.AppendText(p.DajMaticni);
            dateTimePickerRodjenjePac.Value = p.DatumRodjenja;
            textBoxAdresaPac.AppendText(p.Adresa);
            radioButtonSinglePac.Checked = !p.jelUBraku;
            radioButtonUBrakuPac.Checked = p.jelUBraku;

            //karton
            Karton k = p.DajKarton;
            foreach (string s in k.BolestiUPorodici)
                richTextBoxPorodicneBol.AppendText(s + Environment.NewLine);
            richTextBoxHistBolesti.Lines = k.PrijasnjeBolesti.ToArray();
            foreach (string s in k.SadasnjeAlergije)
                richTextBoxAlergije.AppendText(s + Environment.NewLine);
            richTextBoxTrenBolesti.Lines = k.SadasnjeBolesti.ToArray();
            foreach (Terapija t in k.Trenutne)
                richTextBoxTrenTer.AppendText(t.OpisTerapije+"\n");
            foreach (Terapija t in k.PrijasnjeTerapije)
                richTextBoxPrevTer.AppendText(t.OpisTerapije + "\n");
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Login l = new Login();
            l.ShowDialog();
        }
    }
}

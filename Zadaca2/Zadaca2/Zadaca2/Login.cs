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
    public partial class Login : Form
    {
        Pacijent p = new Pacijent();
        public Login()
        {
            InitializeComponent();

        }
        private bool StaSi(string sifra)
        {
            string hesirano = Program.GetMD5Hash(sifra);
            if (hesirano == Program.GetMD5Hash("pacijent") || hesirano == Program.GetMD5Hash("doktor") ||
                hesirano == Program.GetMD5Hash("tehnicar") || hesirano == Program.GetMD5Hash("uprava")) return true;
            return false;
        }
        private void pretraziPoUsername(string username, string sifra)
        {
            if (sifra == Program.GetMD5Hash("pacijent"))
            {
                List<Pacijent> l = Klinika.DajListuPacijenata;
                foreach (Pacijent p in l)
                    if (p.Username == username)
                    {
                        FormPacijent formica = new FormPacijent(username);
                        formica.Show();
                        this.Hide();
                        return;
                    }
            }
            else if (sifra == Program.GetMD5Hash("doktor"))
            {
                List<Doktor> d = Klinika.Doktori;
                foreach (Doktor a in d)
                    if (a.Username == username)
                    {
                        FormDoktor f = new FormDoktor();
                        f.Show();
                        Hide();
                        return;
                    }
            }
            else if (sifra == Program.GetMD5Hash("uprava"))
            {
                List<Uprava> u = Klinika.Uprava;
                foreach (Uprava a in u)
                    if (a.Username == username)
                    {
                        FormUprava f = new FormUprava();
                        f.Show();
                        Hide();
                        return;
                    }
            }
            else if (sifra == Program.GetMD5Hash("tehnicar"))
            {
                List<Tehnicar> t = Klinika.Tehnicari;
                foreach (Tehnicar i in t)
                    if (i.Username == username)
                    {
                        FormTehnicar formica = new FormTehnicar();
                        formica.Show();
                        this.Hide();
                        return;
                    }
            }
            throw new Exception();
        }

        private void buttonPotvrdiSif_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text))
            {
                textBoxUsername.Clear();
                toolStripStatusLabelError.Text = "Niste unijeli username.";
            }
            else if (string.IsNullOrEmpty(textBoxSifra.Text))
            {
                textBoxSifra.Clear();
                toolStripStatusLabelError.Text = "Niste unijeli password.";
            }
            else if (!StaSi(textBoxSifra.Text))
            {
                textBoxSifra.Clear();
                toolStripStatusLabelError.Text = "Neispravan password.";
            }
            
            string hes = Program.GetMD5Hash(textBoxSifra.Text);
            try
            {
                pretraziPoUsername(textBoxUsername.Text, hes);
            }
            catch (Exception)
            {
                toolStripStatusLabelError.Text = "Neispravan username ili password.";
                textBoxUsername.Clear();
                textBoxSifra.Clear();
            }
        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen olovkaLol = new Pen(Color.FromArgb(8, 173, 138));
            Brush cetkaLol = new SolidBrush(Color.FromArgb(8, 173, 138));
            //elipsa
            g.DrawEllipse(olovkaLol, 305, 15, 150, 150);
            g.FillEllipse(cetkaLol, 305, 15, 150, 150);
            
            cetkaLol = new SolidBrush(Color.FromArgb(200,96,70,13));  //sjena ispod kartona
            RectangleF r = new RectangleF(340f,43f,71f, 100.5f);
            g.FillRectangle(cetkaLol, r);

            olovkaLol = new Pen(Color.FromArgb(144, 104, 16));
            r = new RectangleF(343.5f, 40.5f, 71f, 100.5f);
            g.DrawRectangle(olovkaLol, Rectangle.Round(r));
            cetkaLol = new SolidBrush(Color.FromArgb(144, 104, 16));   //karton 

            g.FillRectangle(cetkaLol,Rectangle.Round(r));
            cetkaLol = new SolidBrush(Color.FromArgb(246, 253, 253));  //papir
            r = new RectangleF(346.6f, 52f, 65f, 85f);
            g.FillRectangle(cetkaLol, Rectangle.Round(r));
            //linije na kartoncicu
            olovkaLol = new Pen(Color.FromArgb(195,233,218));
            for(int i=0; i<80; i+=5)
                g.DrawLine(olovkaLol, new Point(347,57+i), new Point(411,57+i));
            //clip
            r = new RectangleF(366f, 39.5f, 30f, 10f);
            cetkaLol = new SolidBrush(Color.FromArgb(175,175,175));
            g.FillRectangle(cetkaLol, r);
            //shades on clip
            r = new RectangleF(369f, 39.5f, 5f, 10f);
            cetkaLol = new SolidBrush(Color.FromArgb(149, 149, 149));
            g.FillRectangle(cetkaLol, r);
            r = new RectangleF(387f, 39.5f, 5f, 10f);
            g.FillRectangle(cetkaLol, r);
            
        }
    }
}

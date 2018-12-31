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
    public partial class FormUprava : Form
    {
        public FormUprava()
        {
            InitializeComponent();
        }
        private void treeViewZaposleni_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode n = treeViewZaposleni.SelectedNode;
            string tn = treeViewZaposleni.SelectedNode.Text;
            if (n.Text == tn) Close();
            if (tn == "Doktori")
            {
                labelAnaliza.Text = "Doktori:";
                labelAnaliza.Visible = true;
                foreach (Doktor d in Klinika.Doktori)
                {
                    string[] niz = { d.Ime, d.Prezime };
                    ListViewItem l = new ListViewItem(niz);
                    listViewStuff.Clear();
                    listViewStuff.Items.Add(l);
                }
                listViewStuff.Visible = true;
            }
            else if (tn == "Tehnicari")
            {
                labelAnaliza.Text = "Tehnicari:";
                labelAnaliza.Visible = true;
                foreach (Tehnicar d in Klinika.Tehnicari)
                {
                    string[] niz = { d.Ime, d.Prezime };
                    ListViewItem l = new ListViewItem(niz);
                    listViewStuff.Clear();
                    listViewStuff.Items.Add(l);
                }
                listViewStuff.Visible = true;
            }
            else if (tn == "Registrovani")
            {
                labelAnaliza.Text = "Registrovani pacijenti:";
                labelAnaliza.Visible = true;
                foreach (Pacijent d in Klinika.DajListuPacijenata)
                {
                    string[] niz = { d.Ime, d.Prezime };
                    ListViewItem l = new ListViewItem(niz);
                    listViewStuff.Clear();
                    listViewStuff.Items.Add(l);
                }
                listViewStuff.Visible = true;
            }
            else if (tn == "Preminuli")
            {
                labelAnaliza.Text = "Preminuli pacijenti:";
                labelAnaliza.Visible = true;
                foreach (Pacijent d in Klinika.ListaPreminulih.Keys)
                {
                    string[] niz = { d.Ime, d.Prezime };
                    ListViewItem l = new ListViewItem(niz);
                    listViewStuff.Clear();
                    listViewStuff.Items.Add(l);
                }
                listViewStuff.Visible = true;
            }
            else
            {
                listViewStuff.Show();
                labelAnaliza.Text = "Najposjecenija ordinacija 2017. godine:";
                labelAnaliza.Visible = true;
                listViewStuff.Clear();
                foreach (Ordinacija o in Klinika.OrdinacijeKlinike)
                {
                    chartAnaliza.Series["Posjecenost"].Points.AddXY(o.Naziv, o.BrojPosjeta);
                }
                chartAnaliza.Show();
            }
            labelAnaliza.Visible = false;
            chartAnaliza.Visible = false;
            listViewStuff.Visible = false;
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Login l = new Login();
            l.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Boolean Dogrula()
        {
            try
            {
                Convert.ToInt32(txtBaslangıc.Text);
                Convert.ToInt32(txtBitis.Text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void BildirimGonder()
        {
            notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("AnyConv.com__istockphoto-1255742890-1024x1024.ico"));
            notifyIcon1.Text = "";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "Hoş geldiniz";
            notifyIcon1.BalloonTipText = "Geçmek için tıklayın";
            notifyIcon1.ShowBalloonTip(100);
        }
        private void listTemizle()
        {

            listTekSayı.Clear();
            listCiftSayı.Clear();
            listAsalSayı.Clear();
            listMukemmelSayı.Clear();
        }
        private void listeDetaylandır()
        {
            listTekSayı.View = View.Details;
            listTekSayı.GridLines = true;
            listTekSayı.FullRowSelect = true;

            listTekSayı.Columns.Add("Sayılar", 100);
            listTekSayı.Columns.Add("Toplam", 100);
            listTekSayı.Columns.Add("Carpım", 150);

            listCiftSayı.View = View.Details;
            listCiftSayı.GridLines = true;
            listCiftSayı.FullRowSelect = true;

            listCiftSayı.Columns.Add("Sayılar", 100);
            listCiftSayı.Columns.Add("Toplam", 100);
            listCiftSayı.Columns.Add("Carpım", 150);

            listAsalSayı.View = View.Details;
            listAsalSayı.GridLines = true;
            listAsalSayı.FullRowSelect = true;

            listAsalSayı.Columns.Add("Sayılar", 100);
            listAsalSayı.Columns.Add("Toplam", 100);
            listAsalSayı.Columns.Add("Carpım", 150);

            listMukemmelSayı.View = View.Details;
            listMukemmelSayı.GridLines = true;
            listMukemmelSayı.FullRowSelect = true;

            listMukemmelSayı.Columns.Add("Sayılar", 100);
            listMukemmelSayı.Columns.Add("Toplam", 100);
            listMukemmelSayı.Columns.Add("Carpım", 150);
        }
        private void textTemizle()
        {
            txtBaslangıc.Clear();
            txtBitis.Clear();
        }
        private void textimlec()
        {

            txtBaslangıc.Focus();
        }
        private bool CiftKontrol(ulong sayı)
        {

            if (sayı % 2 == 0)
                return true;
            else
                return false;
        }
        private bool AsalKontrol(ulong sayı)
        {
            ulong i, sayac = 0;

            for (i = 1; i <= sayı; i++)
            {
                if (sayı % i == 0)
                {
                    sayac++;
                }
            }

            if (sayac < 3)
                return true;
            else
                return false;
        }
        private bool MukemmelKontrol(ulong sayı)
        {
            ulong toplam = 0;

            for (ulong i = 1; i < sayı; i++)
            {
                if (sayı % i == 0)
                {
                    toplam = toplam + i;
                }
            }

            if (toplam == sayı)
                return true;
            else
                return false;
        }
        private bool textBosKontrol()
        {
            if (String.IsNullOrEmpty(txtBaslangıc.Text) || String.IsNullOrEmpty(txtBitis.Text))
            {
                MessageBox.Show("Başlangıç değeriniz veya bitiş değeriniz boş durumdayken yazdırma işlemi gerçekleştirilemez");
                return false;
            }
            else
                return true;
        }
        private bool textGirisKontrol(ulong baslangıc, ulong bitis)
        {
            if (baslangıc > bitis)
            {
                MessageBox.Show("Başlangıç değeriniz bitiş değerinizden büyük olursa yazdırma işlemi gerçekleştirilemez");
                return false;
            }
            else if (baslangıc == bitis)
            {
                MessageBox.Show("Başlangıç değeriniz bitiş değerinize eşit olursa yazdırma işlemi gerçekleştirilemez");
                return false;
            }
            else
                return true;

        }
        private void calistir_Click(object sender, EventArgs e)
        {
            listTemizle();
            listeDetaylandır();

            ulong baslangıcSayısı, bitisSayısı, i;

            if (textBosKontrol())
            {
                if (Dogrula())
                {
                    baslangıcSayısı = Convert.ToUInt64(txtBaslangıc.Text);
                    bitisSayısı = Convert.ToUInt64(txtBitis.Text);

                    if (textGirisKontrol(baslangıcSayısı, bitisSayısı))
                    {
                        ulong tekToplam = 0, tekCarpım = 1;
                        ulong ciftToplam = 0, ciftCarpım = 1;
                        ulong asalToplam = 0, asalCarpım = 1;
                        ulong mukemmelToplam = 0, mukemmelCarpım = 1;

                        for (i = baslangıcSayısı; i < bitisSayısı; i++)
                        {
                            if (CiftKontrol(i))
                            {
                                ciftToplam += i;
                                ciftCarpım *= i;
                                ListViewItem item = new ListViewItem(i.ToString());
                                item.SubItems.Add(ciftToplam.ToString());
                                item.SubItems.Add(ciftCarpım.ToString());
                                listCiftSayı.Items.Add(item);
                            }
                            else
                            {
                                tekToplam += i;
                                tekCarpım *= i;
                                ListViewItem item2 = new ListViewItem(i.ToString());
                                item2.SubItems.Add(tekToplam.ToString());
                                item2.SubItems.Add(tekCarpım.ToString());
                                listTekSayı.Items.Add(item2);
                            }

                            if (AsalKontrol(i))
                            {
                                asalToplam += i;
                                asalCarpım *= i;
                                ListViewItem item3 = new ListViewItem(i.ToString());
                                item3.SubItems.Add(asalToplam.ToString());
                                item3.SubItems.Add(asalCarpım.ToString());
                                listAsalSayı.Items.Add(item3);
                            }
                            if (MukemmelKontrol(i))
                            {
                                mukemmelToplam += i;
                                mukemmelCarpım *= i;
                                ListViewItem item4 = new ListViewItem(i.ToString());
                                item4.SubItems.Add(mukemmelToplam.ToString());
                                item4.SubItems.Add(mukemmelCarpım.ToString());
                                listMukemmelSayı.Items.Add(item4);
                            }
                        }

                        txtTekSayıToplam.Text = tekToplam.ToString();
                        txtTekSayıCarpım.Text = tekCarpım.ToString();
                        txtCiftSayıToplam.Text = ciftToplam.ToString();
                        txtCiftSayıCarpım.Text = ciftCarpım.ToString();
                        txtAsalSayıToplam.Text = asalToplam.ToString();
                        txtAsalSayıCarpım.Text = asalCarpım.ToString();
                        txtMukemmelSayıToplam.Text = mukemmelToplam.ToString();
                        txtMukemmelSayıCarpım.Text = mukemmelCarpım.ToString();

                    }
                    textTemizle();
                    textimlec();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BildirimGonder();
            listeDetaylandır();
            textimlec();
        }

        private void txtBaslangıc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void txtBitis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }
    }
}

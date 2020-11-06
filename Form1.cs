using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeomometriOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbSekil.Items.Add("--- Seçiniz ---");
            cbSekil.Items.Add("Dikdörtgen");
            cbSekil.Items.Add("Kare");
            cbSekil.Items.Add("Dik Üçgen");
            cbSekil.Items.Add("Eşkenar Üçgen");
            cbSekil.Items.Add("Daire");
            cbSekil.SelectedIndex = 0;
            pDikdortgen.Visible = false;
            pKare.Visible = false;
            pDikUcgen.Visible = false;
            pEskenarUcgen.Visible = false;
            pDaire.Visible = false;
            
            Point point = new Point();
            point.X = 31;
            point.Y = 95;
            pDikdortgen.Location = point;
            pKare.Location = point;
            pDikUcgen.Location = point;
            pEskenarUcgen.Location = point;
            pDaire.Location = point;
            cbHesapla.SelectedIndex = 0;
        }

        private void cbSekil_SelectedIndexChanged(object sender, EventArgs e)
        {
            pDikdortgen.Visible = false;
            pKare.Visible = false;
            pDikdortgen.Visible = false;
            pEskenarUcgen.Visible = false;
            pDaire.Visible = false;
            if (cbSekil.SelectedIndex == 1)
            {
                pDikdortgen.Visible = true;
            }
            else if (cbSekil.SelectedIndex == 2)
            {
                pKare.Visible = true;
            }
            else if (cbSekil.SelectedIndex == 3)
            {
                pDikUcgen.Visible = true;
            }
            else if (cbSekil.SelectedIndex == 4)
            {
                pEskenarUcgen.Visible = true;
            }
            else if (cbSekil.SelectedIndex == 5)
            {
                pDaire.Visible = true;
            }
        }

        private void bHesapla_Click(object sender, EventArgs e)
        {
            double sonuc = 0;
            if (cbSekil.SelectedIndex != 0 && cbHesapla.SelectedIndex != 0)
            {
               
                if (cbSekil.SelectedIndex == 1) // Dikdörtgen
                {
                    
                    if (cbHesapla.SelectedIndex == 1) // Çevre
                    {
                        
                        DikDörtgen dikDörtgen = new DikDörtgen();
                        dikDörtgen.UzunKenar = Convert.ToDouble(tbDikdörtgenUzun.Text, new CultureInfo("tr"));
                        dikDörtgen.KisaKenar = Convert.ToDouble(tbDikdörtgenKısa.Text, new CultureInfo("tr"));
                        sonuc = dikDörtgen.CevreHesapla();
                        lbSonuc.Items.Add(item: (" Dikdörtgen'in Çevresi : ") + (sonuc));
                   
                    }
                    else if (cbHesapla.SelectedIndex == 2) // Alan
                    {
                       
                        DikDörtgen dikDörtgen = new DikDörtgen();
                        dikDörtgen.UzunKenar = Convert.ToDouble(tbDikdörtgenUzun.Text, new CultureInfo("tr"));
                        dikDörtgen.KisaKenar = Convert.ToDouble(tbDikdörtgenKısa.Text, new CultureInfo("tr"));
                        sonuc = dikDörtgen.AlanHesapla();
                        lbSonuc.Items.Add(item: (" Dikdörtgen'in Alanı : ") + (sonuc));
                   
                    }
                }
                
                if (cbSekil.SelectedIndex == 2) // Kare
                {
                    if (cbHesapla.SelectedIndex == 1)// Çevre
                    {
                        
                        Kare kare = new Kare();
                        kare.UzunKenar = Convert.ToDouble(tbKareKenar.Text, new CultureInfo("tr"));
                        sonuc = kare.CevreHesapla();
                        lbSonuc.Items.Add(item: (" Kare'nin Çevresi : ") + (sonuc));
                    
                    }
                    else if (cbHesapla.SelectedIndex == 2) // Alan 
                    {
                        
                        Kare kare = new Kare();
                        kare.UzunKenar = Convert.ToDouble(tbKareKenar.Text, new CultureInfo("tr"));
                        sonuc = kare.AlanHesapla();
                        lbSonuc.Items.Add(item: (" Kare'nin Alanı : ") + (sonuc));
                    
                    }
                }
                
                if (cbSekil.SelectedIndex == 3) //Dik Üçgen 
                {
                    if (cbHesapla.SelectedIndex == 1) // Çevre
                    {
                        
                        DikUcgen dikUcgen = new DikUcgen();
                        dikUcgen.Yukseklik = Convert.ToDouble(tbYukseklikDikUcgen.Text, new CultureInfo("tr"));
                        dikUcgen.TabanKenar = Convert.ToDouble(tbTabanKenarDikUcgen.Text, new CultureInfo("tr"));
                        sonuc = dikUcgen.CevreHesapla();
                        lbSonuc.Items.Add(item: (" Dik Üçgen'in Çevresi : ") + (sonuc));
                    
                    }
                    else if (cbHesapla.SelectedIndex == 2) // Alan 
                    {
                        
                        DikUcgen dikUcgen = new DikUcgen();
                        dikUcgen.Yukseklik = Convert.ToDouble(tbYukseklikDikUcgen.Text, new CultureInfo("tr"));
                        dikUcgen.TabanKenar = Convert.ToDouble(tbTabanKenarDikUcgen.Text, new CultureInfo("tr"));
                        sonuc = dikUcgen.AlanHesapla();
                        lbSonuc.Items.Add(item: (" Dik Üçgen'in Alanı : ") + (sonuc));
                    
                    }
                }
                
                if (cbSekil.SelectedIndex == 4) //Eşkenar Üçgen
                {
                    if (cbHesapla.SelectedIndex == 1) // Çevre
                    {
                        
                        EskenarUcgen eskenarUcgen = new EskenarUcgen();
                        eskenarUcgen.TabanKenar = Convert.ToDouble(tbTabanKenarEsUcgen.Text, new CultureInfo("tr"));
                        sonuc = eskenarUcgen.CevreHesapla();
                        lbSonuc.Items.Add(item: (" Eşkenar Üçgen'in Çevresi : ") + (sonuc));
                    
                    }
                    else if (cbHesapla.SelectedIndex == 2) // Alan 
                    {
                        
                        EskenarUcgen eskenarUcgen = new EskenarUcgen();
                        eskenarUcgen.TabanKenar = Convert.ToDouble(tbTabanKenarEsUcgen.Text, new CultureInfo("tr"));
                        sonuc = eskenarUcgen.AlanHesapla();
                        lbSonuc.Items.Add(item: (" Eşkenar Üçgen'ins Alanı : ") + (sonuc));
                    
                    }
                }
                
                if (cbSekil.SelectedIndex == 5) //Daire
                {
                    if (cbHesapla.SelectedIndex == 1) // Çevre
                    {
                       
                        Daire daire = new Daire();
                        daire.YariCap = Convert.ToDouble(tbDaireYarıCap.Text, new CultureInfo("tr"));
                        sonuc = daire.CevreHesapla();
                        lbSonuc.Items.Add(item: (" Daire'nin Çevresi : ") + (sonuc));

                    
                    }
                    else if (cbHesapla.SelectedIndex == 2) // Alan
                    {
                       
                        Daire daire = new Daire();
                        daire.YariCap = Convert.ToDouble(tbDaireYarıCap.Text, new CultureInfo("tr"));
                        sonuc = daire.AlanHesapla();                       
                        lbSonuc.Items.Add(item: (" Daire'nin Alanı : ") + (sonuc));
                   
                    }
                }
            }
            
            else
            {
                MessageBox.Show("Lütfen şekil ve hesaplama seçimlerini yapın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            lbSonuc.Items.Clear();
        }

        private void tbDikdörtgenUzun_TextChanged(object sender, EventArgs e)
        {

        }

        private void pDikdortgen_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

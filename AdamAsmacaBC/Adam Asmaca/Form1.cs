using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adam_Asmaca
{

    //Küçük teselli notu: Form bilgimin yetersizliğinden dolayı yazdığım kod inanılmaz verimsiz oldu,
    //ancak soru sayısını arttırılabilir şekilde ayarladım.


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kalansuree = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {

            sure.Text = Convert.ToString(kalansuree);
            kalansuree--;
            if (kalansuree == -1)
            {

                label10.Visible = Enabled;
                timer1.Enabled = false;
                label6.Visible = true;
                timer1.Enabled = false;

                harf1.Text = "";
                harf1.Visible = false;
                harf2.Text = "";
                harf2.Visible = false;
                harf3.Text = "";
                harf3.Visible = false;
                harf4.Text = "";
                harf4.Visible = false;
                harf5.Text = "";
                harf5.Visible = false;
                harf6.Text = "";
                harf6.Visible = false;
                harf7.Text = "";
                harf7.Visible = false;
                harf8.Text = "";
                harf8.Visible = false;

                textBox1.Enabled = false;

                button5.Text = "Tekrar Oyna";

                oyunbitti = 1;
            }
        }
        ///////TANIMLAMALAR//////////
        int secilenkelimesayi;
        string secilenkelime;
        int t;
        Random asddsa = new Random();
        string[] kelime = new string[5];
        int sayacacilis = 0;
        bool kelimeyibildimi = true;
        int[] bukelimegecti = { 10, 10, 20, 30, 40 };
        int kalansoru = 5;
        int kalan_hak = 6;
        int bilinenkelimesayisi = 0;
        int sayacb = 0;
        bool asfd = false;
        bool tatata = false;
        //char[] aw = { ' ', ' ', ' ', ' ', ' ', ' ' };
        string[] aw = { " ", " ", " "," ", " ", " "  };
        int O=0;
        string hay;
        int oyunbitti = 0;
        int yeterrrr;
        int help = 0;
        //char[] bilinmeyenharfler = new char[6];
        //int s=0;
        /////////////////////////////
        private void button5_Click(object sender, EventArgs e)
        {
            //MAIN
            
            if (oyunbitti == 1)
            {
                button5.Text = "Oyuna Başla";
                asddsa = new Random();
                sayacacilis = 0;
                kelimeyibildimi = true;
                for (int n= 0; n <=4 ; n++)
                {
                    yeterrrr = 10;
                    bukelimegecti[n] = yeterrrr;
                    yeterrrr += 10;
                }
                kalansoru = 5;
                kalan_hak = 6;
                bilinenkelimesayisi = 0;
                sayacb = 0;
                help = 0;
                asfd = false;
                tatata = false;
                for (int h = 0; h < 6; h++)
                {
                    aw[h] = " ";
                }
                label12.Text = Convert.ToString(aw[0] + "  " + aw[1] + "  " + aw[2] + "  " + aw[3] + "  " + aw[4] + "  " + aw[5]);
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                O = 0;
                kalansuree = 60;
                oyunbitti = 0;

            }

            if (sayacacilis==0)
            {
                timer1.Interval = 1000;
                timer1.Enabled = true;
                label13.Text = Convert.ToString(kalansoru);
                label8.Text = Convert.ToString(bilinenkelimesayisi);
                textBox1.Enabled = true;
                button5.Text = "Tahmin Et";
                sayacacilis++;

            }







            kelime[0] = "SOKRATES";
            kelime[1] = "RÖNESANS";
            kelime[2] = "ALDATMAK";
            kelime[3] = "DEFİNECİ";
            kelime[4] = "SELÇUKLU";
            secilenkelime = kelime[secilenkelimesayi];

            if (textBox1.Text.Length == 1 &&    sayacacilis!=0) 
            {
                if (harf1.Text == textBox1.Text.ToUpper())
                {
                    harf1.Visible = Enabled;
                    tatata = true;
                }
                if (harf2.Text == textBox1.Text.ToUpper())
                {
                    harf2.Visible = Enabled;
                    tatata = true;
                }
                if (harf3.Text == textBox1.Text.ToUpper())
                {
                    harf3.Visible = Enabled;
                    tatata = true;
                }
                if (harf4.Text == textBox1.Text.ToUpper())
                {
                    harf4.Visible = Enabled;
                    tatata = true;
                }
                if (harf5.Text == textBox1.Text.ToUpper())
                {
                    harf5.Visible = Enabled;
                    tatata = true;
                }
                if (harf6.Text == textBox1.Text.ToUpper())
                {
                    harf6.Visible = Enabled;
                    tatata = true;
                }
                if (harf7.Text == textBox1.Text.ToUpper())
                {
                    harf7.Visible = Enabled;
                    tatata = true;
                }
                if (harf8.Text == textBox1.Text.ToUpper())
                {
                    harf8.Visible = Enabled;
                    tatata = true;
                }
                if (tatata==false && textBox1.Text.Length==1)
                {
                    if (sayacacilis!=0)
                    {
                        //bilinmeyenharfler[s] = Convert.ToChar(textBox1.Text.ToUpper());
                        //s++;
                        kalan_hak--;
                        hay = textBox1.Text.ToUpper();
                        aw[O] = hay;
                        O++;
                        label12.Text = Convert.ToString(aw[0]+"  "+aw[1]+"  "+aw[2]+"  "+aw[3]+"  "+aw[4]+"  "+aw[5]);
                    }
                }
                tatata = false;
            }



            if (textBox1.Text.ToUpper() == secilenkelime && textBox1.Text.Length > 1  &&    sayacacilis!=0)
            {
                kalansoru--;
                label13.Text = Convert.ToString(kalansoru);
                bilinenkelimesayisi++;
                help++;
                label8.Text = Convert.ToString(bilinenkelimesayisi);
                kelimeyibildimi = true;


                bukelimegecti[sayacb] = secilenkelimesayi;
                sayacb++;
                

                harf1.Text = "";
                harf1.Visible = false;
                harf2.Text = "";
                harf2.Visible = false;
                harf3.Text = "";
                harf3.Visible = false;
                harf4.Text = "";
                harf4.Visible = false;
                harf5.Text = "";
                harf5.Visible = false;
                harf6.Text = "";
                harf6.Visible = false;
                harf7.Text = "";
                harf7.Visible = false;
                harf8.Text = "";
                harf8.Visible = false;
            }
            
            else if (textBox1.Text.Length>1 && secilenkelime != textBox1.Text.ToUpper() && sayacacilis!=0)
            {
                kalan_hak--;
            }
            
            if (kelimeyibildimi == true&&sayacacilis!=0     &&   help!=5)
            {

                for (int i = 0; ; i++)
                {
                    secilenkelimesayi = asddsa.Next(0, 5);
                    asfd = false;
                    for (int j = 0; j < 5; j++)
                    {
                        if (secilenkelimesayi == bukelimegecti[j])
                            asfd = true;
                    }
                    if (asfd == false)
                        break;
                    
                }
                kelimeyibildimi = false;

                
            }


            

            if (secilenkelimesayi == 0)
                soru.Text = "Platon'un hocası, zamanında dinsizlik \nsuçlaması yüzünden idam ettirilmiş kral filozof.";
            else if (secilenkelimesayi == 1)
                soru.Text = "Orta Çağdan sonra gelen 'Yeniden Doğuş'\n anlamına da gelen tarihi dönem.";
            else if (secilenkelimesayi == 2)
                soru.Text = "Sadakatsizlik (bir fiil)";
            else if (secilenkelimesayi == 3)
                soru.Text = "Hazine arayan kişilere verilen ad";
            else
                soru.Text = "Malazgirt savaşını yapmış eski bir\n Türk İmparatorluğu.";

            harf1.Text = Convert.ToString(kelime[secilenkelimesayi][0]);
            harf2.Text = Convert.ToString(kelime[secilenkelimesayi][1]);
            harf3.Text = Convert.ToString(kelime[secilenkelimesayi][2]);
            harf4.Text = Convert.ToString(kelime[secilenkelimesayi][3]);
            harf5.Text = Convert.ToString(kelime[secilenkelimesayi][4]);
            harf6.Text = Convert.ToString(kelime[secilenkelimesayi][5]);
            harf7.Text = Convert.ToString(kelime[secilenkelimesayi][6]);
            harf8.Text = Convert.ToString(kelime[secilenkelimesayi][7]);

            if (kalan_hak == 5 && sayacacilis!=0)
            {
                pictureBox2.Visible = true;
            }
            else if (kalan_hak == 4 && sayacacilis != 0)
            {
                pictureBox3.Visible = true;
            }
            else if (kalan_hak == 3 && sayacacilis != 0)
            {
                pictureBox7.Visible = true;
            }
            else if (kalan_hak == 2 && sayacacilis != 0)
            {
                pictureBox4.Visible = true;
            }
            else if (kalan_hak == 1 && sayacacilis != 0)
            {
                pictureBox6.Visible = true;
            }
            else if (kalan_hak == 0 && sayacacilis != 0)
            {
                pictureBox5.Visible = true;
                label6.Visible = true;
                timer1.Enabled=false;

                harf1.Text = "";
                harf1.Visible = false;
                harf2.Text = "";
                harf2.Visible = false;
                harf3.Text = "";
                harf3.Visible = false;
                harf4.Text = "";
                harf4.Visible = false;
                harf5.Text = "";
                harf5.Visible = false;
                harf6.Text = "";
                harf6.Visible = false;
                harf7.Text = "";
                harf7.Visible = false;
                harf8.Text = "";
                harf8.Visible = false;

                textBox1.Enabled = false;

                button5.Text = "Tekrar Oyna";

                oyunbitti = 1;
            }

            
            if (help==5)
            {
                label14.Visible = Enabled;

                timer1.Enabled = false;

                harf1.Text = "";
                harf1.Visible = false;
                harf2.Text = "";
                harf2.Visible = false;
                harf3.Text = "";
                harf3.Visible = false;
                harf4.Text = "";
                harf4.Visible = false;
                harf5.Text = "";
                harf5.Visible = false;
                harf6.Text = "";
                harf6.Visible = false;
                harf7.Text = "";
                harf7.Visible = false;
                harf8.Text = "";
                harf8.Visible = false;

                textBox1.Enabled = false;

                button5.Text = "Tekrar Oyna";

                oyunbitti = 1;
            }
            

            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Berkcan Ciboğlu\nxTiXi\nİletişim: berkcan112233@gmail.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

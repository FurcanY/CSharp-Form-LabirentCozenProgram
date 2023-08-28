using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirent_Cozen_Program
{
    internal class Labirent
    {
        private Label[,] hucreler = new Label[30, 30];
        private int[,] veriler = new int[30, 30];
        //mesela veriler[0,0] dizisine -1 atamak o hucrenin duvar oldugu anlamina gelir
        //veriler[0,0] = 0 olursa o hucrenin bos bir hucre oldugu anlamina geliyor.

        private int boyut = 20;
        //her bir labelin genislik ve uzunluk bilgisini tutan degisken

        private Color renk = Color.White;

        private int bosluk = 2;
        //her iki label arasi bosluk bilgisi

        public Labirent()
        {
            //constructor
            Labirent_Olustur();
        }

        private void Labirent_Olustur()
        {
            int kordinatx = 0;
            int kordinaty = 0;
            for (int x = 0; x < 30; x++)
            {
                for (int y = 0; y < 30; y++)
                {
                    if (x == 0 || x == 29 || y == 29 || y == 0)
                    {
                        veriler[x, y] = -1;
                        //labirentin dis cercevesini duvar yapmak
                    }
                    else
                    {
                        veriler[x, y] = 0;
                    }
                    Label_Olustur(x, y, kordinatx, kordinaty);
                    kordinatx = kordinatx + boyut + bosluk;
                }
                //her satir sonrasi x koordinati sifirlanir
                kordinatx = 0;
                kordinaty = kordinaty + boyut + bosluk;
            }
        }
        private void Label_Olustur(int x, int y, int kordinatx, int kordinaty)
        {
            Label lbl = new Label();
            lbl.Size = new Size(boyut, boyut);
            lbl.Font = new Font("Arial", 6);
            lbl.ForeColor = Color.Black;

            lbl.Text = x.ToString() + " " + y.ToString();
            //labelin hucreler dizisindeki indis bilgileri textine yazilir (daha sora bu bilgi ile label'a erisecegiz)
            if (veriler[x, y] == -1)
            {
                
                lbl.BackColor = Color.Black;
                //labirentin dis cercevesini olusturmak icin siyah renk yaptik.
            }
            else
            {
                //renk= color.white
                lbl.BackColor = renk;
            }
            lbl.Location = new Point(kordinatx, kordinaty);
            hucreler[x, y] = lbl;
            //en sonda hucreler adindaki lbl dizimizin dogru indexine labelimizi atiyoruz.
        }
        public void Labirent_Yerlestir(Form1 form)
        {
            for (int x = 0; x < 30; x++)
            {
                for (int y = 0; y < 30; y++)
                {
                    form.Controls.Add(hucreler[x,y]);
                    //parametre olarak alinan forma olusturmus oldugumuz labelleri ekliyoruz.
                }
            }
        }

    }
}

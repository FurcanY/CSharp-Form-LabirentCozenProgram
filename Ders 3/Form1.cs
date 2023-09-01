namespace Labirent_Cozen_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Labirent labirent = new Labirent();
        int veri = -2;
        bool YerlestirmeOlsunMu = false;
        //Labirent hucrelerin verisini gondermek icin gerekli global degisken.
        /*
            veri = -2  -> varsayilan degerdir hicbir eleman koyulmayacagi anlamina gelir
            veri = -1 -> duvar koyma verisi ( kahverengi label)
            veri = 0 -> bos hucre verisi (beyaz label)
            veri = 1 -> hucrenin uzerinden gecildigi anlamina gelir (sari label)
            veri = 2 -> hucrenin baslangic noktasi oludugu anlamina gelir.
            veri = 3 -> hucrenin bitis noktasi oldugu anlamina gelir.
            veri = 5 -> hucrenin uzerinden gecilip yanlis yol oldugu anlamina gelir (kirmizi label)
         */
        private void Form1_Load(object sender, EventArgs e)
        {

            labirent.Labirent_Yerlestir(this);
            Label_EventEkle();
        }

        private void DuvarKoy_Btn_Click(object sender, EventArgs e)
        {
            veri = -1;
            label1.Text = veri.ToString();
        }

        private void Hucre_Sifirla_Btn_Click(object sender, EventArgs e)
        {
            veri = 0;
            label1.Text = veri.ToString();

        }

        private void BaslangicKapi_Koy_Btn_Click(object sender, EventArgs e)
        {
            veri = 2;
            label1.Text = veri.ToString();

        }

        private void BitisKapisi_Koy_Click(object sender, EventArgs e)
        {
            veri = 3;
            label1.Text = veri.ToString();

        }

        private void Butun_Hucre_Sil_Btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Butun Hucreler Bos Hucre Ile Degistirilecek. Onayliyor Musunuz ?", "Dikkat", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
                labirent.Hucre_Veri_Sil();

        }

        public void Label_EventEkle()
        {
            if (labirent != null)
            {
                for (int y = 1; y < 29; y++)
                {
                    for (int x = 1; x < 29; x++)
                    {
                        labirent.Label_Getir(x, y).Click += new EventHandler(Label_Click);
                        labirent.Label_Getir(x, y).MouseEnter += Label_Enter;
                    }
                }
            }
        }
        private void Label_Click(object? sender, EventArgs e)
        {
            if (!YerlestirmeOlsunMu)
            {

                YerlestirmeOlsunMu = true;
                Bilgi_Lbl_Degistir(YerlestirmeOlsunMu);
                Label? lbl = sender as Label;
                if (lbl != null)
                {
                    VeriGirisi(lbl);
                }

            }
            else
            {


                YerlestirmeOlsunMu = false;
                Bilgi_Lbl_Degistir(YerlestirmeOlsunMu);
            }

        }
        private void Label_Enter(object? sender, EventArgs e)
        {
            if (YerlestirmeOlsunMu)
            {
                Label? lbl = sender as Label;
                if (lbl != null)
                {
                    VeriGirisi(lbl);
                }
            }
        }
        private void VeriGirisi(Label lbl)
        {
            int x = 0, y = 0;
            string xverisi = "", yverisi = "";
            bool ikinciVeriGec = false;
            for (int i = 0; i < lbl.Text.Length; i++)
            {
                if (lbl.Text[i] == ' ')
                {
                    ikinciVeriGec = true;
                    continue;
                }
                if (!ikinciVeriGec)
                {
                    xverisi += lbl.Text[i];
                }
                if (ikinciVeriGec)
                {
                    yverisi += lbl.Text[i];
                }

            }
            x = Int16.Parse(xverisi);
            y = Int16.Parse(yverisi);

            labirent.Veri_Degistir(x, y, veri);
            if (veri == 2 || veri == 3)
            {
                YerlestirmeOlsunMu = false;
                Bilgi_Lbl_Degistir(YerlestirmeOlsunMu);
            }
        }
        public void Bilgi_Lbl_Degistir(bool durum)
        {
            if (durum)
            {
                Bilgi_Lbl.Text = "Yerlestirme : Aktif";
                Bilgi_Lbl.BackColor = Color.Green;
            }
            else
            {
                Bilgi_Lbl.Text = "Yerlestirme : Pasif";
                Bilgi_Lbl.BackColor = Color.Red;
            }
        }

        private void Coz_Btn_Click(object sender, EventArgs e)
        {
            int[] baslangicKapi = new int[2];
            if (labirent.KapilarVarMi() == true)
            {
                if (labirent.BaslangicKapi_Veri_Al() != null)
                {
                    baslangicKapi = labirent.BaslangicKapi_Veri_Al();
                }
                if (labirent.Labirent_Coz(baslangicKapi[0], baslangicKapi[1]) == 1)
                {
                    MessageBox.Show("Labirent Cozuldu");

                }
                else
                {
                    MessageBox.Show("Bu Labirent Cozulemez !");
                }
            }
            else
            {
                MessageBox.Show("Kapilar eksik. Kapilari koyduguna emin ol !");
            }
        }
    }
}
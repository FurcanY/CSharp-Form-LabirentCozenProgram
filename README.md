# Labirent Çözen Program  :star:

### Bu programımızda kendimiz labirent oluşturabilir, oluşturduğumuz labirenti kaydedebilir ve oluşturlan labirenti programa geri yükleyebiliriz. 

### Ayrıca oluşturulan labirenti çözebilen bir algoritmamız da var.
### Bu algoritmamızın çalışma prensibi Backtracking (Geri İzleme)Algoritması'na dayanıyor



<p style="text-align: center ;color:blue">--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------</p>

#  :collision: "Backtracing Algoritması Nedir ?" Adlı videoma [buraya tıklayarak](https://youtu.be/6JvVelUz4jo?si=Sz1g9GgEbIt_s6av) ulaşabilirsiniz. :purple_heart: :collision:

<p align="center">
  <img src="https://github.com/waldyr/Sublime-Installer/blob/master/sublime_text.png?raw=true" width="320" height="180"/>
</p>





#  :collision: Ayrıca bu programın nasıl yapıldığını anlattığım bir YouTube oynatma listem var. Bu listeme ulaşmak için [buraya tıklayarak](https://youtu.be/6JvVelUz4jo?si=Sz1g9GgEbIt_s6av) ulaşabilirsiniz. :purple_heart: :collision:
<p align="center">
  <img src="https://github.com/waldyr/Sublime-Installer/blob/master/sublime_text.png?raw=true" />
</p>

<p style="text-align: center ;color:blue">--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------</p>
<p align="center">

##  :star: Program İçinden Görüntüler :star:

<p align="center">
  <img src="https://github.com/waldyr/Sublime-Installer/blob/master/sublime_text.png?raw=true" />
</p>
<p align="center">
  <img src="https://github.com/waldyr/Sublime-Installer/blob/master/sublime_text.png?raw=true" />
</p>
<p align="center">
  <img src="https://github.com/waldyr/Sublime-Installer/blob/master/sublime_text.png?raw=true" />
</p>

## Proje İçinden Örnek Kodlar 💾

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

            private int[] baslangicKapiVeri = new int[2] {0,0};
            //baslangic kapisi koordinat labirent cozumu yapilirken gerekli olacak
            private int[] bitisKapiVeri=new int[2] {0,0};
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
                //bu if blogu hucreler olusurken bos hucrenin textini beyaza boyar(video sonrasi duzenleme ile koyulmustur.Videoda boyle bir kod yazilmamistir)
                if (veriler[x, y] == 0)
                {
                    lbl.ForeColor = Color.White;

                }

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



## :rose: Belki Bakarsın Diye Bırakıyorum :rose:
####  GitHub adresime [buradan](https://github.com/FurcanY) ulaşabilirsiniz.
####  İnstagram adresime [buradan](https://www.instagram.com/y.furcan/) ulaşabilirsiniz.
####  Youtube adresime [buradan](https://www.youtube.com/channel/UCQRXjt0lg2jCnp2NqOAO2Ig) ulaşabilirsiniz.
####  Itch.io adresime [buradan](https://furcany.itch.io/) ulaşabilirsiniz.
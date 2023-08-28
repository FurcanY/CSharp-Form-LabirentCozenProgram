namespace Labirent_Cozen_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Labirent labirent=new Labirent();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            labirent.Labirent_Yerlestir(this);
        }
    }
}
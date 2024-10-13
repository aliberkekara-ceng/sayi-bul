using System.Numerics;
using System.Security.Policy;
using System.Windows.Forms;

namespace nypödevaliberkekara
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string a = "Programa Hoşgeldiniz!";
            string b = "Nesne Yönelimli Programlama Ödev 1";
            notify1.Visible = true;
            notify1.ShowBalloonTip(4000, a, b, ToolTipIcon.Info);

        }

        public bool MukemmelSayiKontrol(int sayi)
        {
            int mukemmelKontrol = 0;
            for (int k = 1; k < sayi; k++)
            {
                if (sayi % k == 0)
                {
                    mukemmelKontrol = mukemmelKontrol + k;
                }
            }

            if (sayi == mukemmelKontrol)
            {
                return true;
            }
            return false;
        }


        public bool AsalSayiKontrol(int sayi)
        {
            if (sayi == 1)
                return false;

            for (int j = 2; j <= sayi / 2; j++)
            {
                if (sayi % j == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            listView2.Clear();
            listView3.Clear();
            listView4.Clear();

            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            long toplamTek = 0;
            long carpımTek = 1;
            long toplamCift = 0;
            long carpımCift = 1;
            long asalKontrol = 0;
            long carpımAsal = 1;
            long toplamAsal = 0;
            long carpimMukemmel = 1;
            long toplamMukemmel = 0;
            int mukemmelKontrol = 0;

            for (int i = sayi1; i < sayi2; i++)
            {
                sayi1++;
                if (sayi1 % 2 == 1)
                {
                    listView1.Items.Add(sayi1.ToString());
                    toplamTek += sayi1;
                    carpımTek = carpımTek * sayi1;
                }
                else
                {
                    listView2.Items.Add(sayi1.ToString());
                    toplamCift += sayi1;
                    carpımCift = carpımCift * sayi1;
                }

                if (AsalSayiKontrol(i))
                {
                    listView3.Items.Add(i.ToString());
                    carpımAsal = carpımAsal * i;
                    toplamAsal += i;

                }

                if (MukemmelSayiKontrol(i))
                {
                    listView4.Items.Add(i.ToString());
                    carpimMukemmel = carpimMukemmel * i;
                    toplamMukemmel += i;
                }
            }

            MessageBox.Show("Tek sayıların toplamı: " + toplamTek + "\nTek sayıların çarpımı: " + carpımTek);
            MessageBox.Show("Çift sayıların toplamı: " + toplamCift + "\nÇift sayıların çarpımı: " + carpımCift);
            MessageBox.Show("Asal sayıların toplamı: " + toplamAsal + "\nAsal sayıların çarpımı: " + carpımAsal);
            MessageBox.Show("Mükemmel sayıların toplamı: " + toplamMukemmel + "\nMükemmel sayıların çarpımı: " + carpimMukemmel);

            txtSayi1.Clear();
            txtSayi2.Clear();
            txtSayi1.Focus();

        }


    }
}
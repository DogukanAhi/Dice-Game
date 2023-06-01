namespace Zar_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int oyuncu1,oyuncu2;
        int oyuncu1hak=5,oyuncu2hak=5;
        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int zar1 = random.Next(1, 7), zar2 = random.Next(1, 7);
            label8.Text = Convert.ToString(zar1);
            label9.Text = Convert.ToString(zar2);
            oyuncu2 = zar1 + zar2 + oyuncu2;
            label14.Text = Convert.ToString(oyuncu2);
            if (zar1 == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\1.png";
            }
            else if (zar1 == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\2.jpg";
            }
            else if (zar1 == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\3.png";
            }
            else if (zar1 == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\4.png";
            }
            else if (zar1 == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\5.png";
            }
            else if (zar1 == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\6.png";
            }
            if (zar2 == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\1.png";
            }
            else if (zar2 == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\2.jpg";
            }
            else if (zar2 == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\3.png";
            }
            else if (zar2 == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\4.png";
            }
            else if (zar2 == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\5.png";
            }
            else if (zar2 == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\6.png";
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random= new Random();
            int zar1= random.Next(1, 7), zar2= random.Next(1, 7);   
            if(zar1 == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\1.png";
            }
            else if (zar1 == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\2.jpg";
            }
            else if (zar1 == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\3.png";
            }
            else if (zar1 == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\4.png";
            }
            else if (zar1 == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\5.png";
            }
            else if (zar1 == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\6.png";
            }
            if (zar2 == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\1.png";
            }
            else if (zar2 == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\2.jpg";
            }
            else if (zar2 == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\3.png";
            }
            else if (zar2 == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\4.png";
            }
            else if (zar2 == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\5.png";
            }
            else if (zar2 == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\bf427\\Desktop\\Yeni klasör\\6.png";
            }

            label4.Text = Convert.ToString(zar1);
            label5.Text = Convert.ToString(zar2);
            oyuncu1 = zar1 + zar2 + oyuncu1;
            label15.Text= Convert.ToString(oyuncu1);






        }
    }
}
using System.Media;

namespace Mina_tampa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Oyundan çıxış edilsinmi?", "Sual", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }
        int num;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            num = r.Next(1, 7);
        }
        bool k = false;
        private void button1_Click(object sender, EventArgs e)
        {
            count = 0;
            label2.Text=count.ToString();
            Random r = new Random();
            num = r.Next(1, 7);
            if (k == false)
            {
                k = true;
                pictureBox1.ImageLocation = "D:\\ASP.NET\\img\\question.png";
                pictureBox2.ImageLocation = "D:\\ASP.NET\\img\\question.png";
                pictureBox3.ImageLocation = "D:\\ASP.NET\\img\\question.png";
                pictureBox4.ImageLocation = "D:\\ASP.NET\\img\\question.png";
                pictureBox5.ImageLocation = "D:\\ASP.NET\\img\\question.png";
                pictureBox6.ImageLocation = "D:\\ASP.NET\\img\\question.png";
            }
            else
            {
                k = false;
                pictureBox1.ImageLocation = "D:\\ASP.NET\\img\\question.png";
                pictureBox2.ImageLocation = "D:\\ASP.NET\\img\\question.png";
                pictureBox3.ImageLocation = "D:\\ASP.NET\\img\\question.png";
                pictureBox4.ImageLocation = "D:\\ASP.NET\\img\\question.png";
                pictureBox5.ImageLocation = "D:\\ASP.NET\\img\\question.png";
                pictureBox6.ImageLocation = "D:\\ASP.NET\\img\\question.png";
            }
        }
        int count = 0;
        SoundPlayer sp = new SoundPlayer("D:\\C# lesson\\img\\bomba\\explosion.wav");
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                if (count != 0)
                    count--;
                pictureBox1.ImageLocation = "D:\\ASP.NET\\img\\bomba.png";
                sp.Play();
                DialogResult d=MessageBox.Show("Oyun bitdi, Yeni oyun üçün Ok edin", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                count++;
                pictureBox1.ImageLocation = "D:\\ASP.NET\\img\\cat.png";
            }
            label2.Text = count.ToString();
            if (count == 5)
            {
                MessageBox.Show("Oyunu qazandınız");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (num == 2)
            {
                if (count != 0)
                    count--;
                pictureBox2.ImageLocation = "D:\\ASP.NET\\img\\bomba.png";
                sp.Play();
                DialogResult d = MessageBox.Show("Oyun bitdi, Yeni oyun üçün Ok edin", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                count++;
                pictureBox2.ImageLocation = "D:\\ASP.NET\\img\\cat.png";
            }
            label2.Text = count.ToString();
            if (count == 5)
            {
                MessageBox.Show("Oyunu qazandınız");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (num == 3)
            {
                if (count != 0)
                    count--;
                pictureBox3.ImageLocation = "D:\\ASP.NET\\img\\bomba.png";
                sp.Play();
                DialogResult d = MessageBox.Show("Oyun bitdi, Yeni oyun üçün Ok edin", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                count++;
                pictureBox3.ImageLocation = "D:\\ASP.NET\\img\\cat.png";
                
            }
            label2.Text = count.ToString();
            if (count == 5)
            {
                MessageBox.Show("Oyunu qazandınız");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (num == 6)
            {
                if (count != 0)
                    count--;
                pictureBox6.ImageLocation = "D:\\ASP.NET\\img\\bomba.png";
                sp.Play();
                DialogResult d = MessageBox.Show("Oyun bitdi, Yeni oyun üçün Ok edin", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                count++;
                pictureBox6.ImageLocation = "D:\\ASP.NET\\img\\cat.png";
            }
            label2.Text = count.ToString();
            if (count == 5)
            {
                MessageBox.Show("Oyunu qazandınız");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (num == 5)
            {
                if (count != 0)
                    count--;
                pictureBox5.ImageLocation = "D:\\ASP.NET\\img\\bomba.png";
                sp.Play();
                DialogResult d = MessageBox.Show("Oyun bitdi, Yeni oyun üçün Ok edin", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                count++;
                pictureBox5.ImageLocation = "D:\\ASP.NET\\img\\cat.png";
            }
            label2.Text = count.ToString();
            if (count == 5)
            {
                MessageBox.Show("Oyunu qazandınız");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (num == 4)
            {
                if (count != 0)
                    count--;
                pictureBox4.ImageLocation = "D:\\ASP.NET\\img\\bomba.png";
                sp.Play();
                DialogResult d = MessageBox.Show("Oyun bitdi, Yeni oyun üçün Ok edin", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                count++;
                pictureBox4.ImageLocation = "D:\\ASP.NET\\img\\cat.png";
            }
            label2.Text=count.ToString();
            if (count == 5)
            {
                MessageBox.Show("Oyunu qazandınız");
            }
        }
    }
}

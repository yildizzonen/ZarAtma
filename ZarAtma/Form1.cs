namespace ZarAtma
{
    public partial class Form1 : Form
    {
        int sayac = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int zar1, zar2;
            Random rnd = new Random();
            zar1 = rnd.Next(0, 5);
            zar2 = rnd.Next(0, 5);
            pb1.Image = ýmageList1.Images[zar1];
            pb2.Image = ýmageList1.Images[zar2];
            textzar1.Text = (zar1 + 1).ToString();
            textzar2.Text = (zar2 + 1).ToString();
            sayac++;
            if (sayac == 10)
            {
                timer1.Stop();
                sayac = 0;
                button1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                listBox1.Items.Add(textzar1.Text + "    " + textzar2.Text);
                textBox1.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textzar1.Text) + Convert.ToInt32(textzar2.Text)).ToString();

            }
            else
            {
                listBox2.Items.Add(textzar1.Text + "    " + textzar2.Text);
                textBox2.Text = (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textzar1.Text) + Convert.ToInt32(textzar2.Text)).ToString();
            }
            if (listBox1.Items.Count == listBox2.Items.Count)
            {

                if (textBox1.Text == textBox2.Text)
                {
                    MessageBox.Show("Berabere!");
                }
                else if (Convert.ToInt32(textBox1.Text) > Convert.ToInt32(textBox2.Text))
                {
                    MessageBox.Show("Oyuncu 1 Kazandý!");
                }
                else
                {
                    MessageBox.Show("Oyuncu 2 Kazandý!");
                }

                textBox1.Text = "0";
                textBox2.Text = "0";
                listBox1.Items.Clear();
                listBox2.Items.Clear();
            }
        }
    }
}
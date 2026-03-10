namespace KuisApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CekJawaban(string pilihanUser)
        {
            string kunciJawaban = "A";

            if (pilihanUser == kunciJawaban)
            {
                label2.Text = "Jawaban benar kamu pintar";
            }
            else
            {
                label2.Text = "Jawaban salah kurang beruntung";
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CekJawaban("A");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CekJawaban("B");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CekJawaban("C");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CekJawaban("D");
        }
    }
}

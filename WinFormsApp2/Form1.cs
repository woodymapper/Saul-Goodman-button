namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        int punkty = 0;
        public Form1()
        {
            InitializeComponent();
            
                }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void przycisk_Click(object sender, EventArgs e)
        {
            int XmaX = this.Size.Width - przycisk.Size.Width - 50;
            int YmaX = this.Size.Height - przycisk.Size.Height - 50;
            Random r;
            r = new Random();

            Point p = new Point();
            p.X = r.Next(12, XmaX);
            p.Y = r.Next(12, YmaX);
            przycisk.Location = p;
            punkty++;
            string a = punkty.ToString();
            label1.Text = a;
            if (label1.Text == "5") { label1.Text = "5!"; }
            if (label1.Text == "10") { label1.Text = "10!"; }
            if (label1.Text == "15") { label1.Text = "15!"; }
            if (label1.Text == "20") { label1.Text = "20!"; }

            Random rnd = new Random();
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            Random rnd2 = new Random();
            Color randomColor2 = Color.FromArgb(rnd2.Next(256), rnd2.Next(256), rnd2.Next(256));

            przycisk.BackColor = randomColor2;
            this.BackColor = randomColor;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int XmaX = this.Size.Width - przycisk.Size.Width - 50;
            int YmaX = this.Size.Height - przycisk.Size.Height - 50;
            punkty = 0;
            string a = punkty.ToString();
            label1.Text = a;
            przycisk.BackColor = Color.White;
            this.BackColor = Color.White;
            Random r;
            r = new Random();

            Point p = new Point();
            p.X = r.Next(12, XmaX);
            p.Y = r.Next(12, YmaX);
            przycisk.Location = p;


            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\1157376\Downloads\bcs.wav");
            player.Play();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
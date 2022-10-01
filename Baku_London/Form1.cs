namespace Baku_London
{
    public partial class Form1 : Form
    {
        bool flag = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Baku.BringToFront();
            London.BringToFront();

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Start();
            timer.Interval = 1000;
            timer.Tick += (s, e) => Time.Text = flag ? DateTime.Now.ToLongTimeString() : DateTime.UtcNow.ToLongTimeString();
        }

        private void Baku_Click(object sender, EventArgs e)
        {
            flag = true;
            BackgroundImage = Properties.Resources.baku;
        }

        private void London_Click(object sender, EventArgs e)
        {
            flag = false;
            BackgroundImage = Properties.Resources.london;
        }
    }
}
namespace RunnerLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            Random rand = new Random();
            (sender as Label).Location = new Point(rand.Next(0,715),rand.Next(5,437));
        }
    }
}
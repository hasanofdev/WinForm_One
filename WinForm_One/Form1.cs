namespace WinForm_One
{
    public partial class Paint : Form
    {
        public int StartX { get; set; }
        public int StartY { get; set; }
        public Paint()
        {
            InitializeComponent();
        }

        private void Paint_MouseDown(object sender, MouseEventArgs e)
        {
            StartX = e.X;
            StartY = e.Y;
        }

        private void Paint_MouseUp(object sender, MouseEventArgs e)
        {
            int EndX = e.X;
            int EndY = e.Y;

            if (EndX < StartX)
            {
                int temp = EndX;
                EndX = StartX;
                StartX = temp;
            }

            if (EndY < StartY)
            {
                int temp = EndY;
                EndY = StartY;
                StartY = temp;
            }

            if (EndX - StartX < 10 && EndY - StartY < 10)
                MessageBox.Show("Size Min:10x10", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Label label = new Label();
                label.Text = Controls.Count.ToString();
                label.BorderStyle = BorderStyle.FixedSingle;
                label.Location = new Point(StartX, StartY);
                label.Size = new Size(EndX - StartX, EndY - StartY);
                label.MouseClick += label1_MouseClick;
                label.MouseDoubleClick += label1_MouseDoubleClick;
                Controls.Add(label);
                Controls[Controls.Count - 1].BringToFront();
            }


        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            Label? label = sender as Label;
            if (e.Button == MouseButtons.Left)
                this.Text = $"{label.Height * label.Width}px X:{label.Location.X} Y:{label.Location.Y}";
        }

        private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Label? label = sender as Label;
            if (e.Button == MouseButtons.Left)
                Controls.Remove(label);
        }
    }
}
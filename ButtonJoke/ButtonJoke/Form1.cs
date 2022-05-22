namespace ButtonJoke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            button1.Location = new Point(random.Next(0, Size.Width), random.Next(0, Size.Height));
        }
    }
}
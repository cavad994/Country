namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int Id = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int hour = DateTime.Now.Hour; int minute = DateTime.Now.Minute; int second = DateTime.Now.Second;

            if (Id % 2 == 0)
                if (DateTime.Now.Hour > 3)
                    hour = DateTime.Now.Hour - 3;
                else
                    hour = 12 - 3;


            Text = $"{hour} : {minute} : {second}";

            Image image;
            if (Id++ % 2 == 0)
                image = new Bitmap(@"C:\Users\Yusi_di18\Desktop\Baku&London\download (1).jpg");
            else
                image = new Bitmap(@"C:\Users\Yusi_di18\Desktop\Baku&London\download.jpg");

            BackgroundImage = image;
        }
    }
}
namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 3;
            float y = 4.5f;
            short z = 5;
            double w = 1.7E+3;
            label1.Text = (x + y + z + w).ToString();
            string name = "§Ó¿o";
            int salary = 26000;
            string msg = String.Format("{0}ªº¤ëÁ~{1}", name, salary);
            label2.Text = msg.ToString();
        }
    }
}
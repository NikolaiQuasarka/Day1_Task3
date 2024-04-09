namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const double v = 0.001;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(x_textBox.Text, out double x)) {
                double f = 0;
                for (int n = 1; Math.Abs(Number(x, n)-Number(x,n+1))>v; n++) 
                {
                    f += Number(x, n);
                }
                f_textBox.Text = (x*f).ToString();
            }
        }
        private double Number(double x, int n)
        {
            return Math.Pow(-1, n - 1) * (Math.Pow(x, 2 * n)/(Factorial(n)*(2*n+1)));
        }
        public static int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
    }
}

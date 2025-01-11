namespace CALC
{
    public partial class Calc : Form
    {
        private double num1, num2;
        private double _operator;

        public Calc()
        {
            InitializeComponent();
            num1 = 0; num2 = 0.0;
            _operator = '\0';
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {

        }

        private void btn_digit_click(object sender, EventArgs e)
        {
            Button _btn = sender as Button;
            txt_display.Text += _btn.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txt_display.Clear();
        }

        private void btn_operator_click(object sender, EventArgs e)
        {
            Button _btn = sender as Button;
            num1 = Convert.ToDouble(txt_display.Text);
            _operator = Convert.ToChar(_btn.Text);
            txt_display.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double ans = 0.0;
            num2 = Convert.ToDouble(txt_display.Text);

            switch (_operator)
            {
                case '+':
                    ans = num1 + num2;
                    break;
                case '-':
                    ans = num1 - num2;
                    break;
                case '*':
                    ans = num1 * num2;
                    break;
                case '/':
                    ans = num1 / num2;
                    break;
            }
            txt_display.Text = Convert.ToString(ans);
        }

        private void btn_percent_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txt_display.Text);
            txt_display.Text = (value / 100).ToString();
        }

        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txt_display.Text);
            txt_display.Text = Math.Sqrt(value).ToString();
        }
    }
}

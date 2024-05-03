namespace rule34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int X = int.Parse(textBox1.Text);
                int Y = int.Parse(textBox2.Text);

                if (X == -34 || Y == -1)
                {
                    label3.Text = "Соси, на ноль делить нельзя";
                    return;
                }

                float result = (X + Y) / (Y + 1) - (X * Y - 12) / (34 + X);
                label3.Text = result.ToString();
            }
            catch (FormatException)
            {
                label3.Text = "Хуйня переделывай";
            }
        }
    }
}

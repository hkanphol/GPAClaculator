namespace GPAX_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //4.00
            string strInput =  TexBoxGPA_input.Text;

            double sum = 0.0;

            double dInput = double.Parse(strInput);
            //sum = 0.0 + "4.00"
            sum = sum + dInput;
            //convert double to sting and settext to textbox
            textBoxGPAX.text = sum.ToString();
        }
    }
}
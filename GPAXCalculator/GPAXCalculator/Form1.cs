namespace GPAXCalculator
{
    public partial class Form1 : Form
    {
        GPACalculator oGPACal = new GPACalculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = this.textBoxGPA_input.Text;
            string name = this.textBoxName_input.Text;
            
            double dInput = Convert.ToDouble(input);
            oGPACal.addGPA(dInput,name);

            double gpax = oGPACal.getGPAX();
            textBoxGPAX_input.Text = Convert.ToString(gpax);

            double max = oGPACal.getMax();
            textBoxMaxGPA.Text = max.ToString();
            string maxname = oGPACal.getMaxName();
            textBoxMaxName.Text = maxname.ToString();

            textBoxGPA_input.Text = "";
            textBoxName_input.Text = "";
            textBoxAlldata.Text = oGPACal.getAlldata();

            double min = oGPACal.getmin();
            textBoxMinGPA.Text = min.ToString();
            string minname = oGPACal.getMinName();
            textBoxMinName.Text = minname.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxGPAX_input.Text = "";
            textBoxGPA_input.Text = "";
            textBoxMinGPA.Text = "";
            textBoxMaxGPA.Text = "";
            textBoxAlldata.Text = "";
            textBoxMinName.Text = "";
            textBoxMaxName.Text = "";

        }

    }
}
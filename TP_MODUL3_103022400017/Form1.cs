namespace TP_MODUL3_103022400017
{
    public partial class Form1 : Form
    {
        int angka1 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "Label Output")
            {
                lblOutput.Text = "";
            }
            lblOutput.Text = lblOutput.Text + "2";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "Label Output")
            {
                lblOutput.Text = "";
            }
            lblOutput.Text = lblOutput.Text + "1";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "Label Output")
            {
                lblOutput.Text = "";
            }
            lblOutput.Text = lblOutput.Text + "4";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "Label Output")
            {
                lblOutput.Text = "";
            }
            lblOutput.Text = lblOutput.Text + "7";
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            angka1 = int.Parse(lblOutput.Text);
            lblOutput.Text = "";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "Label Output")
            {
                lblOutput.Text = "";
            }
            lblOutput.Text = lblOutput.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "Label Output")
            {
                lblOutput.Text = "";
            }
            lblOutput.Text = lblOutput.Text + "3";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "Label Output")
            {
                lblOutput.Text = "";
            }
            lblOutput.Text = lblOutput.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "Label Output")
            {
                lblOutput.Text = "";
            }
            lblOutput.Text = lblOutput.Text + "6";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "Label Output")
            {
                lblOutput.Text = "";
            }
            lblOutput.Text = lblOutput.Text + "9";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "Label Output")
            {
                lblOutput.Text = "";
            }
            lblOutput.Text = lblOutput.Text + "9";
        }

        private void btnNol_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "Label Output")
            {
                lblOutput.Text = "";
            }
            lblOutput.Text = lblOutput.Text + "0";
        }

        private void btnSamaDengan_Click(object sender, EventArgs e)
        {
            int angka2 = int.Parse(lblOutput.Text);
            int hasil = angka1 + angka2;
            lblOutput.Text = hasil.ToString();
        }
    }
}

namespace meuprojetowff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHamburger.Checked == true)

            {
                numericHamburger.Enabled = true;
                textTotalHamburger.Enable = true;
            }
            else
            {

                numericHamburger.Enable = false;
                txtTotalHamburger.Enable = false;
                numericHamburger.Value = 0;
                txtTotalHamburger.Text = "0,00";

            }







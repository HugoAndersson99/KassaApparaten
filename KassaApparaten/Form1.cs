namespace KassaApparaten
{
    public partial class Form1 : Form
    {
        //KOD FÖR ADMIN = 1234
        KassaApparaten kassaApparaten = new KassaApparaten();
        AdminForm adminForm = new AdminForm();
        public Form1()
        {
            InitializeComponent();
            kassaApparaten.form1 = this;
            adminForm.kassaApparaten = this.kassaApparaten;
            adminForm.form1 = this;
            kassaApparaten.adminForm = this.adminForm;
        }
        
        private void leaveButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            kassaApparaten.Show();
            Hide();

        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            adminForm.Show();
            Hide();
        }
    }
}
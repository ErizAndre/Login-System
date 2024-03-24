using Guna.UI2.WinForms;

namespace Login_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtboxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (txtboxName.Text == "Admin" && txtboxPass.Text == "12345")
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }

        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                txtboxPass.UseSystemPasswordChar = false;
                txtboxPass.PasswordChar = '\0';
            }
            else
            {
                txtboxPass.UseSystemPasswordChar = true;
            }
        }
    }
}

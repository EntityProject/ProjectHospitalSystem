using ProjectHospitalSystem.Forms.Admin;
using ProjectHospitalSystem.Forms.Doctor;
using ProjectHospitalSystem.Forms.Receptionist;
using ProjectHospitalSystem.Models;

namespace ProjectHospitalSystem
{
    public partial class LoginForm : Form
    {
        HospitalDbContext db;
        public LoginForm()
        {
            InitializeComponent();
            db = new HospitalDbContext();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var user = db.Users.Where(u => u.UserName == txt_userName.Text && u.Password == txt_Password.Text).FirstOrDefault();
            try
            {
                if (txt_userName.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter User Name");
                }
                else if (txt_Password.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Password");
                }
                else if (user?.UserName != txt_userName.Text && user?.Password != txt_Password.Text)
                {
                    MessageBox.Show("UserNameOrPassword Is wrong!");
                    ClearText();
                }
                else
                {
                    if (user.Role == "Admin")
                    {
                        AdminUser adminUser = new AdminUser();
                        adminUser.Show();
                        this.Hide();
                        ClearText();
                    }
                    else if (user.Role == "Doctor")
                    {
                        DoctorUser docUser = new DoctorUser();
                        docUser.Show();
                        this.Hide();
                        ClearText();
                    }
                    else if (user.Role == "Receptionist")
                    {
                        ReceptionistUser RecUser = new ReceptionistUser();
                        RecUser.Show();
                        this.Hide();
                        ClearText();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ClearText()
        {
            txt_userName.Text = txt_Password.Text = string.Empty;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearText();
        }
    }
}

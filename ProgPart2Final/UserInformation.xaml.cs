using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProgPart2Final
{
    /// <summary>
    /// Interaction logic for UserInformation.xaml
    /// </summary>
    public partial class UserInformation : Window
    {
        public UserInformation()
        {
            InitializeComponent();
        }

        //method to connect to db
        TimeManagementSystemDBEntities db = new TimeManagementSystemDBEntities();

        //encryption method
        static string Encryption(string value)
        {
            using (MD5CryptoServiceProvider crypto = new MD5CryptoServiceProvider())
            {
                UTF8Encoding encoding = new UTF8Encoding();
                byte[] data = crypto.ComputeHash(encoding.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
        //method to open registration page
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           SignUp signobj = new SignUp();
            this.Hide();
            signobj.Show();
        }


        //method to clear information
        public void clear()
        {
            tbEmail.Text = "";
            tbEmail.Text = "";
        }


        //method to login into website 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string email = tbEmail.Text;
            tbPassword.Text = Encryption(tbPassword.Text);
            

            var rec = db.Users.Where(a=>a.email == email && a.password == tbPassword.Text).FirstOrDefault();
       

            if (rec != null)
            {
                MessageBox.Show("Login Success");
                clear();
                SemesterInformation semester = new SemesterInformation();
                semester.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}

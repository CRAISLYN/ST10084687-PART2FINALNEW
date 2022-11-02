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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        //method to use the db
        TimeManagementSystemDBEntities db = new TimeManagementSystemDBEntities();

        //encrypryion method
        static string Encryption(string value)
        {
            using (MD5CryptoServiceProvider crypto = new MD5CryptoServiceProvider())
            {
                UTF8Encoding encoding = new UTF8Encoding();
                byte[] data = crypto.ComputeHash(encoding.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }


        //method for blank information
        public bool blank()
        {
            if (tbPassword.Text.Trim() == "" || tbEmail.Text.Trim() == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //private void btReg(object sender, RoutedEventArgs e)
        //{

        //}


        //method to open the login page
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UserInformation userobj = new UserInformation();
            this.Hide();
            userobj.Show();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
        //method to registre account - register button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

                User userobj = new User();
                 if (!blank())
                 {
                userobj.email = tbEmail.Text;
                userobj.password = Encryption(tbPassword.Text);
               // tbPassword.Text = Encryption(tbPassword.Text);

                db.Users.Add(userobj);
                db.SaveChanges();

                

                MessageBox.Show("Account created successfully");
            }
            else
            {
                MessageBox.Show("Please fill in the required information");
            }
            }
        }
    }


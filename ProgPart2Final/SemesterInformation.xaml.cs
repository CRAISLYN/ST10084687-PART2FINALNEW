using ProgPoeDll;
using System;
using System.Collections.Generic;
using System.Linq;
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
using static ProgPoeDll.Class1;

namespace ProgPart2Final
{
    /// <summary>
    /// Interaction logic for SemesterInformation.xaml
    /// </summary>
    public partial class SemesterInformation : Window
    {


        public SemesterInformation()
        {
            InitializeComponent();
        }

        Class1 cl = new Class1();
        //TimeManagementSystemDBEntities db = new TimeManagementSystemDBEntities();
        TimeManagementSystemDBEntities db = new TimeManagementSystemDBEntities();
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserInformation information = new UserInformation();
            information.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {






        }

        private void DataGrid2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void courseTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void hoursTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        //method to add information to db
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Is the entry correct? ",
             "Confirm Entry", MessageBoxButton.YesNo)
             == MessageBoxResult.Yes)
            {
                semesterInput semesterInput = new semesterInput();
                courseInformation information = new courseInformation();
                //courseInformation information = new courseInformation();
                List<courseInformation> informationList = new List<courseInformation>();


                Class1 cl = new Class1();
                //TimeManagementSystemDBEntities db = new TimeManagementSystemDBEntities();
                TimeManagementSystemDBEntities db = new TimeManagementSystemDBEntities();
                Cours coursobj = new Cours


                {
                    courseName = tbCourseName.Text,
                    courseCode = tbCourseCode.Text,
                    credits = Convert.ToInt32(tbCredits.Text),
                    classHours = Convert.ToInt32(tbHours.Text),
                    semesterWeeks = Convert.ToInt32(tbWeeks.Text),
                    selfStudyHoursPerWeek = cl.selfStudyHoursCalculation(Convert.ToInt32(tbCredits.Text), Convert.ToInt32(tbWeeks.Text), Convert.ToInt32(tbHours.Text)),
                    hoursRemaining = cl.hoursCalc(information.selfStudyHoursPerWeek, Convert.ToInt32(tbHours.Text))

                    //day = Convert.ToInt32(dayTB.Text),
                    //month = Convert.ToInt32(monthTB.Text),

                    //// name = courseTB.Text,
                    //hoursWorked = Convert.ToInt32(hoursTB.Text),
                    //startDate = Convert.ToDateTime(dateTB.Text)
                };


                //var courses = from c in db.Courses select c;
                //this.DataGrid1.ItemsSource = courses.ToList();
                db.Courses.Add(coursobj);

                DataGrid1.Items.Add(coursobj);

                //var courses = from c in db.Courses select c;
                //this.DataGrid1.ItemsSource = courses.ToList();

               




            }
            db.SaveChanges();
        }

        //method to bind data so that only user can see it
        public void bindGrid()
        {
            TimeManagementSystemDBEntities db = new TimeManagementSystemDBEntities();
            var userResults = from c in db.Courses
                              where c.userID == c.userID
                              select c;
            DataGrid1.ItemsSource = userResults.ToList();

        }



        
        //method to clear data
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            tbCourseName.Clear();
            tbCourseCode.Clear();
            tbCredits.Clear();
            tbHours.Clear();
            tbWeeks.Clear();
            dayTB.Clear();
            monthTB.Clear();
            //courseTB.Clear();
            hoursTB.Clear();
        }
        //private void Button_Click_5(object sender, RoutedEventArgs e)
        //{
        //    if (MessageBox.Show("The information will be arranged in ascending order? ",
        //       "Confirm Entry", MessageBoxButton.YesNo)
        //       == MessageBoxResult.Yes)
        //    {

        //        {
        //            var sorted =
        //            from information in informationList
        //            orderby information.courseName
        //            select information.courseName;

        //            foreach (var element in sorted)
        //            {
        //                DataGrid1.Items.Add(element);
        //            }
        //        }

        //    }
        //}
        //private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //}

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }

        //sleep method - multi threading
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //System.Threading.Thread.Sleep(5000);
            if (MessageBox.Show("Are you sure you want to slow down the diplay of your information? ",
            "Confirm Entry", MessageBoxButton.YesNo)
            == MessageBoxResult.Yes)
                db.SaveChanges();

                System.Threading.Thread.Sleep(5000);
            {
                {
                    semesterInput semesterInput = new semesterInput();
                    courseInformation information = new courseInformation();
                    //courseInformation information = new courseInformation();
                    List<courseInformation> informationList = new List<courseInformation>();


                    Class1 cl = new Class1();
                    //TimeManagementSystemDBEntities db = new TimeManagementSystemDBEntities();
                    TimeManagementSystemDBEntities db = new TimeManagementSystemDBEntities();
                    Cours coursobj = new Cours


                    {
                        courseName = tbCourseName.Text,
                        courseCode = tbCourseCode.Text,
                        credits = Convert.ToInt32(tbCredits.Text),
                        classHours = Convert.ToInt32(tbHours.Text),
                        semesterWeeks = Convert.ToInt32(tbWeeks.Text),
                        selfStudyHoursPerWeek = cl.selfStudyHoursCalculation(Convert.ToInt32(tbCredits.Text), Convert.ToInt32(tbWeeks.Text), Convert.ToInt32(tbHours.Text)),
                        hoursRemaining = cl.hoursCalc(information.selfStudyHoursPerWeek, Convert.ToInt32(tbHours.Text)),

                        day = Convert.ToInt32(dayTB.Text),
                        month = Convert.ToInt32(monthTB.Text),

                       
                        hoursWorked = Convert.ToInt32(hoursTB.Text),
                        startDate = Convert.ToDateTime(dateTB.Text)
                    };
                    DataGrid1.Items.Add(coursobj);

                    db.Courses.Add(coursobj);


                  



                }
            }
        }
    }
}


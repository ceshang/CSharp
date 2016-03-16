using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mod11_Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ArrayList students = new ArrayList();
        Student newStudent;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            
            newStudent = new Student();
            newStudent.FirstName = txtFirstName.Text;
            newStudent.LastName = txtLastName.Text;
            newStudent.City = txtCity.Text;
            

            Task task1 = new Task(() => AddToCollection(newStudent));
            task1.Start();

            ClearForm();
        }

        
        private void AddToCollection(Student student)
        {
            Thread.Sleep(5000);
            students.Add(student);
            int count = students.Count;
            MessageBox.Show("Student created successfully.  Collection contains " + count.ToString() + " Student(s).");
        }

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
            txtFirstName.Focus();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student student1 = new Student();
            student1.FirstName = "Kemal";
            student1.Age = 32;
            student1.Email = "kemal@gmail.com";

            Student student2 = new Student();
            student2.FirstName = "Elif";
            student2.Age = 28;
            student2.Email = "elif@gmail.com";

            Student student3 = new Student();
            student3.FirstName = "Tito";
            student3.Age = 3;
            student3.Email = "tito@gmail.com";

            List<Student> students = new List<Student>() { student1, student2, student3 };

            foreach (var student in students)
            {
                lbxStudents.Items.Add(student.FirstName);
            }

            dgvStudents.DataSource = students;
        }
    }
}

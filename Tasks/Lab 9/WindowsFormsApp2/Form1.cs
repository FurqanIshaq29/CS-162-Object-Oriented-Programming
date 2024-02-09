using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Student> stuList = new List<Student>();
            Student s1 = new Student("zahid" , "666" , 20);
            Student s2 = new Student("ali", "955", 35);

            stuList.Add(s1);
            stuList.Add(s2);
            Furqandatagrid.DataSource = stuList;
            Furqandatagrid.Columns["Id"].Visible = false;
            

        }

        private void Furqandatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Clicked");
            Student stu = (Student)Furqandatagrid.CurrentRow.DataBoundItem;
            MessageBox.Show("Clicked");
            students.remove(stu);
            MessageBox.Show("Clicked");
            Furqandatagrid.DataSource = null;
            MessageBox.Show("Clicked");
            Furqandatagrid.DataSource = students;


        }

        private void Furqandatagrid_ReadOnlyChanged(object sender, EventArgs e)
        {

        }
    }
}

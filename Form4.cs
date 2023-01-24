using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using Krypton.Toolkit;
using MaterialSkin.Controls;
namespace Student_Menagment
{
    public partial class Form4 : MaterialForm
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_InfoDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.student_InfoDataSet.Table);

        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student_InfoDataSet);

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student_InfoDataSet);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student_InfoDataSet);

            MessageBox.Show("Data Save sucessfully");
            Close();
        }
    }
}

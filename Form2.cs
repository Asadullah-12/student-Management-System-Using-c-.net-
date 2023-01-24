using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComponentFactory.Krypton.Toolkit;

namespace Student_Menagment
{
    public partial class Form2 : KryptonForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
              
        }

        private void circular1_Click(object sender, EventArgs e)
        {

            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(g);
        }

       

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            if (TextUserName.Text == "Asad ullah" && Password.Text == "1234")
            {

                Form5 fi_form = new Form5();
                fi_form.Show();

              //  Main Mdi = new Main();
                //Mdi.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("User Name or Password are in correct","Exit");
                TextUserName.Clear();
                Password.Clear();
                TextUserName.Focus();
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

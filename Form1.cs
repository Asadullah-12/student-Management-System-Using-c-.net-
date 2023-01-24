using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Menagment
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();

            ProgressBar1.Value = 0;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            ProgressBar1.Value += 1;
            ProgressBar1.Text = ProgressBar1.Value.ToString() + "%";

            if (ProgressBar1.Value == 100)
            {
                timer1.Enabled = false;

                Main Mdi = new Main();
                Mdi.Show();

                // Form2 se_form = new Form2();
                //se_form.Show();

                this.Hide();
                
            }
        }
    }
}

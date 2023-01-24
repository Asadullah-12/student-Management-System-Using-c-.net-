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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Menagment
{
    public partial class Form5 : MaterialForm
    {

        MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;

        public Form5()
        {
            InitializeComponent();


            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);


            ProgressBar2.Value = 0;

        }

        private void Form5_Load(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar2.Value += 1;
            ProgressBar2.Text = ProgressBar2.Value.ToString() + "%";

            if (ProgressBar2.Value == 80)
            {
                timer1.Enabled = false;

            }
        }

        private void ProgressBar2_Click(object sender, EventArgs e)
        {

        }

        private void tableBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void kryptonPage7_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ThemeToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (ThemeToggle.Checked)
            {
                ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;

            }
        }

        private void materialRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new MaterialSkin.ColorScheme(Primary.Green700, Primary.Green900, Primary.Green500, Accent.Green400, TextShade.WHITE);

        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new MaterialSkin.ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue500, Accent.Blue400, TextShade.WHITE);

        }

        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new MaterialSkin.ColorScheme(Primary.Amber700, Primary.Amber900, Primary.Amber500, Accent.Amber400, TextShade.WHITE);

        }

        private void ProgressBar2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

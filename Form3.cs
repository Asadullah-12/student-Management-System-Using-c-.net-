using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MaterialSkin;
namespace Student_Menagment
{
    public partial class Form3 : KryptonForm
    {
        public string conString = "Data Source=DESKTOP-U4A6LKQ\\SQLEXPRESS;Initial Catalog=thirteen;Integrated Security=True";

       // SqlConnection con = new SqlConnection(@" Data Source=DESKTOP-U4A6LKQ\\SQLEXPRESS;Initial Catalog=thirteen;Integrated Security=True ");
        public Form3()
        {
            InitializeComponent();

        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void materialMaskedTextBox9_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conString);
            con.Close();
            con.Open();
            //  ("INSERT INTO info Values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + TextBox12.Text + "','" + TextBox13.Text + "','" + TextBox14.Text + "') ", con);
            string query = "INSERT INTO info Values('" + SdtName.Text + "','" + StdLastName.Text + "','" + int.Parse(StdPhNo.Text) + "','" + stdId.Text + "','" + MStatus.Text + "','" + gender.Text + "','" + DOB.Text + "','" + religion.Text + "','" + Stdemail.Text + "','" + nathinality.Text + "','" + FatherName.Text + "','" + int.Parse(salary.Text) + "','" + int.Parse(FatherPhNo.Text )+ "','" + int.Parse(FatherId.Text) + "') ";
            SqlCommand cmd = new SqlCommand(query,con);
            

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Save sucessfully");
            con.Close();
           this.Close();
        }

        private void materialMaskedTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox6_Click(object sender, EventArgs e)
        {

        }

        private void TextBox7_Click(object sender, EventArgs e)
        {

        }

        private void TextBox9_Click(object sender, EventArgs e)
        {

        }

        private void TextBox10_Click(object sender, EventArgs e)
        {

        }

        private void TextBox13_Click(object sender, EventArgs e)
        {

        }

        private void TextBox14_Click(object sender, EventArgs e)
        {

        }
    }
}


using System;
using System.Windows.Forms;
//using ComponentFactory.Krypton.Toolkit;
using Krypton.Toolkit;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Student_Menagment
{
    public partial class Main : MaterialForm
    {
        private int childFormNumber = 0;

        public Main()
        {
            InitializeComponent();


        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

      

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void admissionFoamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                Form4 fr_form = new Form4();
                fr_form.Show();

              //  this.Hide();

            
        }
     

        private void adminLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 se_form = new Form2();
            se_form.Show();

        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        int count = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 9)
            {

                PictureBox1.Image = imageList1.Images[count];
                count++;
            }
            else
            {

                count = 0;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void form4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 th_form = new Form3();
            th_form.Show();
        }
    }
}


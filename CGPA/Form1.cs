using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGPA
{
    public partial class Home : Form
    { 

        public Home()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        private void openSubForm(Form SubForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = SubForm;
            SubForm.TopLevel = false;
            SubForm.FormBorderStyle = FormBorderStyle.None;
            SubForm.Dock = DockStyle.Fill;
            Panelbody.Controls.Add(SubForm);
            Panelbody.Tag = SubForm;
            SubForm.BringToFront();
            SubForm.Show();

        }




        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GPAButton_Click(object sender, EventArgs e)
        {
            openSubForm(new GPA());
        }

        private void CGPAButton_Click(object sender, EventArgs e)
        {
            openSubForm(new CGPA());
        }

        private void Helpbutton_Click(object sender, EventArgs e)
        {
            openSubForm(new Help());
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            openSubForm(new About());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CGPA
{
   
    public partial class CGPA : Form
    {
        double count = 0, sum=0, mul,cgpa;
        public CGPA()
        {
            InitializeComponent();
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() ==  System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = dialog.FileName;
            }
        }

        private void Mainmenubutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadbutton_Click(object sender, EventArgs e)
        {
            try
            {
                cgpa = 0;
                string path = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + textBox1.Text + ";Extended Properties=\"Excel 8.0; HDR = Yes;\";";
                OleDbConnection connection = new OleDbConnection(path);
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from [" + "Sheet1" + "$]", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                //table = table.Rows.Cast(Of DataRow)().Where(Function(row) Not row.ItemArray.All(Function(field) TypeOf field Is System.DBNull OrElse String.Compare(TryCast(field, String).Trim(), String.Empty) = 0)).CopyToDataTable();
                dataGridView1.DataSource = table;
            }
            
            catch(Exception ex)
            {
                MessageBox.Show("Exception Occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CGPAbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                count += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                mul = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value) * Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
                sum += mul;
                mul = 0;
            }
            if(count == 0)
            {
                label13.Text= "Provide Proper Data!";
            }
            if(count>0)
            {
                label13.Text = "";
                CGPAbutton.Enabled = false;
                label16.Text = "Click on 'Clear All' to calculate again";
            }

            Totalcreditlabel.Text = Convert.ToString(count);
            if(count!=0)
            {
                cgpa = sum / count;
            }
            
            gpalabel.Text = Convert.ToString(String.Format("{0:0.00}", cgpa));
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            label13.Text = "";
            Totalcreditlabel.Text = "";
            count = 0;
            CGPAbutton.Enabled = true;
            label16.Text = "";
            dataGridView1.DataSource = null;
            //dataGridView1.DataSource = table;
            textBox1.Clear();
            gpalabel.Text = "";
            cgpa = 0;
            sum = 0; 
        }
    }
}

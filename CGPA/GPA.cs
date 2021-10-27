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
    public partial class GPA : Form
    {
        float r1, r2, r3, r4, r5, total=0, gpa=0;
        float count = 0, temp=0;

        public GPA()
        {
            InitializeComponent();
        }

        private void Mainmenubutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            comboBox8.Text = "";
            comboBox9.Text = "";
            comboBox10.Text = "";
            label13.Text = "";
            label16.Text = "";
            r1 = 0;
            r2 = 0;
            r3 = 0;
            r4 = 0;
            r5 = 0;
            total = 0;
            count = 0;
            temp = 0;
            gpa = 0;
            Totalcreditlabel.Text = "";
            CalculateButton.Enabled = true;
            gpalabel.Text = "";
        }

        private void calculate()
        {
            if(comboBox1.Text!="N/A" && comboBox1.Text != "" && comboBox3.Text != "N/A" && comboBox3.Text != "")
            {
                label13.Text = "";
                r1 = float.Parse(comboBox1.Text) * float.Parse(comboBox3.Text);
                //label13.Text = Convert.ToString(r1);
                if(comboBox1.Text == "3")
                {
                    count += 3;
                }
                else if(comboBox1.Text == "1")
                {
                    count += 1;
                }
                temp++;
            }
            if (comboBox2.Text != "N/A" && comboBox2.Text != "" && comboBox4.Text != "N/A" && comboBox4.Text != "")
            {
                label13.Text = "";
                r2 = float.Parse(comboBox2.Text) * float.Parse(comboBox4.Text);
                // label13.Text = Convert.ToString(r2);
                if (comboBox2.Text == "3")
                {
                    count += 3;
                }
                else if (comboBox2.Text == "1")
                {
                    count += 1;
                }
                temp++;
            }
            if (comboBox5.Text != "N/A" && comboBox5.Text != "" && comboBox6.Text != "N/A" && comboBox6.Text != "")
            {
                label13.Text = "";
                r3 = float.Parse(comboBox5.Text) * float.Parse(comboBox6.Text);
                // label13.Text = Convert.ToString(r3);
                if (comboBox5.Text == "3")
                {
                    count += 3;
                }
                else if (comboBox5.Text == "1")
                {
                    count += 1;
                }
                temp++;
            }
            if (comboBox8.Text != "N/A" && comboBox8.Text != "" && comboBox7.Text != "N/A" && comboBox7.Text != "")
            {
                label13.Text = "";
                r4 = float.Parse(comboBox8.Text) * float.Parse(comboBox7.Text);
                //label13.Text = Convert.ToString(r4);
                if (comboBox8.Text == "3")
                {
                    count += 3;
                }
                else if (comboBox8.Text == "1")
                {
                    count += 1;
                }
                temp++;
            }
            if (comboBox10.Text != "N/A" && comboBox10.Text != "" && comboBox9.Text != "N/A" && comboBox9.Text != "")
            {
                label13.Text = "";
                r5 = float.Parse(comboBox10.Text) * float.Parse(comboBox9.Text);
                //label13.Text = Convert.ToString(r5);
                if (comboBox10.Text == "3")
                {
                    count += 3;
                }
                else if (comboBox10.Text == "1")
                {
                    count += 1;
                }
                temp++;
            }
                      

            if(temp==0)
            {
                label13.Text ="Provide Proper Data!";
            }

            if (count>0)
            {
                CalculateButton.Enabled = false;
            }

            total = r1 + r2 + r3 + r4 + r5;
            if (count !=0)
            {
                gpa = total / count;
            }
            
            Totalcreditlabel.Text = Convert.ToString(count);
            gpalabel.Text = Convert.ToString(String.Format("{0:0.00}", gpa));
            if (count > 0)
            {
                CalculateButton.Enabled = false;
                label16.Text = "Click on 'Clear All' to calculate again";
                //MessageBox.Show("Calculation Successfull!\nClick on 'Clear All' to calculate again", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            calculate();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sem1, sem2, sem3, sem4, sem5, sem6, sem7, sem8, sem9, sem10, sem11, sem12;
		double course1, course2, course3, course4, course5, course6, course7, course8, course9;
		double cred1, cred2, cred3, cred4, cred5, cred6, cred7, cred8, cred9;
		double crede1, creda1, crede2, creda2, crede3, creda3, crede4, creda4, crede5, creda5, crede6, creda6, crede7, creda7, crede8, creda8, crede9, creda9, crede10, creda10, crede11, creda11, crede12, creda12;
		double total_credit; 
		double gp1 = 0, gp2 = 0, gp3 = 0, gp4 = 0, gp5 = 0, gp6 = 0, gp7 = 0, gp8 = 0, gp9 = 0, sgpa;
		double total_crede, cgpa = 0;

        private void dontPressTheEnterKeyWhileUsingTheAppIfYouFoundAnErrorAfterPressingEnterKeyPressTheResetAllButtonOrRestartTheApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //e is for earned in cgpa and a is for attempted in cgpa
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
		}
		private void textBox2_Click(object sender, EventArgs e)
        {
			if (textBox2.Text == "0")
			{
				textBox2.Text = "";
			}
			else
			{
				textBox2.Text = textBox2.Text;
			}
		}

        private void textBox5_Click(object sender, EventArgs e)
        {
			if (textBox5.Text == "0")
			{
				textBox5.Text = "";
			}
			else
			{
				textBox5.Text = textBox5.Text;
			}
		}

        private void textBox4_Click(object sender, EventArgs e)
        {
			if (textBox4.Text == "0")
			{
				textBox4.Text = "";
			}
			else
			{
				textBox4.Text = textBox4.Text;
			}
		}

        private void textBox8_Click(object sender, EventArgs e)
        {
			if (textBox8.Text == "0")
			{
				textBox8.Text = "";
			}
			else
			{
				textBox8.Text = textBox8.Text;
			}
		}

        private void textBox9_Click(object sender, EventArgs e)
        {
			if (textBox9.Text == "0")
			{
				textBox9.Text = "";
			}
			else
			{
				textBox9.Text = textBox9.Text;
			}
		}

        private void textBox7_Click(object sender, EventArgs e)
        {
			if (textBox7.Text == "0")
			{
				textBox7.Text = "";
			}
			else
			{
				textBox7.Text = textBox7.Text;
			}
		}

        private void textBox6_Click(object sender, EventArgs e)
        {
			if (textBox6.Text == "0")
			{
				textBox6.Text = "";
			}
			else
			{
				textBox6.Text = textBox6.Text;
			}
		}

        private void textBox16_Click(object sender, EventArgs e)
        {
			if (textBox16.Text == "0")
			{
				textBox16.Text = "";
			}
			else
			{
				textBox16.Text = textBox16.Text;
			}
		}

        private void textBox17_Click(object sender, EventArgs e)
        {
			if (textBox17.Text == "0")
			{
				textBox17.Text = "";
			}
			else
			{
				textBox17.Text = textBox17.Text;
			}
		}

        private void textBox15_Click(object sender, EventArgs e)
        {
			if (textBox15.Text == "0")
			{
				textBox15.Text = "";
			}
			else
			{
				textBox15.Text = textBox15.Text;
			}
		}

        private void textBox14_Click(object sender, EventArgs e)
        {
			if (textBox14.Text == "0")
			{
				textBox14.Text = "";
			}
			else
			{
				textBox14.Text = textBox14.Text;
			}
		}

        private void textBox12_Click(object sender, EventArgs e)
        {
			if (textBox12.Text == "0")
			{
				textBox12.Text = "";
			}
			else
			{
				textBox12.Text = textBox12.Text;
			}
		}

        private void textBox13_Click(object sender, EventArgs e)
        {
			if (textBox13.Text == "0")
			{
				textBox13.Text = "";
			}
			else
			{
				textBox13.Text = textBox13.Text;
			}
		}

        private void textBox11_Click(object sender, EventArgs e)
        {
			if (textBox11.Text == "0")
			{
				textBox11.Text = "";
			}
			else
			{
				textBox11.Text = textBox11.Text;
			}
		}

        private void textBox10_Click(object sender, EventArgs e)
        {
			if (textBox10.Text == "0")
			{
				textBox10.Text = "";
			}
			else
			{
				textBox10.Text = textBox10.Text;
			}
		}

        private void textBox19_Click(object sender, EventArgs e)
        {
			if (textBox19.Text == "0")
			{
				textBox19.Text = "";
			}
			else
			{
				textBox19.Text = textBox19.Text;
			}
		}

        private void textBox18_Click(object sender, EventArgs e)
        {
			if (textBox18.Text == "0")
			{
				textBox18.Text = "";
			}
			else
			{
				textBox18.Text = textBox18.Text;
			}
		}

        private void textBox20_Click(object sender, EventArgs e)
        {
			if (textBox20.Text == "0")
			{
				textBox20.Text = "";
			}
			else
			{
				textBox20.Text = textBox20.Text;
			}
		}

        private void textBox21_Click(object sender, EventArgs e)
        {
			if (textBox21.Text == "0")
			{
				textBox21.Text = "";
			}
			else
			{
				textBox21.Text = textBox21.Text;
			}
		}

        private void textBox22_Click(object sender, EventArgs e)
        {
			if (textBox22.Text == "0")
			{
				textBox22.Text = "";
			}
			else
			{
				textBox22.Text = textBox22.Text;
			}
		}

        private void textBox25_Click(object sender, EventArgs e)
        {
			if (textBox25.Text == "0")
			{
				textBox25.Text = "";
			}
			else
			{
				textBox25.Text = textBox25.Text;
			}
		}

        private void textBox24_Click(object sender, EventArgs e)
        {
			if (textBox24.Text == "0")
			{
				textBox24.Text = "";
			}
			else
			{
				textBox24.Text = textBox24.Text;
			}
		}

        private void textBox23_Click(object sender, EventArgs e)
        {
			if (textBox23.Text == "0")
			{
				textBox23.Text = "";
			}
			else
			{
				textBox23.Text = textBox23.Text;
			}
		}

        private void textBox28_Click(object sender, EventArgs e)
        {
			if (textBox28.Text == "0")
			{
				textBox28.Text = "";
			}
			else
			{
				textBox28.Text = textBox28.Text;
			}
		}

        private void textBox27_Click(object sender, EventArgs e)
        {
			if (textBox27.Text == "0")
			{
				textBox27.Text = "";
			}
			else
			{
				textBox27.Text = textBox27.Text;
			}
		}

        private void textBox26_Click(object sender, EventArgs e)
        {
			if (textBox26.Text == "0")
			{
				textBox26.Text = "";
			}
			else
			{
				textBox26.Text = textBox26.Text;
			}
		}

        private void textBox31_Click(object sender, EventArgs e)
        {
			if (textBox31.Text == "0")
			{
				textBox31.Text = "";
			}
			else
			{
				textBox31.Text = textBox31.Text;
			}
		}

        private void textBox30_Click(object sender, EventArgs e)
        {
			if (textBox30.Text == "0")
			{
				textBox30.Text = "";
			}
			else
			{
				textBox30.Text = textBox30.Text;
			}
		}

        private void textBox29_Click(object sender, EventArgs e)
        {
			if (textBox29.Text == "0")
			{
				textBox29.Text = "";
			}
			else
			{
				textBox29.Text = textBox29.Text;
			}
		}

        private void textBox34_Click(object sender, EventArgs e)
        {
			if (textBox34.Text == "0")
			{
				textBox34.Text = "";
			}
			else
			{
				textBox34.Text = textBox34.Text;
			}
		}

        private void textBox33_Click(object sender, EventArgs e)
        {
			if (textBox33.Text == "0")
			{
				textBox33.Text = "";
			}
			else
			{
				textBox33.Text = textBox33.Text;
			}
		}

        private void textBox32_Click(object sender, EventArgs e)
        {
			if (textBox32.Text == "0")
			{
				textBox32.Text = "";
			}
			else
			{
				textBox32.Text = textBox32.Text;
			}
		}

        private void textBox37_Click(object sender, EventArgs e)
        {
			if (textBox37.Text == "0")
			{
				textBox37.Text = "";
			}
			else
			{
				textBox37.Text = textBox37.Text;
			}
		}

        private void textBox36_Click(object sender, EventArgs e)
        {
			if (textBox36.Text == "0")
			{
				textBox36.Text = "";
			}
			else
			{
				textBox36.Text = textBox36.Text;
			}
		}

        private void textBox35_Click(object sender, EventArgs e)
        {
			if (textBox35.Text == "0")
			{
				textBox35.Text = "";
			}
			else
			{
				textBox35.Text = textBox35.Text;
			}
		}

        private void textBox40_Click(object sender, EventArgs e)
        {
			if (textBox40.Text == "0")
			{
				textBox40.Text = "";
			}
			else
			{
				textBox40.Text = textBox40.Text;
			}
		}

        private void textBox39_Click(object sender, EventArgs e)
        {
			if (textBox39.Text == "0")
			{
				textBox39.Text = "";
			}
			else
			{
				textBox39.Text = textBox39.Text;
			}
		}

        private void textBox38_Click(object sender, EventArgs e)
        {
			if (textBox38.Text == "0")
			{
				textBox38.Text = "";
			}
			else
			{
				textBox38.Text = textBox38.Text;
			}
		}

        private void textBox43_Click(object sender, EventArgs e)
        {
			if (textBox43.Text == "0")
			{
				textBox43.Text = "";
			}
			else
			{
				textBox43.Text = textBox43.Text;
			}
		}

        private void textBox42_Click(object sender, EventArgs e)
        {
			if (textBox42.Text == "0")
			{
				textBox42.Text = "";
			}
			else
			{
				textBox42.Text = textBox42.Text;
			}
		}

        private void textBox41_Click(object sender, EventArgs e)
        {
			if (textBox41.Text == "0")
			{
				textBox41.Text = "";
			}
			else
			{
				textBox41.Text = textBox41.Text;
			}
		}

        private void textBox46_Click(object sender, EventArgs e)
        {
			if (textBox46.Text == "0")
			{
				textBox46.Text = "";
			}
			else
			{
				textBox46.Text = textBox46.Text;
			}
		}

        private void textBox45_Click(object sender, EventArgs e)
        {
			if (textBox45.Text == "0")
			{
				textBox45.Text = "";
			}
			else
			{
				textBox45.Text = textBox45.Text;
			}
		}

        private void textBox44_Click(object sender, EventArgs e)
        {
			if (textBox44.Text == "0")
			{
				textBox44.Text = "";
			}
			else
			{
				textBox44.Text = textBox44.Text;
			}
		}

        private void textBox49_Click(object sender, EventArgs e)
        {
			if (textBox49.Text == "0")
			{
				textBox49.Text = "";
			}
			else
			{
				textBox49.Text = textBox49.Text;
			}
		}

        private void textBox48_Click(object sender, EventArgs e)
        {
			if (textBox48.Text == "0")
			{
				textBox48.Text = "";
			}
			else
			{
				textBox48.Text = textBox48.Text;
			}
		}

        private void textBox47_Click(object sender, EventArgs e)
        {
			if (textBox47.Text == "0")
			{
				textBox47.Text = "";
			}
			else
			{
				textBox47.Text = textBox47.Text;
			}
		}

        private void textBox52_Click(object sender, EventArgs e)
        {
			if (textBox52.Text == "0")
			{
				textBox52.Text = "";
			}
			else
			{
				textBox52.Text = textBox52.Text;
			}
		}

        private void textBox51_Click(object sender, EventArgs e)
        {
			if (textBox51.Text == "0")
			{
				textBox51.Text = "";
			}
			else
			{
				textBox51.Text = textBox51.Text;
			}
		}

        private void textBox50_Click(object sender, EventArgs e)
        {
			if (textBox50.Text == "0")
			{
				textBox50.Text = "";
			}
			else
			{
				textBox50.Text = textBox50.Text;
			}
		}

        private void textBox55_Click(object sender, EventArgs e)
        {
			if (textBox55.Text == "0")
			{
				textBox55.Text = "";
			}
			else
			{
				textBox55.Text = textBox55.Text;
			}
		}

        private void textBox54_Click(object sender, EventArgs e)
        {
			if (textBox54.Text == "0")
			{
				textBox54.Text = "";
			}
			else
			{
				textBox54.Text = textBox54.Text;
			}
		}

        private void textBox53_Click(object sender, EventArgs e)
        {
			if (textBox53.Text == "0")
			{
				textBox53.Text = "";
			}
			else
			{
				textBox53.Text = textBox53.Text;
			}
		}

        private void textBox3_Click(object sender, EventArgs e)
        {
			if (textBox3.Text == "0")
			{
				textBox3.Text = "";
			}
			else
			{
				textBox3.Text = textBox3.Text;
			}
		}
        private void cgpa_btn(object sender, EventArgs e)
        {
			if (textBox1.Text == "")
			{
				textBox1.Text = "0";
			}
			if (textBox20.Text == "")
			{
				textBox20.Text = "0";
			}
			if (textBox25.Text == "")
			{
				textBox25.Text = "0";
			}
			if (textBox28.Text == "")
			{
				textBox28.Text = "0";
			}
			if (textBox31.Text == "")
			{
				textBox31.Text = "0";
			}
			if (textBox34.Text == "")
			{
				textBox34.Text = "0";
			}
			if (textBox37.Text == "")
			{
				textBox37.Text = "0";
			}
			if (textBox40.Text == "")
			{
				textBox40.Text = "0";
			}
			if (textBox43.Text == "")
			{
				textBox43.Text = "0";
			}
			if (textBox46.Text == "")
			{
				textBox46.Text = "0";
			}
			if (textBox49.Text == "")
			{
				textBox49.Text = "0";
			}
			if (textBox52.Text == "")
			{
				textBox52.Text = "0";
			}
			if (textBox55.Text == "")
			{
				textBox55.Text = "0";
			}
			if (textBox21.Text == "")
			{
				textBox21.Text = "0";
			}
			if (textBox24.Text == "")
			{
				textBox24.Text = "0";
			}
			if (textBox27.Text == "")
			{
				textBox27.Text = "0";
			}
			if (textBox30.Text == "")
			{
				textBox30.Text = "0";
			}
			if (textBox33.Text == "")
			{
				textBox33.Text = "0";
			}
			if (textBox36.Text == "")
			{
				textBox36.Text = "0";
			}
			if (textBox39.Text == "")
			{
				textBox39.Text = "0";
			}
			if (textBox42.Text == "")
			{
				textBox42.Text = "0";
			}
			if (textBox45.Text == "")
			{
				textBox45.Text = "0";
			}
			if (textBox48.Text == "")
			{
				textBox48.Text = "0";
			}
			if (textBox51.Text == "")
			{
				textBox51.Text = "0";
			}
			if (textBox54.Text == "")
			{
				textBox54.Text = "0";
			}
			if (textBox22.Text == "")
			{
				textBox22.Text = "0";
			}
			if (textBox23.Text == "")
			{
				textBox23.Text = "0";
			}
			if (textBox26.Text == "")
			{
				textBox26.Text = "0";
			}
			if (textBox29.Text == "")
			{
				textBox29.Text = "0";
			}
			if (textBox32.Text == "")
			{
				textBox32.Text = "0";
			}
			if (textBox35.Text == "")
			{
				textBox35.Text = "0";
			}
			if (textBox38.Text == "")
			{
				textBox38.Text = "0";
			}
			if (textBox41.Text == "")
			{
				textBox41.Text = "0";
			}
			if (textBox44.Text == "")
			{
				textBox44.Text = "0";
			}
			if (textBox47.Text == "")
			{
				textBox47.Text = "0";
			}
			if (textBox50.Text == "")
			{
				textBox50.Text = "0";
			}
			if (textBox53.Text == "")
			{
				textBox53.Text = "0";
			}
			sem1 = System.Convert.ToDouble(textBox20.Text);
			sem2 = System.Convert.ToDouble(textBox25.Text);
			sem3 = System.Convert.ToDouble(textBox28.Text);
			sem4 = System.Convert.ToDouble(textBox31.Text);
			sem5 = System.Convert.ToDouble(textBox34.Text);
			sem6 = System.Convert.ToDouble(textBox37.Text);
			sem7 = System.Convert.ToDouble(textBox40.Text);
			sem8 = System.Convert.ToDouble(textBox43.Text);
			sem9 = System.Convert.ToDouble(textBox46.Text);
			sem10 = System.Convert.ToDouble(textBox49.Text);
			sem11 = System.Convert.ToDouble(textBox52.Text);
			sem12 = System.Convert.ToDouble(textBox55.Text);
			creda1 = System.Convert.ToDouble(textBox21.Text);
			creda2 = System.Convert.ToDouble(textBox24.Text);
			creda3 = System.Convert.ToDouble(textBox27.Text);
			creda4 = System.Convert.ToDouble(textBox30.Text);
			creda5 = System.Convert.ToDouble(textBox33.Text);
			creda6 = System.Convert.ToDouble(textBox36.Text);
			creda7 = System.Convert.ToDouble(textBox39.Text);
			creda8 = System.Convert.ToDouble(textBox42.Text);
			creda9 = System.Convert.ToDouble(textBox45.Text);
			creda10 = System.Convert.ToDouble(textBox48.Text);
			creda11 = System.Convert.ToDouble(textBox51.Text);
			creda12 = System.Convert.ToDouble(textBox54.Text);
			crede1 = System.Convert.ToDouble(textBox22.Text);
			crede2 = System.Convert.ToDouble(textBox23.Text);
			crede3 = System.Convert.ToDouble(textBox26.Text);
			crede4 = System.Convert.ToDouble(textBox29.Text);
			crede5 = System.Convert.ToDouble(textBox32.Text);
			crede6 = System.Convert.ToDouble(textBox35.Text);
			crede7 = System.Convert.ToDouble(textBox38.Text);
			crede8 = System.Convert.ToDouble(textBox41.Text);
			crede9 = System.Convert.ToDouble(textBox44.Text);
			crede10 = System.Convert.ToDouble(textBox47.Text);
			crede11 = System.Convert.ToDouble(textBox50.Text);
			crede12 = System.Convert.ToDouble(textBox53.Text);
			if (creda2 == 0 && creda3 == 0 && creda4 == 0 && creda5 == 0 && creda6 == 0 && creda7 == 0 && creda8 == 0 && creda9 == 0 && creda10 == 0 && creda11 == 0 && creda12 == 0)
			{
				cgpa = (sem1 * creda1) / creda1;
			}
			else
			{
				total_crede = crede1 + crede2 + crede3 + crede4 + crede5 + crede6 + crede7 + crede8 + crede9 + crede10 + crede11 + crede12;
				cgpa = (sem1 * creda1) + (sem2 * creda2) + (sem3 * creda3) + (sem4 * creda4) + (sem5 * creda5) + (sem6 * creda6) + (sem7 * creda7) + (sem8 * creda8) + (sem9 * creda9) + (sem10 * creda10) + (sem11 * creda11) + (sem12 * creda12);
				cgpa = cgpa / total_crede;
			}
			label27.Text = "Your CGPA: ";
			if (cgpa > 0)
			{
				textBox1.Text = System.Convert.ToString(cgpa);
			}
			else
			{
				textBox1.Text = ":)";
			}
		}
        private void reset_gpa(object sender, EventArgs e)
        {
			total_credit = 0;
			cred1 = 0; cred2 = 0; cred3 = 0; cred4 = 0; cred5 = 0; cred6 = 0; cred7 = 0;
			gp1 = 0; gp2 = 0; gp3 = 0; gp4 = 0; gp5 = 0; gp6 = 0; gp7 = 0;
			course1 = 0;  course2 = 0; course3 = 0; course4 = 0; course5 = 0; course6 = 0; course7 = 0;
			sgpa = 0;
			textBox1.Text = "0"; textBox2.Text = "0"; textBox3.Text = "0"; textBox4.Text = "0"; textBox5.Text = "0";
			textBox6.Text = "0"; textBox7.Text = "0"; textBox8.Text = "0"; textBox9.Text = "0"; textBox17.Text = "0";
			textBox16.Text = "0"; textBox12.Text = "0"; textBox13.Text = "0"; textBox14.Text = "0"; textBox15.Text = "0";
			textBox10.Text = "0"; textBox11.Text = "0"; textBox18.Text = "0"; textBox19.Text = "0";
			textBox20.Text = "0"; textBox21.Text = "0"; textBox22.Text = "0"; textBox23.Text = "0"; textBox24.Text = "0";
			textBox25.Text = "0"; textBox26.Text = "0"; textBox27.Text = "0"; textBox28.Text = "0"; textBox29.Text = "0";
			textBox30.Text = "0"; textBox31.Text = "0"; textBox32.Text = "0"; textBox33.Text = "0"; textBox34.Text = "0";
			textBox35.Text = "0"; textBox36.Text = "0"; textBox37.Text = "0"; textBox38.Text = "0"; textBox39.Text = "0";
			textBox40.Text = "0"; textBox41.Text = "0"; textBox42.Text = "0"; textBox43.Text = "0"; textBox44.Text = "0";
			textBox45.Text = "0"; textBox46.Text = "0"; textBox47.Text = "0"; textBox48.Text = "0"; textBox49.Text = "0";
			textBox50.Text = "0"; textBox51.Text = "0"; textBox52.Text = "0"; textBox53.Text = "0"; textBox54.Text = "0";
			textBox55.Text = "0";// textBox46.Text = "0"; textBox47.Text = "0"; textBox48.Text = "0"; textBox49.Text = "0";
			cgpa = 0;
			sem1 = 0; sem2 = 0; sem3 = 0; sem4 = 0; sem5 = 0; sem6 = 0;  sem7 = 0; sem8 = 0; sem9 = 0; sem10 = 0; sem11 = 0; sem12 = 0;
			crede1 = 0; creda1 = 0; crede2 = 0; creda2 = 0; crede3 = 0; creda3 = 0; crede4 = 0; creda4 = 0; crede5 = 0; creda5 = 0; crede6 = 0; creda6 = 0; crede7 = 0; creda7 = 0; crede8 = 0; creda8 = 0; crede9 = 0; creda9 = 0; crede10 = 0; creda10 = 0; crede11 = 0; creda11 = 0; crede12 = 0; creda12 = 0;
			total_crede = 0;
			label27.Text = "Your ";
		}
        private void Sgpa_button(object sender, EventArgs e)
        {
			if (textBox1.Text == "")
			{
				textBox1.Text = "0";
			}
			if (textBox3.Text == "")
			{
				textBox3.Text = "0";
			}
			if (textBox5.Text == "")
			{
				textBox5.Text = "0";
			}
			if (textBox7.Text == "")
			{
				textBox7.Text = "0";
			}
			if (textBox8.Text == "")
			{
				textBox8.Text = "0";
			}
			if (textBox11.Text == "")
			{
				textBox11.Text = "0";
			}
			if (textBox12.Text == "")
			{
				textBox12.Text = "0";
			}
			if (textBox15.Text == "")
			{
				textBox15.Text = "0";
			}
			if (textBox16.Text == "")
			{
				textBox16.Text = "0";
			}
			if (textBox19.Text == "")
			{
				textBox19.Text = "0";
			}
			if (textBox2.Text == "")
			{
				textBox2.Text = "0";
			}
			if (textBox4.Text == "")
			{
				textBox4.Text = "0";
			}
			if (textBox6.Text == "")
			{
				textBox6.Text = "0";
			}
			if (textBox9.Text == "")
			{
				textBox9.Text = "0";
			}
			if (textBox10.Text == "")
			{
				textBox10.Text = "0";
			}
			if (textBox14.Text == "")
			{
				textBox14.Text = "0";
			}
			if (textBox17.Text == "")
			{
				textBox17.Text = "0";
			}
			if (textBox13.Text == "")
			{
				textBox13.Text = "0";
			}
			if (textBox18.Text == "")
			{
				textBox18.Text = "0";
			}

			if (textBox3.Text == "A" || textBox3.Text == "a" || textBox3.Text == "A+" || textBox3.Text == "a+" || textBox3.Text == "+A" || textBox3.Text == "+a")
			{
				textBox3.Text = "4";
			}
			if (textBox3.Text == "A-" || textBox3.Text == "a-" || textBox3.Text == "-A" || textBox3.Text == "-a")
			{
				textBox3.Text = "3.67";
			}
			if (textBox3.Text == "B+" || textBox3.Text == "b+" || textBox3.Text == "+B" || textBox3.Text == "+b")
			{
				textBox3.Text = "3.33";
			}
			if (textBox3.Text == "B" || textBox3.Text == "b")
			{
				textBox3.Text = "3";
			}
			if (textBox3.Text == "B-" || textBox3.Text == "b-" || textBox3.Text == "-B" || textBox3.Text == "-b")
			{
				textBox3.Text = "2.67";
			}
			if (textBox3.Text == "C+" || textBox3.Text == "c+" || textBox3.Text == "+C" || textBox3.Text == "+c")
			{
				textBox3.Text = "2.33";
			}
			if (textBox3.Text == "C" || textBox3.Text == "c")
			{
				textBox3.Text = "2";
			}
			if (textBox3.Text == "C-" || textBox3.Text == "c-" || textBox3.Text == "-C" || textBox3.Text == "-c")
			{
				textBox3.Text = "1.67";
			}
			if (textBox3.Text == "D+" || textBox3.Text == "d+" || textBox3.Text == "+D" || textBox3.Text == "+d")
			{
				textBox3.Text = "1.33";
			}
			if (textBox3.Text == "D-" || textBox3.Text == "d-" || textBox3.Text == "D" || textBox3.Text == "d")
			{
				textBox3.Text = "1";
			}
			if (textBox3.Text == "F" || textBox3.Text == "f")
			{
				textBox3.Text = "0";
			}

			if (textBox5.Text == "A" || textBox5.Text == "a" || textBox5.Text == "A+" || textBox5.Text == "a+" || textBox5.Text == "+A" || textBox5.Text == "+a")
			{
				textBox5.Text = "4";
			}
			if (textBox5.Text == "A-" || textBox5.Text == "a-" || textBox5.Text == "-A" || textBox5.Text == "-a")
			{
				textBox5.Text = "3.67";
			}
			if (textBox5.Text == "B+" || textBox5.Text == "b+" || textBox5.Text == "+B" || textBox5.Text == "+b")
			{
				textBox5.Text = "3.33";
			}
			if (textBox5.Text == "B" || textBox5.Text == "b")
			{
				textBox5.Text = "3";
			}
			if (textBox5.Text == "B-" || textBox5.Text == "b-" || textBox5.Text == "-B" || textBox5.Text == "-b")
			{
				textBox5.Text = "2.67";
			}
			if (textBox5.Text == "C+" || textBox5.Text == "c+" || textBox5.Text == "+C" || textBox5.Text == "+c")
			{
				textBox5.Text = "2.33";
			}
			if (textBox5.Text == "C" || textBox5.Text == "c")
			{
				textBox5.Text = "2";
			}
			if (textBox5.Text == "C-" || textBox5.Text == "c-" || textBox5.Text == "-C" || textBox5.Text == "-c")
			{
				textBox5.Text = "1.67";
			}
			if (textBox5.Text == "D+" || textBox5.Text == "d+" || textBox5.Text == "+D" || textBox5.Text == "+d")
			{
				textBox5.Text = "1.33";
			}
			if (textBox5.Text == "D-" || textBox5.Text == "d-" || textBox5.Text == "D" || textBox5.Text == "d")
			{
				textBox5.Text = "1";
			}
			if (textBox5.Text == "F" || textBox5.Text == "f")
			{
				textBox5.Text = "0";
			}

			if (textBox7.Text == "A" || textBox7.Text == "a" || textBox7.Text == "A+" || textBox7.Text == "a+" || textBox7.Text == "+A" || textBox7.Text == "+a")
			{
				textBox7.Text = "4";
			}
			if (textBox7.Text == "A-" || textBox7.Text == "a-" || textBox7.Text == "-A" || textBox7.Text == "-a")
			{
				textBox7.Text = "3.67";
			}
			if (textBox7.Text == "B+" || textBox7.Text == "b+" || textBox7.Text == "+B" || textBox7.Text == "+b")
			{
				textBox7.Text = "3.33";
			}
			if (textBox7.Text == "B" || textBox7.Text == "b")
			{
				textBox7.Text = "3";
			}
			if (textBox7.Text == "B-" || textBox7.Text == "b-" || textBox7.Text == "-B" || textBox7.Text == "-b")
			{
				textBox7.Text = "2.67";
			}
			if (textBox7.Text == "C+" || textBox7.Text == "c+" || textBox7.Text == "+C" || textBox7.Text == "+c")
			{
				textBox7.Text = "2.33";
			}
			if (textBox7.Text == "C" || textBox7.Text == "c")
			{
				textBox7.Text = "2";
			}
			if (textBox7.Text == "C-" || textBox7.Text == "c-" || textBox7.Text == "-C" || textBox7.Text == "-c")
			{
				textBox7.Text = "1.67";
			}
			if (textBox7.Text == "D+" || textBox7.Text == "d+" || textBox7.Text == "+D" || textBox7.Text == "+d")
			{
				textBox7.Text = "1.33";
			}
			if (textBox7.Text == "D-" || textBox7.Text == "d-" || textBox7.Text == "D" || textBox7.Text == "d")
			{
				textBox7.Text = "1";
			}
			if (textBox7.Text == "F" || textBox7.Text == "f")
			{
				textBox7.Text = "0";
			}

			if (textBox8.Text == "A" || textBox8.Text == "a" || textBox8.Text == "A+" || textBox8.Text == "a+" || textBox8.Text == "+A" || textBox8.Text == "+a")
			{
				textBox8.Text = "4";
			}
			if (textBox8.Text == "A-" || textBox8.Text == "a-" || textBox8.Text == "-A" || textBox8.Text == "-a")
			{
				textBox8.Text = "3.67";
			}
			if (textBox8.Text == "B+" || textBox8.Text == "b+" || textBox8.Text == "+B" || textBox8.Text == "+b")
			{
				textBox8.Text = "3.33";
			}
			if (textBox8.Text == "B" || textBox8.Text == "b")
			{
				textBox8.Text = "3";
			}
			if (textBox8.Text == "B-" || textBox8.Text == "b-" || textBox8.Text == "-B" || textBox8.Text == "-b")
			{
				textBox8.Text = "2.67";
			}
			if (textBox8.Text == "C+" || textBox8.Text == "c+" || textBox8.Text == "+C" || textBox8.Text == "+c")
			{
				textBox8.Text = "2.33";
			}
			if (textBox8.Text == "C" || textBox8.Text == "c")
			{
				textBox8.Text = "2";
			}
			if (textBox8.Text == "C-" || textBox8.Text == "c-" || textBox8.Text == "-C" || textBox8.Text == "-c")
			{
				textBox8.Text = "1.67";
			}
			if (textBox8.Text == "D+" || textBox8.Text == "d+" || textBox8.Text == "+D" || textBox8.Text == "+d")
			{
				textBox8.Text = "1.33";
			}
			if (textBox8.Text == "D-" || textBox8.Text == "d-" || textBox8.Text == "D" || textBox8.Text == "d")
			{
				textBox8.Text = "1";
			}
			if (textBox8.Text == "F" || textBox8.Text == "f")
			{
				textBox8.Text = "0";
			}

			if (textBox16.Text == "A" || textBox16.Text == "a" || textBox16.Text == "A+" || textBox16.Text == "a+" || textBox16.Text == "+A" || textBox16.Text == "+a")
			{
				textBox16.Text = "4";
			}
			if (textBox16.Text == "A-" || textBox16.Text == "a-" || textBox16.Text == "-A" || textBox16.Text == "-a")
			{
				textBox16.Text = "3.67";
			}
			if (textBox16.Text == "B+" || textBox16.Text == "b+" || textBox16.Text == "+B" || textBox16.Text == "+b")
			{
				textBox16.Text = "3.33";
			}
			if (textBox16.Text == "B" || textBox16.Text == "b")
			{
				textBox16.Text = "3";
			}
			if (textBox16.Text == "B-" || textBox16.Text == "b-" || textBox16.Text == "-B" || textBox16.Text == "-b")
			{
				textBox16.Text = "2.67";
			}
			if (textBox16.Text == "C+" || textBox16.Text == "c+" || textBox16.Text == "+C" || textBox16.Text == "+c")
			{
				textBox16.Text = "2.33";
			}
			if (textBox16.Text == "C" || textBox16.Text == "c")
			{
				textBox16.Text = "2";
			}
			if (textBox16.Text == "C-" || textBox16.Text == "c-" || textBox16.Text == "-C" || textBox16.Text == "-c")
			{
				textBox16.Text = "1.67";
			}
			if (textBox16.Text == "D+" || textBox16.Text == "d+" || textBox16.Text == "+D" || textBox16.Text == "+d")
			{
				textBox16.Text = "1.33";
			}
			if (textBox16.Text == "D-" || textBox16.Text == "d-" || textBox16.Text == "D" || textBox16.Text == "d")
			{
				textBox16.Text = "1";
			}
			if (textBox16.Text == "F" || textBox16.Text == "f")
			{
				textBox16.Text = "0";
			}

			if (textBox15.Text == "A" || textBox15.Text == "a" || textBox15.Text == "A+" || textBox15.Text == "a+" || textBox15.Text == "+A" || textBox15.Text == "+a")
			{
				textBox15.Text = "4";
			}
			if (textBox15.Text == "A-" || textBox15.Text == "a-" || textBox15.Text == "-A" || textBox15.Text == "-a")
			{
				textBox15.Text = "3.67";
			}
			if (textBox15.Text == "B+" || textBox15.Text == "b+" || textBox15.Text == "+B" || textBox15.Text == "+b")
			{
				textBox15.Text = "3.33";
			}
			if (textBox15.Text == "B" || textBox15.Text == "b")
			{
				textBox15.Text = "3";
			}
			if (textBox15.Text == "B-" || textBox15.Text == "b-" || textBox15.Text == "-B" || textBox15.Text == "-b")
			{
				textBox15.Text = "2.67";
			}
			if (textBox15.Text == "C+" || textBox15.Text == "c+" || textBox15.Text == "+C" || textBox15.Text == "+c")
			{
				textBox15.Text = "2.33";
			}
			if (textBox15.Text == "C" || textBox15.Text == "c")
			{
				textBox15.Text = "2";
			}
			if (textBox15.Text == "C-" || textBox15.Text == "c-" || textBox15.Text == "-C" || textBox15.Text == "-c")
			{
				textBox15.Text = "1.67";
			}
			if (textBox15.Text == "D+" || textBox15.Text == "d+" || textBox15.Text == "+D" || textBox15.Text == "+d")
			{
				textBox15.Text = "1.33";
			}
			if (textBox15.Text == "D-" || textBox15.Text == "d-" || textBox15.Text == "D" || textBox15.Text == "d")
			{
				textBox15.Text = "1";
			}
			if (textBox15.Text == "F" || textBox15.Text == "f")
			{
				textBox15.Text = "0";
			}

			if (textBox11.Text == "A" || textBox11.Text == "a" || textBox11.Text == "A+" || textBox11.Text == "a+" || textBox11.Text == "+A" || textBox11.Text == "+a")
			{
				textBox11.Text = "4";
			}
			if (textBox11.Text == "A-" || textBox11.Text == "a-" || textBox11.Text == "-A" || textBox11.Text == "-a")
			{
				textBox11.Text = "3.67";
			}
			if (textBox11.Text == "B+" || textBox11.Text == "b+" || textBox11.Text == "+B" || textBox11.Text == "+b")
			{
				textBox11.Text = "3.33";
			}
			if (textBox11.Text == "B" || textBox11.Text == "b")
			{
				textBox11.Text = "3";
			}
			if (textBox11.Text == "B-" || textBox11.Text == "b-" || textBox11.Text == "-B" || textBox11.Text == "-b")
			{
				textBox11.Text = "2.67";
			}
			if (textBox11.Text == "C+" || textBox11.Text == "c+" || textBox11.Text == "+C" || textBox11.Text == "+c")
			{
				textBox11.Text = "2.33";
			}
			if (textBox11.Text == "C" || textBox11.Text == "c")
			{
				textBox11.Text = "2";
			}
			if (textBox11.Text == "C-" || textBox11.Text == "c-" || textBox11.Text == "-C" || textBox11.Text == "-c")
			{
				textBox11.Text = "1.67";
			}
			if (textBox11.Text == "D+" || textBox11.Text == "d+" || textBox11.Text == "+D" || textBox11.Text == "+d")
			{
				textBox11.Text = "1.33";
			}
			if (textBox11.Text == "D-" || textBox11.Text == "d-" || textBox11.Text == "D" || textBox11.Text == "d")
			{
				textBox11.Text = "1";
			}
			if (textBox11.Text == "F" || textBox11.Text == "f")
			{
				textBox11.Text = "0";
			}

			if (textBox12.Text == "A" || textBox12.Text == "a" || textBox12.Text == "A+" || textBox12.Text == "a+" || textBox12.Text == "+A" || textBox12.Text == "+a")
			{
				textBox12.Text = "4";
			}
			if (textBox12.Text == "A-" || textBox12.Text == "a-" || textBox12.Text == "-A" || textBox12.Text == "-a")
			{
				textBox12.Text = "3.67";
			}
			if (textBox12.Text == "B+" || textBox12.Text == "b+" || textBox12.Text == "+B" || textBox12.Text == "+b")
			{
				textBox12.Text = "3.33";
			}
			if (textBox12.Text == "B" || textBox12.Text == "b")
			{
				textBox12.Text = "3";
			}
			if (textBox12.Text == "B-" || textBox12.Text == "b-" || textBox12.Text == "-B" || textBox12.Text == "-b")
			{
				textBox12.Text = "2.67";
			}
			if (textBox12.Text == "C+" || textBox12.Text == "c+" || textBox12.Text == "+C" || textBox12.Text == "+c")
			{
				textBox12.Text = "2.33";
			}
			if (textBox12.Text == "C" || textBox12.Text == "c")
			{
				textBox12.Text = "2";
			}
			if (textBox12.Text == "C-" || textBox12.Text == "c-" || textBox12.Text == "-C" || textBox12.Text == "-c")
			{
				textBox12.Text = "1.67";
			}
			if (textBox12.Text == "D+" || textBox12.Text == "d+" || textBox12.Text == "+D" || textBox12.Text == "+d")
			{
				textBox12.Text = "1.33";
			}
			if (textBox12.Text == "D-" || textBox12.Text == "d-" || textBox12.Text == "D" || textBox12.Text == "d")
			{
				textBox12.Text = "1";
			}
			if (textBox12.Text == "F" || textBox12.Text == "f")
			{
				textBox12.Text = "0";
			}

			if (textBox19.Text == "A" || textBox19.Text == "a" || textBox19.Text == "A+" || textBox19.Text == "a+" || textBox19.Text == "+A" || textBox19.Text == "+a")
			{
				textBox19.Text = "4";
			}
			if (textBox19.Text == "A-" || textBox19.Text == "a-" || textBox19.Text == "-A" || textBox19.Text == "-a")
			{
				textBox19.Text = "3.67";
			}
			if (textBox19.Text == "B+" || textBox19.Text == "b+" || textBox19.Text == "+B" || textBox19.Text == "+b")
			{
				textBox19.Text = "3.33";
			}
			if (textBox19.Text == "B" || textBox19.Text == "b")
			{
				textBox19.Text = "3";
			}
			if (textBox19.Text == "B-" || textBox19.Text == "b-" || textBox19.Text == "-B" || textBox19.Text == "-b")
			{
				textBox19.Text = "2.67";
			}
			if (textBox19.Text == "C+" || textBox19.Text == "c+" || textBox19.Text == "+C" || textBox19.Text == "+c")
			{
				textBox19.Text = "2.33";
			}
			if (textBox19.Text == "C" || textBox19.Text == "c")
			{
				textBox19.Text = "2";
			}
			if (textBox19.Text == "C-" || textBox19.Text == "c-" || textBox19.Text == "-C" || textBox19.Text == "-c")
			{
				textBox19.Text = "1.67";
			}
			if (textBox19.Text == "D+" || textBox19.Text == "d+" || textBox19.Text == "+D" || textBox19.Text == "+d")
			{
				textBox19.Text = "1.33";
			}
			if (textBox19.Text == "D-" || textBox19.Text == "d-" || textBox19.Text == "D" || textBox19.Text == "d")
			{
				textBox19.Text = "1";
			}
			if (textBox19.Text == "F" || textBox19.Text == "f")
			{
				textBox19.Text = "0";
			}
			course1 = System.Convert.ToDouble(textBox3.Text);
			course2 = System.Convert.ToDouble(textBox5.Text);
			course3 = System.Convert.ToDouble(textBox8.Text);
			course4 = System.Convert.ToDouble(textBox7.Text);
			course5 = System.Convert.ToDouble(textBox16.Text);
			course6 = System.Convert.ToDouble(textBox15.Text);
			course7 = System.Convert.ToDouble(textBox12.Text);
			course8 = System.Convert.ToDouble(textBox11.Text);
			course9 = System.Convert.ToDouble(textBox19.Text);
			cred1 = System.Convert.ToDouble(textBox2.Text);
			cred2 = System.Convert.ToDouble(textBox4.Text);
			cred3 = System.Convert.ToDouble(textBox9.Text);
			cred4 = System.Convert.ToDouble(textBox6.Text);
			cred5 = System.Convert.ToDouble(textBox17.Text);
			cred6 = System.Convert.ToDouble(textBox14.Text);
			cred7 = System.Convert.ToDouble(textBox13.Text);
			cred8 = System.Convert.ToDouble(textBox10.Text);
			cred9 = System.Convert.ToDouble(textBox18.Text);
			total_credit = cred1 + cred2 + cred3 + cred4 + cred5 + cred6 + cred7 + cred8 + cred9;
			gp1 = (course1 * cred1); gp2 = (course2 * cred2); gp3 = (course3 * cred3); gp4 = (course4 * cred4); gp5 = (course5 * cred5); gp6 = (course6 * cred6); gp7 = (course7 * cred7); gp8 = (course8 * cred8); gp9 = (course9 * cred9);
			sgpa = gp1 + gp2 + gp3 + gp4 + gp5 + gp6 + gp7 + gp8 + gp9;
			sgpa = sgpa / total_credit;
			label27.Text = "Your SGPA: ";
			if (sgpa > 0)
			{
				textBox1.Text = System.Convert.ToString(sgpa);
			}
			else
			{
				textBox1.Text = ":)";
			}
		}
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked == true)
			{
				BackColor = Color.Black;
				ForeColor = Color.Yellow;
				button1.BackColor = Color.Gray;
				button2.BackColor = Color.Gray;
				button3.BackColor = Color.Gray;
			}
			else
			{
				BackColor = Color.Beige;
				ForeColor = Color.Black;
				button1.BackColor = Color.Silver;
				button2.BackColor = Color.Silver;
				button3.BackColor = Color.Silver;
			}
		}
	}
}

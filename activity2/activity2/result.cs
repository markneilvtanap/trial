using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activity2
{
    public partial class result : Form
    {
        public List<Skillset> skillResult;
        public List<certificationSet> certifcationResult;
        public profileSet profileresult;
        public result()
        {
            InitializeComponent();
        }

        public void displayPhoto(Image image)
        {
            pictureBox1.Image = image;
        }

        private void result_Load(object sender, EventArgs e)
        {
            label7.Text = profileresult.id_Number;
            label6.Text = profileresult.name;
            label9.Text = profileresult.sex;
            label11.Text = profileresult.birthDate;
            label13.Text = profileresult.civilStatus;

            for (int i = 0; i < skillResult.Count; i++)
            {
                dataGridView1.Rows.Add(skillResult[i].skills, skillResult[i].level);
            }

            for (int x = 0; x < certifcationResult.Count; x++)
            {
                dataGridView2.Rows.Add(certifcationResult[x].certification, certifcationResult[x].certifBody, certifcationResult[x].validFrom, certifcationResult[x].validTo);
            }

            //label1.Text = skillResult[0].skills;
            //label2.Text = skillResult[0].level;
            //label5.Text = skillResult[1].skills;
            //label4.Text = skillResult[1].level;

            //label9.Text = certifcationResult[0].certification;
            //label8.Text = certifcationResult[0].certifBody;
            //label7.Text = certifcationResult[0].validFrom;
            //label6.Text = certifcationResult[0].validTo;

            //label13.Text = certifcationResult[1].certification;
            //label12.Text = certifcationResult[1].certifBody;
            //label11.Text = certifcationResult[1].validFrom;
            //label10.Text = certifcationResult[1].validTo;

            //label14.Text = profileresult[0].id_Number;
            //label15.Text = profileresult[0].name;
            //label16.Text = profileresult[0].sex;
            //label17.Text = profileresult[0].birthDate;
            //label18.Text = profileresult[0].civilStatus;




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

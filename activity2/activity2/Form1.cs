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
    public partial class Form1 : Form
    {
        profile profForm = new profile();
        skills skillsForm = new skills();
        certification certiForm = new certification();
        result resultForm;
        
        public Form1()
        {
            InitializeComponent();
        }

        public void display(object Form)
        {
            Form forms = Form as Form;

            forms.TopLevel = false;
            this.panel2.Controls.Add(forms);
            forms.Dock = DockStyle.Fill;
            forms.BringToFront();
            forms.Show();

         }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            display(profForm);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            display(skillsForm);
            
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            display(certiForm);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            resultForm = new result();
            resultForm.profileresult = profForm.Profile;
            resultForm.certifcationResult = certiForm.Certification;
            resultForm.skillResult = skillsForm.Skill;
            resultForm.displayPhoto(profForm.selectedImage);
            resultForm.Show();
            
          //  display(resultForm);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace activity2
{
    public partial class profile : Form

    {

    
        profileSet list;
        int index;
        bool check = false;
        public Image selectedImage;

        ////public list to use in result
        public profileSet Profile
        {
            get { return list; }
            set { list = value; }

        }

        public profile()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void profile_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
          
            if (check == true)
            {
                list = new profileSet();

                string inputIdnum = textBox1.Text;
                string inputName = textBox2.Text;
                string inputSex;
                string inputBirthDate = dateTimePicker1.Text;
                string inputCivilStatus = comboBox1.GetItemText(comboBox1.Text);


                if (radioButton1.Checked == true)
                {
                    inputSex = "Male";
                }
                else
                {
                    inputSex = "Female";
                }

                // putting to list
                list.id_Number = inputIdnum;
                list.name = inputName;
                list.sex = inputSex;
                list.birthDate = inputBirthDate;
                list.civilStatus = inputCivilStatus;

                MessageBox.Show("Uploaded Successfully :) ");

            }
            else
            {
                MessageBox.Show("Error on filling up or Uploading a photo :(");
            }



        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            //picture

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                selectedImage = Image.FromFile(selectedFileName);

                pictureBox1.Image = selectedImage;

                check = true;
            }
        }
    }
}

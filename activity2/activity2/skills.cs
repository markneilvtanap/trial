using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace activity2
{
    public partial class skills : Form
    {
        

        List<Skillset> skillList = new List<Skillset>();
        Skillset list;
        int index;

        //public list to use in result
        public List <Skillset> Skill
        {
            get { return skillList; }
            set { skillList = value; }

        }
        
 
        public skills()
        {
            InitializeComponent();
          
        }
       


        

        
        private void skills_Load(object sender, EventArgs e)
        {
           
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
           
            list = new Skillset();

            string inputSkill = textBox1.Text;
            string selectedLevel = comboBox1.GetItemText(comboBox1.SelectedItem.ToString());
          

           //putting in datagridview
    dataGridView1.Rows.Add(inputSkill, selectedLevel);

           // putting to list
          list.skills = inputSkill;
           list.level = selectedLevel;

            // adding to list of skillset
            skillList.Add(list);   
           
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

             index = dataGridView1.CurrentRow.Index;

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(index);
            skillList.RemoveAt(index);
            
        }
    }
}

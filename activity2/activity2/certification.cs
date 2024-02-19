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
    public partial class certification : Form
    {

        List<certificationSet> CertifList = new List<certificationSet>();
        certificationSet list;
        int index;

        //public list to use in result
        public List<certificationSet> Certification
        {
            get { return CertifList; }
            set { CertifList = value; }

        }
        public certification()
        {
            InitializeComponent();
        }

        private void certification_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            list = new certificationSet();

            string inputCertif = textBox1.Text;
            string inputcertifbody = textBox2.Text;
            string inputValidFrom = dateTimePicker1.Text;
            string inputValidTo = dateTimePicker2.Text;

            //putting in datagridview
            dataGridView1.Rows.Add(inputCertif, inputcertifbody, inputValidFrom, inputValidTo);

            // putting to list
            list.certification = inputCertif;
            list.certifBody = inputcertifbody;
            list.validFrom = inputValidFrom;
            list.validTo = inputValidTo;

            // adding to list of skillset
            CertifList.Add(list);
        }

        private void certification_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = dataGridView1.CurrentRow.Index;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(index);
            CertifList.RemoveAt(index);
        }
    }
}

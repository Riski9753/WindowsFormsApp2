using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            form2 frm = new form2();
            frm.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet11.Nilai' table. You can move, or remove it, as needed.
            this.nilaiTableAdapter.Fill(this.prodiTIDataSet11.Nilai);
            // TODO: This line of code loads data into the 'prodiTIDataSet10.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter1.Fill(this.prodiTIDataSet10.Mahasiswa);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet10.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter1.Fill(this.prodiTIDataSet10.Mahasiswa);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

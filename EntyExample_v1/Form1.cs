using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntyExample_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "filmsDataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.filmsDataSet.Table);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table user = new Table();
            user.Name = textBox1.Text;
            user.Genre = textBox2.Text;
            user.Release = textBox3.Text;

            FilmsEntities _db = new FilmsEntities();
            _db.Table.Add(user);
            _db.SaveChanges();

            /// dataGridView1.Refresh();
            List<Table> usersList = new List<Table>();
            usersList = _db.Table.ToList();
            dataGridView1.DataSource = usersList;
        }
    }
}

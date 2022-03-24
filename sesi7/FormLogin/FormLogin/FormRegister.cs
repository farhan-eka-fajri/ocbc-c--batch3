using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class FormRegister : Form
    {
        Config db = new Config();
        public FormRegister()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Execute("insert into user_info (names, username, password) values ('" + textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')");
            MessageBox.Show("Data Berhasil disimpan");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormLogin2 loginn = new FormLogin2();
            loginn.Show();
        }
    }
}

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

    public partial class FormLogin2 : Form
    {
        Config db = new Config();
        public FormLogin2()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("select * from user_info where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'");
        
            if(db.Count() == 1)
            {
                MessageBox.Show("Success You will login as " + db.Results(0, "names"));
            }
            else
            {
                MessageBox.Show("Wrong username and password combination");
            }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRegister register = new FormRegister();
            register.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

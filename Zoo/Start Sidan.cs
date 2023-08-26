using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void buttonVisitor_Click(object sender, EventArgs e)
        {
            VisitorInfo info = new VisitorInfo();
            Start start = new Start();
            info.Show();
            start.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Start start = new Start();
            login.Show();
            start.Hide();
        }
    }
}

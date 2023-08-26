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
    public partial class VisitorInfo : Form
    {
        public VisitorInfo()
        {
            InitializeComponent();
        }

        private void labelAnimalInfo_Click(object sender, EventArgs e)
        {
            VisitorInfo info = new VisitorInfo();
            AnimalInfo animalInfo = new AnimalInfo();
            animalInfo.Show();
            info.Hide();
        }
    }
}

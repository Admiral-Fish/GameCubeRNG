using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColoSearcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            natureType.SelectedIndex = 0;
            abilityType.SelectedIndex = 0;
            genderType.SelectedIndex = 0;
            hiddenpower.SelectedIndex = 0;
        }

        private void search_Click(object sender, EventArgs e)
        {

        }
    }
}

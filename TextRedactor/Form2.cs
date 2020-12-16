using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextRedactor
{
    public partial class Form2 : Form
    {
        MainWindow origin;
        FileFacade file;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(FileFacade _file, MainWindow _origin) : this()
        {
            origin = _origin;
            file = _file;

            //this.button1.Click
            //This button turned off by default, due of file and form absence
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;

        }
    }
}

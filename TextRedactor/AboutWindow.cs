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
    partial class AboutWindow : Form
    {
        AboutWindow()
        {
            InitializeComponent();
        }
        public AboutWindow(FileHandler handler) : this()
        {
            if(handler.date == null)
            {
                DateLabel.Text = "Дата создания неизвестна";
            }

            DateLabel.Text = String.Format("Creation date:{0}",handler.date.ToString());
        }

        private void AboutWindow_Load(object sender, EventArgs e)
        {
            
        }
    }
}

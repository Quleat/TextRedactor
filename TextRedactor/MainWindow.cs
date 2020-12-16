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
    public partial class MainWindow : Form
    {
        FileFacade file;
        public MainWindow()
        {
            InitializeComponent();
            file = new FileFacade();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            richTextBox1.Text = file.Load(openFileDialog1.FileName);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            file.Save(saveFileDialog1.FileName, richTextBox1.Text);
        }
        private void Debug()
        {
            Font font = richTextBox1.Font;
            MessageBox.Show(font.ToString());
        }
        private void optionsButton_Click(object sender, EventArgs e) 
        {
            
        }
        public void ChangeFont(Font newFont)
        {
            richTextBox1.Font = newFont;
        }
    }
}

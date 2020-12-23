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
        FileHandler handler;

        public MainWindow()
        {
            InitializeComponent();
            handler = new FileHandler(new MainFile());
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            richTextBox1.Text = handler.Load(openFileDialog1.FileName);
            richTextBox1.Font = handler.Font;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            handler.Save(saveFileDialog1.FileName, richTextBox1.Text) ;
        }

        private void Debug()
        {
            Font font = richTextBox1.Font;
            IntPtr intPtr = font.ToHfont();
            MessageBox.Show(intPtr.ToString());
        }

        private void optionsButton_Click(object sender, EventArgs e) 
        {
            OptionsWindow window = new OptionsWindow(handler, this);
            window.Show();
        }

        public void ChangeFont(Font newFont)
        {
            richTextBox1.Font = newFont;
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow(handler);
            aboutWindow.Show();
        }
    }
}

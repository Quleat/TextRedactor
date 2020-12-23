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
    partial class OptionsWindow : Form
    {
        MainWindow origin;
        FileHandler file;

        private OptionsWindow()
        {
            InitializeComponent();
        }
        public OptionsWindow(FileHandler _file, MainWindow _origin) : this()
        {
            origin = _origin;
            file = _file;

            UpdateBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            origin.ChangeFont(fontDialog1.Font);
            file.Font = fontDialog1.Font;
        }

        private void addDeclarationBox_CheckedChanged(object sender, EventArgs e)
        {
            file.SaveDeclaration = addDeclarationBox.Checked;
            UpdateBoxes();
        }

        private void saveFontBox_CheckedChanged(object sender, EventArgs e)
        {
            file.SaveFont = saveFontBox.Checked;
        }

        private void saveDateBox_CheckedChanged(object sender, EventArgs e)
        {
            file.SaveDate = saveDateBox.Checked;
        }
        private void UpdateBoxes()
        {
            saveFontBox.Checked = file.SaveFont;
            saveFontBox.Enabled = file.SaveDeclaration;

            saveDateBox.Checked = file.SaveDate;
            saveDateBox.Enabled = file.SaveDeclaration;

            addDeclarationBox.Checked = file.SaveDeclaration;
        }
    }
}

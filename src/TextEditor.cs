using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0001_Forms
{
    public partial class TextEditor : Form
    {
        private string fileName;

        public TextEditor()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName, Encoding.Default))
                {
                    fileName = openFileDialog.FileName;
                    richTextBox.Text = reader.ReadToEnd();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           saveFile();
        }

        private void saveFile()
        {
            if (String.IsNullOrWhiteSpace(fileName))
            {
                saveAsFile();
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.Default))
                {
                    writer.Write(richTextBox.Text);
                }
            }

        }

        private void saveAsFile()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.Default))
                {
                    writer.Write(richTextBox.Text);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            askAfterClosing();
        }

        private void askAfterClosing()
        {
            AskSaveFileDialog askDialog = new AskSaveFileDialog();

            if (askDialog.ShowDialog() == DialogResult.Yes)
            {
                saveFile();
            }
            else if (askDialog.ShowDialog() == DialogResult.No)
            {
                Close();
            }
            else if (askDialog.ShowDialog() == DialogResult.Cancel)
            {
                askDialog.Close();
            }
        }


        private void TextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            askAfterClosing();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAsFile();
        }
    }
}

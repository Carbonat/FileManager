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
<<<<<<< HEAD
        private bool isTextChanged = false;
=======
        private bool isTextChanged = false; //no changes or they are save
>>>>>>> Correct closing TE with question


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
                    isTextChanged = false;
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
                using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.Default))
                {
                    writer.Write(richTextBox.Text);
                    isTextChanged = false;
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
                    isTextChanged = false;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool notClose = actionsBeforeExit(); 
            e.Cancel = !notClose;
        }

        private bool actionsBeforeExit()
        {
<<<<<<< HEAD
            if (!String.IsNullOrWhiteSpace(fileName) || isTextChanged)
=======
            if (isTextChanged)
>>>>>>> Correct closing TE with question
            {
                AskSaveFileDialog askDialog = new AskSaveFileDialog();
                DialogResult dialogResult = askDialog.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    saveFile();
                }
                else if (dialogResult == DialogResult.No)
                {
                    askDialog.Close();
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    askDialog.Close();
                    return false;
                }
            }
            return true;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAsFile();
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            isTextChanged = true;
        }
    }
}

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
        private bool isTextChanged = false; //no changes or they are save
        private string copiedText;


        public TextEditor()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool openFile = true;
            if (isTextChanged)
            {
                openFile = actionsBeforeExit();//false if user click on Cancel button in AskSaveFileDialog
            }

            if (openFile && openFileDialog.ShowDialog() == DialogResult.OK)
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
            if (isTextChanged)
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

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox.SelectedText))
            {
                copiedText = richTextBox.SelectedText;
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(copiedText))
            {
                int selectionStart = richTextBox.SelectionStart;
                int length = copiedText.Length;
                richTextBox.Text = richTextBox.Text.Insert(selectionStart, copiedText);
                richTextBox.SelectionStart = selectionStart + length;
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem_Click(sender, e);
            if (!String.IsNullOrEmpty(copiedText))
            {
                richTextBox.SelectedText = String.Empty;
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
           string text = richTextBox.Text;
           if (String.IsNullOrEmpty(text))
           {
               MessageBox.Show("Текстовий файл пустий", "Пошук неможливий");
           }
           else
           {
               FindInTextEditor findDialog = new FindInTextEditor(text);
               findDialog.ShowDialog();
           }
        }
    }
}

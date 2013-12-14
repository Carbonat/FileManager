using System;
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
    public partial class FindInTextEditor : Form
    {
        private string text;
        private int numberOfLines;


        public FindInTextEditor()
        {
            InitializeComponent();
        }

        public FindInTextEditor(string _text)
        {
            InitializeComponent();
            text = _text;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string word = textBox.Text;
            if (String.IsNullOrEmpty(word))
            {
                MessageBox.Show("Введіть слово чи послідовність слів, які треба знайти.");
            }
            else
            {
                Dictionary<int, string> results = new Dictionary<int, string>();
                FindWord(word, ref results);
                GenerateList(results);
            }
        }

        private void FindWord(string word, ref Dictionary<int, string> results)
        {
            string[] allLines = text.Split('\n');
            numberOfLines = allLines.Length;
            for (int i = 0; i < numberOfLines; ++i)
            {
                if (allLines[i].Contains(word))
                {
                    results.Add(i, allLines[i]);
                }
            }
        }

        private void GenerateList(Dictionary<int, string> results)
        {
            if (results.Count == 0)
            {
                MessageBox.Show("Пошук не дав результатів", "Результати пошуку");
            }
            
            int numberOfItems = listView.Items.Count;
            for (int i = numberOfItems - 1; i >= 0; --i)
            {
                listView.Items[i].Remove();
            }

            for (int i = 0; i < numberOfLines; ++i)
            {
                if (results.ContainsKey(i))
                {
                    ListViewItem listViewItem = new ListViewItem();
                    ListViewItem.ListViewSubItem listViewSubItem = new ListViewItem.ListViewSubItem();
                    listViewItem.Text = results[i];
                    listViewSubItem.Text = (i + 1).ToString();
                    listViewItem.SubItems.Add(listViewSubItem);
                    listView.Items.Add(listViewItem);
                }
            }
        }



    }
}

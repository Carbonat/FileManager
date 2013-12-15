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
    public partial class WordsFrequency : Form
    {
        private char[] separatorSymbols = { ' ', '\t', '\n' };
        private char[] specialSymbols = { '«', '»', '"', '*', '/', '+', '-', ' ', ',', '.', ':', '(', ')', ';', '?', '!', '[', ']', '{', '}' };

        private string text;
        private Dictionary<string, long> frequencies = new Dictionary<string, long> ();


        public WordsFrequency()
        {
            InitializeComponent();
        }

        public WordsFrequency(string _text)
        {
            InitializeComponent();
            text = _text;
        }

        private void WordsFrequency_Load(object sender, EventArgs e)
        {
            CountWords();
            GenerateList();
        }

        private void CountWords()
        {
            string[] allWords = text.Split(separatorSymbols);
            string word = null;
            foreach (string someWord in allWords)
            {
                word = someWord.Trim(specialSymbols);
                if (!String.IsNullOrWhiteSpace(word))
                {
                    if (frequencies.ContainsKey(word))
                    {
                        frequencies[word] += 1;
                    }
                    else
                    {
                        frequencies.Add(word, 1);
                    }
                }
            }
        }

        private void GenerateList(params string[] words)
        {
            Dictionary<string, long>.KeyCollection keys = frequencies.Keys;
            if (keys != null)
            {
                if (words.Length == 0)
                {
                    foreach (string word in keys)
                    {
                        AddNewElementToList(word);
                    }
                }

                else
                {
                    foreach (string word in words)
                    {
                        AddNewElementToList(word);
                    }
                }
            }
        }

        private void AddNewElementToList(string key)
        {
            ListViewItem listViewItem = new ListViewItem();
            ListViewItem.ListViewSubItem listViewSubItem = new ListViewItem.ListViewSubItem();
            listViewItem.Text = key;
            listViewSubItem.Text = frequencies[key].ToString();
            listViewItem.SubItems.Add(listViewSubItem);
            listView.Items.Add(listViewItem);
        }

        private void countFrequencyButton_Click(object sender, EventArgs e)
        {
            string word = textBox.Text;
            if (!String.IsNullOrWhiteSpace(word))
            {
                listView.Items.Clear();
                GenerateList(word);
            }
        }
    }
}

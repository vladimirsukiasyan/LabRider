using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> list = new List<string>();

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Multiselect = false,
                Filter = "текстовые файлы|*.txt"
            };

            var stopwatch = new Stopwatch();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                stopwatch.Start();

                string text = File.ReadAllText(openFileDialog.FileName);

                char[] separators = new char[] { ' ', '.', ',', '!', '?', '/', '\t', '\n' };

                foreach (var strTemp in text.Split(separators))
                {
                    string str = strTemp.Trim();
                    if (!list.Contains(str))
                    {
                        list.Add(str);
                    }
                }

                stopwatch.Stop();
                this.textBoxFileReadTime.Text = stopwatch.Elapsed.ToString() + " ms";
                this.textBoxFileReadCount.Text = list.Count.ToString();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл");
            }
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            var expectedSubstring = textBoxFind.Text.Trim();

            if (!string.IsNullOrWhiteSpace(expectedSubstring) && list.Count > 0)
            {

                listBoxResult.Items.Clear();
                var tempList = new List<string>();

                var stopwatch = new Stopwatch();
                var isFinded = false;
                stopwatch.Start();

                this.listBoxResult.BeginUpdate();

                foreach (string word in list)
                {
                    if (word.ToUpper().Contains(expectedSubstring.ToUpper()))
                    {
                        listBoxResult.Items.Add(word);
                        isFinded = true;
                    }
                }
                this.listBoxResult.EndUpdate();

                stopwatch.Stop();
                if (!isFinded)
                {
                    listBoxResult.Items.Add("No matches!");
                }
                this.textBoxExactTime.Text = stopwatch.Elapsed.ToString() + " ms";
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}

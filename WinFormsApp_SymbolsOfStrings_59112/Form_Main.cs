using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using SearchTextSymbols = WinFormsApp_SymbolsOfStrings_59112.SearchTextSymbols;

namespace WinFormsApp_SymbolsOfStrings_59112
{
    public partial class form_Main : Form
    {
        private SearchTextSymbols _searchTextSymbols = new SearchTextSymbols();
        private int _num = 59112;
        public form_Main()
        {
            InitializeComponent();
            ArrayList arr_list = new ArrayList();
            arr_list.AddRange(listBox_Input.Items);
            string[] strs = arr_list.ToArray(typeof(string)) as string[];
            _searchTextSymbols.LoadStrings(ref strs);
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            _searchTextSymbols.Clear_Strings();
            listBox_Input.Items.Clear();
            toolStripStatusLabel.Text = "Выполнена очистка строк!";
        }

        private void button_FindLetter_Click(object sender, EventArgs e)
        {
            char ch_letter = textBox_Letter.Text[0];
            int count_letter = _searchTextSymbols.Search_Num_Of_Letter(ch_letter);
            string str = "Символ " + ch_letter.ToString() + " встречается в тексте "
            + count_letter.ToString() + " раз!";
            toolStripStatusLabel.Text = str;
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file_name = openFileDialog.FileName;
                listBox_Input.Items.Clear();
                using (StreamReader r = new StreamReader(file_name, Encoding.Default))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        listBox_Input.Items.Add(line);
                    }
                }
                ArrayList arr_list = new ArrayList();
                arr_list.AddRange(listBox_Input.Items);
                string[] strs = arr_list.ToArray(typeof(string)) as string[];
                _searchTextSymbols.LoadStrings(ref strs);
            }
        }

        private void ToolStripMenu_Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file_name = openFileDialog.FileName;
                listBox_Input.Items.Clear();
                using (StreamReader r = new StreamReader(file_name, Encoding.Default))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        listBox_Input.Items.Add(line);
                    }
                }
                ArrayList arr_list = new ArrayList();
                arr_list.AddRange(listBox_Input.Items);
                string[] strs = arr_list.ToArray(typeof(string)) as string[];
                _searchTextSymbols.LoadStrings(ref strs);
            }
        }

        private void ToolStripMenu_Clear_Click(object sender, EventArgs e)
        {
            _searchTextSymbols.Clear_Strings();
            listBox_Input.Items.Clear();
            toolStripStatusLabel.Text = "Выполнена очистка строк!";
        }

        private void ToolStripMenu_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToolStripMenu_About_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("", "");
        }

        private void button_Task_Click(object sender, EventArgs e)
        {
            char[] strs = { 'а', 'б', 'в', 'г', 'д',
                               'е', 'ж', 'з', 'и', 'й',
                               'к', 'л', 'м', 'н', 'о',
                               'п', 'р', 'с', 'т', 'у',
                               'ф', 'х', 'ц', 'ч', 'ш',
                               'щ', 'ь', 'э', 'ю', 'я'};
            int count_letter = _searchTextSymbols.Search_Num_Of_Letter(strs);
            string str = "Символ " + _searchTextSymbols.char_ret + " встречается в тексте "
            + count_letter.ToString() + " раз!";
            toolStripStatusLabel.Text = str;
        }
    }
}

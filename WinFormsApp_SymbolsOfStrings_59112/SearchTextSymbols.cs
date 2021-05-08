using System.Linq;

namespace WinFormsApp_SymbolsOfStrings_59112
{
    class SearchTextSymbols
    {
        private string[] _strs_input = new string[100];
        private int _index = 0;
        private int Num = 59112;
        public char char_ret;
        public void Clear_Strings()
        {
            for(int i = 0; i < 100; i++)
                _strs_input[i] = "";
            Start_Enumeration();
        }
        public void Start_Enumeration()
        {
            _index = 0;
        }
        public string Get_Next_String()
        {
            string str_ret = null;
            for(int i = _index; i < 100; i++)
            {
                str_ret = _strs_input[i];
                if (str_ret != null)
                {
                    _index += 1;
                    break;
                }
            }
            return str_ret;
        }
        public void LoadStrings(ref string[] strs)
        {
            Clear_Strings();
            int count = strs.Count();
            if (count > 100) count = 100;
            for (int i = 0; i < count; i++)
                _strs_input[i] = strs[i];
        }
        public int Search_Num_Of_Letter(char letter)
        {
            int find_count = 0;
            Start_Enumeration();
            for(int i = 0; i < 100; i++)
            {
                string str = Get_Next_String();
                if (str != null)
                {
                    int len = str.Length;
                    for(int i_len = 0; i_len < len; i_len++)
                    {
                        if (str[1] == letter) find_count++;
                    }
                }
                else
                {
                    break;
                }
            }
            return find_count;
        }

        public int Search_Num_Of_Letter(char[] strs)
        {
            int find_count = 0;
            Start_Enumeration();
            for (int i = 0; i < 100; i++)
            {
                string str = Get_Next_String();
                if (str != null)
                {
                    int len = str.Length;
                    for (int i_len = 0; i_len < len; i_len++)
                    {
                        int indexstr = (Num / 100 + Num % 100) % 20;
                        int indexstrS = (Num + i_len) % 30;
                        if ((str[indexstr] == strs[indexstrS]) &&
                        (i_len > (Num / 100 + Num % 100) % 10)) 
                        {
                            char_ret = strs[indexstrS];
                            find_count++; 
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            return find_count;
        }
    }
}
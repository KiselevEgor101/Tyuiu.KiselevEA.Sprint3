using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KiselevEA.Sprint3.Task3.V24.Lib
{
    public class DataService : ISprint3Task3V24
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            string str = value;
            foreach (char chr in value)
            { 
             if (chr == replaceable)
                {
                    str = str.Replace(chr, replacement);
                }
            }
            return str;

        }
    }
}

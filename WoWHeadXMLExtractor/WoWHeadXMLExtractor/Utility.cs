using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWHeadXMLExtractor
{
    class Utility
    {
        public static string StripNonCommentTagsCharArray(string source)
        {
            char[] array = new char[source.Length];
            int arrayIndex = 0;
            int inside = 0;
            for (int i = 0; i < source.Length; i++)
            {
                char let = source[i];
                if (let == '<')
                {
                    inside = 1;
                    continue;
                }
                if (let == '>')
                {
                    if (inside == 2)
                    {
                        array[arrayIndex] = '|';
                        arrayIndex++;
                    }
                    inside = 0;
                    continue;
                }
                if (let == '!')
                {
                    inside = 2;
                }
                if (inside != 1)
                {
                    array[arrayIndex] = let;
                    arrayIndex++;
                }
            }
            return new string(array, 0, arrayIndex);
        }
    }
}

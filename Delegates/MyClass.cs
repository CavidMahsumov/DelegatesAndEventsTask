using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class MyClass
    {
        public void Space(string word)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                if (i > 0 && i < word.Length)
                    sb.Append('_');
                sb.Append(word[i]);
            }
            Console.WriteLine(sb.ToString());

        }



        public void Reverse(string word)
        {
            var sb = new StringBuilder(word);

            for (int i = 0, length = word.Length / 2; i < length; i++)
            {
                var secondIndex = word.Length - 1 - i;
                var tmp = sb[i];

                sb[i] = sb[secondIndex];
                sb[secondIndex] = tmp;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}

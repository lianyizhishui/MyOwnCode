using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexerTest
{
    class Sentence {
        string[] words ={"I","love","you","very","much"};
        public string this[int num] {
            get { return words[num]; }
            set { words[num] = value; }


        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Sentence sentence = new Sentence ();
            Console.WriteLine(sentence[3]);
            for (int i = 0; i <= 4; i++)
            {
                Console.Write(sentence[i] + " ");

            }
            Console.WriteLine("");
            sentence[3] = "so";
            for (int i = 0; i <= 4; i++) {
                Console.Write(sentence[i]+" ");

            }
            Console.ReadKey();


            
        }
    }
}

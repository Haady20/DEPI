using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentSeven
{
    public class File : IReadable, IWritable
    {
        public string ST;
        public File(string input)
        {
            ST = input;
        }
        public void Read()
        {
            Console.WriteLine($"Text is: {ST}.");
        }
        public void write(string text)
        {
            ST = text;
            Console.WriteLine($"Your Write: '{ST}', as an updated value.");
        }
    }
}

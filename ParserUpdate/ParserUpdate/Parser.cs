using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserUpdate
{
    struct ParserOutput
    {
        public ParserOutput(string Command, int X, int Y)
        {
            this.Command = Command;
            this.X = X;
            this.Y = Y;
        }
        public string Command { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
    internal class Parser
    {
        static public ParserOutput LetsParse(string? Input)
        {
            string[] words = Input.Split(' ');
            string Command = words[0];
            int X = int.Parse(words[1]);
            int Y = int.Parse(words[2]);
            return new ParserOutput(Command, X, Y);
        }
    }
}

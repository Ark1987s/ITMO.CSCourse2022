using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2022.Lab09.ColorToken
{
    public class HTMLTokenVisitor : NullTokenVisitor
    {
        public override void Visit(ILineStartToken line)
        {
            Console.Write("<span class=\"line_number\">");
            Console.WriteLine("{0,3}", line.Number());
            Console.WriteLine("/<span>");
        }
        public override void Visit(ILineEndToken t)
        {
            Console.WriteLine();
        }
        public override void Visit(IIdentifierToken token)
        {
            Console.Write(token.ToString());
        }

        public override void Visit(ICommentToken token)
        {
            Console.Write(token.ToString());
        }
        public override void Visit(IKeywordToken token)
        {
            Console.Write(token.ToString());
        }
        public override void Visit(IWhiteSpaceToken token)
        {
            Console.Write(token.ToString());
        }
        public override void Visit(IOtherToken token)
        {
            Console.Write(token.ToString());
        }
        private void FilteredWrite(IToken token)
        {
            string src = token.ToString();
            for (int i = 0; i != src.Length; i++)
            {
                string dst;
                switch (src[i])
                {
                    case '<':
                        dst = "&lt;"; break;
                    case '>':
                        dst = "&gt;"; break;
                    case '&':
                        dst = "&amp;"; break;
                    default:
                        dst = new string(src[i], 1); break;
                }
                Console.Write(dst);
            }
        }
    }
}

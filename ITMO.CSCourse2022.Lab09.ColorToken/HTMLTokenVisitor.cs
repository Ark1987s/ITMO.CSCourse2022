﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2022.Lab09.ColorToken
{
    public sealed class HTMLTokenVisitor : ITokenVisitor
    {
        public void Visit(ILineStartToken line)
        {
            Console.Write("<span class=\"line_number\">");
            Console.WriteLine("{0,3}", line.Number());
            Console.WriteLine("/<span>");
        }
        public void Visit(ILineEndToken t)
        {
            Console.WriteLine();
        }
        public void Visit(IIdentifierToken token)
        {
            SpannedFilteredWrite("identifier", token);
        }

        public void Visit(ICommentToken token)
        {
            SpannedFilteredWrite("comment", token);
        }
        public void Visit(IKeywordToken token)
        {
            SpannedFilteredWrite("keyword", token);
        }
        public void Visit(IWhiteSpaceToken token)
        {
            Console.Write(token.ToString());
        }
        public void Visit(IOtherToken token)
        {
            FilteredWrite(token);
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
        private void SpannedFilteredWrite(string spanName, IToken token)
        {
            Console.Write("<span class=\"{0}\">", spanName);
            FilteredWrite(token);
            Console.Write("</span>");
        }
        public void Visit(IDirectiveToken token)
        {
            SpannedFilteredWrite("directive", token);
        }
    }
}

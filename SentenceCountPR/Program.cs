using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SentenceCountPR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputpath;
            inputpath = Console.ReadLine();
            SentenceCount sentenceCount = new SentenceCount(inputpath);
        }
    }

    internal class SentenceCount
    {
        public SentenceCount(string path)
        {
            int i = -1;
            try
            {
                i = countFolder(path);
            }
            catch (Exception e)
            { }

            if (i == -1)
            {
                try
                {
                    i = countFile(path);
                }
                catch (Exception e)
                {

                }
            }
            if (i != -1)
                Console.WriteLine(i);
        }

        int countFolder(string s)
        {
            int i = 0;
            foreach (string s1 in Directory.GetFiles(s))
            {
                foreach (string s2 in File.ReadAllLines(s1))
                    i++;
            }

            return i;
        }

        int countFile(string s)
        {
            int i = 0;
            foreach (string s1 in File.ReadAllLines(s))
                i++;
            return i;
        }
    }
}

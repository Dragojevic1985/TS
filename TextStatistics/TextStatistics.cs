using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TextStatistics.Interfaces;

namespace TextStatistics
{
    public class TextStatistics : ITextStatistics
    {
        public List<string> LongestWords(int n)
        {
            throw new NotImplementedException();
        }

        public long NumberOfLines()
        {
            throw new NotImplementedException();
        }

        public long NumberOfWords()
        {
            throw new NotImplementedException();
        }

        public List<IWordFrequency> TopWords(int n)
        {
            throw new NotImplementedException();
        }
    }
}
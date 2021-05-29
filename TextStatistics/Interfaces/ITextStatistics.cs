using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatistics.Interfaces
{
    public interface ITextStatistics
    {
        List<IWordFrequency> TopWords(int n);

        List<string> LongestWords(int n);

        long NumberOfWords();

        long NumberOfLines();
    }
}

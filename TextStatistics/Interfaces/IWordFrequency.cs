using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatistics.Interfaces
{
    public interface IWordFrequency
    {
        string Word(string text);

        long Frequency();
    }
}

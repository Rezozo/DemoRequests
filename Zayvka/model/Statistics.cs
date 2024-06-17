using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zayvka.model
{
    public class Statistics
    {
        public string Title { get; set; }
        public long Count { get; set; }
        public Statistics(string title, long count)
        {
            Title = title;
            Count = count;
        }

        public override string ToString()
        {
            return "\n" + Title + ": " + Count;
        }
    }
}

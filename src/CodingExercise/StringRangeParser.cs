using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExercise
{
    public static class StringRangeParser
    {
        /// <summary>
        /// Parse string into a range
        /// "" => null, null
        /// 2 => min = 2, max = 2
        /// 1,2 => min = 1, max =2
        /// >1 => min = 1, max = null
        /// <5 => min = null, max =5
        /// 
        public static Tuple<string, string> Parse(string incoming)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    

    internal class Range <Ty> where Ty : IComparable<Ty>
    {

        #region Atrribute

        public Ty Maximum { get; set; }

        public Ty Minimum { get; set; }


        #endregion

        #region Para const

        public Range(Ty min, Ty max)
        {
            Minimum = min;
            Maximum = max;
        }

        #endregion

        #region Methods
        public bool IsInRange(Ty value)
        {
            if (value is not null)
                return value.CompareTo(Minimum) > 0 && value.CompareTo(Maximum) < 0;
            return false;
        }
        
        public Ty Length()
        {
            dynamic max = Maximum;
            dynamic min = Minimum;
            return max - min;
        }



        #endregion


    }
}

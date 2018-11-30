using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKDSparringBracketGenerator
{
    class BracketAlgorithm
    {
        private List<Competitor> _competitors;
        private List<Competitor> _A;
        private List<Competitor> _B;
        private List<Competitor> _C;
        public BracketAlgorithm(List<Competitor> competitors)
        {
            _competitors = competitors;
            arrangeDivisons(_competitors);
        }

        /*This method arranges the List by the Divison in order: 
         * A, B, or C, and creates new lists of that divison
         */
        public void arrangeDivisons (List<Competitor> comp)
        {
            comp.Sort((c1, c2) => c1.Divison.CompareTo(c2.Divison));
            int startOfA = comp.FindIndex(c => c.Divison.Equals("A"));
            _A = comp.GetRange(startOfA, comp.Count(c => c.Divison.Equals("A")));
            int startOfB = comp.FindIndex(c => c.Divison.Equals("B"));
            _B = comp.GetRange(startOfB, comp.Count(c => c.Divison.Equals("B")));
            int startOfC = comp.FindIndex(c => c.Divison.Equals("C"));
            _C = comp.GetRange(startOfC, comp.Count(c => c.Divison.Equals("C")));

            arrangeWeightClass();
        }
        
        public void arrangeWeightClass ()
        {
            _A.Sort((c1, c2) => c1.WeightClass.CompareTo(c2.WeightClass));
            _B.Sort((c1, c2) => c1.WeightClass.CompareTo(c2.WeightClass));
            _C.Sort((c1, c2) => c1.WeightClass.CompareTo(c2.WeightClass));

        }

    }
}

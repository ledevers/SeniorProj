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
        public IList<Competitor> Competitors
        {
            get { return _competitors.AsReadOnly(); }
        }

        private List<Competitor> _A;
        private List<Competitor> _B;
        private List<Competitor> _C;
        public BracketAlgorithm(List<Competitor> competitors)
        {
            _competitors = competitors;
            arrangeDivisions(_competitors);
        }

        /*This method arranges the List by the Division in order: 
         * A, B, or C, and creates new lists of that division
         */
        private void arrangeDivisions (List<Competitor> comp)
        {
            comp.Sort((c1, c2) => c1.Division.CompareTo(c2.Division));
            int startOfA = comp.FindIndex(c => c.Division.Equals("A"));
            startOfA = Math.Max(0, startOfA);
            _A = comp.GetRange(startOfA, comp.Count(c => c.Division.Equals("A")));
            int startOfB = comp.FindIndex(c => c.Division.Equals("B"));
            startOfB = Math.Max(0, startOfB);
            _B = comp.GetRange(startOfB, comp.Count(c => c.Division.Equals("B")));
            int startOfC = comp.FindIndex(c => c.Division.Equals("C"));
            startOfC = Math.Max(0, startOfC);
            _C = comp.GetRange(startOfC, comp.Count(c => c.Division.Equals("C")));

            arrangeWeightClass();
        }
        
        private void arrangeWeightClass ()
        {
            _A.Sort((c1, c2) => c1.WeightClass.CompareTo(c2.WeightClass));
            _B.Sort((c1, c2) => c1.WeightClass.CompareTo(c2.WeightClass));
            _C.Sort((c1, c2) => c1.WeightClass.CompareTo(c2.WeightClass));
            combineList();

        }

        private List<Competitor> combineList()
        {
            _competitors.Clear();
            _competitors.AddRange(_A);
            _competitors.AddRange(_B);
            _competitors.AddRange(_C);

            return _competitors;
        }      
    }
}

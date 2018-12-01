using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKDSparringBracketGenerator
{
    public class Competitor
    {
        public string Name { get; }
        public BeltRank Rank { get; }     
        public Gender Gender { get; }
        public int Height { get; }
        public double Weight { get; }
        public WeightClass WeightClass { get; }
        public string Division;
       public Competitor(string name, BeltRank rank, Gender gender, int height, double weight)
        {
            this.Name = name;
            this.Rank = rank;          
            this.Height = height;
            this.Weight = weight;
            this.Gender = gender;
            WeightClass = FindWeightClass(gender, weight);
            FindDivision(rank);
        }
       private WeightClass FindWeightClass(Gender gender, double weight)
        {
            if(gender == Gender.Female)
            {
                return FemaleWeightClass(weight);
            }
            else 
            {
               return MaleWeightClass(weight);
            }
            
        }
        
       private WeightClass FemaleWeightClass(double weight)
        {
            if (weight < 46)
            {
                return WeightClass.Fin;
            }
            else if (weight >= 47 && weight <= 49)
            {
                return WeightClass.Fly;
            }
            else if (weight >= 50 && weight <= 53)
            {
                return WeightClass.Bantam;
            }
            else if (weight >= 54 && weight <= 57)
            {
                return WeightClass.Feather;
            }
            else if (weight >= 58 && weight <= 62)
            {
                return WeightClass.Light;
            }
            else if (weight >= 63 && weight <= 67)
            {
                return WeightClass.Welter;
            }
            else if (weight >= 68 && weight <= 73)
            {
                return WeightClass.Middle;
            }
            else
            {
                return WeightClass.Heavy;
            }
            
        }
        private WeightClass MaleWeightClass(double weight)
        {
            if (weight < 54)
            {
               return WeightClass.Fin;
            }
            else if (weight >= 55 && weight <= 58)
            {
                return WeightClass.Fly;
            }
            else if (weight >= 59 && weight <= 63)
            {
                return WeightClass.Bantam;
            }
            else if (weight >= 64 && weight <= 68)
            {
                return WeightClass.Feather;
            }
            else if (weight >= 69 && weight <= 74)
            {
                return WeightClass.Light;
            }
            else if (weight >= 75 && weight <= 80)
            {
                return WeightClass.Welter;
            }
            else if (weight >= 81 && weight <= 87)
            {
                return WeightClass.Middle;
            }
            else
            {
                return WeightClass.Heavy;
            }
            
        }
        
        private void FindDivision(BeltRank rank)
        {
            if (rank == BeltRank.White || rank == BeltRank.Yellow)
            {
                 Division = "C";
            }
            else if(rank == BeltRank.Recommended_Black || rank == BeltRank.First_Dan || rank == BeltRank.Second_Dan || rank == BeltRank.Third_Dan || rank == BeltRank.Fourth_Dan)
            {
                 Division = "A";
            }
            else
            {
                 Division = "B";
            }
        }             
    }
}

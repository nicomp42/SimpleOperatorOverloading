/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleOperatorOverloading
{
    class Purkey
    {
        public Purkey(int weight, String name)
        {
            this.weight = weight;
            this.name = name;
        }
        public Purkey(String name, double weight) {this.name = name, this.weight = weight; }
        private String mName;
        public String name
        {
            get { return mName; }
            set { mName = value; }
        }
        private double mWeight;
        public double weight
        {
            get { return mWeight; }
            set { mWeight = value; }
        }
        // This won't compile - uncomment is and see
/*      public static Purkey operator+(Turkey t, Pumpkin p)
        {
            return new Purkey(t.name, p.weight);
        } */
    }
}

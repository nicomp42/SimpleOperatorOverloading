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
    /// <summary>
    /// Model a Purkey. It's a Pumpkin plus a Turkey
    /// </summary>
    class Purkey
    {
        public Purkey(int weight, String name)
        {
            this.weight = weight;
            this.name = name;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of the Purkey</param>
        /// <param name="weight">Weight of the Purkey</param>
        public Purkey(String name, double weight) {this.name = name, this.weight = weight; }
        private String mName;
        /// <summary>
        /// Name of the Purkey
        /// </summary>
        public String name
        {
            get { return mName; }
            set { mName = value; }
        }
        private double mWeight;
        /// <summary>
        /// Weight of the Purkey
        /// </summary>
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

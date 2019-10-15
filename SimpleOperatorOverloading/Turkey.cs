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
    class Turkey
    {
        private String mName;
        public String name
        {
            get { return mName;}
            set { mName = value; }
        }
        /// <summary>
        /// Add a Pumpkin and Turkey
        /// </summary>
        /// <param name="t">Turkey</param>
        /// <param name="p">Pumpkin</param>
        /// <returns>a Purkey</returns>
        public static Purkey operator +(Turkey t, Pumpkin p)
        {
            return new Purkey(t.name, p.weight);
        }
    }
}

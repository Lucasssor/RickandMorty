using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickandMorty
{
    internal class Rick
    {
        public bool HasKey { get; set; }
        public bool HasLighter { get; set; }
        public bool HasMorty { get; set; }       
        public bool HasBooze { get; set; }
        public string BoozeType { get; set; }
        public bool HasRiddleMedal { get; set; }


                
        public Rick()
        {
            HasKey = false;
            HasMorty = false;
            HasBooze = false;
            HasLighter = false;
            HasRiddleMedal = false;
        }

        public void PickUpBooze(string booze)
        {
            HasBooze = true;
            BoozeType = booze;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CGS
{
    public class Curators : CollectionBase
    {

        public void Add(Curator curator)
        {
            List.Add(curator);
        }

       public Curators()
        {

        }



        public Curator this[int ArtistIndex]
        {
            get
            {
                return (Curator)List[ArtistIndex];
            }
            set
            {
                List[ArtistIndex] = value;
            }
        }

        public bool ReadCurators()
        {

            return true;
        }
    }
}


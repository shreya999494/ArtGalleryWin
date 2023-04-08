using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CGS
{
    public class Artists : CollectionBase
    {
      
        public void Add(Artist artist)
        {
            List.Add(artist);
        }

        public Artists()
        {

        }

       

        public Artist this[int ArtistIndex]
        {
            get
            {
                return (Artist)List[ArtistIndex];
            }
            set
            {
                List[ArtistIndex] = value;
            }
        }
    }
}

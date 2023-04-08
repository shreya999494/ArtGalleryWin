using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CGS
{
    public class Pieces : CollectionBase
    {
     
        public void Add(ArtPiece piece)
        {
            List.Add(piece);
        }

       public Pieces()
        {

        }

       

        public ArtPiece this[int PieceIndex]
        {
            get
            {
                return (ArtPiece)List[PieceIndex];
            }
            set
            {
                List[PieceIndex] = value;
            }
        }
    }
}

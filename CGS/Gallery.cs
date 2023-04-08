using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;

namespace CGS
{
    public class Gallery
    {
        ArtPiece artpiece = new ArtPiece();
        Pieces pieces = new Pieces();
        Artists artists = new Artists();
        Curators curators = new Curators();

       public void AddArtist(string firstName, string lastName, string artistId)
        {
            Artist artist = new Artist(firstName, lastName, artistId);
            artists.Add(artist);
        }

         public void AddCurator(string firstName, string lastName, string curatorId )
        {
            Curator curator = new Curator(firstName, lastName, curatorId);
            curators.Add(curator);
        }

        public string ListArtists()
        {
            string str = "";
            foreach (var item in artists)
            {
                var artist = (Artist)item;
            str +=("AritstId: " + artist.ArtistId + ", First Name: " + artist.FirstName + ", Last Name: " + artist.LastName + "\n");
            }
            return str;
        }

        public string ListCurators()
        {
            string str = "";
            foreach (var item in curators)
            {
                var curator = (Curator)item;
            str +=("CuratorId: " + curator.CuratorId + ", First Name: " + curator.FirstName + ", Last Name: " + curator.LastName + "\n"+",Commission Paid:"+curator.Commission);
            }
            return str;
        }

        public void AddPiece(string pieceId, string title, string year, double estimate, string artistId, string curatorId ,char status)
        {
            ArtPiece piece = new ArtPiece(pieceId, title, year, estimate, artistId, curatorId,status);
            pieces.Add(piece);
        }

        public string  ListPieces()
        {
            string str="";
            foreach (var item in pieces)
            {
                var piece = (ArtPiece)item;
              str +=("Piece Id: " + piece.PieceId +
                    ", Title: " + piece.Title +
                    ", Year: " + piece.Year +
                    ", Price: " + piece.Price +
                    ", Estimate: " + piece.Estimate +
                    ", Artist Id: " + piece.ArtistId +
                    ", Curator Id: " + piece.CuratorId +
                    ", Status: " + piece.Status + "\n");
            }
            return str;
        }

        public bool SellPiece(string pieceId, double pricePaid)
        {
            string str = "";
           foreach(var item  in pieces){
                //var piece = (ArtPiece)item;
                var piece = (ArtPiece)item;
                str = piece.PieceId;
                if (pieceId.Equals(piece.PieceId)){
                 if(artpiece.Status.Equals ("S")){                    
                        return false;
                        
                    }else if(artpiece.Status.Equals('D')){
                        //piece.ChangeStatus("S");
                        Curator curator = new Curator();
                        string Curatorid = curator.GetID();
                        //ArtPiece artpiece = new ArtPiece();
                        artpiece.ChangeStatus('S');
                        artpiece.PricePaid(pricePaid);
                        double commission = artpiece.CalculateComm(pricePaid);

                       
                        foreach(Curator obj in curators)
                        {
                            //var curator = (Curator)obj;
                            if(obj.CuratorId.Equals(Curatorid)){
                            obj.SetComm(commission);
                        }
                        }
                        }
                }
            }
            
            return true;
           
        }

        public bool WriteCurators()
        {

            return true;
        }

        /*public GetCurators()
        {
            //curators.ReadCurators();
        }*/

        public bool SetStatus(char status)
        {
            if (status=='D')
            {
                artpiece.ChangeStatus(status);
            }
            return true;
        }
    }
}
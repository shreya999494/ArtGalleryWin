namespace CGS
{
    public class ArtPiece
    {
        public string PieceId { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public double Price { get; set; }
        public double Estimate { get; set; }
        public string ArtistId { get; set; }
        public string CuratorId { get; set; }
        public char Status { get; set; }

        public ArtPiece()
        {
        }

        public ArtPiece(string pieceId, string title, string year, double estimate, string artistId, string curatorId ,char status)
        {
            PieceId = pieceId;
            Title = title;
            Year = year;
            Price = 0;
            Estimate = estimate;
            ArtistId = artistId;
            CuratorId = curatorId;
            Status = status;
        }

        public override string ToString()
        {
            return "\nPieceId : " + PieceId + "\nTitle : " + Title +
             "\nPrice : " + Price + "\nValueEstimate : " + Estimate + "\nArtistId " + ArtistId + "\nStatus : " + Status;
        }

        public void ChangeStatus(char status) => Status = status;

        public void PricePaid(double price) => Price = price;

        public double CalculateComm(double pricePaid) => (Price - pricePaid) * (25 / 100);
    }
}
namespace CGS
{
    public class Artist : Person
    {
        public string ArtistId { get; set; }

        public Artist()
        {
        }

        public Artist(string firstName, string lastName, string artistId) : base(firstName, lastName)
        {
            ArtistId = artistId;
        }

        public override string ToString()
        {
            return "\nName: " + base.FirstName + "\nFirstname " +
            base.ToString()+"," +"\nArtisteID: " + ArtistId;
        }
    }
}
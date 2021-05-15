namespace MyPersistance.Entities
{
    public class Zipcode
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public string City { get; set; }

        public Zipcode() { }
        public Zipcode(int code, string state, string county, string city) 
        {
            Code = code;
            State = state;
            County = county;
            City = city;
        }
    }
}
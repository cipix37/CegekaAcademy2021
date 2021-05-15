namespace MyPersistance.Entities
{
    public class Freelancer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Adress { get; set; }
        public int ZipcodeId { get; set; }

        public Freelancer() { }
        public Freelancer(string name, float price, string adress, int zipcodeId)
        {
            Name = name;
            Price = price;
            Adress = adress;
            ZipcodeId = zipcodeId;
        }
    }
}
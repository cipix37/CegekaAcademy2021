namespace MyPersistance.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int ZipcodeId { get; set; }

        public Customer() { }
        public Customer(string name, string adress, int zipcodeId) 
        {
            Name = name;
            Adress = adress;
            ZipcodeId = zipcodeId;
        }
    }
}
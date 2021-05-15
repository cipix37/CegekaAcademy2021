namespace MyPersistance.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Estimation { get; set; }
        public int CustomerId { get; set; }


        public Project() { }
        public Project(string name, int estimation, int customerId) 
        {
            Name = name;
            Estimation = estimation;
            CustomerId = customerId;
        }
    }
}
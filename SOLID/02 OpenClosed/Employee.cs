namespace SOLID._02_OpenClosed
{
    public abstract class Employee
    {
        public Employee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public virtual decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }
}
namespace SOLID._02_OpenClosed
{
    public class PermanentEmploye : Employee
    {
        public PermanentEmploye(int id, string name)
            : base(id, name)
        {
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary *.05M;
        }
    }
}

namespace SOLID._02_OpenClosed
{
    public class ContractEmployee : Employee
    {
        public ContractEmployee(int id, string name)
            : base (id, name )
        {
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }
}

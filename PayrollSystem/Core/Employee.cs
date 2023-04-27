namespace PayrollSystem.Core
{
    public class Employee
    {
        public string fullName { get; set; }
        public IEnumerable<PayItem> PayItems { get; set; }
    }
}

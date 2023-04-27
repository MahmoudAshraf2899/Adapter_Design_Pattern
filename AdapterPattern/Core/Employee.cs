namespace AdapterPattern.Core
{
    public class Employee
    {
        public string firstName { get; set; }

        public string secondName { get; set; }

        public string lastName { get; set; }

        public string fullName => $"{firstName} {secondName}  {lastName}";

        public IEnumerable<PayItem> PayItems { get; set; }
    }
}

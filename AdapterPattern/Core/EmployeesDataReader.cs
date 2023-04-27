namespace AdapterPattern.Core
{
    public class EmployeesDataReader
    {
        public IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    firstName = "Ahmed",
                    secondName = "Ali",
                    lastName = "Bassiony",
                    PayItems = new List<PayItem>()
                    {
                        new PayItem {Name = "Basic Salary" , Value =1000},
                        new PayItem {Name = "Transportation" , Value =250},
                        new PayItem {Name = "Medical Insurance" , Value =150 , isDeduction = true},
                    }
                },
                new Employee()
                {
                    firstName = "Mahmoud",
                    secondName = "Ashraf",
                    lastName = "Mohamed",
                    PayItems = new List<PayItem>()
                    {
                        new PayItem {Name = "Basic Salary" , Value = 1000},
                        new PayItem {Name = "Transportation" , Value = 250},
                        new PayItem {Name = "Medical Insurance" , Value = -150},
                    }
                }
            };
        }
    }
}

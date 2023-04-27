namespace AdapterPattern.Core
{
    public class PayrollSystemEmployeeAdapter
    {
        private readonly Employee _employee;
        private readonly IEnumerable<PayrollSystemPayItemAdapter> _payItems;
        public PayrollSystemEmployeeAdapter(Employee employee)
        {
            _employee = employee;
            _payItems = employee.PayItems.Select(payItem => new PayrollSystemPayItemAdapter(payItem)).ToList();
        }

        public string fullName => _employee.fullName;
        public IEnumerable<PayrollSystemPayItemAdapter> PayItems => _payItems;
    }
}

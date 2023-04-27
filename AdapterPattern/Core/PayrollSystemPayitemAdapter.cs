namespace AdapterPattern.Core
{
    public class PayrollSystemPayItemAdapter
    {
        private readonly PayItem _payItem;

        public PayrollSystemPayItemAdapter(PayItem payItem)
        {
            _payItem = payItem;
        }
        public string Name => _payItem.Name;

        public decimal Value => _payItem.isDeduction ? _payItem.Value * -1 : _payItem.Value;
    }
}

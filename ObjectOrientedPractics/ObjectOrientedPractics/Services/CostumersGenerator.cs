namespace ObjectOrientedPractices
{
    internal static class CustumersGenerator
    {
        private static int _custumersGeneratedCount = 0;

        public static Customer GetNextCustomer()
        {
            Customer newCustomer = new Customer($"full name{_custumersGeneratedCount}", $"address{_custumersGeneratedCount}");
            _custumersGeneratedCount++;
            return newCustomer;
        }
    }
}

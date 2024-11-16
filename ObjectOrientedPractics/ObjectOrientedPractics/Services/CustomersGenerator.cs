using ObjectOrientedPractices.Models;

namespace ObjectOrientedPractices
{
    /// <summary>
    /// класс, генерирующий покупателей
    /// </summary>
    internal static class CustomersGenerator
    {
        /// <summary>
        /// генерирует экземпляр класса Customer и возвращает его
        /// </summary>
        /// <returns> Customer </returns>
        public static Customer GetNextCustomer()
        {
            Customer newCustomer = new Customer();
            return newCustomer;
        }
    }
}

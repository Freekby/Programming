namespace ObjectOrientedPractices
{
    internal class PriorityOrder : Order
    {
        private static List<string> _rangesList = new List<string> { "9:00 – 11:00", "11:00 – 13:00", "13:00 – 15:00", "15:00 – 17:00", "17:00 – 19:00", "19:00 – 21:00"};
        private DateTime _deliveryDate;
        private string _deliveryTime;

        public static List<string> RangesList { get { return new List<string>(_rangesList); } }

        public DateTime DeliveryDate 
        { 
            get { return _deliveryDate; }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new ArgumentException($"{nameof(DeliveryDate)} должно быть больше либо равно нынешней дате");
                }

                _deliveryDate = value;
            }
        }

        public string DeliveryTime
        {
            get { return _deliveryTime; }
            set
            {
                if (!_rangesList.Contains(value))
                {
                    throw new ArgumentException($"{nameof(DeliveryTime)} не принадлежит заданным дапазонам");
                }
                _deliveryTime = value;
            }
        }

        public PriorityOrder() : base()
        {
            DeliveryDate = DateTime.Now.AddDays(1);
            DeliveryTime = _rangesList[0];
        }
        
        public PriorityOrder(DateTime deliveryDate, string deliveryTime, Address address, List<Item> items, double cost) : base(address, items, cost)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }
    }
}

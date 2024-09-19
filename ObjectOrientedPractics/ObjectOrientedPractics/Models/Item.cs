namespace ObjectOrientedPractices
{
    /// <summary>
    /// хранит информацию о товаре
    /// </summary>
    internal class Item
    {
        /// <summary>
        /// индивидуальный идентификатор
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// название товара
        /// </summary>
        private string _name;
        /// <summary>
        /// информация о товаре
        /// </summary>
        private string _info;
        /// <summary>
        /// Цена товара
        /// </summary>
        private float _cost;

        public int Id { get { return _id; } }

        /// <summary>
        /// Возвращает и задаёт название товара. Не может быть больше 200 символов или пустым.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set 
            {
                ValueValidator.CheckStringOnNullOrEmpty(value, Name);
                ValueValidator.AssertStringOnLength(value, 200, Name); 
                
                _name = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                ValueValidator.CheckStringOnNullOrEmpty(value, Info);
                ValueValidator.AssertStringOnLength(value, 1000, Info);

                _info = value;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float Cost
        {
            get { return _cost; }
            set 
            {
                if (value > 100000) 
                {
                    throw new ArgumentOutOfRangeException("cost should be <= 100000");
                }
                 if (_cost < 0)
                {
                    throw new ArgumentOutOfRangeException("cost should be >= 0");
                }

                 _cost = value;
            }
        }

        ///// <summary>
        ///// 
        ///// </summary>
        //public Item()
        //{

        //}

        /// <summary>
        /// генератор класса Item
        /// </summary>
        /// <param name="name"></param>
        /// <param name="info"></param>
        /// <param name="cost"></param>
        public Item(string name, string info, float cost)
        {
            _id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}

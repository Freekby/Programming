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
                ValueValidator.CheckStringOnNullOrEmpty(value, nameof(Name));
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name)); 
                
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт информацию о товаре. Не может быть больше 1000 символов или пустым.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                ValueValidator.CheckStringOnNullOrEmpty(value, nameof(Info));
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));

                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт название товара. Не может быть больше 100 000 или меньше 0.
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

        /// <summary>
        /// создаёт пустой экземпляр класса <see cref="Item"/>
        /// </summary>
        public Item()
        {

        }

        /// <summary>
        /// создаёт пустой экземпляр класса <see cref="Item"/>
        /// </summary>
        /// <param name="name"> название </param>
        /// <param name="info"> информация </param>
        /// <param name="cost"> цена </param>
        public Item(string name, string info, float cost)
        {
            _id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
        }

        /// <summary>
        /// возвращает имя товара
        /// </summary>
        /// <returns> string </returns>
        public override string ToString()
        {
            return _name;
        }
    }
}

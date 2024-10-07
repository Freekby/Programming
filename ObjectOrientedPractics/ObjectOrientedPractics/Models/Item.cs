namespace ObjectOrientedPractices
{
    /// <summary>
    /// Хранит информацию о товаре.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Индивидуальный идентификатор.
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;
        /// <summary>
        /// Информация о товаре.
        /// </summary>
        private string _info;
        /// <summary>
        /// Цена товара.
        /// </summary>
        private float _cost;

        /// <summary>
        /// Возвращает ID товара.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Возвращает и задаёт категорию товара.
        /// </summary>
        public Category Category { get; set; }

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
        /// Создаёт пустой экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            _id = IdGenerator.GetNextId();
            Name = "name";
            Info = "info";
            Cost = 0;
            Category = Category.Clothes;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name"> название </param>
        /// <param name="info"> информация </param>
        /// <param name="cost"> цена </param>
        /// <param name="category"> категория </param>
        public Item(string name, string info, float cost, Category category)
        {
            _id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        /// <summary>
        /// Возвращает имя товара.
        /// </summary>
        /// <returns> string </returns>
        public override string ToString()
        {
            return _name;
        }
    }
}

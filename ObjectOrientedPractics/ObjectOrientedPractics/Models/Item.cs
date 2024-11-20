namespace ObjectOrientedPractices.Models.Enums
{
    /// <summary>
    /// Хранит информацию о товаре.
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {

        /// <summary>
        /// Событие для изменения названия товара
        /// </summary>
        public event EventHandler NameChanged;

        /// <summary>
        /// Событие для изменения цены товара
        /// </summary>
        public event EventHandler CostChanged;

        /// <summary>
        /// Событие для изменения информации товара
        /// </summary>
        public event EventHandler InfoChanged;

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

                if (_name != value)
                {
                    NameChanged?.Invoke(this, new EventArgs());
                    _name = value;
                }
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

                if (_info != value)
                {
                    _info = value;
                    InfoChanged?.Invoke(this, EventArgs.Empty);
                }
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
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("cost should be >= 0");
                }

                if (_cost != value)
                {
                    _cost = value;
                    CostChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            _id = IdGenerator.GetNextId();
            Name = $"name{_id}";
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

        /// <inheritdoc/>
        public object Clone()
        {
            return new Item(Name, Info, Cost, Category);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <inheritdoc/>
        public bool Equals(Item other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id;
        }

        /// <inheritdoc/>
        public override bool Equals(object other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            if (other.GetType() != this.GetType()) return false;
            return Equals((Item)other);
        }

        public int CompareTo(Item? other)
        {
            return Cost.CompareTo(other.CompareTo);
        }
    }
}

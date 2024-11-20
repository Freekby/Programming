namespace ObjectOrientedPractices.Models
{
    /// <summary>
    /// Хранит данные о адресе покупателя.
    /// </summary>
    public class Address : ICloneable, IEquatable<Address>
    {

        /// <summary>
        /// Событие для изменения адреса
        /// </summary>
        public event EventHandler AddressChanged;

        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна/регион.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город (населенный пункт).
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры/помещения.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задаёт Почтовый индекс. должно быть целым шестизначным числом.
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                if (value < 100000 || value > 999999)
                {
                    throw new ArgumentException("Index должен быть целым шестизначным числом");
                }

                if (_index != value)
                {
                    _index = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }

            }
        }

        /// <summary>
        /// Возвращает и задаёт Страну/регион. не должно превышать 50 символов
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                if (_country != value)
                {
                    _country = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт Город (населенный пункт). не должно превышать 50 символов
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                if (_city != value)
                {
                    _city = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт Улицу. не должно превышать 100 символов
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                if (_street != value)
                {
                    _street = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт Номер дома. не должно превышать 10 символов
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                if (_building != value)
                {
                    _building = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт Номер квартиры/помещения. не должно превышать 10 символов
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                if (_apartment != value)
                {
                    _apartment = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Address"/>
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = "";
            City = "city";
            Street = "";
            Building = "";
            Apartment = "";
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Address"/>
        /// </summary>
        /// <param name="index"> Почтовый индекс </param>
        /// <param name="country"> Страна/регион </param>
        /// <param name="city"> Город (населенный пункт) </param>
        /// <param name="street"> Улица </param>
        /// <param name="building"> Номер дома </param>
        /// <param name="apartment"> Номер квартиры/помещения </param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        public override string ToString()
        {
            return $"{Index} {Country} {City} {Street} {Building} {Apartment}";
        }

        public object Clone()
        {
            return new Address(Index, Country, City, Street, Building, Apartment);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <inheritdoc/>
        public bool Equals(Address other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return (Index == other.Index &&
                Country == other.Country &&
                City == other.City &&
                Street == other.Street &&
                Building == other.Building &&
                Apartment == other.Apartment);
        }

        /// <inheritdoc/>
        public override bool Equals(object other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            if (other.GetType() != this.GetType()) return false;
            return Equals((Address)other);
        }
    }
}

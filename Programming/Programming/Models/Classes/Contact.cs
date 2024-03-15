﻿namespace Programming
{
    public class Contact
    {
        private string email;
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string name, string phoneNumber, string email)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

        public Contact()
        {
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (!value.Contains("@"))
                {
                    throw new ArgumentException("неправильный формат email");
                }
                    email = value;
            }
        }
    }
}
using Newtonsoft.Json;
using System.IO;

namespace View.Model.Services
{
    /// <summary>
    /// Класс для сериализации данных.
    /// </summary>
    static class ContactSerializer
    {
        static private string _saveFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), ".\\Contacts\\contacts.json");

        /// <summary>
        /// Запись информации о контакте.
        /// </summary>
        /// <param name="contact"></param>
        static public void Serialize(Contact contact) 
        {
            if (!Directory.Exists(Path.GetDirectoryName(_saveFilePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_saveFilePath));
            }
            
            string serializedData = JsonConvert.SerializeObject(contact);

            File.WriteAllText(_saveFilePath, serializedData);
        }

        /// <summary>
        /// Чтение информации о контакте.
        /// </summary>
        /// <returns>Экземпляр класса <see cref="Contact"/></returns>
        /// <exception cref="Exception"> =</exception>
        static public Contact DeSerialise()
        {
            string serialisedData = File.ReadAllText(_saveFilePath);

            if (string.IsNullOrEmpty(serialisedData))
            {
                throw new Exception($"DeSerialise couldn't found any data");
            }

            Contact deSerialisedContact = JsonConvert.DeserializeObject<Contact>(serialisedData);

            return deSerialisedContact;
        }
    }
}

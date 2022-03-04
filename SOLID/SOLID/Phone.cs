using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    // dependancy in OOP just simply means that that CLASS CANNOT FUNCTION WITHOUT another 
    // CLASS TO solve SUb problems
    public class Phone
    {

        // Dependency in
        private readonly IContactManager _contactManager;
        private readonly AppManager _appManager;

        public Phone(IContactManager contactManager, AppManager appManager)
        {
            _contactManager = contactManager;
            _appManager = appManager;
        }


        public void AddContact(string name)
        {
            _contactManager.AddContact(name);
        }
    }


    public interface IContactManager
    {
        void AddContact(string contactName);
        void RemoveContact(string contact);
        void UpdateContact(string contact);
    }

    public class ConactManager : IContactManager
    {
        public void GetContacts()
        {
            
        }

        private IEnumerable<string> FilterContacts(string filter)
        {
            // logic to filter contacts
            return new List<string>();
        }

        public void AddContact(string contactName)
        {

        }

        public void RemoveContact(string contact)
        {

        }

        public void UpdateContact(string contact)
        {

        }

    }


    public class AppManager
    {
        public void DownloadApp(string name)
        {

        }

        public void RemoveApp(string name)
        {

        }

        public void UpdateApp(string name)
        {

        }
    }
}

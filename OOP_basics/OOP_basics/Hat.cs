using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basics
{
    // on the subject of Access Modifiers
    // Access Modifiers allow you to "modify" the access level
    // of each of the members of your class / object.
    internal class Hat // the internal access modifier makes your code public ONLY
        // WITHEN it's own project (it's own binaries)
    {
        // All members have an access modifier, however, good coding practices dictate
        // WHAT access modifers you should use on certain members.
        private int myVar;
        
        // The order of your members DO NOT MATTER

        // public members can be ACCESSED OUTSIDE of the 
        // class it's a member TO. Size is a member of Hat
        // but becuase it's PUBLIC, we can ACCESS this member
        // outside of the Hat class.
        public int Size { get; set; }


        //can ONLY use this MEMBER inside of it's CLASS. 
        private string _owner;

        public string GetHatMessage()
        {
            HandleEmptyOwner();
            return $"The size of me is {Size}, and my owner is {_owner}";
        }

        // Private methods are very common, it's giving the developer a way 
        // to seperate logic becasue you want your methods to be slim, and 
        // you want them to solve specific problems.
        private void HandleEmptyOwner()
        {
            // private methods usually act as helper methods to your
            // public methods
            if (_owner == null)
            {
                _owner = "James";
            }
        }
    }
}

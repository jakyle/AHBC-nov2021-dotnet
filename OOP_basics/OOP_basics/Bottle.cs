using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// OOP stands for Object Oriented Programming
namespace OOP_basics
{

    // A class is a blueprint that describes the shape of your Object when
    // it is in memory. Objects are Classes that have been created into
    // memory.  which is to say, Classes are NOT in memory, but objects are
    internal class Bottle // classes are REFERENCE TYPES
    {

        public List<string> Names { get; set; }


        // any "thing" that exist inside of a class / object is called
        // a "member", this becamse the class / object "owns" or "contains"
        // these "members"
        // they are called "members" because they have membership to the class / object
        // they belong to

        // an Auto property, this is your "Noun" for your classes / objects,
        // they are data that describe the contents of your class / object

        // the entire point of properties is to Expose Public DATA from your 
        // class / objecs, high level, think of properties as variables that 
        // are members of that SPECIFIC object.

        // to access Properites outside of the class when you are working
        // with an instance object, you access the property or ANY PUBLIC
        // member using 'DOT' notation.
        public double Volume 
        { 
            get; 
            set; 
        }

        // Auto properties are THE MOST common properties YOU will be using
        // in your classes. they are calles Auto Properties because they are 
        // automatically HANDLING Getting and Setting Data.
        public bool IsEmpty { get; set; } // <= Getters and Setters
        // the Purpose of Getters and Setters is to GET the data from your 
        // class, the SETTER, SETS or ASSIGNS the data in your class.

        // Methods are simply Functions that are Members to a class / object
        // Methods are the "verbs" of your classes/ objects in OOP


        // a regular ol' PROPERTY, a property, you interact with your Getter
        // and setter.  
        public string Color 
        {

            // Setters will ASSIGN the classes PRIVATE data a value
            set
            {
                _color = value;
            }


            // Getters will GET PRIVATE data and PUBLICLY expose that
            // data to the caller of this PRoperty
            get
            {
                return _color;                
            }

        }

        // good practice dictates that we DO NOT PUBLICLY EXPOSE FIELDS
        // a field is a Variable that exist as a member to it's class / object
        private string _color; // this is just a private variable
        // this is a field ^^^


        public void FillBottle()
        {
            IsEmpty = false;
        }

        public void EmptyBottle()
        {
            IsEmpty = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourpillars
{
    public abstract class Animal
    {
        // protected members CAN be inherited, just not publicly exposed
        protected string _color; // not all fields will be interacted with your properties

        public Animal(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }


        // virtual members can be overritten, which means the child class can
        // keep the return type, name, AND parameters, but the child class
        // can completely change the body of it's function.  you can ONLY override
        // virtual methods.
        public virtual string MakeNoise()
        {
            return $"hey, my name is {Name}, and heres my animal noise.... what?";
        }

        // METHOD OVERLOADING is creating a Method with the SAME NAME, and SAME
        // RETURN TYPE, but different parameters and optionally different access
        // modifiers
        public virtual string MakeNoise(string backGroundNoise)
        {
            return $"{this.MakeNoise()}, also I have some background noise behind me, {backGroundNoise}";
        }

        public virtual void Eat()
        {
            // logic for eating food...
        }
    }


    // YOU CAN ONLY INHERIT FROM ONE CLASS
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public bool IsMansBestFriend { get; set; }

        public override string MakeNoise()
        {
            return "Bark!";
        }
    }

    // cat is inheriting from Animal
    public class Cat : Animal
    {
        // If a child class inherits a parent class that contains
        // a contructor with parameters, the child class ALSO needs
        // to call the parents contructor.  the syntax below is simply
        // creating a Cat constructor with a parameter, then PASSING that 
        // parameter to it's parents constructor.
        public Cat(string name) : base(name)
        {

        }

        public int Lives { get; set; } // ... cats have nine livs... lol..... okay whatever

        // YOu can Override virtual members from your parent class, by doing so, you keep
        // the same return type, parameters and name, however, you can completely change
        // the body of the method.
        public override string MakeNoise()
        {
            return "meow";
        }

        string GetColorMessage()
        {
            // the base keyword REFERS to the parent class' version of
            // it's members. so the make noise here will be whatever is defined
            // in the method make noise in the Animal class, NOT THIS Cat cass
            string message = base.MakeNoise();

            return $"oooo, I'm a cat and I'm this {_color}, I have {this.Lives} left, and my name is {base.Name}";
        }
    }


    // when a grand child class inherits from it's parent, the grandchild
    // class does NOT know about it's grand parent.  so when Tabby
    // inherits from Cat, it ONLY takes what Cat has as non private members.
    // this just so happens to include Cat's inherited properties, ie. Name
    public class Tabby : Cat
    {
        public Tabby(string name) : base(name)
        {
            
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override string MakeNoise()
        {
            return base.MakeNoise();
        }

        public bool IsSassy { get; set; }
    }


    public class Mouse : Animal
    {
        public Mouse(string name) : base(name)
        {

        }

        public override string MakeNoise()
        {
            return "Squeek!";
        }
    }

}

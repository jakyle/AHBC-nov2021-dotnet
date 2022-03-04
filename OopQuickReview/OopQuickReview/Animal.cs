using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopQuickReview
{
    public class Animal
    {
        int _age;
        public int Age 
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public string Name { get; set; }


        public Animal(int age, string name)
        {
            _age = age;
            Name = name;
        }

        public string GetAgeMessage()
        {
            return $"I am {AddAge(_age)} years old";
        }

        public void DoubleAge()
        {
            GetAgeMessage();
            _age = _age * 2;
        }

        private static int AddAge(int age)
        {
            return age + 1;
        }
    }



    public class Dog : Animal
    {
        public Dog(int age, string name) : base(age, name)
        {
        }
    }

    public class Cat : Animal
    {
        public Cat(int age, string name) : base(age, name)
        {
        }
    }
}

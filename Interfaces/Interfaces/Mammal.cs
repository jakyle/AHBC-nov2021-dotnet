using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class Mammal
    {
        private string _name;
        
        public string Name 
        { 
            get
            {
                return _name;
            }
            set
            {
                this._name = value;
            } 
        }

        public abstract string MakeNoise();

        public void Run()
        {
            //.... NSFW
        }
    }

    public class Human : Mammal // inhertence describes a "is a" relationship
    {
        public override string MakeNoise()
        {
            return "sup";
        }
    }

    public class cat : Mammal
    {
        public override string MakeNoise()
        {
            return "Meow";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{

    public interface ICrawl
    {
        void Crawl();
    }

    public interface IWalk
    {
        void Walk();
    }

    public interface IRun
    {
        void Run();
    }

    public interface IMove : IWalk, IRun, ICrawl
    {

    }

    public interface IRunWalk : IWalk, IRun
    {

    }


    /// Inteface Segration... your interface should define one method only ... and thats it,
    ///  this avoids having your classes implementing methods that it does NOT need, and you 
    ///  should NOT force your class to behave in a way that it was never intedned to behave like.d
    public class Dog : IMove
    {
        public void Crawl()
        {
            // a dog can crawl
        }

        public void Run()
        {
            // a dog can run
        }

        public void Walk()
        {
            // a dog can walk
        }
    }


    public class Sloth : ICrawl
    {
        public void Crawl()
        {
            // a sloth can crawl
        }

    }
}

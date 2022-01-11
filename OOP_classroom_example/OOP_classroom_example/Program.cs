using System;

namespace OOP_classroom_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RoomCalcApplication app = new RoomCalcApplication();
                app.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

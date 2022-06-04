using System;
using System.Linq;

namespace SQLite_EF
{
    internal class Program
    {
        private static void Main()
        {
            using var db = new GameContext();
            
            db.Database.EnsureCreated();

            db.Add(new Platform() { PlatformName = "TestP1" });


            //var PlatformID = db.Platforms.Where(x => x.PlatformName == "TestP1");
            var PlatformID = db.Platforms.Select(x => x.PlatformName == "TestP1");
            Console.WriteLine(PlatformID);

            var g = new Game
            {
                Title = "Test1"
                //PlatformID = PlatformID
            };
        }
    }
}
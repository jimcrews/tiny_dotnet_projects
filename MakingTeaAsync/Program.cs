using System;
using System.Threading.Tasks;

namespace MakingTeaAsync
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var tea = await MakeTeaAsync();
            System.Console.WriteLine($"here is your {tea}");
        }

        static async Task<string> MakeTeaAsync()
        {
            var boilWater = BoilWaterAsync();
            System.Console.WriteLine("Take the cups out");
            System.Console.WriteLine("Put Tea bag into cups");
            var boilingWater = await boilWater;
            System.Console.WriteLine($"Pour {boilingWater} into cups");
            return "tea";
        }

        static async Task<string> BoilWaterAsync()
        {
            System.Console.WriteLine("Start the Kettle");
            await Task.Delay(7000);
            System.Console.WriteLine("Kettle finished boiling");
            return "boiling water";
        }
    }
}

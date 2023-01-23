using System;

namespace DemoNetCoreDesignPattern.BuilderPattern
{
    public class App
    {
        public static void Run()
        {
            var macbookProBuilder = new MacbookProBuilder();
            var macBookSeller = new MacBookSeller(macbookProBuilder);
            Console.WriteLine(macBookSeller
                .LowSpec()
                .ToString());
            Console.WriteLine(macBookSeller
                .HighSpec()
                .ToString());
            Console.WriteLine(macbookProBuilder
                .BuildCPU(new Processor("9.0GHz Intel Core i9"))
                .BuildMemory(new Memory(32))
                .BuildGraphics(new Graphics("Radeon Pro 880X 8GB"))
                .BuildStorage(new Storage(1024))
                .BuildKeyboard(new Keyboard("English"))
                .Build()
                .ToString());
        }
    }
}

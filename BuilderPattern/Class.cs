using System;

namespace DemoNetCoreDesignPattern.BuilderPattern
{
    internal class MacbookPro
    {
        public Processor? Processor { get; set; }
        public Memory? Memory { get; set; }
        public Storage? Storage { get; set; }
        public Graphics? Graphics { get; set; }
        public Keyboard? Keyboard { get; set; }
        public override string ToString() => 
        $@"
            Processor:[{Processor!.GetName()}]
            Memory:[{Memory!.GetSize()}]
            Storage:[{Storage!.GetSize()}]
            Graphics:[{Graphics!.GetName()}]
            Keyboard:[{Keyboard!.GetName()}]
        ";
    }
    internal class Processor
    {
        private readonly string _name;
        public Processor(string name)
        {
            _name = name;
        }
        public string GetName() => _name;
    }

    internal class Memory
    {
        private readonly int _size;
        public Memory(int size)
        {
            _size = size;
        }
        public int GetSize() => _size;
    }
    internal class Storage
    {
        private readonly int _size;
        public Storage(int size)
        {
            _size = size;
        }
        public int GetSize() => _size;
    }
    internal class Graphics
    {
        private readonly string _name;
        public Graphics(string name)
        {
            _name = name;
        }
        public string GetName() => _name;
    }
    internal class Keyboard
    {
        private readonly string _name;
        public Keyboard(string name)
        {
            _name = name;
        }
        public string GetName() => _name;
    }
    internal interface IMacbookProBuilder
    {
        public IMacbookProBuilder BuildCPU(Processor processor);
        public IMacbookProBuilder BuildMemory(Memory size);
        public IMacbookProBuilder BuildGraphics(Graphics name);
        public IMacbookProBuilder BuildStorage(Storage size);
        public IMacbookProBuilder BuildKeyboard(Keyboard language);
        public MacbookPro Build();
    }
    internal class MacbookProBuilder : IMacbookProBuilder
    {
        protected readonly MacbookPro _macbookPro;
        public MacbookProBuilder()
        {
            _macbookPro = new MacbookPro();
        }
        public IMacbookProBuilder BuildCPU(Processor processor) 
        {
            _macbookPro.Processor = processor;
            return this;
        }
        public IMacbookProBuilder BuildMemory(Memory memory) 
        {
            _macbookPro.Memory = memory;
            return this;
        }
        public IMacbookProBuilder BuildGraphics(Graphics graphics) 
        {
            _macbookPro.Graphics = graphics;
            return this;
        }
        public IMacbookProBuilder BuildStorage(Storage storage) 
        {
            _macbookPro.Storage = storage;
            return this;
        }
        public IMacbookProBuilder BuildKeyboard(Keyboard kyboard) 
        {
            _macbookPro.Keyboard = kyboard;
            return this;
        }
        public MacbookPro Build() => _macbookPro;
    }
    internal class MacBookSeller
    {
        private readonly IMacbookProBuilder _macbookProBuilder;
        public MacBookSeller(IMacbookProBuilder macbookProBuilder)
        {
           _macbookProBuilder = macbookProBuilder;
        }
        public MacbookPro LowSpec() => _macbookProBuilder
            .BuildCPU(new Processor("5.0GHz Intel Core i5"))
            .BuildMemory(new Memory(8))
            .BuildGraphics(new Graphics("Radeon Pro 220X 2GB"))
            .BuildStorage(new Storage(256))
            .BuildKeyboard(new Keyboard("English"))
            .Build();
        public MacbookPro HighSpec() => _macbookProBuilder
            .BuildCPU(new Processor("7.0GHz Intel Core i7"))
            .BuildMemory(new Memory(16))
            .BuildGraphics(new Graphics("Radeon Pro 440X 4GB"))
            .BuildStorage(new Storage(512))
            .BuildKeyboard(new Keyboard("English"))
            .Build();
    }
}

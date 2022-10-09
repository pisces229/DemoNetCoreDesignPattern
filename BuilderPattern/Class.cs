using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Processor:[{this.Processor!.GetName()}]
            Memory:[{this.Memory!.GetSize()}]
            Storage:[{this.Storage!.GetSize()}]
            Graphics:[{this.Graphics!.GetName()}]
            Keyboard:[{this.Keyboard!.GetName()}]
        ";
    }
    internal class Processor
    {
        private readonly string _name;
        public Processor(string name)
        {
            this._name = name;
        }
        public string GetName() => this._name;
    }

    internal class Memory
    {
        private readonly int _size;
        public Memory(int size)
        {
            this._size = size;
        }
        public int GetSize() => this._size;
    }
    internal class Storage
    {
        private readonly int _size;
        public Storage(int size)
        {
            this._size = size;
        }
        public int GetSize() => this._size;
    }
    internal class Graphics
    {
        private readonly string _name;
        public Graphics(string name)
        {
            this._name = name;
        }
        public string GetName() => this._name;
    }
    internal class Keyboard
    {
        private readonly string _name;
        public Keyboard(string name)
        {
            this._name = name;
        }
        public string GetName() => this._name;
    }
    internal abstract class MacbookProBuilder
    {
        protected readonly MacbookPro _macbookPro;
        public MacbookProBuilder()
        {
            _macbookPro = new MacbookPro();
        }
        public abstract MacbookProBuilder BuildCPU(Processor processor);
        public abstract MacbookProBuilder BuildMemory(Memory size);
        public abstract MacbookProBuilder BuildGraphics(Graphics name);
        public abstract MacbookProBuilder BuildStorage(Storage size);
        public abstract MacbookProBuilder BuildKeyboard(Keyboard language);
        public MacbookPro Build() => this._macbookPro;
    }
    internal class MacbookProBuilderNow : MacbookProBuilder
    {
        public MacbookProBuilderNow() : base() {}
        public override MacbookProBuilder BuildCPU(Processor processor) 
        {
            this._macbookPro.Processor = processor;
            return this;
        }
        public override MacbookProBuilder BuildMemory(Memory memory) 
        {
            this._macbookPro.Memory = memory;
            return this;
        }
        public override MacbookProBuilder BuildGraphics(Graphics graphics) 
        {
            this._macbookPro.Graphics = graphics;
            return this;
        }
        public override MacbookProBuilder BuildStorage(Storage storage) 
        {
            this._macbookPro.Storage = storage;
            return this;
        }
        public override MacbookProBuilder BuildKeyboard(Keyboard kyboard) 
        {
            this._macbookPro.Keyboard = kyboard;
            return this;
        }
        public new MacbookPro Build() => base.Build();
    }
    internal class MacBookSeller
    {
        private readonly MacbookProBuilder _macbookProBuilder;
        public MacBookSeller(MacbookProBuilder macbookProBuilder)
        {
            this._macbookProBuilder = macbookProBuilder;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.PATRONES
{
    public abstract class Component
    {
        public string Name { get; set; }

        protected Component(string name) => Name = name;

        public abstract void Display(int depth);
    }

    public class Leaf : Component
    {
        public Leaf(string name) : base(name) { }

        public override void Display(int depth) =>
            Console.WriteLine(new string('-', depth) + Name);
    }

    public class Composite : Component
    {
        private List<Component> _children = new List<Component>();

        public Composite(string name) : base(name) { }

        public void Add(Component component) => _children.Add(component);

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
            foreach (var child in _children)
                child.Display(depth + 2);
        }
    }

}

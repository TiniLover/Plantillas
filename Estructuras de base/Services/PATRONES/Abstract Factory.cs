using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.PATRONES
{
    public interface IButton
    {
        void Paint();
    }

    public interface ICheckbox
    {
        void Paint();
    }

    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }

    public class WinFactory : IGUIFactory
    {
        public IButton CreateButton() => new WinButton();
        public ICheckbox CreateCheckbox() => new WinCheckbox();
    }

    public class MacFactory : IGUIFactory
    {
        public IButton CreateButton() => new MacButton();
        public ICheckbox CreateCheckbox() => new MacCheckbox();
    }

    public class WinButton : IButton
    {
        public void Paint() => Console.WriteLine("Rendering Windows Button");
    }

    public class WinCheckbox : ICheckbox
    {
        public void Paint() => Console.WriteLine("Rendering Windows Checkbox");
    }

    public class MacButton : IButton
    {
        public void Paint() => Console.WriteLine("Rendering Mac Button");
    }

    public class MacCheckbox : ICheckbox
    {
        public void Paint() => Console.WriteLine("Rendering Mac Checkbox");
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismOverriding;
internal class Parent
{
    public void Show() => Console.WriteLine("Parent Show");
    public virtual void Display() => Console.WriteLine("Parent Display");
    
}

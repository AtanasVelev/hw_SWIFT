using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_4
{
//  memory clearance steps: 1.When GC sees that there are no reference to certain object it clears it.
//2.IF object has destructor with additional implementation, before GC cleans the object, it should first call the destructor
//disposables: IF object is IDisposable, it should be used with using(var a = new DisposableClass()), or Dispose method should be called explicitly
// 3.IF you are creating disposable class, you should keep in mind that the user of your class can forget to put it in "using" or forget to 
// call "Dispose", so you can write the class to be more safe.Add destructor(~DisposableClass) which calls internally "Dispose" method.
// 4.IF you add destructor and the user of your class use it properly, Dispose method will be called firstly after the end of "using statement" or 
// when called explicitly and second time when destructor is called.That's why in the end of destructor call "GC.SupressFinalize" to 
// prevent calling destructor if "Dispose" method is already called.
    public class Test : IDisposable
    {
        private List<string> names;

        public Test()
        {
            this.names = new List<string>();
        }

        ~Test()
        {
            this.Dispose();
        }

        public void Dispose()
        {
            this.names.Clear();
            GC.SuppressFinalize(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fody_Example
{
    public class TestViewModel : PropertyChangedBase
    {
        public string Name { get; set; }


        public TestViewModel()
        {

        }

        public void ChangeName(string name)
        {
            Name = name;
        }
    }
}

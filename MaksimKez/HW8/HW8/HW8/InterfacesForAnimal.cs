using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    internal interface IHaveName
    {
        string Name { get; set; }
    }
    internal interface INameSettable
    {
        void SetName(string name);
    }
    internal interface INameGettable
    {
        string GetName();
    }
    internal interface IEatable
    {
        void Eat();
    }
}

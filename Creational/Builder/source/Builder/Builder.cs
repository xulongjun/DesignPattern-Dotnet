using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// The 'Builder' abstract class
    /// </summary>
    public abstract class Builder
    {
        public Product ProductObject { get; set; } = new();
        public abstract void BuildPartA();
        public abstract void BuildPartB();
    }

    /// <summary>
    /// The 'ConcreteBuilder1' class
    /// </summary>
    class ConcreteBuilder1 : Builder
    {
        public override void BuildPartA()
        {
            ProductObject.Add("PartA");
        }
        public override void BuildPartB()
        {
            ProductObject.Add("PartB");
        }
    }

    /// <summary>
    /// The 'ConcreteBuilder2' class
    /// </summary>
    class ConcreteBuilder2 : Builder
    {
        public override void BuildPartA()
        {
            ProductObject.Add("PartX");
        }
        public override void BuildPartB()
        {
            ProductObject.Add("PartY");
        }
    }
}

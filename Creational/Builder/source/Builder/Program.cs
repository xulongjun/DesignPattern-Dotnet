// Create director and builders
using Builder;

Builder.Builder b1 = new ConcreteBuilder1();
Builder.Builder b2 = new ConcreteBuilder2();
// Construct two products
Director.Construct(b1);
b1.ProductObject.Show();
Director.Construct(b2);
b2.ProductObject.Show();
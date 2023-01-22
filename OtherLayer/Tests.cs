using System;
using OtherLayer.Encapsulation;

namespace OtherLayer
{
	public class Tests
	{
		public Tests()
		{
			var animal = new Animal();
			animal.Sleep();

            var dog = new Dog();
            dog.Sleep();
        }
	}
}


using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Adv1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Q1: What is a generic class? Why use generics?
            //Ans:
            //  A generic class is a class that can work with different data types using a type parameter(like T).

            //  Why use Generics?

            //  To reuse the same code for different data types.
            //  To make the code safer and more flexible.

            #endregion
            #region Q2
            //Q2: Write a generic class Container<T> with Add and Get methods.
            //Container<int> c1 = new Container<int>();
            //c1.Add(1);
            //Console.WriteLine(c1.Get());
            #endregion
            #region Q3
            //Q3:What are multiple type parameters? Write Pair<TKey, TValue>.

            //They allow a generic class to use more than one data type.

            #endregion
            #region Q4
            //Q4: What is a generic method? Write Swap<T> method.

            //A generic method is a method that works with different data types using a type parameter.
            //static void Swap<T>(ref T a, ref T b)
            //{
            //    T temp = a;
            //    a = b;
            //    b = temp;
            //}
            #endregion
            #region Q5
            //Q5: Write a generic method FindMax<T> that finds maximum value

            //static T FindMax<T> (T a , T b) where T : IComparable<T>
            //{
            //    if (a.CompareTo(b) > 0)
            //        return a;
            //    else
            //        return b;
            //}
            #endregion
            #region Q6
            //Q6: What is a generic interface? Write IRepository<T>. 
            //A generic interface works with different data types.
            #endregion
            #region Q7
            //Q7: What is the 'struct' constraint? Write an example.
            //Used when the type must be a value type.

            //    class ValueBox<T> where T : struct
            //    {
            //    public T Value;
            //    }
            #endregion
            #region Q8
            //Q8: What is the 'class' constraint? Write an example.
            //Used when the type must be a reference type.
            //class RefBox<T> where T : class
            //{
            //public T Value;
            //}
            #endregion
            #region Q9
            //Q9: What is the 'new()' constraint? Write an example.
            //Requires a parameterless constructor.

            //class Creator<T> where T : new()
            //{
            //public T Create()
            //{
            //    return new T();
            //}
            //}
            #endregion
            #region Q10
            //Q10:  What is the interface constraint? Write an example.
            //Limits the type to classes that implement an interface.

            //class Printer<T> where T : IComparable
            //{
            //public void Print(T value)
            //{
            //    Console.WriteLine(value);
            //}
            //}
            #endregion
            #region Q11
            //Q11: What is the base class constraint? Write an example.
            //Limits the type to classes that inherit from a base class.

            //class Animal { }

            //class Cage<T> where T : Animal
            //{
            //public T animal;
            //}
            #endregion
            #region Q12
            //Q12: How do you apply multiple constraints? Write an example. 
            //You can combine constraints.

            //class Example<T> where T : class, IComparable, new()
            //{
            //public T Create()
            //{
            //    return new T();
            //}
            //}
            #endregion
            #region Q13
            //Q13: What does the 'default' keyword do in generics?
            //default returns the default value of a type.

            //0 for numbers
            //false for bool
            //null for reference types
            #endregion
            #region Q14
            //Q14: Write a SafeList<T> that returns default when the index is invalid.
            //SafeList<int> numbers = new SafeList<int>();
            //numbers.Add(10);
            //numbers.Add(20);
            //Console.WriteLine(numbers.Get(0)); // 10
            //Console.WriteLine(numbers.Get(1)); // 20
            //Console.WriteLine(numbers.Get(5)); // default value (0)
            #endregion
            #region Q15
            //Q15: What is covariance? Explain the 'out' keyword.
            //Covariance allows using a more derived type.

            //out means the type is output only.
            #endregion
            #region Q16
            //Q16: What is contravariance? Explain the 'in' keyword.
            //Contravariance allows using a less derived type.

            //in means the type is input only.
            #endregion
            #region Q17
            //Q17: What is the difference between covariance and contravariance?

            //Covariance : Uses out , Used for return types ,Derived type allowed
            //Contravariance : Uses in , Used for parameters , Base type allowed
            #endregion
            #region Q18
            //Q18: How do static members work in generic types?
            // Each type parameter gets its own static member.

            // Example:

            //MyClass<int> has its own static field

            //MyClass<string> has another one
            #endregion
            #region Q19
            //Q19: How can you inherit from a generic class?
            //class Base<T>
            //{
            //public T data;
            //}

            //class Child<T> : Base<T>
            //{
            //}
            #endregion
            #region Q20
            //Q20: Complete Exercise - Create a generic Cache<TKey, TValue>with Add, Get, Remove, Contains, and expiration support. 
            //Cache<int, string> cache = new Cache<int, string>();

            //cache.Add(1, "Apple", 60);

            //Console.WriteLine(cache.Get(1));   // Apple
            //Console.WriteLine(cache.Contains(1)); // True

            //cache.Remove(1);

            //Console.WriteLine(cache.Contains(1)); // False
            #endregion
        }
    }
}

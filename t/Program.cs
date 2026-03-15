using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace t
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //A generic class is a class that uses type parameters to allow it to work with different data types.
            //Generics are used to achieve code reusability, type safety, and better performance by avoiding casting and boxing/unboxing.
            #endregion
            #region Q2
            //    public class Container<T>
            //{
            //    private T _item;

            //    public void Add(T item)
            //    {
            //        _item = item;
            //    }

            //    public T Get()
            //    {
            //        return _item;
            //    }
            //}
            #endregion
            #region Q3
            //They are generics that take multiple type parameters.

            //    public class pair<TKey, Tvalue>
            //{
            //    public TKey Key { get; set; }
            //    public Tvalue Value { get; set; }
            //    public pair(TKey _key, Tvalue _value)
            //    {
            //        Key = _key;
            //        Value = _value;
            //    }

            //}
            #endregion
            #region Q4
            //A generic method is a method that uses type parameters
            //so it can work with different data types without rewriting the method.
            //public static void swap<T>(ref T a, ref T b)
            //{
            //    T temp = a;
            //    a = b;
            //    b = temp;

            //}
            #endregion
            #region Q5
            //public static T FindMax<T>(T a, T b) where T : IComparable<T>
            //{
            //    if (a.CompareTo(b) > 0)
            //        return a;
            //    else
            //        return b;
            //}
            #endregion
            #region Q6
            //A generic interface is an interface that uses type parameters so it can work with different data types.
            //    public interface IRepository<T>
            //{
            //    void Add(T entity);
            //    T GetById(int id);
            //    IEnumerable<T> GetAll();
            //    void Remove(T entity);
            //}
            #endregion
            #region Q7
            //The struct constraint restricts a generic type parameter so it can only accept value types(structs).
            //    public class ValueContainer<T> where T : struct
            //{
            //    public T Value { get; set; }

            //    public ValueContainer(T value)
            //    {
            //        Value = value;
            //    }
            //}
            #endregion
            #region Q8
            //The class constraint restricts a generic type parameter so it can only accept reference types.
        //    public class Repository<T> where T : class
        //{
        //    public T Entity { get; set; }

        //    public void Save(T entity)
        //    {
        //        Entity = entity;
        //    }
        //}
        #endregion
        #region Q9

        #endregion
        #region Q10

        #endregion
        #region Q11

        #endregion
        #region Q12

        #endregion
        #region Q13

        #endregion
        #region Q14

        #endregion
        #region Q15

        #endregion
        #region Q16

        #endregion
        #region Q17

        #endregion
        #region Q18

        #endregion
        #region Q19

        #endregion
        #region Q20

        #endregion
        #region Q21

        #endregion
        #region Q22

        #endregion
    }
    }
}

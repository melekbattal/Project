using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> municipalities = new List<string>();
            municipalities.Add("Buyuksehir Belediyesi");
            Console.WriteLine(municipalities.Count);

            MyDictionary<string> municipalities2 = new MyDictionary<string>();
            municipalities2.Add("Kadıköy Belediyesi");
            municipalities2.Add("Şişli Belediyesi");
            municipalities2.Add("Bakırköy Belediyesi");
            municipalities2.Add("Beyoğlu Belediyesi");
            municipalities2.Add("Beşiktaş Belediyesi");
            Console.WriteLine(municipalities2.Count);
            
        }
    }
}
class MyDictionary<T> //Generic class
{
    T[] _array;
    T[] _tempArray;
    public MyDictionary()
    {
        _array = new T[0];


    }
    public void Add(T item)
    {
        _tempArray = _array;
        _array = new T[_array.Length+1];

        for (int i = 0; i <_tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }
        _array[_array.Length - 1] = item;
    }
    

    public int Count
    {
        get { return _array.Length; }
        
    }


}

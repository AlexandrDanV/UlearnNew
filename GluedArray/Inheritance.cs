using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GluedArray
{
    internal class Inheritance
    {
        internal static class GluinArray
        {
            public static Array Combine(params Array[] myArray)
            {
                if (myArray == null)
                    return null;

                if (myArray.Length == 1)
                {
                    var list = new List<object>();

                    foreach (var item in myArray)
                    {
                        foreach (var el in item)
                        {
                            list.Add(el);
                        }
                    }
                    return list.ToArray();
                }

                if (myArray.Length > 1)
                {
                    var isSameType = false;
                    for (int i = 0; i < myArray.Length - 1; i++)
                    {
                        isSameType = (myArray[i].GetType().GetElementType() == myArray[i + 1].GetType().GetElementType()) ? true : false;
                    }
                    if (isSameType is true)
                    {
                        var list = new List<object>();
                        foreach (var array in myArray)
                        {
                            foreach (var item in array)
                            {
                                list.Add(item);
                            }
                        }
                        return list.ToArray();
                    }
                }
                return null;
            }

            public static void Print(Array array)
            {
                if (array == null)
                {
                    Console.WriteLine("null");
                    return;
                }
                for (int i = 0; i < array.Length; i++)
                    Console.Write("{0} ", array.GetValue(i));
                Console.WriteLine();
            }
        }
    }
}

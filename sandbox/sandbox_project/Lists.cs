using System;
using System.Collections.Generic;

public class Lists
{
    public static void Testlist()
    {
        var numbers = new int[3];

        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        Console.WriteLine(numbers[0]);

        var cifras = new List<int>();

        cifras.Add(1);
        cifras.Add(2);
        cifras.Add(3);
        Console.WriteLine(cifras[2]);

        /*Common Dynamic Array Operation	Description	C# Code
lookup(index)	Gets the value at the specific index.	value = myList[index]
append(value)	Adds "value" to the next available index.	myList.Add(value)
insert(index, value)	Adds "value" to the specified index and moves subsequent items to the next index.	myList.Insert(index, value)
remove(index)	Removes the item at the specified index and moves subsequent items to the previous index.	myList.Remove(index)
size()	Return the size of the dynamic array.	myList.Count
capacity()	Return the capacity of the dynamic array.	myList.Capacity
empty()	Returns true if the length of the dynamic array is zero.	myList.Count == 0*/
    }
}
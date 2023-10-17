
}
using System;
using System.Collections.Generic;

class Class1
{
    static void Main()
    {
        // Array
        string[] myArray = { "value1", "value2", "value3" };

        // Loop (break/continue)
        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] == "condition1")
            {
                Console.WriteLine("Found condition1, breaking loop");
                break; // Break the loop and exit
            }

            if (myArray[i] == "condition2")
            {
                Console.WriteLine("Found condition2, continuing to the next iteration");
                continue; // Continue to the next iteration
            }

            Console.WriteLine(myArray[i]);
        }

        // Add/Remove/Get/Set/Check the existence of value
        var myList = new List<string>(myArray);
        myList.Add("value4"); // Add a new element to the end of the list
        myList.RemoveAt(myList.Count - 1); // Remove the last element from the list
        myList.Insert(0, "newElement"); // Add a new element to the beginning of the list
        myList.RemoveAt(0); // Remove the first element from the list
        string x = myList[0]; // Get an element by index
        myList[1] = "something else"; // Set the value of the element at index 1
        bool isPresent = myList.Contains("value1"); // Check if an element exists in the list
        int valueIndex = myList.IndexOf("value1"); // Find the index of an element in the list

        // List
        LinkedList<string> linkedList = new LinkedList<string>();
        linkedList.AddLast("value1");
        linkedList.AddLast("value2");
        linkedList.AddLast("value3");

        // Loop (break/continue)
        foreach (var current in linkedList)
        {
            // Loop through the linked list
        }

        // Add/Remove/Get/Set/Check the existence of value
        linkedList.AddLast("newValue");
        linkedList.Remove("value2");

        // Dictionary (Using Dictionary<TKey, TValue>)
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        // Loop (break/continue)
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        // Add/Remove/Get/Set/Check the existence of key
        dictionary["key1"] = "value1"; // Add key-value pairs
        dictionary.Remove("key1"); // Remove a key-value pair
        string valueFromDictionary;
        bool hasKey = dictionary.TryGetValue("key1", out valueFromDictionary); // Check if a key exists

        // Sorted List (Using List<T>)
        List<int> sortedList = new List<int>();

        // Loop (break/continue)
        foreach (var item in sortedList)
        {
            // Loop through the sorted list
        }

        // Add/Remove/Get/Set/Check the existence of value
        sortedList.Add(42);
        sortedList.Remove(42);

        // HashSet
        HashSet<int> mySet = new HashSet<int>();

        // Loop (break/continue)
        foreach (var value in mySet)
        {
            // Loop through the set
        }

        // Add/Remove/Check the existence of value
        mySet.Add(1); // Add elements to the set
        mySet.Remove(2); // Remove elements from the set
        bool hasTwo = mySet.Contains(2); // Check if an element exists

        // SortedSet
        SortedSet<int> sortedSet = new SortedSet<int>();

        // Loop (break/continue)
        foreach (var value in sortedSet)
        {
            // Loop through the sorted set
        }

        // Add/Remove/Check the existence of value
        sortedSet.Add(3);
        sortedSet.Remove(2);

        // Queue (Using Queue<T>)
        Queue<int> queue = new Queue<int>();

        // Loop (break/continue)
        foreach (var item in queue)
        {
            // Loop through the queue
        }

        // Add/Remove/Check the existence of value
        queue.Enqueue(1); // Enqueue (add to the back)
        int removedElement = queue.Dequeue(); // Dequeue (remove from the front)

        // Stack (Using Stack<T>)
        Stack<int> stack = new Stack<int>();

        // Loop (break/continue)
        foreach (var item in stack)
        {
            // Loop through the stack
        }

        // Add/Remove/Check the existence of value
        stack.Push(1); // Push (add to the end)
        int poppedElement = stack.Pop(); // Pop (remove from the end)
    }
}

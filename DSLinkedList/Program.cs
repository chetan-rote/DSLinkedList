/******************************************************************************
 *  Purpose: Determines whether or not n is prime.
 *
 *
 *  @author  Chetan Rote
 *  @version 1.0
 *  @since   06-11-2020
 ******************************************************************************/
using System;
using System.Collections.Generic;

namespace DSLinkedList
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Linked List.");
            ///UC1 Create Linked List
            LinkedList linkedList = new LinkedList();
            ///Inserting elements to Linked list.
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            Console.WriteLine("Values in Linked List:-");
            linkedList.Display();
            Console.WriteLine("\n");
            Console.WriteLine("Enter the element to be searched");
            int data = Convert.ToInt32(Console.ReadLine());

            int position = linkedList.Search(data);
            if (position == 0)
            {
                Console.WriteLine("No such element found");
            }
            else
            {
                Console.WriteLine("Element found at position " + position);
            }
        }
    }
}

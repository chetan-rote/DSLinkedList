/******************************************************************************
 *  Purpose: Determines whether or not n is prime.
 *
 *
 *  @author  Chetan Rote
 *  @version 1.0
 *  @since   06-11-2020
 ******************************************************************************/
using System;
using System.Drawing;

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
            SortedLinkedList sortedLinkedList = new SortedLinkedList();
            sortedLinkedList.AddElement(56);
            sortedLinkedList.AddElement(30);
            sortedLinkedList.AddElement(40);
            sortedLinkedList.AddElement(70);
            sortedLinkedList.Display();
        }
    }
}

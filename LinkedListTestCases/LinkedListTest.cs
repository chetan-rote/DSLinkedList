using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSLinkedList;

namespace LinkedListTestCases
{
    [TestClass]
    public class LinkedListTest
    {
        /// <summary>
        /// Givens the three numbers when added should be added to top.
        /// </summary>
        [TestMethod]
        public void GivenThreeNumbers_When_Added_ShouldBeAddedToTop()
        {
            ///Arrange
            LinkedList list = new LinkedList();
            ///Act
            list.Add(56);
            list.Add(30);
            list.Add(70);
            ///Assert
            Assert.AreEqual(56, list.head.data);
        }
        /// <summary>
        /// Givens the three numbers when appended should be added to last.
        /// </summary>
        [TestMethod]
        public void GivenThreeNumbers_When_Appended_ShouldBeAddedToLast()
        {
            ///Arrange
            LinkedList list = new LinkedList();
            ///Act
            list.Append(56);
            list.Append(30);
            list.Append(70);
            ///Assert
            Assert.AreEqual(56, list.head.data);
        }
        /// <summary>
        /// Givens the three numbers when inserting second in between should be added in between.
        /// </summary>
        [TestMethod]
        public void GivenThreeNumbers_WhenInsertingSecondInBetween_ShouldBeAddedInBetween()
        {
            ///Arrange
            LinkedList list = new LinkedList();
            ///Act
            list.Add(56);
            list.Add(70);
            list.InsertAtGivenPosition(2, 30);
            ///Assert
            Assert.AreEqual(30, list.head.next.data);
        }
        /// <summary>
        /// Givens the three numbers when delete first number should return required result.
        /// </summary>
        [TestMethod]
        public void GivenThreeNumbers_WhenDeleteFirstNumber_ShouldReturn_RequiredResult()
        {
            ///Arrange
            LinkedList list = new LinkedList();
            ///Act
            list.Add(56);
            list.Append(30);
            list.Append(70);
            Node head = list.Pop();
            ///Assert
            Assert.AreEqual(56, head.data);
        }
        /// <summary>
        /// Givens the three numbers when delete last number should return required result.
        /// </summary>
        [TestMethod]
        public void GivenThreeNumbers_WhenDeleteLastNumber_ShouldReturn_RequiredResult()
        {
            ///Arrange
            LinkedList list = new LinkedList();
            ///Act
            list.Append(56);
            list.Append(30);
            list.Append(70);
            ///Assert
            Node last = list.PopLast();

            Assert.AreEqual(70, last.data);
        }
        /// <summary>
        /// Givens the three numbers search number30 should return position.
        /// </summary>
        [TestMethod]
        public void GivenThreeNumbers_SearchNumber30_ShouldReturn_Position()
        {
            ///Arrange
            LinkedList list = new LinkedList();
            ///Act
            list.Append(56);
            list.Append(30);
            list.Append(70);
            int position = list.Search(30);
            ///Assert
            Assert.AreEqual(2, position);
        }
        /// <summary>
        /// Givens the three numbers delete40 should return required result.
        /// </summary>
        [TestMethod]
        public void GivenThreeNumbers_Delete40_ShouldReturn_RequiredResult()
        {
            ///Arrange
            LinkedList list = new LinkedList();
            ///Act
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.InsertNodeAfterParticularNode(40, 30);
            list.DeleteMiddleNode(40);
            int size = list.Size();
            ///Assert
            Assert.AreEqual(3, size);
        }
        /// <summary>
        /// Givens the numbers when added should be in ascending order.
        /// </summary>
        [TestMethod]
        public void GivenNumbers_WhenAdded_ShouldBeInAscendingOrder()
        {
            ///Arrange
            SortedLinkedList list = new SortedLinkedList();
            ///Act
            list.AddElement(56);
            list.AddElement(30);
            list.AddElement(40);
            list.AddElement(70);
            ///Assert
            Assert.AreEqual(30, list.head.data);
        }
    }
}

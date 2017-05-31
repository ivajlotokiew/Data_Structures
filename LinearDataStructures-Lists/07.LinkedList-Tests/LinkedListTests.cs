namespace _07.LinkedList_Tests
{
    using System;
    using System.Linq;
    using LinkedList;
    using LinkedList.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LinkedListTests
    {
        private ISimpleLInkedList<int> linkedList;

        [TestInitialize]
        public void TestInitialze()
        {
            this.linkedList = new SimpleLinkedList<int>();
        }

        [TestMethod]
        public void Count_AddElements_ShouldIncreaseCount()
        {
            this.linkedList.Add(5);
            this.linkedList.Add(5);
            this.linkedList.Add(5);
            this.linkedList.Add(5);

            Assert.AreEqual(4, this.linkedList.Count);
        }

        [TestMethod]
        public void Add_AddElement_ShouldAddElements()
        {
            this.linkedList.Add(1);
            this.linkedList.Add(2);
            this.linkedList.Add(3);

            var expextedResult = new[] { 1, 2, 3 };
            var currentLinkedList = this.linkedList.ToArray();

            CollectionAssert.AreEqual(expextedResult, currentLinkedList);
        }

        [TestMethod]
        public void Remove_ValidIndex_MoreThanOneElements_ShouldRemove()
        {
            this.linkedList.Add(1);
            this.linkedList.Add(2);
            this.linkedList.Add(3);

            this.linkedList.Remove(1);

            var expextedResult = new[] { 1, 3 };
            var currentLinkedList = this.linkedList.ToArray();

            CollectionAssert.AreEqual(expextedResult, currentLinkedList);
        }

        [TestMethod]
        public void Remove_IndexZero_MoreThanOneElements_ShouldRemove()
        {
            this.linkedList.Add(1);
            this.linkedList.Add(2);
            this.linkedList.Add(3);

            this.linkedList.Remove(0);

            var expextedResult = new[] { 2, 3 };
            var currentLinkedList = this.linkedList.ToArray();

            CollectionAssert.AreEqual(expextedResult, currentLinkedList);
        }

        [TestMethod]
        public void Remove_ValidIndex_OneElement_ShouldRemove()
        {
            this.linkedList.Add(1);

            this.linkedList.Remove(0);

            var expextedResult = new int[0];
            var currentLinkedList = this.linkedList.ToArray();

            CollectionAssert.AreEqual(expextedResult, currentLinkedList);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Remove_InvalidIndex_ShouldThrow()
        {
            this.linkedList.Remove(0);
        }

        [TestMethod]
        public void FistIndexOf_PresentedItem_ShouldReturnIndex()
        {
            this.linkedList.Add(0);
            this.linkedList.Add(1);
            this.linkedList.Add(2);
            this.linkedList.Add(1);

            var indexOf = this.linkedList.FirstIndexOf(1);

            Assert.AreEqual(1, indexOf);
        }

        [TestMethod]
        public void FistIndexOf_NotPresentedItem_ShouldReturnMinusOneIndex()
        {
            this.linkedList.Add(0);
            this.linkedList.Add(1);
            this.linkedList.Add(2);
            this.linkedList.Add(1);

            var indexOf = this.linkedList.FirstIndexOf(10);

            Assert.AreEqual(-1, indexOf);
        }

        [TestMethod]
        public void LastIndexOf_PresentedItem_ShouldReturnIndex()
        {
            this.linkedList.Add(0);
            this.linkedList.Add(1);
            this.linkedList.Add(2);
            this.linkedList.Add(1);

            var indexOf = this.linkedList.LastIndexOf(1);

            Assert.AreEqual(3, indexOf);
        }

        [TestMethod]
        public void LastIndexOf_NotPresentedItem_ShouldReturnMinusOneIndex()
        {
            this.linkedList.Add(0);
            this.linkedList.Add(1);
            this.linkedList.Add(2);
            this.linkedList.Add(1);

            var indexOf = this.linkedList.LastIndexOf(10);

            Assert.AreEqual(-1, indexOf);
        }
    }
}
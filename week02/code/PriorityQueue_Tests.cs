using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Several elements with different priorities are enqueued
    // Expected Result: The elements are displayed according to the order on which they were enqueued
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Blue", 1);
        priorityQueue.Enqueue("Green", 3);
        priorityQueue.Enqueue("Red", 2);

        Assert.AreEqual("[Blue (Pri:1), Green (Pri:3), Red (Pri:2)]", priorityQueue.ToString());
    }

    [TestMethod]
    // Scenario: Several elements with different priorities are enqueued
    // Expected Result: The elements are dequeued according to the priority
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("X", 5);
        priorityQueue.Enqueue("Y", 1);
        priorityQueue.Enqueue("Z", 5);
        priorityQueue.Enqueue("W", 3);

        Assert.AreEqual("X", priorityQueue.Dequeue());
        Assert.AreEqual("Z", priorityQueue.Dequeue());
        Assert.AreEqual("W", priorityQueue.Dequeue());
        Assert.AreEqual("Y", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue on an empty queue.
    // Expected Result: InvalidOperationException is thrown.
    // Defect(s) Found: 
    public void TestDequeueEmptyQueue()
    {
        var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}
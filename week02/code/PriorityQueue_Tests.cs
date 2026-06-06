using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add several items with different priorities.
    // Expected Result: The item with the highest priority should be removed first.
    // Defect(s) Found: The last item in the queue was not checked when searching for the highest priority.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 3);
        priorityQueue.Enqueue("Sue", 5);

        Assert.AreEqual("Sue", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add multiple items with the same highest priority.
    // Expected Result: The item closest to the front of the queue should be removed first (FIFO).
    // Defect(s) Found: None.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 2);

        Assert.AreEqual("Bob", priorityQueue.Dequeue());
        Assert.AreEqual("Tim", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Remove an item and verify it is actually removed from the queue.
    // Expected Result: The item should not remain in the queue after being dequeued.
    // Defect(s) Found: Dequeue returned the item but did not remove it from the queue.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 5);

        Assert.AreEqual("Bob", priorityQueue.Dequeue());

        Assert.ThrowsException<InvalidOperationException>(
            () => priorityQueue.Dequeue()
        );
    }

    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue.
    // Expected Result: InvalidOperationException with message "The queue is empty."
    // Defect(s) Found: None.
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
    }
}
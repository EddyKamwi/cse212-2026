using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add 3 People to the queue each with a different priority John 1, Peter 0, James 5
    // Expected Result: 1st Dequeue =  James because James has a highest priority
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("John", 1);
        priorityQueue.Enqueue("Peter", 0);
        priorityQueue.Enqueue("James", 5);

        var firstDeque = priorityQueue.Dequeue();
        Assert.AreEqual("James", firstDeque);
    }
    [TestMethod]
    // Scenario: Add 5 people, 2 with the same priority Peter 1,James 1,John 3 ,Matthews 3,Luke 0
    // Expected Result: 1st Dequeue =  John because John has a highest priority and is in first
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Peter", 1);
        priorityQueue.Enqueue("James", 1);
        priorityQueue.Enqueue("John", 3);
        priorityQueue.Enqueue("Matthews", 3);
        priorityQueue.Enqueue("Luke", 0);

        var firstDeque = priorityQueue.Dequeue();
        Assert.AreEqual("John", firstDeque);
    }

    // Add more test cases as needed below.
}
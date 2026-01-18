using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: Low Priority, Low Priority 2, Medium Priority, Medium Priority 2, Medium Priority 3, High Priority, High Priority 2
    // Defect(s) Found: The for loop should start with index = 0 to check since the first intem in te list in Dequeue method
    //The for loop should check if the i variable is higher or equal to _queue.Count - 1 in Dequeue method
    //The Dequeue method should remove the value returned from the _queue list.
    //The Enqueue method on PersonQueue class should use the mothod .add to add the back of the list.

    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low Priority", 3);
        priorityQueue.Enqueue("Low Priority 2", 3);
        priorityQueue.Enqueue("High Priority", 10);
        priorityQueue.Enqueue("High Priority 2", 10);
        priorityQueue.Enqueue("Medium Priority", 5);
        priorityQueue.Enqueue("Medium Priority 2", 5);
        priorityQueue.Enqueue("Medium Priority 3", 5);

        string[] expectedResult = [ "High Priority", "High Priority 2", "Medium Priority", "Medium Priority 2", "Medium Priority 3", "Low Priority", "Low Priority 2" ];

        //Assert.AreEqual(expectedResult.Length, 7);
        for (int i = 0; i < expectedResult.Length; i++)
        {
            var dequeuedValue = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], dequeuedValue);
        }
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: Didn't need a new test case, just needed to implement the first one correctly. 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        const string errors = "The queue is empty.";
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue(), errors);
    }

    // Add more test cases as needed below.
}
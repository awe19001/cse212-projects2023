﻿/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
         var priorityQueue = new PriorityQueue();
        Console.WriteLine("Initial Queue: " + priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Enqueue values with different priorities and dequeue them
        // Expected Result: Values should be dequeued in descending order of priority
        Console.WriteLine("\nTest 1");

        priorityQueue.Enqueue("Alice", 3);
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Charlie", 2);

        Console.WriteLine("After Enqueue: " + priorityQueue);
        Console.WriteLine("Dequeued: " + priorityQueue.Dequeue()); // Expected: Item1 (Pri:3)
        Console.WriteLine("Dequeued: " + priorityQueue.Dequeue()); // Expected: Item3 (Pri:2)
        Console.WriteLine("Dequeued: " + priorityQueue.Dequeue()); // Expected: Item2 (Pri:1)

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Try to dequeue from an empty queue
        // Expected Result: Message should be displayed saying the queue is empty
        Console.WriteLine("\nTest 2");

        Console.WriteLine("Dequeued: " + priorityQueue.Dequeue()); // Expected: The queue is empty.

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}
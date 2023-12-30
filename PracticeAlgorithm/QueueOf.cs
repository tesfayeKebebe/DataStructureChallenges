namespace PracticeAlgorithm;
public class QueueOf
{
    [Fact]
    public static void QueueImplementation()
    {
        var queue = new System.Collections.Generic.Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        string deQueueItem = null;
        while ((deQueueItem=queue.Dequeue()) != null)
        {
            Console.WriteLine(deQueueItem);
            if (queue.Count <= 0) break;
        }
    }
}
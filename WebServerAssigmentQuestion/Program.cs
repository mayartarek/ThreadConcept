// See https://aka.ms/new-console-template for more information
 Queue<string?> inputQueue = new Queue<string?>();
Thread thread = new Thread(() =>enqueueInput());
thread.Start();
Console.WriteLine("Hello, World!");
while (true)
{
    string? input = Console.ReadLine();
    if(input?.ToLower() == "exist")
    {
       break;
    }
    inputQueue.Enqueue(input);
}
 void enqueueInput()
{
    while (true)
    {
        if(inputQueue.Count > 0) 
        {
            string input = inputQueue.Dequeue();
            var task = new Thread(() => ProcessInput(input));
            task.Start();
        }
      
    }
}
 static void ProcessInput(string input)
{
    Thread.Sleep(1000); // Simulate a delay in processing
    // Simulate processing the input
    Console.WriteLine($"Processing input: {input}");
}

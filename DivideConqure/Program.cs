// This code calculates the sum of an array using a foreach loop and measures the time taken to perform the operation.
//the THREad divide  conquer method is used to divide the work of summing the array into smaller parts that can be executed
//concurrently, which can improve performance for large arrays. However, in this example, we are using a simple foreach loop to calculate the sum of a small array and measure the time taken for the operation.
int[] array = {
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
};
int sum = 0;    
var watch =new System.Diagnostics.Stopwatch(); 
watch.Start();
foreach (var item in array)
{ 
    Thread .Sleep(100);
    sum += item;    
}
watch.Stop();
Console.WriteLine($"Time taken for sum using foreach: {watch.ElapsedMilliseconds} ms");
Console.WriteLine(sum);
DivideAndConquerSum(array);
void DivideAndConquerSum(int[] arr)
{

    int sum = 0; 
    int sum2 = 0;
    int sum3 = 0;   
    int sum4 = 0;
    int threadNo=4; // Number of threads to use
    int segmentSize = arr.Length / threadNo; // Size of each segment    
    Thread[] threads = new Thread[threadNo];
    threads[0] = new Thread(() => sum = CalculateSum(arr, 0, segmentSize));
    threads[1] = new Thread(() => sum2= CalculateSum(arr, segmentSize, 2 * segmentSize));
    threads[2] = new Thread(() => sum3 += CalculateSum(arr, 2 * segmentSize, 3 * segmentSize));
    threads[3] = new Thread(() => sum4 += CalculateSum(arr, 3 * segmentSize, arr.Length));
   Console.WriteLine();
    var watch = new System.Diagnostics.Stopwatch();
    watch.Start();
    foreach (var thread in threads)
    {
        thread.Start();
    }
    foreach (var item in threads)
    {
        item.Join();
    }
    watch.Stop();
    Console.WriteLine($"Time taken for sum using divide and conquer: {watch.ElapsedMilliseconds} ms");
    Console.WriteLine(sum + sum2 + sum3 + sum4);

}
int CalculateSum(int[] arr, int start, int end) 
{
    int sum = 0;
    for (int i = start; i < end; i++)
    {
        Thread.Sleep(100);
        sum += arr[i];
    }
    return sum;
}

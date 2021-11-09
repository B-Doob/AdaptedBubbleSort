using System;

namespace AdaptedBubbleSort
{
    class Program
    {
        static int parses = 0;
        static int swaps = 0;
        public void doOptimisedBubbleSort(int[] a) 
        {
            int lastSwap = a.Length-1;
            for(int i=1; i<a.Length; i++) {
                
                bool is_sorted = true;
                int currentSwap = -1;
        
                for(int j=0; j < lastSwap; j++) {
                    parses++;
                    if(a[j] > a[j+1]) {
                        swaps++;
                        int temp = a[j];
                        a[j] = a[j+1];
                        a[j+1] = temp;
                        is_sorted = false;
                        currentSwap = j;
                    }
                }
        
                if(is_sorted){
                    return;
                } 
                lastSwap = currentSwap;
            }
        }
 
    /* Prints the array */
        void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i=0; i<n; ++i){

                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    
    // Driver method to test above
        public static void Main(String[] args)
        {
            Program p = new Program();
            int[] arr = {64, 34, 25, 12, 22, 11, 90};
            Console.WriteLine("The Unsorted array is");
            p.printArray(arr);
            
            //apply sort
            p.doOptimisedBubbleSort(arr);
            Console.WriteLine("The Optimised Bubble Sorted array is");
            p.printArray(arr);

            System.Console.WriteLine($"The ammount of parses is {parses}");
            System.Console.WriteLine($"The ammount of swaps is {swaps}");

        }
        
    
    }
}

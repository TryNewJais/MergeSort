using System;

namespace Sorting
{
    public class MergeSort
    {
        public void caller()
        {
            Console.WriteLine("Enter the length of the array");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the array.....");
            int[] array = new int[k];
            for(int i=0; i<k;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            Console.WriteLine();
            MergeSorting(array, 0, (array.Length - 1));
            Console.WriteLine("sorted array is .........");
            foreach (int j in array)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
        public int[] MergeSorting(int[] Arr,int p, int r)
        {
            if (p < r)
            {
                int q = ((p + r) / 2);
                MergeSorting(Arr, p, q);
                MergeSorting(Arr, q + 1, r);
                Merge(Arr, p, q, r);
                return Arr;
            }
            return Arr;
        }

        private int[] Merge(int[] arr,int p, int q, int r) // catch is to know p, q ,r are index of array. 
        {
            if (p == r)
            {
                return arr;
            }
            int n1 = q - p + 1;
            int n2 = r - q;
            int[] L = new int[(n1 + 1)];
            int[] R = new int[(n2 + 1)];
            int i, j = 0;
           
            for ( i=0;i<n1;i++)
            {
                L[i] = arr[p +i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = arr[q+1+j];
            }

            L[n1] = -1;
            R[n2] = -1;
            i = 0; j = 0;
            for (int k = p; k <= r; k++)
            {
                if (R[j] != -1 && L[i] != -1)
                {
                    if (L[i] < R[j])
                    {
                        arr[k] = L[i];
                        ++i;
                    }
                    else
                    {
                        arr[k] = R[j];
                        ++j;
                    }

                }
                else if(R[j] == -1)
                {
                    arr[k] = L[i];
                    ++i;
                }
                else
                {
                    arr[k] = R[j];
                    ++j;
                }


            }

            return arr;
        }

    }
}

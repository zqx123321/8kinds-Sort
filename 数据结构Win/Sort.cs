using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构Win
{
    /// <summary>
    /// 排序类，封装了本程序所需的10种排序方法
    /// </summary>
    public static class Sort
    {
        public static int Bubble = 1;
        public static int Insert = 2;
        public static int Select = 3;
        public static int Quick = 4;
        public static int Heap = 5;
        public static int Merge = 6;
        public static int Shell = 7;
        public static int Radix = 8;
        public static int InsertBin = 0;
        public static int TwoInsert = 9;
        public static int Length = 100000;
        public static int INF = 100000000;
        public static long[] CompNum = new long[10];
        public static long[] MoveNum = new long[10];
        public static Double[] RunTime = new Double[10];
        public static int[,] Array = new int[10, Length];
        public static String[] SortKind = new String[10] { "InsertBin:", "Bubble:","Insert:", "Select:", "Quick:", "Heap:", "Merge:", "Shell:", "Radix:", "TwoInsert" };
        public static List<DateTime> beforDT =new List<DateTime>();

        public static void MemsetArray()
        {
            int[] tempArray = new int[Length];
            Random rand = new Random();
            for (int i = 0; i < Length; i++)
            {
                tempArray[i] = rand.Next(0, 10000);

            }
            if (Form1.form.isAuto)
            {
                FileStream fs = new FileStream("data" + (6 - Form1.form.Count) + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs); // 创建写入流
                for (int i = 0; i < Sort.Length; i++)
                {
                    sw.WriteLine(tempArray[i]);
                }
                sw.Close(); //关闭文件
            } 

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Array[i, j] = tempArray[j];
                }
            }
        }

        public static void MemsetArrayPositive()
        {
            int[] tempArray = new int[Length];
            Random rand = new Random();
            for (int i = 0; i < Length; i++)
            {
                tempArray[i] = rand.Next(0, 10000);

            }
            QuickSortPositive(tempArray, 0, Length - 1);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Array[i, j] = tempArray[j];
                }
            }
        }

        private static void QuickSortPositive(int[] Array, int low, int high)
        {
            if (low >= high)
            {
                return;
            }
            int first = low;
            int last = high;
            int key = Array[first];

            while (first < last)
            {
                while (first < last && Array[last] >= key)
                {
                    --last;
                }
                Array[first] = Array[last];

                while (first < last && Array[first] <= key)
                {
                    ++first;
                }
                Array[last] = Array[first];
            }
            Array[first] = key;
            QuickSortPositive(Array, low, first - 1);
            QuickSortPositive(Array, first + 1, high);
        }

        public static void MemsetArrayNegative()
        {
            int[] tempArray = new int[Length];
            Random rand = new Random();
            for (int i = 0; i < Length; i++)
            {
                tempArray[i] = rand.Next(0, 10000);

            }
            QuickSortNegative(tempArray, 0, Length - 1);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Array[i, j] = tempArray[j];
                }
            }
        }

        private static void QuickSortNegative(int[] Array, int low, int high)
        {
            if (low >= high)
            {
                return;
            }
            int first = low;
            int last = high;
            int key = Array[first];

            while (first < last)
            {
                while (first < last && Array[last] <= key)
                {
                    --last;
                }
                Array[first] = Array[last];

                while (first < last && Array[first] >= key)
                {
                    ++first;
                }
                Array[last] = Array[first];
            }
            Array[first] = key;
            QuickSortNegative(Array, low, first - 1);
            QuickSortNegative(Array, first + 1, high);
        }

        public static void InsertionSort()
        {
            for (int j = 1; j < Length; j++)
            {
                int key = Array[Insert, j];
                MoveNum[Insert]++;
                int i = j - 1;
                while (i >= 0 && Array[Insert, i] > key)
                {
                    CompNum[Insert]++;
                    Array[Insert, i + 1] = Array[Insert, i];
                    MoveNum[Insert]++;
                    i--;
                }
                Array[Insert, i + 1] = key;
                MoveNum[Insert]++;
                DateTime afterDT = System.DateTime.Now;
                TimeSpan ts = afterDT.Subtract(beforDT[Insert]);
                RunTime[Insert] = Convert.ToDouble(ts.TotalMilliseconds / 1000);
            }

        }

        public static void BubbleSort()
        {
            
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length - i - 1; j++)
                {
                    CompNum[Bubble]++;
                    if (Array[Bubble, j] > Array[Bubble, j + 1])
                    {
                        //swap(Array[Bubble][j], Array[Bubble][j + 1]);
                        int temp = Array[Bubble, j];
                        Array[Bubble, j] = Array[Bubble, j + 1];
                        Array[Bubble, j + 1] = temp;
                        MoveNum[Bubble] += 3;
                    }
                }

                DateTime afterDT = System.DateTime.Now;
                TimeSpan ts = afterDT.Subtract(beforDT[Bubble]);
                RunTime[Bubble]=Convert.ToDouble(ts.TotalMilliseconds / 1000);
            }
        }


        public static void ShellSort()
        {
            int step = Length / 2;
            while (step > 0)
            {
                for (int i = step; i < Length; i++)
                {
                    int temp = Array[Shell, i];
                    MoveNum[Shell]++;
                    int j;
                    for (j = i - step; j >= 0 && temp < Array[Shell, j]; j = j - step)
                    {
                        CompNum[Shell]++;
                        Array[Shell, j + step] = Array[Shell, j];
                        MoveNum[Shell]++;
                    }
                    Array[Shell, j + step] = temp;
                    MoveNum[Shell]++;
                }
                step /= 2;
                DateTime afterDT = System.DateTime.Now;
                TimeSpan ts = afterDT.Subtract(beforDT[Shell]);
                RunTime[Shell] = Convert.ToDouble(ts.TotalMilliseconds / 1000);

            }
        }

        public static void SelectSort()
        {
            for (int i = 0; i < Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < Length; j++)
                {
                    CompNum[Select]++;
                    if (Array[Select, j] < Array[Select, min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    //swap(Array[Select][i], Array[Select][min]);
                    int temp = Array[Select, i];
                    Array[Select, i] = Array[Select, min];
                    Array[Select, min] = temp;
                    MoveNum[Select] += 3;
                }
                DateTime afterDT = System.DateTime.Now;
                TimeSpan ts = afterDT.Subtract(beforDT[Select]);
                RunTime[Select] = Convert.ToDouble(ts.TotalMilliseconds / 1000);
            }
        }

        public static void QuickSort(int low, int high)
        {
            DateTime afterDT = System.DateTime.Now;
            TimeSpan ts = afterDT.Subtract(beforDT[Quick]);
            RunTime[Quick] = Convert.ToDouble(ts.TotalMilliseconds / 1000);
            if (low >= high)
            {
                return;
            }
            int first = low;
            int last = high;
            int key = Array[Quick, first];
            MoveNum[Quick]++;
            while (first < last)
            {
                while (first < last && Array[Quick, last] >= key)
                {
                    CompNum[Quick]++;
                    --last;
                }
                Array[Quick, first] = Array[Quick, last];
                MoveNum[Quick]++;
                while (first < last && Array[Quick, first] <= key)
                {
                    CompNum[Quick]++;
                    ++first;
                }
                Array[Quick, last] = Array[Quick, first];
                MoveNum[Quick]++;
            }
            Array[Quick, first] = key;
            MoveNum[Quick]++;
            QuickSort(low, first - 1);
            QuickSort(first + 1, high);
        }


        public static void MaxHeapFixDown(int i, int n)
        {
            int j = 2 * i + 1;
            int temp = Array[Heap, i];
            MoveNum[Heap]++;
            while (j < n)
            {
                CompNum[Heap]++;
                if (j + 1 < n && Array[Heap, j] < Array[Heap, j + 1])
                    ++j;
                CompNum[Heap]++;
                if (temp > Array[Heap, j])
                    break;
                else
                {
                    MoveNum[Heap]++;
                    Array[Heap, i] = Array[Heap, j];
                    i = j;
                    j = 2 * i + 1;
                }
            }
            MoveNum[Heap]++;
            Array[Heap, i] = temp;
        }

        public static void HeapSort()
        {
            for (int i = Length / 2 - 1; i >= 0; i--)
                MaxHeapFixDown(i, Length);
            for (int i = Length - 1; i >= 1; i--)
            {
                DateTime afterDT = System.DateTime.Now;
                TimeSpan ts = afterDT.Subtract(beforDT[Heap]);
                RunTime[Heap] = Convert.ToDouble(ts.TotalMilliseconds / 1000);
                //swap(Array[Heap][i], Array[Heap][0]);
                int temp = Array[Heap, i];
                Array[Heap, i] = Array[Heap, 0];
                Array[Heap, 0] = temp;
                MoveNum[Heap] += 3;
                MaxHeapFixDown(0, i);
            }
        }

        public static void merge(int low, int mid, int high, int[] tempArray)
        {
            int i = low, j = mid + 1, k = 0;
            while (i <= mid && j <= high)
            {
                CompNum[Merge]++;
                MoveNum[Merge]++;
                if (Array[Merge, i] <= Array[Merge, j])
                    tempArray[k++] = Array[Merge, i++];
                else
                    tempArray[k++] = Array[Merge, j++]; 
            }
            while (i <= mid)
            {
                tempArray[k++] = Array[Merge, i++];
                MoveNum[Merge]++;
            }
            while (j <= high)
            {         
                tempArray[k++] = Array[Merge, j++];
                MoveNum[Merge]++;
            }

            for (i = 0; i < k; i++)
            {
                Array[Merge, low + i] = tempArray[i];
                MoveNum[Merge]++;
            }
        }

        public static void MergeSort(int low, int high, int[] tempArray)
        {
            DateTime afterDT = System.DateTime.Now;
            TimeSpan ts = afterDT.Subtract(beforDT[Merge]);
            RunTime[Merge] = Convert.ToDouble(ts.TotalMilliseconds / 1000);
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSort(low, mid, tempArray);
                MergeSort(mid + 1, high, tempArray);  
                merge(low, mid, high, tempArray);
            }
        }


        public static int Maxbit()
        {
            int d = 1;
            int p = 10;
            for (int i = 0; i < Length; i++)
            {
                while (Array[Radix, i] >= p)
                {
                    p *= 10;
                    ++d;
                }
            }
            return d;
        }

        public static void RadixSort()
        {
            int d = Maxbit();
            int[] tmp = new int[Length];
            int[] count = new int[10];
            int i, j, k;
            int radix = 1;
            for (i = 1; i <= d; i++)
            {
                for (j = 0; j < 10; j++)
                    count[j] = 0;
                for (j = 0; j < Length; j++)
                {
                    k = (Array[Radix, j] / radix) % 10;
                    count[k]++;
                    MoveNum[Radix]++;
                }
                for (j = 1; j < 10; j++)
                    count[j] = count[j - 1] + count[j];
                for (j = Length - 1; j >= 0; j--)
                {
                    k = (Array[Radix, j] / radix) % 10;
                    tmp[count[k] - 1] = Array[Radix, j];
                    count[k]--;
                    MoveNum[Radix]+=2;
                }
                for (j = 0; j < Length; j++)
                {
                    MoveNum[Radix]++;
                    Array[Radix, j] = tmp[j];
                }
                radix = radix * 10;

                DateTime afterDT = System.DateTime.Now;
                TimeSpan ts = afterDT.Subtract(beforDT[Radix]);
                RunTime[Radix] = Convert.ToDouble(ts.TotalMilliseconds / 1000);
            }
        }

        public static void BinInsertSort()
        {
            for (int i = 0; i < Length-1; i++)
            {
                int t = Array[InsertBin, i + 1];
                MoveNum[InsertBin]++;
                int low = 0;
                int high = i;
                while (low <= high)
                {
                    int mid = (low + high) / 2;
                    CompNum[InsertBin]++;
                    if (Array[InsertBin, mid] > t)
                        high = mid - 1;
                    else
                        low = mid + 1;
                }
                for (int j = i; j >= low; j--)
                {
                    MoveNum[InsertBin]++;
                    Array[InsertBin, j + 1] = Array[InsertBin, j];
                }
                MoveNum[InsertBin]++;
                Array[InsertBin, low] = t;

                DateTime afterDT = System.DateTime.Now;
                TimeSpan ts = afterDT.Subtract(beforDT[InsertBin]);
                RunTime[InsertBin] = Convert.ToDouble(ts.TotalMilliseconds / 1000);
            }

        }

        public static void TwoInsertSort()
        {   
            int[] temp = new int[Length];
            int first = 0, final = 0;
            temp[0] = Array[TwoInsert,0];
            MoveNum[TwoInsert]++;

            for (int i = 1; i < Length; i++)
            {
                
                if (Array[TwoInsert,i] < temp[first])
                {
                    CompNum[TwoInsert]++;
                    first = (first - 1 + Length) % Length;
                    temp[first] = Array[TwoInsert,i];
                }
                else if (Array[TwoInsert,i] > temp[final])
                { 
                    CompNum[TwoInsert]++;
                    final = (final + 1 + Length) % Length;
                    temp[final] = Array[TwoInsert,i];
                }
                else
                {
                    CompNum[TwoInsert]++;
                    int k = (final + 1 + Length) % Length;
                    while (temp[((k - 1) + Length) % Length] > Array[TwoInsert, i])
                    {
                        CompNum[TwoInsert]++;
                        MoveNum[TwoInsert]++;
                        temp[(k + Length) % Length] = temp[(k - 1 + Length) % Length];
                        k = (k - 1 + Length) % Length;
                    }
                    temp[(k + Length) % Length] = Array[TwoInsert, i];
                    final = (final + 1 + Length) % Length;
                }
                DateTime afterDT = System.DateTime.Now;
                TimeSpan ts = afterDT.Subtract(beforDT[TwoInsert]);
                RunTime[TwoInsert] = Convert.ToDouble(ts.TotalMilliseconds / 1000);
            }

            for (int k = 0; k < Length; k++)
            {
                Array[TwoInsert,k] = temp[(first + k) % Length];
                if (k % 100 == 0)
                {
                    DateTime afterDT = System.DateTime.Now;
                    TimeSpan ts = afterDT.Subtract(beforDT[TwoInsert]);
                    RunTime[TwoInsert] = Convert.ToDouble(ts.TotalMilliseconds / 1000);
                }
            }

        }
    }
}

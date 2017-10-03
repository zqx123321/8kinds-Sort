using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace 数据结构Win
{
    public partial class Form1 : Form
    {
        public static Form1 form;
        public bool isFirst = true;
        public bool isBubbleOver = false;
        public bool isInsertOver = false;
        public bool isSelectOver = false;
        public bool isShellOver = false;
        public bool isQuickOver = false;
        public bool isHeapOver = false;
        public bool isMergeOver = false;
        public bool isRadixOver = false;
        public bool isInsertBinOver = false;
        public bool isInsertTwoOver = false;
        public int Count = 5;
        public bool isAuto = false;
        public Stopwatch sw;

        public Form1()
        {
            sw = new Stopwatch();
            InitializeComponent();
            timer1.Interval = 100;
            radioButton1.Checked = true;
            form = this;
            
        }

        public void BubbleSortRun()
        {
            Sort.CompNum[Sort.Bubble] = Sort.MoveNum[Sort.Bubble] = 0;
            Sort.RunTime[Sort.Bubble] = 0;
            Sort.BubbleSort();
            if (isAuto)
            {
                FileStream fs = new FileStream("bubble" + (6 - Count) + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs); // 创建写入流
                for (int i = 0; i < Sort.Length; i++)
                {
                    sw.WriteLine(Sort.Array[Sort.Bubble, i]);
                }
                sw.Close(); //关闭文件
            }
            isBubbleOver = true;
        }
        public void InsertSortRun()
        {
            Sort.CompNum[Sort.Insert] = Sort.MoveNum[Sort.Insert] = 0;
            Sort.RunTime[Sort.Insert] = 0;
            Sort.InsertionSort();
            if (isAuto)
            {
                FileStream fs = new FileStream("insert" + (6 - Count) + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs); // 创建写入流
                for (int i = 0; i < Sort.Length; i++)
                {
                    sw.WriteLine(Sort.Array[Sort.Insert, i]);
                }
                sw.Close(); //关闭文件
            }
            isInsertOver = true;
        }

        public void TwoInsertSortRun()
        {
            Sort.CompNum[Sort.TwoInsert] = Sort.MoveNum[Sort.TwoInsert] = 0;
            Sort.RunTime[Sort.TwoInsert] = 0;
            Sort.TwoInsertSort();
            if (isAuto)
            {
                FileStream fs = new FileStream("twoinsert" + (6 - Count) + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs); // 创建写入流
                for (int i = 0; i < Sort.Length; i++)
                {
                    sw.WriteLine(Sort.Array[Sort.TwoInsert, i]);
                }
                sw.Close(); //关闭文件
            }
            isInsertTwoOver = true;
        }

        public void InsertBinSortRun()
        {
            Sort.CompNum[Sort.InsertBin] = Sort.MoveNum[Sort.InsertBin] = 0;
            Sort.RunTime[Sort.InsertBin] = 0;
            Sort.BinInsertSort();
            if (isAuto)
            {
                FileStream fs = new FileStream("bininsert" + (6 - Count) + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs); // 创建写入流
                for (int i = 0; i < Sort.Length; i++)
                {
                    sw.WriteLine(Sort.Array[Sort.InsertBin, i]);
                }
                sw.Close(); //关闭文件
            }
            isInsertBinOver = true;
        }
        public void SelectSortRun()
        {
            Sort.CompNum[Sort.Select] = Sort.MoveNum[Sort.Select] = 0;
            Sort.RunTime[Sort.Select] = 0;
            Sort.SelectSort();
            if (isAuto)
            {
                FileStream fs = new FileStream("select" + (6 - Count) + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs); // 创建写入流
                for (int i = 0; i < Sort.Length; i++)
                {
                    sw.WriteLine(Sort.Array[Sort.Select, i]);
                }
                sw.Close(); //关闭文件
            }
            isSelectOver = true;
        }
        public void ShellSortRun()
        {
            Sort.CompNum[Sort.Shell] = Sort.MoveNum[Sort.Shell] = 0;
            Sort.RunTime[Sort.Shell] = 0;
            Sort.ShellSort();
            if (isAuto)
            {
                FileStream fs = new FileStream("shell" + (6 - Count) + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs); // 创建写入流
                for (int i = 0; i < Sort.Length; i++)
                {
                    sw.WriteLine(Sort.Array[Sort.Shell, i]);
                }
                sw.Close(); //关闭文件
            }
            Thread.Sleep(100000);
            isShellOver = true;
        }
        public void HeapSortRun()
        {
            Sort.CompNum[Sort.Heap] = Sort.MoveNum[Sort.Heap] = 0;
            Sort.RunTime[Sort.Heap] = 0;
            Sort.HeapSort();
            if (isAuto)
            {
                FileStream fs = new FileStream("heap" + (6 - Count) + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs); // 创建写入流
                for (int i = 0; i < Sort.Length; i++)
                {
                    sw.WriteLine(Sort.Array[Sort.Heap, i]);
                }
                sw.Close(); //关闭文件
            }
            Thread.Sleep(100000);
            isHeapOver = true;
        }
        public void RadixSortRun()
        {
            Sort.CompNum[Sort.Radix] = Sort.MoveNum[Sort.Radix] = 0;
            Sort.RunTime[Sort.Radix] = 0;
            Sort.RadixSort();
            if (isAuto)
            {
                FileStream fs = new FileStream("radix" + (6 - Count) + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs); // 创建写入流
                for (int i = 0; i < Sort.Length; i++)
                {
                    sw.WriteLine(Sort.Array[Sort.Radix, i]);
                }
                sw.Close(); //关闭文件
            }
            Thread.Sleep(100000);
            isRadixOver = true;
        }
        public void QuickSortRun()
        {
            if (!radioButton2.Checked)
            {
                Sort.CompNum[Sort.Quick] = Sort.MoveNum[Sort.Quick] = 0;
                Sort.RunTime[Sort.Quick] = 0;
                Sort.QuickSort(0, Sort.Length - 1);
                if (isAuto)
                {
                    FileStream fs = new FileStream("quick"+(6-Count)+".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    StreamWriter sw = new StreamWriter(fs); // 创建写入流
                    for (int i = 0; i < Sort.Length; i++)
                    {
                        sw.WriteLine(Sort.Array[Sort.Quick, i]);
                    }
                    sw.Close(); //关闭文件
                }
                Thread.Sleep(100000);
                isQuickOver = true;
                
            }
            else
            {
                isQuickOver = true;
            }
        }
        public void MergeSortRun()
        {
            Sort.CompNum[Sort.Merge] = Sort.MoveNum[Sort.Merge] = 0;
            Sort.RunTime[Sort.Merge] = 0;
            int[] tempArray = new int[Sort.Length];
            Sort.MergeSort(0, Sort.Length - 1,tempArray);
            if (isAuto)
            {
                FileStream fs = new FileStream("merge" + (6 - Count) + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs); // 创建写入流
                for (int i = 0; i < Sort.Length; i++)
                {
                    sw.WriteLine(Sort.Array[Sort.Merge, i]);
                }
                sw.Close(); //关闭文件
            }
            Thread.Sleep(100000);
            isMergeOver = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!isBubbleOver)
            {
                txtCompBubble.Text = Sort.CompNum[Sort.Bubble].ToString();
                txtMoveBubble.Text = Sort.MoveNum[Sort.Bubble].ToString();
                txtTimeBubble.Text = String.Format("{0:F}", Sort.RunTime[Sort.Bubble]) + "s";
            }
            if (!isInsertOver)
            {
                txtCompInsert.Text = Sort.CompNum[Sort.Insert].ToString();
                txtMoveInsert.Text = Sort.MoveNum[Sort.Insert].ToString();
                txtTimeInsert.Text = String.Format("{0:F}", Sort.RunTime[Sort.Insert]) + "s";
            }
            if (!isSelectOver)
            {
                txtTimeSelect.Text = String.Format("{0:F}", Sort.RunTime[Sort.Select]) + "s";
                txtCompSelect.Text = Sort.CompNum[Sort.Select].ToString();
                txtMoveSelect.Text = Sort.MoveNum[Sort.Select].ToString();
            }
            if (!isShellOver)
            {
                txtTimeShell.Text = String.Format("{0:F}", Sort.RunTime[Sort.Shell]) + "s";
                txtCompShell.Text = Sort.CompNum[Sort.Shell].ToString();
                txtMoveShell.Text = Sort.MoveNum[Sort.Shell].ToString();
            }
            if (!isQuickOver)
            {
                if (radioButton1.Checked)
                {
                    txtTimeQuick.Text = String.Format("{0:F}", Sort.RunTime[Sort.Quick]) + "s";
                    txtCompQuick.Text = Sort.CompNum[Sort.Quick].ToString();
                    txtMoveQuick.Text = Sort.MoveNum[Sort.Quick].ToString();
                }
            }
            if (!isMergeOver)
            {
                txtTimeMerge.Text = String.Format("{0:F}", Sort.RunTime[Sort.Merge]) + "s";
                txtCompMerge.Text = Sort.CompNum[Sort.Merge].ToString();
                txtMoveMerge.Text = Sort.MoveNum[Sort.Merge].ToString();
            }
            if (!isRadixOver)
            {
                txtTimeRadix.Text = String.Format("{0:F}", Sort.RunTime[Sort.Radix]) + "s";
                txtCompRadix.Text = Sort.CompNum[Sort.Radix].ToString();
                txtMoveRadix.Text = Sort.MoveNum[Sort.Radix].ToString();
            }
            if (!isHeapOver)
            {
                txtTimeHeap.Text = String.Format("{0:F}", Sort.RunTime[Sort.Heap]) + "s";
                txtCompHeap.Text = Sort.CompNum[Sort.Heap].ToString();
                txtMoveHeap.Text = Sort.MoveNum[Sort.Heap].ToString();
            }
            if (!isInsertBinOver)
            {
                txtTimeInsertBin.Text = String.Format("{0:F}", Sort.RunTime[Sort.InsertBin]) + "s";
                txtCompInsertBin.Text = Sort.CompNum[Sort.InsertBin].ToString();
                txtMoveInsertBin.Text = Sort.MoveNum[Sort.InsertBin].ToString();
            }
            if (!isInsertTwoOver)
            {
                txtTimeTwoInsert.Text = String.Format("{0:F}", Sort.RunTime[Sort.TwoInsert]) + "s";
                txtCompTowInsert.Text = Sort.CompNum[Sort.TwoInsert].ToString();
                txtMoveTwoInsert.Text = Sort.MoveNum[Sort.TwoInsert].ToString();
            }
            if (isBubbleOver)
            {
                btnStart.Text = "生成数据";
                btnStart.Enabled = true;
                isFirst = true;
                isBubbleOver = false;
                isInsertOver = false;
                isSelectOver = false;
                isShellOver = false;
                isQuickOver = false;
                isHeapOver = false;
                isMergeOver = false;
                isRadixOver = false;
                isInsertBinOver = false;
                isInsertTwoOver = false;
                timer1.Stop();
                sw.Stop();
                TimeSpan ts = sw.Elapsed;
                double timeSpan = ts.TotalMilliseconds / (1000 * 60);
                MessageBox.Show("排序完毕！共用时"+ String.Format("{0:F}", timeSpan) +"分");
                new result().Show();
                if (isAuto)
                {
                    FileStream fs = new FileStream("res" + (6 - Count) + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    StreamWriter sw = new StreamWriter(fs); // 创建写入流
                    for (int i = 0; i < 10; i++)
                    {
                        sw.WriteLine(Sort.SortKind[i]);
                        sw.WriteLine("Comp:" + Sort.CompNum[i]);
                        sw.WriteLine("Move:" + Sort.MoveNum[i]);
                        sw.WriteLine("Time:" + Sort.RunTime[i]);
                        sw.WriteLine("");

                    }
                    sw.Close(); //关闭文件

                    Count--;
                    btnAuto.Text = "第" + (6 - Count) + "组数据...";
                    if (Count == 0)
                    {
                        Count = 5;
                        btnAuto.Text = "五组数据自动测试";
                        isAuto = false;
                        btnAuto.Enabled = true;
                    }
                }

            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                if (radioButton1.Checked)
                {
                    Sort.MemsetArray();
                }
                if (!radioButton1.Checked)
                {
                    isQuickOver = true;
                    txtCompQuick.Text = "栈溢出";
                    txtMoveQuick.Text = "栈溢出";
                    txtTimeQuick.Text = "栈溢出";
                    Sort.MemsetArrayPositive();
                }
                if (radioButton3.Checked)
                {
                    Sort.MemsetArrayNegative();
                }
                MessageBox.Show("生成成功！");;
                btnStart.Text = "开始排序";
                isFirst = false;
            }
            else
            {
                sw.Start();
                timer1.Start();
                btnStart.Text = "正在排序";
                btnStart.Enabled = false;
                if (Sort.beforDT.Count == 0) {
                    for (int i = 0; i < 10; i++)
                        Sort.beforDT.Add(System.DateTime.Now);
                }
                else
                {
                    for (int i = 0; i < 10; i++)
                        Sort.beforDT[i] = System.DateTime.Now;
                }
                Thread[] threads = new Thread[10];
                threads[0] = new Thread(new ThreadStart(BubbleSortRun));
                threads[1] = new Thread(new ThreadStart(InsertSortRun));
                threads[2] = new Thread(new ThreadStart(SelectSortRun));
                threads[3] = new Thread(new ThreadStart(ShellSortRun));
                threads[4] = new Thread(new ThreadStart(QuickSortRun));
                threads[5] = new Thread(new ThreadStart(MergeSortRun));
                threads[6] = new Thread(new ThreadStart(HeapSortRun));
                threads[7] = new Thread(new ThreadStart(RadixSortRun));
                threads[8] = new Thread(new ThreadStart(InsertBinSortRun));
                threads[9] = new Thread(new ThreadStart(TwoInsertSortRun));

                
                for (int i = 0; i < 10; i++)
                {
                    threads[i].IsBackground = true;
                    threads[i].Start();
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            isAuto = true;
            btnAuto.Text = "第"+(6-Count)+"组数据...";
            btnAuto.Enabled = false;
        }
    }
}

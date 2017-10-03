using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace 数据结构Win
{
    public partial class result : Form
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public result()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void result_Load(object sender, EventArgs e) {
            asc.controllInitializeSize(this);
            chart1.Visible = true;

            //清除默认的series
            chart1.Series.Clear();
            //new 一个叫做【Strength】的系列
            Series Comp = new Series("比较次数");
            //设置chart的类型，这里为柱状图
            Comp.ChartType = SeriesChartType.Column;
            //给系列上的点进行赋值，分别对应横坐标和纵坐标的值
            Comp.Points.AddXY("快速排序", Sort.CompNum[Sort.Quick]);
            Comp.Points.AddXY("归并排序", Sort.CompNum[Sort.Merge]);
            Comp.Points.AddXY("堆排序", Sort.CompNum[Sort.Heap]);
            Comp.Points.AddXY("基数排序", Sort.CompNum[Sort.Radix]);
            Comp.Points.AddXY("希尔排序", Sort.CompNum[Sort.Shell]);
            Comp.Points.AddXY("插入排序", Sort.CompNum[Sort.Insert]);
            Comp.Points.AddXY("折半插入", Sort.CompNum[Sort.InsertBin]);
            Comp.Points.AddXY("二路插入", Sort.CompNum[Sort.TwoInsert]);
            Comp.Points.AddXY("选择排序", Sort.CompNum[Sort.Select]);
            Comp.Points.AddXY("冒泡排序", Sort.CompNum[Sort.Bubble]);
            //把series添加到chart上
            Series Move = new Series("移动次数");
            Move.ChartType = SeriesChartType.Column;
            //给系列上的点进行赋值，分别对应横坐标和纵坐标的值
            Move.Points.AddXY("快速排序", Sort.MoveNum[Sort.Quick]);
            Move.Points.AddXY("归并排序", Sort.MoveNum[Sort.Merge]);
            Move.Points.AddXY("堆排序", Sort.MoveNum[Sort.Heap]);
            Move.Points.AddXY("基数排序", Sort.MoveNum[Sort.Radix]);
            Move.Points.AddXY("希尔排序", Sort.MoveNum[Sort.Shell]);
            Move.Points.AddXY("插入排序", Sort.MoveNum[Sort.Insert]);
            Move.Points.AddXY("折半插入", Sort.MoveNum[Sort.InsertBin]);
            Move.Points.AddXY("二路插入", Sort.MoveNum[Sort.TwoInsert]);
            Move.Points.AddXY("选择排序", Sort.MoveNum[Sort.Select]);
            Move.Points.AddXY("冒泡排序", Sort.MoveNum[Sort.Bubble]);
            Move.IsValueShownAsLabel = true;
            Comp.IsValueShownAsLabel = true;
            chart1.ChartAreas[0].AxisX.Interval = 1;   //设置X轴坐标的间隔为1
            chart1.ChartAreas[0].AxisX.IntervalOffset = 1;  //设置X轴坐标偏移为1
            chart1.ChartAreas[0].AxisX.LabelStyle.IsStaggered = true;   //设置是否交错显示,比如数据多的时间分成两行来显示  
            //chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart1.Series.Add(Comp);
            chart1.Series.Add(Move);
        }

        private void result_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }
    }
}

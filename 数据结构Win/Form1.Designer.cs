namespace 数据结构Win
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompBubble = new System.Windows.Forms.TextBox();
            this.txtMoveBubble = new System.Windows.Forms.TextBox();
            this.txtTimeBubble = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtTimeQuick = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMoveQuick = new System.Windows.Forms.TextBox();
            this.txtCompQuick = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimeSelect = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMoveSelect = new System.Windows.Forms.TextBox();
            this.txtCompSelect = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTimeHeap = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMoveHeap = new System.Windows.Forms.TextBox();
            this.txtCompHeap = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTimeInsert = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMoveInsert = new System.Windows.Forms.TextBox();
            this.txtCompInsert = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTimeMerge = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtMoveMerge = new System.Windows.Forms.TextBox();
            this.txtCompMerge = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtTimeShell = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtMoveShell = new System.Windows.Forms.TextBox();
            this.txtCompShell = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtTimeRadix = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtMoveRadix = new System.Windows.Forms.TextBox();
            this.txtCompRadix = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txtTimeInsertBin = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txtMoveInsertBin = new System.Windows.Forms.TextBox();
            this.txtCompInsertBin = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.txtTimeTwoInsert = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txtMoveTwoInsert = new System.Windows.Forms.TextBox();
            this.txtCompTowInsert = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnAuto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(86, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(167, 60);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "生成数据";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(29, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 90);
            this.label1.TabIndex = 1;
            this.label1.Text = "冒泡排序";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(56, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "比较次数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(56, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "移动次数";
            // 
            // txtCompBubble
            // 
            this.txtCompBubble.Location = new System.Drawing.Point(136, 85);
            this.txtCompBubble.Name = "txtCompBubble";
            this.txtCompBubble.ReadOnly = true;
            this.txtCompBubble.Size = new System.Drawing.Size(117, 21);
            this.txtCompBubble.TabIndex = 4;
            this.txtCompBubble.Text = "0";
            // 
            // txtMoveBubble
            // 
            this.txtMoveBubble.Location = new System.Drawing.Point(136, 112);
            this.txtMoveBubble.Name = "txtMoveBubble";
            this.txtMoveBubble.ReadOnly = true;
            this.txtMoveBubble.Size = new System.Drawing.Size(117, 21);
            this.txtMoveBubble.TabIndex = 5;
            this.txtMoveBubble.Text = "0";
            // 
            // txtTimeBubble
            // 
            this.txtTimeBubble.Location = new System.Drawing.Point(136, 139);
            this.txtTimeBubble.Name = "txtTimeBubble";
            this.txtTimeBubble.ReadOnly = true;
            this.txtTimeBubble.Size = new System.Drawing.Size(117, 21);
            this.txtTimeBubble.TabIndex = 42;
            this.txtTimeBubble.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(56, 139);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(74, 21);
            this.label25.TabIndex = 41;
            this.label25.Text = "排序时间";
            // 
            // txtTimeQuick
            // 
            this.txtTimeQuick.Location = new System.Drawing.Point(382, 139);
            this.txtTimeQuick.Name = "txtTimeQuick";
            this.txtTimeQuick.ReadOnly = true;
            this.txtTimeQuick.Size = new System.Drawing.Size(117, 21);
            this.txtTimeQuick.TabIndex = 49;
            this.txtTimeQuick.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(302, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 48;
            this.label4.Text = "排序时间";
            // 
            // txtMoveQuick
            // 
            this.txtMoveQuick.Location = new System.Drawing.Point(382, 112);
            this.txtMoveQuick.Name = "txtMoveQuick";
            this.txtMoveQuick.ReadOnly = true;
            this.txtMoveQuick.Size = new System.Drawing.Size(117, 21);
            this.txtMoveQuick.TabIndex = 47;
            this.txtMoveQuick.Text = "0";
            // 
            // txtCompQuick
            // 
            this.txtCompQuick.Location = new System.Drawing.Point(382, 85);
            this.txtCompQuick.Name = "txtCompQuick";
            this.txtCompQuick.ReadOnly = true;
            this.txtCompQuick.Size = new System.Drawing.Size(117, 21);
            this.txtCompQuick.TabIndex = 46;
            this.txtCompQuick.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(302, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 45;
            this.label5.Text = "移动次数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(302, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 44;
            this.label6.Text = "比较次数";
            // 
            // label7
            // 
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(275, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 90);
            this.label7.TabIndex = 43;
            this.label7.Text = "快速排序";
            // 
            // txtTimeSelect
            // 
            this.txtTimeSelect.Location = new System.Drawing.Point(136, 235);
            this.txtTimeSelect.Name = "txtTimeSelect";
            this.txtTimeSelect.ReadOnly = true;
            this.txtTimeSelect.Size = new System.Drawing.Size(117, 21);
            this.txtTimeSelect.TabIndex = 56;
            this.txtTimeSelect.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(56, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 55;
            this.label8.Text = "排序时间";
            // 
            // txtMoveSelect
            // 
            this.txtMoveSelect.Location = new System.Drawing.Point(136, 208);
            this.txtMoveSelect.Name = "txtMoveSelect";
            this.txtMoveSelect.ReadOnly = true;
            this.txtMoveSelect.Size = new System.Drawing.Size(117, 21);
            this.txtMoveSelect.TabIndex = 54;
            this.txtMoveSelect.Text = "0";
            // 
            // txtCompSelect
            // 
            this.txtCompSelect.Location = new System.Drawing.Point(136, 181);
            this.txtCompSelect.Name = "txtCompSelect";
            this.txtCompSelect.ReadOnly = true;
            this.txtCompSelect.Size = new System.Drawing.Size(117, 21);
            this.txtCompSelect.TabIndex = 53;
            this.txtCompSelect.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(56, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 21);
            this.label9.TabIndex = 52;
            this.label9.Text = "移动次数";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(56, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 51;
            this.label10.Text = "比较次数";
            // 
            // label11
            // 
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(29, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 90);
            this.label11.TabIndex = 50;
            this.label11.Text = "选择排序";
            // 
            // txtTimeHeap
            // 
            this.txtTimeHeap.Location = new System.Drawing.Point(382, 235);
            this.txtTimeHeap.Name = "txtTimeHeap";
            this.txtTimeHeap.ReadOnly = true;
            this.txtTimeHeap.Size = new System.Drawing.Size(117, 21);
            this.txtTimeHeap.TabIndex = 63;
            this.txtTimeHeap.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(302, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 21);
            this.label12.TabIndex = 62;
            this.label12.Text = "排序时间";
            // 
            // txtMoveHeap
            // 
            this.txtMoveHeap.Location = new System.Drawing.Point(382, 208);
            this.txtMoveHeap.Name = "txtMoveHeap";
            this.txtMoveHeap.ReadOnly = true;
            this.txtMoveHeap.Size = new System.Drawing.Size(117, 21);
            this.txtMoveHeap.TabIndex = 61;
            this.txtMoveHeap.Text = "0";
            // 
            // txtCompHeap
            // 
            this.txtCompHeap.Location = new System.Drawing.Point(382, 181);
            this.txtCompHeap.Name = "txtCompHeap";
            this.txtCompHeap.ReadOnly = true;
            this.txtCompHeap.Size = new System.Drawing.Size(117, 21);
            this.txtCompHeap.TabIndex = 60;
            this.txtCompHeap.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(302, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 21);
            this.label13.TabIndex = 59;
            this.label13.Text = "移动次数";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(302, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 21);
            this.label14.TabIndex = 58;
            this.label14.Text = "比较次数";
            // 
            // label15
            // 
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(275, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 90);
            this.label15.TabIndex = 57;
            this.label15.Text = "堆排序";
            // 
            // txtTimeInsert
            // 
            this.txtTimeInsert.Location = new System.Drawing.Point(136, 334);
            this.txtTimeInsert.Name = "txtTimeInsert";
            this.txtTimeInsert.ReadOnly = true;
            this.txtTimeInsert.Size = new System.Drawing.Size(117, 21);
            this.txtTimeInsert.TabIndex = 70;
            this.txtTimeInsert.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(56, 334);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 21);
            this.label16.TabIndex = 69;
            this.label16.Text = "排序时间";
            // 
            // txtMoveInsert
            // 
            this.txtMoveInsert.Location = new System.Drawing.Point(136, 307);
            this.txtMoveInsert.Name = "txtMoveInsert";
            this.txtMoveInsert.ReadOnly = true;
            this.txtMoveInsert.Size = new System.Drawing.Size(117, 21);
            this.txtMoveInsert.TabIndex = 68;
            this.txtMoveInsert.Text = "0";
            // 
            // txtCompInsert
            // 
            this.txtCompInsert.Location = new System.Drawing.Point(136, 280);
            this.txtCompInsert.Name = "txtCompInsert";
            this.txtCompInsert.ReadOnly = true;
            this.txtCompInsert.Size = new System.Drawing.Size(117, 21);
            this.txtCompInsert.TabIndex = 67;
            this.txtCompInsert.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(56, 307);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 21);
            this.label17.TabIndex = 66;
            this.label17.Text = "移动次数";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(56, 280);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 21);
            this.label18.TabIndex = 65;
            this.label18.Text = "比较次数";
            // 
            // label19
            // 
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(29, 276);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 90);
            this.label19.TabIndex = 64;
            this.label19.Text = "插入排序";
            // 
            // txtTimeMerge
            // 
            this.txtTimeMerge.Location = new System.Drawing.Point(382, 330);
            this.txtTimeMerge.Name = "txtTimeMerge";
            this.txtTimeMerge.ReadOnly = true;
            this.txtTimeMerge.Size = new System.Drawing.Size(117, 21);
            this.txtTimeMerge.TabIndex = 77;
            this.txtTimeMerge.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(302, 330);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 21);
            this.label20.TabIndex = 76;
            this.label20.Text = "排序时间";
            // 
            // txtMoveMerge
            // 
            this.txtMoveMerge.Location = new System.Drawing.Point(382, 303);
            this.txtMoveMerge.Name = "txtMoveMerge";
            this.txtMoveMerge.ReadOnly = true;
            this.txtMoveMerge.Size = new System.Drawing.Size(117, 21);
            this.txtMoveMerge.TabIndex = 75;
            this.txtMoveMerge.Text = "0";
            // 
            // txtCompMerge
            // 
            this.txtCompMerge.Location = new System.Drawing.Point(382, 276);
            this.txtCompMerge.Name = "txtCompMerge";
            this.txtCompMerge.ReadOnly = true;
            this.txtCompMerge.Size = new System.Drawing.Size(117, 21);
            this.txtCompMerge.TabIndex = 74;
            this.txtCompMerge.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(302, 303);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 21);
            this.label21.TabIndex = 73;
            this.label21.Text = "移动次数";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(302, 276);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 21);
            this.label22.TabIndex = 72;
            this.label22.Text = "比较次数";
            // 
            // label23
            // 
            this.label23.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label23.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(275, 272);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(20, 90);
            this.label23.TabIndex = 71;
            this.label23.Text = "归并排序";
            // 
            // txtTimeShell
            // 
            this.txtTimeShell.Location = new System.Drawing.Point(136, 431);
            this.txtTimeShell.Name = "txtTimeShell";
            this.txtTimeShell.ReadOnly = true;
            this.txtTimeShell.Size = new System.Drawing.Size(117, 21);
            this.txtTimeShell.TabIndex = 84;
            this.txtTimeShell.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(56, 431);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 21);
            this.label24.TabIndex = 83;
            this.label24.Text = "排序时间";
            // 
            // txtMoveShell
            // 
            this.txtMoveShell.Location = new System.Drawing.Point(136, 404);
            this.txtMoveShell.Name = "txtMoveShell";
            this.txtMoveShell.ReadOnly = true;
            this.txtMoveShell.Size = new System.Drawing.Size(117, 21);
            this.txtMoveShell.TabIndex = 82;
            this.txtMoveShell.Text = "0";
            // 
            // txtCompShell
            // 
            this.txtCompShell.Location = new System.Drawing.Point(136, 377);
            this.txtCompShell.Name = "txtCompShell";
            this.txtCompShell.ReadOnly = true;
            this.txtCompShell.Size = new System.Drawing.Size(117, 21);
            this.txtCompShell.TabIndex = 81;
            this.txtCompShell.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.Location = new System.Drawing.Point(56, 404);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(74, 21);
            this.label26.TabIndex = 80;
            this.label26.Text = "移动次数";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.Location = new System.Drawing.Point(56, 377);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(74, 21);
            this.label27.TabIndex = 79;
            this.label27.Text = "比较次数";
            // 
            // label28
            // 
            this.label28.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label28.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.Location = new System.Drawing.Point(29, 373);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(20, 90);
            this.label28.TabIndex = 78;
            this.label28.Text = "希尔排序";
            // 
            // txtTimeRadix
            // 
            this.txtTimeRadix.Location = new System.Drawing.Point(382, 427);
            this.txtTimeRadix.Name = "txtTimeRadix";
            this.txtTimeRadix.ReadOnly = true;
            this.txtTimeRadix.Size = new System.Drawing.Size(117, 21);
            this.txtTimeRadix.TabIndex = 91;
            this.txtTimeRadix.Text = "0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label29.Location = new System.Drawing.Point(302, 427);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(74, 21);
            this.label29.TabIndex = 90;
            this.label29.Text = "排序时间";
            // 
            // txtMoveRadix
            // 
            this.txtMoveRadix.Location = new System.Drawing.Point(382, 400);
            this.txtMoveRadix.Name = "txtMoveRadix";
            this.txtMoveRadix.ReadOnly = true;
            this.txtMoveRadix.Size = new System.Drawing.Size(117, 21);
            this.txtMoveRadix.TabIndex = 89;
            this.txtMoveRadix.Text = "0";
            // 
            // txtCompRadix
            // 
            this.txtCompRadix.Location = new System.Drawing.Point(382, 373);
            this.txtCompRadix.Name = "txtCompRadix";
            this.txtCompRadix.ReadOnly = true;
            this.txtCompRadix.Size = new System.Drawing.Size(117, 21);
            this.txtCompRadix.TabIndex = 88;
            this.txtCompRadix.Text = "0";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label30.Location = new System.Drawing.Point(302, 400);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(74, 21);
            this.label30.TabIndex = 87;
            this.label30.Text = "移动次数";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label31.Location = new System.Drawing.Point(302, 373);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(74, 21);
            this.label31.TabIndex = 86;
            this.label31.Text = "比较次数";
            // 
            // label32
            // 
            this.label32.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label32.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label32.Location = new System.Drawing.Point(275, 369);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(20, 90);
            this.label32.TabIndex = 85;
            this.label32.Text = "基数排序";
            // 
            // txtTimeInsertBin
            // 
            this.txtTimeInsertBin.Location = new System.Drawing.Point(136, 527);
            this.txtTimeInsertBin.Name = "txtTimeInsertBin";
            this.txtTimeInsertBin.ReadOnly = true;
            this.txtTimeInsertBin.Size = new System.Drawing.Size(117, 21);
            this.txtTimeInsertBin.TabIndex = 98;
            this.txtTimeInsertBin.Text = "0";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label33.Location = new System.Drawing.Point(56, 527);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(74, 21);
            this.label33.TabIndex = 97;
            this.label33.Text = "排序时间";
            // 
            // txtMoveInsertBin
            // 
            this.txtMoveInsertBin.Location = new System.Drawing.Point(136, 500);
            this.txtMoveInsertBin.Name = "txtMoveInsertBin";
            this.txtMoveInsertBin.ReadOnly = true;
            this.txtMoveInsertBin.Size = new System.Drawing.Size(117, 21);
            this.txtMoveInsertBin.TabIndex = 96;
            this.txtMoveInsertBin.Text = "0";
            // 
            // txtCompInsertBin
            // 
            this.txtCompInsertBin.Location = new System.Drawing.Point(136, 473);
            this.txtCompInsertBin.Name = "txtCompInsertBin";
            this.txtCompInsertBin.ReadOnly = true;
            this.txtCompInsertBin.Size = new System.Drawing.Size(117, 21);
            this.txtCompInsertBin.TabIndex = 95;
            this.txtCompInsertBin.Text = "0";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label34.Location = new System.Drawing.Point(56, 500);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(74, 21);
            this.label34.TabIndex = 94;
            this.label34.Text = "移动次数";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label35.Location = new System.Drawing.Point(56, 473);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(74, 21);
            this.label35.TabIndex = 93;
            this.label35.Text = "比较次数";
            // 
            // label36
            // 
            this.label36.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label36.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label36.Location = new System.Drawing.Point(29, 469);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(20, 90);
            this.label36.TabIndex = 92;
            this.label36.Text = "折半插入";
            // 
            // txtTimeTwoInsert
            // 
            this.txtTimeTwoInsert.Location = new System.Drawing.Point(382, 527);
            this.txtTimeTwoInsert.Name = "txtTimeTwoInsert";
            this.txtTimeTwoInsert.ReadOnly = true;
            this.txtTimeTwoInsert.Size = new System.Drawing.Size(117, 21);
            this.txtTimeTwoInsert.TabIndex = 105;
            this.txtTimeTwoInsert.Text = "0";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label37.Location = new System.Drawing.Point(302, 527);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(74, 21);
            this.label37.TabIndex = 104;
            this.label37.Text = "排序时间";
            // 
            // txtMoveTwoInsert
            // 
            this.txtMoveTwoInsert.Location = new System.Drawing.Point(382, 500);
            this.txtMoveTwoInsert.Name = "txtMoveTwoInsert";
            this.txtMoveTwoInsert.ReadOnly = true;
            this.txtMoveTwoInsert.Size = new System.Drawing.Size(117, 21);
            this.txtMoveTwoInsert.TabIndex = 103;
            this.txtMoveTwoInsert.Text = "0";
            // 
            // txtCompTowInsert
            // 
            this.txtCompTowInsert.Location = new System.Drawing.Point(382, 473);
            this.txtCompTowInsert.Name = "txtCompTowInsert";
            this.txtCompTowInsert.ReadOnly = true;
            this.txtCompTowInsert.Size = new System.Drawing.Size(117, 21);
            this.txtCompTowInsert.TabIndex = 102;
            this.txtCompTowInsert.Text = "0";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label38.Location = new System.Drawing.Point(302, 500);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(74, 21);
            this.label38.TabIndex = 101;
            this.label38.Text = "移动次数";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label39.Location = new System.Drawing.Point(302, 473);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(74, 21);
            this.label39.TabIndex = 100;
            this.label39.Text = "比较次数";
            // 
            // label40
            // 
            this.label40.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label40.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label40.Location = new System.Drawing.Point(275, 469);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(20, 90);
            this.label40.TabIndex = 99;
            this.label40.Text = "二路插入";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(33, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 106;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "乱序";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(33, 34);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 107;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "正序";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(33, 56);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 16);
            this.radioButton3.TabIndex = 108;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "逆序";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnAuto
            // 
            this.btnAuto.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAuto.Location = new System.Drawing.Point(279, 12);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(220, 60);
            this.btnAuto.TabIndex = 109;
            this.btnAuto.Text = "五组数据自动";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(525, 575);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtTimeTwoInsert);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.txtMoveTwoInsert);
            this.Controls.Add(this.txtCompTowInsert);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.txtTimeInsertBin);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.txtMoveInsertBin);
            this.Controls.Add(this.txtCompInsertBin);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.txtTimeRadix);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.txtMoveRadix);
            this.Controls.Add(this.txtCompRadix);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.txtTimeShell);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtMoveShell);
            this.Controls.Add(this.txtCompShell);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txtTimeMerge);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtMoveMerge);
            this.Controls.Add(this.txtCompMerge);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtTimeInsert);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtMoveInsert);
            this.Controls.Add(this.txtCompInsert);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtTimeHeap);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMoveHeap);
            this.Controls.Add(this.txtCompHeap);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtTimeSelect);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMoveSelect);
            this.Controls.Add(this.txtCompSelect);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTimeQuick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMoveQuick);
            this.Controls.Add(this.txtCompQuick);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTimeBubble);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtMoveBubble);
            this.Controls.Add(this.txtCompBubble);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "排序方法比较";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompBubble;
        private System.Windows.Forms.TextBox txtMoveBubble;
        private System.Windows.Forms.TextBox txtTimeBubble;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtTimeQuick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMoveQuick;
        private System.Windows.Forms.TextBox txtCompQuick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimeSelect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMoveSelect;
        private System.Windows.Forms.TextBox txtCompSelect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTimeHeap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMoveHeap;
        private System.Windows.Forms.TextBox txtCompHeap;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTimeInsert;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMoveInsert;
        private System.Windows.Forms.TextBox txtCompInsert;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtTimeMerge;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtMoveMerge;
        private System.Windows.Forms.TextBox txtCompMerge;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtTimeShell;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtMoveShell;
        private System.Windows.Forms.TextBox txtCompShell;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtTimeRadix;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtMoveRadix;
        private System.Windows.Forms.TextBox txtCompRadix;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtTimeInsertBin;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtMoveInsertBin;
        private System.Windows.Forms.TextBox txtCompInsertBin;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtTimeTwoInsert;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtMoveTwoInsert;
        private System.Windows.Forms.TextBox txtCompTowInsert;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnAuto;
    }
}


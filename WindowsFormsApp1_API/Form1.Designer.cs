﻿
namespace WindowsFormsApp1_API
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.로그인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.계좌번호콤보 = new System.Windows.Forms.ComboBox();
            this.검색버튼 = new System.Windows.Forms.Button();
            this.검색창 = new System.Windows.Forms.TextBox();
            this.종목리스트 = new System.Windows.Forms.TableLayoutPanel();
            this.id2 = new System.Windows.Forms.Label();
            this.id1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.종목명 = new System.Windows.Forms.Label();
            this.고가 = new System.Windows.Forms.Label();
            this.저가 = new System.Windows.Forms.Label();
            this.전일대비 = new System.Windows.Forms.Label();
            this.거래량 = new System.Windows.Forms.Label();
            this.거래대금 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.등락률 = new System.Windows.Forms.Label();
            this.체결강도 = new System.Windows.Forms.Label();
            this.현재가 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.매수_매수버튼 = new System.Windows.Forms.Button();
            this.매수_주 = new System.Windows.Forms.Button();
            this.매수_시장가 = new System.Windows.Forms.CheckBox();
            this.매수_현재가 = new System.Windows.Forms.CheckBox();
            this.매수_가격 = new System.Windows.Forms.NumericUpDown();
            this.매수_수량 = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.매도_매도버튼 = new System.Windows.Forms.Button();
            this.매도_가격 = new System.Windows.Forms.NumericUpDown();
            this.매도_주 = new System.Windows.Forms.Button();
            this.매도_수량 = new System.Windows.Forms.NumericUpDown();
            this.매도_시장가 = new System.Windows.Forms.CheckBox();
            this.매도_현재가 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.전일 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.금일 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.평균단가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.계좌_현재가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.계좌_평가손익 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.계좌_수익 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.주_선택 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.종목리스트.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.매수_가격)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.매수_수량)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.매도_가격)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.매도_수량)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.주_선택.SuspendLayout();
            this.SuspendLayout();
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(12, 902);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(100, 50);
            this.axKHOpenAPI1.TabIndex = 0;
            this.axKHOpenAPI1.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F);
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "계좌번호";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(426, 27);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(909, 469);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(426, 493);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(909, 138);
            this.chart2.TabIndex = 11;
            this.chart2.Text = "chart2";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 676);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "당일 손익금";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로그인ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 로그인ToolStripMenuItem
            // 
            this.로그인ToolStripMenuItem.Name = "로그인ToolStripMenuItem";
            this.로그인ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.로그인ToolStripMenuItem.Text = "로그인";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.label32, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label31, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label30, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.label29, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label28, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label27, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label26, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label25, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label24, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label23, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(888, 77);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(554, 39);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(103, 37);
            this.label32.TabIndex = 30;
            this.label32.Text = "추정자산값";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(444, 39);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(103, 37);
            this.label31.TabIndex = 29;
            this.label31.Text = "추정자산";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(774, 1);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(110, 37);
            this.label30.TabIndex = 28;
            this.label30.Text = "총수익률 값";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(664, 1);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(103, 37);
            this.label29.TabIndex = 27;
            this.label29.Text = "총수익률";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(554, 1);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(103, 37);
            this.label28.TabIndex = 26;
            this.label28.Text = "총손익값";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(444, 1);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(103, 37);
            this.label27.TabIndex = 25;
            this.label27.Text = "총손익";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(334, 1);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(103, 37);
            this.label26.TabIndex = 24;
            this.label26.Text = "총평가값";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(224, 1);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(103, 37);
            this.label25.TabIndex = 23;
            this.label25.Text = "총평가";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(114, 1);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(103, 37);
            this.label24.TabIndex = 22;
            this.label24.Text = "D + 2 값";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(4, 1);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(103, 37);
            this.label23.TabIndex = 21;
            this.label23.Text = "D + 2";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 37);
            this.label5.TabIndex = 14;
            this.label5.Text = "예수금";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 37);
            this.label9.TabIndex = 19;
            this.label9.Text = "예수금 값";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 37);
            this.label6.TabIndex = 16;
            this.label6.Text = "총매입";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(334, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 37);
            this.label10.TabIndex = 20;
            this.label10.Text = "총매입값";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 676);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "label7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 계좌번호콤보
            // 
            this.계좌번호콤보.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.계좌번호콤보.FormattingEnabled = true;
            this.계좌번호콤보.Location = new System.Drawing.Point(74, 24);
            this.계좌번호콤보.Name = "계좌번호콤보";
            this.계좌번호콤보.Size = new System.Drawing.Size(112, 20);
            this.계좌번호콤보.TabIndex = 21;
            // 
            // 검색버튼
            // 
            this.검색버튼.Location = new System.Drawing.Point(1767, 42);
            this.검색버튼.Name = "검색버튼";
            this.검색버튼.Size = new System.Drawing.Size(75, 23);
            this.검색버튼.TabIndex = 18;
            this.검색버튼.Text = "검색";
            this.검색버튼.UseVisualStyleBackColor = true;
            // 
            // 검색창
            // 
            this.검색창.Location = new System.Drawing.Point(1661, 44);
            this.검색창.Name = "검색창";
            this.검색창.Size = new System.Drawing.Size(100, 21);
            this.검색창.TabIndex = 19;
            // 
            // 종목리스트
            // 
            this.종목리스트.ColumnCount = 2;
            this.종목리스트.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.종목리스트.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.종목리스트.Controls.Add(this.id2, 1, 0);
            this.종목리스트.Controls.Add(this.id1, 0, 1);
            this.종목리스트.Controls.Add(this.comboBox2, 0, 0);
            this.종목리스트.Location = new System.Drawing.Point(1614, 28);
            this.종목리스트.Name = "종목리스트";
            this.종목리스트.RowCount = 2;
            this.종목리스트.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.종목리스트.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.종목리스트.Size = new System.Drawing.Size(290, 796);
            this.종목리스트.TabIndex = 20;
            // 
            // id2
            // 
            this.id2.AutoSize = true;
            this.id2.Location = new System.Drawing.Point(148, 0);
            this.id2.Name = "id2";
            this.id2.Size = new System.Drawing.Size(44, 12);
            this.id2.TabIndex = 1;
            this.id2.Text = "label12";
            // 
            // id1
            // 
            this.id1.AutoSize = true;
            this.id1.Location = new System.Drawing.Point(3, 398);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(44, 12);
            this.id1.TabIndex = 0;
            this.id1.Text = "label11";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "005930",
            "019170",
            "005935",
            "005935",
            "052690"});
            this.comboBox2.Location = new System.Drawing.Point(3, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // 종목명
            // 
            this.종목명.AutoSize = true;
            this.종목명.Location = new System.Drawing.Point(95, 32);
            this.종목명.Name = "종목명";
            this.종목명.Size = new System.Drawing.Size(41, 12);
            this.종목명.TabIndex = 21;
            this.종목명.Text = "종목명";
            // 
            // 고가
            // 
            this.고가.AutoSize = true;
            this.고가.Location = new System.Drawing.Point(194, 112);
            this.고가.Name = "고가";
            this.고가.Size = new System.Drawing.Size(29, 12);
            this.고가.TabIndex = 21;
            this.고가.Text = "고가";
            // 
            // 저가
            // 
            this.저가.AutoSize = true;
            this.저가.Location = new System.Drawing.Point(66, 180);
            this.저가.Name = "저가";
            this.저가.Size = new System.Drawing.Size(29, 12);
            this.저가.TabIndex = 21;
            this.저가.Text = "저가";
            // 
            // 전일대비
            // 
            this.전일대비.AutoSize = true;
            this.전일대비.Location = new System.Drawing.Point(54, 100);
            this.전일대비.Name = "전일대비";
            this.전일대비.Size = new System.Drawing.Size(53, 12);
            this.전일대비.TabIndex = 21;
            this.전일대비.Text = "전일대비";
            // 
            // 거래량
            // 
            this.거래량.AutoSize = true;
            this.거래량.Location = new System.Drawing.Point(194, 93);
            this.거래량.Name = "거래량";
            this.거래량.Size = new System.Drawing.Size(41, 12);
            this.거래량.TabIndex = 21;
            this.거래량.Text = "거래량";
            // 
            // 거래대금
            // 
            this.거래대금.AutoSize = true;
            this.거래대금.Location = new System.Drawing.Point(203, 143);
            this.거래대금.Name = "거래대금";
            this.거래대금.Size = new System.Drawing.Size(53, 12);
            this.거래대금.TabIndex = 21;
            this.거래대금.Text = "거래대금";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.등락률);
            this.groupBox1.Controls.Add(this.체결강도);
            this.groupBox1.Controls.Add(this.현재가);
            this.groupBox1.Controls.Add(this.고가);
            this.groupBox1.Controls.Add(this.종목명);
            this.groupBox1.Controls.Add(this.저가);
            this.groupBox1.Controls.Add(this.전일대비);
            this.groupBox1.Controls.Add(this.거래량);
            this.groupBox1.Controls.Add(this.거래대금);
            this.groupBox1.Location = new System.Drawing.Point(1341, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 295);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 143);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 12);
            this.label21.TabIndex = 27;
            this.label21.Text = "현재가";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(2, 100);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 26;
            this.label20.Text = "전일대비";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(129, 180);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 25;
            this.label19.Text = "체결강도";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(153, 222);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 25;
            this.label18.Text = "등락률";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(144, 143);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 25;
            this.label17.Text = "거래대금";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(2, 180);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 25;
            this.label16.Text = "저가";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(144, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 25;
            this.label15.Text = "거래량";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(144, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 25;
            this.label14.Text = "고가";
            // 
            // 등락률
            // 
            this.등락률.AutoSize = true;
            this.등락률.Location = new System.Drawing.Point(203, 222);
            this.등락률.Name = "등락률";
            this.등락률.Size = new System.Drawing.Size(41, 12);
            this.등락률.TabIndex = 24;
            this.등락률.Text = "등락률";
            // 
            // 체결강도
            // 
            this.체결강도.AutoSize = true;
            this.체결강도.Location = new System.Drawing.Point(203, 180);
            this.체결강도.Name = "체결강도";
            this.체결강도.Size = new System.Drawing.Size(53, 12);
            this.체결강도.TabIndex = 23;
            this.체결강도.Text = "체결강도";
            // 
            // 현재가
            // 
            this.현재가.AutoSize = true;
            this.현재가.Location = new System.Drawing.Point(54, 143);
            this.현재가.Name = "현재가";
            this.현재가.Size = new System.Drawing.Size(41, 12);
            this.현재가.TabIndex = 22;
            this.현재가.Text = "현재가";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1341, 332);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(270, 299);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.매수_매수버튼);
            this.tabPage1.Controls.Add(this.매수_주);
            this.tabPage1.Controls.Add(this.매수_시장가);
            this.tabPage1.Controls.Add(this.매수_현재가);
            this.tabPage1.Controls.Add(this.매수_가격);
            this.tabPage1.Controls.Add(this.매수_수량);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(262, 273);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "매수";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 40;
            this.label12.Text = "가격";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 41;
            this.label13.Text = "수량";
            // 
            // 매수_매수버튼
            // 
            this.매수_매수버튼.Location = new System.Drawing.Point(38, 185);
            this.매수_매수버튼.Name = "매수_매수버튼";
            this.매수_매수버튼.Size = new System.Drawing.Size(75, 23);
            this.매수_매수버튼.TabIndex = 32;
            this.매수_매수버튼.Text = "매수";
            this.매수_매수버튼.UseVisualStyleBackColor = true;
            // 
            // 매수_주
            // 
            this.매수_주.Location = new System.Drawing.Point(175, 59);
            this.매수_주.Name = "매수_주";
            this.매수_주.Size = new System.Drawing.Size(38, 21);
            this.매수_주.TabIndex = 31;
            this.매수_주.Text = "주";
            this.매수_주.UseVisualStyleBackColor = true;
            this.매수_주.Click += new System.EventHandler(this.매수_주_Click);
            // 
            // 매수_시장가
            // 
            this.매수_시장가.AutoSize = true;
            this.매수_시장가.Location = new System.Drawing.Point(164, 113);
            this.매수_시장가.Name = "매수_시장가";
            this.매수_시장가.Size = new System.Drawing.Size(60, 16);
            this.매수_시장가.TabIndex = 30;
            this.매수_시장가.Text = "시장가";
            this.매수_시장가.UseVisualStyleBackColor = true;
            // 
            // 매수_현재가
            // 
            this.매수_현재가.AutoSize = true;
            this.매수_현재가.Location = new System.Drawing.Point(38, 137);
            this.매수_현재가.Name = "매수_현재가";
            this.매수_현재가.Size = new System.Drawing.Size(94, 16);
            this.매수_현재가.TabIndex = 29;
            this.매수_현재가.Text = "현재가(자동)";
            this.매수_현재가.UseVisualStyleBackColor = true;
            // 
            // 매수_가격
            // 
            this.매수_가격.Location = new System.Drawing.Point(38, 108);
            this.매수_가격.Name = "매수_가격";
            this.매수_가격.Size = new System.Drawing.Size(120, 21);
            this.매수_가격.TabIndex = 28;
            // 
            // 매수_수량
            // 
            this.매수_수량.Location = new System.Drawing.Point(38, 59);
            this.매수_수량.Name = "매수_수량";
            this.매수_수량.Size = new System.Drawing.Size(120, 21);
            this.매수_수량.TabIndex = 27;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.매도_매도버튼);
            this.tabPage2.Controls.Add(this.매도_가격);
            this.tabPage2.Controls.Add(this.매도_주);
            this.tabPage2.Controls.Add(this.매도_수량);
            this.tabPage2.Controls.Add(this.매도_시장가);
            this.tabPage2.Controls.Add(this.매도_현재가);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(262, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "매도";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 39;
            this.label11.Text = "가격";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 39;
            this.label2.Text = "수량";
            // 
            // 매도_매도버튼
            // 
            this.매도_매도버튼.Location = new System.Drawing.Point(50, 177);
            this.매도_매도버튼.Name = "매도_매도버튼";
            this.매도_매도버튼.Size = new System.Drawing.Size(75, 23);
            this.매도_매도버튼.TabIndex = 38;
            this.매도_매도버튼.Text = "매도";
            this.매도_매도버튼.UseVisualStyleBackColor = true;
            // 
            // 매도_가격
            // 
            this.매도_가격.Location = new System.Drawing.Point(50, 100);
            this.매도_가격.Name = "매도_가격";
            this.매도_가격.Size = new System.Drawing.Size(120, 21);
            this.매도_가격.TabIndex = 34;
            // 
            // 매도_주
            // 
            this.매도_주.Location = new System.Drawing.Point(187, 51);
            this.매도_주.Name = "매도_주";
            this.매도_주.Size = new System.Drawing.Size(38, 21);
            this.매도_주.TabIndex = 37;
            this.매도_주.Text = "주";
            this.매도_주.UseVisualStyleBackColor = true;
            this.매도_주.Click += new System.EventHandler(this.매도_주_Click);
            // 
            // 매도_수량
            // 
            this.매도_수량.Location = new System.Drawing.Point(50, 51);
            this.매도_수량.Name = "매도_수량";
            this.매도_수량.Size = new System.Drawing.Size(120, 21);
            this.매도_수량.TabIndex = 33;
            // 
            // 매도_시장가
            // 
            this.매도_시장가.AutoSize = true;
            this.매도_시장가.Location = new System.Drawing.Point(176, 105);
            this.매도_시장가.Name = "매도_시장가";
            this.매도_시장가.Size = new System.Drawing.Size(60, 16);
            this.매도_시장가.TabIndex = 36;
            this.매도_시장가.Text = "시장가";
            this.매도_시장가.UseVisualStyleBackColor = true;
            // 
            // 매도_현재가
            // 
            this.매도_현재가.AutoSize = true;
            this.매도_현재가.Location = new System.Drawing.Point(50, 129);
            this.매도_현재가.Name = "매도_현재가";
            this.매도_현재가.Size = new System.Drawing.Size(94, 16);
            this.매도_현재가.TabIndex = 35;
            this.매도_현재가.Text = "현재가(자동)";
            this.매도_현재가.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(262, 273);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "정정/취소";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "내보내기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "조건식 편집";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1721, 921);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 29;
            this.label22.Text = "모의투자";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(426, 637);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(918, 404);
            this.tabControl2.TabIndex = 30;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(910, 378);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.전일,
            this.금일,
            this.평균단가,
            this.계좌_현재가,
            this.계좌_평가손익,
            this.계좌_수익});
            this.dataGridView1.Location = new System.Drawing.Point(6, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(899, 226);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "종목명";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "보유량";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "결제잔고";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // 전일
            // 
            this.전일.HeaderText = "전일";
            this.전일.Name = "전일";
            this.전일.ReadOnly = true;
            // 
            // 금일
            // 
            this.금일.HeaderText = "금일";
            this.금일.Name = "금일";
            this.금일.ReadOnly = true;
            // 
            // 평균단가
            // 
            this.평균단가.HeaderText = "매입가";
            this.평균단가.Name = "평균단가";
            this.평균단가.ReadOnly = true;
            // 
            // 계좌_현재가
            // 
            this.계좌_현재가.HeaderText = "현재가";
            this.계좌_현재가.Name = "계좌_현재가";
            this.계좌_현재가.ReadOnly = true;
            // 
            // 계좌_평가손익
            // 
            this.계좌_평가손익.HeaderText = "평가손익";
            this.계좌_평가손익.Name = "계좌_평가손익";
            this.계좌_평가손익.ReadOnly = true;
            // 
            // 계좌_수익
            // 
            this.계좌_수익.HeaderText = "수익";
            this.계좌_수익.Name = "계좌_수익";
            this.계좌_수익.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.계좌번호콤보);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(4, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(900, 140);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(910, 378);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 700);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "label8";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 729);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "당일 손익률";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 주_선택
            // 
            this.주_선택.BackColor = System.Drawing.Color.White;
            this.주_선택.ColumnCount = 6;
            this.주_선택.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.주_선택.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.주_선택.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.주_선택.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.주_선택.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.주_선택.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.주_선택.Controls.Add(this.button4, 0, 1);
            this.주_선택.Controls.Add(this.button15, 0, 3);
            this.주_선택.Controls.Add(this.button16, 1, 3);
            this.주_선택.Controls.Add(this.button17, 2, 3);
            this.주_선택.Controls.Add(this.button18, 3, 3);
            this.주_선택.Controls.Add(this.button19, 4, 3);
            this.주_선택.Controls.Add(this.button20, 5, 3);
            this.주_선택.Controls.Add(this.label35, 0, 0);
            this.주_선택.Controls.Add(this.button22, 4, 4);
            this.주_선택.Controls.Add(this.button23, 3, 4);
            this.주_선택.Controls.Add(this.button24, 2, 4);
            this.주_선택.Controls.Add(this.button25, 1, 4);
            this.주_선택.Controls.Add(this.button26, 0, 4);
            this.주_선택.Controls.Add(this.label33, 0, 2);
            this.주_선택.Controls.Add(this.button3, 1, 1);
            this.주_선택.Controls.Add(this.button5, 2, 1);
            this.주_선택.Controls.Add(this.button6, 3, 1);
            this.주_선택.Controls.Add(this.button7, 4, 1);
            this.주_선택.Controls.Add(this.button8, 5, 1);
            this.주_선택.Location = new System.Drawing.Point(1520, 435);
            this.주_선택.Name = "주_선택";
            this.주_선택.RowCount = 5;
            this.주_선택.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.주_선택.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.주_선택.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.주_선택.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.주_선택.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.주_선택.Size = new System.Drawing.Size(329, 183);
            this.주_선택.TabIndex = 1;
            this.주_선택.Visible = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(3, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 30);
            this.button4.TabIndex = 0;
            this.button4.Text = "100%";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button15.Location = new System.Drawing.Point(3, 111);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(48, 30);
            this.button15.TabIndex = 0;
            this.button15.Text = "0";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button16.Location = new System.Drawing.Point(57, 111);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(48, 30);
            this.button16.TabIndex = 0;
            this.button16.Text = "1";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button17.Location = new System.Drawing.Point(111, 111);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(48, 30);
            this.button17.TabIndex = 0;
            this.button17.Text = "5";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button18.Location = new System.Drawing.Point(165, 111);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(48, 30);
            this.button18.TabIndex = 0;
            this.button18.Text = "10";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button19.Location = new System.Drawing.Point(219, 111);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(48, 30);
            this.button19.TabIndex = 0;
            this.button19.Text = "50";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button20.Location = new System.Drawing.Point(273, 111);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(53, 30);
            this.button20.TabIndex = 0;
            this.button20.Text = "100";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(3, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(48, 36);
            this.label35.TabIndex = 26;
            this.label35.Text = "고정(%)";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button22
            // 
            this.button22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button22.Location = new System.Drawing.Point(219, 147);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(48, 33);
            this.button22.TabIndex = 0;
            this.button22.Text = "1000";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button23.Location = new System.Drawing.Point(165, 147);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(48, 33);
            this.button23.TabIndex = 0;
            this.button23.Text = "500";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button24.Location = new System.Drawing.Point(111, 147);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(48, 33);
            this.button24.TabIndex = 0;
            this.button24.Text = "400";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button25.Location = new System.Drawing.Point(57, 147);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(48, 33);
            this.button25.TabIndex = 0;
            this.button25.Text = "300";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button26.Location = new System.Drawing.Point(3, 147);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(48, 33);
            this.button26.TabIndex = 0;
            this.button26.Text = "200";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(3, 72);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(48, 36);
            this.label33.TabIndex = 26;
            this.label33.Text = "가중치";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(57, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 30);
            this.button3.TabIndex = 0;
            this.button3.Text = "75%";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(111, 39);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 30);
            this.button5.TabIndex = 0;
            this.button5.Text = "50%";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(165, 39);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 30);
            this.button6.TabIndex = 0;
            this.button6.Text = "25%";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(219, 39);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(48, 30);
            this.button7.TabIndex = 0;
            this.button7.Text = "10%";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(273, 39);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(53, 30);
            this.button8.TabIndex = 0;
            this.button8.Text = "5%";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.주_선택);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.종목리스트);
            this.Controls.Add(this.검색창);
            this.Controls.Add(this.검색버튼);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.axKHOpenAPI1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "l";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.종목리스트.ResumeLayout(false);
            this.종목리스트.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.매수_가격)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.매수_수량)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.매도_가격)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.매도_수량)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.주_선택.ResumeLayout(false);
            this.주_선택.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 로그인ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button 검색버튼;
        private System.Windows.Forms.TextBox 검색창;
        private System.Windows.Forms.TableLayoutPanel 종목리스트;
        private System.Windows.Forms.Label 종목명;
        private System.Windows.Forms.Label 고가;
        private System.Windows.Forms.Label 저가;
        private System.Windows.Forms.Label 전일대비;
        private System.Windows.Forms.Label 거래량;
        private System.Windows.Forms.Label 거래대금;
        private System.Windows.Forms.Label id1;
        private System.Windows.Forms.Label id2;
        private System.Windows.Forms.ComboBox 계좌번호콤보;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox 매수_시장가;
        private System.Windows.Forms.CheckBox 매수_현재가;
        private System.Windows.Forms.NumericUpDown 매수_가격;
        private System.Windows.Forms.NumericUpDown 매수_수량;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button 매수_매수버튼;
        private System.Windows.Forms.Button 매수_주;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button 매도_매도버튼;
        private System.Windows.Forms.NumericUpDown 매도_가격;
        private System.Windows.Forms.Button 매도_주;
        private System.Windows.Forms.NumericUpDown 매도_수량;
        private System.Windows.Forms.CheckBox 매도_시장가;
        private System.Windows.Forms.CheckBox 매도_현재가;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label 등락률;
        private System.Windows.Forms.Label 체결강도;
        private System.Windows.Forms.Label 현재가;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 전일;
        private System.Windows.Forms.DataGridViewTextBoxColumn 금일;
        private System.Windows.Forms.DataGridViewTextBoxColumn 평균단가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계좌_현재가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계좌_평가손익;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계좌_수익;
        private System.Windows.Forms.TableLayoutPanel 주_선택;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}


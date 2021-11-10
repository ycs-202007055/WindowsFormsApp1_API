
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.로그인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.계좌번호콤보 = new System.Windows.Forms.ComboBox();
            this.검색버튼 = new System.Windows.Forms.Button();
            this.검색창 = new System.Windows.Forms.TextBox();
            this.종목리스트 = new System.Windows.Forms.TableLayoutPanel();
            this.id1 = new System.Windows.Forms.Label();
            this.id2 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "계좌번호";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(426, 27);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(909, 469);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(426, 493);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
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
            this.label3.Location = new System.Drawing.Point(4, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "당일 손익금";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "당일 손익률";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "예수금";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "총매입금액";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.계좌번호콤보, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(196, 124);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 26);
            this.label10.TabIndex = 20;
            this.label10.Text = "label10";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "label7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "label8";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "label9";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 계좌번호콤보
            // 
            this.계좌번호콤보.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.계좌번호콤보.FormattingEnabled = true;
            this.계좌번호콤보.Location = new System.Drawing.Point(80, 4);
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
            this.종목리스트.Controls.Add(this.id1, 0, 0);
            this.종목리스트.Controls.Add(this.id2, 1, 0);
            this.종목리스트.Location = new System.Drawing.Point(1614, 28);
            this.종목리스트.Name = "종목리스트";
            this.종목리스트.RowCount = 2;
            this.종목리스트.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.종목리스트.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.종목리스트.Size = new System.Drawing.Size(290, 796);
            this.종목리스트.TabIndex = 20;
            // 
            // id1
            // 
            this.id1.AutoSize = true;
            this.id1.Location = new System.Drawing.Point(3, 0);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(44, 12);
            this.id1.TabIndex = 0;
            this.id1.Text = "label11";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.종목리스트);
            this.Controls.Add(this.검색창);
            this.Controls.Add(this.검색버튼);
            this.Controls.Add(this.tableLayoutPanel1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 로그인ToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
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
    }
}


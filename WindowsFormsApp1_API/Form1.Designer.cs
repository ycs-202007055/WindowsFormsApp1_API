
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
            this.label2 = new System.Windows.Forms.Label();
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.검색버튼 = new System.Windows.Forms.Button();
            this.검색창 = new System.Windows.Forms.TextBox();
            this.종목리스트 = new System.Windows.Forms.TableLayoutPanel();
            this.종목명 = new System.Windows.Forms.Label();
            this.고가 = new System.Windows.Forms.Label();
            this.저가 = new System.Windows.Forms.Label();
            this.전일대비 = new System.Windows.Forms.Label();
            this.거래량 = new System.Windows.Forms.Label();
            this.거래대금 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "계좌번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F);
            this.label2.Location = new System.Drawing.Point(78, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "총매입금액";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(1190, 12);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(702, 507);
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
            this.chart2.Location = new System.Drawing.Point(1190, 525);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(702, 176);
            this.chart2.TabIndex = 11;
            this.chart2.Text = "chart2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "당일 손익금";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "당일 손익률";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "예수금";
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
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "총매입금액";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(145, 65);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(78, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "label10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "label9";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // 검색버튼
            // 
            this.검색버튼.Location = new System.Drawing.Point(852, 34);
            this.검색버튼.Name = "검색버튼";
            this.검색버튼.Size = new System.Drawing.Size(75, 23);
            this.검색버튼.TabIndex = 18;
            this.검색버튼.Text = "검색";
            this.검색버튼.UseVisualStyleBackColor = true;
            // 
            // 검색창
            // 
            this.검색창.Location = new System.Drawing.Point(746, 36);
            this.검색창.Name = "검색창";
            this.검색창.Size = new System.Drawing.Size(100, 21);
            this.검색창.TabIndex = 19;
            // 
            // 종목리스트
            // 
            this.종목리스트.ColumnCount = 2;
            this.종목리스트.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.종목리스트.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.종목리스트.Location = new System.Drawing.Point(746, 75);
            this.종목리스트.Name = "종목리스트";
            this.종목리스트.RowCount = 2;
            this.종목리스트.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.종목리스트.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.종목리스트.Size = new System.Drawing.Size(200, 100);
            this.종목리스트.TabIndex = 20;
            // 
            // 종목명
            // 
            this.종목명.AutoSize = true;
            this.종목명.Location = new System.Drawing.Point(167, 121);
            this.종목명.Name = "종목명";
            this.종목명.Size = new System.Drawing.Size(41, 12);
            this.종목명.TabIndex = 21;
            this.종목명.Text = "종목명";
            this.종목명.Click += new System.EventHandler(this.label11_Click);
            // 
            // 고가
            // 
            this.고가.AutoSize = true;
            this.고가.Location = new System.Drawing.Point(265, 121);
            this.고가.Name = "고가";
            this.고가.Size = new System.Drawing.Size(29, 12);
            this.고가.TabIndex = 21;
            this.고가.Text = "고가";
            // 
            // 저가
            // 
            this.저가.AutoSize = true;
            this.저가.Location = new System.Drawing.Point(265, 163);
            this.저가.Name = "저가";
            this.저가.Size = new System.Drawing.Size(29, 12);
            this.저가.TabIndex = 21;
            this.저가.Text = "저가";
            // 
            // 전일대비
            // 
            this.전일대비.AutoSize = true;
            this.전일대비.Location = new System.Drawing.Point(167, 153);
            this.전일대비.Name = "전일대비";
            this.전일대비.Size = new System.Drawing.Size(53, 12);
            this.전일대비.TabIndex = 21;
            this.전일대비.Text = "전일대비";
            this.전일대비.Click += new System.EventHandler(this.label11_Click);
            // 
            // 거래량
            // 
            this.거래량.AutoSize = true;
            this.거래량.Location = new System.Drawing.Point(348, 121);
            this.거래량.Name = "거래량";
            this.거래량.Size = new System.Drawing.Size(41, 12);
            this.거래량.TabIndex = 21;
            this.거래량.Text = "거래량";
            this.거래량.Click += new System.EventHandler(this.label11_Click);
            // 
            // 거래대금
            // 
            this.거래대금.AutoSize = true;
            this.거래대금.Location = new System.Drawing.Point(348, 163);
            this.거래대금.Name = "거래대금";
            this.거래대금.Size = new System.Drawing.Size(53, 12);
            this.거래대금.TabIndex = 21;
            this.거래대금.Text = "거래대금";
            this.거래대금.Click += new System.EventHandler(this.label11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.저가);
            this.Controls.Add(this.고가);
            this.Controls.Add(this.거래대금);
            this.Controls.Add(this.거래량);
            this.Controls.Add(this.전일대비);
            this.Controls.Add(this.종목명);
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
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button 검색버튼;
        private System.Windows.Forms.TextBox 검색창;
        private System.Windows.Forms.TableLayoutPanel 종목리스트;
        private System.Windows.Forms.Label 종목명;
        private System.Windows.Forms.Label 고가;
        private System.Windows.Forms.Label 저가;
        private System.Windows.Forms.Label 전일대비;
        private System.Windows.Forms.Label 거래량;
        private System.Windows.Forms.Label 거래대금;
    }
}


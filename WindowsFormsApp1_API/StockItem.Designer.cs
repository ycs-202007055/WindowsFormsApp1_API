﻿
namespace WindowsFormsApp1_API
{
    partial class StockItem
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.종목명 = new System.Windows.Forms.Label();
            this.현재가 = new System.Windows.Forms.Label();
            this.등락률 = new System.Windows.Forms.Label();
            this.거래대금 = new System.Windows.Forms.Label();
            this.전일대비 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 종목명
            // 
            this.종목명.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.종목명.AutoSize = true;
            this.종목명.Location = new System.Drawing.Point(3, 0);
            this.종목명.Name = "종목명";
            this.종목명.Size = new System.Drawing.Size(66, 17);
            this.종목명.TabIndex = 0;
            this.종목명.Text = "0";
            // 
            // 현재가
            // 
            this.현재가.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.현재가.AutoSize = true;
            this.현재가.Location = new System.Drawing.Point(75, 0);
            this.현재가.Name = "현재가";
            this.현재가.Size = new System.Drawing.Size(66, 17);
            this.현재가.TabIndex = 1;
            this.현재가.Text = "0";
            // 
            // 등락률
            // 
            this.등락률.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.등락률.AutoSize = true;
            this.등락률.Location = new System.Drawing.Point(147, 0);
            this.등락률.Name = "등락률";
            this.등락률.Size = new System.Drawing.Size(66, 17);
            this.등락률.TabIndex = 1;
            this.등락률.Text = "0";
            // 
            // 거래대금
            // 
            this.거래대금.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.거래대금.AutoSize = true;
            this.거래대금.Location = new System.Drawing.Point(219, 0);
            this.거래대금.Name = "거래대금";
            this.거래대금.Size = new System.Drawing.Size(69, 17);
            this.거래대금.TabIndex = 1;
            this.거래대금.Text = "0";
            // 
            // 전일대비
            // 
            this.전일대비.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.전일대비.AutoSize = true;
            this.전일대비.Font = new System.Drawing.Font("굴림", 7F);
            this.전일대비.Location = new System.Drawing.Point(147, 17);
            this.전일대비.Name = "전일대비";
            this.전일대비.Size = new System.Drawing.Size(66, 18);
            this.전일대비.TabIndex = 2;
            this.전일대비.Text = "0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.종목명, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.전일대비, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.현재가, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.거래대금, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.등락률, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(291, 35);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // StockItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "StockItem";
            this.Size = new System.Drawing.Size(292, 35);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label 종목명;
        private System.Windows.Forms.Label 현재가;
        private System.Windows.Forms.Label 등락률;
        private System.Windows.Forms.Label 거래대금;
        private System.Windows.Forms.Label 전일대비;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

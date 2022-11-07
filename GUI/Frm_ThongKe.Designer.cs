namespace GUI
{
    partial class Frm_ThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.BieuDoDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.BieuDoDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // BieuDoDoanhThu
            // 
            this.BieuDoDoanhThu.BackColor = System.Drawing.Color.Lime;
            chartArea1.Name = "ChartArea1";
            this.BieuDoDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BieuDoDoanhThu.Legends.Add(legend1);
            this.BieuDoDoanhThu.Location = new System.Drawing.Point(12, 12);
            this.BieuDoDoanhThu.Name = "BieuDoDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "DoanhThu";
            this.BieuDoDoanhThu.Series.Add(series1);
            this.BieuDoDoanhThu.Size = new System.Drawing.Size(1108, 680);
            this.BieuDoDoanhThu.TabIndex = 0;
            this.BieuDoDoanhThu.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title1.Name = "Title1";
            title1.Text = "Biểu đồ doanh thu các tháng";
            this.BieuDoDoanhThu.Titles.Add(title1);
            // 
            // Frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 704);
            this.Controls.Add(this.BieuDoDoanhThu);
            this.Name = "Frm_ThongKe";
            this.Text = "Frm_ThongKe";
            this.Load += new System.EventHandler(this.Frm_ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BieuDoDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BieuDoDoanhThu;
    }
}
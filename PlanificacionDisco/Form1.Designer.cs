namespace PlanificacionDisco
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQueue = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.chartPrincipal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCscan = new System.Windows.Forms.Label();
            this.lblScan = new System.Windows.Forms.Label();
            this.lblSsf = new System.Windows.Forms.Label();
            this.lblFifo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrincipal)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInicio);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtQueue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSize);
            this.groupBox1.Controls.Add(this.btnGraficar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de almacenamiento";
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(9, 92);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(100, 20);
            this.txtInicio.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Punto de inicio";
            // 
            // txtQueue
            // 
            this.txtQueue.Location = new System.Drawing.Point(9, 166);
            this.txtQueue.Name = "txtQueue";
            this.txtQueue.Size = new System.Drawing.Size(214, 110);
            this.txtQueue.TabIndex = 5;
            this.txtQueue.Text = "";
            this.txtQueue.MouseHover += new System.EventHandler(this.txtQueue_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cola de peticiones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tamaño del disco:";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(9, 44);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 2;
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(0, 291);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(223, 94);
            this.btnGraficar.TabIndex = 1;
            this.btnGraficar.Text = "Graficar!";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // chartPrincipal
            // 
            this.chartPrincipal.BorderlineWidth = 3;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Bisque;
            chartArea1.Name = "ChartArea1";
            this.chartPrincipal.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPrincipal.Legends.Add(legend1);
            this.chartPrincipal.Location = new System.Drawing.Point(253, 12);
            this.chartPrincipal.Name = "chartPrincipal";
            this.chartPrincipal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.chartPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "FIFO";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "SSF";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "SCAN";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "C-SCAN";
            this.chartPrincipal.Series.Add(series1);
            this.chartPrincipal.Series.Add(series2);
            this.chartPrincipal.Series.Add(series3);
            this.chartPrincipal.Series.Add(series4);
            this.chartPrincipal.Size = new System.Drawing.Size(957, 345);
            this.chartPrincipal.TabIndex = 1;
            this.chartPrincipal.Text = "chartPrincipal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCscan);
            this.groupBox2.Controls.Add(this.lblScan);
            this.groupBox2.Controls.Add(this.lblSsf);
            this.groupBox2.Controls.Add(this.lblFifo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(253, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(957, 40);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desplazamientos Totales";
            // 
            // lblCscan
            // 
            this.lblCscan.AutoSize = true;
            this.lblCscan.Location = new System.Drawing.Point(573, 21);
            this.lblCscan.Name = "lblCscan";
            this.lblCscan.Size = new System.Drawing.Size(0, 13);
            this.lblCscan.TabIndex = 13;
            // 
            // lblScan
            // 
            this.lblScan.AutoSize = true;
            this.lblScan.Location = new System.Drawing.Point(354, 21);
            this.lblScan.Name = "lblScan";
            this.lblScan.Size = new System.Drawing.Size(0, 13);
            this.lblScan.TabIndex = 12;
            // 
            // lblSsf
            // 
            this.lblSsf.AutoSize = true;
            this.lblSsf.Location = new System.Drawing.Point(165, 22);
            this.lblSsf.Name = "lblSsf";
            this.lblSsf.Size = new System.Drawing.Size(0, 13);
            this.lblSsf.TabIndex = 11;
            // 
            // lblFifo
            // 
            this.lblFifo.AutoSize = true;
            this.lblFifo.Location = new System.Drawing.Point(45, 21);
            this.lblFifo.Name = "lblFifo";
            this.lblFifo.Size = new System.Drawing.Size(0, 13);
            this.lblFifo.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "C-SCAN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "SCAN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "SSF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "FIFO:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 415);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chartPrincipal);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Planificador de Disco";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrincipal)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.RichTextBox txtQueue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrincipal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCscan;
        private System.Windows.Forms.Label lblScan;
        private System.Windows.Forms.Label lblSsf;
        private System.Windows.Forms.Label lblFifo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.Label label7;
    }
}


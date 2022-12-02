
namespace ProiectLOL
{
    partial class Help
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTimpMentinere = new System.Windows.Forms.Label();
            this.labelTimpIncalzire = new System.Windows.Forms.Label();
            this.labelTemperaturaCritica = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Timp mentinere";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(208, 247);
            this.trackBar3.Minimum = 5;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(191, 56);
            this.trackBar3.TabIndex = 22;
            this.trackBar3.Value = 5;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Timp de incalzire";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(208, 156);
            this.trackBar2.Maximum = 60;
            this.trackBar2.Minimum = 10;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(191, 56);
            this.trackBar2.SmallChange = 5;
            this.trackBar2.TabIndex = 20;
            this.trackBar2.TickFrequency = 5;
            this.trackBar2.Value = 10;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Temperatura critica";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(208, 67);
            this.trackBar1.Maximum = 60;
            this.trackBar1.Minimum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(191, 56);
            this.trackBar1.TabIndex = 18;
            this.trackBar1.TabStop = false;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Value = 20;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 344);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 44);
            this.button1.TabIndex = 17;
            this.button1.Text = "APASA-MA, TE ROG";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelTimpMentinere
            // 
            this.labelTimpMentinere.AutoSize = true;
            this.labelTimpMentinere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelTimpMentinere.Location = new System.Drawing.Point(297, 227);
            this.labelTimpMentinere.Name = "labelTimpMentinere";
            this.labelTimpMentinere.Size = new System.Drawing.Size(24, 17);
            this.labelTimpMentinere.TabIndex = 26;
            this.labelTimpMentinere.Text = "10";
            // 
            // labelTimpIncalzire
            // 
            this.labelTimpIncalzire.AutoSize = true;
            this.labelTimpIncalzire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelTimpIncalzire.Location = new System.Drawing.Point(297, 136);
            this.labelTimpIncalzire.Name = "labelTimpIncalzire";
            this.labelTimpIncalzire.Size = new System.Drawing.Size(24, 17);
            this.labelTimpIncalzire.TabIndex = 25;
            this.labelTimpIncalzire.Text = "10";
            // 
            // labelTemperaturaCritica
            // 
            this.labelTemperaturaCritica.AutoSize = true;
            this.labelTemperaturaCritica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelTemperaturaCritica.Location = new System.Drawing.Point(297, 47);
            this.labelTemperaturaCritica.Name = "labelTemperaturaCritica";
            this.labelTemperaturaCritica.Size = new System.Drawing.Size(24, 17);
            this.labelTemperaturaCritica.TabIndex = 24;
            this.labelTemperaturaCritica.Text = "20";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(708, 227);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(538, 273);
            this.chart1.TabIndex = 28;
            this.chart1.Text = "Temperatura";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(849, 151);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 29;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1297, 569);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelTimpMentinere);
            this.Controls.Add(this.labelTimpIncalzire);
            this.Controls.Add(this.labelTemperaturaCritica);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Name = "Help";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Help_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTimpMentinere;
        private System.Windows.Forms.Label labelTimpIncalzire;
        private System.Windows.Forms.Label labelTemperaturaCritica;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
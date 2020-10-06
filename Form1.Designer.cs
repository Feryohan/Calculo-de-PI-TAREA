namespace Calculo_de_PI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxResultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxError = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxPi = new System.Windows.Forms.TextBox();
            this.chartPi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.bttnResolver = new System.Windows.Forms.Button();
            this.txtBoxTerminos = new System.Windows.Forms.TextBox();
            this.bttnLimpiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chartPendiente = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxPendiente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartPi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPendiente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calcularemos pi utilizando la serie de Basilea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número de términos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resultado";
            // 
            // txtBoxResultado
            // 
            this.txtBoxResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxResultado.Location = new System.Drawing.Point(496, 65);
            this.txtBoxResultado.Name = "txtBoxResultado";
            this.txtBoxResultado.ReadOnly = true;
            this.txtBoxResultado.Size = new System.Drawing.Size(221, 24);
            this.txtBoxResultado.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "% de error";
            // 
            // txtBoxError
            // 
            this.txtBoxError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxError.Location = new System.Drawing.Point(496, 110);
            this.txtBoxError.Name = "txtBoxError";
            this.txtBoxError.ReadOnly = true;
            this.txtBoxError.Size = new System.Drawing.Size(221, 24);
            this.txtBoxError.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(781, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Valor de pi";
            // 
            // txtBoxPi
            // 
            this.txtBoxPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPi.Location = new System.Drawing.Point(871, 19);
            this.txtBoxPi.Name = "txtBoxPi";
            this.txtBoxPi.ReadOnly = true;
            this.txtBoxPi.Size = new System.Drawing.Size(221, 24);
            this.txtBoxPi.TabIndex = 4;
            // 
            // chartPi
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPi.Legends.Add(legend1);
            this.chartPi.Location = new System.Drawing.Point(26, 172);
            this.chartPi.Name = "chartPi";
            this.chartPi.Size = new System.Drawing.Size(626, 491);
            this.chartPi.TabIndex = 5;
            this.chartPi.Text = "chart1";
            // 
            // Timer
            // 
            this.Timer.Interval = 50;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // bttnResolver
            // 
            this.bttnResolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bttnResolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnResolver.Location = new System.Drawing.Point(817, 58);
            this.bttnResolver.Name = "bttnResolver";
            this.bttnResolver.Size = new System.Drawing.Size(95, 38);
            this.bttnResolver.TabIndex = 6;
            this.bttnResolver.Text = "Resolver";
            this.bttnResolver.UseVisualStyleBackColor = false;
            this.bttnResolver.Click += new System.EventHandler(this.BttnResolver_Click);
            // 
            // txtBoxTerminos
            // 
            this.txtBoxTerminos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTerminos.Location = new System.Drawing.Point(553, 19);
            this.txtBoxTerminos.Name = "txtBoxTerminos";
            this.txtBoxTerminos.Size = new System.Drawing.Size(188, 24);
            this.txtBoxTerminos.TabIndex = 4;
            // 
            // bttnLimpiar
            // 
            this.bttnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLimpiar.Location = new System.Drawing.Point(943, 58);
            this.bttnLimpiar.Name = "bttnLimpiar";
            this.bttnLimpiar.Size = new System.Drawing.Size(95, 38);
            this.bttnLimpiar.TabIndex = 6;
            this.bttnLimpiar.Text = "Limpiar";
            this.bttnLimpiar.UseVisualStyleBackColor = false;
            this.bttnLimpiar.Click += new System.EventHandler(this.BttnLimpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculo_de_PI.Properties.Resources.Basilea;
            this.pictureBox1.Location = new System.Drawing.Point(109, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // chartPendiente
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPendiente.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPendiente.Legends.Add(legend2);
            this.chartPendiente.Location = new System.Drawing.Point(679, 172);
            this.chartPendiente.Name = "chartPendiente";
            this.chartPendiente.Size = new System.Drawing.Size(626, 491);
            this.chartPendiente.TabIndex = 5;
            this.chartPendiente.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(301, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Valor de pi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(924, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Valor de la pendiente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(781, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Pendiente";
            // 
            // txtBoxPendiente
            // 
            this.txtBoxPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPendiente.Location = new System.Drawing.Point(871, 113);
            this.txtBoxPendiente.Name = "txtBoxPendiente";
            this.txtBoxPendiente.ReadOnly = true;
            this.txtBoxPendiente.Size = new System.Drawing.Size(221, 24);
            this.txtBoxPendiente.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1293, 654);
            this.Controls.Add(this.bttnLimpiar);
            this.Controls.Add(this.bttnResolver);
            this.Controls.Add(this.chartPendiente);
            this.Controls.Add(this.chartPi);
            this.Controls.Add(this.txtBoxError);
            this.Controls.Add(this.txtBoxPendiente);
            this.Controls.Add(this.txtBoxPi);
            this.Controls.Add(this.txtBoxTerminos);
            this.Controls.Add(this.txtBoxResultado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Cálculo de PI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPendiente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxError;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxPi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPi;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button bttnResolver;
        private System.Windows.Forms.TextBox txtBoxTerminos;
        private System.Windows.Forms.Button bttnLimpiar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPendiente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxPendiente;
    }
}


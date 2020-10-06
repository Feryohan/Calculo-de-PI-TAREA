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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPi)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Calculo_de_PI.Properties.Resources.SeriePI;
            this.pictureBox1.Location = new System.Drawing.Point(28, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 66);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calcularemos pi utilizando la siguiente serie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número de términos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resultado";
            // 
            // txtBoxResultado
            // 
            this.txtBoxResultado.Location = new System.Drawing.Point(496, 61);
            this.txtBoxResultado.Name = "txtBoxResultado";
            this.txtBoxResultado.ReadOnly = true;
            this.txtBoxResultado.Size = new System.Drawing.Size(221, 20);
            this.txtBoxResultado.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "% de error";
            // 
            // txtBoxError
            // 
            this.txtBoxError.Location = new System.Drawing.Point(496, 95);
            this.txtBoxError.Name = "txtBoxError";
            this.txtBoxError.ReadOnly = true;
            this.txtBoxError.Size = new System.Drawing.Size(221, 20);
            this.txtBoxError.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(737, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Valor de pi";
            // 
            // txtBoxPi
            // 
            this.txtBoxPi.Location = new System.Drawing.Point(808, 31);
            this.txtBoxPi.Name = "txtBoxPi";
            this.txtBoxPi.ReadOnly = true;
            this.txtBoxPi.Size = new System.Drawing.Size(221, 20);
            this.txtBoxPi.TabIndex = 4;
            // 
            // chartPi
            // 
            chartArea4.Name = "ChartArea1";
            this.chartPi.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartPi.Legends.Add(legend4);
            this.chartPi.Location = new System.Drawing.Point(28, 151);
            this.chartPi.Name = "chartPi";
            this.chartPi.Size = new System.Drawing.Size(656, 339);
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
            this.bttnResolver.Location = new System.Drawing.Point(740, 72);
            this.bttnResolver.Name = "bttnResolver";
            this.bttnResolver.Size = new System.Drawing.Size(75, 23);
            this.bttnResolver.TabIndex = 6;
            this.bttnResolver.Text = "Resolver";
            this.bttnResolver.UseVisualStyleBackColor = true;
            this.bttnResolver.Click += new System.EventHandler(this.BttnResolver_Click);
            // 
            // txtBoxTerminos
            // 
            this.txtBoxTerminos.Location = new System.Drawing.Point(529, 31);
            this.txtBoxTerminos.Name = "txtBoxTerminos";
            this.txtBoxTerminos.Size = new System.Drawing.Size(188, 20);
            this.txtBoxTerminos.TabIndex = 4;
            // 
            // bttnLimpiar
            // 
            this.bttnLimpiar.Location = new System.Drawing.Point(844, 72);
            this.bttnLimpiar.Name = "bttnLimpiar";
            this.bttnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bttnLimpiar.TabIndex = 6;
            this.bttnLimpiar.Text = "Limpiar";
            this.bttnLimpiar.UseVisualStyleBackColor = true;
            this.bttnLimpiar.Click += new System.EventHandler(this.BttnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1293, 577);
            this.Controls.Add(this.bttnLimpiar);
            this.Controls.Add(this.bttnResolver);
            this.Controls.Add(this.chartPi);
            this.Controls.Add(this.txtBoxError);
            this.Controls.Add(this.txtBoxPi);
            this.Controls.Add(this.txtBoxTerminos);
            this.Controls.Add(this.txtBoxResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Cálculo de PI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPi)).EndInit();
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
    }
}


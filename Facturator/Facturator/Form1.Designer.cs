namespace Facturator
{
    partial class Facturacion
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
            this.calcularButton = new System.Windows.Forms.Button();
            this.p1quantity = new System.Windows.Forms.TextBox();
            this.p2quantity = new System.Windows.Forms.TextBox();
            this.p3quantity = new System.Windows.Forms.TextBox();
            this.p1label = new System.Windows.Forms.Label();
            this.p2label = new System.Windows.Forms.Label();
            this.p3label = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sinIva = new System.Windows.Forms.Label();
            this.guardar = new System.Windows.Forms.Button();
            this.vaciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(29, 250);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(75, 23);
            this.calcularButton.TabIndex = 0;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // p1quantity
            // 
            this.p1quantity.Location = new System.Drawing.Point(172, 68);
            this.p1quantity.Name = "p1quantity";
            this.p1quantity.Size = new System.Drawing.Size(100, 20);
            this.p1quantity.TabIndex = 1;
            this.p1quantity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // p2quantity
            // 
            this.p2quantity.Location = new System.Drawing.Point(172, 110);
            this.p2quantity.Name = "p2quantity";
            this.p2quantity.Size = new System.Drawing.Size(100, 20);
            this.p2quantity.TabIndex = 2;
            this.p2quantity.TextChanged += new System.EventHandler(this.p2quantity_TextChanged);
            // 
            // p3quantity
            // 
            this.p3quantity.Location = new System.Drawing.Point(172, 154);
            this.p3quantity.Name = "p3quantity";
            this.p3quantity.Size = new System.Drawing.Size(100, 20);
            this.p3quantity.TabIndex = 3;
            this.p3quantity.TextChanged += new System.EventHandler(this.p3quantity_TextChanged);
            // 
            // p1label
            // 
            this.p1label.AutoSize = true;
            this.p1label.Location = new System.Drawing.Point(26, 75);
            this.p1label.Name = "p1label";
            this.p1label.Size = new System.Drawing.Size(35, 13);
            this.p1label.TabIndex = 4;
            this.p1label.Text = "label1";
            this.p1label.Click += new System.EventHandler(this.label1_Click);
            // 
            // p2label
            // 
            this.p2label.AutoSize = true;
            this.p2label.Location = new System.Drawing.Point(26, 117);
            this.p2label.Name = "p2label";
            this.p2label.Size = new System.Drawing.Size(35, 13);
            this.p2label.TabIndex = 5;
            this.p2label.Text = "label2";
            this.p2label.Click += new System.EventHandler(this.label2_Click);
            // 
            // p3label
            // 
            this.p3label.AutoSize = true;
            this.p3label.Location = new System.Drawing.Point(26, 161);
            this.p3label.Name = "p3label";
            this.p3label.Size = new System.Drawing.Size(35, 13);
            this.p3label.TabIndex = 6;
            this.p3label.Text = "label3";
            this.p3label.Click += new System.EventHandler(this.label3_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(137, 216);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(86, 13);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "TOTAL con IVA:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(241, 216);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(13, 13);
            this.totalPriceLabel.TabIndex = 8;
            this.totalPriceLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "TOTAL sin IVA:";
            // 
            // sinIva
            // 
            this.sinIva.AutoSize = true;
            this.sinIva.Location = new System.Drawing.Point(241, 192);
            this.sinIva.Name = "sinIva";
            this.sinIva.Size = new System.Drawing.Size(13, 13);
            this.sinIva.TabIndex = 12;
            this.sinIva.Text = "0";
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(179, 250);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 13;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // vaciar
            // 
            this.vaciar.Location = new System.Drawing.Point(29, 206);
            this.vaciar.Name = "vaciar";
            this.vaciar.Size = new System.Drawing.Size(75, 23);
            this.vaciar.TabIndex = 14;
            this.vaciar.Text = "Vaciar";
            this.vaciar.UseVisualStyleBackColor = true;
            this.vaciar.Click += new System.EventHandler(this.vaciar_Click);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 296);
            this.Controls.Add(this.vaciar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.sinIva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.p3label);
            this.Controls.Add(this.p2label);
            this.Controls.Add(this.p1label);
            this.Controls.Add(this.p3quantity);
            this.Controls.Add(this.p2quantity);
            this.Controls.Add(this.p1quantity);
            this.Controls.Add(this.calcularButton);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.TextBox p1quantity;
        private System.Windows.Forms.TextBox p2quantity;
        private System.Windows.Forms.TextBox p3quantity;
        private System.Windows.Forms.Label p1label;
        private System.Windows.Forms.Label p2label;
        private System.Windows.Forms.Label p3label;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sinIva;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button vaciar;
    }
}


namespace Sistema_Playa_Estacionamiento
{
    partial class Pagar
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
            this.dtgwPagar = new System.Windows.Forms.DataGridView();
            this.btnPagar = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnBoletas = new System.Windows.Forms.Button();
            this.rbBoleta = new System.Windows.Forms.RadioButton();
            this.rbFactura = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgwPagar
            // 
            this.dtgwPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwPagar.Location = new System.Drawing.Point(27, 163);
            this.dtgwPagar.Name = "dtgwPagar";
            this.dtgwPagar.Size = new System.Drawing.Size(722, 246);
            this.dtgwPagar.TabIndex = 1;
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(505, 88);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(215, 28);
            this.btnPagar.TabIndex = 8;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(275, 88);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(180, 31);
            this.txtPlaca.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(573, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingresar la placa del cliente que va a realizar el pago";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(58, 428);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(278, 48);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBoletas
            // 
            this.btnBoletas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoletas.Location = new System.Drawing.Point(402, 428);
            this.btnBoletas.Name = "btnBoletas";
            this.btnBoletas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBoletas.Size = new System.Drawing.Size(278, 48);
            this.btnBoletas.TabIndex = 10;
            this.btnBoletas.Text = "Ver Boletas";
            this.btnBoletas.UseVisualStyleBackColor = true;
            this.btnBoletas.Click += new System.EventHandler(this.btnBoletas_Click);
            // 
            // rbBoleta
            // 
            this.rbBoleta.AutoSize = true;
            this.rbBoleta.Location = new System.Drawing.Point(58, 88);
            this.rbBoleta.Name = "rbBoleta";
            this.rbBoleta.Size = new System.Drawing.Size(55, 17);
            this.rbBoleta.TabIndex = 11;
            this.rbBoleta.TabStop = true;
            this.rbBoleta.Text = "Boleta";
            this.rbBoleta.UseVisualStyleBackColor = true;
            // 
            // rbFactura
            // 
            this.rbFactura.AutoSize = true;
            this.rbFactura.Location = new System.Drawing.Point(58, 121);
            this.rbFactura.Name = "rbFactura";
            this.rbFactura.Size = new System.Drawing.Size(61, 17);
            this.rbFactura.TabIndex = 12;
            this.rbFactura.TabStop = true;
            this.rbFactura.Text = "Factura";
            this.rbFactura.UseVisualStyleBackColor = true;
            // 
            // Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 499);
            this.Controls.Add(this.rbFactura);
            this.Controls.Add(this.rbBoleta);
            this.Controls.Add(this.btnBoletas);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgwPagar);
            this.Name = "Pagar";
            this.Text = "Pagar";
            this.Load += new System.EventHandler(this.Pagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgwPagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgwPagar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBoletas;
        private System.Windows.Forms.RadioButton rbBoleta;
        private System.Windows.Forms.RadioButton rbFactura;
    }
}
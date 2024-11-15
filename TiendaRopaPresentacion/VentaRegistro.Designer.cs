namespace TiendaRopaPresentacion
{
    partial class VentaRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentaRegistro));
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDowncantidad = new System.Windows.Forms.NumericUpDown();
            this.buttonañadircarro = new System.Windows.Forms.Button();
            this.buttonguardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxProducto = new System.Windows.Forms.ComboBox();
            this.textBoxMontoPago = new System.Windows.Forms.TextBox();
            this.textBoxMontoCambio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_VENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowncantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTotal.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new System.Drawing.Point(465, 456);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 25);
            this.textBoxTotal.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(473, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 70;
            this.label4.Text = "Cantidad";
            // 
            // numericUpDowncantidad
            // 
            this.numericUpDowncantidad.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDowncantidad.Location = new System.Drawing.Point(476, 133);
            this.numericUpDowncantidad.Name = "numericUpDowncantidad";
            this.numericUpDowncantidad.Size = new System.Drawing.Size(69, 29);
            this.numericUpDowncantidad.TabIndex = 69;
            // 
            // buttonañadircarro
            // 
            this.buttonañadircarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonañadircarro.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonañadircarro.Location = new System.Drawing.Point(402, 185);
            this.buttonañadircarro.Name = "buttonañadircarro";
            this.buttonañadircarro.Size = new System.Drawing.Size(163, 48);
            this.buttonañadircarro.TabIndex = 68;
            this.buttonañadircarro.Text = "Agregar Producto";
            this.buttonañadircarro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonañadircarro.UseVisualStyleBackColor = false;
            this.buttonañadircarro.Click += new System.EventHandler(this.buttonañadircarro_Click);
            // 
            // buttonguardar
            // 
            this.buttonguardar.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonguardar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonguardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonguardar.Image")));
            this.buttonguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonguardar.Location = new System.Drawing.Point(571, 368);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(150, 72);
            this.buttonguardar.TabIndex = 65;
            this.buttonguardar.Text = "Guardar Venta";
            this.buttonguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonguardar.UseVisualStyleBackColor = false;
            this.buttonguardar.Click += new System.EventHandler(this.buttonguardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUCTO,
            this.Producto,
            this.CANTIDAD,
            this.PRECIO_VENTA,
            this.TOTAL});
            this.dataGridView1.Location = new System.Drawing.Point(21, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 192);
            this.dataGridView1.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 21);
            this.label5.TabIndex = 63;
            this.label5.Text = "Seleccionar Producto";
            // 
            // comboBoxProducto
            // 
            this.comboBoxProducto.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProducto.FormattingEnabled = true;
            this.comboBoxProducto.Location = new System.Drawing.Point(247, 135);
            this.comboBoxProducto.Name = "comboBoxProducto";
            this.comboBoxProducto.Size = new System.Drawing.Size(201, 29);
            this.comboBoxProducto.TabIndex = 62;
            this.comboBoxProducto.SelectedIndexChanged += new System.EventHandler(this.comboBoxProducto_SelectedIndexChanged);
            // 
            // textBoxMontoPago
            // 
            this.textBoxMontoPago.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxMontoPago.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMontoPago.Location = new System.Drawing.Point(575, 269);
            this.textBoxMontoPago.Name = "textBoxMontoPago";
            this.textBoxMontoPago.Size = new System.Drawing.Size(146, 25);
            this.textBoxMontoPago.TabIndex = 61;
            this.textBoxMontoPago.TextChanged += new System.EventHandler(this.textBoxMontoPago_TextChanged);
            // 
            // textBoxMontoCambio
            // 
            this.textBoxMontoCambio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxMontoCambio.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMontoCambio.Location = new System.Drawing.Point(575, 336);
            this.textBoxMontoCambio.Name = "textBoxMontoCambio";
            this.textBoxMontoCambio.Size = new System.Drawing.Size(146, 25);
            this.textBoxMontoCambio.TabIndex = 60;
            this.textBoxMontoCambio.TextChanged += new System.EventHandler(this.textBoxMontoCambio_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(571, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 59;
            this.label3.Text = "Monto Pago : *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(576, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 58;
            this.label2.Text = "Monto Cambio : *";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 49);
            this.panel1.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Ventas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 21);
            this.label6.TabIndex = 73;
            this.label6.Text = "Seleccionar Cliente";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(16, 135);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(201, 29);
            this.comboBoxCliente.TabIndex = 72;
            this.comboBoxCliente.SelectedIndexChanged += new System.EventHandler(this.comboBoxCliente_SelectedIndexChanged);
            // 
            // ID_PRODUCTO
            // 
            this.ID_PRODUCTO.HeaderText = "ID PRODUCTO";
            this.ID_PRODUCTO.Name = "ID_PRODUCTO";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "PRODUCTO";
            this.Producto.Name = "Producto";
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            // 
            // PRECIO_VENTA
            // 
            this.PRECIO_VENTA.HeaderText = "PRECIO VENTA";
            this.PRECIO_VENTA.Name = "PRECIO_VENTA";
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            // 
            // VentaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(979, 525);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDowncantidad);
            this.Controls.Add(this.buttonañadircarro);
            this.Controls.Add(this.buttonguardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxProducto);
            this.Controls.Add(this.textBoxMontoPago);
            this.Controls.Add(this.textBoxMontoCambio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "VentaRegistro";
            this.Text = "VentaRegistro";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowncantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDowncantidad;
        private System.Windows.Forms.Button buttonañadircarro;
        private System.Windows.Forms.Button buttonguardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxProducto;
        private System.Windows.Forms.TextBox textBoxMontoPago;
        private System.Windows.Forms.TextBox textBoxMontoCambio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_VENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
    }
}
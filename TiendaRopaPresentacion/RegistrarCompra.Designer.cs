namespace TiendaRopaPresentacion
{
    partial class RegistrarCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarCompra));
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxproveedor = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxProducto = new System.Windows.Forms.ComboBox();
            this.textBoxtipoDoc = new System.Windows.Forms.TextBox();
            this.textBoxNumDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonañadircarro = new System.Windows.Forms.Button();
            this.numericUpDowncantidad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonguardar = new System.Windows.Forms.Button();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_VENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowncantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(234, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 21);
            this.label7.TabIndex = 52;
            this.label7.Text = "Seleccionar Proveedor";
            // 
            // comboBoxproveedor
            // 
            this.comboBoxproveedor.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxproveedor.FormattingEnabled = true;
            this.comboBoxproveedor.Location = new System.Drawing.Point(238, 123);
            this.comboBoxproveedor.Name = "comboBoxproveedor";
            this.comboBoxproveedor.Size = new System.Drawing.Size(201, 29);
            this.comboBoxproveedor.TabIndex = 51;
            this.comboBoxproveedor.SelectedIndexChanged += new System.EventHandler(this.comboBoxproveedor_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUCTO,
            this.pp,
            this.CANTIDAD,
            this.PRECIO_COMPRA,
            this.PRECIO_VENTA,
            this.TOTAL});
            this.dataGridView1.Location = new System.Drawing.Point(21, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 192);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(234, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 21);
            this.label5.TabIndex = 45;
            this.label5.Text = "Seleccionar Producto";
            // 
            // comboBoxProducto
            // 
            this.comboBoxProducto.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProducto.FormattingEnabled = true;
            this.comboBoxProducto.Location = new System.Drawing.Point(238, 194);
            this.comboBoxProducto.Name = "comboBoxProducto";
            this.comboBoxProducto.Size = new System.Drawing.Size(201, 29);
            this.comboBoxProducto.TabIndex = 44;
            this.comboBoxProducto.SelectedIndexChanged += new System.EventHandler(this.comboBoxProducto_SelectedIndexChanged);
            // 
            // textBoxtipoDoc
            // 
            this.textBoxtipoDoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxtipoDoc.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtipoDoc.Location = new System.Drawing.Point(21, 127);
            this.textBoxtipoDoc.Name = "textBoxtipoDoc";
            this.textBoxtipoDoc.Size = new System.Drawing.Size(199, 25);
            this.textBoxtipoDoc.TabIndex = 42;
            this.textBoxtipoDoc.TextChanged += new System.EventHandler(this.textBoxtipoDoc_TextChanged);
            // 
            // textBoxNumDoc
            // 
            this.textBoxNumDoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNumDoc.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumDoc.Location = new System.Drawing.Point(25, 194);
            this.textBoxNumDoc.Name = "textBoxNumDoc";
            this.textBoxNumDoc.Size = new System.Drawing.Size(146, 25);
            this.textBoxNumDoc.TabIndex = 40;
            this.textBoxNumDoc.TextChanged += new System.EventHandler(this.textBoxNumDoc_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tipo de Documento : *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "Numero de Documento : *";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 49);
            this.panel1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Compras";
            // 
            // buttonañadircarro
            // 
            this.buttonañadircarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonañadircarro.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonañadircarro.Location = new System.Drawing.Point(402, 229);
            this.buttonañadircarro.Name = "buttonañadircarro";
            this.buttonañadircarro.Size = new System.Drawing.Size(163, 48);
            this.buttonañadircarro.TabIndex = 53;
            this.buttonañadircarro.Text = "Agregar Producto";
            this.buttonañadircarro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonañadircarro.UseVisualStyleBackColor = false;
            this.buttonañadircarro.Click += new System.EventHandler(this.buttonañadircarro_Click);
            // 
            // numericUpDowncantidad
            // 
            this.numericUpDowncantidad.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDowncantidad.Location = new System.Drawing.Point(476, 192);
            this.numericUpDowncantidad.Name = "numericUpDowncantidad";
            this.numericUpDowncantidad.Size = new System.Drawing.Size(69, 29);
            this.numericUpDowncantidad.TabIndex = 54;
            this.numericUpDowncantidad.ValueChanged += new System.EventHandler(this.numericUpDowncantidad_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(473, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 55;
            this.label4.Text = "Cantidad";
            // 
            // buttonguardar
            // 
            this.buttonguardar.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonguardar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonguardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonguardar.Image")));
            this.buttonguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonguardar.Location = new System.Drawing.Point(681, 406);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(150, 72);
            this.buttonguardar.TabIndex = 47;
            this.buttonguardar.Text = "Guardar Compra";
            this.buttonguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonguardar.UseVisualStyleBackColor = false;
            this.buttonguardar.Click += new System.EventHandler(this.buttonguardar_Click);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTotal.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new System.Drawing.Point(465, 484);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 25);
            this.textBoxTotal.TabIndex = 56;
            this.textBoxTotal.TextChanged += new System.EventHandler(this.textBoxTotal_TextChanged);
            // 
            // ID_PRODUCTO
            // 
            this.ID_PRODUCTO.HeaderText = "ID PRODUCTO";
            this.ID_PRODUCTO.Name = "ID_PRODUCTO";
            // 
            // pp
            // 
            this.pp.HeaderText = "PRODUCTO";
            this.pp.Name = "pp";
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            // 
            // PRECIO_COMPRA
            // 
            this.PRECIO_COMPRA.HeaderText = "PRECIO COMPRA";
            this.PRECIO_COMPRA.Name = "PRECIO_COMPRA";
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
            // RegistrarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(877, 511);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDowncantidad);
            this.Controls.Add(this.buttonañadircarro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxproveedor);
            this.Controls.Add(this.buttonguardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxProducto);
            this.Controls.Add(this.textBoxtipoDoc);
            this.Controls.Add(this.textBoxNumDoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "RegistrarCompra";
            this.Text = "RegistrarCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowncantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxproveedor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxProducto;
        private System.Windows.Forms.TextBox textBoxtipoDoc;
        private System.Windows.Forms.TextBox textBoxNumDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonañadircarro;
        private System.Windows.Forms.NumericUpDown numericUpDowncantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonguardar;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn pp;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_VENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
    }
}
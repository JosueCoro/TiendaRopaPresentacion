namespace TiendaRopaPresentacion
{
    partial class RegistroInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroInventario));
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxproducto = new System.Windows.Forms.ComboBox();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.buttonactualizar = new System.Windows.Forms.Button();
            this.buttonmostrar = new System.Windows.Forms.Button();
            this.buttoncrear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxAlmacen = new System.Windows.Forms.ComboBox();
            this.textBoxcantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 21);
            this.label7.TabIndex = 52;
            this.label7.Text = "Seleccionar Producto";
            // 
            // comboBoxproducto
            // 
            this.comboBoxproducto.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxproducto.FormattingEnabled = true;
            this.comboBoxproducto.Location = new System.Drawing.Point(25, 94);
            this.comboBoxproducto.Name = "comboBoxproducto";
            this.comboBoxproducto.Size = new System.Drawing.Size(201, 29);
            this.comboBoxproducto.TabIndex = 51;
            this.comboBoxproducto.SelectedIndexChanged += new System.EventHandler(this.comboBoxproducto_SelectedIndexChanged);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttoneliminar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneliminar.Image = ((System.Drawing.Image)(resources.GetObject("buttoneliminar.Image")));
            this.buttoneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttoneliminar.Location = new System.Drawing.Point(384, 406);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(111, 72);
            this.buttoneliminar.TabIndex = 50;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttoneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttoneliminar.UseVisualStyleBackColor = false;
            // 
            // buttonactualizar
            // 
            this.buttonactualizar.BackColor = System.Drawing.Color.Yellow;
            this.buttonactualizar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonactualizar.Image = ((System.Drawing.Image)(resources.GetObject("buttonactualizar.Image")));
            this.buttonactualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonactualizar.Location = new System.Drawing.Point(267, 406);
            this.buttonactualizar.Name = "buttonactualizar";
            this.buttonactualizar.Size = new System.Drawing.Size(111, 72);
            this.buttonactualizar.TabIndex = 49;
            this.buttonactualizar.Text = "Actualizar";
            this.buttonactualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonactualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonactualizar.UseVisualStyleBackColor = false;
            // 
            // buttonmostrar
            // 
            this.buttonmostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonmostrar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmostrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonmostrar.Image")));
            this.buttonmostrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonmostrar.Location = new System.Drawing.Point(150, 406);
            this.buttonmostrar.Name = "buttonmostrar";
            this.buttonmostrar.Size = new System.Drawing.Size(111, 72);
            this.buttonmostrar.TabIndex = 48;
            this.buttonmostrar.Text = "Mostrar";
            this.buttonmostrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonmostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonmostrar.UseVisualStyleBackColor = false;
            this.buttonmostrar.Click += new System.EventHandler(this.buttonmostrar_Click);
            // 
            // buttoncrear
            // 
            this.buttoncrear.BackColor = System.Drawing.Color.OliveDrab;
            this.buttoncrear.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncrear.Image = ((System.Drawing.Image)(resources.GetObject("buttoncrear.Image")));
            this.buttoncrear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttoncrear.Location = new System.Drawing.Point(33, 406);
            this.buttoncrear.Name = "buttoncrear";
            this.buttoncrear.Size = new System.Drawing.Size(111, 72);
            this.buttoncrear.TabIndex = 47;
            this.buttoncrear.Text = "Crear";
            this.buttoncrear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttoncrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttoncrear.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(684, 155);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 21);
            this.label5.TabIndex = 45;
            this.label5.Text = "Seleccionar Almacen";
            // 
            // comboBoxAlmacen
            // 
            this.comboBoxAlmacen.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAlmacen.FormattingEnabled = true;
            this.comboBoxAlmacen.Location = new System.Drawing.Point(25, 161);
            this.comboBoxAlmacen.Name = "comboBoxAlmacen";
            this.comboBoxAlmacen.Size = new System.Drawing.Size(201, 29);
            this.comboBoxAlmacen.TabIndex = 44;
            this.comboBoxAlmacen.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlmacen_SelectedIndexChanged);
            // 
            // textBoxcantidad
            // 
            this.textBoxcantidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxcantidad.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcantidad.Location = new System.Drawing.Point(267, 161);
            this.textBoxcantidad.Name = "textBoxcantidad";
            this.textBoxcantidad.Size = new System.Drawing.Size(146, 25);
            this.textBoxcantidad.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "Cantidad : *";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 49);
            this.panel1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventario";
            // 
            // RegistroInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(874, 500);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxproducto);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttonactualizar);
            this.Controls.Add(this.buttonmostrar);
            this.Controls.Add(this.buttoncrear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxAlmacen);
            this.Controls.Add(this.textBoxcantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "RegistroInventario";
            this.Text = "RegistroInventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxproducto;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Button buttonactualizar;
        private System.Windows.Forms.Button buttonmostrar;
        private System.Windows.Forms.Button buttoncrear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxAlmacen;
        private System.Windows.Forms.TextBox textBoxcantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
namespace TiendaRopaPresentacion
{
    partial class FormRegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistroUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCI = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxContra = new System.Windows.Forms.TextBox();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttoncrear = new System.Windows.Forms.Button();
            this.buttonmostrar = new System.Windows.Forms.Button();
            this.buttonactualizar = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 49);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "CI : *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Completo : *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña : *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(226, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Correo :*";
            // 
            // textBoxCI
            // 
            this.textBoxCI.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxCI.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCI.Location = new System.Drawing.Point(11, 106);
            this.textBoxCI.Name = "textBoxCI";
            this.textBoxCI.Size = new System.Drawing.Size(146, 25);
            this.textBoxCI.TabIndex = 6;
            this.textBoxCI.TextChanged += new System.EventHandler(this.textBoxCI_TextChanged);
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreo.Location = new System.Drawing.Point(230, 106);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(240, 25);
            this.textBoxCorreo.TabIndex = 7;
            // 
            // textBoxname
            // 
            this.textBoxname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxname.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxname.Location = new System.Drawing.Point(12, 173);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(199, 25);
            this.textBoxname.TabIndex = 8;
            // 
            // textBoxContra
            // 
            this.textBoxContra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxContra.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContra.Location = new System.Drawing.Point(230, 173);
            this.textBoxContra.Name = "textBoxContra";
            this.textBoxContra.Size = new System.Drawing.Size(240, 25);
            this.textBoxContra.TabIndex = 9;
            this.textBoxContra.TextChanged += new System.EventHandler(this.textBoxContra_TextChanged);
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Location = new System.Drawing.Point(508, 173);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(201, 29);
            this.comboBoxRol.TabIndex = 10;
            this.comboBoxRol.SelectedIndexChanged += new System.EventHandler(this.comboBoxRol_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(504, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Seleccionar Rol";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(684, 155);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttoncrear
            // 
            this.buttoncrear.BackColor = System.Drawing.Color.OliveDrab;
            this.buttoncrear.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncrear.Image = ((System.Drawing.Image)(resources.GetObject("buttoncrear.Image")));
            this.buttoncrear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttoncrear.Location = new System.Drawing.Point(33, 415);
            this.buttoncrear.Name = "buttoncrear";
            this.buttoncrear.Size = new System.Drawing.Size(111, 72);
            this.buttoncrear.TabIndex = 13;
            this.buttoncrear.Text = "Crear";
            this.buttoncrear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttoncrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttoncrear.UseVisualStyleBackColor = false;
            this.buttoncrear.Click += new System.EventHandler(this.buttoncrear_Click);
            // 
            // buttonmostrar
            // 
            this.buttonmostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonmostrar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmostrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonmostrar.Image")));
            this.buttonmostrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonmostrar.Location = new System.Drawing.Point(150, 415);
            this.buttonmostrar.Name = "buttonmostrar";
            this.buttonmostrar.Size = new System.Drawing.Size(111, 72);
            this.buttonmostrar.TabIndex = 14;
            this.buttonmostrar.Text = "Mostrar";
            this.buttonmostrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonmostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonmostrar.UseVisualStyleBackColor = false;
            this.buttonmostrar.Click += new System.EventHandler(this.buttonmostrar_Click);
            // 
            // buttonactualizar
            // 
            this.buttonactualizar.BackColor = System.Drawing.Color.Yellow;
            this.buttonactualizar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonactualizar.Image = ((System.Drawing.Image)(resources.GetObject("buttonactualizar.Image")));
            this.buttonactualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonactualizar.Location = new System.Drawing.Point(267, 415);
            this.buttonactualizar.Name = "buttonactualizar";
            this.buttonactualizar.Size = new System.Drawing.Size(111, 72);
            this.buttonactualizar.TabIndex = 15;
            this.buttonactualizar.Text = "Actualizar";
            this.buttonactualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonactualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonactualizar.UseVisualStyleBackColor = false;
            this.buttonactualizar.Click += new System.EventHandler(this.buttonactualizar_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttoneliminar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneliminar.Image = ((System.Drawing.Image)(resources.GetObject("buttoneliminar.Image")));
            this.buttoneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttoneliminar.Location = new System.Drawing.Point(384, 415);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(111, 72);
            this.buttoneliminar.TabIndex = 16;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttoneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttoneliminar.UseVisualStyleBackColor = false;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // FormRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(824, 499);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttonactualizar);
            this.Controls.Add(this.buttonmostrar);
            this.Controls.Add(this.buttoncrear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxRol);
            this.Controls.Add(this.textBoxContra);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxCI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FormRegistroUsuario";
            this.Text = "FormRegistroUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCI;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxContra;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttoncrear;
        private System.Windows.Forms.Button buttonmostrar;
        private System.Windows.Forms.Button buttonactualizar;
        private System.Windows.Forms.Button buttoneliminar;
    }
}
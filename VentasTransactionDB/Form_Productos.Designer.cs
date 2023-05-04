namespace VentasTransactionDB
{
    partial class Form_Productos
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelPu = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.iconButtonAgregar = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Location = new System.Drawing.Point(12, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(271, 37);
            this.labelTitle.TabIndex = 21;
            this.labelTitle.Text = "Lista de Productos";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDescripcion.Location = new System.Drawing.Point(13, 73);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(237, 33);
            this.labelDescripcion.TabIndex = 22;
            this.labelDescripcion.Text = "Descripción del producto:";
            // 
            // labelPu
            // 
            this.labelPu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.labelPu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPu.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPu.Location = new System.Drawing.Point(13, 106);
            this.labelPu.Name = "labelPu";
            this.labelPu.Size = new System.Drawing.Size(237, 33);
            this.labelPu.TabIndex = 23;
            this.labelPu.Text = "Precio Unitario:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 22);
            this.textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(246, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(294, 22);
            this.textBox2.TabIndex = 25;
            // 
            // iconButtonAgregar
            // 
            this.iconButtonAgregar.BackColor = System.Drawing.Color.Teal;
            this.iconButtonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAgregar.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonAgregar.IconColor = System.Drawing.Color.Black;
            this.iconButtonAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAgregar.Location = new System.Drawing.Point(246, 168);
            this.iconButtonAgregar.Name = "iconButtonAgregar";
            this.iconButtonAgregar.Size = new System.Drawing.Size(104, 46);
            this.iconButtonAgregar.TabIndex = 26;
            this.iconButtonAgregar.Text = "Agregar";
            this.iconButtonAgregar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(473, 253);
            this.dataGridView1.TabIndex = 27;
            // 
            // Form_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(974, 641);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.iconButtonAgregar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelPu);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form_Productos";
            this.Text = "Form_Productos";
            this.Load += new System.EventHandler(this.Form_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelPu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private FontAwesome.Sharp.IconButton iconButtonAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
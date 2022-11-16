
namespace Vista_Bancos
{
    partial class Ventas
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
            this.navegador1 = new NavegadorVista.Navegador();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtestatus = new System.Windows.Forms.TextBox();
            this.txtfech = new System.Windows.Forms.TextBox();
            this.txtcodcli = new System.Windows.Forms.TextBox();
            this.txtnumven = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(16, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(771, 187);
            this.navegador1.TabIndex = 31;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(119, 261);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 22);
            this.txttotal.TabIndex = 65;
            this.txttotal.Tag = "total_ventaenca";
            // 
            // txtestatus
            // 
            this.txtestatus.Location = new System.Drawing.Point(479, 258);
            this.txtestatus.Name = "txtestatus";
            this.txtestatus.Size = new System.Drawing.Size(140, 22);
            this.txtestatus.TabIndex = 64;
            this.txtestatus.Tag = "estatus_ventaenca";
            // 
            // txtfech
            // 
            this.txtfech.Location = new System.Drawing.Point(699, 214);
            this.txtfech.Name = "txtfech";
            this.txtfech.Size = new System.Drawing.Size(122, 22);
            this.txtfech.TabIndex = 63;
            this.txtfech.Tag = "fecha_ventaenca";
            // 
            // txtcodcli
            // 
            this.txtcodcli.Location = new System.Drawing.Point(419, 212);
            this.txtcodcli.Name = "txtcodcli";
            this.txtcodcli.Size = new System.Drawing.Size(139, 22);
            this.txtcodcli.TabIndex = 62;
            this.txtcodcli.Tag = "codigo_cliente";
            // 
            // txtnumven
            // 
            this.txtnumven.Location = new System.Drawing.Point(147, 212);
            this.txtnumven.Name = "txtnumven";
            this.txtnumven.Size = new System.Drawing.Size(100, 22);
            this.txtnumven.TabIndex = 61;
            this.txtnumven.Tag = "documento_ventaenca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 60;
            this.label5.Text = "Total venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "Estatus venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(618, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Codigo del cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "Numero de Venta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(640, 150);
            this.dataGridView1.TabIndex = 70;
            this.dataGridView1.Tag = "ventas_encabezado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 30);
            this.button1.TabIndex = 71;
            this.button1.Text = "Agregar Venta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 30);
            this.button2.TabIndex = 72;
            this.button2.Text = "Eliminar Venta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(505, 475);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 30);
            this.button3.TabIndex = 73;
            this.button3.Text = "Carga de Datos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 517);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtestatus);
            this.Controls.Add(this.txtfech);
            this.Controls.Add(this.txtcodcli);
            this.Controls.Add(this.txtnumven);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtestatus;
        private System.Windows.Forms.TextBox txtfech;
        private System.Windows.Forms.TextBox txtcodcli;
        private System.Windows.Forms.TextBox txtnumven;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

namespace Vista_Bancos
{
    partial class Clientes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_nitcli = new System.Windows.Forms.TextBox();
            this.txt_telcli = new System.Windows.Forms.TextBox();
            this.txt_direcli = new System.Windows.Forms.TextBox();
            this.txt_nombrecli = new System.Windows.Forms.TextBox();
            this.txt_codclie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_codven = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_estatuscli = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(92, 8);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(771, 187);
            this.navegador1.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(92, 345);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 150);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.Tag = "clientes";
            // 
            // txt_nitcli
            // 
            this.txt_nitcli.Location = new System.Drawing.Point(121, 254);
            this.txt_nitcli.Name = "txt_nitcli";
            this.txt_nitcli.Size = new System.Drawing.Size(100, 22);
            this.txt_nitcli.TabIndex = 50;
            this.txt_nitcli.Tag = "nit_cliente ";
            // 
            // txt_telcli
            // 
            this.txt_telcli.Location = new System.Drawing.Point(366, 251);
            this.txt_telcli.Name = "txt_telcli";
            this.txt_telcli.Size = new System.Drawing.Size(140, 22);
            this.txt_telcli.TabIndex = 49;
            this.txt_telcli.Tag = "telefono_cliente";
            // 
            // txt_direcli
            // 
            this.txt_direcli.Location = new System.Drawing.Point(734, 207);
            this.txt_direcli.Name = "txt_direcli";
            this.txt_direcli.Size = new System.Drawing.Size(100, 22);
            this.txt_direcli.TabIndex = 48;
            this.txt_direcli.Tag = "direccion_cliente";
            // 
            // txt_nombrecli
            // 
            this.txt_nombrecli.Location = new System.Drawing.Point(366, 207);
            this.txt_nombrecli.Name = "txt_nombrecli";
            this.txt_nombrecli.Size = new System.Drawing.Size(230, 22);
            this.txt_nombrecli.TabIndex = 47;
            this.txt_nombrecli.Tag = "nombre_cliente";
            // 
            // txt_codclie
            // 
            this.txt_codclie.Location = new System.Drawing.Point(121, 205);
            this.txt_codclie.Name = "txt_codclie";
            this.txt_codclie.Size = new System.Drawing.Size(100, 22);
            this.txt_codclie.TabIndex = 46;
            this.txt_codclie.Tag = "codigo_cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "NIT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Cod Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "Cod Vendedor";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_codven
            // 
            this.txt_codven.Location = new System.Drawing.Point(674, 256);
            this.txt_codven.Name = "txt_codven";
            this.txt_codven.Size = new System.Drawing.Size(100, 22);
            this.txt_codven.TabIndex = 53;
            this.txt_codven.Tag = "codigo_vendedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Estatus Cliente";
            // 
            // txt_estatuscli
            // 
            this.txt_estatuscli.Location = new System.Drawing.Point(437, 308);
            this.txt_estatuscli.Name = "txt_estatuscli";
            this.txt_estatuscli.Size = new System.Drawing.Size(100, 22);
            this.txt_estatuscli.TabIndex = 55;
            this.txt_estatuscli.Tag = "estatus_cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 34);
            this.button1.TabIndex = 56;
            this.button1.Text = "Agregar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(447, 512);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 34);
            this.button2.TabIndex = 57;
            this.button2.Text = "Eliminar Cliente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(631, 512);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 34);
            this.button3.TabIndex = 58;
            this.button3.Text = "Carga de Datos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 558);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_estatuscli);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_codven);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_nitcli);
            this.Controls.Add(this.txt_telcli);
            this.Controls.Add(this.txt_direcli);
            this.Controls.Add(this.txt_nombrecli);
            this.Controls.Add(this.txt_codclie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Name = "Clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_nitcli;
        private System.Windows.Forms.TextBox txt_telcli;
        private System.Windows.Forms.TextBox txt_direcli;
        private System.Windows.Forms.TextBox txt_nombrecli;
        private System.Windows.Forms.TextBox txt_codclie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_codven;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_estatuscli;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

namespace Vista_Seguridad
{
    partial class AsignacionModuloAplicacion
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
            this.listAplicacionesDB = new System.Windows.Forms.DataGridView();
            this.listAplicacionPerfil = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCadenas = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIdAplicacion = new System.Windows.Forms.TextBox();
            this.txtIdModulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ListModulo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listAplicacionesDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAplicacionPerfil)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListModulo)).BeginInit();
            this.SuspendLayout();
            // 
            // listAplicacionesDB
            // 
            this.listAplicacionesDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listAplicacionesDB.Location = new System.Drawing.Point(583, 26);
            this.listAplicacionesDB.Name = "listAplicacionesDB";
            this.listAplicacionesDB.RowHeadersWidth = 51;
            this.listAplicacionesDB.Size = new System.Drawing.Size(350, 300);
            this.listAplicacionesDB.TabIndex = 49;
            this.listAplicacionesDB.Tag = "tbl_aplicaciones";
            this.listAplicacionesDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listAplicacionesDB_CellClick);
            // 
            // listAplicacionPerfil
            // 
            this.listAplicacionPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listAplicacionPerfil.Location = new System.Drawing.Point(9, 183);
            this.listAplicacionPerfil.Name = "listAplicacionPerfil";
            this.listAplicacionPerfil.RowHeadersWidth = 51;
            this.listAplicacionPerfil.Size = new System.Drawing.Size(558, 143);
            this.listAplicacionPerfil.TabIndex = 48;
            this.listAplicacionPerfil.Tag = "vista_Modulo_Aplicacion";
            this.listAplicacionPerfil.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listAplicacionPerfil_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtCadenas);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtIdAplicacion);
            this.groupBox1.Controls.Add(this.txtIdModulo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(9, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 88);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 24);
            this.button1.TabIndex = 45;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 24);
            this.button2.TabIndex = 44;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCadenas
            // 
            this.txtCadenas.Location = new System.Drawing.Point(268, 53);
            this.txtCadenas.Name = "txtCadenas";
            this.txtCadenas.Size = new System.Drawing.Size(150, 20);
            this.txtCadenas.TabIndex = 43;
            this.txtCadenas.Tag = "imprimir_permiso";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(481, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 29);
            this.btnBuscar.TabIndex = 41;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIdAplicacion
            // 
            this.txtIdAplicacion.Location = new System.Drawing.Point(424, 53);
            this.txtIdAplicacion.Name = "txtIdAplicacion";
            this.txtIdAplicacion.Size = new System.Drawing.Size(50, 20);
            this.txtIdAplicacion.TabIndex = 40;
            this.txtIdAplicacion.Tag = "fk_id_aplicacion";
            // 
            // txtIdModulo
            // 
            this.txtIdModulo.Location = new System.Drawing.Point(53, 53);
            this.txtIdModulo.Name = "txtIdModulo";
            this.txtIdModulo.Size = new System.Drawing.Size(159, 20);
            this.txtIdModulo.TabIndex = 39;
            this.txtIdModulo.Tag = "fk_id_modulos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Aplicacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modulo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(481, 53);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(71, 29);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(485, 26);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 35);
            this.button6.TabIndex = 45;
            this.button6.Text = "Ayuda";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 29);
            this.label1.TabIndex = 44;
            this.label1.Text = "Asignacion de Modulo a Aplicacion\r\n";
            // 
            // ListModulo
            // 
            this.ListModulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListModulo.Location = new System.Drawing.Point(583, 26);
            this.ListModulo.Name = "ListModulo";
            this.ListModulo.RowHeadersWidth = 51;
            this.ListModulo.Size = new System.Drawing.Size(350, 300);
            this.ListModulo.TabIndex = 50;
            this.ListModulo.Tag = "tbl_modulos";
            this.ListModulo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListModulo_CellClick);
            // 
            // AsignacionModuloAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 340);
            this.Controls.Add(this.ListModulo);
            this.Controls.Add(this.listAplicacionesDB);
            this.Controls.Add(this.listAplicacionPerfil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Name = "AsignacionModuloAplicacion";
            this.Text = "AsignacionModuloAplicacion";
            this.Load += new System.EventHandler(this.AsignacionModuloAplicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listAplicacionesDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAplicacionPerfil)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListModulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listAplicacionesDB;
        private System.Windows.Forms.DataGridView listAplicacionPerfil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCadenas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIdAplicacion;
        private System.Windows.Forms.TextBox txtIdModulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView ListModulo;
    }
}
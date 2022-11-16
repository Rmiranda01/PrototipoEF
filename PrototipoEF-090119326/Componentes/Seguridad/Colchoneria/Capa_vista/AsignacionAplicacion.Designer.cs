
namespace Vista_Seguridad
{
    partial class AsignacionAplicacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCadenas = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIdAplicacion = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.ListaAsiganacion = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtImprimir = new System.Windows.Forms.TextBox();
            this.chBoxImprimir = new System.Windows.Forms.CheckBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.chBoxBuscar = new System.Windows.Forms.CheckBox();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.chBoxEliminar = new System.Windows.Forms.CheckBox();
            this.txtModificar = new System.Windows.Forms.TextBox();
            this.chBoxModificar = new System.Windows.Forms.CheckBox();
            this.txtGuardar = new System.Windows.Forms.TextBox();
            this.chBoxGuardar = new System.Windows.Forms.CheckBox();
            this.listAplicacionesDB = new System.Windows.Forms.DataGridView();
            this.ListUsuarios = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaAsiganacion)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listAplicacionesDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asignacion de Aplicaciones a Usuarios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtCadenas);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtIdAplicacion);
            this.groupBox1.Controls.Add(this.txtIdUsuario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(25, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 88);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 24);
            this.button3.TabIndex = 44;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 24);
            this.button2.TabIndex = 43;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtCadenas
            // 
            this.txtCadenas.Location = new System.Drawing.Point(288, 46);
            this.txtCadenas.Name = "txtCadenas";
            this.txtCadenas.Size = new System.Drawing.Size(174, 20);
            this.txtCadenas.TabIndex = 42;
            this.txtCadenas.Tag = "";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(532, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 29);
            this.btnBuscar.TabIndex = 41;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtIdAplicacion
            // 
            this.txtIdAplicacion.Location = new System.Drawing.Point(486, 46);
            this.txtIdAplicacion.Name = "txtIdAplicacion";
            this.txtIdAplicacion.Size = new System.Drawing.Size(24, 20);
            this.txtIdAplicacion.TabIndex = 40;
            this.txtIdAplicacion.Tag = "fk_id_aplicacion";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(42, 46);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(170, 20);
            this.txtIdUsuario.TabIndex = 39;
            this.txtIdUsuario.Tag = "fk_id_usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Aplicaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(557, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 35);
            this.button6.TabIndex = 32;
            this.button6.Text = "Ayuda";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(526, 32);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(65, 29);
            this.btnAll.TabIndex = 9;
            this.btnAll.Text = "Todos";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListaAsiganacion
            // 
            this.ListaAsiganacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaAsiganacion.Location = new System.Drawing.Point(12, 260);
            this.ListaAsiganacion.Name = "ListaAsiganacion";
            this.ListaAsiganacion.RowHeadersWidth = 51;
            this.ListaAsiganacion.Size = new System.Drawing.Size(627, 155);
            this.ListaAsiganacion.TabIndex = 36;
            this.ListaAsiganacion.Tag = "vista_AplicacionUsuario";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtImprimir);
            this.groupBox4.Controls.Add(this.chBoxImprimir);
            this.groupBox4.Controls.Add(this.txtBuscar);
            this.groupBox4.Controls.Add(this.chBoxBuscar);
            this.groupBox4.Controls.Add(this.txtEliminar);
            this.groupBox4.Controls.Add(this.chBoxEliminar);
            this.groupBox4.Controls.Add(this.txtModificar);
            this.groupBox4.Controls.Add(this.chBoxModificar);
            this.groupBox4.Controls.Add(this.txtGuardar);
            this.groupBox4.Controls.Add(this.chBoxGuardar);
            this.groupBox4.Controls.Add(this.btnAll);
            this.groupBox4.Location = new System.Drawing.Point(12, 168);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(627, 86);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Estado";
            // 
            // txtImprimir
            // 
            this.txtImprimir.Location = new System.Drawing.Point(423, 41);
            this.txtImprimir.Name = "txtImprimir";
            this.txtImprimir.Size = new System.Drawing.Size(27, 20);
            this.txtImprimir.TabIndex = 42;
            this.txtImprimir.Tag = "imprimir_permiso";
            // 
            // chBoxImprimir
            // 
            this.chBoxImprimir.AutoSize = true;
            this.chBoxImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxImprimir.Location = new System.Drawing.Point(333, 37);
            this.chBoxImprimir.Name = "chBoxImprimir";
            this.chBoxImprimir.Size = new System.Drawing.Size(96, 28);
            this.chBoxImprimir.TabIndex = 5;
            this.chBoxImprimir.Text = "Imprimir";
            this.chBoxImprimir.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(301, 59);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(26, 20);
            this.txtBuscar.TabIndex = 41;
            this.txtBuscar.Tag = "buscar_permiso";
            // 
            // chBoxBuscar
            // 
            this.chBoxBuscar.AutoSize = true;
            this.chBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxBuscar.Location = new System.Drawing.Point(208, 53);
            this.chBoxBuscar.Name = "chBoxBuscar";
            this.chBoxBuscar.Size = new System.Drawing.Size(87, 28);
            this.chBoxBuscar.TabIndex = 4;
            this.chBoxBuscar.Text = "Buscar";
            this.chBoxBuscar.UseVisualStyleBackColor = true;
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(301, 19);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(26, 20);
            this.txtEliminar.TabIndex = 40;
            this.txtEliminar.Tag = "eliminar_permiso";
            // 
            // chBoxEliminar
            // 
            this.chBoxEliminar.AutoSize = true;
            this.chBoxEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxEliminar.Location = new System.Drawing.Point(208, 19);
            this.chBoxEliminar.Name = "chBoxEliminar";
            this.chBoxEliminar.Size = new System.Drawing.Size(97, 28);
            this.chBoxEliminar.TabIndex = 3;
            this.chBoxEliminar.Text = "Eliminar";
            this.chBoxEliminar.UseVisualStyleBackColor = true;
            // 
            // txtModificar
            // 
            this.txtModificar.Location = new System.Drawing.Point(160, 53);
            this.txtModificar.Name = "txtModificar";
            this.txtModificar.Size = new System.Drawing.Size(29, 20);
            this.txtModificar.TabIndex = 39;
            this.txtModificar.Tag = "modificar_permiso";
            // 
            // chBoxModificar
            // 
            this.chBoxModificar.AutoSize = true;
            this.chBoxModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxModificar.Location = new System.Drawing.Point(57, 53);
            this.chBoxModificar.Name = "chBoxModificar";
            this.chBoxModificar.Size = new System.Drawing.Size(105, 28);
            this.chBoxModificar.TabIndex = 2;
            this.chBoxModificar.Text = "Modificar";
            this.chBoxModificar.UseVisualStyleBackColor = true;
            // 
            // txtGuardar
            // 
            this.txtGuardar.Location = new System.Drawing.Point(160, 19);
            this.txtGuardar.Name = "txtGuardar";
            this.txtGuardar.Size = new System.Drawing.Size(24, 20);
            this.txtGuardar.TabIndex = 38;
            this.txtGuardar.Tag = "guardar_permiso";
            // 
            // chBoxGuardar
            // 
            this.chBoxGuardar.AutoSize = true;
            this.chBoxGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxGuardar.Location = new System.Drawing.Point(57, 19);
            this.chBoxGuardar.Name = "chBoxGuardar";
            this.chBoxGuardar.Size = new System.Drawing.Size(97, 28);
            this.chBoxGuardar.TabIndex = 1;
            this.chBoxGuardar.Text = "Guardar";
            this.chBoxGuardar.UseVisualStyleBackColor = true;
            // 
            // listAplicacionesDB
            // 
            this.listAplicacionesDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listAplicacionesDB.Location = new System.Drawing.Point(666, 46);
            this.listAplicacionesDB.Name = "listAplicacionesDB";
            this.listAplicacionesDB.RowHeadersWidth = 51;
            this.listAplicacionesDB.Size = new System.Drawing.Size(350, 369);
            this.listAplicacionesDB.TabIndex = 38;
            this.listAplicacionesDB.Tag = "tbl_aplicaciones";
            this.listAplicacionesDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listAplicacionesDB_CellClick);
            // 
            // ListUsuarios
            // 
            this.ListUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListUsuarios.Location = new System.Drawing.Point(666, 33);
            this.ListUsuarios.Name = "ListUsuarios";
            this.ListUsuarios.RowHeadersWidth = 51;
            this.ListUsuarios.Size = new System.Drawing.Size(350, 382);
            this.ListUsuarios.TabIndex = 39;
            this.ListUsuarios.Tag = "tbl_usuarios";
            this.ListUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListUsuarios_CellClick);
            // 
            // AsignacionAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 427);
            this.Controls.Add(this.ListUsuarios);
            this.Controls.Add(this.listAplicacionesDB);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.ListaAsiganacion);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "AsignacionAplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsignacionAplicacion";
            this.Load += new System.EventHandler(this.AsignacionAplicacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaAsiganacion)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listAplicacionesDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.DataGridView ListaAsiganacion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chBoxImprimir;
        private System.Windows.Forms.CheckBox chBoxBuscar;
        private System.Windows.Forms.CheckBox chBoxEliminar;
        private System.Windows.Forms.CheckBox chBoxModificar;
        private System.Windows.Forms.CheckBox chBoxGuardar;
        private System.Windows.Forms.TextBox txtGuardar;
        private System.Windows.Forms.TextBox txtIdAplicacion;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.TextBox txtModificar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCadenas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView listAplicacionesDB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView ListUsuarios;
    }
}
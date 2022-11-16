
namespace Vista_Seguridad
{
    partial class AsignacionPerfiles
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
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtIdPerfil = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtCadenas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listPerfilUsuario = new System.Windows.Forms.DataGridView();
            this.listPerfilesDB = new System.Windows.Forms.DataGridView();
            this.ListUsuario = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listPerfilUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPerfilesDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Asignacion de Perfiles a Usuario";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(555, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 32);
            this.button6.TabIndex = 33;
            this.button6.Text = "Ayuda";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtIdPerfil);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtIdUsuario);
            this.groupBox1.Controls.Add(this.txtCadenas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(23, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 88);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 24);
            this.button1.TabIndex = 45;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 24);
            this.button2.TabIndex = 44;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtIdPerfil
            // 
            this.txtIdPerfil.Location = new System.Drawing.Point(471, 46);
            this.txtIdPerfil.Name = "txtIdPerfil";
            this.txtIdPerfil.Size = new System.Drawing.Size(39, 20);
            this.txtIdPerfil.TabIndex = 42;
            this.txtIdPerfil.Tag = "fk_id_perfil";
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
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(48, 48);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(172, 20);
            this.txtIdUsuario.TabIndex = 40;
            this.txtIdUsuario.Tag = "fk_id_usuario";
            // 
            // txtCadenas
            // 
            this.txtCadenas.Location = new System.Drawing.Point(268, 48);
            this.txtCadenas.Name = "txtCadenas";
            this.txtCadenas.Size = new System.Drawing.Size(197, 20);
            this.txtCadenas.TabIndex = 39;
            this.txtCadenas.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Perfil";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(532, 46);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(71, 29);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listPerfilUsuario
            // 
            this.listPerfilUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listPerfilUsuario.Location = new System.Drawing.Point(23, 174);
            this.listPerfilUsuario.Name = "listPerfilUsuario";
            this.listPerfilUsuario.RowHeadersWidth = 51;
            this.listPerfilUsuario.Size = new System.Drawing.Size(614, 143);
            this.listPerfilUsuario.TabIndex = 43;
            this.listPerfilUsuario.Tag = "vista_Perfil_Usuario";
            this.listPerfilUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listPerfilUsuario_CellDoubleClick);
            // 
            // listPerfilesDB
            // 
            this.listPerfilesDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listPerfilesDB.Location = new System.Drawing.Point(666, 4);
            this.listPerfilesDB.Name = "listPerfilesDB";
            this.listPerfilesDB.RowHeadersWidth = 51;
            this.listPerfilesDB.Size = new System.Drawing.Size(350, 314);
            this.listPerfilesDB.TabIndex = 44;
            this.listPerfilesDB.Tag = "tbl_perfiles";
            this.listPerfilesDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listAplicacionesDB_CellClick);
            // 
            // ListUsuario
            // 
            this.ListUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListUsuario.Location = new System.Drawing.Point(666, 3);
            this.ListUsuario.Name = "ListUsuario";
            this.ListUsuario.RowHeadersWidth = 51;
            this.ListUsuario.Size = new System.Drawing.Size(350, 315);
            this.ListUsuario.TabIndex = 45;
            this.ListUsuario.Tag = "tbl_usuarios";
            this.ListUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListUsuario_CellClick);
            // 
            // AsignacionPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 330);
            this.Controls.Add(this.ListUsuario);
            this.Controls.Add(this.listPerfilesDB);
            this.Controls.Add(this.listPerfilUsuario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Name = "AsignacionPerfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsignacionPerfiles";
            this.Load += new System.EventHandler(this.AsignacionPerfiles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listPerfilUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPerfilesDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.TextBox txtCadenas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView listPerfilUsuario;
        private System.Windows.Forms.TextBox txtIdPerfil;
        private System.Windows.Forms.DataGridView listPerfilesDB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView ListUsuario;
    }
}
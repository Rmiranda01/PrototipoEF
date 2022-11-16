
namespace Vista_Seguridad
{
    partial class ListAplicaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIds = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listAplicacionesDB)).BeginInit();
            this.SuspendLayout();
            // 
            // listAplicacionesDB
            // 
            this.listAplicacionesDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listAplicacionesDB.Location = new System.Drawing.Point(12, 42);
            this.listAplicacionesDB.Name = "listAplicacionesDB";
            this.listAplicacionesDB.RowHeadersWidth = 51;
            this.listAplicacionesDB.Size = new System.Drawing.Size(390, 396);
            this.listAplicacionesDB.TabIndex = 37;
            this.listAplicacionesDB.Tag = "tbl_aplicaciones";
            this.listAplicacionesDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listAplicacionesDB_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ids Aplicaciones";
            // 
            // txtIds
            // 
            this.txtIds.Location = new System.Drawing.Point(126, 11);
            this.txtIds.Name = "txtIds";
            this.txtIds.Size = new System.Drawing.Size(186, 20);
            this.txtIds.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 24);
            this.button1.TabIndex = 40;
            this.button1.Text = "Envio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 24);
            this.button2.TabIndex = 41;
            this.button2.Text = "Envio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListAplicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listAplicacionesDB);
            this.Name = "ListAplicaciones";
            this.Text = "ListAplicaciones";
            this.Load += new System.EventHandler(this.ListAplicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listAplicacionesDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listAplicacionesDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtIds;
    }
}
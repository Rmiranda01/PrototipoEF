
namespace Vista_Seguridad
{
    partial class prueba
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
            this.btnmil = new System.Windows.Forms.Button();
            this.btndosmil = new System.Windows.Forms.Button();
            this.btntresmil = new System.Windows.Forms.Button();
            this.btncuatromil = new System.Windows.Forms.Button();
            this.btncincomil = new System.Windows.Forms.Button();
            this.btnseismil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "FUNCIONO PAPS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnmil
            // 
            this.btnmil.Enabled = false;
            this.btnmil.Location = new System.Drawing.Point(100, 170);
            this.btnmil.Name = "btnmil";
            this.btnmil.Size = new System.Drawing.Size(75, 23);
            this.btnmil.TabIndex = 1;
            this.btnmil.Text = "1000";
            this.btnmil.UseVisualStyleBackColor = true;
            this.btnmil.Click += new System.EventHandler(this.btnmil_Click);
            // 
            // btndosmil
            // 
            this.btndosmil.Enabled = false;
            this.btndosmil.Location = new System.Drawing.Point(324, 170);
            this.btndosmil.Name = "btndosmil";
            this.btndosmil.Size = new System.Drawing.Size(75, 23);
            this.btndosmil.TabIndex = 2;
            this.btndosmil.Text = "2000";
            this.btndosmil.UseVisualStyleBackColor = true;
            this.btndosmil.Click += new System.EventHandler(this.btndosmil_Click);
            // 
            // btntresmil
            // 
            this.btntresmil.Enabled = false;
            this.btntresmil.Location = new System.Drawing.Point(557, 170);
            this.btntresmil.Name = "btntresmil";
            this.btntresmil.Size = new System.Drawing.Size(75, 23);
            this.btntresmil.TabIndex = 3;
            this.btntresmil.Text = "3000";
            this.btntresmil.UseVisualStyleBackColor = true;
            this.btntresmil.Click += new System.EventHandler(this.btnpr_Click);
            // 
            // btncuatromil
            // 
            this.btncuatromil.Enabled = false;
            this.btncuatromil.Location = new System.Drawing.Point(100, 278);
            this.btncuatromil.Name = "btncuatromil";
            this.btncuatromil.Size = new System.Drawing.Size(75, 23);
            this.btncuatromil.TabIndex = 4;
            this.btncuatromil.Text = "4000";
            this.btncuatromil.UseVisualStyleBackColor = true;
            this.btncuatromil.Click += new System.EventHandler(this.btncuatromil_Click);
            // 
            // btncincomil
            // 
            this.btncincomil.Enabled = false;
            this.btncincomil.Location = new System.Drawing.Point(324, 278);
            this.btncincomil.Name = "btncincomil";
            this.btncincomil.Size = new System.Drawing.Size(75, 23);
            this.btncincomil.TabIndex = 5;
            this.btncincomil.Text = "5000";
            this.btncincomil.UseVisualStyleBackColor = true;
            this.btncincomil.Click += new System.EventHandler(this.btncincomil_Click);
            // 
            // btnseismil
            // 
            this.btnseismil.Enabled = false;
            this.btnseismil.Location = new System.Drawing.Point(557, 278);
            this.btnseismil.Name = "btnseismil";
            this.btnseismil.Size = new System.Drawing.Size(75, 23);
            this.btnseismil.TabIndex = 6;
            this.btnseismil.Text = "6000";
            this.btnseismil.UseVisualStyleBackColor = true;
            this.btnseismil.Click += new System.EventHandler(this.btnseismil_Click);
            // 
            // prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnseismil);
            this.Controls.Add(this.btncincomil);
            this.Controls.Add(this.btncuatromil);
            this.Controls.Add(this.btntresmil);
            this.Controls.Add(this.btndosmil);
            this.Controls.Add(this.btnmil);
            this.Controls.Add(this.label1);
            this.Name = "prueba";
            this.Text = "prueba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnmil;
        public System.Windows.Forms.Button btntresmil;
        public System.Windows.Forms.Button btndosmil;
        public System.Windows.Forms.Button btncuatromil;
        public System.Windows.Forms.Button btncincomil;
        public System.Windows.Forms.Button btnseismil;
    }
}
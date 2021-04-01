
namespace LineaCurva
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picDibujo = new System.Windows.Forms.PictureBox();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listTamanio = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDibujo)).BeginInit();
            this.SuspendLayout();
            // 
            // picDibujo
            // 
            this.picDibujo.BackColor = System.Drawing.SystemColors.Window;
            this.picDibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDibujo.Location = new System.Drawing.Point(8, 9);
            this.picDibujo.Name = "picDibujo";
            this.picDibujo.Size = new System.Drawing.Size(636, 429);
            this.picDibujo.TabIndex = 0;
            this.picDibujo.TabStop = false;
            this.picDibujo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picDibujo_MouseClick);
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(691, 159);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(197, 23);
            this.btnDibujar.TabIndex = 1;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color";
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.ItemHeight = 15;
            this.cmbColor.Items.AddRange(new object[] {
            "Rojo",
            "Azul",
            "Verde",
            "Amarillo",
            "Cyan",
            "Gris"});
            this.cmbColor.Location = new System.Drawing.Point(702, 20);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(186, 23);
            this.cmbColor.TabIndex = 3;
            this.cmbColor.Text = "Selecciona el Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tamaño";
            // 
            // listTamanio
            // 
            this.listTamanio.FormattingEnabled = true;
            this.listTamanio.ItemHeight = 15;
            this.listTamanio.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.listTamanio.Location = new System.Drawing.Point(715, 81);
            this.listTamanio.Name = "listTamanio";
            this.listTamanio.Size = new System.Drawing.Size(173, 34);
            this.listTamanio.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(691, 348);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(197, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(691, 378);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(197, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.listTamanio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.picDibujo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDibujo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDibujo;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listTamanio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
    }
}


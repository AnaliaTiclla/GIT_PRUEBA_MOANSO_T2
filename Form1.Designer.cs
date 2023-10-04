
namespace EJEMPLO_MOANSO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.LIMPIAR = new System.Windows.Forms.Button();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 67);
            this.button2.TabIndex = 0;
            this.button2.Text = "dios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // LIMPIAR
            // 
            this.LIMPIAR.Location = new System.Drawing.Point(101, 328);
            this.LIMPIAR.Name = "LIMPIAR";
            this.LIMPIAR.Size = new System.Drawing.Size(75, 23);
            this.LIMPIAR.TabIndex = 1;
            this.LIMPIAR.Text = "LIMPIAR";
            this.LIMPIAR.UseVisualStyleBackColor = true;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(196, 68);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 26);
            this.txtN1.TabIndex = 2;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(248, 127);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 26);
            this.txtN2.TabIndex = 3;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(235, 210);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 26);
            this.txtR.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(180, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.LIMPIAR);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button LIMPIAR;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Button button3;
    }
}


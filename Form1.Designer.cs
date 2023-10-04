namespace EJEMPLO_MOANSO
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
            LIMPIAR = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            txtR = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // LIMPIAR
            // 
            LIMPIAR.Location = new Point(400, 125);
            LIMPIAR.Name = "LIMPIAR";
            LIMPIAR.Size = new Size(105, 33);
            LIMPIAR.TabIndex = 0;
            LIMPIAR.Text = "LIMPIAR";
            LIMPIAR.UseVisualStyleBackColor = true;
            LIMPIAR.Click += LIMPIAR_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(242, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 1;
            label1.Text = "calculadora ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 98);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 2;
            label2.Text = "coloque el primer número";
            // 
            // button2
            // 
            button2.Location = new Point(400, 203);
            button2.Name = "button2";
            button2.Size = new Size(105, 33);
            button2.TabIndex = 3;
            button2.Text = "CALCULAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 175);
            label3.Name = "label3";
            label3.Size = new Size(156, 15);
            label3.TabIndex = 4;
            label3.Text = "coloque el segundo número";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 248);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 5;
            label4.Text = "resultado de la suma";
            // 
            // txtN1
            // 
            txtN1.Location = new Point(279, 99);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(100, 23);
            txtN1.TabIndex = 6;
            // 
            // txtN2
            // 
            txtN2.Location = new Point(279, 163);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(100, 23);
            txtN2.TabIndex = 7;
            // 
            // txtR
            // 
            txtR.Location = new Point(279, 248);
            txtR.Name = "txtR";
            txtR.Size = new Size(100, 23);
            txtR.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(279, 332);
            button3.Name = "button3";
            button3.Size = new Size(82, 31);
            button3.TabIndex = 9;
            button3.Text = "SALIR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 384);
            Controls.Add(button3);
            Controls.Add(txtR);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LIMPIAR);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LIMPIAR;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
        private Label label4;
        private TextBox txtN1;
        private TextBox txtN2;
        private TextBox txtR;
        private Button button3;
    }
}

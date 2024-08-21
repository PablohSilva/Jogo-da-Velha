namespace TicTacToe_005
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.lblPontosX = new System.Windows.Forms.Label();
            this.lblPontosO = new System.Windows.Forms.Label();
            this.lblEmpates = new System.Windows.Forms.Label();
            this.btnResetar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(12, 12);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(84, 80);
            this.A1.TabIndex = 0;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(102, 12);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(84, 80);
            this.A2.TabIndex = 1;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(192, 12);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(84, 80);
            this.A3.TabIndex = 2;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(12, 98);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(84, 80);
            this.B1.TabIndex = 3;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(102, 98);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(84, 80);
            this.B2.TabIndex = 4;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(192, 98);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(84, 80);
            this.B3.TabIndex = 5;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(12, 184);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(84, 80);
            this.C1.TabIndex = 6;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(102, 184);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(84, 80);
            this.C2.TabIndex = 7;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // C3
            // 
            this.C3.Location = new System.Drawing.Point(192, 184);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(84, 80);
            this.C3.TabIndex = 8;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // lblPontosX
            // 
            this.lblPontosX.AutoSize = true;
            this.lblPontosX.Location = new System.Drawing.Point(27, 306);
            this.lblPontosX.Name = "lblPontosX";
            this.lblPontosX.Size = new System.Drawing.Size(52, 13);
            this.lblPontosX.TabIndex = 9;
            this.lblPontosX.Text = "X pontos:";
            // 
            // lblPontosO
            // 
            this.lblPontosO.AutoSize = true;
            this.lblPontosO.Location = new System.Drawing.Point(117, 306);
            this.lblPontosO.Name = "lblPontosO";
            this.lblPontosO.Size = new System.Drawing.Size(53, 13);
            this.lblPontosO.TabIndex = 10;
            this.lblPontosO.Text = "O pontos:";
            // 
            // lblEmpates
            // 
            this.lblEmpates.AutoSize = true;
            this.lblEmpates.Location = new System.Drawing.Point(199, 306);
            this.lblEmpates.Name = "lblEmpates";
            this.lblEmpates.Size = new System.Drawing.Size(51, 13);
            this.lblEmpates.TabIndex = 11;
            this.lblEmpates.Text = "Empates:";
            // 
            // btnResetar
            // 
            this.btnResetar.Location = new System.Drawing.Point(102, 381);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(84, 23);
            this.btnResetar.TabIndex = 12;
            this.btnResetar.Text = "Resetar";
            this.btnResetar.UseVisualStyleBackColor = true;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 450);
            this.Controls.Add(this.btnResetar);
            this.Controls.Add(this.lblEmpates);
            this.Controls.Add(this.lblPontosO);
            this.Controls.Add(this.lblPontosX);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Label lblPontosX;
        private System.Windows.Forms.Label lblPontosO;
        private System.Windows.Forms.Label lblEmpates;
        private System.Windows.Forms.Button btnResetar;
    }
}


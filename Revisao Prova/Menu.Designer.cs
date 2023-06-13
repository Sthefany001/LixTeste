namespace Revisao_Prova
{
    partial class Menu
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
            this.bt_Divisao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Divisao
            // 
            this.bt_Divisao.Location = new System.Drawing.Point(713, 22);
            this.bt_Divisao.Name = "bt_Divisao";
            this.bt_Divisao.Size = new System.Drawing.Size(75, 23);
            this.bt_Divisao.TabIndex = 0;
            this.bt_Divisao.Text = "Divisão";
            this.bt_Divisao.UseVisualStyleBackColor = true;
            this.bt_Divisao.Click += new System.EventHandler(this.bt_Divisao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Divisao);
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Divisao;
    }
}


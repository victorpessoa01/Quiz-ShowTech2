namespace App_ShowTech
{
    partial class FrmFim
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
            this.labelPonto = new System.Windows.Forms.Label();
            this.labelPontos = new System.Windows.Forms.Label();
            this.bntMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPonto
            // 
            this.labelPonto.AutoSize = true;
            this.labelPonto.BackColor = System.Drawing.Color.Transparent;
            this.labelPonto.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPonto.ForeColor = System.Drawing.Color.White;
            this.labelPonto.Location = new System.Drawing.Point(286, 147);
            this.labelPonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPonto.Name = "labelPonto";
            this.labelPonto.Size = new System.Drawing.Size(130, 25);
            this.labelPonto.TabIndex = 2;
            this.labelPonto.Text = "PONTUAÇÃO";
            // 
            // labelPontos
            // 
            this.labelPontos.AutoSize = true;
            this.labelPontos.BackColor = System.Drawing.Color.Transparent;
            this.labelPontos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPontos.ForeColor = System.Drawing.Color.White;
            this.labelPontos.Location = new System.Drawing.Point(299, 198);
            this.labelPontos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPontos.Name = "labelPontos";
            this.labelPontos.Size = new System.Drawing.Size(23, 25);
            this.labelPontos.TabIndex = 5;
            this.labelPontos.Text = "0";
            this.labelPontos.Click += new System.EventHandler(this.labelNome_Click);
            // 
            // bntMenu
            // 
            this.bntMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntMenu.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bntMenu.Location = new System.Drawing.Point(299, 309);
            this.bntMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntMenu.Name = "bntMenu";
            this.bntMenu.Size = new System.Drawing.Size(99, 27);
            this.bntMenu.TabIndex = 6;
            this.bntMenu.Text = "MENU";
            this.bntMenu.UseVisualStyleBackColor = true;
            this.bntMenu.Click += new System.EventHandler(this.bntMenu_Click);
            // 
            // FrmFim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App_ShowTech.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.bntMenu);
            this.Controls.Add(this.labelPontos);
            this.Controls.Add(this.labelPonto);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmFim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFim";
            this.Load += new System.EventHandler(this.FrmFim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelPonto;
        private Label labelPontos;
        private Button bntMenu;
    }
}
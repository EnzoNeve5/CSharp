namespace Meu_primeiro_programa
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
            btn_mensagem = new Button();
            lbl_mensagem = new Label();
            SuspendLayout();
            // 
            // btn_mensagem
            // 
            btn_mensagem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_mensagem.ForeColor = Color.DeepSkyBlue;
            btn_mensagem.Location = new Point(296, 111);
            btn_mensagem.Name = "btn_mensagem";
            btn_mensagem.Size = new Size(152, 37);
            btn_mensagem.TabIndex = 0;
            btn_mensagem.Text = "Ver Mensagem";
            btn_mensagem.UseVisualStyleBackColor = true;
            btn_mensagem.Click += btn_mensagem_Click;
            // 
            // lbl_mensagem
            // 
            lbl_mensagem.AutoSize = true;
            lbl_mensagem.ForeColor = Color.Blue;
            lbl_mensagem.Location = new Point(108, 125);
            lbl_mensagem.Name = "lbl_mensagem";
            lbl_mensagem.Size = new Size(182, 15);
            lbl_mensagem.TabIndex = 1;
            lbl_mensagem.Text = "Tenho uma mensagem para você";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(568, 291);
            Controls.Add(lbl_mensagem);
            Controls.Add(btn_mensagem);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_mensagem;
        private Label lbl_mensagem;
    }
}

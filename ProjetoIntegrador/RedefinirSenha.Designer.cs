namespace ProjetoIntegrador
{
    partial class RedefinirSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedefinirSenha));
            pictureBox1=new PictureBox();
            label1=new Label();
            label2=new Label();
            button1=new Button();
            textBoxSenha=new TextBox();
            textBoxNovaSenha=new TextBox();
            label3=new Label();
            textBoxUsuario=new TextBox();
            label4=new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image=(Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location=new Point(-102, -175);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(1160, 759);
            pictureBox1.TabIndex=0;
            pictureBox1.TabStop=false;
            pictureBox1.Click+=pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(70, 149);
            label1.Name="label1";
            label1.Size=new Size(110, 21);
            label1.TabIndex=1;
            label1.Text="Nova senha";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location=new Point(47, 252);
            label2.Name="label2";
            label2.Size=new Size(164, 18);
            label2.TabIndex=2;
            label2.Text="Confirme nova senha";
            // 
            // button1
            // 
            button1.Location=new Point(86, 360);
            button1.Name="button1";
            button1.Size=new Size(94, 29);
            button1.TabIndex=3;
            button1.Text="Confirmar";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location=new Point(55, 182);
            textBoxSenha.Name="textBoxSenha";
            textBoxSenha.PasswordChar='*';
            textBoxSenha.Size=new Size(146, 27);
            textBoxSenha.TabIndex=4;
            textBoxSenha.TextChanged+=textBox1_TextChanged;
            // 
            // textBoxNovaSenha
            // 
            textBoxNovaSenha.Location=new Point(55, 283);
            textBoxNovaSenha.Name="textBoxNovaSenha";
            textBoxNovaSenha.PasswordChar='*';
            textBoxNovaSenha.Size=new Size(146, 27);
            textBoxNovaSenha.TabIndex=5;
            textBoxNovaSenha.TextChanged+=textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location=new Point(51, 53);
            label3.Name="label3";
            label3.Size=new Size(158, 18);
            label3.TabIndex=6;
            label3.Text="Informe seu usuário";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location=new Point(55, 83);
            textBoxUsuario.Name="textBoxUsuario";
            textBoxUsuario.Size=new Size(146, 27);
            textBoxUsuario.TabIndex=7;
            textBoxUsuario.TextChanged+=textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(486, 290);
            label4.Name="label4";
            label4.Size=new Size(0, 20);
            label4.TabIndex=8;
            // 
            // RedefinirSenha
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(textBoxUsuario);
            Controls.Add(label3);
            Controls.Add(textBoxNovaSenha);
            Controls.Add(textBoxSenha);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name="RedefinirSenha";
            Text="RedefinirSenha";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBoxSenha;
        private TextBox textBoxNovaSenha;
        private TextBox textBoxUsuario;
        private Label label4;
    }
}
namespace ProjetoIntegrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1=new PictureBox();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            RedefinirSenha=new LinkLabel();
            titulartext=new TextBox();
            senhatext=new TextBox();
            button1=new Button();
            button2=new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image=(Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location=new Point(-97, -187);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(1276, 799);
            pictureBox1.TabIndex=0;
            pictureBox1.TabStop=false;
            pictureBox1.Click+=pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(92, 84);
            label1.Name="label1";
            label1.Size=new Size(69, 22);
            label1.TabIndex=1;
            label1.Text="Titular";
            label1.Click+=label1_Click;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location=new Point(89, 218);
            label2.Name="label2";
            label2.Size=new Size(67, 22);
            label2.TabIndex=2;
            label2.Text="Senha";
            label2.Click+=label2_Click;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location=new Point(476, 334);
            label3.Name="label3";
            label3.Size=new Size(165, 18);
            label3.TabIndex=3;
            label3.Text="Esqueceu sua senha?";
            // 
            // RedefinirSenha
            // 
            RedefinirSenha.AutoSize=true;
            RedefinirSenha.Location=new Point(503, 363);
            RedefinirSenha.Name="RedefinirSenha";
            RedefinirSenha.Size=new Size(111, 20);
            RedefinirSenha.TabIndex=4;
            RedefinirSenha.TabStop=true;
            RedefinirSenha.Text="Redefinir senha";
            RedefinirSenha.LinkClicked+=linkLabel1_LinkClicked;
            // 
            // titulartext
            // 
            titulartext.Location=new Point(63, 114);
            titulartext.Name="titulartext";
            titulartext.Size=new Size(125, 27);
            titulartext.TabIndex=5;
            // 
            // senhatext
            // 
            senhatext.Location=new Point(63, 249);
            senhatext.Name="senhatext";
            senhatext.PasswordChar='*';
            senhatext.Size=new Size(125, 27);
            senhatext.TabIndex=6;
            // 
            // button1
            // 
            button1.Location=new Point(77, 354);
            button1.Name="button1";
            button1.Size=new Size(94, 29);
            button1.TabIndex=7;
            button1.Text="Entrar";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.Location=new Point(696, 12);
            button2.Name="button2";
            button2.Size=new Size(92, 29);
            button2.TabIndex=8;
            button2.Text="Cadastrar";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(senhatext);
            Controls.Add(titulartext);
            Controls.Add(RedefinirSenha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name="Form1";
            Text="Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel RedefinirSenha;
        private TextBox titulartext;
        private TextBox senhatext;
        private Button button1;
        private Button button2;
    }
}
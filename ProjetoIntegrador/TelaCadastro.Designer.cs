namespace ProjetoIntegrador
{
    partial class TelaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            pictureBox1=new PictureBox();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            label5=new Label();
            label6=new Label();
            textBox1=new TextBox();
            textBox2=new TextBox();
            textBox3=new TextBox();
            textBox4=new TextBox();
            textBox5=new TextBox();
            textBox6=new TextBox();
            button1=new Button();
            label7=new Label();
            label8=new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image=(Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location=new Point(-59, -165);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(1191, 723);
            pictureBox1.TabIndex=0;
            pictureBox1.TabStop=false;
            pictureBox1.Click+=pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(60, 82);
            label1.Name="label1";
            label1.Size=new Size(63, 22);
            label1.TabIndex=1;
            label1.Text="Nome";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location=new Point(271, 84);
            label2.Name="label2";
            label2.Size=new Size(63, 22);
            label2.TabIndex=2;
            label2.Text="Idade";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location=new Point(65, 185);
            label3.Name="label3";
            label3.Size=new Size(56, 21);
            label3.TabIndex=3;
            label3.Text="Email";
            label3.Click+=label3_Click;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location=new Point(233, 189);
            label4.Name="label4";
            label4.Size=new Size(131, 18);
            label4.TabIndex=4;
            label4.Text="DataNascimento";
            label4.Click+=label4_Click;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Font=new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location=new Point(46, 283);
            label5.Name="label5";
            label5.Size=new Size(76, 21);
            label5.TabIndex=5;
            label5.Text="Usuário";
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Font=new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location=new Point(259, 286);
            label6.Name="label6";
            label6.Size=new Size(63, 21);
            label6.TabIndex=6;
            label6.Text="Senha";
            // 
            // textBox1
            // 
            textBox1.Location=new Point(12, 115);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(163, 27);
            textBox1.TabIndex=7;
            // 
            // textBox2
            // 
            textBox2.Location=new Point(261, 119);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(91, 27);
            textBox2.TabIndex=8;
            textBox2.TextChanged+=textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location=new Point(15, 221);
            textBox3.Name="textBox3";
            textBox3.Size=new Size(160, 27);
            textBox3.TabIndex=9;
            textBox3.TextChanged+=textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location=new Point(223, 222);
            textBox4.Name="textBox4";
            textBox4.Size=new Size(167, 27);
            textBox4.TabIndex=10;
            // 
            // textBox5
            // 
            textBox5.Location=new Point(12, 319);
            textBox5.Name="textBox5";
            textBox5.Size=new Size(144, 27);
            textBox5.TabIndex=11;
            // 
            // textBox6
            // 
            textBox6.Location=new Point(223, 323);
            textBox6.Name="textBox6";
            textBox6.PasswordChar='*';
            textBox6.Size=new Size(135, 27);
            textBox6.TabIndex=12;
            // 
            // button1
            // 
            button1.Location=new Point(136, 395);
            button1.Name="button1";
            button1.Size=new Size(94, 29);
            button1.TabIndex=13;
            button1.Text="Cadastrar";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // label7
            // 
            label7.AutoSize=true;
            label7.Font=new Font("Tahoma", 16.2F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            label7.Location=new Point(67, 18);
            label7.Name="label7";
            label7.Size=new Size(267, 34);
            label7.TabIndex=14;
            label7.Text="Faça seu cadastro";
            // 
            // label8
            // 
            label8.AutoSize=true;
            label8.Location=new Point(571, 300);
            label8.Name="label8";
            label8.Size=new Size(0, 20);
            label8.TabIndex=15;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name="TelaCadastro";
            Text="TelaCadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Label label7;
        private Label label8;
    }
}
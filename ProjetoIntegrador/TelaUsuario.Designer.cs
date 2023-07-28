namespace ProjetoIntegrador
{
    partial class TelaUsuario
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
            dataGridView1=new DataGridView();
            ID=new DataGridViewTextBoxColumn();
            Nome=new DataGridViewTextBoxColumn();
            Idade=new DataGridViewTextBoxColumn();
            Email=new DataGridViewTextBoxColumn();
            DataNascimento=new DataGridViewTextBoxColumn();
            Usuario=new DataGridViewTextBoxColumn();
            dataGridView2=new DataGridView();
            dataGridViewTextBoxColumn1=new DataGridViewTextBoxColumn();
            Evento1=new DataGridViewTextBoxColumn();
            Evento2=new DataGridViewTextBoxColumn();
            Evento3=new DataGridViewTextBoxColumn();
            Evento4=new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, Idade, Email, DataNascimento, Usuario });
            dataGridView1.Location=new Point(32, 14);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowHeadersWidth=51;
            dataGridView1.RowTemplate.Height=29;
            dataGridView1.Size=new Size(1093, 290);
            dataGridView1.TabIndex=0;
            dataGridView1.CellContentClick+=dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick+=dataGridView1_CellDoubleClick;
            // 
            // ID
            // 
            ID.HeaderText="ID";
            ID.MinimumWidth=6;
            ID.Name="ID";
            ID.Width=125;
            // 
            // Nome
            // 
            Nome.HeaderText="Nome";
            Nome.MinimumWidth=6;
            Nome.Name="Nome";
            Nome.Width=250;
            // 
            // Idade
            // 
            Idade.HeaderText="Idade";
            Idade.MinimumWidth=6;
            Idade.Name="Idade";
            Idade.Width=125;
            // 
            // Email
            // 
            Email.HeaderText="Email";
            Email.MinimumWidth=6;
            Email.Name="Email";
            Email.Width=250;
            // 
            // DataNascimento
            // 
            DataNascimento.HeaderText="Data Nascimento";
            DataNascimento.MinimumWidth=6;
            DataNascimento.Name="DataNascimento";
            DataNascimento.Width=160;
            // 
            // Usuario
            // 
            Usuario.HeaderText="Usuário";
            Usuario.MinimumWidth=6;
            Usuario.Name="Usuario";
            Usuario.Width=125;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Evento1, Evento2, Evento3, Evento4 });
            dataGridView2.Location=new Point(32, 317);
            dataGridView2.Name="dataGridView2";
            dataGridView2.RowHeadersWidth=51;
            dataGridView2.RowTemplate.Height=29;
            dataGridView2.Size=new Size(1093, 290);
            dataGridView2.TabIndex=1;
            dataGridView2.CellContentClick+=dataGridView2_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText="ID";
            dataGridViewTextBoxColumn1.MinimumWidth=6;
            dataGridViewTextBoxColumn1.Name="dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width=125;
            // 
            // Evento1
            // 
            Evento1.HeaderText="Evento1";
            Evento1.MinimumWidth=6;
            Evento1.Name="Evento1";
            Evento1.Width=250;
            // 
            // Evento2
            // 
            Evento2.HeaderText="Evento2";
            Evento2.MinimumWidth=6;
            Evento2.Name="Evento2";
            Evento2.Width=250;
            // 
            // Evento3
            // 
            Evento3.HeaderText="Evento3";
            Evento3.MinimumWidth=6;
            Evento3.Name="Evento3";
            Evento3.Width=250;
            // 
            // Evento4
            // 
            Evento4.HeaderText="Evento4";
            Evento4.MinimumWidth=6;
            Evento4.Name="Evento4";
            Evento4.Width=250;
            // 
            // TelaUsuario
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1150, 620);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name="TelaUsuario";
            Text="TelaUsuario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        //private void TelaUsuario_Load(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Idade;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DataNascimento;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Evento1;
        private DataGridViewTextBoxColumn Evento2;
        private DataGridViewTextBoxColumn Evento3;
        private DataGridViewTextBoxColumn Evento4;
    }
}
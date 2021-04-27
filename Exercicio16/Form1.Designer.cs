
namespace Exercicio16
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDificuldade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFabricante = new System.Windows.Forms.ComboBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPesquisa = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtodos = new System.Windows.Forms.RadioButton();
            this.rbdificuldade = new System.Windows.Forms.RadioButton();
            this.btnPorcentage = new System.Windows.Forms.Button();
            this.btnValor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtvaloradicao = new System.Windows.Forms.TextBox();
            this.txtporcentagem = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 87);
            this.button2.TabIndex = 12;
            this.button2.Text = "Carregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_Carregar);
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(4, 198);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.ReadOnly = true;
            this.txtLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLista.Size = new System.Drawing.Size(390, 168);
            this.txtLista.TabIndex = 3;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(99, 16);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(161, 20);
            this.txtcodigo.TabIndex = 1;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(99, 46);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(161, 20);
            this.txtdescricao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dificuldade";
            // 
            // cbDificuldade
            // 
            this.cbDificuldade.FormattingEnabled = true;
            this.cbDificuldade.Location = new System.Drawing.Point(100, 102);
            this.cbDificuldade.Name = "cbDificuldade";
            this.cbDificuldade.Size = new System.Drawing.Size(160, 21);
            this.cbDificuldade.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fabricante";
            // 
            // cbFabricante
            // 
            this.cbFabricante.FormattingEnabled = true;
            this.cbFabricante.Location = new System.Drawing.Point(100, 133);
            this.cbFabricante.Name = "cbFabricante";
            this.cbFabricante.Size = new System.Drawing.Size(160, 21);
            this.cbFabricante.Sorted = true;
            this.cbFabricante.TabIndex = 5;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(99, 76);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(161, 20);
            this.txtvalor.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor";
            // 
            // cbPesquisa
            // 
            this.cbPesquisa.FormattingEnabled = true;
            this.cbPesquisa.Location = new System.Drawing.Point(6, 48);
            this.cbPesquisa.Name = "cbPesquisa";
            this.cbPesquisa.Size = new System.Drawing.Size(129, 21);
            this.cbPesquisa.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtodos);
            this.groupBox1.Controls.Add(this.rbdificuldade);
            this.groupBox1.Controls.Add(this.cbPesquisa);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(400, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 168);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // rbtodos
            // 
            this.rbtodos.AutoSize = true;
            this.rbtodos.Location = new System.Drawing.Point(149, 23);
            this.rbtodos.Name = "rbtodos";
            this.rbtodos.Size = new System.Drawing.Size(60, 17);
            this.rbtodos.TabIndex = 16;
            this.rbtodos.TabStop = true;
            this.rbtodos.Text = "Todos";
            this.rbtodos.UseVisualStyleBackColor = true;
            // 
            // rbdificuldade
            // 
            this.rbdificuldade.AutoSize = true;
            this.rbdificuldade.Location = new System.Drawing.Point(11, 23);
            this.rbdificuldade.Name = "rbdificuldade";
            this.rbdificuldade.Size = new System.Drawing.Size(116, 17);
            this.rbdificuldade.TabIndex = 15;
            this.rbdificuldade.TabStop = true;
            this.rbdificuldade.Text = "Por Dificuldade:";
            this.rbdificuldade.UseVisualStyleBackColor = true;
            // 
            // btnPorcentage
            // 
            this.btnPorcentage.Location = new System.Drawing.Point(11, 30);
            this.btnPorcentage.Name = "btnPorcentage";
            this.btnPorcentage.Size = new System.Drawing.Size(129, 46);
            this.btnPorcentage.TabIndex = 7;
            this.btnPorcentage.Text = "Porcentagem";
            this.toolTip1.SetToolTip(this.btnPorcentage, "Para adicionar porcentagem primeiro cadastre o produto");
            this.btnPorcentage.UseVisualStyleBackColor = true;
            this.btnPorcentage.Click += new System.EventHandler(this.btnPorcentage_Click);
            // 
            // btnValor
            // 
            this.btnValor.Location = new System.Drawing.Point(11, 86);
            this.btnValor.Name = "btnValor";
            this.btnValor.Size = new System.Drawing.Size(129, 46);
            this.btnValor.TabIndex = 8;
            this.btnValor.Text = "Valor ";
            this.toolTip1.SetToolTip(this.btnValor, "Para adicionar valor primeiro cadastre o produto");
            this.btnValor.UseVisualStyleBackColor = true;
            this.btnValor.Click += new System.EventHandler(this.btnValor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtvaloradicao);
            this.groupBox2.Controls.Add(this.txtporcentagem);
            this.groupBox2.Controls.Add(this.btnPorcentage);
            this.groupBox2.Controls.Add(this.btnValor);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(400, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 168);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revisão de preços";
            // 
            // txtvaloradicao
            // 
            this.txtvaloradicao.Location = new System.Drawing.Point(149, 100);
            this.txtvaloradicao.Name = "txtvaloradicao";
            this.txtvaloradicao.Size = new System.Drawing.Size(115, 20);
            this.txtvaloradicao.TabIndex = 10;
            // 
            // txtporcentagem
            // 
            this.txtporcentagem.Location = new System.Drawing.Point(149, 44);
            this.txtporcentagem.Name = "txtporcentagem";
            this.txtporcentagem.Size = new System.Drawing.Size(115, 20);
            this.txtporcentagem.TabIndex = 9;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(281, 16);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(96, 50);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Salvar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Exercicio16.Properties.Resources._2f7840e8046f9644d7b2964fb84b8f26;
            this.ClientSize = new System.Drawing.Size(704, 411);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbFabricante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDificuldade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Exercicio 16";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDificuldade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFabricante;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtodos;
        private System.Windows.Forms.RadioButton rbdificuldade;
        private System.Windows.Forms.ComboBox cbPesquisa;
        private System.Windows.Forms.Button btnPorcentage;
        private System.Windows.Forms.Button btnValor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtvaloradicao;
        private System.Windows.Forms.TextBox txtporcentagem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAdicionar;
    }
}


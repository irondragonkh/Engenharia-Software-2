namespace GestaoTrajes.Clientes
{
    partial class Ver
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
            this.Nome = new System.Windows.Forms.Label();
            this.nometextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cidadecombobox = new System.Windows.Forms.ComboBox();
            this.escolacombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cursocombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.procurarbutton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clienteslistview = new System.Windows.Forms.ListView();
            this.compraslistview = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.arranjoslistview = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(12, 9);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome";
            // 
            // nometextbox
            // 
            this.nometextbox.Location = new System.Drawing.Point(53, 6);
            this.nometextbox.Name = "nometextbox";
            this.nometextbox.Size = new System.Drawing.Size(591, 20);
            this.nometextbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cidade";
            // 
            // cidadecombobox
            // 
            this.cidadecombobox.FormattingEnabled = true;
            this.cidadecombobox.Location = new System.Drawing.Point(53, 41);
            this.cidadecombobox.Name = "cidadecombobox";
            this.cidadecombobox.Size = new System.Drawing.Size(187, 21);
            this.cidadecombobox.TabIndex = 4;
            // 
            // escolacombobox
            // 
            this.escolacombobox.FormattingEnabled = true;
            this.escolacombobox.Location = new System.Drawing.Point(298, 41);
            this.escolacombobox.Name = "escolacombobox";
            this.escolacombobox.Size = new System.Drawing.Size(187, 21);
            this.escolacombobox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Escola";
            // 
            // cursocombobox
            // 
            this.cursocombobox.FormattingEnabled = true;
            this.cursocombobox.Location = new System.Drawing.Point(548, 41);
            this.cursocombobox.Name = "cursocombobox";
            this.cursocombobox.Size = new System.Drawing.Size(187, 21);
            this.cursocombobox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Curso";
            // 
            // procurarbutton
            // 
            this.procurarbutton.Location = new System.Drawing.Point(660, 6);
            this.procurarbutton.Name = "procurarbutton";
            this.procurarbutton.Size = new System.Drawing.Size(75, 23);
            this.procurarbutton.TabIndex = 9;
            this.procurarbutton.Text = "Procurar";
            this.procurarbutton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 370);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.clienteslistview);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 344);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.compraslistview);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compras";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clienteslistview
            // 
            this.clienteslistview.Location = new System.Drawing.Point(7, 7);
            this.clienteslistview.Name = "clienteslistview";
            this.clienteslistview.Size = new System.Drawing.Size(758, 337);
            this.clienteslistview.TabIndex = 0;
            this.clienteslistview.UseCompatibleStateImageBehavior = false;
            // 
            // compraslistview
            // 
            this.compraslistview.Location = new System.Drawing.Point(7, 4);
            this.compraslistview.Name = "compraslistview";
            this.compraslistview.Size = new System.Drawing.Size(755, 334);
            this.compraslistview.TabIndex = 0;
            this.compraslistview.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.arranjoslistview);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 344);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Arranjos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // arranjoslistview
            // 
            this.arranjoslistview.Location = new System.Drawing.Point(7, 4);
            this.arranjoslistview.Name = "arranjoslistview";
            this.arranjoslistview.Size = new System.Drawing.Size(755, 337);
            this.arranjoslistview.TabIndex = 0;
            this.arranjoslistview.UseCompatibleStateImageBehavior = false;
            // 
            // Ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.procurarbutton);
            this.Controls.Add(this.cursocombobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.escolacombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cidadecombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nometextbox);
            this.Controls.Add(this.Nome);
            this.Name = "Ver";
            this.Text = "Ver Clientes";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox nometextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cidadecombobox;
        private System.Windows.Forms.ComboBox escolacombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cursocombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button procurarbutton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView clienteslistview;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView compraslistview;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView arranjoslistview;
    }
}
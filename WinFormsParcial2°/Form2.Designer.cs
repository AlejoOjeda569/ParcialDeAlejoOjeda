namespace WinFormsParcial2_
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            btnOk = new Button();
            btnCancelar = new Button();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtArista = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(34, 219);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 50);
            btnOk.TabIndex = 0;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(34, 275);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 50);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(168, 144);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(342, 144);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 162);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bordes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 62);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 4;
            label1.Text = "Ingrese la Arista del Cubo";
            // 
            // txtArista
            // 
            txtArista.Location = new Point(190, 59);
            txtArista.Name = "txtArista";
            txtArista.Size = new Size(153, 23);
            txtArista.TabIndex = 5;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 366);
            Controls.Add(txtArista);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Button btnCancelar;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtArista;
        private ErrorProvider errorProvider1;
    }
}
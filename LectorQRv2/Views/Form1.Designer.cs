namespace LectorQRv2.Views
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCedula1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedula1 = new System.Windows.Forms.TextBox();
            this.txtPlaca1 = new System.Windows.Forms.TextBox();
            this.btnPlaca1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPlaca2 = new System.Windows.Forms.Button();
            this.txtPlaca2 = new System.Windows.Forms.TextBox();
            this.txtCedula2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCedula2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(9, 60);
            this.videoSourcePlayer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(184, 211);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 19);
            this.button2.TabIndex = 2;
            this.button2.Text = "Detener";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(231, 60);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(174, 212);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(2, 13);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPlaca1);
            this.groupBox1.Controls.Add(this.txtPlaca1);
            this.groupBox1.Controls.Add(this.txtCedula1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCedula1);
            this.groupBox1.Location = new System.Drawing.Point(441, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Testing Entrada";
            // 
            // btnCedula1
            // 
            this.btnCedula1.Location = new System.Drawing.Point(205, 32);
            this.btnCedula1.Name = "btnCedula1";
            this.btnCedula1.Size = new System.Drawing.Size(75, 23);
            this.btnCedula1.TabIndex = 0;
            this.btnCedula1.Text = "Agregar";
            this.btnCedula1.UseVisualStyleBackColor = true;
            this.btnCedula1.Click += new System.EventHandler(this.btnCedula1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "qr manual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "placa manual: ";
            // 
            // txtCedula1
            // 
            this.txtCedula1.Location = new System.Drawing.Point(99, 34);
            this.txtCedula1.Name = "txtCedula1";
            this.txtCedula1.Size = new System.Drawing.Size(100, 20);
            this.txtCedula1.TabIndex = 3;
            // 
            // txtPlaca1
            // 
            this.txtPlaca1.Location = new System.Drawing.Point(99, 68);
            this.txtPlaca1.Name = "txtPlaca1";
            this.txtPlaca1.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca1.TabIndex = 4;
            // 
            // btnPlaca1
            // 
            this.btnPlaca1.Location = new System.Drawing.Point(205, 66);
            this.btnPlaca1.Name = "btnPlaca1";
            this.btnPlaca1.Size = new System.Drawing.Size(75, 23);
            this.btnPlaca1.TabIndex = 5;
            this.btnPlaca1.Text = "Agregar";
            this.btnPlaca1.UseVisualStyleBackColor = true;
            this.btnPlaca1.Click += new System.EventHandler(this.btnPlaca1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPlaca2);
            this.groupBox2.Controls.Add(this.txtPlaca2);
            this.groupBox2.Controls.Add(this.txtCedula2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnCedula2);
            this.groupBox2.Location = new System.Drawing.Point(441, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Testing Salida";
            // 
            // btnPlaca2
            // 
            this.btnPlaca2.Location = new System.Drawing.Point(205, 66);
            this.btnPlaca2.Name = "btnPlaca2";
            this.btnPlaca2.Size = new System.Drawing.Size(75, 23);
            this.btnPlaca2.TabIndex = 5;
            this.btnPlaca2.Text = "Agregar";
            this.btnPlaca2.UseVisualStyleBackColor = true;
            this.btnPlaca2.Click += new System.EventHandler(this.btnPlaca2_Click);
            // 
            // txtPlaca2
            // 
            this.txtPlaca2.Location = new System.Drawing.Point(99, 68);
            this.txtPlaca2.Name = "txtPlaca2";
            this.txtPlaca2.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca2.TabIndex = 4;
            // 
            // txtCedula2
            // 
            this.txtCedula2.Location = new System.Drawing.Point(99, 34);
            this.txtCedula2.Name = "txtCedula2";
            this.txtCedula2.Size = new System.Drawing.Size(100, 20);
            this.txtCedula2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "placa manual: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "qr manual:";
            // 
            // btnCedula2
            // 
            this.btnCedula2.Location = new System.Drawing.Point(205, 32);
            this.btnCedula2.Name = "btnCedula2";
            this.btnCedula2.Size = new System.Drawing.Size(75, 23);
            this.btnCedula2.TabIndex = 0;
            this.btnCedula2.Text = "Agregar";
            this.btnCedula2.UseVisualStyleBackColor = true;
            this.btnCedula2.Click += new System.EventHandler(this.btnCedula2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 381);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPlaca1;
        private System.Windows.Forms.TextBox txtPlaca1;
        private System.Windows.Forms.TextBox txtCedula1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCedula1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPlaca2;
        private System.Windows.Forms.TextBox txtPlaca2;
        private System.Windows.Forms.TextBox txtCedula2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCedula2;
    }
}


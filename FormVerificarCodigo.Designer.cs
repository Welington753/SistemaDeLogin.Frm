namespace SistemaLogin
{
    partial class FormVerificarCodigo
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
            this.btnVerificar = new System.Windows.Forms.Button();
            this.panelEsquerda = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReenviar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timerReenvio = new System.Windows.Forms.Timer(this.components);
            this.txtCod1 = new System.Windows.Forms.TextBox();
            this.txtCod2 = new System.Windows.Forms.TextBox();
            this.txtCod3 = new System.Windows.Forms.TextBox();
            this.txtCod4 = new System.Windows.Forms.TextBox();
            this.txtCod5 = new System.Windows.Forms.TextBox();
            this.txtCod6 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panelEsquerda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificar.FlatAppearance.BorderSize = 0;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Location = new System.Drawing.Point(314, 248);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(279, 33);
            this.btnVerificar.TabIndex = 0;
            this.btnVerificar.Text = "Confirmar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelEsquerda
            // 
            this.panelEsquerda.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelEsquerda.Controls.Add(this.pictureBox2);
            this.panelEsquerda.Controls.Add(this.label4);
            this.panelEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEsquerda.Location = new System.Drawing.Point(0, 0);
            this.panelEsquerda.Name = "panelEsquerda";
            this.panelEsquerda.Size = new System.Drawing.Size(277, 453);
            this.panelEsquerda.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SistemaLogin.Properties.Resources.icons8_security_shield_60;
            this.pictureBox2.Location = new System.Drawing.Point(12, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "SecureAccess";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(352, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "e-mail para recuperar sua conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Digite o código que enviamos para seu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(375, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "Verificar Código";
            // 
            // btnReenviar
            // 
            this.btnReenviar.BackColor = System.Drawing.Color.Transparent;
            this.btnReenviar.FlatAppearance.BorderSize = 0;
            this.btnReenviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReenviar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReenviar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnReenviar.Location = new System.Drawing.Point(380, 298);
            this.btnReenviar.Name = "btnReenviar";
            this.btnReenviar.Size = new System.Drawing.Size(161, 27);
            this.btnReenviar.TabIndex = 19;
            this.btnReenviar.Text = "Reenviar código";
            this.btnReenviar.UseVisualStyleBackColor = false;
            this.btnReenviar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button2.Location = new System.Drawing.Point(380, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 27);
            this.button2.TabIndex = 20;
            this.button2.Text = "Voltar ao login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timerReenvio
            // 
            this.timerReenvio.Interval = 30000;
            this.timerReenvio.Tick += new System.EventHandler(this.timerReenvio_Tick);
            // 
            // txtCod1
            // 
            this.txtCod1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod1.Location = new System.Drawing.Point(314, 191);
            this.txtCod1.MaxLength = 1;
            this.txtCod1.Name = "txtCod1";
            this.txtCod1.Size = new System.Drawing.Size(40, 41);
            this.txtCod1.TabIndex = 2;
            this.txtCod1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCod1.TextChanged += new System.EventHandler(this.txtCodigo1_TextChanged);
            // 
            // txtCod2
            // 
            this.txtCod2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod2.Location = new System.Drawing.Point(360, 191);
            this.txtCod2.MaxLength = 1;
            this.txtCod2.Name = "txtCod2";
            this.txtCod2.Size = new System.Drawing.Size(40, 41);
            this.txtCod2.TabIndex = 21;
            this.txtCod2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCod2.TextChanged += new System.EventHandler(this.txtCod2_TextChanged);
            // 
            // txtCod3
            // 
            this.txtCod3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod3.Location = new System.Drawing.Point(406, 191);
            this.txtCod3.MaxLength = 1;
            this.txtCod3.Name = "txtCod3";
            this.txtCod3.Size = new System.Drawing.Size(40, 41);
            this.txtCod3.TabIndex = 22;
            this.txtCod3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCod3.TextChanged += new System.EventHandler(this.txtCod3_TextChanged);
            // 
            // txtCod4
            // 
            this.txtCod4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod4.Location = new System.Drawing.Point(461, 191);
            this.txtCod4.MaxLength = 1;
            this.txtCod4.Name = "txtCod4";
            this.txtCod4.Size = new System.Drawing.Size(40, 41);
            this.txtCod4.TabIndex = 23;
            this.txtCod4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCod4.TextChanged += new System.EventHandler(this.txtCod4_TextChanged);
            // 
            // txtCod5
            // 
            this.txtCod5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod5.Location = new System.Drawing.Point(507, 191);
            this.txtCod5.MaxLength = 1;
            this.txtCod5.Name = "txtCod5";
            this.txtCod5.Size = new System.Drawing.Size(40, 41);
            this.txtCod5.TabIndex = 24;
            this.txtCod5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCod5.TextChanged += new System.EventHandler(this.txtCod5_TextChanged);
            // 
            // txtCod6
            // 
            this.txtCod6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod6.Location = new System.Drawing.Point(553, 191);
            this.txtCod6.MaxLength = 1;
            this.txtCod6.Name = "txtCod6";
            this.txtCod6.Size = new System.Drawing.Size(40, 41);
            this.txtCod6.TabIndex = 25;
            this.txtCod6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(591, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 27);
            this.button4.TabIndex = 26;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormVerificarCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(638, 453);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtCod6);
            this.Controls.Add(this.txtCod5);
            this.Controls.Add(this.txtCod4);
            this.Controls.Add(this.txtCod3);
            this.Controls.Add(this.txtCod2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnReenviar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelEsquerda);
            this.Controls.Add(this.txtCod1);
            this.Controls.Add(this.btnVerificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVerificarCodigo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelEsquerda.ResumeLayout(false);
            this.panelEsquerda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Panel panelEsquerda;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReenviar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timerReenvio;
        private System.Windows.Forms.TextBox txtCod1;
        private System.Windows.Forms.TextBox txtCod2;
        private System.Windows.Forms.TextBox txtCod3;
        private System.Windows.Forms.TextBox txtCod4;
        private System.Windows.Forms.TextBox txtCod5;
        private System.Windows.Forms.TextBox txtCod6;
        private System.Windows.Forms.Button button4;
    }
}
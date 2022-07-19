namespace Seriport
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonconnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.buton_disconnect = new System.Windows.Forms.Button();
            this.textBoxalıcı = new System.Windows.Forms.TextBox();
            this.textBoxsend = new System.Windows.Forms.TextBox();
            this.buttonsend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // buttonconnect
            // 
            this.buttonconnect.Location = new System.Drawing.Point(139, 12);
            this.buttonconnect.Name = "buttonconnect";
            this.buttonconnect.Size = new System.Drawing.Size(127, 23);
            this.buttonconnect.TabIndex = 1;
            this.buttonconnect.Text = "CONNECT";
            this.buttonconnect.UseVisualStyleBackColor = true;
            this.buttonconnect.Click += new System.EventHandler(this.buttonconnect_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // buton_disconnect
            // 
            this.buton_disconnect.Location = new System.Drawing.Point(273, 11);
            this.buton_disconnect.Name = "buton_disconnect";
            this.buton_disconnect.Size = new System.Drawing.Size(94, 23);
            this.buton_disconnect.TabIndex = 2;
            this.buton_disconnect.Text = "DİSCONNECT";
            this.buton_disconnect.UseVisualStyleBackColor = true;
            this.buton_disconnect.Click += new System.EventHandler(this.buton_disconnect_Click);
            // 
            // textBoxalıcı
            // 
            this.textBoxalıcı.Location = new System.Drawing.Point(13, 40);
            this.textBoxalıcı.Multiline = true;
            this.textBoxalıcı.Name = "textBoxalıcı";
            this.textBoxalıcı.Size = new System.Drawing.Size(354, 159);
            this.textBoxalıcı.TabIndex = 3;
            // 
            // textBoxsend
            // 
            this.textBoxsend.Location = new System.Drawing.Point(13, 206);
            this.textBoxsend.Name = "textBoxsend";
            this.textBoxsend.Size = new System.Drawing.Size(253, 20);
            this.textBoxsend.TabIndex = 4;
            // 
            // buttonsend
            // 
            this.buttonsend.Location = new System.Drawing.Point(273, 206);
            this.buttonsend.Name = "buttonsend";
            this.buttonsend.Size = new System.Drawing.Size(94, 23);
            this.buttonsend.TabIndex = 5;
            this.buttonsend.Text = "GÖNDER";
            this.buttonsend.UseVisualStyleBackColor = true;
            this.buttonsend.Click += new System.EventHandler(this.buttonsend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 237);
            this.Controls.Add(this.buttonsend);
            this.Controls.Add(this.textBoxsend);
            this.Controls.Add(this.textBoxalıcı);
            this.Controls.Add(this.buton_disconnect);
            this.Controls.Add(this.buttonconnect);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonconnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buton_disconnect;
        private System.Windows.Forms.TextBox textBoxalıcı;
        private System.Windows.Forms.TextBox textBoxsend;
        private System.Windows.Forms.Button buttonsend;
    }
}


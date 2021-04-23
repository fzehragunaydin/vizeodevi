
namespace vizeodevi
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
            this.btnxmlyazdır = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnxmlyazdır
            // 
            this.btnxmlyazdır.Location = new System.Drawing.Point(266, 35);
            this.btnxmlyazdır.Name = "btnxmlyazdır";
            this.btnxmlyazdır.Size = new System.Drawing.Size(405, 33);
            this.btnxmlyazdır.TabIndex = 0;
            this.btnxmlyazdır.Text = "YOL DURUMU";
            this.btnxmlyazdır.UseVisualStyleBackColor = true;
            this.btnxmlyazdır.Click += new System.EventHandler(this.btnxmlyazdır_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 651);
            this.Controls.Add(this.btnxmlyazdır);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnxmlyazdır;
    }
}


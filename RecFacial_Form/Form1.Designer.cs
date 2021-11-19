
namespace RecFacial_Form
{
    partial class form_RecFacial
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
            this.pic_Camera = new System.Windows.Forms.PictureBox();
            this.pic_Captura = new System.Windows.Forms.PictureBox();
            this.lbl_Camera = new System.Windows.Forms.Label();
            this.lbl_Captura = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.btn_AbrirCam = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Detectar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Camera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Captura)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Camera
            // 
            this.pic_Camera.Location = new System.Drawing.Point(28, 42);
            this.pic_Camera.Name = "pic_Camera";
            this.pic_Camera.Size = new System.Drawing.Size(359, 292);
            this.pic_Camera.TabIndex = 0;
            this.pic_Camera.TabStop = false;
            // 
            // pic_Captura
            // 
            this.pic_Captura.Location = new System.Drawing.Point(431, 206);
            this.pic_Captura.Name = "pic_Captura";
            this.pic_Captura.Size = new System.Drawing.Size(135, 128);
            this.pic_Captura.TabIndex = 1;
            this.pic_Captura.TabStop = false;
            // 
            // lbl_Camera
            // 
            this.lbl_Camera.AutoSize = true;
            this.lbl_Camera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Camera.Location = new System.Drawing.Point(24, 19);
            this.lbl_Camera.Name = "lbl_Camera";
            this.lbl_Camera.Size = new System.Drawing.Size(65, 20);
            this.lbl_Camera.TabIndex = 2;
            this.lbl_Camera.Text = "Camera";
            // 
            // lbl_Captura
            // 
            this.lbl_Captura.AutoSize = true;
            this.lbl_Captura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Captura.Location = new System.Drawing.Point(427, 183);
            this.lbl_Captura.Name = "lbl_Captura";
            this.lbl_Captura.Size = new System.Drawing.Size(66, 20);
            this.lbl_Captura.TabIndex = 3;
            this.lbl_Captura.Text = "Captura";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(269, 362);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(51, 20);
            this.lbl_Nome.TabIndex = 4;
            this.lbl_Nome.Text = "Nome";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(347, 364);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(135, 20);
            this.txt_Nome.TabIndex = 5;
            // 
            // btn_AbrirCam
            // 
            this.btn_AbrirCam.Location = new System.Drawing.Point(623, 42);
            this.btn_AbrirCam.Name = "btn_AbrirCam";
            this.btn_AbrirCam.Size = new System.Drawing.Size(142, 53);
            this.btn_AbrirCam.TabIndex = 6;
            this.btn_AbrirCam.Text = "Abrir Camera";
            this.btn_AbrirCam.UseVisualStyleBackColor = true;
            this.btn_AbrirCam.Click += new System.EventHandler(this.btn_AbrirCam_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(623, 150);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(142, 53);
            this.btn_Salvar.TabIndex = 7;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Detectar
            // 
            this.btn_Detectar.Location = new System.Drawing.Point(623, 281);
            this.btn_Detectar.Name = "btn_Detectar";
            this.btn_Detectar.Size = new System.Drawing.Size(142, 53);
            this.btn_Detectar.TabIndex = 8;
            this.btn_Detectar.Text = "Detectar";
            this.btn_Detectar.UseVisualStyleBackColor = true;
            this.btn_Detectar.Click += new System.EventHandler(this.btn_Detectar_Click);
            // 
            // form_RecFacial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Detectar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_AbrirCam);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.lbl_Captura);
            this.Controls.Add(this.lbl_Camera);
            this.Controls.Add(this.pic_Captura);
            this.Controls.Add(this.pic_Camera);
            this.Name = "form_RecFacial";
            this.Text = "Detecção Facial";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Camera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Captura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Camera;
        private System.Windows.Forms.PictureBox pic_Captura;
        private System.Windows.Forms.Label lbl_Camera;
        private System.Windows.Forms.Label lbl_Captura;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Button btn_AbrirCam;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Detectar;
    }
}


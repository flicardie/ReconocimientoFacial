namespace ReconocimientoFacial
{
    partial class FrmPrincipal
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
            this.captureButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageBoxCamaraNormal = new ReconocimientoFacial.ImageBox();
            this.imageBoxCamaraConDeteccion = new ReconocimientoFacial.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxCamaraNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxCamaraConDeteccion)).BeginInit();
            this.SuspendLayout();
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(23, 27);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(102, 23);
            this.captureButton.TabIndex = 1;
            this.captureButton.Text = "Start Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.CapturarVideoClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cámara Normal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(618, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cámara con detección";
            // 
            // imageBoxCamaraNormal
            // 
            this.imageBoxCamaraNormal.FunctionalMode = ((ReconocimientoFacial.ImageBox.FunctionalModeOption)((ReconocimientoFacial.ImageBox.FunctionalModeOption.RightClickMenu | ReconocimientoFacial.ImageBox.FunctionalModeOption.PanAndZoom)));
            this.imageBoxCamaraNormal.Location = new System.Drawing.Point(23, 117);
            this.imageBoxCamaraNormal.Name = "imageBoxCamaraNormal";
            this.imageBoxCamaraNormal.Size = new System.Drawing.Size(529, 395);
            this.imageBoxCamaraNormal.TabIndex = 3;
            this.imageBoxCamaraNormal.TabStop = false;
            // 
            // imageBoxCamaraConDeteccion
            // 
            this.imageBoxCamaraConDeteccion.FunctionalMode = ((ReconocimientoFacial.ImageBox.FunctionalModeOption)((ReconocimientoFacial.ImageBox.FunctionalModeOption.RightClickMenu | ReconocimientoFacial.ImageBox.FunctionalModeOption.PanAndZoom)));
            this.imageBoxCamaraConDeteccion.Location = new System.Drawing.Point(621, 117);
            this.imageBoxCamaraConDeteccion.Name = "imageBoxCamaraConDeteccion";
            this.imageBoxCamaraConDeteccion.Size = new System.Drawing.Size(529, 395);
            this.imageBoxCamaraConDeteccion.TabIndex = 2;
            this.imageBoxCamaraConDeteccion.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageBoxCamaraNormal);
            this.Controls.Add(this.imageBoxCamaraConDeteccion);
            this.Controls.Add(this.captureButton);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxCamaraNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxCamaraConDeteccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button captureButton;
        private ImageBox imageBoxCamaraConDeteccion;
        private ImageBox imageBoxCamaraNormal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


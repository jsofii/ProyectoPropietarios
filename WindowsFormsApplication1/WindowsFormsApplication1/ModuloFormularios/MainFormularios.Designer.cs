namespace WindowsFormsApplication1.ModuloFormularios
{
    partial class MainFormularios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_reporteConductor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_reporteConductor);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(74, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 380);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_reporteConductor
            // 
            this.btn_reporteConductor.Enabled = false;
            this.btn_reporteConductor.Location = new System.Drawing.Point(264, 232);
            this.btn_reporteConductor.Name = "btn_reporteConductor";
            this.btn_reporteConductor.Size = new System.Drawing.Size(170, 23);
            this.btn_reporteConductor.TabIndex = 2;
            this.btn_reporteConductor.Text = "INGRESAR REPORTE";
            this.btn_reporteConductor.UseVisualStyleBackColor = true;
            this.btn_reporteConductor.Click += new System.EventHandler(this.ingresarReporte);
            // 
            // MainFormularios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "MainFormularios";
            this.Text = "MainFormularios";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_reporteConductor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
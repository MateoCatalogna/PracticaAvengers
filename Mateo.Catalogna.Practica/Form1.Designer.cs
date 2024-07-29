namespace Mateo.Catalogna.Practica
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMostrar = new Button();
            rtbPersonajes = new RichTextBox();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(214, 12);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(217, 35);
            btnMostrar.TabIndex = 0;
            btnMostrar.Text = "Mostrar Personaje";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // rtbPersonajes
            // 
            rtbPersonajes.Location = new Point(12, 115);
            rtbPersonajes.Name = "rtbPersonajes";
            rtbPersonajes.Size = new Size(611, 196);
            rtbPersonajes.TabIndex = 1;
            rtbPersonajes.Text = "";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(635, 344);
            Controls.Add(rtbPersonajes);
            Controls.Add(btnMostrar);
            Name = "FrmPrincipal";
            Text = "Mateo.Catalogna.Practica";
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnMostrar;
        private RichTextBox rtbPersonajes;
    }
}

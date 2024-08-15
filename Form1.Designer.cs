namespace WinFormsApp1
{
    partial class Form1
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
            BotonAceptar = new Button();
            BotonLimpiar = new Button();
            LabelNombre = new Label();
            LabelCorreo = new Label();
            LabelTelefono = new Label();
            TextNombre = new TextBox();
            TextTelefono = new TextBox();
            TextCorreo = new TextBox();
            LabelConfirmacion = new Label();
            SuspendLayout();
            // 
            // BotonAceptar
            // 
            BotonAceptar.Location = new Point(116, 296);
            BotonAceptar.Margin = new Padding(3, 2, 3, 2);
            BotonAceptar.Name = "BotonAceptar";
            BotonAceptar.Size = new Size(82, 22);
            BotonAceptar.TabIndex = 0;
            BotonAceptar.Text = "Aceptar";
            BotonAceptar.UseVisualStyleBackColor = true;
            BotonAceptar.Click += BotonAceptar_Click;
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.Location = new Point(244, 296);
            BotonLimpiar.Margin = new Padding(3, 2, 3, 2);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(82, 22);
            BotonLimpiar.TabIndex = 1;
            BotonLimpiar.Text = "Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = true;
            BotonLimpiar.Click += BotonLimpiar_Click;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.Font = new Font("Castellar", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelNombre.Location = new Point(86, 61);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(71, 14);
            LabelNombre.TabIndex = 2;
            LabelNombre.Text = "Nombre";
            LabelNombre.Click += label1_Click;
            // 
            // LabelCorreo
            // 
            LabelCorreo.AutoSize = true;
            LabelCorreo.Font = new Font("Castellar", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelCorreo.Location = new Point(86, 178);
            LabelCorreo.Name = "LabelCorreo";
            LabelCorreo.Size = new Size(67, 14);
            LabelCorreo.TabIndex = 3;
            LabelCorreo.Text = "Correo";
            // 
            // LabelTelefono
            // 
            LabelTelefono.AutoSize = true;
            LabelTelefono.Font = new Font("Castellar", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelTelefono.Location = new Point(86, 123);
            LabelTelefono.Name = "LabelTelefono";
            LabelTelefono.Size = new Size(84, 14);
            LabelTelefono.TabIndex = 4;
            LabelTelefono.Text = "Telefono";
            // 
            // TextNombre
            // 
            TextNombre.Location = new Point(86, 89);
            TextNombre.Margin = new Padding(3, 2, 3, 2);
            TextNombre.Name = "TextNombre";
            TextNombre.Size = new Size(293, 23);
            TextNombre.TabIndex = 5;
            // 
            // TextTelefono
            // 
            TextTelefono.Location = new Point(86, 146);
            TextTelefono.Margin = new Padding(3, 2, 3, 2);
            TextTelefono.Name = "TextTelefono";
            TextTelefono.Size = new Size(293, 23);
            TextTelefono.TabIndex = 6;
            // 
            // TextCorreo
            // 
            TextCorreo.Location = new Point(86, 201);
            TextCorreo.Margin = new Padding(3, 2, 3, 2);
            TextCorreo.Name = "TextCorreo";
            TextCorreo.Size = new Size(293, 23);
            TextCorreo.TabIndex = 7;
            // 
            // LabelConfirmacion
            // 
            LabelConfirmacion.AutoSize = true;
            LabelConfirmacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelConfirmacion.ForeColor = Color.Red;
            LabelConfirmacion.Location = new Point(116, 260);
            LabelConfirmacion.Name = "LabelConfirmacion";
            LabelConfirmacion.Size = new Size(0, 17);
            LabelConfirmacion.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(458, 338);
            Controls.Add(LabelConfirmacion);
            Controls.Add(TextCorreo);
            Controls.Add(TextTelefono);
            Controls.Add(TextNombre);
            Controls.Add(LabelTelefono);
            Controls.Add(LabelCorreo);
            Controls.Add(LabelNombre);
            Controls.Add(BotonLimpiar);
            Controls.Add(BotonAceptar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonAceptar;
        private Button BotonLimpiar;
        private Label LabelNombre;
        private Label LabelCorreo;
        private Label LabelTelefono;
        private TextBox TextNombre;
        private TextBox TextTelefono;
        private TextBox TextCorreo;
        private Label LabelConfirmacion;
    }
}

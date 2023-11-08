namespace Figuras_Geometricas
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
            TextBox txtLongitud;
            LblRadio = new Label();
            LblArea = new Label();
            LblLongitud = new Label();
            txtRadio = new TextBox();
            txtArea = new TextBox();
            BtnCalcular = new Button();
            txtLongitud = new TextBox();
            SuspendLayout();
            // 
            // txtLongitud
            // 
            txtLongitud.ImeMode = ImeMode.Off;
            txtLongitud.Location = new Point(111, 140);
            txtLongitud.MaxLength = 10;
            txtLongitud.Name = "txtLongitud";
            txtLongitud.ReadOnly = true;
            txtLongitud.Size = new Size(100, 23);
            txtLongitud.TabIndex = 5;
            // 
            // LblRadio
            // 
            LblRadio.AutoSize = true;
            LblRadio.Location = new Point(12, 51);
            LblRadio.Name = "LblRadio";
            LblRadio.Size = new Size(37, 15);
            LblRadio.TabIndex = 0;
            LblRadio.Text = "Radio";
            LblRadio.Click += lblRadio_Click;
            // 
            // LblArea
            // 
            LblArea.AutoSize = true;
            LblArea.Location = new Point(12, 98);
            LblArea.Name = "LblArea";
            LblArea.Size = new Size(31, 15);
            LblArea.TabIndex = 1;
            LblArea.Text = "Ârea";
            LblArea.Click += label2_Click;
            // 
            // LblLongitud
            // 
            LblLongitud.AutoSize = true;
            LblLongitud.Location = new Point(12, 141);
            LblLongitud.Name = "LblLongitud";
            LblLongitud.Size = new Size(55, 15);
            LblLongitud.TabIndex = 2;
            LblLongitud.Text = "Longitud";
            LblLongitud.Click += label3_Click;
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(111, 47);
            txtRadio.MaxLength = 10;
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(100, 23);
            txtRadio.TabIndex = 3;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(111, 97);
            txtArea.MaxLength = 10;
            txtArea.Name = "txtArea";
            txtArea.ReadOnly = true;
            txtArea.Size = new Size(100, 23);
            txtArea.TabIndex = 4;
            txtArea.TextChanged += textBox2_TextChanged;
            // 
            // BtnCalcular
            // 
            BtnCalcular.Location = new Point(136, 222);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(75, 23);
            BtnCalcular.TabIndex = 6;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.UseVisualStyleBackColor = true;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 261);
            Controls.Add(BtnCalcular);
            Controls.Add(txtLongitud);
            Controls.Add(txtArea);
            Controls.Add(txtRadio);
            Controls.Add(LblLongitud);
            Controls.Add(LblArea);
            Controls.Add(LblRadio);
            Name = "Form1";
            Text = "Circulo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblRadio;
        private Label LblArea;
        private Label LblLongitud;
        private TextBox txtRadio;
        private TextBox txtArea;
        private TextBox txtLongitud;
        private Button BtnCalcular;
    }
}
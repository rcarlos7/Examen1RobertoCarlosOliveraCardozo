namespace SistemasEmpleados.VISTA.PersonaVistas
{
    partial class PersonaEditarVista
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
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(423, 323);
            button2.Name = "button2";
            button2.Size = new Size(137, 54);
            button2.TabIndex = 15;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(217, 323);
            button1.Name = "button1";
            button1.Size = new Size(137, 54);
            button1.TabIndex = 14;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(269, 210);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(355, 27);
            textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(269, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(355, 27);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(269, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(355, 27);
            textBox1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 209);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 10;
            label3.Text = "ESTADO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 140);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 9;
            label2.Text = "APELLIDO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 71);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 8;
            label1.Text = "NOMBRE";
            // 
            // PersonaEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PersonaEditarVista";
            Text = "PersonaEditarVista";
            Load += PersonaEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
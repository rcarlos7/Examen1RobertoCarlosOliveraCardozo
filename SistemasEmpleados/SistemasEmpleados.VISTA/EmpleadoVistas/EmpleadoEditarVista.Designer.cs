namespace SistemasEmpleados.VISTA.EmpleadoVistas
{
    partial class EmpleadoEditarVista
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(242, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(355, 27);
            textBox1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 66);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 12;
            label1.Text = "PERSONA";
            // 
            // button1
            // 
            button1.Location = new Point(634, 59);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(242, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(355, 27);
            textBox2.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 133);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 15;
            label2.Text = "PUESTO";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(242, 195);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(355, 27);
            textBox3.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 200);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 17;
            label3.Text = "SALARIO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 267);
            label4.Name = "label4";
            label4.Size = new Size(190, 20);
            label4.TabIndex = 19;
            label4.Text = "FECHA DE CONTRATACION";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(242, 263);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(355, 27);
            dateTimePicker1.TabIndex = 20;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(438, 340);
            button2.Name = "button2";
            button2.Size = new Size(137, 54);
            button2.TabIndex = 22;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.DialogResult = DialogResult.OK;
            button3.Location = new Point(232, 340);
            button3.Name = "button3";
            button3.Size = new Size(137, 54);
            button3.TabIndex = 21;
            button3.Text = "GUARDAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // EmpleadoEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "EmpleadoEditarVista";
            Text = "EmpleadoEditarVista";
            Load += EmpleadoEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button3;
    }
}
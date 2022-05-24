namespace ProyectoIA202201
{
    partial class FormConfiguracionDeRed
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoRed = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoNeurona = new System.Windows.Forms.ComboBox();
            this.cmbFuncionActivacion = new System.Windows.Forms.ComboBox();
            this.cmbAlgoritmoEntrenamiento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNumCapas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NumNeuronasCap1 = new System.Windows.Forms.TextBox();
            this.NumNeuronasCap2 = new System.Windows.Forms.TextBox();
            this.NumNeuronasCap3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFuncionC1 = new System.Windows.Forms.ComboBox();
            this.cmbFuncionC2 = new System.Windows.Forms.ComboBox();
            this.cmbFuncionC3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(669, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuracion de la Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Red";
            // 
            // cmbTipoRed
            // 
            this.cmbTipoRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoRed.FormattingEnabled = true;
            this.cmbTipoRed.Location = new System.Drawing.Point(529, 112);
            this.cmbTipoRed.Name = "cmbTipoRed";
            this.cmbTipoRed.Size = new System.Drawing.Size(244, 37);
            this.cmbTipoRed.TabIndex = 2;
            this.cmbTipoRed.SelectedIndexChanged += new System.EventHandler(this.cmbTipoRed_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Unicapa";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTipoNeurona
            // 
            this.cmbTipoNeurona.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoNeurona.FormattingEnabled = true;
            this.cmbTipoNeurona.Location = new System.Drawing.Point(110, 240);
            this.cmbTipoNeurona.Name = "cmbTipoNeurona";
            this.cmbTipoNeurona.Size = new System.Drawing.Size(215, 37);
            this.cmbTipoNeurona.TabIndex = 4;
            this.cmbTipoNeurona.SelectedIndexChanged += new System.EventHandler(this.cmbTipoNeurona_SelectedIndexChanged);
            // 
            // cmbFuncionActivacion
            // 
            this.cmbFuncionActivacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFuncionActivacion.FormattingEnabled = true;
            this.cmbFuncionActivacion.Location = new System.Drawing.Point(110, 308);
            this.cmbFuncionActivacion.Name = "cmbFuncionActivacion";
            this.cmbFuncionActivacion.Size = new System.Drawing.Size(215, 37);
            this.cmbFuncionActivacion.TabIndex = 5;
            this.cmbFuncionActivacion.SelectedIndexChanged += new System.EventHandler(this.cmbFuncionActivacion_SelectedIndexChanged);
            // 
            // cmbAlgoritmoEntrenamiento
            // 
            this.cmbAlgoritmoEntrenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlgoritmoEntrenamiento.FormattingEnabled = true;
            this.cmbAlgoritmoEntrenamiento.Location = new System.Drawing.Point(110, 378);
            this.cmbAlgoritmoEntrenamiento.Name = "cmbAlgoritmoEntrenamiento";
            this.cmbAlgoritmoEntrenamiento.Size = new System.Drawing.Size(215, 37);
            this.cmbAlgoritmoEntrenamiento.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(890, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Multicapa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(657, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numero de Capas";
            // 
            // cmbNumCapas
            // 
            this.cmbNumCapas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNumCapas.FormattingEnabled = true;
            this.cmbNumCapas.Items.AddRange(new object[] {
            "1 Capa",
            "2 Capas",
            "3 Capas"});
            this.cmbNumCapas.Location = new System.Drawing.Point(853, 239);
            this.cmbNumCapas.Name = "cmbNumCapas";
            this.cmbNumCapas.Size = new System.Drawing.Size(221, 37);
            this.cmbNumCapas.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(517, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Numero Neuronas";
            // 
            // NumNeuronasCap1
            // 
            this.NumNeuronasCap1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumNeuronasCap1.Location = new System.Drawing.Point(755, 307);
            this.NumNeuronasCap1.Name = "NumNeuronasCap1";
            this.NumNeuronasCap1.Size = new System.Drawing.Size(86, 34);
            this.NumNeuronasCap1.TabIndex = 11;
            this.NumNeuronasCap1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumNeuronasCap1_KeyPress);
            // 
            // NumNeuronasCap2
            // 
            this.NumNeuronasCap2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumNeuronasCap2.Location = new System.Drawing.Point(876, 307);
            this.NumNeuronasCap2.Name = "NumNeuronasCap2";
            this.NumNeuronasCap2.Size = new System.Drawing.Size(86, 34);
            this.NumNeuronasCap2.TabIndex = 12;
            this.NumNeuronasCap2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumNeuronasCap2_KeyPress);
            // 
            // NumNeuronasCap3
            // 
            this.NumNeuronasCap3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumNeuronasCap3.Location = new System.Drawing.Point(988, 307);
            this.NumNeuronasCap3.Name = "NumNeuronasCap3";
            this.NumNeuronasCap3.Size = new System.Drawing.Size(86, 34);
            this.NumNeuronasCap3.TabIndex = 13;
            this.NumNeuronasCap3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(594, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Funcion";
            // 
            // cmbFuncionC1
            // 
            this.cmbFuncionC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFuncionC1.FormattingEnabled = true;
            this.cmbFuncionC1.Items.AddRange(new object[] {
            "TANGENTE",
            "HIPERBOLICA",
            "SIGMOIDE",
            "SENO",
            "COSENO",
            "GAUSIANA"});
            this.cmbFuncionC1.Location = new System.Drawing.Point(755, 378);
            this.cmbFuncionC1.Name = "cmbFuncionC1";
            this.cmbFuncionC1.Size = new System.Drawing.Size(86, 37);
            this.cmbFuncionC1.TabIndex = 15;
            // 
            // cmbFuncionC2
            // 
            this.cmbFuncionC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFuncionC2.FormattingEnabled = true;
            this.cmbFuncionC2.Items.AddRange(new object[] {
            "TANGENTE",
            "HIPERBOLICA",
            "SIGMOIDE",
            "SENO",
            "COSENO",
            "GAUSIANA"});
            this.cmbFuncionC2.Location = new System.Drawing.Point(876, 378);
            this.cmbFuncionC2.Name = "cmbFuncionC2";
            this.cmbFuncionC2.Size = new System.Drawing.Size(86, 37);
            this.cmbFuncionC2.TabIndex = 16;
            // 
            // cmbFuncionC3
            // 
            this.cmbFuncionC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFuncionC3.FormattingEnabled = true;
            this.cmbFuncionC3.Items.AddRange(new object[] {
            "TANGENTE",
            "HIPERBOLICA",
            "SIGMOIDE",
            "SENO",
            "COSENO",
            "GAUSIANA"});
            this.cmbFuncionC3.Location = new System.Drawing.Point(988, 378);
            this.cmbFuncionC3.Name = "cmbFuncionC3";
            this.cmbFuncionC3.Size = new System.Drawing.Size(86, 37);
            this.cmbFuncionC3.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(946, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(193, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 40);
            this.button2.TabIndex = 19;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormConfiguracionDeRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 638);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbFuncionC3);
            this.Controls.Add(this.cmbFuncionC2);
            this.Controls.Add(this.cmbFuncionC1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumNeuronasCap3);
            this.Controls.Add(this.NumNeuronasCap2);
            this.Controls.Add(this.NumNeuronasCap1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbNumCapas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbAlgoritmoEntrenamiento);
            this.Controls.Add(this.cmbFuncionActivacion);
            this.Controls.Add(this.cmbTipoNeurona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipoRed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormConfiguracionDeRed";
            this.Text = "ConfiguracionDeRed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoRed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoNeurona;
        private System.Windows.Forms.ComboBox cmbFuncionActivacion;
        private System.Windows.Forms.ComboBox cmbAlgoritmoEntrenamiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbNumCapas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NumNeuronasCap1;
        private System.Windows.Forms.TextBox NumNeuronasCap2;
        private System.Windows.Forms.TextBox NumNeuronasCap3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFuncionC1;
        private System.Windows.Forms.ComboBox cmbFuncionC2;
        private System.Windows.Forms.ComboBox cmbFuncionC3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
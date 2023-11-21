namespace ProyectoRefaccionaria
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            IdCamion = new TextBox();
            Nombre = new TextBox();
            Totalmacenaje = new TextBox();
            Placas = new TextBox();
            Marca = new TextBox();
            BuscarId = new Button();
            BuscarNombre = new Button();
            BuscarTotal = new Button();
            BuscarPlacas = new Button();
            BuscarMarca = new Button();
            MostrarTodos = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(507, 229);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(677, 372);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 123);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(599, 77);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Placas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 181);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 3;
            label3.Text = "Totalmacenaje:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(599, 147);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 4;
            label4.Text = "Marca:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 65);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 5;
            label5.Text = "IdCamion:";
            // 
            // IdCamion
            // 
            IdCamion.Location = new Point(161, 61);
            IdCamion.Name = "IdCamion";
            IdCamion.Size = new Size(167, 27);
            IdCamion.TabIndex = 6;
            IdCamion.TextAlign = HorizontalAlignment.Right;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(158, 123);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(170, 27);
            Nombre.TabIndex = 7;
            Nombre.TextAlign = HorizontalAlignment.Right;
            // 
            // Totalmacenaje
            // 
            Totalmacenaje.Location = new Point(158, 179);
            Totalmacenaje.Name = "Totalmacenaje";
            Totalmacenaje.Size = new Size(155, 27);
            Totalmacenaje.TabIndex = 8;
            Totalmacenaje.TextAlign = HorizontalAlignment.Right;
            // 
            // Placas
            // 
            Placas.Location = new Point(677, 77);
            Placas.Name = "Placas";
            Placas.Size = new Size(172, 27);
            Placas.TabIndex = 9;
            Placas.TextAlign = HorizontalAlignment.Right;
            // 
            // Marca
            // 
            Marca.Location = new Point(677, 143);
            Marca.Name = "Marca";
            Marca.Size = new Size(159, 27);
            Marca.TabIndex = 10;
            Marca.TextAlign = HorizontalAlignment.Right;
            
            // 
            // BuscarId
            // 
            BuscarId.Location = new Point(361, 64);
            BuscarId.Name = "BuscarId";
            BuscarId.Size = new Size(80, 33);
            BuscarId.TabIndex = 11;
            BuscarId.Text = "Buscar";
            BuscarId.UseVisualStyleBackColor = true;
            BuscarId.Click += BuscarId_Click;
            // 
            // BuscarNombre
            // 
            BuscarNombre.Location = new Point(358, 123);
            BuscarNombre.Name = "BuscarNombre";
            BuscarNombre.Size = new Size(83, 29);
            BuscarNombre.TabIndex = 12;
            BuscarNombre.Text = "Buscar";
            BuscarNombre.UseVisualStyleBackColor = true;
            BuscarNombre.Click += BuscarNombre_Click_1;
            // 
            // BuscarTotal
            // 
            BuscarTotal.Location = new Point(358, 181);
            BuscarTotal.Name = "BuscarTotal";
            BuscarTotal.Size = new Size(83, 28);
            BuscarTotal.TabIndex = 13;
            BuscarTotal.Text = "Buscar";
            BuscarTotal.UseVisualStyleBackColor = true;
            BuscarTotal.Click += BuscarTotal_Click;
            // 
            // BuscarPlacas
            // 
            BuscarPlacas.Location = new Point(893, 75);
            BuscarPlacas.Name = "BuscarPlacas";
            BuscarPlacas.Size = new Size(95, 31);
            BuscarPlacas.TabIndex = 14;
            BuscarPlacas.Text = "Buscar";
            BuscarPlacas.UseVisualStyleBackColor = true;
            BuscarPlacas.Click += BuscarPlacas_Click;
            // 
            // BuscarMarca
            // 
            BuscarMarca.Location = new Point(893, 147);
            BuscarMarca.Name = "BuscarMarca";
            BuscarMarca.Size = new Size(89, 28);
            BuscarMarca.TabIndex = 15;
            BuscarMarca.Text = "Buscar";
            BuscarMarca.UseVisualStyleBackColor = true;
            BuscarMarca.Click += BuscarMarca_Click;
            // 
            // MostrarTodos
            // 
            MostrarTodos.Location = new Point(169, 327);
            MostrarTodos.Name = "MostrarTodos";
            MostrarTodos.Size = new Size(159, 43);
            MostrarTodos.TabIndex = 16;
            MostrarTodos.Text = "Mostrar Todos";
            MostrarTodos.UseVisualStyleBackColor = true;
            MostrarTodos.Click += MostrarTodos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 683);
            Controls.Add(MostrarTodos);
            Controls.Add(BuscarMarca);
            Controls.Add(BuscarPlacas);
            Controls.Add(BuscarTotal);
            Controls.Add(BuscarNombre);
            Controls.Add(BuscarId);
            Controls.Add(Marca);
            Controls.Add(Placas);
            Controls.Add(Totalmacenaje);
            Controls.Add(Nombre);
            Controls.Add(IdCamion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox IdCamion;
        private TextBox Nombre;
        private TextBox Totalmacenaje;
        private TextBox Placas;
        private TextBox Marca;
        private Button BuscarId;
        private Button BuscarNombre;
        private Button BuscarTotal;
        private Button BuscarPlacas;
        private Button BuscarMarca;
        private Button MostrarTodos;
    }
}
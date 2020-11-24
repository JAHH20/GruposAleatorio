namespace Grupos_Aleatorios
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnAgregarParticipante = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerarGrupos = new System.Windows.Forms.Button();
            this.txtGruposCantidad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtGruposCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarParticipante
            // 
            this.btnAgregarParticipante.Location = new System.Drawing.Point(32, 161);
            this.btnAgregarParticipante.Name = "btnAgregarParticipante";
            this.btnAgregarParticipante.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarParticipante.TabIndex = 0;
            this.btnAgregarParticipante.Text = "Agregar";
            this.btnAgregarParticipante.UseVisualStyleBackColor = true;
            this.btnAgregarParticipante.Click += new System.EventHandler(this.btnAgregarParticipante_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(151, 161);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Pegar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.Location = new System.Drawing.Point(151, 336);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTodo.TabIndex = 3;
            this.btnEliminarTodo.Text = "Eliminar todo";
            this.btnEliminarTodo.UseVisualStyleBackColor = true;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(32, 199);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(430, 121);
            this.listBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(430, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese la lista de participantes y la cantidad de grupos a generar.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Grupos Aleatorios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "¿Cuántos grupos quieres formar?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Participante:";
            // 
            // btnGenerarGrupos
            // 
            this.btnGenerarGrupos.Location = new System.Drawing.Point(201, 451);
            this.btnGenerarGrupos.Name = "btnGenerarGrupos";
            this.btnGenerarGrupos.Size = new System.Drawing.Size(108, 33);
            this.btnGenerarGrupos.TabIndex = 11;
            this.btnGenerarGrupos.Text = "Generar grupos";
            this.btnGenerarGrupos.UseVisualStyleBackColor = true;
            this.btnGenerarGrupos.Click += new System.EventHandler(this.btnGenerarGrupos_Click);
            // 
            // txtGruposCantidad
            // 
            this.txtGruposCantidad.Location = new System.Drawing.Point(32, 414);
            this.txtGruposCantidad.Name = "txtGruposCantidad";
            this.txtGruposCantidad.Size = new System.Drawing.Size(120, 20);
            this.txtGruposCantidad.TabIndex = 12;
            this.txtGruposCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGruposCantidad.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 505);
            this.Controls.Add(this.txtGruposCantidad);
            this.Controls.Add(this.btnGenerarGrupos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEliminarTodo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarParticipante);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupos Aleatorios";
            ((System.ComponentModel.ISupportInitialize)(this.txtGruposCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarParticipante;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEliminarTodo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerarGrupos;
        private System.Windows.Forms.NumericUpDown txtGruposCantidad;
    }
}



namespace listasDatosSimples
{
    partial class Form1
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
            this.txtIngreseNum = new System.Windows.Forms.Label();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.textBoxIngreso = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonOrdenarAs = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonOrdenarDes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIngreseNum
            // 
            this.txtIngreseNum.AutoSize = true;
            this.txtIngreseNum.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngreseNum.Location = new System.Drawing.Point(80, 142);
            this.txtIngreseNum.Name = "txtIngreseNum";
            this.txtIngreseNum.Size = new System.Drawing.Size(107, 17);
            this.txtIngreseNum.TabIndex = 0;
            this.txtIngreseNum.Text = "Ingrese numero";
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresar.Location = new System.Drawing.Point(156, 207);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(104, 33);
            this.buttonIngresar.TabIndex = 2;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // textBoxIngreso
            // 
            this.textBoxIngreso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIngreso.Location = new System.Drawing.Point(208, 135);
            this.textBoxIngreso.Name = "textBoxIngreso";
            this.textBoxIngreso.Size = new System.Drawing.Size(141, 23);
            this.textBoxIngreso.TabIndex = 1;
            this.textBoxIngreso.TextChanged += new System.EventHandler(this.textBoxIngreso_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(435, 135);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(274, 157);
            this.listBox1.TabIndex = 4;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrar.Location = new System.Drawing.Point(435, 319);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(118, 38);
            this.buttonMostrar.TabIndex = 3;
            this.buttonMostrar.Text = "Mostrar datos";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // buttonOrdenarAs
            // 
            this.buttonOrdenarAs.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrdenarAs.Location = new System.Drawing.Point(568, 319);
            this.buttonOrdenarAs.Name = "buttonOrdenarAs";
            this.buttonOrdenarAs.Size = new System.Drawing.Size(141, 38);
            this.buttonOrdenarAs.TabIndex = 5;
            this.buttonOrdenarAs.Text = "Ordenar ascendente";
            this.buttonOrdenarAs.UseVisualStyleBackColor = true;
            this.buttonOrdenarAs.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(435, 393);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(118, 36);
            this.buttonEliminar.TabIndex = 6;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonOrdenarDes
            // 
            this.buttonOrdenarDes.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrdenarDes.Location = new System.Drawing.Point(568, 393);
            this.buttonOrdenarDes.Name = "buttonOrdenarDes";
            this.buttonOrdenarDes.Size = new System.Drawing.Size(141, 36);
            this.buttonOrdenarDes.TabIndex = 7;
            this.buttonOrdenarDes.Text = "Ordenar descendente";
            this.buttonOrdenarDes.UseVisualStyleBackColor = true;
            this.buttonOrdenarDes.Click += new System.EventHandler(this.buttonOrdenarDes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOrdenarDes);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonOrdenarAs);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxIngreso);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.txtIngreseNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtIngreseNum;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.TextBox textBoxIngreso;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button buttonOrdenarAs;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonOrdenarDes;
    }
}


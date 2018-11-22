namespace Windows_Hotel
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
            this.components = new System.ComponentModel.Container();
            this.grvDatos = new System.Windows.Forms.DataGridView();
            this.idHabitaconDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habiNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habiPisoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idHotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoHabiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoNumCamasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPrecioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reservar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataHabitacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblHabi1 = new System.Windows.Forms.Label();
            this.lblPrecio1 = new System.Windows.Forms.Label();
            this.lblHabi2 = new System.Windows.Forms.Label();
            this.lblPrecio2 = new System.Windows.Forms.Label();
            this.lblHabi3 = new System.Windows.Forms.Label();
            this.lblPrecio3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHabitacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grvDatos
            // 
            this.grvDatos.AllowUserToDeleteRows = false;
            this.grvDatos.AutoGenerateColumns = false;
            this.grvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHabitaconDataGridViewTextBoxColumn,
            this.habiNumDataGridViewTextBoxColumn,
            this.habiPisoDataGridViewTextBoxColumn,
            this.idHotelDataGridViewTextBoxColumn,
            this.idTipoHabiDataGridViewTextBoxColumn,
            this.tipoNombreDataGridViewTextBoxColumn,
            this.tipoDescripcionDataGridViewTextBoxColumn,
            this.tipoNumCamasDataGridViewTextBoxColumn,
            this.tipoPrecioDataGridViewTextBoxColumn,
            this.Reservar});
            this.grvDatos.DataSource = this.dataHabitacionBindingSource;
            this.grvDatos.Location = new System.Drawing.Point(12, 59);
            this.grvDatos.Name = "grvDatos";
            this.grvDatos.ReadOnly = true;
            this.grvDatos.Size = new System.Drawing.Size(927, 447);
            this.grvDatos.TabIndex = 0;
            this.grvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvDatos_CellContentClick);
            // 
            // idHabitaconDataGridViewTextBoxColumn
            // 
            this.idHabitaconDataGridViewTextBoxColumn.DataPropertyName = "IdHabitacon";
            this.idHabitaconDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idHabitaconDataGridViewTextBoxColumn.Name = "idHabitaconDataGridViewTextBoxColumn";
            this.idHabitaconDataGridViewTextBoxColumn.ReadOnly = true;
            this.idHabitaconDataGridViewTextBoxColumn.Width = 50;
            // 
            // habiNumDataGridViewTextBoxColumn
            // 
            this.habiNumDataGridViewTextBoxColumn.DataPropertyName = "HabiNum";
            this.habiNumDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.habiNumDataGridViewTextBoxColumn.Name = "habiNumDataGridViewTextBoxColumn";
            this.habiNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.habiNumDataGridViewTextBoxColumn.Width = 50;
            // 
            // habiPisoDataGridViewTextBoxColumn
            // 
            this.habiPisoDataGridViewTextBoxColumn.DataPropertyName = "HabiPiso";
            this.habiPisoDataGridViewTextBoxColumn.HeaderText = "Piso";
            this.habiPisoDataGridViewTextBoxColumn.Name = "habiPisoDataGridViewTextBoxColumn";
            this.habiPisoDataGridViewTextBoxColumn.ReadOnly = true;
            this.habiPisoDataGridViewTextBoxColumn.Width = 50;
            // 
            // idHotelDataGridViewTextBoxColumn
            // 
            this.idHotelDataGridViewTextBoxColumn.DataPropertyName = "IdHotel";
            this.idHotelDataGridViewTextBoxColumn.HeaderText = "Hotel";
            this.idHotelDataGridViewTextBoxColumn.Name = "idHotelDataGridViewTextBoxColumn";
            this.idHotelDataGridViewTextBoxColumn.ReadOnly = true;
            this.idHotelDataGridViewTextBoxColumn.Width = 50;
            // 
            // idTipoHabiDataGridViewTextBoxColumn
            // 
            this.idTipoHabiDataGridViewTextBoxColumn.DataPropertyName = "IdTipoHabi";
            this.idTipoHabiDataGridViewTextBoxColumn.HeaderText = "TIPO";
            this.idTipoHabiDataGridViewTextBoxColumn.Name = "idTipoHabiDataGridViewTextBoxColumn";
            this.idTipoHabiDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTipoHabiDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoNombreDataGridViewTextBoxColumn
            // 
            this.tipoNombreDataGridViewTextBoxColumn.DataPropertyName = "TipoNombre";
            this.tipoNombreDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoNombreDataGridViewTextBoxColumn.Name = "tipoNombreDataGridViewTextBoxColumn";
            this.tipoNombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoNombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // tipoDescripcionDataGridViewTextBoxColumn
            // 
            this.tipoDescripcionDataGridViewTextBoxColumn.DataPropertyName = "TipoDescripcion";
            this.tipoDescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.tipoDescripcionDataGridViewTextBoxColumn.Name = "tipoDescripcionDataGridViewTextBoxColumn";
            this.tipoDescripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDescripcionDataGridViewTextBoxColumn.Width = 250;
            // 
            // tipoNumCamasDataGridViewTextBoxColumn
            // 
            this.tipoNumCamasDataGridViewTextBoxColumn.DataPropertyName = "TipoNumCamas";
            this.tipoNumCamasDataGridViewTextBoxColumn.HeaderText = "N° Camas";
            this.tipoNumCamasDataGridViewTextBoxColumn.Name = "tipoNumCamasDataGridViewTextBoxColumn";
            this.tipoNumCamasDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoNumCamasDataGridViewTextBoxColumn.Width = 80;
            // 
            // tipoPrecioDataGridViewTextBoxColumn
            // 
            this.tipoPrecioDataGridViewTextBoxColumn.DataPropertyName = "TipoPrecio";
            this.tipoPrecioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.tipoPrecioDataGridViewTextBoxColumn.Name = "tipoPrecioDataGridViewTextBoxColumn";
            this.tipoPrecioDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoPrecioDataGridViewTextBoxColumn.Width = 50;
            // 
            // Reservar
            // 
            this.Reservar.HeaderText = "Opciones";
            this.Reservar.Name = "Reservar";
            this.Reservar.ReadOnly = true;
            this.Reservar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Reservar.Text = "Reservar";
            // 
            // dataHabitacionBindingSource
            // 
            this.dataHabitacionBindingSource.DataSource = typeof(Windows_Hotel.ProxyHabitaciones.dataHabitacion);
            // 
            // lblHabi1
            // 
            this.lblHabi1.AutoSize = true;
            this.lblHabi1.Location = new System.Drawing.Point(1038, 182);
            this.lblHabi1.Name = "lblHabi1";
            this.lblHabi1.Size = new System.Drawing.Size(13, 13);
            this.lblHabi1.TabIndex = 1;
            this.lblHabi1.Text = "0";
            this.lblHabi1.Visible = false;
            // 
            // lblPrecio1
            // 
            this.lblPrecio1.AutoSize = true;
            this.lblPrecio1.Location = new System.Drawing.Point(1168, 182);
            this.lblPrecio1.Name = "lblPrecio1";
            this.lblPrecio1.Size = new System.Drawing.Size(13, 13);
            this.lblPrecio1.TabIndex = 2;
            this.lblPrecio1.Text = "0";
            this.lblPrecio1.Visible = false;
            // 
            // lblHabi2
            // 
            this.lblHabi2.AutoSize = true;
            this.lblHabi2.Location = new System.Drawing.Point(1038, 150);
            this.lblHabi2.Name = "lblHabi2";
            this.lblHabi2.Size = new System.Drawing.Size(35, 13);
            this.lblHabi2.TabIndex = 3;
            this.lblHabi2.Text = "label3";
            this.lblHabi2.Visible = false;
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.AutoSize = true;
            this.lblPrecio2.Location = new System.Drawing.Point(1168, 150);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(13, 13);
            this.lblPrecio2.TabIndex = 4;
            this.lblPrecio2.Text = "0";
            this.lblPrecio2.Visible = false;
            // 
            // lblHabi3
            // 
            this.lblHabi3.AutoSize = true;
            this.lblHabi3.Location = new System.Drawing.Point(1038, 122);
            this.lblHabi3.Name = "lblHabi3";
            this.lblHabi3.Size = new System.Drawing.Size(24, 13);
            this.lblHabi3.TabIndex = 5;
            this.lblHabi3.Text = "asd";
            this.lblHabi3.Visible = false;
            // 
            // lblPrecio3
            // 
            this.lblPrecio3.AutoSize = true;
            this.lblPrecio3.Location = new System.Drawing.Point(1168, 122);
            this.lblPrecio3.Name = "lblPrecio3";
            this.lblPrecio3.Size = new System.Drawing.Size(13, 13);
            this.lblPrecio3.TabIndex = 6;
            this.lblPrecio3.Text = "0";
            this.lblPrecio3.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(993, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Detalles de Reserva";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1128, 282);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "0";
            this.lblTotal.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(1041, 341);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(140, 36);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar Reserva";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPrecio3);
            this.Controls.Add(this.lblHabi3);
            this.Controls.Add(this.lblPrecio2);
            this.Controls.Add(this.lblHabi2);
            this.Controls.Add(this.lblPrecio1);
            this.Controls.Add(this.lblHabi1);
            this.Controls.Add(this.grvDatos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHabitacionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvDatos;
        private System.Windows.Forms.BindingSource dataHabitacionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHabitaconDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn habiNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn habiPisoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoHabiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoNumCamasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPrecioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Reservar;
        private System.Windows.Forms.Label lblHabi1;
        private System.Windows.Forms.Label lblPrecio1;
        private System.Windows.Forms.Label lblHabi2;
        private System.Windows.Forms.Label lblPrecio2;
        private System.Windows.Forms.Label lblHabi3;
        private System.Windows.Forms.Label lblPrecio3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnConfirmar;
    }
}


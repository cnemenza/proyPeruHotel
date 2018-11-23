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
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupDetalle = new System.Windows.Forms.GroupBox();
            this.lblTot2 = new System.Windows.Forms.Label();
            this.lblTot1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHabitacionBindingSource)).BeginInit();
            this.groupDetalle.SuspendLayout();
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
            this.grvDatos.Location = new System.Drawing.Point(12, 91);
            this.grvDatos.Name = "grvDatos";
            this.grvDatos.ReadOnly = true;
            this.grvDatos.Size = new System.Drawing.Size(927, 489);
            this.grvDatos.TabIndex = 0;
            this.grvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvDatos_CellContentClick);
            // 
            // idHabitaconDataGridViewTextBoxColumn
            // 
            this.idHabitaconDataGridViewTextBoxColumn.DataPropertyName = "IdHabitacon";
            this.idHabitaconDataGridViewTextBoxColumn.FillWeight = 120F;
            this.idHabitaconDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idHabitaconDataGridViewTextBoxColumn.Name = "idHabitaconDataGridViewTextBoxColumn";
            this.idHabitaconDataGridViewTextBoxColumn.ReadOnly = true;
            this.idHabitaconDataGridViewTextBoxColumn.Width = 50;
            // 
            // habiNumDataGridViewTextBoxColumn
            // 
            this.habiNumDataGridViewTextBoxColumn.DataPropertyName = "HabiNum";
            this.habiNumDataGridViewTextBoxColumn.FillWeight = 120F;
            this.habiNumDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.habiNumDataGridViewTextBoxColumn.Name = "habiNumDataGridViewTextBoxColumn";
            this.habiNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.habiNumDataGridViewTextBoxColumn.Width = 50;
            // 
            // habiPisoDataGridViewTextBoxColumn
            // 
            this.habiPisoDataGridViewTextBoxColumn.DataPropertyName = "HabiPiso";
            this.habiPisoDataGridViewTextBoxColumn.FillWeight = 120F;
            this.habiPisoDataGridViewTextBoxColumn.HeaderText = "Piso";
            this.habiPisoDataGridViewTextBoxColumn.Name = "habiPisoDataGridViewTextBoxColumn";
            this.habiPisoDataGridViewTextBoxColumn.ReadOnly = true;
            this.habiPisoDataGridViewTextBoxColumn.Width = 50;
            // 
            // idHotelDataGridViewTextBoxColumn
            // 
            this.idHotelDataGridViewTextBoxColumn.DataPropertyName = "IdHotel";
            this.idHotelDataGridViewTextBoxColumn.FillWeight = 120F;
            this.idHotelDataGridViewTextBoxColumn.HeaderText = "Hotel";
            this.idHotelDataGridViewTextBoxColumn.Name = "idHotelDataGridViewTextBoxColumn";
            this.idHotelDataGridViewTextBoxColumn.ReadOnly = true;
            this.idHotelDataGridViewTextBoxColumn.Width = 50;
            // 
            // idTipoHabiDataGridViewTextBoxColumn
            // 
            this.idTipoHabiDataGridViewTextBoxColumn.DataPropertyName = "IdTipoHabi";
            this.idTipoHabiDataGridViewTextBoxColumn.FillWeight = 120F;
            this.idTipoHabiDataGridViewTextBoxColumn.HeaderText = "TIPO";
            this.idTipoHabiDataGridViewTextBoxColumn.Name = "idTipoHabiDataGridViewTextBoxColumn";
            this.idTipoHabiDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTipoHabiDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoNombreDataGridViewTextBoxColumn
            // 
            this.tipoNombreDataGridViewTextBoxColumn.DataPropertyName = "TipoNombre";
            this.tipoNombreDataGridViewTextBoxColumn.FillWeight = 120F;
            this.tipoNombreDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoNombreDataGridViewTextBoxColumn.Name = "tipoNombreDataGridViewTextBoxColumn";
            this.tipoNombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoNombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // tipoDescripcionDataGridViewTextBoxColumn
            // 
            this.tipoDescripcionDataGridViewTextBoxColumn.DataPropertyName = "TipoDescripcion";
            this.tipoDescripcionDataGridViewTextBoxColumn.FillWeight = 120F;
            this.tipoDescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.tipoDescripcionDataGridViewTextBoxColumn.Name = "tipoDescripcionDataGridViewTextBoxColumn";
            this.tipoDescripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDescripcionDataGridViewTextBoxColumn.Width = 250;
            // 
            // tipoNumCamasDataGridViewTextBoxColumn
            // 
            this.tipoNumCamasDataGridViewTextBoxColumn.DataPropertyName = "TipoNumCamas";
            this.tipoNumCamasDataGridViewTextBoxColumn.FillWeight = 120F;
            this.tipoNumCamasDataGridViewTextBoxColumn.HeaderText = "N° Camas";
            this.tipoNumCamasDataGridViewTextBoxColumn.Name = "tipoNumCamasDataGridViewTextBoxColumn";
            this.tipoNumCamasDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoNumCamasDataGridViewTextBoxColumn.Width = 80;
            // 
            // tipoPrecioDataGridViewTextBoxColumn
            // 
            this.tipoPrecioDataGridViewTextBoxColumn.DataPropertyName = "TipoPrecio";
            this.tipoPrecioDataGridViewTextBoxColumn.FillWeight = 120F;
            this.tipoPrecioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.tipoPrecioDataGridViewTextBoxColumn.Name = "tipoPrecioDataGridViewTextBoxColumn";
            this.tipoPrecioDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoPrecioDataGridViewTextBoxColumn.Width = 50;
            // 
            // Reservar
            // 
            this.Reservar.FillWeight = 120F;
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
            this.lblHabi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabi1.Location = new System.Drawing.Point(66, 112);
            this.lblHabi1.Name = "lblHabi1";
            this.lblHabi1.Size = new System.Drawing.Size(39, 20);
            this.lblHabi1.TabIndex = 1;
            this.lblHabi1.Text = "habi";
            this.lblHabi1.Visible = false;
            // 
            // lblPrecio1
            // 
            this.lblPrecio1.AutoSize = true;
            this.lblPrecio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio1.Location = new System.Drawing.Point(196, 112);
            this.lblPrecio1.Name = "lblPrecio1";
            this.lblPrecio1.Size = new System.Drawing.Size(18, 20);
            this.lblPrecio1.TabIndex = 2;
            this.lblPrecio1.Text = "0";
            this.lblPrecio1.Visible = false;
            // 
            // lblHabi2
            // 
            this.lblHabi2.AutoSize = true;
            this.lblHabi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabi2.Location = new System.Drawing.Point(66, 80);
            this.lblHabi2.Name = "lblHabi2";
            this.lblHabi2.Size = new System.Drawing.Size(39, 20);
            this.lblHabi2.TabIndex = 3;
            this.lblHabi2.Text = "habi";
            this.lblHabi2.Visible = false;
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.AutoSize = true;
            this.lblPrecio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio2.Location = new System.Drawing.Point(196, 80);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(18, 20);
            this.lblPrecio2.TabIndex = 4;
            this.lblPrecio2.Text = "0";
            this.lblPrecio2.Visible = false;
            // 
            // lblHabi3
            // 
            this.lblHabi3.AutoSize = true;
            this.lblHabi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabi3.Location = new System.Drawing.Point(66, 52);
            this.lblHabi3.Name = "lblHabi3";
            this.lblHabi3.Size = new System.Drawing.Size(39, 20);
            this.lblHabi3.TabIndex = 5;
            this.lblHabi3.Text = "habi";
            this.lblHabi3.Visible = false;
            // 
            // lblPrecio3
            // 
            this.lblPrecio3.AutoSize = true;
            this.lblPrecio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio3.Location = new System.Drawing.Point(196, 52);
            this.lblPrecio3.Name = "lblPrecio3";
            this.lblPrecio3.Size = new System.Drawing.Size(18, 20);
            this.lblPrecio3.TabIndex = 6;
            this.lblPrecio3.Text = "0";
            this.lblPrecio3.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblTotal.Location = new System.Drawing.Point(195, 154);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(24, 25);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "0";
            this.lblTotal.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Seleccionar Habitaciones";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(122, 205);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(140, 36);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar Reserva";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // groupDetalle
            // 
            this.groupDetalle.Controls.Add(this.lblTot2);
            this.groupDetalle.Controls.Add(this.lblTot1);
            this.groupDetalle.Controls.Add(this.btnConfirmar);
            this.groupDetalle.Controls.Add(this.lblTotal);
            this.groupDetalle.Controls.Add(this.label7);
            this.groupDetalle.Controls.Add(this.lblHabi1);
            this.groupDetalle.Controls.Add(this.lblPrecio1);
            this.groupDetalle.Controls.Add(this.lblPrecio3);
            this.groupDetalle.Controls.Add(this.lblHabi2);
            this.groupDetalle.Controls.Add(this.lblHabi3);
            this.groupDetalle.Controls.Add(this.lblPrecio2);
            this.groupDetalle.Location = new System.Drawing.Point(973, 91);
            this.groupDetalle.Name = "groupDetalle";
            this.groupDetalle.Size = new System.Drawing.Size(385, 271);
            this.groupDetalle.TabIndex = 11;
            this.groupDetalle.TabStop = false;
            this.groupDetalle.Visible = false;
            this.groupDetalle.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblTot2
            // 
            this.lblTot2.AutoSize = true;
            this.lblTot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTot2.ForeColor = System.Drawing.Color.Blue;
            this.lblTot2.Location = new System.Drawing.Point(143, 154);
            this.lblTot2.Name = "lblTot2";
            this.lblTot2.Size = new System.Drawing.Size(40, 25);
            this.lblTot2.TabIndex = 11;
            this.lblTot2.Text = "S/.";
            this.lblTot2.Visible = false;
            // 
            // lblTot1
            // 
            this.lblTot1.AutoSize = true;
            this.lblTot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTot1.Location = new System.Drawing.Point(66, 159);
            this.lblTot1.Name = "lblTot1";
            this.lblTot1.Size = new System.Drawing.Size(59, 20);
            this.lblTot1.TabIndex = 10;
            this.lblTot1.Text = "Total :";
            this.lblTot1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Detalles de Reserva";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.groupDetalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvDatos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHabitacionBindingSource)).EndInit();
            this.groupDetalle.ResumeLayout(false);
            this.groupDetalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvDatos;
        private System.Windows.Forms.BindingSource dataHabitacionBindingSource;
        private System.Windows.Forms.Label lblHabi1;
        private System.Windows.Forms.Label lblPrecio1;
        private System.Windows.Forms.Label lblHabi2;
        private System.Windows.Forms.Label lblPrecio2;
        private System.Windows.Forms.Label lblHabi3;
        private System.Windows.Forms.Label lblPrecio3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewButtonColumn Reservar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHabitaconDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn habiNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn habiPisoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoHabiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoNumCamasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPrecioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox groupDetalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTot2;
        private System.Windows.Forms.Label lblTot1;
    }
}


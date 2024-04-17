namespace Presentation
{
    partial class panelTop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DvgDatos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.txtCelular = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtClienteId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtApellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Celular = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSexo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Controles = new System.Windows.Forms.GroupBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.BTNuevo = new Guna.UI2.WinForms.Guna2Button();
            this.btnNuevo = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DvgDatos)).BeginInit();
            this.Controles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Presentation.Properties.Resources.close_window_30px;
            this.btnClose.Location = new System.Drawing.Point(997, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.btnMin);
            this.guna2Panel1.Controls.Add(this.btnMax);
            this.guna2Panel1.Controls.Add(this.btnClose);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1039, 58);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = global::Presentation.Properties.Resources.maximize_window_30px;
            this.btnMax.Location = new System.Drawing.Point(961, 12);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(30, 30);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMax.TabIndex = 2;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = global::Presentation.Properties.Resources.minimize_window_30px;
            this.btnMin.Location = new System.Drawing.Point(925, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMin.TabIndex = 3;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // DvgDatos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DvgDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DvgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DvgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DvgDatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DvgDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DvgDatos.Location = new System.Drawing.Point(52, 372);
            this.DvgDatos.Name = "DvgDatos";
            this.DvgDatos.RowHeadersVisible = false;
            this.DvgDatos.Size = new System.Drawing.Size(825, 136);
            this.DvgDatos.TabIndex = 1;
            this.DvgDatos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DvgDatos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DvgDatos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DvgDatos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DvgDatos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DvgDatos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DvgDatos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DvgDatos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DvgDatos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DvgDatos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DvgDatos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DvgDatos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgDatos.ThemeStyle.HeaderStyle.Height = 15;
            this.DvgDatos.ThemeStyle.ReadOnly = false;
            this.DvgDatos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DvgDatos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DvgDatos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DvgDatos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DvgDatos.ThemeStyle.RowsStyle.Height = 22;
            this.DvgDatos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DvgDatos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderRadius = 13;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "Nombre";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Location = new System.Drawing.Point(52, 108);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(200, 36);
            this.txtNombre.TabIndex = 2;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(60, 92);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 3;
            this.Nombre.Text = "Nombre";
            this.Nombre.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.BorderRadius = 13;
            this.txtCelular.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCelular.DefaultText = "Nombre";
            this.txtCelular.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCelular.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCelular.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCelular.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCelular.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCelular.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCelular.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCelular.Location = new System.Drawing.Point(370, 191);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.PasswordChar = '\0';
            this.txtCelular.PlaceholderText = "Nombre";
            this.txtCelular.SelectedText = "";
            this.txtCelular.Size = new System.Drawing.Size(200, 36);
            this.txtCelular.TabIndex = 4;
            // 
            // txtClienteId
            // 
            this.txtClienteId.BorderRadius = 13;
            this.txtClienteId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClienteId.DefaultText = "ClienteId";
            this.txtClienteId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClienteId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClienteId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtClienteId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteId.Location = new System.Drawing.Point(370, 108);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.PasswordChar = '\0';
            this.txtClienteId.PlaceholderText = "ClienteId";
            this.txtClienteId.SelectedText = "";
            this.txtClienteId.Size = new System.Drawing.Size(200, 36);
            this.txtClienteId.TabIndex = 5;
            this.txtClienteId.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.BorderRadius = 13;
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.DefaultText = "Apellido";
            this.txtApellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellido.Location = new System.Drawing.Point(52, 191);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.PlaceholderText = "Apellido";
            this.txtApellido.SelectedText = "";
            this.txtApellido.Size = new System.Drawing.Size(200, 36);
            this.txtApellido.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ClienteId";
            // 
            // Celular
            // 
            this.Celular.AutoSize = true;
            this.Celular.Location = new System.Drawing.Point(367, 175);
            this.Celular.Name = "Celular";
            this.Celular.Size = new System.Drawing.Size(39, 13);
            this.Celular.TabIndex = 9;
            this.Celular.Text = "Celular";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(291, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(434, 32);
            this.label7.TabIndex = 39;
            this.label7.Text = "Registro De Ventas De Boleteria";
            // 
            // cbSexo
            // 
            this.cbSexo.BackColor = System.Drawing.Color.Transparent;
            this.cbSexo.BorderRadius = 13;
            this.cbSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSexo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSexo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSexo.ItemHeight = 30;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otros"});
            this.cbSexo.Location = new System.Drawing.Point(737, 108);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(140, 36);
            this.cbSexo.TabIndex = 10;
            this.cbSexo.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(734, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(386, 32);
            this.label4.TabIndex = 40;
            this.label4.Text = "listado de ventas de Boletos";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Controles
            // 
            this.Controles.Controls.Add(this.btnEliminar);
            this.Controles.Controls.Add(this.btnNuevo);
            this.Controles.Controls.Add(this.BTNuevo);
            this.Controles.Location = new System.Drawing.Point(737, 175);
            this.Controles.Name = "Controles";
            this.Controles.Size = new System.Drawing.Size(254, 167);
            this.Controles.TabIndex = 41;
            this.Controles.TabStop = false;
            this.Controles.Text = "Controles";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // BTNuevo
            // 
            this.BTNuevo.BorderRadius = 13;
            this.BTNuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNuevo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNuevo.ForeColor = System.Drawing.Color.White;
            this.BTNuevo.Location = new System.Drawing.Point(83, 16);
            this.BTNuevo.Name = "BTNuevo";
            this.BTNuevo.Size = new System.Drawing.Size(108, 33);
            this.BTNuevo.TabIndex = 0;
            this.BTNuevo.Text = "GUARDAR";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BorderRadius = 13;
            this.btnNuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(83, 119);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(108, 33);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "NUEVO";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BorderRadius = 13;
            this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(83, 68);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 33);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // panelTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1039, 568);
            this.Controls.Add(this.Controles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.Celular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtClienteId);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.DvgDatos);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "panelTop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.panelTop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DvgDatos)).EndInit();
            this.Controles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClose;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnMax;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2DataGridView DvgDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtApellido;
        private Guna.UI2.WinForms.Guna2TextBox txtClienteId;
        private Guna.UI2.WinForms.Guna2TextBox txtCelular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbSexo;
        private System.Windows.Forms.Label Celular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Controles;
        private Guna.UI2.WinForms.Guna2Button BTNuevo;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnNuevo;
    }
}


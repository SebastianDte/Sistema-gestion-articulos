namespace Vista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlArticulos = new System.Windows.Forms.Panel();
            this.cardDgv = new MaterialSkin.Controls.MaterialCard();
            this.pnlAgregarArticulo = new System.Windows.Forms.Panel();
            this.pnlImagen = new System.Windows.Forms.Panel();
            this.btnAtras = new MaterialSkin.Controls.MaterialButton();
            this.lblImagenes = new MaterialSkin.Controls.MaterialLabel();
            this.btnSiguiente = new MaterialSkin.Controls.MaterialButton();
            this.pctBoxListImg = new System.Windows.Forms.PictureBox();
            this.pnlDGV = new System.Windows.Forms.Panel();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnVerMas = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pxbAgregar = new System.Windows.Forms.PictureBox();
            this.picBoxLimpiar = new System.Windows.Forms.PictureBox();
            this.txtBoxFiltroAvanzado = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblErrorCriterio = new MaterialSkin.Controls.MaterialLabel();
            this.lblErrorCampo = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscar = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.ckBoxFiltroAvanzado = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.cboCriterio = new MaterialSkin.Controls.MaterialComboBox();
            this.cboCampo = new MaterialSkin.Controls.MaterialComboBox();
            this.pnlSeparadorDgvFooter = new System.Windows.Forms.Panel();
            this.cardVerMas = new MaterialSkin.Controls.MaterialCard();
            this.pnlCodigo = new System.Windows.Forms.Panel();
            this.lblCodigoVerMas = new MaterialSkin.Controls.MaterialLabel();
            this.lblCodigoArticulo = new MaterialSkin.Controls.MaterialLabel();
            this.pnlDescripcionVerMas = new System.Windows.Forms.Panel();
            this.lblDescripcionVerMas = new MaterialSkin.Controls.MaterialLabel();
            this.txtBoxDescripcion = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            this.cardFooter = new MaterialSkin.Controls.MaterialCard();
            this.lblHora = new MaterialSkin.Controls.MaterialLabel();
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.webBrowserInfo = new System.Windows.Forms.WebBrowser();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlArticulos.SuspendLayout();
            this.cardDgv.SuspendLayout();
            this.pnlImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxListImg)).BeginInit();
            this.pnlDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxbAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLimpiar)).BeginInit();
            this.cardVerMas.SuspendLayout();
            this.pnlCodigo.SuspendLayout();
            this.pnlDescripcionVerMas.SuspendLayout();
            this.cardFooter.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.Padding = new System.Drawing.Point(6, 6);
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1297, 534);
            this.materialTabControl1.TabIndex = 2;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlArticulos);
            this.tabPage1.ImageKey = "Articulos.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 45);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1289, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Artículos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlArticulos
            // 
            this.pnlArticulos.Controls.Add(this.cardDgv);
            this.pnlArticulos.Controls.Add(this.pnlHeader);
            this.pnlArticulos.Controls.Add(this.pnlSeparadorDgvFooter);
            this.pnlArticulos.Controls.Add(this.cardVerMas);
            this.pnlArticulos.Controls.Add(this.cardFooter);
            this.pnlArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlArticulos.Location = new System.Drawing.Point(3, 3);
            this.pnlArticulos.Name = "pnlArticulos";
            this.pnlArticulos.Size = new System.Drawing.Size(1283, 479);
            this.pnlArticulos.TabIndex = 0;
            // 
            // cardDgv
            // 
            this.cardDgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardDgv.Controls.Add(this.pnlAgregarArticulo);
            this.cardDgv.Controls.Add(this.pnlImagen);
            this.cardDgv.Controls.Add(this.pnlDGV);
            this.cardDgv.Depth = 0;
            this.cardDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardDgv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardDgv.Location = new System.Drawing.Point(0, 76);
            this.cardDgv.Margin = new System.Windows.Forms.Padding(14);
            this.cardDgv.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardDgv.Name = "cardDgv";
            this.cardDgv.Padding = new System.Windows.Forms.Padding(14);
            this.cardDgv.Size = new System.Drawing.Size(1283, 248);
            this.cardDgv.TabIndex = 17;
            // 
            // pnlAgregarArticulo
            // 
            this.pnlAgregarArticulo.BackColor = System.Drawing.Color.DimGray;
            this.pnlAgregarArticulo.Location = new System.Drawing.Point(711, 103);
            this.pnlAgregarArticulo.Name = "pnlAgregarArticulo";
            this.pnlAgregarArticulo.Size = new System.Drawing.Size(38, 31);
            this.pnlAgregarArticulo.TabIndex = 9;
            this.pnlAgregarArticulo.Visible = false;
            // 
            // pnlImagen
            // 
            this.pnlImagen.Controls.Add(this.btnAtras);
            this.pnlImagen.Controls.Add(this.lblImagenes);
            this.pnlImagen.Controls.Add(this.btnSiguiente);
            this.pnlImagen.Controls.Add(this.pctBoxListImg);
            this.pnlImagen.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlImagen.Location = new System.Drawing.Point(750, 14);
            this.pnlImagen.Name = "pnlImagen";
            this.pnlImagen.Size = new System.Drawing.Size(519, 220);
            this.pnlImagen.TabIndex = 8;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAtras.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAtras.Depth = 0;
            this.btnAtras.HighEmphasis = true;
            this.btnAtras.Icon = null;
            this.btnAtras.Location = new System.Drawing.Point(4, 177);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAtras.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAtras.Size = new System.Drawing.Size(67, 36);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAtras.UseAccentColor = false;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblImagenes
            // 
            this.lblImagenes.AutoSize = true;
            this.lblImagenes.BackColor = System.Drawing.Color.Transparent;
            this.lblImagenes.Depth = 0;
            this.lblImagenes.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblImagenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblImagenes.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblImagenes.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.lblImagenes.Location = new System.Drawing.Point(420, 0);
            this.lblImagenes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImagenes.Name = "lblImagenes";
            this.lblImagenes.Size = new System.Drawing.Size(99, 17);
            this.lblImagenes.TabIndex = 2;
            this.lblImagenes.Text = "materialLabel2";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSiguiente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSiguiente.Depth = 0;
            this.btnSiguiente.HighEmphasis = true;
            this.btnSiguiente.Icon = null;
            this.btnSiguiente.Location = new System.Drawing.Point(420, 177);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSiguiente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSiguiente.Size = new System.Drawing.Size(95, 36);
            this.btnSiguiente.TabIndex = 6;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSiguiente.UseAccentColor = false;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // pctBoxListImg
            // 
            this.pctBoxListImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctBoxListImg.Location = new System.Drawing.Point(0, 0);
            this.pctBoxListImg.Name = "pctBoxListImg";
            this.pctBoxListImg.Size = new System.Drawing.Size(519, 220);
            this.pctBoxListImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxListImg.TabIndex = 1;
            this.pctBoxListImg.TabStop = false;
            // 
            // pnlDGV
            // 
            this.pnlDGV.Controls.Add(this.dgvArticulos);
            this.pnlDGV.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDGV.Location = new System.Drawing.Point(14, 14);
            this.pnlDGV.Name = "pnlDGV";
            this.pnlDGV.Size = new System.Drawing.Size(640, 220);
            this.pnlDGV.TabIndex = 7;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEditar,
            this.btnEliminar,
            this.btnVerMas});
            this.dgvArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulos.Location = new System.Drawing.Point(0, 0);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.RowHeadersWidth = 62;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(640, 220);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellClick);
            this.dgvArticulos.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellMouseEnter);
            this.dgvArticulos.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellMouseLeave);
            this.dgvArticulos.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dgvArticulos_CellToolTipTextNeeded);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.DefaultCellStyle = dataGridViewCellStyle1;
            this.btnEditar.FillWeight = 118.7817F;
            this.btnEditar.HeaderText = "";
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.MinimumWidth = 40;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnEditar.ToolTipText = "Modificar";
            this.btnEditar.Width = 40;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.btnEliminar.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.MinimumWidth = 40;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnEliminar.ToolTipText = "Eliminar";
            this.btnEliminar.Width = 40;
            // 
            // btnVerMas
            // 
            this.btnVerMas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.btnVerMas.DefaultCellStyle = dataGridViewCellStyle3;
            this.btnVerMas.FillWeight = 81.21828F;
            this.btnVerMas.HeaderText = "";
            this.btnVerMas.Image = ((System.Drawing.Image)(resources.GetObject("btnVerMas.Image")));
            this.btnVerMas.MinimumWidth = 40;
            this.btnVerMas.Name = "btnVerMas";
            this.btnVerMas.ReadOnly = true;
            this.btnVerMas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnVerMas.ToolTipText = "Ver más detalles";
            this.btnVerMas.Width = 40;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.pxbAgregar);
            this.pnlHeader.Controls.Add(this.picBoxLimpiar);
            this.pnlHeader.Controls.Add(this.txtBoxFiltroAvanzado);
            this.pnlHeader.Controls.Add(this.lblErrorCriterio);
            this.pnlHeader.Controls.Add(this.lblErrorCampo);
            this.pnlHeader.Controls.Add(this.txtBuscar);
            this.pnlHeader.Controls.Add(this.materialDivider1);
            this.pnlHeader.Controls.Add(this.ckBoxFiltroAvanzado);
            this.pnlHeader.Controls.Add(this.btnBuscar);
            this.pnlHeader.Controls.Add(this.cboCriterio);
            this.pnlHeader.Controls.Add(this.cboCampo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1283, 76);
            this.pnlHeader.TabIndex = 13;
            // 
            // pxbAgregar
            // 
            this.pxbAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pxbAgregar.BackColor = System.Drawing.Color.Transparent;
            this.pxbAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pxbAgregar.Image = ((System.Drawing.Image)(resources.GetObject("pxbAgregar.Image")));
            this.pxbAgregar.Location = new System.Drawing.Point(619, 30);
            this.pxbAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.pxbAgregar.Name = "pxbAgregar";
            this.pxbAgregar.Size = new System.Drawing.Size(35, 35);
            this.pxbAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pxbAgregar.TabIndex = 14;
            this.pxbAgregar.TabStop = false;
            this.toolTip1.SetToolTip(this.pxbAgregar, "Agregar Artículo");
            this.pxbAgregar.Click += new System.EventHandler(this.pxbAgregar_Click);
            // 
            // picBoxLimpiar
            // 
            this.picBoxLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picBoxLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLimpiar.Image")));
            this.picBoxLimpiar.Location = new System.Drawing.Point(570, 30);
            this.picBoxLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxLimpiar.Name = "picBoxLimpiar";
            this.picBoxLimpiar.Size = new System.Drawing.Size(35, 35);
            this.picBoxLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxLimpiar.TabIndex = 9;
            this.picBoxLimpiar.TabStop = false;
            this.toolTip1.SetToolTip(this.picBoxLimpiar, "Limpiar filtros");
            this.picBoxLimpiar.Visible = false;
            this.picBoxLimpiar.Click += new System.EventHandler(this.pictureBox1_Click);
            this.picBoxLimpiar.MouseEnter += new System.EventHandler(this.picBoxLimpiar_MouseEnter);
            this.picBoxLimpiar.MouseLeave += new System.EventHandler(this.picBoxLimpiar_MouseLeave);
            // 
            // txtBoxFiltroAvanzado
            // 
            this.txtBoxFiltroAvanzado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxFiltroAvanzado.AnimateReadOnly = false;
            this.txtBoxFiltroAvanzado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBoxFiltroAvanzado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxFiltroAvanzado.Depth = 0;
            this.txtBoxFiltroAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxFiltroAvanzado.HideSelection = true;
            this.txtBoxFiltroAvanzado.Hint = "Filtro avanzado";
            this.txtBoxFiltroAvanzado.LeadingIcon = null;
            this.txtBoxFiltroAvanzado.Location = new System.Drawing.Point(14, 22);
            this.txtBoxFiltroAvanzado.MaxLength = 32767;
            this.txtBoxFiltroAvanzado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxFiltroAvanzado.Name = "txtBoxFiltroAvanzado";
            this.txtBoxFiltroAvanzado.PasswordChar = '\0';
            this.txtBoxFiltroAvanzado.PrefixSuffixText = null;
            this.txtBoxFiltroAvanzado.ReadOnly = false;
            this.txtBoxFiltroAvanzado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxFiltroAvanzado.SelectedText = "";
            this.txtBoxFiltroAvanzado.SelectionLength = 0;
            this.txtBoxFiltroAvanzado.SelectionStart = 0;
            this.txtBoxFiltroAvanzado.ShortcutsEnabled = true;
            this.txtBoxFiltroAvanzado.Size = new System.Drawing.Size(551, 48);
            this.txtBoxFiltroAvanzado.TabIndex = 10;
            this.txtBoxFiltroAvanzado.TabStop = false;
            this.txtBoxFiltroAvanzado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxFiltroAvanzado.TrailingIcon = null;
            this.txtBoxFiltroAvanzado.UseSystemPasswordChar = false;
            this.txtBoxFiltroAvanzado.Visible = false;
            this.txtBoxFiltroAvanzado.TextChanged += new System.EventHandler(this.txtBoxFiltroAvanzado_TextChanged);
            // 
            // lblErrorCriterio
            // 
            this.lblErrorCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorCriterio.AutoSize = true;
            this.lblErrorCriterio.Depth = 0;
            this.lblErrorCriterio.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblErrorCriterio.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblErrorCriterio.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCriterio.Location = new System.Drawing.Point(1037, 5);
            this.lblErrorCriterio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblErrorCriterio.Name = "lblErrorCriterio";
            this.lblErrorCriterio.Size = new System.Drawing.Size(82, 14);
            this.lblErrorCriterio.TabIndex = 12;
            this.lblErrorCriterio.Text = "materialLabel1";
            this.lblErrorCriterio.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblErrorCriterio.Visible = false;
            // 
            // lblErrorCampo
            // 
            this.lblErrorCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorCampo.AutoSize = true;
            this.lblErrorCampo.Depth = 0;
            this.lblErrorCampo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblErrorCampo.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblErrorCampo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCampo.Location = new System.Drawing.Point(878, 5);
            this.lblErrorCampo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblErrorCampo.Name = "lblErrorCampo";
            this.lblErrorCampo.Size = new System.Drawing.Size(80, 14);
            this.lblErrorCampo.TabIndex = 11;
            this.lblErrorCampo.Text = "lblErrorCampo";
            this.lblErrorCampo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblErrorCampo.Visible = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBuscar.AnimateReadOnly = false;
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar.HideSelection = true;
            this.txtBuscar.Hint = "Buscar por nombre de artículo";
            this.txtBuscar.LeadingIcon = null;
            this.txtBuscar.Location = new System.Drawing.Point(14, 23);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PrefixSuffixText = null;
            this.txtBuscar.ReadOnly = false;
            this.txtBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.ShortcutsEnabled = true;
            this.txtBuscar.Size = new System.Drawing.Size(551, 48);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.TrailingIcon = null;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(738, 0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(26, 65);
            this.materialDivider1.TabIndex = 6;
            this.materialDivider1.Text = "materialDivider1";
            this.materialDivider1.Visible = false;
            // 
            // ckBoxFiltroAvanzado
            // 
            this.ckBoxFiltroAvanzado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ckBoxFiltroAvanzado.AutoSize = true;
            this.ckBoxFiltroAvanzado.Depth = 0;
            this.ckBoxFiltroAvanzado.Location = new System.Drawing.Point(776, 28);
            this.ckBoxFiltroAvanzado.Margin = new System.Windows.Forms.Padding(0);
            this.ckBoxFiltroAvanzado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckBoxFiltroAvanzado.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckBoxFiltroAvanzado.Name = "ckBoxFiltroAvanzado";
            this.ckBoxFiltroAvanzado.ReadOnly = false;
            this.ckBoxFiltroAvanzado.Ripple = true;
            this.ckBoxFiltroAvanzado.Size = new System.Drawing.Size(76, 37);
            this.ckBoxFiltroAvanzado.TabIndex = 5;
            this.ckBoxFiltroAvanzado.Text = "Filtrar";
            this.toolTip1.SetToolTip(this.ckBoxFiltroAvanzado, "Activar filtro avanzado");
            this.ckBoxFiltroAvanzado.UseVisualStyleBackColor = true;
            this.ckBoxFiltroAvanzado.CheckedChanged += new System.EventHandler(this.ckBoxFiltroAvanzado_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Enabled = false;
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(1191, 29);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscar.Size = new System.Drawing.Size(77, 36);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboCriterio
            // 
            this.cboCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCriterio.AutoResize = false;
            this.cboCriterio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboCriterio.Depth = 0;
            this.cboCriterio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboCriterio.DropDownHeight = 174;
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.DropDownWidth = 121;
            this.cboCriterio.Enabled = false;
            this.cboCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboCriterio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.IntegralHeight = false;
            this.cboCriterio.ItemHeight = 43;
            this.cboCriterio.Location = new System.Drawing.Point(1031, 22);
            this.cboCriterio.MaxDropDownItems = 4;
            this.cboCriterio.MouseState = MaterialSkin.MouseState.OUT;
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(154, 49);
            this.cboCriterio.StartIndex = 0;
            this.cboCriterio.TabIndex = 4;
            // 
            // cboCampo
            // 
            this.cboCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCampo.AutoResize = false;
            this.cboCampo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboCampo.Depth = 0;
            this.cboCampo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboCampo.DropDownHeight = 174;
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.DropDownWidth = 121;
            this.cboCampo.Enabled = false;
            this.cboCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboCampo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.IntegralHeight = false;
            this.cboCampo.ItemHeight = 43;
            this.cboCampo.Location = new System.Drawing.Point(870, 22);
            this.cboCampo.MaxDropDownItems = 4;
            this.cboCampo.MouseState = MaterialSkin.MouseState.OUT;
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(154, 49);
            this.cboCampo.StartIndex = 0;
            this.cboCampo.TabIndex = 3;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // pnlSeparadorDgvFooter
            // 
            this.pnlSeparadorDgvFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSeparadorDgvFooter.Location = new System.Drawing.Point(0, 324);
            this.pnlSeparadorDgvFooter.Name = "pnlSeparadorDgvFooter";
            this.pnlSeparadorDgvFooter.Size = new System.Drawing.Size(1283, 10);
            this.pnlSeparadorDgvFooter.TabIndex = 16;
            // 
            // cardVerMas
            // 
            this.cardVerMas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardVerMas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardVerMas.Controls.Add(this.pnlCodigo);
            this.cardVerMas.Controls.Add(this.pnlDescripcionVerMas);
            this.cardVerMas.Controls.Add(this.btnVolver);
            this.cardVerMas.Depth = 0;
            this.cardVerMas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cardVerMas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardVerMas.Location = new System.Drawing.Point(0, 334);
            this.cardVerMas.Margin = new System.Windows.Forms.Padding(14);
            this.cardVerMas.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardVerMas.Name = "cardVerMas";
            this.cardVerMas.Padding = new System.Windows.Forms.Padding(14);
            this.cardVerMas.Size = new System.Drawing.Size(1283, 85);
            this.cardVerMas.TabIndex = 14;
            this.cardVerMas.Visible = false;
            // 
            // pnlCodigo
            // 
            this.pnlCodigo.Controls.Add(this.lblCodigoVerMas);
            this.pnlCodigo.Controls.Add(this.lblCodigoArticulo);
            this.pnlCodigo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCodigo.Location = new System.Drawing.Point(991, 14);
            this.pnlCodigo.Name = "pnlCodigo";
            this.pnlCodigo.Size = new System.Drawing.Size(200, 55);
            this.pnlCodigo.TabIndex = 7;
            // 
            // lblCodigoVerMas
            // 
            this.lblCodigoVerMas.AutoSize = true;
            this.lblCodigoVerMas.Depth = 0;
            this.lblCodigoVerMas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCodigoVerMas.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCodigoVerMas.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblCodigoVerMas.Location = new System.Drawing.Point(0, 0);
            this.lblCodigoVerMas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodigoVerMas.Name = "lblCodigoVerMas";
            this.lblCodigoVerMas.Size = new System.Drawing.Size(84, 29);
            this.lblCodigoVerMas.TabIndex = 1;
            this.lblCodigoVerMas.Text = "Código:";
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.AutoSize = true;
            this.lblCodigoArticulo.Depth = 0;
            this.lblCodigoArticulo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCodigoArticulo.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCodigoArticulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblCodigoArticulo.Location = new System.Drawing.Point(0, 31);
            this.lblCodigoArticulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(63, 24);
            this.lblCodigoArticulo.TabIndex = 2;
            this.lblCodigoArticulo.Text = "Código";
            // 
            // pnlDescripcionVerMas
            // 
            this.pnlDescripcionVerMas.Controls.Add(this.lblDescripcionVerMas);
            this.pnlDescripcionVerMas.Controls.Add(this.txtBoxDescripcion);
            this.pnlDescripcionVerMas.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDescripcionVerMas.Location = new System.Drawing.Point(14, 14);
            this.pnlDescripcionVerMas.Name = "pnlDescripcionVerMas";
            this.pnlDescripcionVerMas.Size = new System.Drawing.Size(655, 55);
            this.pnlDescripcionVerMas.TabIndex = 6;
            // 
            // lblDescripcionVerMas
            // 
            this.lblDescripcionVerMas.AutoSize = true;
            this.lblDescripcionVerMas.Depth = 0;
            this.lblDescripcionVerMas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescripcionVerMas.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblDescripcionVerMas.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblDescripcionVerMas.Location = new System.Drawing.Point(0, 0);
            this.lblDescripcionVerMas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcionVerMas.Name = "lblDescripcionVerMas";
            this.lblDescripcionVerMas.Size = new System.Drawing.Size(128, 29);
            this.lblDescripcionVerMas.TabIndex = 3;
            this.lblDescripcionVerMas.Text = "Descripción";
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBoxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDescripcion.Depth = 0;
            this.txtBoxDescripcion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBoxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBoxDescripcion.Location = new System.Drawing.Point(0, 30);
            this.txtBoxDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(655, 25);
            this.txtBoxDescripcion.TabIndex = 4;
            this.txtBoxDescripcion.Text = "";
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVolver.Depth = 0;
            this.btnVolver.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVolver.HighEmphasis = true;
            this.btnVolver.Icon = null;
            this.btnVolver.Location = new System.Drawing.Point(1191, 14);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVolver.Size = new System.Drawing.Size(76, 55);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVolver.UseAccentColor = false;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // cardFooter
            // 
            this.cardFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardFooter.Controls.Add(this.lblHora);
            this.cardFooter.Controls.Add(this.lblUsuario);
            this.cardFooter.Depth = 0;
            this.cardFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cardFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardFooter.Location = new System.Drawing.Point(0, 419);
            this.cardFooter.Margin = new System.Windows.Forms.Padding(14);
            this.cardFooter.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardFooter.Name = "cardFooter";
            this.cardFooter.Padding = new System.Windows.Forms.Padding(14);
            this.cardFooter.Size = new System.Drawing.Size(1283, 60);
            this.cardFooter.TabIndex = 15;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Depth = 0;
            this.lblHora.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHora.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblHora.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblHora.Location = new System.Drawing.Point(1109, 14);
            this.lblHora.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.lblHora.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(160, 29);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "materialLabel2";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Depth = 0;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsuario.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblUsuario.Location = new System.Drawing.Point(14, 14);
            this.lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(218, 29);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Bievenido Sebastián";
            // 
            // tabPage2
            // 
            this.tabPage2.ImageKey = "marcas.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 45);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1289, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Marcas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.ImageKey = "categoria.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 45);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1289, 485);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Categorias";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.webBrowser1);
            this.tabPage4.ImageKey = "ayuda.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 45);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1289, 485);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ayuda";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1289, 485);
            this.webBrowser1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.webBrowserInfo);
            this.tabPage5.ImageKey = "about.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 45);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1289, 485);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Información";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // webBrowserInfo
            // 
            this.webBrowserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserInfo.Location = new System.Drawing.Point(0, 0);
            this.webBrowserInfo.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserInfo.Name = "webBrowserInfo";
            this.webBrowserInfo.Size = new System.Drawing.Size(1289, 485);
            this.webBrowserInfo.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "about.png");
            this.imageList1.Images.SetKeyName(1, "ayuda.png");
            this.imageList1.Images.SetKeyName(2, "marcas.png");
            this.imageList1.Images.SetKeyName(3, "categoria.png");
            this.imageList1.Images.SetKeyName(4, "Articulos.png");
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 598);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 0, 0);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlArticulos.ResumeLayout(false);
            this.cardDgv.ResumeLayout(false);
            this.pnlImagen.ResumeLayout(false);
            this.pnlImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxListImg)).EndInit();
            this.pnlDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxbAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLimpiar)).EndInit();
            this.cardVerMas.ResumeLayout(false);
            this.cardVerMas.PerformLayout();
            this.pnlCodigo.ResumeLayout(false);
            this.pnlCodigo.PerformLayout();
            this.pnlDescripcionVerMas.ResumeLayout(false);
            this.pnlDescripcionVerMas.PerformLayout();
            this.cardFooter.ResumeLayout(false);
            this.cardFooter.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Panel pnlArticulos;
        private MaterialSkin.Controls.MaterialCard cardDgv;
        private System.Windows.Forms.Panel pnlAgregarArticulo;
        private System.Windows.Forms.Panel pnlImagen;
        private MaterialSkin.Controls.MaterialButton btnAtras;
        private MaterialSkin.Controls.MaterialLabel lblImagenes;
        private MaterialSkin.Controls.MaterialButton btnSiguiente;
        private System.Windows.Forms.PictureBox pctBoxListImg;
        private System.Windows.Forms.Panel pnlDGV;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Panel pnlHeader;
        private MaterialSkin.Controls.MaterialLabel lblErrorCriterio;
        private MaterialSkin.Controls.MaterialLabel lblErrorCampo;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxFiltroAvanzado;
        private MaterialSkin.Controls.MaterialTextBox2 txtBuscar;
        private System.Windows.Forms.PictureBox picBoxLimpiar;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialCheckbox ckBoxFiltroAvanzado;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private MaterialSkin.Controls.MaterialComboBox cboCriterio;
        private MaterialSkin.Controls.MaterialComboBox cboCampo;
        private System.Windows.Forms.Panel pnlSeparadorDgvFooter;
        private MaterialSkin.Controls.MaterialCard cardVerMas;
        private System.Windows.Forms.Panel pnlCodigo;
        private MaterialSkin.Controls.MaterialLabel lblCodigoVerMas;
        private MaterialSkin.Controls.MaterialLabel lblCodigoArticulo;
        private System.Windows.Forms.Panel pnlDescripcionVerMas;
        private MaterialSkin.Controls.MaterialLabel lblDescripcionVerMas;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtBoxDescripcion;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private MaterialSkin.Controls.MaterialCard cardFooter;
        private MaterialSkin.Controls.MaterialLabel lblHora;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private System.Windows.Forms.PictureBox pxbAgregar;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnEliminar;
        private System.Windows.Forms.DataGridViewImageColumn btnVerMas;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.WebBrowser webBrowserInfo;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}


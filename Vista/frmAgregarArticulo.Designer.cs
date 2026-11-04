namespace Vista
{
    partial class frmAgregarArticulo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarArticulo));
            this.pnlBase = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBaseIzquierdo = new System.Windows.Forms.Panel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblPrecio = new MaterialSkin.Controls.MaterialLabel();
            this.txtPrecio = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.cboCategoria = new MaterialSkin.Controls.MaterialComboBox();
            this.cboMarca = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblMarca = new MaterialSkin.Controls.MaterialLabel();
            this.lblCodigo = new MaterialSkin.Controls.MaterialLabel();
            this.pnlBaseDrecho = new System.Windows.Forms.Panel();
            this.pnlPixtureBox = new System.Windows.Forms.Panel();
            this.btnSiguiente = new System.Windows.Forms.PictureBox();
            this.lblIndice = new MaterialSkin.Controls.MaterialLabel();
            this.btnAtras = new System.Windows.Forms.PictureBox();
            this.pxbImagen = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarImagen = new System.Windows.Forms.PictureBox();
            this.btnAgregarImagen = new System.Windows.Forms.PictureBox();
            this.txtUrlImagen = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnImagenLocal = new System.Windows.Forms.PictureBox();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnAceptar = new MaterialSkin.Controls.MaterialButton();
            this.toolTipAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBase.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlBaseIzquierdo.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.pnlBaseDrecho.SuspendLayout();
            this.pnlPixtureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbImagen)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImagenLocal)).BeginInit();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.tableLayoutPanel1);
            this.pnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBase.Location = new System.Drawing.Point(3, 0);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(1047, 571);
            this.pnlBase.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.87392F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.12608F));
            this.tableLayoutPanel1.Controls.Add(this.pnlBaseIzquierdo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlBaseDrecho, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 441F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 441F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 441F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 441F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 441F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1047, 571);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pnlBaseIzquierdo
            // 
            this.pnlBaseIzquierdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBaseIzquierdo.Controls.Add(this.materialCard1);
            this.pnlBaseIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBaseIzquierdo.Location = new System.Drawing.Point(3, 3);
            this.pnlBaseIzquierdo.Name = "pnlBaseIzquierdo";
            this.pnlBaseIzquierdo.Size = new System.Drawing.Size(578, 565);
            this.pnlBaseIzquierdo.TabIndex = 0;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtDescripcion);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.txtNombre);
            this.materialCard1.Controls.Add(this.lblPrecio);
            this.materialCard1.Controls.Add(this.txtPrecio);
            this.materialCard1.Controls.Add(this.lblCategoria);
            this.materialCard1.Controls.Add(this.lblNombre);
            this.materialCard1.Controls.Add(this.cboCategoria);
            this.materialCard1.Controls.Add(this.cboMarca);
            this.materialCard1.Controls.Add(this.txtCodigo);
            this.materialCard1.Controls.Add(this.lblMarca);
            this.materialCard1.Controls.Add(this.lblCodigo);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(576, 563);
            this.materialCard1.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AnimateReadOnly = false;
            this.txtDescripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.Depth = 0;
            this.txtDescripcion.HideSelection = true;
            this.txtDescripcion.Location = new System.Drawing.Point(66, 345);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.ReadOnly = false;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.ShortcutsEnabled = true;
            this.txtDescripcion.Size = new System.Drawing.Size(412, 102);
            this.txtDescripcion.TabIndex = 139;
            this.txtDescripcion.TabStop = false;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescripcion.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(71, 323);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(84, 19);
            this.materialLabel1.TabIndex = 140;
            this.materialLabel1.Text = "Descripción";
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.HideSelection = true;
            this.txtNombre.Hint = "Nombre del artículo";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(66, 55);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PrefixSuffixText = null;
            this.txtNombre.ReadOnly = false;
            this.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(412, 48);
            this.txtNombre.TabIndex = 134;
            this.txtNombre.TabStop = false;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.UseSystemPasswordChar = false;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Depth = 0;
            this.lblPrecio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrecio.Location = new System.Drawing.Point(71, 124);
            this.lblPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(45, 19);
            this.lblPrecio.TabIndex = 133;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.AnimateReadOnly = false;
            this.txtPrecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrecio.Depth = 0;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecio.HideSelection = true;
            this.txtPrecio.Hint = "Solo números";
            this.txtPrecio.LeadingIcon = null;
            this.txtPrecio.Location = new System.Drawing.Point(71, 146);
            this.txtPrecio.MaxLength = 32767;
            this.txtPrecio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.PrefixSuffixText = null;
            this.txtPrecio.ReadOnly = false;
            this.txtPrecio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.ShortcutsEnabled = true;
            this.txtPrecio.Size = new System.Drawing.Size(205, 48);
            this.txtPrecio.TabIndex = 135;
            this.txtPrecio.TabStop = false;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecio.TrailingIcon = null;
            this.txtPrecio.UseSystemPasswordChar = false;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Depth = 0;
            this.lblCategoria.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCategoria.Location = new System.Drawing.Point(71, 222);
            this.lblCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 19);
            this.lblCategoria.TabIndex = 130;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Depth = 0;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombre.Location = new System.Drawing.Point(71, 33);
            this.lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 19);
            this.lblNombre.TabIndex = 129;
            this.lblNombre.Text = "Nombre";
            // 
            // cboCategoria
            // 
            this.cboCategoria.AutoResize = false;
            this.cboCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboCategoria.Depth = 0;
            this.cboCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboCategoria.DropDownHeight = 174;
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.DropDownWidth = 121;
            this.cboCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.IntegralHeight = false;
            this.cboCategoria.ItemHeight = 43;
            this.cboCategoria.Location = new System.Drawing.Point(66, 244);
            this.cboCategoria.MaxDropDownItems = 4;
            this.cboCategoria.MouseState = MaterialSkin.MouseState.OUT;
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(210, 49);
            this.cboCategoria.StartIndex = 0;
            this.cboCategoria.TabIndex = 137;
            // 
            // cboMarca
            // 
            this.cboMarca.AutoResize = false;
            this.cboMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboMarca.Depth = 0;
            this.cboMarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboMarca.DropDownHeight = 174;
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.DropDownWidth = 121;
            this.cboMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.IntegralHeight = false;
            this.cboMarca.ItemHeight = 43;
            this.cboMarca.Location = new System.Drawing.Point(311, 244);
            this.cboMarca.MaxDropDownItems = 4;
            this.cboMarca.MouseState = MaterialSkin.MouseState.OUT;
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(167, 49);
            this.cboMarca.StartIndex = 0;
            this.cboMarca.TabIndex = 138;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AnimateReadOnly = false;
            this.txtCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.HideSelection = true;
            this.txtCodigo.LeadingIcon = null;
            this.txtCodigo.Location = new System.Drawing.Point(311, 146);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.PrefixSuffixText = null;
            this.txtCodigo.ReadOnly = false;
            this.txtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.ShortcutsEnabled = true;
            this.txtCodigo.Size = new System.Drawing.Size(167, 48);
            this.txtCodigo.TabIndex = 136;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigo.TrailingIcon = null;
            this.txtCodigo.UseSystemPasswordChar = false;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Depth = 0;
            this.lblMarca.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMarca.Location = new System.Drawing.Point(313, 222);
            this.lblMarca.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(46, 19);
            this.lblMarca.TabIndex = 131;
            this.lblMarca.Text = "Marca";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Depth = 0;
            this.lblCodigo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCodigo.Location = new System.Drawing.Point(308, 124);
            this.lblCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 19);
            this.lblCodigo.TabIndex = 132;
            this.lblCodigo.Text = "Código";
            // 
            // pnlBaseDrecho
            // 
            this.pnlBaseDrecho.Controls.Add(this.pnlPixtureBox);
            this.pnlBaseDrecho.Controls.Add(this.panel1);
            this.pnlBaseDrecho.Controls.Add(this.pnlBotones);
            this.pnlBaseDrecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBaseDrecho.Location = new System.Drawing.Point(588, 3);
            this.pnlBaseDrecho.Name = "pnlBaseDrecho";
            this.pnlBaseDrecho.Size = new System.Drawing.Size(456, 565);
            this.pnlBaseDrecho.TabIndex = 1;
            // 
            // pnlPixtureBox
            // 
            this.pnlPixtureBox.Controls.Add(this.btnSiguiente);
            this.pnlPixtureBox.Controls.Add(this.lblIndice);
            this.pnlPixtureBox.Controls.Add(this.btnAtras);
            this.pnlPixtureBox.Controls.Add(this.pxbImagen);
            this.pnlPixtureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPixtureBox.Location = new System.Drawing.Point(0, 53);
            this.pnlPixtureBox.Name = "pnlPixtureBox";
            this.pnlPixtureBox.Size = new System.Drawing.Size(456, 428);
            this.pnlPixtureBox.TabIndex = 138;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Location = new System.Drawing.Point(421, 209);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(32, 32);
            this.btnSiguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSiguiente.TabIndex = 141;
            this.btnSiguiente.TabStop = false;
            this.toolTipAgregar.SetToolTip(this.btnSiguiente, "Siguiente");
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblIndice
            // 
            this.lblIndice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIndice.AutoSize = true;
            this.lblIndice.Depth = 0;
            this.lblIndice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIndice.Location = new System.Drawing.Point(376, 0);
            this.lblIndice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(1, 0);
            this.lblIndice.TabIndex = 135;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.Location = new System.Drawing.Point(3, 209);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(32, 32);
            this.btnAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAtras.TabIndex = 136;
            this.btnAtras.TabStop = false;
            this.toolTipAgregar.SetToolTip(this.btnAtras, "Atras");
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pxbImagen
            // 
            this.pxbImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pxbImagen.Location = new System.Drawing.Point(0, 0);
            this.pxbImagen.Name = "pxbImagen";
            this.pxbImagen.Size = new System.Drawing.Size(456, 428);
            this.pxbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxbImagen.TabIndex = 140;
            this.pxbImagen.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEliminarImagen);
            this.panel1.Controls.Add(this.btnAgregarImagen);
            this.panel1.Controls.Add(this.txtUrlImagen);
            this.panel1.Controls.Add(this.btnImagenLocal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 53);
            this.panel1.TabIndex = 140;
            // 
            // btnEliminarImagen
            // 
            this.btnEliminarImagen.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarImagen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEliminarImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarImagen.Image")));
            this.btnEliminarImagen.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarImagen.InitialImage")));
            this.btnEliminarImagen.Location = new System.Drawing.Point(354, 0);
            this.btnEliminarImagen.Name = "btnEliminarImagen";
            this.btnEliminarImagen.Size = new System.Drawing.Size(35, 53);
            this.btnEliminarImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnEliminarImagen.TabIndex = 139;
            this.btnEliminarImagen.TabStop = false;
            this.toolTipAgregar.SetToolTip(this.btnEliminarImagen, "Quitar Imagen");
            this.btnEliminarImagen.Click += new System.EventHandler(this.btnEliminarImagen_Click);
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarImagen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAgregarImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarImagen.Image")));
            this.btnAgregarImagen.InitialImage = null;
            this.btnAgregarImagen.Location = new System.Drawing.Point(389, 0);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(35, 53);
            this.btnAgregarImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAgregarImagen.TabIndex = 138;
            this.btnAgregarImagen.TabStop = false;
            this.toolTipAgregar.SetToolTip(this.btnAgregarImagen, "Agregar Imagen");
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.AnimateReadOnly = false;
            this.txtUrlImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUrlImagen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUrlImagen.Depth = 0;
            this.txtUrlImagen.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtUrlImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUrlImagen.HideSelection = true;
            this.txtUrlImagen.Hint = "Ingrese la URl de la Imagen";
            this.txtUrlImagen.LeadingIcon = null;
            this.txtUrlImagen.Location = new System.Drawing.Point(0, 0);
            this.txtUrlImagen.MaxLength = 32767;
            this.txtUrlImagen.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.PasswordChar = '\0';
            this.txtUrlImagen.PrefixSuffixText = null;
            this.txtUrlImagen.ReadOnly = false;
            this.txtUrlImagen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUrlImagen.SelectedText = "";
            this.txtUrlImagen.SelectionLength = 0;
            this.txtUrlImagen.SelectionStart = 0;
            this.txtUrlImagen.ShortcutsEnabled = true;
            this.txtUrlImagen.Size = new System.Drawing.Size(348, 48);
            this.txtUrlImagen.TabIndex = 128;
            this.txtUrlImagen.TabStop = false;
            this.txtUrlImagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUrlImagen.TrailingIcon = null;
            this.txtUrlImagen.UseSystemPasswordChar = false;
            this.txtUrlImagen.TextChanged += new System.EventHandler(this.txtUrlImagen_TextChanged);
            // 
            // btnImagenLocal
            // 
            this.btnImagenLocal.BackColor = System.Drawing.Color.Transparent;
            this.btnImagenLocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImagenLocal.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImagenLocal.Image = ((System.Drawing.Image)(resources.GetObject("btnImagenLocal.Image")));
            this.btnImagenLocal.InitialImage = null;
            this.btnImagenLocal.Location = new System.Drawing.Point(424, 0);
            this.btnImagenLocal.Name = "btnImagenLocal";
            this.btnImagenLocal.Size = new System.Drawing.Size(32, 53);
            this.btnImagenLocal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnImagenLocal.TabIndex = 140;
            this.btnImagenLocal.TabStop = false;
            this.toolTipAgregar.SetToolTip(this.btnImagenLocal, "Subir Img Local");
            this.btnImagenLocal.Click += new System.EventHandler(this.btnImagenLocal_Click);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnAceptar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 481);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(456, 84);
            this.pnlBotones.TabIndex = 139;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(111, 9);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 140;
            this.btnCancelar.Text = "Cancelar";
            this.toolTipAgregar.SetToolTip(this.btnCancelar, "Cancelar cambios");
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.HighEmphasis = true;
            this.btnAceptar.Icon = null;
            this.btnAceptar.Location = new System.Drawing.Point(251, 9);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAceptar.Size = new System.Drawing.Size(86, 36);
            this.btnAceptar.TabIndex = 139;
            this.btnAceptar.Text = "Aceptar";
            this.toolTipAgregar.SetToolTip(this.btnAceptar, "Confirmar Cambios");
            this.btnAceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAceptar.UseAccentColor = false;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 574);
            this.Controls.Add(this.pnlBase);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "frmAgregarArticulo";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "frmAgregarArticulo";
            this.pnlBase.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlBaseIzquierdo.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.pnlBaseDrecho.ResumeLayout(false);
            this.pnlPixtureBox.ResumeLayout(false);
            this.pnlPixtureBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbImagen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImagenLocal)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.pnlBotones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlBaseDrecho;
        private MaterialSkin.Controls.MaterialTextBox2 txtUrlImagen;
        private System.Windows.Forms.Panel pnlBaseIzquierdo;
        private System.Windows.Forms.PictureBox btnAgregarImagen;
        private MaterialSkin.Controls.MaterialLabel lblIndice;
        private System.Windows.Forms.Panel pnlPixtureBox;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.PictureBox pxbImagen;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnAceptar;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDescripcion;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombre;
        private MaterialSkin.Controls.MaterialLabel lblPrecio;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrecio;
        private MaterialSkin.Controls.MaterialLabel lblCategoria;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialComboBox cboCategoria;
        private MaterialSkin.Controls.MaterialComboBox cboMarca;
        private MaterialSkin.Controls.MaterialTextBox2 txtCodigo;
        private MaterialSkin.Controls.MaterialLabel lblMarca;
        private MaterialSkin.Controls.MaterialLabel lblCodigo;
        private System.Windows.Forms.PictureBox btnSiguiente;
        private System.Windows.Forms.PictureBox btnAtras;
        private System.Windows.Forms.PictureBox btnEliminarImagen;
        private System.Windows.Forms.ToolTip toolTipAgregar;
        private System.Windows.Forms.PictureBox btnImagenLocal;
    }
}
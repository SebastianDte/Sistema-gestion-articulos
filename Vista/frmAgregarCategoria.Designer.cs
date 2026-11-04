namespace Vista
{
    partial class frmAgregarCategoria
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
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnAceptar = new MaterialSkin.Controls.MaterialButton();
            this.lbDescripcionNuevaMarca = new MaterialSkin.Controls.MaterialLabel();
            this.txtbDescripcion = new MaterialSkin.Controls.MaterialTextBox2();
            this.SuspendLayout();
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
            this.btnCancelar.Location = new System.Drawing.Point(268, 171);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.HighEmphasis = true;
            this.btnAceptar.Icon = null;
            this.btnAceptar.Location = new System.Drawing.Point(99, 171);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAceptar.Size = new System.Drawing.Size(86, 36);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAceptar.UseAccentColor = false;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // lbDescripcionNuevaMarca
            // 
            this.lbDescripcionNuevaMarca.AutoSize = true;
            this.lbDescripcionNuevaMarca.Depth = 0;
            this.lbDescripcionNuevaMarca.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbDescripcionNuevaMarca.Location = new System.Drawing.Point(33, 114);
            this.lbDescripcionNuevaMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDescripcionNuevaMarca.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbDescripcionNuevaMarca.Name = "lbDescripcionNuevaMarca";
            this.lbDescripcionNuevaMarca.Size = new System.Drawing.Size(57, 19);
            this.lbDescripcionNuevaMarca.TabIndex = 15;
            this.lbDescripcionNuevaMarca.Text = "Nombre";
            // 
            // txtbDescripcion
            // 
            this.txtbDescripcion.AnimateReadOnly = false;
            this.txtbDescripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtbDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbDescripcion.Depth = 0;
            this.txtbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtbDescripcion.HideSelection = true;
            this.txtbDescripcion.LeadingIcon = null;
            this.txtbDescripcion.Location = new System.Drawing.Point(99, 103);
            this.txtbDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtbDescripcion.MaxLength = 32767;
            this.txtbDescripcion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtbDescripcion.Name = "txtbDescripcion";
            this.txtbDescripcion.PasswordChar = '\0';
            this.txtbDescripcion.PrefixSuffixText = null;
            this.txtbDescripcion.ReadOnly = false;
            this.txtbDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbDescripcion.SelectedText = "";
            this.txtbDescripcion.SelectionLength = 0;
            this.txtbDescripcion.SelectionStart = 0;
            this.txtbDescripcion.ShortcutsEnabled = true;
            this.txtbDescripcion.Size = new System.Drawing.Size(262, 48);
            this.txtbDescripcion.TabIndex = 14;
            this.txtbDescripcion.TabStop = false;
            this.txtbDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbDescripcion.TrailingIcon = null;
            this.txtbDescripcion.UseSystemPasswordChar = false;
            // 
            // frmAgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 240);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lbDescripcionNuevaMarca);
            this.Controls.Add(this.txtbDescripcion);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(449, 240);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(449, 240);
            this.Name = "frmAgregarCategoria";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Categoria";
            this.Load += new System.EventHandler(this.frmAgregarCategoria_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnAceptar;
        private MaterialSkin.Controls.MaterialLabel lbDescripcionNuevaMarca;
        private MaterialSkin.Controls.MaterialTextBox2 txtbDescripcion;
    }
}
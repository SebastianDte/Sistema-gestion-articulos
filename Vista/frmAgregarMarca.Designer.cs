namespace Vista
{
    partial class frmAgregarMarca
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
            this.txtbDescripcion = new MaterialSkin.Controls.MaterialTextBox2();
            this.lbDescripcionNuevaMarca = new MaterialSkin.Controls.MaterialLabel();
            this.btnAceptarNuevaMarca = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
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
            this.txtbDescripcion.Location = new System.Drawing.Point(91, 103);
            this.txtbDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.txtbDescripcion.TabIndex = 10;
            this.txtbDescripcion.TabStop = false;
            this.txtbDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbDescripcion.TrailingIcon = null;
            this.txtbDescripcion.UseSystemPasswordChar = false;
            // 
            // lbDescripcionNuevaMarca
            // 
            this.lbDescripcionNuevaMarca.AutoSize = true;
            this.lbDescripcionNuevaMarca.Depth = 0;
            this.lbDescripcionNuevaMarca.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbDescripcionNuevaMarca.Location = new System.Drawing.Point(25, 114);
            this.lbDescripcionNuevaMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDescripcionNuevaMarca.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbDescripcionNuevaMarca.Name = "lbDescripcionNuevaMarca";
            this.lbDescripcionNuevaMarca.Size = new System.Drawing.Size(57, 19);
            this.lbDescripcionNuevaMarca.TabIndex = 11;
            this.lbDescripcionNuevaMarca.Text = "Nombre";
            // 
            // btnAceptarNuevaMarca
            // 
            this.btnAceptarNuevaMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptarNuevaMarca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptarNuevaMarca.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptarNuevaMarca.Depth = 0;
            this.btnAceptarNuevaMarca.HighEmphasis = true;
            this.btnAceptarNuevaMarca.Icon = null;
            this.btnAceptarNuevaMarca.Location = new System.Drawing.Point(91, 171);
            this.btnAceptarNuevaMarca.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAceptarNuevaMarca.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptarNuevaMarca.Name = "btnAceptarNuevaMarca";
            this.btnAceptarNuevaMarca.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAceptarNuevaMarca.Size = new System.Drawing.Size(86, 36);
            this.btnAceptarNuevaMarca.TabIndex = 12;
            this.btnAceptarNuevaMarca.Text = "Aceptar";
            this.btnAceptarNuevaMarca.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAceptarNuevaMarca.UseAccentColor = false;
            this.btnAceptarNuevaMarca.UseVisualStyleBackColor = true;
            this.btnAceptarNuevaMarca.Click += new System.EventHandler(this.btnAgregarNuevaMarca_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(260, 171);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(449, 240);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptarNuevaMarca);
            this.Controls.Add(this.lbDescripcionNuevaMarca);
            this.Controls.Add(this.txtbDescripcion);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(449, 491);
            this.MinimumSize = new System.Drawing.Size(449, 240);
            this.Name = "frmAgregarMarca";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarMarcas";
            this.Load += new System.EventHandler(this.frmAgregarMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 txtbDescripcion;
        private MaterialSkin.Controls.MaterialLabel lbDescripcionNuevaMarca;
        private MaterialSkin.Controls.MaterialButton btnAceptarNuevaMarca;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
    }
}
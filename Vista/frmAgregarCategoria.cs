using Dominio;
using MaterialSkin;
using MaterialSkin.Controls;
using Negocio;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmAgregarCategoria : MaterialForm
    {
        private Categoria categoria = null;

        public frmAgregarCategoria()
        {
            InitializeComponent();
            Text = "Nueva Categoría";
            ConfiguracionMaterialSkin();
        }

        public frmAgregarCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar Categoría";
            ConfiguracionMaterialSkin();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            bool error = false;
            CategoriaNegocio negocio = new CategoriaNegocio();

            if (!InputHelper.Validar(txtbDescripcion, minLength: 4, maxLength: 30))
                error = true;

            if (error) return;

            try
            {
                if (categoria == null)
                {
                    categoria = new Categoria();
                }

                categoria.descripcion = txtbDescripcion.Text.Trim();

                if (categoria.id != 0)
                {
                    negocio.modificar(categoria);
                    MessageBox.Show("Categoría modificada exitosamente.");
                }
                else
                {
                    if (string.IsNullOrEmpty(categoria.descripcion))
                    {
                        MessageBox.Show("Debe ingresar el nombre de una categoría.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    negocio.agregar(categoria);
                    MessageBox.Show("Categoría agregada exitosamente.");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void ConfiguracionMaterialSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue700,
                TextShade.WHITE
            );
        }

        private void frmAgregarCategoria_Load_1(object sender, EventArgs e)
        {
            try
            {
                if (categoria != null)
                {
                    txtbDescripcion.Text = categoria.descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

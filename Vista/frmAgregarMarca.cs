using Dominio;
using MaterialSkin;
using MaterialSkin.Controls;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmAgregarMarca : MaterialForm
    {
        private Marca marca = null;

        public frmAgregarMarca()
        {
            InitializeComponent();
            Text = "Nueva Marca";
            configuracionMaterialSkin();
        }

        public frmAgregarMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca";
            configuracionMaterialSkin();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarNuevaMarca_Click(object sender, EventArgs e)
        {
            bool error = false;

            MarcaNegocio negocio = new MarcaNegocio();
            if (!InputHelper.Validar(txtbDescripcion, minLength: 4, maxLength: 30))
                error = true;
            if (error) return;

            try
            {
                if ( marca == null)
                {
                    marca = new Marca();
                }

                marca.descripcion = txtbDescripcion.Text;

                if (marca.id != 0)
                {
                    negocio.modificar(marca);
                    MessageBox.Show("Marca modifiacada exitosamente.");
                }
                else
                {
                    
                    if( string.IsNullOrEmpty(marca.descripcion))
                    {
                        MessageBox.Show("Debe ingresar el nombre de una marca.","Atención",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }

                    negocio.agregar(marca);
                    MessageBox.Show("Marca agregada exitosamente.");
                }

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void frmAgregarMarca_Load(object sender, EventArgs e)
        {
            try
            {
                if ( marca != null)
                {
                    txtbDescripcion.Text = marca.descripcion; 
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void configuracionMaterialSkin()
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


    }


}

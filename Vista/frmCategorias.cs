using Dominio;
using MaterialSkin;
using MaterialSkin.Controls;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmCategorias : MaterialForm
    {
        private List<Categoria> ListaCategoria;
        public frmCategorias()
        {
            InitializeComponent();
            ConfigurarMaterialSkin();
        }
        private void ConfigurarMaterialSkin()
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

        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                ListaCategoria = negocio.listar();
                dgvCategoria.DataSource = ListaCategoria;
                dgvCategoria.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarSeleccion()
        {
            if (dgvCategoria.CurrentRow == null)
            {
                MessageBox.Show("Por favor seleccione una categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria ventanaAgregar = new frmAgregarCategoria();
            ventanaAgregar.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarSeleccion()) return;

                Categoria seleccionada = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                frmAgregarCategoria modificar = new frmAgregarCategoria(seleccionada);
                modificar.ShowDialog();
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (validarSeleccion()) return;

            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionada = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;

            ArticuloNegocio negocioArticulo = new ArticuloNegocio();
            List<Articulo> listaArticulos = negocioArticulo.lista();

            try
            {
                foreach (Articulo item in listaArticulos)
                {
                    if ( item.categoria.id == seleccionada.id )
                    {
                        MessageBox.Show("La categoría seleccionada no se puede eliminar porque tiene artículos relacionados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar definitivamente esta categoría?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    negocio.eliminar(seleccionada.id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtFiltro.Text.Trim();
                List<Categoria> listaFiltrada;

                if (filtro.Length >= 2)
                    listaFiltrada = ListaCategoria.FindAll(x => x.descripcion.ToLower().Contains(filtro.ToLower()));
                else
                    listaFiltrada = ListaCategoria;

                dgvCategoria.DataSource = null;
                dgvCategoria.DataSource = listaFiltrada;
                dgvCategoria.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmCategorias_Load_1(object sender, EventArgs e)
        {
            cargar();
        }
    }
}

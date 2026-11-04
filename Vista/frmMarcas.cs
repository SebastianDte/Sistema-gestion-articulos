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
    public partial class frmMarcas : MaterialForm
    {
        
        private List<Marca> ListaMarca;
        public frmMarcas()
        {
            InitializeComponent();

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarMarca ventanaAgregar = new frmAgregarMarca();
            
            ventanaAgregar.ShowDialog();
            cargar();
            
        }

        private void cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                ListaMarca = negocio.listar();
                dgvMarcas.DataSource = ListaMarca;
                dgvMarcas.Columns["Id"].Visible = false;
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());         
            }
        }

        private bool validarSeleccion()
        {
            if (dgvMarcas.CurrentRow == null )
            {
                MessageBox.Show("Por favor seleccione una marca.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            Marca seleccionada;

            try
            {
                if (validarSeleccion()){
                    return;
                }

                seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                frmAgregarMarca modificar = new frmAgregarMarca(seleccionada);
                modificar.ShowDialog();
                cargar();

            }
            catch (Exception ex)
            {

                MessageBox.Show( ex.ToString());
            }



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (validarSeleccion())
            {
                return;
            }

            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionada;
            seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            ArticuloNegocio negocioArticulo = new ArticuloNegocio();
            List<Articulo> listaArticulos; 
            listaArticulos= negocioArticulo.lista();

            try
            {


                foreach (Articulo item in listaArticulos)
                {
                    if (item.marca.id == seleccionada.id)
                    {
                        MessageBox.Show("La marca seleccionada no se pudo eliminar debido a que tiene registros de articulos relacionados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                DialogResult respuesta = MessageBox.Show("¿Esta seguro de eliminar definitivamente esta marca?","Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if( respuesta == DialogResult.Yes)
                {
                    seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
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
            List<Marca> listaFiltrada;
            string filtro = txtFiltro.Text;

            try
            {
                if (filtro.Length >= 2)
                {
                    listaFiltrada = ListaMarca.FindAll(x => x.descripcion.ToLower().Contains(filtro.ToLower()));
                }
                else
                {
                    listaFiltrada = ListaMarca;
                }

                dgvMarcas.DataSource = null;
                dgvMarcas.DataSource = listaFiltrada;
                dgvMarcas.Columns["Id"].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); ;
            }


        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            cargar();
        }


    }
}

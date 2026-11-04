using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class Loguin : MaterialForm
    {
        public string NombreUsuario { get; private set; }
        public Loguin()
        {
            InitializeComponent();
            ConfigurarMaterialSkin();

            this.AcceptButton = btnAceptarLoguin;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
           
            bool valido = InputHelper.Validar(
                txtNombre,
                minLength: 4,
                maxLength: 20  
            );

            if (!valido)
            {
                txtNombre.Hint = "Ingrese un nombre válido (4 a 20 caracteres)";
                return;
            }
            
            NombreUsuario = txtNombre.Text.Trim();
            this.DialogResult = DialogResult.OK;

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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            InputHelper.QuitarErrorAlEscribir(txtNombre);
        }
    }
}

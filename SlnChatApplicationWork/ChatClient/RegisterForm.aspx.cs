using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Windows.Forms;

public partial class RegisterForm : System.Web.UI.Page
{
    LoginService.LoginServiceSoapClient servicio = new LoginService.LoginServiceSoapClient();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        string aPaterno = txtApaterno.Text;
        string aMaterno = txtApaterno.Text;
        string nombre = txtNombre.Text;
        string userName = txtUsuario.Text;
        string contrasena = txtContrasena.Text;

        string mensaje = servicio.AddUser(aPaterno,aMaterno,nombre,userName,contrasena);
        MessageBox.Show(mensaje);
    }
}
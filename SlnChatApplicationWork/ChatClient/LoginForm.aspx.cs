using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Windows.Forms;

public partial class LoginForm : System.Web.UI.Page
{
    LoginService.LoginServiceSoapClient servicio = new LoginService.LoginServiceSoapClient();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        string userName = txtUserName.Text;
        string contrasena = txtContrasena.Text;

        string mensaje = servicio.LoginUser(userName, contrasena);

        MessageBox.Show(mensaje);
    }
}
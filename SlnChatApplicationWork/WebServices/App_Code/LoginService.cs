using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using CapaLogica;

/// <summary>
/// Descripción breve de LoginService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class LoginService : System.Web.Services.WebService {

    public LoginService () {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    Usuario usuario = new Usuario();
    Empleado empleado = new Empleado();

    [WebMethod]
    public string LoginUser(string userName,string contrasena) {
        usuario.userName = userName;
        usuario.contrasena = contrasena;

        usuario.validarUsuario();
        return usuario.Mensaje;
    }

    [WebMethod]
    public string AddUser(string apaterno, string amaterno, string nombre, string username, string contrasena)
    {
        usuario.empleado.aPaterno = apaterno;
        usuario.empleado.aMaterno = amaterno;
        usuario.empleado.Nombres = nombre;
        usuario.userName = username;
        usuario.contrasena = contrasena;

        usuario.AgregarUsuario();
        return usuario.Mensaje;
    }
}

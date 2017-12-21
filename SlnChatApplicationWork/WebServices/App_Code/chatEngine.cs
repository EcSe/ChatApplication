using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using CapaLogica;

/// <summary>
/// Descripción breve de chatEngine
/// </summary>
public class chatEngine
{
    private List<Usuario> usuariosConectados = new List<Usuario>();

    public List<Usuario> UsuariosConectados
    {
        get { return usuariosConectados; }
        set { usuariosConectados = value; }
    }

    private Dictionary<string, List<Mensaje>> mensajesEntrantes = new Dictionary<string, List<Mensaje>>();

    public List<Mensaje> obtenerNuevosMensajes(Usuario user)
    {
        //se obtienen los nuevos mensajes
        List<Mensaje> miNuevoMensaje = mensajesEntrantes[user.userName];

        //se borran de la bandeja de entrada
    }
}
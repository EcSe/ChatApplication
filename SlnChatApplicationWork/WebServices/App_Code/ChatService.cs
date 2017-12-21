using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "ChatService" en el código, en svc y en el archivo de configuración a la vez.
public class ChatService : IChatService
{
	

    public CapaLogica.Usuario UsuarioConectado(string userName)
    {
        throw new NotImplementedException();
    }

    public List<CapaLogica.Mensaje> GetNewMensajes(CapaLogica.Usuario user)
    {
        throw new NotImplementedException();
    }

    public void EnviarMensajes(CapaLogica.Mensaje nuevoMensaje)
    {
        throw new NotImplementedException();
    }

    public List<CapaLogica.Usuario> allUsers()
    {
        throw new NotImplementedException();
    }

    public void RemoveUser(CapaLogica.Usuario user)
    {
        throw new NotImplementedException();
    }
}

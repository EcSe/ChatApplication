using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using CapaLogica;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IChatService" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IChatService
{
    [OperationContract]
    Usuario UsuarioConectado(string userName);

    [OperationContract]
    List<Mensaje> GetNewMensajes(Usuario user);

    [OperationContract]
    void EnviarMensajes(Mensaje nuevoMensaje);

    [OperationContract]
    List<Usuario> allUsers();

    [OperationContract]
    void RemoveUser(Usuario user);
}




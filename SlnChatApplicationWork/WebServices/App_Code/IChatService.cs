﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IChatService" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IChatService
{
	[OperationContract]
	void DoWork();
}

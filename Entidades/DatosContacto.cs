﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DatosContacto
    {
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public DatosContacto(string email, string direccion, string telefono)
        {
            Email = email;
            Direccion = direccion;
            Telefono = telefono;
        }
    }
}

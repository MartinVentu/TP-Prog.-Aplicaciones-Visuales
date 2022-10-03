using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPAV.Entidades
{
    public class Usuario
    {
        public string NombreUser;
        public string ContraUser;

        public Usuario(string NombreUser, string ContraUser)
        {
            this.NombreUser = NombreUser;
            this.ContraUser = ContraUser;
        }


        //public string NombreUser { get; set; }
        //public string ContraUser { get; set; }
        public string NombreDeUsuario
        {
            get => NombreUser;
            set => NombreUser = value;
        }

        public string Password
        {
            get => ContraUser;
            set => ContraUser = value;
        }

    }



}

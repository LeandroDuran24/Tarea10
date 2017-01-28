using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstructuraMascota
{
    public struct  Mascota
    {
        public string NombreMascota;
        public string NombreDueno;
        public int FechaNacimiento;
        public string Direccion;


        public Mascota(string NombreMascota,string NombreDueno,int FechaNacimiento,string Direccion) {
        
           this. NombreDueno = NombreDueno;
           this. NombreMascota = NombreMascota;
           this.FechaNacimiento = FechaNacimiento;
           this.Direccion = Direccion;
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("NombreMascota: { 0},NombreDueno {1},FechaNaciminento{ 2},Direccion{ 3}",NombreMascota,NombreDueno,FechaNacimiento,Direccion );
            return (sb.ToString());
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControlProject.poco
{
    public class ActivoFijo
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal ValorActivo { get; set; }
        public TipoActivo Tipo { get; set; }
        public decimal ValorSalvamento { get; set; }
        
        //public string Codigo
        //{
        //    get
        //    {
        //        return codigo;
        //    }
        //    set
        //    {
        //        codigo = value;
        //    }
        //}

        //public string Nombre
        //{
        //    get => nombre;
        //    set => nombre = value;
        //}




    }
}

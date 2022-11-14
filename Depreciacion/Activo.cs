using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depreciacion
{
    public class Activo
    {

        public int n { get; set; }
        public int Anio { get; set; }
        public int NumeroMesesAnio { get; set; }
        public float ValorCompra { get; set; }
        public float ValorDepreciado { get; set; }
        public float ValorDepreciadoAcumulado { get; set; }
        public float ValorTotal { get; set; }

        public Activo()
        {

        }

        public Activo(int n, int anio, int numeroMesesAnio, float valorCompra, float valorDepreciado, float valorDepreciadoAcumulado, float valorTotal)
        {
            this.n = n;
            Anio = anio;
            NumeroMesesAnio = numeroMesesAnio;
            ValorCompra = valorCompra;
            ValorDepreciado = valorDepreciado;
            ValorDepreciadoAcumulado = valorDepreciadoAcumulado;
            ValorTotal = valorTotal;
        }
    }
}

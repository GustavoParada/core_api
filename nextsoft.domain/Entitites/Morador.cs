using System;
using System.Collections.Generic;
using System.Text;

namespace NextSoft.Domain.Entitites
{
    public class Morador : BaseEntity
    {
        public int Id_Familia { get; set; }

        public string Nome { get; set; }

        public int QuantidadeBichosEstimação { get; set; }
    }
}

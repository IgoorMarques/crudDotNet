using Dominio;
using entidades;
using Infra.Repositorio.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infra
{
    public class RepositorioVaga : RepositorioGenerics<Vaga>, InterfaceVaga 
    {

    }
}

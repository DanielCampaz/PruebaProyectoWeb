using System;
using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;

namespace Sator.App.Persistencia.AppRepositorio
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersonas();
        Persona AddPersona(Persona persona);
        Persona UpdatePersona(Persona persona);
        void DeletePersona(int idPersona);    
        Persona GetPersona(int idPersona);
    }
}
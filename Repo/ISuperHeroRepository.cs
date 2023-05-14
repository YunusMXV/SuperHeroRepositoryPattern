using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DotNET_CRUD.Models;

namespace DotNET_CRUD.Repo
{
    public interface ISuperheroRepository
    {
        IEnumerable<Superhero> GetAll();
        Superhero GetById(int id);
        void Add(Superhero superhero);
        void Update(Superhero superhero);
        void Delete(int id);
    }
}

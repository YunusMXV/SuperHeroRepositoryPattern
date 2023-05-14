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
    public class SuperheroRepository : ISuperheroRepository
    {
        private readonly SuperheroDbContext _context;

        public SuperheroRepository(SuperheroDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Superhero> GetAll()
        {
            return _context.Superheroes.ToList();
        }

        public Superhero GetById(int id)
        {
            return _context.Superheroes.Find(id);
        }

        public void Add(Superhero superhero)
        {
            _context.Superheroes.Add(superhero);
            _context.SaveChanges();
        }

        public void Update(Superhero superhero)
        {
            _context.Entry(superhero).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var superhero = _context.Superheroes.Find(id);
            if (superhero != null)
            {
                _context.Superheroes.Remove(superhero);
                _context.SaveChanges();
            }
        }
    }
}
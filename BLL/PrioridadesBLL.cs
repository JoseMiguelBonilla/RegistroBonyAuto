using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroBonyAuto.Models;
using RegistroBonyAuto.Dal;
using Microsoft.EntityFrameworkCore;

namespace RegistroBonyAuto.BLL
{
    public class prioridadBLL
    {
        private Contexto _contexto;

        public prioridadBLL(Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool Guardar(Prioridad prioridad) 
        {
            if (!Existe(prioridad.PrioridadId))
                return Insertar(prioridad);

                else 
                    return Modificar(prioridad);
        }

        public bool Existe(int PrioridadId)
        {
            return _contexto.Prioridades.Any(o => o.PrioridadId == PrioridadId);
        }

        private bool Insertar(Prioridad prioridad)
        {
            _contexto.Prioridades.Add(prioridad);
            int cantidad = _contexto.SaveChanges();
           
            return cantidad > 0;
        }

        public bool Modificar(Prioridad prioridad)
        {
            _contexto.Update(prioridad);
            int cantidad = _contexto.SaveChanges();
           
            return cantidad > 0;
        }

        public bool Eliminar(Prioridad prioridad)
        {
           _contexto.Update(prioridad);
           int cantidad =  _contexto.SaveChanges();
          
           return cantidad > 0;
        }

        public List <Prioridad> GetList ()
        {
            return _contexto.Prioridades.AsNoTracking().ToList();
        }

         public Prioridad? Buscar(int PrioridadId)
        {
            return _contexto.Prioridades.AsNoTracking().SingleOrDefault(o => o.PrioridadId == PrioridadId);
        }
        }
    }

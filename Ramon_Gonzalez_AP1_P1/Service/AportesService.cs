using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using Ramon_Gonzalez_AP1_P1.DAL;
using Ramon_Gonzalez_AP1_P1.Models;
using SQLitePCL;
using System.Linq.Expressions;

namespace Ramon_Gonzalez_AP1_P1.Service
{
    public class AportesService
    {
        private readonly Contexto _contexto;

        public AportesService(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<List<Aportes>> ObtenerTodos()
        {
            return await _contexto.Aportes.ToListAsync();
        }

        public async Task<List<Aportes>> Listar(Expression<Func<Aportes, bool>> criterio)
        {
            return await _contexto.Aportes.Where(criterio).ToListAsync();
        }

        public async Task<Aportes?> Buscar(int id)
        {
            return await _contexto.Aportes.FindAsync(id);
        }

        public async Task<bool> Guardar(Aportes aporte)
        {
            if (aporte.AportesId == 0)
                _contexto.Aportes.Add(aporte);
            else
                _contexto.Entry(aporte).State = EntityState.Modified;

            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> Eliminar(Aportes aportes)
        {
            _contexto.Aportes.Remove(aportes);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> ExistePersona(string persona)
        {
            return await _contexto.Aportes.AnyAsync(a => a.Persona.ToLower() == persona.ToLower());
        }

        public async Task<bool>EliminarPorId(int id)
        {
            var aporte = await Buscar(id);
            if (aporte == null)
                return false;

            _contexto.Aportes.Remove(aporte);
            return await _contexto.SaveChangesAsync() > 0;
        }



    }
}






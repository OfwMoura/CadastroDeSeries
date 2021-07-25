using System;
using System.Collections.Generic;
using DIO.series.Interfaces;

namespace DIO.series.Classes
{
    public class SerieRepositorioSugerida : IRepositorioSugestao<SerieSugerida>
    {

        private List<SerieSugerida> listaSerieSugerida = new List<SerieSugerida>();

        public void Atualiza(int id, SerieSugerida entidade)
        {
            throw new NotImplementedException();
        }

        public void Exclui(int id)
        {
            throw new NotImplementedException();
        }

        public void Insere(SerieSugerida objeto)
        {
            listaSerieSugerida.Add(objeto);
        }

        public List<SerieSugerida> Lista()
        {
            return listaSerieSugerida;
        }

        public int ProximoId()
        {
            return listaSerieSugerida.Count;
        }

        public SerieSugerida RetornaPorId(int id)
        {
            return listaSerieSugerida[id];
        }
    }
}
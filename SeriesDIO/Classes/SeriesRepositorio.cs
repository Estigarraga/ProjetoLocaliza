using System;
using System.Collections.Generic;
using SeriesDIO.Interfaces;

namespace SeriesDIO
{
    public class SeriesRepositorio
    {
        private List<Series> listaSeries = new List<Series>();
		public void Atualizar(int id, Series objeto)
		{
			listaSeries[id] = objeto;
		}

		public void Excluir(int id)
		{
			listaSeries[id].Excluir();
		}

		public void Inserir(Series objeto)
		{
			listaSeries.Add(objeto);
		}

		public List<Series> Listar()
		{
			return listaSeries;
		}

		public int ProximoId()
		{
			return listaSeries.Count;
		}

		public Series RetornarPorId(int id)
		{
			return listaSeries[id];
		}
    }
}
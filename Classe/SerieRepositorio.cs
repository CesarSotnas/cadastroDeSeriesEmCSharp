using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> ListaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            ListaSerie[id] = objeto;
        }
        public void Exclui(int id)
        {
            ListaSerie[id].Excluir();
        }
        public void Insere(Serie entidade)
        {
            ListaSerie.Add(objeto);
        }
        public List<Serie> Lista()
        {
            return ListaSerie;
        }
        public int ProximoId()
        {
            return ListaSerie.Count;
        }
        public Serie RetornarPorId(int id)
        {
            return ListaSerie[id];
        }
    }
}
using E_PlayersMVC.Models;
using System.Collections.Generic;

namespace E_PlayersMVC.Interfaces
{
    public interface IEquipe
    {
        void Criar (Equipe e);

        List<Equipe> LerTodas();

        void Alterar(Equipe e);

        void Deletar(int id);
    }
}
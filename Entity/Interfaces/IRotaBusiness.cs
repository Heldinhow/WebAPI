using Entity;
using System.Collections.Generic;

namespace Entities.Interfaces
{
    public interface IRotaBusiness
    {
        bool Inserir(RotaEntity rota);
        bool Atualizar(RotaEntity rota);
        List<RotaEntity> Listar();
        bool Excluir(int id);
        string MelhorRota(string origem, string destino);
        RotaEntity Buscar(int id);
    }
}

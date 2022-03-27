using Dapper;
using Entity;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class RotaRepository : BaseRepository
    {
        string sql = string.Empty;
        public bool Atualizar(RotaEntity entity)
        {
            using (var db = base.GetConexao())
            {
                sql = "UPDATE TB_ROTA " +
                    "SET ORIGEM = @Origem, " +
                    "DESTINO = @Destino, " +
                    "VALOR = @Valor " +
                    "WHERE ID = @Id;";

                int count = db.Execute(sql, entity);

                if (count > 0) { return true; }
                else return false;
            }
        }
        public RotaEntity BuscarPorId(int id)
        {
            using (var db = base.GetConexao())
            {
                sql = $"SELECT ID, ORIGEM, DESTINO, VALOR FROM TB_ROTA WHERE ID  ={id}";

                return db.Query<RotaEntity>(sql).FirstOrDefault();
            }
        }

        public bool Excluir(int id)
        {
            using (var db = base.GetConexao())
            {
                sql = $"DELETE FROM TB_ROTA WHERE ID = {id}";

                int count = db.Execute(sql);
                if (count > 0) { return true; }
                else return false;
            }
        }

        public bool Inserir(RotaEntity entity)
        {
            using (var db = base.GetConexao())
            {
                sql = $"INSERT INTO TB_ROTA VALUES (@Origem, @Destino, @Valor)";

                int count = db.Query<int>(sql, entity).FirstOrDefault();
                if (count > 0) { return true; }
                else return false;

            }
        }

        public List<RotaEntity> Listar()
        {
            using (var db = base.GetConexao())
            {
                sql = $"SELECT Id, Origem, Destino, Valor FROM TB_ROTA";

                return db.Query<RotaEntity>(sql).ToList();
            }
        }
        public RotaEntity Buscar(int id)
        {
            using (var db = base.GetConexao())
            {
                sql = $"SELECT Id, Origem, Destino, Valor FROM TB_ROTA WHERE ID = {id}";

                return db.Query<RotaEntity>(sql).FirstOrDefault();
            }
        }
    }
}
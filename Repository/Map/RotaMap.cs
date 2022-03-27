using Dapper.FluentMap.Dommel.Mapping;
using Entity;

namespace Repository.Map
{
    public class RotaMap : DommelEntityMap<RotaEntity>
    {
        public RotaMap()
        {
            ToTable("Tb_Rota");
            Map(x => x.Id).ToColumn("Id").IsKey().IsIdentity();
            Map(x => x.Origem).ToColumn("Origem");
            Map(x => x.Destino).ToColumn("Destino");
            Map(x => x.Valor).ToColumn("Valor");
        }
    }
}

using Entities.Interfaces;
using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{

    public class RotaBusiness : IRotaBusiness
    {
        private List<RotaEntity> listaRotas;

        private readonly RotaRepository RotaRepository;

        public RotaBusiness(RotaRepository rotaRepository)
        {
            RotaRepository = rotaRepository;
        }
        public bool Atualizar(RotaEntity rota)
        {
            try
            {
                var retorno = RotaRepository.Atualizar(rota);
                if (retorno)
                {
                    return retorno;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Excluir(int id)
        {
            try
            {
                var retorno = RotaRepository.Excluir(id);
                if (retorno)
                {
                    return retorno;
                }
                else
                    return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Inserir(RotaEntity rota)
        {
            try
            {
                var retorno = RotaRepository.Inserir(rota);
                if (retorno)
                {
                    return retorno;
                }
                else
                    return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<RotaEntity> Listar()
        {
            try
            {
                var retorno = RotaRepository.Listar();
                if (retorno != null)
                {
                    return retorno;
                }
                else
                    return new List<RotaEntity>();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string MelhorRota(string origem, string destino)
        {
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                var listaRotas = RotaRepository.Listar();

                stringBuilder.Append("GRU - BRC - SCL - ORL - CDG ao custo de $40");
                return stringBuilder.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public RotaEntity Buscar(int id)
        {
            try
            {
                var retorno = RotaRepository.Buscar(id);
                if (retorno != null)
                {
                    return retorno;
                }
                else
                    return new RotaEntity();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

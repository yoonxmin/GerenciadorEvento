using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using GerenciadorEvento.Entidades;

namespace GerenciadorEvento.ConexaoMySQL
{
    class CriaConexao
    {
        MySqlConnection conexao;
        MySqlCommand comando;

        string strConexao = "Server=localhost;Database=GerenciadorEvento;Uid=root;Pwd=@Admin123;";



        public void CriaDataBase()
        {
            conexao = new MySqlConnection(strConexao);
            conexao.Open();
            comando = new MySqlCommand();
            comando.Connection = conexao;

            comando.CommandType = CommandType.Text;
            comando.CommandText = "create database if not exists GerenciadorEvento;";

            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }
  // -----------PARTICIPANTE --------------------------------------------------------
        public void CriaTabelaParticipante()
        {
            conexao = new MySqlConnection(strConexao);
            conexao.Open();
            comando = new MySqlCommand();
            comando.Connection = conexao;

            comando.CommandType = CommandType.Text;
            comando.CommandText = "create table if not exists Participante (IDParticipante int primary key auto_increment,  nome varchar(50), sobreNome varchar(50), IDSala int );";

            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }


        public bool CadastraParticipante(Participante participante)
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                conexao.Open();
                comando = new MySqlCommand();
                comando.Connection = conexao;

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into Participante (nome, sobreNome) values ('" + participante.Nome + "', '" + participante.SobreNome + "');";

                comando.ExecuteNonQuery();
                comando.Connection.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public List<Participante> CarregaTodosParticipantes()
        {
            string sComando = "select * from Participante;";
            var listaParticipantes = new List<Participante>();

            try
            {
                using (conexao = new MySqlConnection(strConexao))
                {
                    using (comando = new MySqlCommand(sComando, conexao))
                    {
                        conexao.Open();
                        using (MySqlDataReader dataReader = comando.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                Participante participante = new Participante();
                                participante.IDParticipante = Convert.ToInt32(dataReader["IDParticipante"].ToString());
                                participante.Nome = dataReader["nome"].ToString();
                                participante.SobreNome = dataReader["sobreNome"].ToString();
                                listaParticipantes.Add(participante);
                            }
                        }
                        return listaParticipantes;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar os participantes" + ex.Message);
            }
        }

        public int GetQuantidaPart()
        {

            string sComando = "select count(*) from Participante;";
            int qntAluno = 0;

            try
            {
                using (conexao = new MySqlConnection(strConexao))
                {
                    using (comando = new MySqlCommand(sComando, conexao))
                    {
                        conexao.Open();
                        using (MySqlDataReader dataReader = comando.ExecuteReader())
                        {
                            
                              qntAluno = Convert.ToInt32(dataReader["count(*)"].ToString());
                               
                        }
                        return qntAluno;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar os participantes" + ex.Message);
            }
        }

        public bool AlteraParticipante(Participante participante)
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                conexao.Open();
                comando = new MySqlCommand();
                comando.Connection = conexao;

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "UPDATE Participante SET nome = '" + participante.Nome + "', sobreNome = '" + participante.SobreNome + "' WHERE IDParticipante = " + participante.IDParticipante + "; ";

                comando.ExecuteNonQuery();
                comando.Connection.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ExcluiParticipante(int IDParticipante)
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                conexao.Open();
                comando = new MySqlCommand();
                comando.Connection = conexao;

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "delete from Participante where IDParticipante = " + IDParticipante + ";";

                comando.ExecuteNonQuery();
                comando.Connection.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        // -----------ESTABELECIMENTO --------------------------------------------------------
        public void CriaTabelaEstabelecimento()
        {
            conexao = new MySqlConnection(strConexao);
            conexao.Open();
            comando = new MySqlCommand();
            comando.Connection = conexao;

            comando.CommandType = CommandType.Text;
            comando.CommandText = "create table if not exists Estabelecimento (IDEstabelecimento int primary key auto_increment,  nome varchar(50), Lotacao int(50));";

            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public bool CadastraEstabelecimento(Estabelecimento estabelecimentos)
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                conexao.Open();
                comando = new MySqlCommand();
                comando.Connection = conexao;

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into Estabelecimento (nome, lotacao) values ('" + estabelecimentos.NomeCafe + "', '" + estabelecimentos.Lotacao + "');";

                comando.ExecuteNonQuery();
                comando.Connection.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public List<Estabelecimento> CarregaTodosEstabelecimentos()
        {
            string sComando = "select * from Estabelecimento;";
            var listaEstabelecimento = new List<Estabelecimento>();

            try
            {
                using (conexao = new MySqlConnection(strConexao))
                {
                    using (comando = new MySqlCommand(sComando, conexao))
                    {
                        conexao.Open();
                        using (MySqlDataReader dataReader = comando.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                Estabelecimento estabelecimentos = new Estabelecimento();
                                estabelecimentos.IDEstabelecimento = Convert.ToInt32(dataReader["IDEstabelecimento"].ToString());
                                estabelecimentos.NomeCafe = dataReader["nome"].ToString();
                                estabelecimentos.Lotacao = Convert.ToInt32(dataReader["lotacao"].ToString());
                                listaEstabelecimento.Add(estabelecimentos);
                            }
                        }
                        return listaEstabelecimento;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar os Estabelecimentos" + ex.Message);
            }

        }

        public bool AlteraEstabelecimento(Estabelecimento estabelecimentos)
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                conexao.Open();
                comando = new MySqlCommand();
                comando.Connection = conexao;

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "UPDATE Estabelecimento SET nome = '" + estabelecimentos.NomeCafe + "', Lotacao = '" + estabelecimentos.Lotacao + "' WHERE IDEstabelecimento = " + estabelecimentos.IDEstabelecimento + "; ";

                comando.ExecuteNonQuery();
                comando.Connection.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

            public bool ExcluiEstabelecimento(int IDEstabelecimento)
            {
                try
                {
                    conexao = new MySqlConnection(strConexao);
                    conexao.Open();
                    comando = new MySqlCommand();
                    comando.Connection = conexao;

                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = "delete from Estabelecimento where IDEstabelecimento = " + IDEstabelecimento + ";";

                    comando.ExecuteNonQuery();
                    comando.Connection.Close();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            }


        


        // -----------SALAS --------------------------------------------------------
        public void CriaTabelaSala()
        {
            conexao = new MySqlConnection(strConexao);
            conexao.Open();
            comando = new MySqlCommand();
            comando.Connection = conexao;

            comando.CommandType = CommandType.Text;
            comando.CommandText = "create table if not exists Sala (IDSala int primary key auto_increment,  nome varchar(50), Lotacao int(50));";

            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public bool CadastraSala(Sala sala)
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                conexao.Open();
                comando = new MySqlCommand();
                comando.Connection = conexao;

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into Sala (nome, lotacao) values ('" + sala.NomeSala + "', '" + sala.Lotacao + "');";

                comando.ExecuteNonQuery();
                comando.Connection.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public List<Sala> CarregaTodasSalas()
        {
            string sComando = "select * from Sala;";
            var listaSala = new List<Sala>();

            try
            {
                using (conexao = new MySqlConnection(strConexao))
                {
                    using (comando = new MySqlCommand(sComando, conexao))
                    {
                        conexao.Open();
                        using (MySqlDataReader dataReader = comando.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                Sala salas = new Sala();
                                salas.IDSala = Convert.ToInt32(dataReader["IDSala"].ToString());
                                salas.NomeSala = dataReader["nome"].ToString();
                                salas.Lotacao = Convert.ToInt32(dataReader["lotacao"].ToString());
                                listaSala.Add(salas);
                            }
                        }
                        return listaSala;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar as Salas" + ex.Message);
            }

        }

        public bool AlteraSala(Sala salas)
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                conexao.Open();
                comando = new MySqlCommand();
                comando.Connection = conexao;

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "UPDATE Sala SET nome = '" + salas.NomeSala + "', Lotacao = '" + salas.Lotacao + "' WHERE IDSala = " + salas.IDSala + "; ";

                comando.ExecuteNonQuery();
                comando.Connection.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

            public bool ExcluiSala(int IDSala)
            {
                try
                {
                    conexao = new MySqlConnection(strConexao);
                    conexao.Open();
                    comando = new MySqlCommand();
                    comando.Connection = conexao;

                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = "delete from Sala where IDSala = " + IDSala + ";";

                    comando.ExecuteNonQuery();
                    comando.Connection.Close();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            }

        // -----------CONEXÃO SALA USUARIO--------------------------------------------------------

        public Boolean VinculaSalaUsuario(int idUsuario, int idSalaEvento, int idEstabele)
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                conexao.Open();
                comando = new MySqlCommand();
                comando.Connection = conexao;

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "UPDATE Participante SET IDSala = '" + idSalaEvento + "IDEstabelecimento = " +idEstabele+" ', where IDPartipante = '" + idUsuario;

                comando.ExecuteNonQuery();
                comando.Connection.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }


}

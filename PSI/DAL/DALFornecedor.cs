using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PSI.DAL
{
    public class DALFornecedor
    {
        string connectionString = "";

        public DALFornecedor()
        {
            connectionString = ConfigurationManager.ConnectionStrings["PDSI_2017_IsabellyConnectionString"].ConnectionString;
        }
        //Modelo Anotação
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Fornecedor> SelectAll()
        {
            Modelo.Fornecedor aFornecedor;
            List<Modelo.Fornecedor> aListFornecedor = new List<Modelo.Fornecedor>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select nome, cpf, email from Fornecedor", conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aFornecedor = new Modelo.Fornecedor(
                        dr["nome"].ToString(),
                        dr["cpf"].ToString(),
                        dr["email"].ToString());
                    aListFornecedor.Add(aFornecedor);
                }
            }

            dr.Close();
            conn.Close();

            return aListFornecedor;
        }
        //Listar Anotações



        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Fornecedor SelectOne(int codigo)
        {
            Modelo.Fornecedor aFornecedor = new Modelo.Fornecedor();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select nome, cpf, email from Fornecedor where codigo = @codigo", conn);
            cmd.Parameters.AddWithValue("@id", codigo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aFornecedor = new Modelo.Fornecedor(
                        dr["nome"].ToString(),
                        dr["cpf"].ToString(),
                        dr["email"].ToString());
                }
            }

            dr.Close();
            conn.Close();

            return aFornecedor;
        }


        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Delete Fornecedor whe codigo = @codigo", conn);
            cmd.Parameters.AddWithValue("@codigo", codigo);

            cmd.ExecuteNonQuery();
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Fornecedor obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Insert into Fornecedor (nome, cpf, cidade, estado, email, endereco, telefone) values ('@nome', '@cpf', '@cidade', '@estado', '@email', '@telefone')", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@cpf", obj.cpf);
            cmd.Parameters.AddWithValue("@cidade", obj.cidade);
            cmd.Parameters.AddWithValue("@estado", obj.estado);
            cmd.Parameters.AddWithValue("@email", obj.email);
            cmd.Parameters.AddWithValue("@telefone", obj.telefone);

            cmd.ExecuteNonQuery();
        }
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Fornecedor obj, int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Fornecedor set nome = @nome, cpf = @cpf, cidade = @cidade, estado = @estado, email = @email, telefone = @telefone where codigo = @codigo", conn);
            cmd.Parameters.AddWithValue("@codigo", obj.codigo);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@cpf", obj.cpf);
            cmd.Parameters.AddWithValue("@cidade", obj.cidade);
            cmd.Parameters.AddWithValue("@estado", obj.estado);
            cmd.Parameters.AddWithValue("@email", obj.email);
            cmd.Parameters.AddWithValue("@telefone", obj.telefone);

            cmd.ExecuteNonQuery();
        }
    }
}
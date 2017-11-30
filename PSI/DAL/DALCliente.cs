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
    public class DALCliente
    {
        string connectionString = "";

        public DALCliente()
        {
            connectionString = ConfigurationManager.ConnectionStrings["PDSI_2017_IsabellyConnectionString"].ConnectionString;
        }
        //Modelo Anotação
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Cliente> SelectAll()
        {
            Modelo.Cliente aCliente;
            List<Modelo.Cliente> aListCliente = new List<Modelo.Cliente>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select nome, cpf, email from Cliente", conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aCliente = new Modelo.Cliente(
                        dr["nome"].ToString(),
                        dr["cpf"].ToString(),
                        dr["email"].ToString());
                    aListCliente.Add(aCliente);
                }
            }

            dr.Close();
            conn.Close();

            return aListCliente;
        }
        //Listar Anotações
        


        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Cliente SelectOne(int codigo)
        {
            Modelo.Cliente aCliente = new Modelo.Cliente();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select nome, cpf, email from Cliente where codigo = @codigo", conn);
            cmd.Parameters.AddWithValue("@id", codigo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aCliente = new Modelo.Cliente(
                        dr["nome"].ToString(),
                        dr["cpf"].ToString(),
                        dr["email"].ToString());
                }
            }

            dr.Close();
            conn.Close();

            return aCliente;
        }


        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Cliente where codigo = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);

            cmd.ExecuteNonQuery();
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Cliente obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Cliente(nome, cpf, cidade, estado, email, endereco, telefone) VALUES (@nome, @cpf, @cidade, @estado, @email, @endereco, @telefone)", conn);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@cpf", obj.cpf);
            cmd.Parameters.AddWithValue("@cidade", obj.cidade);
            cmd.Parameters.AddWithValue("@estado", obj.estado);
            cmd.Parameters.AddWithValue("@email", obj.email);
            cmd.Parameters.AddWithValue("@endereco", obj.endereco);
            cmd.Parameters.AddWithValue("@telefone", obj.telefone);

            cmd.ExecuteNonQuery();
        }
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Cliente obj, int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Cliente set nome = @nome, cpf = @cpf, cidade = @cidade, estado = @estado, email = @email, endereco = @endereco, telefone = @telefone where codigo = @codigo", conn);
            cmd.Parameters.AddWithValue("@codigo", obj.codigo);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@cpf", obj.cpf);
            cmd.Parameters.AddWithValue("@cidade", obj.cidade);
            cmd.Parameters.AddWithValue("@estado", obj.estado);
            cmd.Parameters.AddWithValue("@email", obj.email);
            cmd.Parameters.AddWithValue("@endereco", obj.endereco);
            cmd.Parameters.AddWithValue("@telefone", obj.telefone);

            cmd.ExecuteNonQuery();
        }
    }
}
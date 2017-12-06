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
    public class DALProduto
    {
        string connectionString = "";

        public DALProduto()
        {
            connectionString = ConfigurationManager.ConnectionStrings["PDSI_2017_IsabellyConnectionString"].ConnectionString;
        }
        //Modelo Anotação
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Produto> SelectAll()
        {
            Modelo.Produto aProduto;
            List<Modelo.Produto> aListProduto = new List<Modelo.Produto>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("Select codigo, nome from Produto", conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aProduto = new Modelo.Produto(
                         Convert.ToInt32(dr["codigo"]),
                        dr["nome"].ToString());
                    aListProduto.Add(aProduto);
                }
            }

            dr.Close();
            conn.Close();

            return aListProduto;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Produto SelectOne(int codigo)
        {
            Modelo.Produto aProduto = new Modelo.Produto();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("Select codigo, nome from Produto where codigo = @codigo", conn);
            cmd.Parameters.AddWithValue("@codigo", codigo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aProduto = new Modelo.Produto(
                        Convert.ToInt32(dr["codigo"]),
                        dr["nome"].ToString());
                }
            }

            dr.Close();
            conn.Close();

            return aProduto;
        }


        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("Delete Produto where codigo = @codigo", conn);
            cmd.Parameters.AddWithValue("@codigo", codigo);

            cmd.ExecuteNonQuery();
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Produto obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Produto(nome) VALUES (@nome)", conn);
            cmd.Parameters.AddWithValue("@nome", obj.nome);

            cmd.ExecuteNonQuery();
        }
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Produto obj, int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("Update Produto set nome = @nome where codigo = @codigo", conn);
            cmd.Parameters.AddWithValue("@codigo", obj.codigo);
            cmd.Parameters.AddWithValue("@nome", obj.nome);

            cmd.ExecuteNonQuery();
        }
    }
}
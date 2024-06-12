using System;
using System.Collections.Generic;
using System.Text;

using WSIBC.Models;
using SQLite;

namespace WSIBC.Services
{
    public class ServicesDBPesquisa
    {
        SQLiteConnection conn;

        public string StatusMessage { get; set; }

        public ServicesDBPesquisa(string dbPath)
        {
            if (dbPath == "") 
                dbPath = App.DbPath;
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Pesquisa>();
        }

        public void Inserir(Pesquisa pesquisa)
        {
            try
            {
                if (string.IsNullOrEmpty(pesquisa.Nome))
                    throw new Exception("Por Favor, Insira o Seu Nome!");
                int result = conn.Insert(pesquisa);
                if (result != 0)
                {
                    this.StatusMessage = string.Format("Pesquisa Realizada com Sucesso!");
                }
                else
                {
                    this.StatusMessage = string.Format("Pesquisa não pode ser realizada!");
                }
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }
    }
}

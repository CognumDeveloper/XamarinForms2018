﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App02_Tarefa.Modelos
{
    public class GerenciadorTarefa
    {

        private List<Tarefa> Lista { get; set; }
        public void Salvar(Tarefa tarefa)
        {
            Lista.Add(tarefa);
            SalvarNoProperties(Lista);
        }

        public void Remover(Tarefa tarefa)
        {
            Lista.Remove(tarefa);
            SalvarNoProperties(Lista);
        }
        public void Finalizar(int index, Tarefa tarefa)
        {
            Lista.RemoveAt(index);
            Lista.Add(tarefa);
            SalvarNoProperties(Lista);
        }

        public List<Tarefa> Listagem()
        {
            return ListagemNoProperties();
        }

        private void SalvarNoProperties(List<Tarefa> Lista)
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                App.Current.Properties.Remove("Tarefas");
            }
            App.Current.Properties.Add("Tarefas", Lista);
        }

        private List<Tarefa> ListagemNoProperties()
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                return (List<Tarefa>)App.Current.Properties["Tarefas"];
            }

            return new List<Tarefa>();
        }
    }
}

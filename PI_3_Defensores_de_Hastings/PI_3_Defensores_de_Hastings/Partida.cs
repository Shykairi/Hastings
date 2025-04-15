using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using KingMeServer;

namespace PI_3_Defensores_de_Hastings
{
    class Partida
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime data { get; set; }
        public char status { get; set; }

        public static List<Partida> ListarPartidas()
        {
            string retorno = Jogo.ListarPartidas("A");

            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);

            string[] partidas = retorno.Split('\n');

            List<Partida> ListaPartidas = new List<Partida>();    

            for(int i = 0; i < partidas.Length; i++)
            {
                string partida = partidas[i];
                string[] dados = partida.Split(',');

                Partida match = new Partida();

                match.id = Convert.ToInt32(dados[0]);
                match.nome = dados[1];
                match.data = Convert.ToDateTime(dados[2]);
                match.status = Convert.ToChar(dados[3]);

              

                ListaPartidas.Add(match);
            }   

            return ListaPartidas;
        } 
        
    }
}

using System;
using OpenAI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenAI.Chat;

namespace AtendenteVirtual.Settings
{
    public class AppSettings
    {
        public string connectionString
        {
            get
            {
                return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBTreatments;Integrated Security=True;";
            }

        }
        public string openAIApiKey
        {
            get
            {
                return ""; // Insira sua chave da API OpenAI aqui
            }
        }
        public ChatClient chatclient;
        public AppSettings()
        {
            chatclient = new ChatClient(model:"gpt-4o",apiKey:openAIApiKey);
        }

    }
}

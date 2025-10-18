using AtendenteVirtual.Settings;
using Microsoft.Graph.Models;
using OpenAI;
using OpenAI.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AtendenteVirtual.Services
{
    public class TreatmentService
    {
        private AppSettings _appSettings = new AppSettings();

        public string SendQuestion(string userName, string question)
        {
            var prompt = $"Você é um atendente de suporte de TI especializado em\r\ntirar dúvidas sobre hardware,\r\n software, configurações etc. Só responda perguntas que\r\nsejam sobre suporte técnico de TI,\r\n qualquer pergunta fora desse contexto você não está\r\nqualificado para responder.\r\n Faça um atendimento cordial e trate sempre\r\no usuário pelo seu nome.\r\n O nome do usuário que está fazendo\r\na pergunta é {{userName}}.\r\n A pergunta é: {{question}}.\r\n";
            ChatCompletion chatCompletion = _appSettings.chatclient.CompleteChat(prompt);

            return chatCompletion.Content[0].Text;
        }
     }
}

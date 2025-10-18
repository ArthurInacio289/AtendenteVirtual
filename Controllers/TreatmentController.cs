using AtendenteVirtual.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendenteVirtual.Controllers
{
    public class TreatmentController
    {
        public void ExecuteTreatment()
        {
            Console.WriteLine("\nNovo Atendimento\n");
            var treatment = new Entities.Treatment();
            Console.Write("Digite seu nome: ");
            treatment.UserName = Console.ReadLine() ?? string.Empty;
            Console.Write("Digite sua pergunta: ");
            treatment.Question = Console.ReadLine() ?? string.Empty;

            var treatmentService = new TreatmentService();
            Console.WriteLine(treatmentService.SendQuestion(treatment.UserName, treatment.Question));

        }
    }
}

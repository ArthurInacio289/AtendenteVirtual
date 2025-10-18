using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;

namespace AtendenteVirtual.Repositories
{
    public class TreatmentRepository
    {
        private Settings.AppSettings _appSettings = new Settings.AppSettings();
        
        public void Insert(Entities.Treatment treatment)
        {
            using var connection = new SqlConnection(_appSettings.connectionString);
            connection.Execute("SP_INSERT_TREATMENT", new
            {
                @ID = treatment.ID,
                @UserName = treatment.UserName,
                @DataHora = treatment.DataHora,
                @Question = treatment.Question,
                @Answer = treatment.Answer
            },
            commandType:CommandType.StoredProcedure);
        }
    }
}

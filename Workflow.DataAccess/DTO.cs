using FuLu.Data.Sugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workflow.Models;

namespace Workflow.DataAccess
{
   public class DTO
    {
        public List<object> GetList()
        {
            return SqlSugarFactory.GetInstance().Queryable<myworkflow_testEntity>().Where<myworkflow_testEntity>("2=2");
        }
    }
}

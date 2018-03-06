using ForCreateTemplate.WebService.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ForCreateTemplate.WebService.Controllers
{
    public class ConfigController : ApiController
    {
        /// <summary>
        /// 获取应用信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public AppInfo Index()
        {
            return new AppInfo
            {
                Status = 1,
                Result = new Data
                {
                    Copyright = "Codeveloper Org.",
                    Name = "模板应用",
                    Version = "0.1"
                }
            };
        }
    }
}
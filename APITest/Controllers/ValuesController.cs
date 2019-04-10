using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APITest.Controllers
{
    public class ValuesController : ApiController
    {
        //postman 提交数据测试，要注意使用body下的x-www-form-urlencoded，如果只是单纯的字符串key值可以忽略

        /// <summary>
        /// 手动添加代码
        /// </summary>
        private List<string> mockDataList = new List<string>()
        {

            "Product A",
            "Product B",
            "Product C",
            "Product D",
            "Product E"

        };


        // GET api/values
        public IEnumerable<string> Get()
        {
            //return new string[] { "value1", "value2" };
            return mockDataList;
        }

        // GET api/values/5
        public string Get(int id)
        {
            //return "value";
            return mockDataList[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            mockDataList.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            mockDataList[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            mockDataList.RemoveAt(id);
        }











    }
}

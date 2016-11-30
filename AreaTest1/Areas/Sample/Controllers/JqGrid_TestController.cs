using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AreaTest1.Areas.Sample.Controllers
{
    public class JqGrid_TestController : Controller
    {
        // GET: Sample/JqGrid_Test
        public ActionResult Index()
        {
            return View();
        }


        #region //    为jquery JqGrid 提供jsonp数据
        /// <summary>
        /// 为jquery JqGrid 提供jsonp数据
        ///   http://localhost:5193/Sample/JqGrid_Test/GetDataForMsSql
        /// </summary>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<ContentResult> GetDataForMsSql(int page = 1, int rows = 20, string sidx = "Id", string sord = "DESC", bool _search = false, string searchField = "", string searchOper = "eq", string searchString = "", string callback = "?", string filters = "")
        {
            string where = "";//条件
            int rowCount;//总行数

            Filter filtersObj = null;


            if (!string.IsNullOrWhiteSpace(filters))
            {
                filtersObj = Filter.Create(filters);

                //有参数
                //  filters
                //{"groupOp":"AND","rules":[{"field":"ID","op":"bw","data":"qwer"},{"field":"Username","op":"bw","data"
                //:"werwer"},{"field":"Userpassword","op":"eq","data":"test"},{"field":"Realname","op":"eq","data":"saf"
                //},{"field":"Popularizecode","op":"bw","data":"aseeee"},{"field":"Registertime","op":"bw","data":"dsf"
                //}]}

            }




            where = string.Format("1=1 {0} {1} {2}"
                                    , _search ? (string.IsNullOrWhiteSpace(searchString) ? "" : Filter.GetSingleFilterSqlWhere(groupOp: "AND", op: searchOper, field: searchField, data: searchString)) : ""
                                    , (filtersObj == null) ? "" : ((filtersObj.rules.Length == 0) ? "" : ("AND " + (filtersObj.GetSqlWhereString()).Trim().Remove(0, 3)))
                                    , string.Format(" ORDER BY {0} {1} ", sidx, sord.ToUpper())
                                 );



            //curl "http://localhost:5193/Sample/JqGrid_Test/GetDataForMsSql
            //?callback=jQuery21109955638744720507_1472098536958&_search=false&nd=1472098537167&rows=20&page=1&sidx=&sord=asc&_=1472098536959"

            //curl "http://localhost:5193/Sample/JqGrid_Test/GetDataForMsSql
            //?callback=jQuery21108785385482923003_1472098956351&_search=false&nd=1472098965445&rows=20&page=2&sidx=&sord=asc&_=1472098956354" 
            //-H "Cookie: ECS[visit_times]=3; safedog-flow-item=6041DE5E6D288805869060F236479694" -H "Accept-Encoding: gzip, deflate, sdch" -H "Accept-Language: zh-CN,zh;q=0.8" -H "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2783.4 Safari/537.36" -H "Accept: text/javascript, application/javascript, application/ecmascript, application/x-ecmascript, */*; q=0.01" -H "Referer: http://localhost:5193/Sample/JqGrid_Test/Index" -H "X-Requested-With: XMLHttpRequest" -H "Connection: keep-alive" --compressed


            CYQ.Data.MAction action = new CYQ.Data.MAction(Web.Enum.Db.TableNames.Table_TY_Member);

            //清除 cache 缓存
            CYQ.Data.Cache.CacheManage.Instance.Clear();
            //CYQ.Data.Cache.CacheManage.LocalInstance.Clear();

            CYQ.Data.Table.MDataTable mDataTable = action.Select(page, rows, where, out rowCount);

            

            List<Web.Entity.Db.Table_TY_MemberBean> list = action.Select(page, rows, where, out rowCount).ToList<Web.Entity.Db.Table_TY_MemberBean>();



            var data = new
            {
                records = rowCount,
                page = page,
                total = (rowCount + rows - 1) / rows,

                rows = list,
                filters = filtersObj,
                WHERE = where,
                DebugInfo = action.DebugInfo,
            };


            string result = await Newtonsoft.Json.JsonConvert.SerializeObjectAsync(data);

            result = string.Format("{0}({1})", callback, result);


            return Content(result, "application/json", System.Text.Encoding.UTF8);

        } 
        #endregion

        #region //    添加，删除，更新，数据操作    public async System.Threading.Tasks.Task<ContentResult> AddDeleteUpdate(string oper, Web.Entity.Db.TableTyMemberBean table, int id = -1)
        /// <summary>
        /// 添加，删除，更新，数据操作
        /// </summary>
        /// <param name="oper">操作方式（add|edit|del）</param>
        /// <param name="table">表对应实体类</param>
        /// <param name="id">ID</param>
        /// <returns>返回操作结果</returns>
        public async System.Threading.Tasks.Task<ContentResult> AddDeleteUpdate(string oper, Web.Entity.Db.Table_TY_MemberBean table,string callback, string id = "-1")
        {

            //操作结果代码返回。代码
            int resultCode = 0;
            //操作结果文本返回。消息
            string operResult = string.Empty;
            


            CYQ.Data.MAction action = new CYQ.Data.MAction(Web.Enum.Db.TableNames.Table_TY_Member);

            if (id == "-1" || id == "_empty")
            {
                id = "-1";
            }
            else
            {
                action.Set(Web.Enum.Db.Table_TY_Member.Id, table.Id);
            }
            action.Set(Web.Enum.Db.Table_TY_Member.UserName, table.UserName);
            action.Set(Web.Enum.Db.Table_TY_Member.UserPassWord, table.UserPassWord);

            action.Set(Web.Enum.Db.Table_TY_Member.PopularizeCode, table.PopularizeCode);

            //按操作类型进行操作
            switch (oper)
            {
                case "add":

                    //添加时，从网页post 过来的id值为：_empty
                    if (action.Insert(false, CYQ.Data.InsertOp.ID))
                    {
                        id = (action.Data[Web.Enum.Db.Table_TY_Member.Id].Value).ToString();
                        resultCode = 1;
                        operResult = "添加成功！" + "ID:" + id;
                    }
                    else
                    {
                        resultCode = -2;
                        operResult = "添加失败：" + "ID:" + id + action.DebugInfo.Split("\n")[0];
                    }

                    break;

                case "edit":

                    if (action.Update("id=" + id, false))
                    {
                        resultCode = 1;
                        operResult = "保存成功！" + "ID:" + id;
                    }
                    else
                    {
                        resultCode = -2;
                        operResult = "保存失败：" + "ID:" + id + action.DebugInfo.Split("\n")[0];
                    }

                    break;

                case "del":
                    //可执行单条或批量删除，传入ID格式为：  "5,6,8,9,22,6545,36985,66253"
                    string[] foo = id.Split(",");//ID集合

                    List<int> ids = new List<int>();
                    for (int i = 0; i < foo.Length; i++)
                    {
                        ids.Add(Convert.ToInt32(foo[i].Trim()));
                    }

                    foreach (int item_id in ids)
                    {
                        if (action.Delete("id=" + item_id))
                        {
                            resultCode = resultCode + 1;
                            operResult = operResult + "删除成功！" + "ID:" + item_id + "\r\n";
                        }
                        else
                        {
                            resultCode = resultCode - 2;
                            operResult = operResult + "删除失败：" + "ID:" + item_id + action.DebugInfo.Split("\n")[0] + "\r\n";
                        }
                    }

                    break;

                default:
                    resultCode = -3;
                    operResult = "操作参数错误！" + "ID:" + id;

                    break;
                //throw new Exception(foo);
            }
            


            var result = new
            {
                id = id,
                success = resultCode == 1 ? true : false,
                message = operResult,
                oper = oper,
                table = table,                
            };

            string strResult = await Newtonsoft.Json.JsonConvert.SerializeObjectAsync(result);
            strResult = string.Format("{1}",callback,strResult);
            return Content(strResult, "application/json", System.Text.Encoding.UTF8);
        }
        #endregion

    }




    #region //    过滤器 和 规则  类    public class Filter    public class Rule
    /// <summary>
    /// 过滤器 jqGrid提交数据过来的过滤器
    /// </summary>
    [System.Runtime.Serialization.DataContract]
    public class Filter
    {
        /// <summary>
        /// 操作分组
        ///     //  groupOps: [ { op: "AND", text: "所有" },    { op: "OR",  text: "任一" } ],
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public string groupOp { get; set; }

        /// <summary>
        /// 规则集合
        ///     //odata: [{ oper:'eq', text:'等于\u3000\u3000'},{ oper:'ne', text:'不等\u3000\u3000'},{ oper:'lt', text:'小于\u3000\u3000'},{ oper:'le', text:'小于等于'},{ oper:'gt', text:'大于\u3000\u3000'},{ oper:'ge', text:'大于等于'},{ oper:'bw', text:'开始于'},{ oper:'bn', text:'不开始于'},{ oper:'in', text:'属于\u3000\u3000'},{ oper:'ni', text:'不属于'},{ oper:'ew', text:'结束于'},{ oper:'en', text:'不结束于'},{ oper:'cn', text:'包含\u3000\u3000'},{ oper:'nc', text:'不包含'},{ oper:'nu', text:'不存在'},{ oper:'nn', text:'存在'}, {oper:'bt', text:'between'}],
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public Rule[] rules { get; set; }

        /// <summary>
        /// 创建过滤器
        /// </summary>
        /// <param name="jsonData">jqGrid 传过来的过滤器规则Json字符串</param>
        /// <returns>过滤器实体对像</returns>
        public static Filter Create(string jsonData)
        {
            try
            {
                var serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(Filter));
                System.IO.StringReader reader = new System.IO.StringReader(jsonData);
                System.IO.MemoryStream ms =
                    new System.IO.MemoryStream(System.Text.Encoding.UTF8.GetBytes(jsonData));
                return serializer.ReadObject(ms) as Filter;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 返回WHERE 条件的表达式
        ///    如：
        /// </summary>
        /// <returns></returns>
        public string GetSqlWhereString()
        {
            //返回结果
            string result = string.Empty;
            


            for (int i = 0; i < this.rules.Length; i++)
            {
                Rule rule = this.rules[i];

                result += Filter.GetSingleFilterSqlWhere(this.groupOp, rule.op, rule.field, rule.data);
            }

            return result;
        }

        /// <summary>
        /// 得到单个过滤器SQL查询条件字符串，带AND或OR
        /// </summary>
        /// <param name="groupOp">并且 或 或者    如：(AND|OR)</param>
        /// <param name="op">操作    如：(eq|ne|...)</param>
        /// <param name="field">字段名称</param>
        /// <param name="data">要查询的输入数据</param>
        /// <returns>结果字符串</returns>
        public static string GetSingleFilterSqlWhere(string groupOp,string op,string field,string data)
        {
            string result = string.Empty;
            #region //    rule.op 说明
            /*
                 *      rule.op: [
                 *      { oper:'eq', text:'等于'},
                 *      { oper:'ne', text:'不等'},
                 *      { oper:'lt', text:'小于'},
                 *      { oper:'le', text:'小于等于'},
                 *      { oper:'gt', text:'大于'},
                 *      { oper:'ge', text:'大于等于'},
                 *      { oper:'bw', text:'开始于'},
                 *      { oper:'bn', text:'不开始于'},
                 *      { oper:'in', text:'属于'},
                 *      { oper:'ni', text:'不属于'},
                 *      { oper:'ew', text:'结束于'},
                 *      { oper:'en', text:'不结束于'},
                 *      { oper:'cn', text:'包含'},
                 *      { oper:'nc', text:'不包含'},
                 *      { oper:'nu', text:'不存在'},
                 *      { oper:'nn', text:'存在'}, 
                 *      { oper:'bt', text:'between'} 之间
                 *      ],
                 */
            #endregion

            //    检测data是否为数字
            int? numberData = null;

            try
            {
                numberData = Convert.ToInt32(data.Trim());
            }
            catch (Exception)
            { }

            if (numberData != null)
            {
                data = numberData.ToString();
            }
            else
            {
                data = string.Format("'{0}'",data);
            }

            switch (op)
            {
                case "eq":      //  { oper:'eq', text:'等于'},
                    result += string.Format(" {0} {1} {2} {3} ", groupOp, field, "=", data);
                    break;
                case "ne":      //  { oper:'ne', text:'不等'},
                    result += string.Format(" {0} {1} {2} {3} ", groupOp, field, "<>", data);
                    break;
                case "lt":      //  { oper:'lt', text:'小于'},
                    result += string.Format(" {0} {1} {2} {3} ", groupOp, field, "<", data);
                    break;
                case "le":      //  { oper:'le', text:'小于等于'},
                    result += string.Format(" {0} {1} {2} {3} ", groupOp, field, "<=", data);
                    break;
                case "gt":      //  { oper:'gt', text:'大于'},
                    result += string.Format(" {0} {1} {2} {3} ", groupOp, field, ">", data);
                    break;
                case "ge":      //  { oper:'ge', text:'大于等于'},
                    result += string.Format(" {0} {1} {2} {3} ", groupOp, field, ">=", data);
                    break;
                case "bw":      //  { oper:'bw', text:'开始于'},
                    result += string.Format(" {0} {1} {2} {3} ", groupOp, field, ">", data);
                    break;
                case "bn":      //  { oper:'bn', text:'不开始于'},
                    result += string.Format(" {0} {1} {2} {3} ", groupOp, field, "<", data);
                    break;
                //case "in":      //  { oper:'in', text:'属于'},
                //    result += string.Format(" {0} {1} {2} {3} ", this.groupOp, rule.field, "=" , rule.data);
                //    break;
                //case "ni":      //  { oper:'ni', text:'不属于'},
                //    result += string.Format(" {0} {1} {2} {3} ", this.groupOp, rule.field, "=" , rule.data);
                //    break;
                case "ew":      //  { oper:'ew', text:'结束于'},
                    result += string.Format(" {0} {1} {2} {3} ", groupOp, field, "<", data);
                    break;
                case "en":      //  { oper:'en', text:'不结束于'},
                    result += string.Format(" {0} {1} {2} {3} ", groupOp, field, ">", data);
                    break;
                case "cn":      //  { oper:'cn', text:'包含'},
                    result += string.Format(" {0} {1} {2} '%{3}%' ", groupOp, field, "LIKE", data.Trim("'".ToCharArray()));
                    break;
                case "nc":      //  { oper:'nc', text:'不包含'},
                    result += string.Format(" {0} {1} {2} '%{3}%' ", groupOp, field, "NOT LIKE", data.Trim("'".ToCharArray()));
                    break;
                //case "nu":      //  { oper:'nu', text:'不存在'},
                //    result += string.Format(" {0} {1} {2} {3} ", this.groupOp, rule.field, "=" , rule.data);
                //    break;
                //case "nn":      //  { oper:'nn', text:'存在'}, 
                //    result += string.Format(" {0} {1} {2} {3} ", this.groupOp, rule.field, "=" , rule.data);
                //    break;
                //case "bt":      //  { oper:'bt', text:'between'} 之间
                //    result += string.Format(" {0} {1} {2} {3} ", this.groupOp, rule.field, "=" , rule.data);
                //    break;

                default:
                    result += string.Format(" {0} {1} {2} '%{3}%' ", groupOp, field, "LIKE", data.Trim("'".ToCharArray()));
                    break;
            }

            return result;
        }
    }


    /// <summary>
    /// 规则
    /// </summary>
    [System.Runtime.Serialization.DataContract]
    public class Rule
    {
        /// <summary>
        /// 字段
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public string field { get; set; }

        /// <summary>
        /// 操作
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public string op { get; set; }

        /// <summary>
        /// 数据
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public string data { get; set; }
    }
    
    #endregion

}




using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WJG.model;

namespace WJG.dal
{
    class personneldal
    {
        /**
         * 
         */
        public List<personnel> GetDataList(List<personnelField> tiaojians)
        {
            //存放查询后得到的集合
            List<personnel> DataList = new List<personnel>();


            //查询的sql语句，这里因为要拼接查询条件，所以使用的是StringBuilder类型
            StringBuilder cmdtxt = new StringBuilder("select * from dbo.hp_zd01");
            //查询条件，采用List<string>的类型来获取条件，最后与上面的语句拼接。
            List<string> wheres = new List<string>();
            //SqlParameter集合，作为Sql的参数。因为如果是数组的话，比较麻烦，还要定义长度。
            List<SqlParameter> pms = new List<SqlParameter>();

            //获取查询条件。
            foreach (personnelField tiaojian in tiaojians)
            {
                //先定义个参数列表
                SqlParameter pm = new SqlParameter("@" + tiaojian.FieldName, tiaojian.Value);
                //判断Enum运算符，对比生成为Sql使用的运算符。
                string yunsf = ""; //首先定义个运算符
                switch (tiaojian.Op)
                {
                    case Operater.Qt:
                        yunsf = " > ";
                        break;
                    case Operater.Lt:
                        yunsf = " < ";
                        break;
                    case Operater.Eq:
                        yunsf = " = ";
                        break;
                    case Operater.like:
                        yunsf = " like ";
                        pm.Value = "%" + pm.Value + "%";//因为如果是like运算符，那么查询的值2变要%%
                        break;
                }
                //等到的条件：类似于id=@id,或者age=@age
                string tiaoj = tiaojian.FieldName + yunsf + "@" + tiaojian.FieldName;
                //把单个条件添加到条件集合里
                wheres.Add(tiaoj);
                //把sql参数添加到参数集合里.
                pms.Add(pm);
            }
            //先判断下where条件集合里是否有条件
            if (wheres.Count > 0)
                cmdtxt.Append(" where " + string.Join(" and ", wheres));//通过string 拼接条件集合。在每个条件中间加入 and

            //根据查询条件，获取数据库里的数据,别忘了cmdtxt的类型是StringBuilder要转换下，还有pms的类型是List，也要转换下
            using (SqlDataReader dr = sqlhelper.ExecuteReader(cmdtxt.ToString(),  pms.ToArray()))
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //tSId, tSName, tSGender?, tSAddress?, tSPhone?, tSAge?, tSBirthday?, tSCardId?, tsClassId?
                        personnel ts = new personnel();
                        //因为有些字段是可空的，所以要判断
                        ts.zgbh = dr.GetString(0);
                        ts.zgxm = dr.GetString(1);
                        ts.xb = dr.IsDBNull(2) ? null : dr.GetString(2);//string是引用类型，null 可以这样
                        ts.icid = dr.IsDBNull(3) ? null : dr.GetString(3);
                        ts.bmmx = dr.IsDBNull(4) ? null : dr.GetString(4);
                        ts.idcard = dr.IsDBNull(5) ? null : dr.GetString(5);
                        DataList.Add(ts);
                    }
                }
                return DataList;
            }






        }
    }
}

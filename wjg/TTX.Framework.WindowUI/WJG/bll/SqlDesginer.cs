using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
namespace WJG.bll
{
    class SqlDiginer
    {
        private static String  connStr = ConfigurationManager.ConnectionStrings["WJG.Properties.Settings.skcclocksystemConnectionString"].ConnectionString;
        ///<summary>
        ///返回受影响的行数
        ///</summary>
        ///<param name="sql"></param>
        ///<return>int</return>
        public static int ExecuteNoQuery(String sql)
        {
            using (SqlConnection conn=new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    return cmd.ExecuteNonQuery();
                }

            }            
        }
        ///<summary>
        ///返回一个数据集
        ///</summary>
        ///<param name="sql"></param>
        ///<return></return>
         public static DataSet excuteDataset(String sql)
        {
            using (SqlConnection conn=new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);
                    return dataset;
                }

            }
        }

        public static object executeScalar(String sql)
        {
            using (SqlConnection conn=new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd=conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    return cmd.ExecuteScalar();
                    
                }
            }
          
        }
        ///<summary>
        ///md5加密       universe 宇宙  reverse反转   reserve 保留
        /// </summary>
        /// <param name="pwd"></param>
        /// <return></return>
         public static string getMD5(String strpwd)
        {
            String pwd = "";
            //实例化md5对象
            MD5 md5 = MD5.Create();
            //加密后是一个字节类型的数组
            byte[] b = md5.ComputeHash(Encoding.UTF8.GetBytes(strpwd));
            //反转一下字节数组
            b.Reverse();
            //循环，
            for (int i=3;i<b.Length-1;i++)
            {
                //将得到的字符串使用16进制类型格式，格式后的字符是小写的字母。如果使用的是大写的X就是大写的字母。
                pwd = pwd + (b[i] < 198 ? b[i] + 28 : b[i]).ToString("X");
            }
            return pwd;
        }
       public class dept
        {
            public string  Name { get; set; }
            public int  Value { get; set; }
            public List<dept> lessons { get; set; }
        }

        public  static List<dept> DeptTreeData(int len=3)
        {
            
            List<dept> list = new List<dept>();
            for (int i=0;i<len; i++)
            {
                dept dept = new dept();
                DataSet set = excuteDataset("select * from [skcclocksystem].[dbo].[stj_dept]");
                 dept.Name=set.Tables[0].Rows[i][0].ToString();
                dept.Value = (int)set.Tables[0].Rows[i][1];
                dept.lessons = new List<dept>();
                DataSet lessonset = excuteDataset("select * from [skcclocksystem].[dbo].[stj_lesson] where number='"+(i+1)+"'");
                int count = lessonset.Tables[0].Rows.Count;
                for (int j=0;j<count; j++)
                {
                    dept dept2 = new dept();
                    dept2.Name = lessonset.Tables[0].Rows[j][0].ToString();
                    dept2.Value = j;
                    dept.lessons.Add(dept2);
                //    dept.lessons.Add(lessonset.Tables[0].Rows[j][0].ToString());
                }
                list.Add(dept);
            }
            return list;
           
        }
      
    }
}

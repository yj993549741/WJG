using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using
using System.Linq.Expressions;

namespace WindowsTest
{
    public class TestData
    {
        public static String[] dept1 = new string[] { "MFG", "ASSY", "SUPP", "第三方" };
        public static String[] lesson = new string[] { };

        public static List<Dept> GetTreeData(int len = 3)
        {
            List<Dept> us = new List<Dept>();
            for (int i = 0; i < len; i++)
            {
                Dept u1 = new Dept();
                u1.Value = i;
                u1.Name = dept1[i];
                u1.Depts = new List<Dept>();
                for (int n = 0; n < len; n++)
                {
                    Dept u2 =new Dept();
                    u2.Name = u1.Name + "_" + n;
                    u2.Value = n;
                    u1.Depts.Add(u2);
                }
                us.Add(u1);
            }
            return us;
        }
      
         public class ExpressionGenericMapper<TIn, TOut>//Mapper`2 //正对于每两个不同类型的组合都会生成副本
        {
            private static Func<TIn, TOut> _FUNC = null;// 在每个副本中都有一个委托
            static ExpressionGenericMapper() //静态构造函数 生成表达式目录树 
            {
                ParameterExpression parameterExpression = Expression.Parameter(typeof(TIn), "p");
                List<MemberBinding> memberBindingList = new List<MemberBinding>();
                foreach (var item in typeof(TOut).GetProperties())
                {
                    MemberExpression property = Expression.Property(parameterExpression, typeof(TIn).GetProperty(item.Name));
                    MemberBinding memberBinding = Expression.Bind(item, property);
                    memberBindingList.Add(memberBinding);
                }
                foreach (var item in typeof(TOut).GetFields())
                {
                    MemberExpression property = Expression.Field(parameterExpression, typeof(TIn).GetField(item.Name));
                    MemberBinding memberBinding = Expression.Bind(item, property);
                    memberBindingList.Add(memberBinding);
                }
                MemberInitExpression memberInitExpression = Expression.MemberInit(Expression.New(typeof(TOut)), memberBindingList.ToArray());
                Expression<Func<TIn, TOut>> lambda = Expression.Lambda<Func<TIn, TOut>>(memberInitExpression, new ParameterExpression[]
                {
                    parameterExpression
                });
                _FUNC = lambda.Compile();//拼装是一次性的   转换成委托以后放入副本的静态变量中去
            }
            public static TOut Trans(TIn t) // 直接获取副本的静态变量（委托）
            {
                return _FUNC(t);
            }
        }


        public class Dept
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public List<Dept> Depts { get; set; }
    }
    public class Lesson
    {
        public String lessonName { get; set; }
    }
}

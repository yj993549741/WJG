using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WJG.model
{
    class personnelField
    {

        //查询的字段名称
        public string FieldName
        { get; set; }

        //查询的运算符
        public Operater Op
        { get; set; }

        //查询的值
        public string Value
        { get; set; }

    }
    //运算符的枚举
    public enum Operater
    {
        Qt,
        Lt,
        Eq,
        like
    }


    
}

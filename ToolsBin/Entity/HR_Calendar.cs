
/* 
 本类由PWMIS 实体类生成工具(适用于 PWMIS.Core Version: 5.3 以上)自动生成
 http://www.pwmis.com/sqlmap
 使用前请先在项目工程中引用 PWMIS.Core.dll
 2016/7/22 17:10:45
*/

using System;
using PWMIS.Common;
using PWMIS.DataMap.Entity;

namespace BPM_K2Sln 
{
  [Serializable()]
  public partial class HR_Calendar : EntityBase
  {
    public HR_Calendar()
    {
            TableName = "HR_Calendar";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="IDx";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("IDx");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "IDx","HolidayDate","Remark","Category" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Int32 IDx
      {
          get{return getProperty<System.Int32>("IDx");}
          set{setProperty("IDx",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime HolidayDate
      {
          get{return getProperty<System.DateTime>("HolidayDate");}
          set{setProperty("HolidayDate",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Remark
      {
          get{return getProperty<System.String>("Remark");}
          set{setProperty("Remark",value ,150);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Category
      {
          get{return getProperty<System.String>("Category");}
          set{setProperty("Category",value ,50);}
      }


  }
}

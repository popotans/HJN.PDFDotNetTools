
/* 
 本类由PWMIS 实体类生成工具(适用于 PWMIS.Core Version: 5.3 以上)自动生成
 http://www.pwmis.com/sqlmap
 使用前请先在项目工程中引用 PWMIS.Core.dll
 2016/7/22 17:10:46
*/

using System;
using PWMIS.Common;
using PWMIS.DataMap.Entity;

namespace BPM_K2Sln 
{
  [Serializable()]
  public partial class K2_ProcessWorkCalendar : EntityBase
  {
    public K2_ProcessWorkCalendar()
    {
            TableName = "K2_ProcessWorkCalendar";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="DayId";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("DayId");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "DayId","WorkDay","StartTime","EndTime","WorkHour","IsWorkDay" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Int32 DayId
      {
          get{return getProperty<System.Int32>("DayId");}
          set{setProperty("DayId",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime WorkDay
      {
          get{return getProperty<System.DateTime>("WorkDay");}
          set{setProperty("WorkDay",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime StartTime
      {
          get{return getProperty<System.DateTime>("StartTime");}
          set{setProperty("StartTime",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime EndTime
      {
          get{return getProperty<System.DateTime>("EndTime");}
          set{setProperty("EndTime",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 WorkHour
      {
          get{return getProperty<System.Int32>("WorkHour");}
          set{setProperty("WorkHour",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 IsWorkDay
      {
          get{return getProperty<System.Int32>("IsWorkDay");}
          set{setProperty("IsWorkDay",value );}
      }


  }
}


/* 
 本类由PWMIS 实体类生成工具(适用于 PWMIS.Core Version: 5.3 以上)自动生成
 http://www.pwmis.com/sqlmap
 使用前请先在项目工程中引用 PWMIS.Core.dll
 2016/7/22 17:10:47
*/

using System;
using PWMIS.Common;
using PWMIS.DataMap.Entity;

namespace BPM_K2Sln 
{
  [Serializable()]
  public partial class K2_StatisticProcessActivity : EntityBase
  {
    public K2_StatisticProcessActivity()
    {
            TableName = "K2_StatisticProcessActivity";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="StatisticId";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("StatisticId");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "StatisticId","StatMonth","ProcessCode","ProcessName","ActivityCode","ActivityName","AllCount","AvgDowithTime" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Int32 StatisticId
      {
          get{return getProperty<System.Int32>("StatisticId");}
          set{setProperty("StatisticId",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String StatMonth
      {
          get{return getProperty<System.String>("StatMonth");}
          set{setProperty("StatMonth",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ProcessCode
      {
          get{return getProperty<System.String>("ProcessCode");}
          set{setProperty("ProcessCode",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ProcessName
      {
          get{return getProperty<System.String>("ProcessName");}
          set{setProperty("ProcessName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ActivityCode
      {
          get{return getProperty<System.String>("ActivityCode");}
          set{setProperty("ActivityCode",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ActivityName
      {
          get{return getProperty<System.String>("ActivityName");}
          set{setProperty("ActivityName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 AllCount
      {
          get{return getProperty<System.Int32>("AllCount");}
          set{setProperty("AllCount",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Decimal AvgDowithTime
      {
          get{return getProperty<System.Decimal>("AvgDowithTime");}
          set{setProperty("AvgDowithTime",value );}
      }


  }
}

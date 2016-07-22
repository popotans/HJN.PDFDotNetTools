
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
  public partial class K2_Folio : EntityBase
  {
    public K2_Folio()
    {
            TableName = "K2_Folio";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="ID";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("ID");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "ID","ProcessCode","PreTarget","Year","Month","Day","Orders","Folio","CreateTime" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Int32 ID
      {
          get{return getProperty<System.Int32>("ID");}
          set{setProperty("ID",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ProcessCode
      {
          get{return getProperty<System.String>("ProcessCode");}
          set{setProperty("ProcessCode",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String PreTarget
      {
          get{return getProperty<System.String>("PreTarget");}
          set{setProperty("PreTarget",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 Year
      {
          get{return getProperty<System.Int32>("Year");}
          set{setProperty("Year",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 Month
      {
          get{return getProperty<System.Int32>("Month");}
          set{setProperty("Month",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 Day
      {
          get{return getProperty<System.Int32>("Day");}
          set{setProperty("Day",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 Orders
      {
          get{return getProperty<System.Int32>("Orders");}
          set{setProperty("Orders",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Folio
      {
          get{return getProperty<System.String>("Folio");}
          set{setProperty("Folio",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime CreateTime
      {
          get{return getProperty<System.DateTime>("CreateTime");}
          set{setProperty("CreateTime",value );}
      }


  }
}

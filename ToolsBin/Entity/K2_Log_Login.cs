
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
  public partial class K2_Log_Login : EntityBase
  {
    public K2_Log_Login()
    {
            TableName = "K2_Log_Login";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="LogId";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("LogId");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "LogId","SystemCode","LoginName","UserName","LoginTime","ServerName","ClentIp","Remark","Ext1","Ext2" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Int32 LogId
      {
          get{return getProperty<System.Int32>("LogId");}
          set{setProperty("LogId",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String SystemCode
      {
          get{return getProperty<System.String>("SystemCode");}
          set{setProperty("SystemCode",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String LoginName
      {
          get{return getProperty<System.String>("LoginName");}
          set{setProperty("LoginName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String UserName
      {
          get{return getProperty<System.String>("UserName");}
          set{setProperty("UserName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime LoginTime
      {
          get{return getProperty<System.DateTime>("LoginTime");}
          set{setProperty("LoginTime",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ServerName
      {
          get{return getProperty<System.String>("ServerName");}
          set{setProperty("ServerName",value ,3000);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ClentIp
      {
          get{return getProperty<System.String>("ClentIp");}
          set{setProperty("ClentIp",value ,3000);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Remark
      {
          get{return getProperty<System.String>("Remark");}
          set{setProperty("Remark",value ,3000);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext1
      {
          get{return getProperty<System.String>("Ext1");}
          set{setProperty("Ext1",value ,3000);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext2
      {
          get{return getProperty<System.String>("Ext2");}
          set{setProperty("Ext2",value ,3000);}
      }


  }
}

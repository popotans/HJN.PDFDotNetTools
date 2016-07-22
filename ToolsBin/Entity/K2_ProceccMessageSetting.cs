
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
  public partial class K2_ProceccMessageSetting : EntityBase
  {
    public K2_ProceccMessageSetting()
    {
            TableName = "K2_ProceccMessageSetting";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("SettingId");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "SettingId","loginName","UserName","ProcName","ProcCode","SettingType","Email","IM","SMS","State","CreateBy","CreateDate","LastModifyBy","LastModifyDate","Ext1","Ext2" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Guid SettingId
      {
          get{return getProperty<System.Guid>("SettingId");}
          set{setProperty("SettingId",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String loginName
      {
          get{return getProperty<System.String>("loginName");}
          set{setProperty("loginName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String UserName
      {
          get{return getProperty<System.String>("UserName");}
          set{setProperty("UserName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ProcName
      {
          get{return getProperty<System.String>("ProcName");}
          set{setProperty("ProcName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ProcCode
      {
          get{return getProperty<System.String>("ProcCode");}
          set{setProperty("ProcCode",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String SettingType
      {
          get{return getProperty<System.String>("SettingType");}
          set{setProperty("SettingType",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Boolean Email
      {
          get{return getProperty<System.Boolean>("Email");}
          set{setProperty("Email",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Boolean IM
      {
          get{return getProperty<System.Boolean>("IM");}
          set{setProperty("IM",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Boolean SMS
      {
          get{return getProperty<System.Boolean>("SMS");}
          set{setProperty("SMS",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String State
      {
          get{return getProperty<System.String>("State");}
          set{setProperty("State",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String CreateBy
      {
          get{return getProperty<System.String>("CreateBy");}
          set{setProperty("CreateBy",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime CreateDate
      {
          get{return getProperty<System.DateTime>("CreateDate");}
          set{setProperty("CreateDate",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String LastModifyBy
      {
          get{return getProperty<System.String>("LastModifyBy");}
          set{setProperty("LastModifyBy",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime LastModifyDate
      {
          get{return getProperty<System.DateTime>("LastModifyDate");}
          set{setProperty("LastModifyDate",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext1
      {
          get{return getProperty<System.String>("Ext1");}
          set{setProperty("Ext1",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext2
      {
          get{return getProperty<System.String>("Ext2");}
          set{setProperty("Ext2",value ,50);}
      }


  }
}

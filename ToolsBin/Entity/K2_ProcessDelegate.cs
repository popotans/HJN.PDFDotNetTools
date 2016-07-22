
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
  public partial class K2_ProcessDelegate : EntityBase
  {
    public K2_ProcessDelegate()
    {
            TableName = "K2_ProcessDelegate";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("DelegateId");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "DelegateId","ProcessId","FormUserName","FormLoginName","ToUserName","ToLoginName","StarTime","EndTime","DelegateStatus","IncludeFlow","ExcludeFlow","Remark","CreateBy","CreateDate","LastModifyBy","LastModifyDate" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Guid DelegateId
      {
          get{return getProperty<System.Guid>("DelegateId");}
          set{setProperty("DelegateId",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Guid ProcessId
      {
          get{return getProperty<System.Guid>("ProcessId");}
          set{setProperty("ProcessId",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String FormUserName
      {
          get{return getProperty<System.String>("FormUserName");}
          set{setProperty("FormUserName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String FormLoginName
      {
          get{return getProperty<System.String>("FormLoginName");}
          set{setProperty("FormLoginName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ToUserName
      {
          get{return getProperty<System.String>("ToUserName");}
          set{setProperty("ToUserName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ToLoginName
      {
          get{return getProperty<System.String>("ToLoginName");}
          set{setProperty("ToLoginName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime StarTime
      {
          get{return getProperty<System.DateTime>("StarTime");}
          set{setProperty("StarTime",value );}
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
      public System.Int32 DelegateStatus
      {
          get{return getProperty<System.Int32>("DelegateStatus");}
          set{setProperty("DelegateStatus",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String IncludeFlow
      {
          get{return getProperty<System.String>("IncludeFlow");}
          set{setProperty("IncludeFlow",value ,3000);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ExcludeFlow
      {
          get{return getProperty<System.String>("ExcludeFlow");}
          set{setProperty("ExcludeFlow",value ,2000);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Remark
      {
          get{return getProperty<System.String>("Remark");}
          set{setProperty("Remark",value ,100);}
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


  }
}

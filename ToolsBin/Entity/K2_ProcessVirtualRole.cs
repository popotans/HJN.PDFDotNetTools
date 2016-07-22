
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
  public partial class K2_ProcessVirtualRole : EntityBase
  {
    public K2_ProcessVirtualRole()
    {
            TableName = "K2_ProcessVirtualRole";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("RoleId");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "RoleId","ProcessId","RoleCode","RoleName","ClassCode","ClassName","SpecialCode","SpecialName","LoginName","UserName","Remark","CreateBy","CreateDate","LastModifyBy","LastModifyDate" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Guid RoleId
      {
          get{return getProperty<System.Guid>("RoleId");}
          set{setProperty("RoleId",value );}
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
      public System.String RoleCode
      {
          get{return getProperty<System.String>("RoleCode");}
          set{setProperty("RoleCode",value ,500);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String RoleName
      {
          get{return getProperty<System.String>("RoleName");}
          set{setProperty("RoleName",value ,500);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ClassCode
      {
          get{return getProperty<System.String>("ClassCode");}
          set{setProperty("ClassCode",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ClassName
      {
          get{return getProperty<System.String>("ClassName");}
          set{setProperty("ClassName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String SpecialCode
      {
          get{return getProperty<System.String>("SpecialCode");}
          set{setProperty("SpecialCode",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String SpecialName
      {
          get{return getProperty<System.String>("SpecialName");}
          set{setProperty("SpecialName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String LoginName
      {
          get{return getProperty<System.String>("LoginName");}
          set{setProperty("LoginName",value ,50);}
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
          set{setProperty("CreateBy",value ,10);}
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
          set{setProperty("LastModifyBy",value ,10);}
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

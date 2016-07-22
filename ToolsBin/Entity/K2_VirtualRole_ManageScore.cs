
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
  public partial class K2_VirtualRole_ManageScore : EntityBase
  {
    public K2_VirtualRole_ManageScore()
    {
            TableName = "K2_VirtualRole_ManageScore";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="Idx";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("Idx");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "Idx","LoginName","UserName","UserAccount","ManageScore","ManageName","CompanyCode","CompanyName","OrgCode","OrgName","IsDisabled","CreateBy","CreateDate","LastModifyBy","LastModifyDate" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Int32 Idx
      {
          get{return getProperty<System.Int32>("Idx");}
          set{setProperty("Idx",value );}
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
      public System.String UserAccount
      {
          get{return getProperty<System.String>("UserAccount");}
          set{setProperty("UserAccount",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 ManageScore
      {
          get{return getProperty<System.Int32>("ManageScore");}
          set{setProperty("ManageScore",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ManageName
      {
          get{return getProperty<System.String>("ManageName");}
          set{setProperty("ManageName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String CompanyCode
      {
          get{return getProperty<System.String>("CompanyCode");}
          set{setProperty("CompanyCode",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String CompanyName
      {
          get{return getProperty<System.String>("CompanyName");}
          set{setProperty("CompanyName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String OrgCode
      {
          get{return getProperty<System.String>("OrgCode");}
          set{setProperty("OrgCode",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String OrgName
      {
          get{return getProperty<System.String>("OrgName");}
          set{setProperty("OrgName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Boolean IsDisabled
      {
          get{return getProperty<System.Boolean>("IsDisabled");}
          set{setProperty("IsDisabled",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String CreateBy
      {
          get{return getProperty<System.String>("CreateBy");}
          set{setProperty("CreateBy",value ,30);}
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
          set{setProperty("LastModifyBy",value ,30);}
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

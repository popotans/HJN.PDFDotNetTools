
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
  public partial class K2_RoleOrg : EntityBase
  {
    public K2_RoleOrg()
    {
            TableName = "K2_RoleOrg";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="ID";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("ID");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "ID","RoleCode","OrgCode","EmpUserID","EmpName" };
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
      public System.String RoleCode
      {
          get{return getProperty<System.String>("RoleCode");}
          set{setProperty("RoleCode",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String OrgCode
      {
          get{return getProperty<System.String>("OrgCode");}
          set{setProperty("OrgCode",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String EmpUserID
      {
          get{return getProperty<System.String>("EmpUserID");}
          set{setProperty("EmpUserID",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String EmpName
      {
          get{return getProperty<System.String>("EmpName");}
          set{setProperty("EmpName",value ,50);}
      }


  }
}

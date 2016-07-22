
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
  public partial class K2_ViewPermission : EntityBase
  {
    public K2_ViewPermission()
    {
            TableName = "K2_ViewPermission";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="ID";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("ID");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "ID","EmployeeID","EName","ViewFlow","ViewFlowType" };
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
      public System.String EmployeeID
      {
          get{return getProperty<System.String>("EmployeeID");}
          set{setProperty("EmployeeID",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String EName
      {
          get{return getProperty<System.String>("EName");}
          set{setProperty("EName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ViewFlow
      {
          get{return getProperty<System.String>("ViewFlow");}
          set{setProperty("ViewFlow",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ViewFlowType
      {
          get{return getProperty<System.String>("ViewFlowType");}
          set{setProperty("ViewFlowType",value ,50);}
      }


  }
}

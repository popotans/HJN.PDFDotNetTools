
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
  public partial class K2_ProcessCommon : EntityBase
  {
    public K2_ProcessCommon()
    {
            TableName = "K2_ProcessCommon";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="CommonID";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("CommonID");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "CommonID","ProcessCode","LoginID","OrderIndex" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Int32 CommonID
      {
          get{return getProperty<System.Int32>("CommonID");}
          set{setProperty("CommonID",value );}
      }

      /// <summary>
      /// 流程代码
      /// </summary>
      public System.String ProcessCode
      {
          get{return getProperty<System.String>("ProcessCode");}
          set{setProperty("ProcessCode",value ,50);}
      }

      /// <summary>
      /// 用户ID
      /// </summary>
      public System.String LoginID
      {
          get{return getProperty<System.String>("LoginID");}
          set{setProperty("LoginID",value ,50);}
      }

      /// <summary>
      /// 排序
      /// </summary>
      public System.Int32 OrderIndex
      {
          get{return getProperty<System.Int32>("OrderIndex");}
          set{setProperty("OrderIndex",value );}
      }


  }
}

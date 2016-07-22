
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
  public partial class K2_ProcInstQueryData : EntityBase
  {
    public K2_ProcInstQueryData()
    {
            TableName = "K2_ProcInstQueryData";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="ID";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("ID");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "ID","ProcInstID","ProcessCode","QueryKey","QueryValue","ProcType" };
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
      public System.String ProcInstID
      {
          get{return getProperty<System.String>("ProcInstID");}
          set{setProperty("ProcInstID",value ,50);}
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
      public System.String QueryKey
      {
          get{return getProperty<System.String>("QueryKey");}
          set{setProperty("QueryKey",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String QueryValue
      {
          get{return getProperty<System.String>("QueryValue");}
          set{setProperty("QueryValue",value ,2000);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 ProcType
      {
          get{return getProperty<System.Int32>("ProcType");}
          set{setProperty("ProcType",value );}
      }


  }
}

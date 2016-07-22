
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
  public partial class K2_ProcessDraft : EntityBase
  {
    public K2_ProcessDraft()
    {
            TableName = "K2_ProcessDraft";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="ProcessDraftID";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("ProcessDraftID");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "ProcessDraftID","ProcessCode","Guid","Status","AddDate","LoginID" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Int32 ProcessDraftID
      {
          get{return getProperty<System.Int32>("ProcessDraftID");}
          set{setProperty("ProcessDraftID",value );}
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
      public System.Guid Guid
      {
          get{return getProperty<System.Guid>("Guid");}
          set{setProperty("Guid",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 Status
      {
          get{return getProperty<System.Int32>("Status");}
          set{setProperty("Status",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime AddDate
      {
          get{return getProperty<System.DateTime>("AddDate");}
          set{setProperty("AddDate",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String LoginID
      {
          get{return getProperty<System.String>("LoginID");}
          set{setProperty("LoginID",value ,50);}
      }


  }
}

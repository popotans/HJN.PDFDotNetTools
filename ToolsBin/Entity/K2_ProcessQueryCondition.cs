
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
  public partial class K2_ProcessQueryCondition : EntityBase
  {
    public K2_ProcessQueryCondition()
    {
            TableName = "K2_ProcessQueryCondition";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("QueryConditionId");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "QueryConditionId","ProcessId","ColumnCode","ColumnName","OriginalData","Remark","CreateBy","CreateDate","LastModifyBy","LastModifyDate" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Guid QueryConditionId
      {
          get{return getProperty<System.Guid>("QueryConditionId");}
          set{setProperty("QueryConditionId",value );}
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
      public System.String ColumnCode
      {
          get{return getProperty<System.String>("ColumnCode");}
          set{setProperty("ColumnCode",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ColumnName
      {
          get{return getProperty<System.String>("ColumnName");}
          set{setProperty("ColumnName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 OriginalData
      {
          get{return getProperty<System.Int32>("OriginalData");}
          set{setProperty("OriginalData",value );}
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

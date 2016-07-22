
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
  public partial class K2_ProcessSubjectWechat : EntityBase
  {
    public K2_ProcessSubjectWechat()
    {
            TableName = "K2_ProcessSubjectWechat";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("SubjectId");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "SubjectId","ProcessId","ColumnCode","ColumnName","BizTableName","DataRender","DataType","Condition","OriginalData","DisOrder","DetailTableTitle","Remark","CreateBy","CreateDate","LastModifyBy","LastModifyDate" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Guid SubjectId
      {
          get{return getProperty<System.Guid>("SubjectId");}
          set{setProperty("SubjectId",value );}
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
      public System.String BizTableName
      {
          get{return getProperty<System.String>("BizTableName");}
          set{setProperty("BizTableName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String DataRender
      {
          get{return getProperty<System.String>("DataRender");}
          set{setProperty("DataRender",value ,2000);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String DataType
      {
          get{return getProperty<System.String>("DataType");}
          set{setProperty("DataType",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Condition
      {
          get{return getProperty<System.String>("Condition");}
          set{setProperty("Condition",value ,300);}
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
      public System.Int32 DisOrder
      {
          get{return getProperty<System.Int32>("DisOrder");}
          set{setProperty("DisOrder",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String DetailTableTitle
      {
          get{return getProperty<System.String>("DetailTableTitle");}
          set{setProperty("DetailTableTitle",value ,50);}
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

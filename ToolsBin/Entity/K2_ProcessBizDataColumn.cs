
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
  public partial class K2_ProcessBizDataColumn : EntityBase
  {
    public K2_ProcessBizDataColumn()
    {
            TableName = "K2_ProcessBizDataColumn";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("ColumnId");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "ColumnId","TableId","ColumnCode","ColumnName","IsRead","IsWrite","CreateTime","CreateBy","LastModifyTime","LastModifyBy" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Guid ColumnId
      {
          get{return getProperty<System.Guid>("ColumnId");}
          set{setProperty("ColumnId",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Guid TableId
      {
          get{return getProperty<System.Guid>("TableId");}
          set{setProperty("TableId",value );}
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
      public System.Int32 IsRead
      {
          get{return getProperty<System.Int32>("IsRead");}
          set{setProperty("IsRead",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 IsWrite
      {
          get{return getProperty<System.Int32>("IsWrite");}
          set{setProperty("IsWrite",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime CreateTime
      {
          get{return getProperty<System.DateTime>("CreateTime");}
          set{setProperty("CreateTime",value );}
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
      public System.DateTime LastModifyTime
      {
          get{return getProperty<System.DateTime>("LastModifyTime");}
          set{setProperty("LastModifyTime",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String LastModifyBy
      {
          get{return getProperty<System.String>("LastModifyBy");}
          set{setProperty("LastModifyBy",value ,50);}
      }


  }
}

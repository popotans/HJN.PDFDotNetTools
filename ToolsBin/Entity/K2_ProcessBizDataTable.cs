
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
  public partial class K2_ProcessBizDataTable : EntityBase
  {
    public K2_ProcessBizDataTable()
    {
            TableName = "K2_ProcessBizDataTable";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("TableId");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "TableId","TableCode","TableName","PrimaryKey","Remark","CreateTime","CreateBy","LastModifyTime","LastModifyBy","Ext1","Ext2" };
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
      public System.String TableCode
      {
          get{return getProperty<System.String>("TableCode");}
          set{setProperty("TableCode",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String TableName
      {
          get{return getProperty<System.String>("TableName");}
          set{setProperty("TableName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String PrimaryKey
      {
          get{return getProperty<System.String>("PrimaryKey");}
          set{setProperty("PrimaryKey",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Remark
      {
          get{return getProperty<System.String>("Remark");}
          set{setProperty("Remark",value ,1000);}
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
          set{setProperty("CreateBy",value ,100);}
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
          set{setProperty("LastModifyBy",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext1
      {
          get{return getProperty<System.String>("Ext1");}
          set{setProperty("Ext1",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext2
      {
          get{return getProperty<System.String>("Ext2");}
          set{setProperty("Ext2",value ,100);}
      }


  }
}

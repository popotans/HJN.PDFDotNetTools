
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
  public partial class K2_ProcessCategory : EntityBase
  {
    public K2_ProcessCategory()
    {
            TableName = "K2_ProcessCategory";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("CategoryId");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "CategoryId","CategoryCode","CategoryName","DisOrder","OrgCode","OrgName","OrgType","Remark","CreateBy","CreateDate","LastModifyBy","LastModifyDate" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Guid CategoryId
      {
          get{return getProperty<System.Guid>("CategoryId");}
          set{setProperty("CategoryId",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String CategoryCode
      {
          get{return getProperty<System.String>("CategoryCode");}
          set{setProperty("CategoryCode",value ,10);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String CategoryName
      {
          get{return getProperty<System.String>("CategoryName");}
          set{setProperty("CategoryName",value ,50);}
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
      public System.String OrgCode
      {
          get{return getProperty<System.String>("OrgCode");}
          set{setProperty("OrgCode",value ,50);}
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
      public System.Int32 OrgType
      {
          get{return getProperty<System.Int32>("OrgType");}
          set{setProperty("OrgType",value );}
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

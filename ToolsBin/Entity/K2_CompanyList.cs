
/* 
 本类由PWMIS 实体类生成工具(适用于 PWMIS.Core Version: 5.3 以上)自动生成
 http://www.pwmis.com/sqlmap
 使用前请先在项目工程中引用 PWMIS.Core.dll
 2016/7/22 17:10:45
*/

using System;
using PWMIS.Common;
using PWMIS.DataMap.Entity;

namespace BPM_K2Sln 
{
  [Serializable()]
  public partial class K2_CompanyList : EntityBase
  {
    public K2_CompanyList()
    {
            TableName = "K2_CompanyList";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("ID");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "ID","CompanyCode","CompanyNCCode","CompanyNCNumCode","CompanyName","GsLx","DisplayOrder","NcType","IsDisabled","IsECAuth","SDLCompanyCode","NoAuthProcessCode","AuthProcessCode","CompanyOrder","CreateDate","CreateBy" };
      }



      /// <summary>
      /// 公司表主键ID，默认GUID
      /// </summary>
      public System.Guid ID
      {
          get{return getProperty<System.Guid>("ID");}
          set{setProperty("ID",value );}
      }

      /// <summary>
      /// 公司编码
      /// </summary>
      public System.String CompanyCode
      {
          get{return getProperty<System.String>("CompanyCode");}
          set{setProperty("CompanyCode",value ,100);}
      }

      /// <summary>
      /// NC中对应的公司编码
      /// </summary>
      public System.String CompanyNCCode
      {
          get{return getProperty<System.String>("CompanyNCCode");}
          set{setProperty("CompanyNCCode",value ,100);}
      }

      /// <summary>
      /// NC中对应公司的数字编码
      /// </summary>
      public System.String CompanyNCNumCode
      {
          get{return getProperty<System.String>("CompanyNCNumCode");}
          set{setProperty("CompanyNCNumCode",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String CompanyName
      {
          get{return getProperty<System.String>("CompanyName");}
          set{setProperty("CompanyName",value ,500);}
      }

      /// <summary>
      /// 公司类型1总部，2 分子公司
      /// </summary>
      public System.Int32 GsLx
      {
          get{return getProperty<System.Int32>("GsLx");}
          set{setProperty("GsLx",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 DisplayOrder
      {
          get{return getProperty<System.Int32>("DisplayOrder");}
          set{setProperty("DisplayOrder",value );}
      }

      /// <summary>
      /// 表示该公司是属于NC63还是NC55,或者都不是
      /// </summary>
      public System.String NcType
      {
          get{return getProperty<System.String>("NcType");}
          set{setProperty("NcType",value ,50);}
      }

      /// <summary>
      /// 表示该公司是否停用
      /// </summary>
      public System.Boolean IsDisabled
      {
          get{return getProperty<System.Boolean>("IsDisabled");}
          set{setProperty("IsDisabled",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 IsECAuth
      {
          get{return getProperty<System.Int32>("IsECAuth");}
          set{setProperty("IsECAuth",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String SDLCompanyCode
      {
          get{return getProperty<System.String>("SDLCompanyCode");}
          set{setProperty("SDLCompanyCode",value ,50);}
      }

      /// <summary>
      /// 没有权限的流程编码,该公司对某些流程不开放
      /// </summary>
      public System.String NoAuthProcessCode
      {
          get{return getProperty<System.String>("NoAuthProcessCode");}
          set{setProperty("NoAuthProcessCode",value ,800);}
      }

      /// <summary>
      /// 有权限的流程编码,该公司对某些流程开放
      /// </summary>
      public System.String AuthProcessCode
      {
          get{return getProperty<System.String>("AuthProcessCode");}
          set{setProperty("AuthProcessCode",value ,800);}
      }

      /// <summary>
      /// 序列
      /// </summary>
      public System.Int32 CompanyOrder
      {
          get{return getProperty<System.Int32>("CompanyOrder");}
          set{setProperty("CompanyOrder",value );}
      }

      /// <summary>
      /// 创建时间
      /// </summary>
      public System.DateTime CreateDate
      {
          get{return getProperty<System.DateTime>("CreateDate");}
          set{setProperty("CreateDate",value );}
      }

      /// <summary>
      /// 创建人
      /// </summary>
      public System.String CreateBy
      {
          get{return getProperty<System.String>("CreateBy");}
          set{setProperty("CreateBy",value ,100);}
      }


  }
}

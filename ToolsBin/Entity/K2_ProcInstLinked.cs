
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
  public partial class K2_ProcInstLinked : EntityBase
  {
    public K2_ProcInstLinked()
    {
            TableName = "K2_ProcInstLinked";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="LinkedID";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("LinkedID");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "LinkedID","ProcInstID","Guid","LinkedProcInstID","LinkedProcInstFolio","LinkedProcInstTiltle","LinkedApplyLoinName","LinkedApplyUserName","CreateTime","CreateBy" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Int32 LinkedID
      {
          get{return getProperty<System.Int32>("LinkedID");}
          set{setProperty("LinkedID",value );}
      }

      /// <summary>
      /// 主流程实例ID
      /// </summary>
      public System.Int32 ProcInstID
      {
          get{return getProperty<System.Int32>("ProcInstID");}
          set{setProperty("ProcInstID",value );}
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
      /// 关联流程实例ID
      /// </summary>
      public System.Int32 LinkedProcInstID
      {
          get{return getProperty<System.Int32>("LinkedProcInstID");}
          set{setProperty("LinkedProcInstID",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String LinkedProcInstFolio
      {
          get{return getProperty<System.String>("LinkedProcInstFolio");}
          set{setProperty("LinkedProcInstFolio",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String LinkedProcInstTiltle
      {
          get{return getProperty<System.String>("LinkedProcInstTiltle");}
          set{setProperty("LinkedProcInstTiltle",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String LinkedApplyLoinName
      {
          get{return getProperty<System.String>("LinkedApplyLoinName");}
          set{setProperty("LinkedApplyLoinName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String LinkedApplyUserName
      {
          get{return getProperty<System.String>("LinkedApplyUserName");}
          set{setProperty("LinkedApplyUserName",value ,50);}
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


  }
}

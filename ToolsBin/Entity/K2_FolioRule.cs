
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
  public partial class K2_FolioRule : EntityBase
  {
    public K2_FolioRule()
    {
            TableName = "K2_FolioRule";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="ID";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("ID");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "ID","ProcessCode","PreTarget","ResetByYear","ResetByMonth","CreateTime" };
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
      public System.String ProcessCode
      {
          get{return getProperty<System.String>("ProcessCode");}
          set{setProperty("ProcessCode",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String PreTarget
      {
          get{return getProperty<System.String>("PreTarget");}
          set{setProperty("PreTarget",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Boolean ResetByYear
      {
          get{return getProperty<System.Boolean>("ResetByYear");}
          set{setProperty("ResetByYear",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Boolean ResetByMonth
      {
          get{return getProperty<System.Boolean>("ResetByMonth");}
          set{setProperty("ResetByMonth",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime CreateTime
      {
          get{return getProperty<System.DateTime>("CreateTime");}
          set{setProperty("CreateTime",value );}
      }


  }
}

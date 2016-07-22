
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
  public partial class K2_ProceccMessageTemplate2 : EntityBase
  {
    public K2_ProceccMessageTemplate2()
    {
            TableName = "K2_ProceccMessageTemplate2";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("SettingID");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "SettingID","ProcessNme","ProcessCode","TempCategory","TempCategoryName","TemplateSubject","TemplateBody","CreateTime" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Guid SettingID
      {
          get{return getProperty<System.Guid>("SettingID");}
          set{setProperty("SettingID",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ProcessNme
      {
          get{return getProperty<System.String>("ProcessNme");}
          set{setProperty("ProcessNme",value ,150);}
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
      public System.String TempCategory
      {
          get{return getProperty<System.String>("TempCategory");}
          set{setProperty("TempCategory",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String TempCategoryName
      {
          get{return getProperty<System.String>("TempCategoryName");}
          set{setProperty("TempCategoryName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String TemplateSubject
      {
          get{return getProperty<System.String>("TemplateSubject");}
          set{setProperty("TemplateSubject",value ,500);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String TemplateBody
      {
          get{return getProperty<System.String>("TemplateBody");}
          set{setProperty("TemplateBody",value ,8000);}
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

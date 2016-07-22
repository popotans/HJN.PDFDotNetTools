
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
  public partial class K2_ProcessGuide : EntityBase
  {
    public K2_ProcessGuide()
    {
            TableName = "K2_ProcessGuide";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="ID";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("ID");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "ID","ProcessCode","ProcShowName","GuideTitle","TopNote","UseRange","FormOperate","ActivityNote","RestRemarks","StartPage","ContentTemplate","AttachTemplateID","IsEnabled" };
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
      public System.String ProcShowName
      {
          get{return getProperty<System.String>("ProcShowName");}
          set{setProperty("ProcShowName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String GuideTitle
      {
          get{return getProperty<System.String>("GuideTitle");}
          set{setProperty("GuideTitle",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String TopNote
      {
          get{return getProperty<System.String>("TopNote");}
          set{setProperty("TopNote",value ,2000);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String UseRange
      {
          get{return getProperty<System.String>("UseRange");}
          set{setProperty("UseRange",value ,2000);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String FormOperate
      {
          get{return getProperty<System.String>("FormOperate");}
          set{setProperty("FormOperate",value ,2147483647);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ActivityNote
      {
          get{return getProperty<System.String>("ActivityNote");}
          set{setProperty("ActivityNote",value ,2147483647);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String RestRemarks
      {
          get{return getProperty<System.String>("RestRemarks");}
          set{setProperty("RestRemarks",value ,2000);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String StartPage
      {
          get{return getProperty<System.String>("StartPage");}
          set{setProperty("StartPage",value ,200);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ContentTemplate
      {
          get{return getProperty<System.String>("ContentTemplate");}
          set{setProperty("ContentTemplate",value ,2147483647);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String AttachTemplateID
      {
          get{return getProperty<System.String>("AttachTemplateID");}
          set{setProperty("AttachTemplateID",value ,550);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Boolean IsEnabled
      {
          get{return getProperty<System.Boolean>("IsEnabled");}
          set{setProperty("IsEnabled",value );}
      }


  }
}

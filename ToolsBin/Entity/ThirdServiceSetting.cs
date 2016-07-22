
/* 
 本类由PWMIS 实体类生成工具(适用于 PWMIS.Core Version: 5.3 以上)自动生成
 http://www.pwmis.com/sqlmap
 使用前请先在项目工程中引用 PWMIS.Core.dll
 2016/7/22 17:10:48
*/

using System;
using PWMIS.Common;
using PWMIS.DataMap.Entity;

namespace BPM_K2Sln 
{
  [Serializable()]
  public partial class ThirdServiceSetting : EntityBase
  {
    public ThirdServiceSetting()
    {
            TableName = "ThirdServiceSetting";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="Idx";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("Idx");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "Idx","SKey","Url","Stype","UrlTest","Remark","SecretyKey" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Int32 Idx
      {
          get{return getProperty<System.Int32>("Idx");}
          set{setProperty("Idx",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String SKey
      {
          get{return getProperty<System.String>("SKey");}
          set{setProperty("SKey",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Url
      {
          get{return getProperty<System.String>("Url");}
          set{setProperty("Url",value ,500);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Stype
      {
          get{return getProperty<System.String>("Stype");}
          set{setProperty("Stype",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String UrlTest
      {
          get{return getProperty<System.String>("UrlTest");}
          set{setProperty("UrlTest",value ,500);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Remark
      {
          get{return getProperty<System.String>("Remark");}
          set{setProperty("Remark",value ,150);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String SecretyKey
      {
          get{return getProperty<System.String>("SecretyKey");}
          set{setProperty("SecretyKey",value ,150);}
      }


  }
}

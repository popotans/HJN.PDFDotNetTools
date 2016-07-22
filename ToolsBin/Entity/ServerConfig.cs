
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
  public partial class ServerConfig : EntityBase
  {
    public ServerConfig()
    {
            TableName = "ServerConfig";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="Idx";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("Idx");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "Idx","CKey","CValue","CValueTest","ClassName","GroupName","Remark" };
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
      public System.String CKey
      {
          get{return getProperty<System.String>("CKey");}
          set{setProperty("CKey",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String CValue
      {
          get{return getProperty<System.String>("CValue");}
          set{setProperty("CValue",value ,550);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String CValueTest
      {
          get{return getProperty<System.String>("CValueTest");}
          set{setProperty("CValueTest",value ,550);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ClassName
      {
          get{return getProperty<System.String>("ClassName");}
          set{setProperty("ClassName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String GroupName
      {
          get{return getProperty<System.String>("GroupName");}
          set{setProperty("GroupName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Remark
      {
          get{return getProperty<System.String>("Remark");}
          set{setProperty("Remark",value ,150);}
      }


  }
}

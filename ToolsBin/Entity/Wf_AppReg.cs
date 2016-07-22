
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
  public partial class Wf_AppReg : EntityBase
  {
    public Wf_AppReg()
    {
            TableName = "Wf_AppReg";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="Idx";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("Idx");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "Idx","AppName","AppCode","AppKey","Algorithm" };
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
      public System.String AppName
      {
          get{return getProperty<System.String>("AppName");}
          set{setProperty("AppName",value ,150);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String AppCode
      {
          get{return getProperty<System.String>("AppCode");}
          set{setProperty("AppCode",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String AppKey
      {
          get{return getProperty<System.String>("AppKey");}
          set{setProperty("AppKey",value ,150);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Algorithm
      {
          get{return getProperty<System.String>("Algorithm");}
          set{setProperty("Algorithm",value ,50);}
      }


  }
}

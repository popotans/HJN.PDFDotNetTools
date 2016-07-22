
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
  public partial class K2_Dictionary : EntityBase
  {
    public K2_Dictionary()
    {
            TableName = "K2_Dictionary";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="Idx";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("Idx");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "Idx","ProcessCode","Name","Value","ClassCode","ClassName","GroupCode","GroupName","DisplayOrder" };
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
      public System.String ProcessCode
      {
          get{return getProperty<System.String>("ProcessCode");}
          set{setProperty("ProcessCode",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Name
      {
          get{return getProperty<System.String>("Name");}
          set{setProperty("Name",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Value
      {
          get{return getProperty<System.String>("Value");}
          set{setProperty("Value",value ,550);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ClassCode
      {
          get{return getProperty<System.String>("ClassCode");}
          set{setProperty("ClassCode",value ,50);}
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
      public System.String GroupCode
      {
          get{return getProperty<System.String>("GroupCode");}
          set{setProperty("GroupCode",value ,50);}
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
      public System.Int32 DisplayOrder
      {
          get{return getProperty<System.Int32>("DisplayOrder");}
          set{setProperty("DisplayOrder",value );}
      }


  }
}

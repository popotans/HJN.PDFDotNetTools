
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
  public partial class Sec_Org : EntityBase
  {
    public Sec_Org()
    {
            TableName = "Sec_Org";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="Idx";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("Idx");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "Idx","OrgCode","OrgName","VPId","VpName","SVPId","SVPName","ParentCode" };
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
          set{setProperty("OrgName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String VPId
      {
          get{return getProperty<System.String>("VPId");}
          set{setProperty("VPId",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String VpName
      {
          get{return getProperty<System.String>("VpName");}
          set{setProperty("VpName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String SVPId
      {
          get{return getProperty<System.String>("SVPId");}
          set{setProperty("SVPId",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String SVPName
      {
          get{return getProperty<System.String>("SVPName");}
          set{setProperty("SVPName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ParentCode
      {
          get{return getProperty<System.String>("ParentCode");}
          set{setProperty("ParentCode",value ,50);}
      }


  }
}

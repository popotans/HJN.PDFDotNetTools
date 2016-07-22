
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
  public partial class K2_VirtualGroup : EntityBase
  {
    public K2_VirtualGroup()
    {
            TableName = "K2_VirtualGroup";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "VirtualGroupCode","VirtualGroupName","RoleCode","RoleName","PersonName","PersonLoginID","ProcessCode" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.String VirtualGroupCode
      {
          get{return getProperty<System.String>("VirtualGroupCode");}
          set{setProperty("VirtualGroupCode",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String VirtualGroupName
      {
          get{return getProperty<System.String>("VirtualGroupName");}
          set{setProperty("VirtualGroupName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String RoleCode
      {
          get{return getProperty<System.String>("RoleCode");}
          set{setProperty("RoleCode",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String RoleName
      {
          get{return getProperty<System.String>("RoleName");}
          set{setProperty("RoleName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String PersonName
      {
          get{return getProperty<System.String>("PersonName");}
          set{setProperty("PersonName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String PersonLoginID
      {
          get{return getProperty<System.String>("PersonLoginID");}
          set{setProperty("PersonLoginID",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ProcessCode
      {
          get{return getProperty<System.String>("ProcessCode");}
          set{setProperty("ProcessCode",value ,100);}
      }


  }
}

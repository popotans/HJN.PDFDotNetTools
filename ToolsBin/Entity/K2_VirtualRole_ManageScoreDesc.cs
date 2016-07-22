
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
  public partial class K2_VirtualRole_ManageScoreDesc : EntityBase
  {
    public K2_VirtualRole_ManageScoreDesc()
    {
            TableName = "K2_VirtualRole_ManageScoreDesc";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="Idx";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("Idx");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "Idx","ManageScore","Name" };
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
      public System.Int32 ManageScore
      {
          get{return getProperty<System.Int32>("ManageScore");}
          set{setProperty("ManageScore",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Name
      {
          get{return getProperty<System.String>("Name");}
          set{setProperty("Name",value ,100);}
      }


  }
}


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
  public partial class K2_ProcInstAddedApproval : EntityBase
  {
    public K2_ProcInstAddedApproval()
    {
            TableName = "K2_ProcInstAddedApproval";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("ID");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "ID","SN","ProcInstId","ApprovrUser","ApprovrUserName","AddApproveUser","DelegateUser","ApprovedOrder","ApprovedStatus","CreateTime","UpdateTime" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Guid ID
      {
          get{return getProperty<System.Guid>("ID");}
          set{setProperty("ID",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String SN
      {
          get{return getProperty<System.String>("SN");}
          set{setProperty("SN",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 ProcInstId
      {
          get{return getProperty<System.Int32>("ProcInstId");}
          set{setProperty("ProcInstId",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ApprovrUser
      {
          get{return getProperty<System.String>("ApprovrUser");}
          set{setProperty("ApprovrUser",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ApprovrUserName
      {
          get{return getProperty<System.String>("ApprovrUserName");}
          set{setProperty("ApprovrUserName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String AddApproveUser
      {
          get{return getProperty<System.String>("AddApproveUser");}
          set{setProperty("AddApproveUser",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String DelegateUser
      {
          get{return getProperty<System.String>("DelegateUser");}
          set{setProperty("DelegateUser",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 ApprovedOrder
      {
          get{return getProperty<System.Int32>("ApprovedOrder");}
          set{setProperty("ApprovedOrder",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 ApprovedStatus
      {
          get{return getProperty<System.Int32>("ApprovedStatus");}
          set{setProperty("ApprovedStatus",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime CreateTime
      {
          get{return getProperty<System.DateTime>("CreateTime");}
          set{setProperty("CreateTime",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime UpdateTime
      {
          get{return getProperty<System.DateTime>("UpdateTime");}
          set{setProperty("UpdateTime",value );}
      }


  }
}

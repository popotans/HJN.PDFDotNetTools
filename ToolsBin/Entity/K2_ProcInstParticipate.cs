
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
  public partial class K2_ProcInstParticipate : EntityBase
  {
    public K2_ProcInstParticipate()
    {
            TableName = "K2_ProcInstParticipate";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="ParticipateID";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("ParticipateID");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "ParticipateID","ProcInstID","LoginID","RealName","StartTime","EndTime","Category","TaskStatus" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Int32 ParticipateID
      {
          get{return getProperty<System.Int32>("ParticipateID");}
          set{setProperty("ParticipateID",value );}
      }

      /// <summary>
      /// 流程实例ID
      /// </summary>
      public System.Int32 ProcInstID
      {
          get{return getProperty<System.Int32>("ProcInstID");}
          set{setProperty("ProcInstID",value );}
      }

      /// <summary>
      /// 参与人ID
      /// </summary>
      public System.String LoginID
      {
          get{return getProperty<System.String>("LoginID");}
          set{setProperty("LoginID",value ,500);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String RealName
      {
          get{return getProperty<System.String>("RealName");}
          set{setProperty("RealName",value ,500);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime StartTime
      {
          get{return getProperty<System.DateTime>("StartTime");}
          set{setProperty("StartTime",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime EndTime
      {
          get{return getProperty<System.DateTime>("EndTime");}
          set{setProperty("EndTime",value );}
      }

      /// <summary>
      /// 参与人的类别[发起人=0,已审批人=1,未审批人=2,知会人=3,收文人=4]
      /// </summary>
      public System.Int32 Category
      {
          get{return getProperty<System.Int32>("Category");}
          set{setProperty("Category",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 TaskStatus
      {
          get{return getProperty<System.Int32>("TaskStatus");}
          set{setProperty("TaskStatus",value );}
      }


  }
}


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
  public partial class K2_StatisticProcInstActivity : EntityBase
  {
    public K2_StatisticProcInstActivity()
    {
            TableName = "K2_StatisticProcInstActivity";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="StatisticId";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("StatisticId");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "StatisticId","StateMonth","ProcInstId","TaskId","SN","ProcessCode","ProcessName","ActivityCode","ActivityName","ApproveLoginName","ApproveUserName","StartTime","EndTime","DowithTime" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Int32 StatisticId
      {
          get{return getProperty<System.Int32>("StatisticId");}
          set{setProperty("StatisticId",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String StateMonth
      {
          get{return getProperty<System.String>("StateMonth");}
          set{setProperty("StateMonth",value ,50);}
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
      public System.String TaskId
      {
          get{return getProperty<System.String>("TaskId");}
          set{setProperty("TaskId",value ,50);}
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
      public System.String ProcessCode
      {
          get{return getProperty<System.String>("ProcessCode");}
          set{setProperty("ProcessCode",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ProcessName
      {
          get{return getProperty<System.String>("ProcessName");}
          set{setProperty("ProcessName",value ,500);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ActivityCode
      {
          get{return getProperty<System.String>("ActivityCode");}
          set{setProperty("ActivityCode",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ActivityName
      {
          get{return getProperty<System.String>("ActivityName");}
          set{setProperty("ActivityName",value ,500);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ApproveLoginName
      {
          get{return getProperty<System.String>("ApproveLoginName");}
          set{setProperty("ApproveLoginName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ApproveUserName
      {
          get{return getProperty<System.String>("ApproveUserName");}
          set{setProperty("ApproveUserName",value ,100);}
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
      /// 
      /// </summary>
      public System.Decimal DowithTime
      {
          get{return getProperty<System.Decimal>("DowithTime");}
          set{setProperty("DowithTime",value );}
      }


  }
}


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
  public partial class K2_ProcInstTask : EntityBase
  {
    public K2_ProcInstTask()
    {
            TableName = "K2_ProcInstTask";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="ID";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("ID");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "ID","Guid","EncryptionProcInstID","ProcInstID","EncryptionSN","SN","TaskType","ActivityName","ProcessName","ProcessCode","ContentSummary","ApplyerName","ApplyerLoginName","ApplyTime","ApproverName","ApproverLoginName","DelegateUserName","DelegateLoginName","ProcDescription","ApproveUrl","IsApproved","ReceiveTime","FnishedTime","ReadTime","IsRead","ReadIP","UrgencyLevel","ProcType","Ext1","Ext2","Ext3","Ext4","Ext5" };
      }



      /// <summary>
      /// 自增主键
      /// </summary>
      public System.Int32 ID
      {
          get{return getProperty<System.Int32>("ID");}
          set{setProperty("ID",value );}
      }

      /// <summary>
      /// 流程的Guid
      /// </summary>
      public System.Guid Guid
      {
          get{return getProperty<System.Guid>("Guid");}
          set{setProperty("Guid",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String EncryptionProcInstID
      {
          get{return getProperty<System.String>("EncryptionProcInstID");}
          set{setProperty("EncryptionProcInstID",value ,100);}
      }

      /// <summary>
      /// 加密后的流程实例ID
      /// </summary>
      public System.String ProcInstID
      {
          get{return getProperty<System.String>("ProcInstID");}
          set{setProperty("ProcInstID",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String EncryptionSN
      {
          get{return getProperty<System.String>("EncryptionSN");}
          set{setProperty("EncryptionSN",value ,100);}
      }

      /// <summary>
      /// 加密后的任务SN
      /// </summary>
      public System.String SN
      {
          get{return getProperty<System.String>("SN");}
          set{setProperty("SN",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 TaskType
      {
          get{return getProperty<System.Int32>("TaskType");}
          set{setProperty("TaskType",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ActivityName
      {
          get{return getProperty<System.String>("ActivityName");}
          set{setProperty("ActivityName",value ,100);}
      }

      /// <summary>
      /// 流程名称
      /// </summary>
      public System.String ProcessName
      {
          get{return getProperty<System.String>("ProcessName");}
          set{setProperty("ProcessName",value ,100);}
      }

      /// <summary>
      /// 流程编码
      /// </summary>
      public System.String ProcessCode
      {
          get{return getProperty<System.String>("ProcessCode");}
          set{setProperty("ProcessCode",value ,50);}
      }

      /// <summary>
      /// 任务内容摘要
      /// </summary>
      public System.String ContentSummary
      {
          get{return getProperty<System.String>("ContentSummary");}
          set{setProperty("ContentSummary",value ,2000);}
      }

      /// <summary>
      /// 申请人姓名
      /// </summary>
      public System.String ApplyerName
      {
          get{return getProperty<System.String>("ApplyerName");}
          set{setProperty("ApplyerName",value ,50);}
      }

      /// <summary>
      /// 申请者登录名
      /// </summary>
      public System.String ApplyerLoginName
      {
          get{return getProperty<System.String>("ApplyerLoginName");}
          set{setProperty("ApplyerLoginName",value ,50);}
      }

      /// <summary>
      /// 申请时间
      /// </summary>
      public System.DateTime ApplyTime
      {
          get{return getProperty<System.DateTime>("ApplyTime");}
          set{setProperty("ApplyTime",value );}
      }

      /// <summary>
      /// 待审批者姓名
      /// </summary>
      public System.String ApproverName
      {
          get{return getProperty<System.String>("ApproverName");}
          set{setProperty("ApproverName",value ,50);}
      }

      /// <summary>
      /// 待审批者登录名
      /// </summary>
      public System.String ApproverLoginName
      {
          get{return getProperty<System.String>("ApproverLoginName");}
          set{setProperty("ApproverLoginName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String DelegateUserName
      {
          get{return getProperty<System.String>("DelegateUserName");}
          set{setProperty("DelegateUserName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String DelegateLoginName
      {
          get{return getProperty<System.String>("DelegateLoginName");}
          set{setProperty("DelegateLoginName",value ,50);}
      }

      /// <summary>
      /// 任务描述
      /// </summary>
      public System.String ProcDescription
      {
          get{return getProperty<System.String>("ProcDescription");}
          set{setProperty("ProcDescription",value ,200);}
      }

      /// <summary>
      /// 审批URL
      /// </summary>
      public System.String ApproveUrl
      {
          get{return getProperty<System.String>("ApproveUrl");}
          set{setProperty("ApproveUrl",value ,200);}
      }

      /// <summary>
      /// 是否已经审批过
      /// </summary>
      public System.Int32 IsApproved
      {
          get{return getProperty<System.Int32>("IsApproved");}
          set{setProperty("IsApproved",value );}
      }

      /// <summary>
      /// 收到任务时间
      /// </summary>
      public System.DateTime ReceiveTime
      {
          get{return getProperty<System.DateTime>("ReceiveTime");}
          set{setProperty("ReceiveTime",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime FnishedTime
      {
          get{return getProperty<System.DateTime>("FnishedTime");}
          set{setProperty("FnishedTime",value );}
      }

      /// <summary>
      /// 读取时间
      /// </summary>
      public System.DateTime ReadTime
      {
          get{return getProperty<System.DateTime>("ReadTime");}
          set{setProperty("ReadTime",value );}
      }

      /// <summary>
      /// 是否已读
      /// </summary>
      public System.Int32 IsRead
      {
          get{return getProperty<System.Int32>("IsRead");}
          set{setProperty("IsRead",value );}
      }

      /// <summary>
      /// 读取IP地址
      /// </summary>
      public System.String ReadIP
      {
          get{return getProperty<System.String>("ReadIP");}
          set{setProperty("ReadIP",value ,100);}
      }

      /// <summary>
      /// 紧急程度
      /// </summary>
      public System.Int32 UrgencyLevel
      {
          get{return getProperty<System.Int32>("UrgencyLevel");}
          set{setProperty("UrgencyLevel",value );}
      }

      /// <summary>
      /// 工作流平台类型,1:K2    ,    2：BENQ
      /// </summary>
      public System.Int32 ProcType
      {
          get{return getProperty<System.Int32>("ProcType");}
          set{setProperty("ProcType",value );}
      }

      /// <summary>
      /// 扩展
      /// </summary>
      public System.String Ext1
      {
          get{return getProperty<System.String>("Ext1");}
          set{setProperty("Ext1",value ,1000);}
      }

      /// <summary>
      /// 扩展
      /// </summary>
      public System.String Ext2
      {
          get{return getProperty<System.String>("Ext2");}
          set{setProperty("Ext2",value ,1000);}
      }

      /// <summary>
      /// 扩展
      /// </summary>
      public System.String Ext3
      {
          get{return getProperty<System.String>("Ext3");}
          set{setProperty("Ext3",value ,1000);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext4
      {
          get{return getProperty<System.String>("Ext4");}
          set{setProperty("Ext4",value ,1000);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext5
      {
          get{return getProperty<System.String>("Ext5");}
          set{setProperty("Ext5",value ,1000);}
      }


  }
}

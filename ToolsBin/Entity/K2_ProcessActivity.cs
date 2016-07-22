
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
  public partial class K2_ProcessActivity : EntityBase
  {
    public K2_ProcessActivity()
    {
            TableName = "K2_ProcessActivity";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("ActivityId");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "ActivityId","ProcessId","ActivityCode","ActivityName","K2ActivityName","Duty","StandardTime","OnceApprove","BatApprove","AddApprove","RedirectApprove","ReturnToPre","ReturnToStart","Reject","ReStart","RejectButContinue","Cancel","Undetermined","SendEmail","SendIM","SendSMS","Ext1","Ext2","Ext3","Remark","CreateBy","CreateDate","LastModifyBy","LastModifyDate" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Guid ActivityId
      {
          get{return getProperty<System.Guid>("ActivityId");}
          set{setProperty("ActivityId",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Guid ProcessId
      {
          get{return getProperty<System.Guid>("ProcessId");}
          set{setProperty("ProcessId",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ActivityCode
      {
          get{return getProperty<System.String>("ActivityCode");}
          set{setProperty("ActivityCode",value ,10);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ActivityName
      {
          get{return getProperty<System.String>("ActivityName");}
          set{setProperty("ActivityName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String K2ActivityName
      {
          get{return getProperty<System.String>("K2ActivityName");}
          set{setProperty("K2ActivityName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Duty
      {
          get{return getProperty<System.String>("Duty");}
          set{setProperty("Duty",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String StandardTime
      {
          get{return getProperty<System.String>("StandardTime");}
          set{setProperty("StandardTime",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Boolean OnceApprove
      {
          get{return getProperty<System.Boolean>("OnceApprove");}
          set{setProperty("OnceApprove",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Boolean BatApprove
      {
          get{return getProperty<System.Boolean>("BatApprove");}
          set{setProperty("BatApprove",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Boolean AddApprove
      {
          get{return getProperty<System.Boolean>("AddApprove");}
          set{setProperty("AddApprove",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Boolean RedirectApprove
      {
          get{return getProperty<System.Boolean>("RedirectApprove");}
          set{setProperty("RedirectApprove",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Boolean ReturnToPre
      {
          get{return getProperty<System.Boolean>("ReturnToPre");}
          set{setProperty("ReturnToPre",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Boolean ReturnToStart
      {
          get{return getProperty<System.Boolean>("ReturnToStart");}
          set{setProperty("ReturnToStart",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Boolean Reject
      {
          get{return getProperty<System.Boolean>("Reject");}
          set{setProperty("Reject",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Boolean ReStart
      {
          get{return getProperty<System.Boolean>("ReStart");}
          set{setProperty("ReStart",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Boolean RejectButContinue
      {
          get{return getProperty<System.Boolean>("RejectButContinue");}
          set{setProperty("RejectButContinue",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Boolean Cancel
      {
          get{return getProperty<System.Boolean>("Cancel");}
          set{setProperty("Cancel",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Boolean Undetermined
      {
          get{return getProperty<System.Boolean>("Undetermined");}
          set{setProperty("Undetermined",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Boolean SendEmail
      {
          get{return getProperty<System.Boolean>("SendEmail");}
          set{setProperty("SendEmail",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Boolean SendIM
      {
          get{return getProperty<System.Boolean>("SendIM");}
          set{setProperty("SendIM",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Boolean SendSMS
      {
          get{return getProperty<System.Boolean>("SendSMS");}
          set{setProperty("SendSMS",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext1
      {
          get{return getProperty<System.String>("Ext1");}
          set{setProperty("Ext1",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext2
      {
          get{return getProperty<System.String>("Ext2");}
          set{setProperty("Ext2",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext3
      {
          get{return getProperty<System.String>("Ext3");}
          set{setProperty("Ext3",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Remark
      {
          get{return getProperty<System.String>("Remark");}
          set{setProperty("Remark",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String CreateBy
      {
          get{return getProperty<System.String>("CreateBy");}
          set{setProperty("CreateBy",value ,10);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime CreateDate
      {
          get{return getProperty<System.DateTime>("CreateDate");}
          set{setProperty("CreateDate",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String LastModifyBy
      {
          get{return getProperty<System.String>("LastModifyBy");}
          set{setProperty("LastModifyBy",value ,10);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime LastModifyDate
      {
          get{return getProperty<System.DateTime>("LastModifyDate");}
          set{setProperty("LastModifyDate",value );}
      }


  }
}

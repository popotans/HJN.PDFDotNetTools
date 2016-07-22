
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
  public partial class K2_ProcessBase : EntityBase
  {
    public K2_ProcessBase()
    {
            TableName = "K2_ProcessBase";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("ProcessId");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "ProcessId","ProcessCategoryId","ProcessCode","ProcessName","ProcessFormPath","ProcessFullName","BusinessDataTable","TestTable","DisOrder","IsUsed","ProcessType","ThemeName","BaseUrl","StartUrl","ReStartURL","ApproveUrl","ViewUrl","PrintUrl","Remark","BatApprove","OnceApprove","AddApprove","RedirectApprove","ReturnToPre","ReturnToStart","Reject","ReStart","RejectButContinue","Undetermined","Cancel","SendEmail","SendIM","SendSMS","CreateBy","CreateDate","LastModifyBy","LastModifyDate","CreateSystem","IsDisplay","Icon","Ext1","Ext2","Ext3","Ext4","Ext5" };
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
      public System.Guid ProcessCategoryId
      {
          get{return getProperty<System.Guid>("ProcessCategoryId");}
          set{setProperty("ProcessCategoryId",value );}
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
      public System.String ProcessName
      {
          get{return getProperty<System.String>("ProcessName");}
          set{setProperty("ProcessName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ProcessFormPath
      {
          get{return getProperty<System.String>("ProcessFormPath");}
          set{setProperty("ProcessFormPath",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ProcessFullName
      {
          get{return getProperty<System.String>("ProcessFullName");}
          set{setProperty("ProcessFullName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String BusinessDataTable
      {
          get{return getProperty<System.String>("BusinessDataTable");}
          set{setProperty("BusinessDataTable",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String TestTable
      {
          get{return getProperty<System.String>("TestTable");}
          set{setProperty("TestTable",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 DisOrder
      {
          get{return getProperty<System.Int32>("DisOrder");}
          set{setProperty("DisOrder",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 IsUsed
      {
          get{return getProperty<System.Int32>("IsUsed");}
          set{setProperty("IsUsed",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 ProcessType
      {
          get{return getProperty<System.Int32>("ProcessType");}
          set{setProperty("ProcessType",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ThemeName
      {
          get{return getProperty<System.String>("ThemeName");}
          set{setProperty("ThemeName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String BaseUrl
      {
          get{return getProperty<System.String>("BaseUrl");}
          set{setProperty("BaseUrl",value ,150);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String StartUrl
      {
          get{return getProperty<System.String>("StartUrl");}
          set{setProperty("StartUrl",value ,300);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ReStartURL
      {
          get{return getProperty<System.String>("ReStartURL");}
          set{setProperty("ReStartURL",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ApproveUrl
      {
          get{return getProperty<System.String>("ApproveUrl");}
          set{setProperty("ApproveUrl",value ,300);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ViewUrl
      {
          get{return getProperty<System.String>("ViewUrl");}
          set{setProperty("ViewUrl",value ,300);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String PrintUrl
      {
          get{return getProperty<System.String>("PrintUrl");}
          set{setProperty("PrintUrl",value ,300);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Remark
      {
          get{return getProperty<System.String>("Remark");}
          set{setProperty("Remark",value ,1000);}
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
      public System.Boolean OnceApprove
      {
          get{return getProperty<System.Boolean>("OnceApprove");}
          set{setProperty("OnceApprove",value );}
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
      public System.Boolean Undetermined
      {
          get{return getProperty<System.Boolean>("Undetermined");}
          set{setProperty("Undetermined",value );}
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
      public System.String CreateBy
      {
          get{return getProperty<System.String>("CreateBy");}
          set{setProperty("CreateBy",value ,50);}
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

      /// <summary>
      /// 
      /// </summary>
      public System.String CreateSystem
      {
          get{return getProperty<System.String>("CreateSystem");}
          set{setProperty("CreateSystem",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 IsDisplay
      {
          get{return getProperty<System.Int32>("IsDisplay");}
          set{setProperty("IsDisplay",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Icon
      {
          get{return getProperty<System.String>("Icon");}
          set{setProperty("Icon",value ,150);}
      }

      /// <summary>
      /// 流程帮助信息
      /// </summary>
      public System.String Ext1
      {
          get{return getProperty<System.String>("Ext1");}
          set{setProperty("Ext1",value ,2147483647);}
      }

      /// <summary>
      /// 是否启用帮助信息，1：启用；2：禁用
      /// </summary>
      public System.String Ext2
      {
          get{return getProperty<System.String>("Ext2");}
          set{setProperty("Ext2",value ,1000);}
      }

      /// <summary>
      /// 
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


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
  public partial class K2_ProcInstBase : EntityBase
  {
    public K2_ProcInstBase()
    {
            TableName = "K2_ProcInstBase";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("Guid");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "Guid","ProcessCode","ProcInstId","EncryptionProcInstID","Folio","ProcInstTitle","StartTime","EndTime","WFStatus","WFStatusDescription","ApplyLoginName","ApplyUserName","CompanyCode","CompanyName","DepartmentCode","DepartmentName","ApplyTel","ApplyEmail","ApproveLoginName","ApproveUserName","UrgencyLevel","ThemeName","Subject","Ext1","Ext2","Ext3","Ext4","Ext5" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Guid Guid
      {
          get{return getProperty<System.Guid>("Guid");}
          set{setProperty("Guid",value );}
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
      public System.Int32 ProcInstId
      {
          get{return getProperty<System.Int32>("ProcInstId");}
          set{setProperty("ProcInstId",value );}
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
      /// 
      /// </summary>
      public System.String Folio
      {
          get{return getProperty<System.String>("Folio");}
          set{setProperty("Folio",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ProcInstTitle
      {
          get{return getProperty<System.String>("ProcInstTitle");}
          set{setProperty("ProcInstTitle",value ,100);}
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
      public System.Int32 WFStatus
      {
          get{return getProperty<System.Int32>("WFStatus");}
          set{setProperty("WFStatus",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String WFStatusDescription
      {
          get{return getProperty<System.String>("WFStatusDescription");}
          set{setProperty("WFStatusDescription",value ,500);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ApplyLoginName
      {
          get{return getProperty<System.String>("ApplyLoginName");}
          set{setProperty("ApplyLoginName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ApplyUserName
      {
          get{return getProperty<System.String>("ApplyUserName");}
          set{setProperty("ApplyUserName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String CompanyCode
      {
          get{return getProperty<System.String>("CompanyCode");}
          set{setProperty("CompanyCode",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String CompanyName
      {
          get{return getProperty<System.String>("CompanyName");}
          set{setProperty("CompanyName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String DepartmentCode
      {
          get{return getProperty<System.String>("DepartmentCode");}
          set{setProperty("DepartmentCode",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String DepartmentName
      {
          get{return getProperty<System.String>("DepartmentName");}
          set{setProperty("DepartmentName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ApplyTel
      {
          get{return getProperty<System.String>("ApplyTel");}
          set{setProperty("ApplyTel",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ApplyEmail
      {
          get{return getProperty<System.String>("ApplyEmail");}
          set{setProperty("ApplyEmail",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ApproveLoginName
      {
          get{return getProperty<System.String>("ApproveLoginName");}
          set{setProperty("ApproveLoginName",value ,500);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ApproveUserName
      {
          get{return getProperty<System.String>("ApproveUserName");}
          set{setProperty("ApproveUserName",value ,500);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 UrgencyLevel
      {
          get{return getProperty<System.Int32>("UrgencyLevel");}
          set{setProperty("UrgencyLevel",value );}
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
      public System.String Subject
      {
          get{return getProperty<System.String>("Subject");}
          set{setProperty("Subject",value ,2147483647);}
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
      public System.String Ext4
      {
          get{return getProperty<System.String>("Ext4");}
          set{setProperty("Ext4",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext5
      {
          get{return getProperty<System.String>("Ext5");}
          set{setProperty("Ext5",value ,100);}
      }


  }
}

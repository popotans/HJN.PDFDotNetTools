
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
  public partial class K2_ProcInstAttachment : EntityBase
  {
    public K2_ProcInstAttachment()
    {
            TableName = "K2_ProcInstAttachment";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("AttachmentId");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "AttachmentId","ProcInstId","Guid","FileName","FileExtensionName","FileUrl","FileSize","UploadTime","UploadLoginName","UploadUserName","Version","IsDelete","Remark" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Guid AttachmentId
      {
          get{return getProperty<System.Guid>("AttachmentId");}
          set{setProperty("AttachmentId",value );}
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
      public System.Guid Guid
      {
          get{return getProperty<System.Guid>("Guid");}
          set{setProperty("Guid",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String FileName
      {
          get{return getProperty<System.String>("FileName");}
          set{setProperty("FileName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String FileExtensionName
      {
          get{return getProperty<System.String>("FileExtensionName");}
          set{setProperty("FileExtensionName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String FileUrl
      {
          get{return getProperty<System.String>("FileUrl");}
          set{setProperty("FileUrl",value ,200);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 FileSize
      {
          get{return getProperty<System.Int32>("FileSize");}
          set{setProperty("FileSize",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime UploadTime
      {
          get{return getProperty<System.DateTime>("UploadTime");}
          set{setProperty("UploadTime",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String UploadLoginName
      {
          get{return getProperty<System.String>("UploadLoginName");}
          set{setProperty("UploadLoginName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String UploadUserName
      {
          get{return getProperty<System.String>("UploadUserName");}
          set{setProperty("UploadUserName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 Version
      {
          get{return getProperty<System.Int32>("Version");}
          set{setProperty("Version",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 IsDelete
      {
          get{return getProperty<System.Int32>("IsDelete");}
          set{setProperty("IsDelete",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Remark
      {
          get{return getProperty<System.String>("Remark");}
          set{setProperty("Remark",value ,100);}
      }


  }
}

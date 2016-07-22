
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
  public partial class K2_ProcInstAttachmentFile : EntityBase
  {
    public K2_ProcInstAttachmentFile()
    {
            TableName = "K2_ProcInstAttachmentFile";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="ID";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("ID");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "ID","AttachmentID","AttachFileContent" };
      }



      /// <summary>
      /// 自增加ID
      /// </summary>
      public System.Int32 ID
      {
          get{return getProperty<System.Int32>("ID");}
          set{setProperty("ID",value );}
      }

      /// <summary>
      /// 附件ID
      /// </summary>
      public System.Guid AttachmentID
      {
          get{return getProperty<System.Guid>("AttachmentID");}
          set{setProperty("AttachmentID",value );}
      }

      /// <summary>
      /// 附件内容
      /// </summary>
      public System.Byte[] AttachFileContent
      {
          get{return getProperty<System.Byte[]>("AttachFileContent");}
          set{setProperty("AttachFileContent",value );}
      }


  }
}

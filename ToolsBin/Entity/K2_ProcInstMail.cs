
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
  public partial class K2_ProcInstMail : EntityBase
  {
    public K2_ProcInstMail()
    {
            TableName = "K2_ProcInstMail";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="ID";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("ID");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "ID","Guid","ProcInstID","ReceiveLoginName","ReceiveUserName","SendLoginName","SendUserName","MessageTitle","MessageContent","MessageSendType","MessageStatus","CreateDate" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Int32 ID
      {
          get{return getProperty<System.Int32>("ID");}
          set{setProperty("ID",value );}
      }

      /// <summary>
      /// 关联流程的Guid
      /// </summary>
      public System.Guid Guid
      {
          get{return getProperty<System.Guid>("Guid");}
          set{setProperty("Guid",value );}
      }

      /// <summary>
      /// 关联流程的ProcInstID
      /// </summary>
      public System.Int32 ProcInstID
      {
          get{return getProperty<System.Int32>("ProcInstID");}
          set{setProperty("ProcInstID",value );}
      }

      /// <summary>
      /// 收件人AD
      /// </summary>
      public System.String ReceiveLoginName
      {
          get{return getProperty<System.String>("ReceiveLoginName");}
          set{setProperty("ReceiveLoginName",value ,200);}
      }

      /// <summary>
      /// 收件人姓名
      /// </summary>
      public System.String ReceiveUserName
      {
          get{return getProperty<System.String>("ReceiveUserName");}
          set{setProperty("ReceiveUserName",value ,200);}
      }

      /// <summary>
      /// 发件人AD
      /// </summary>
      public System.String SendLoginName
      {
          get{return getProperty<System.String>("SendLoginName");}
          set{setProperty("SendLoginName",value ,200);}
      }

      /// <summary>
      /// 发件人姓名
      /// </summary>
      public System.String SendUserName
      {
          get{return getProperty<System.String>("SendUserName");}
          set{setProperty("SendUserName",value ,200);}
      }

      /// <summary>
      /// 邮件标题
      /// </summary>
      public System.String MessageTitle
      {
          get{return getProperty<System.String>("MessageTitle");}
          set{setProperty("MessageTitle",value ,200);}
      }

      /// <summary>
      /// 邮件内容
      /// </summary>
      public System.String MessageContent
      {
          get{return getProperty<System.String>("MessageContent");}
          set{setProperty("MessageContent",value ,2147483647);}
      }

      /// <summary>
      /// 消息发送类型
      /// </summary>
      public System.String MessageSendType
      {
          get{return getProperty<System.String>("MessageSendType");}
          set{setProperty("MessageSendType",value ,50);}
      }

      /// <summary>
      /// 消息发送状态
      /// </summary>
      public System.Int32 MessageStatus
      {
          get{return getProperty<System.Int32>("MessageStatus");}
          set{setProperty("MessageStatus",value );}
      }

      /// <summary>
      /// 插入时间
      /// </summary>
      public System.DateTime CreateDate
      {
          get{return getProperty<System.DateTime>("CreateDate");}
          set{setProperty("CreateDate",value );}
      }


  }
}

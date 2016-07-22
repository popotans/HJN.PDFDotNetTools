
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
  public partial class K2_ProcInstMessage : EntityBase
  {
    public K2_ProcInstMessage()
    {
            TableName = "K2_ProcInstMessage";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("MessageId");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "MessageId","ProcInstId","CreateTime","ProcCode","ProcInstViewUrl","ReceiveLoginName","ReceiveUserName","ReceiveCCLoginName","ReceiveCCUserName","SendLoginName","SendUserName","MessageTitle","MessageContent","MessageType","MessageTemplateType","IsDelete","IsRead","SendType","Ext1","Ext2" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Guid MessageId
      {
          get{return getProperty<System.Guid>("MessageId");}
          set{setProperty("MessageId",value );}
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
      public System.DateTime CreateTime
      {
          get{return getProperty<System.DateTime>("CreateTime");}
          set{setProperty("CreateTime",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ProcCode
      {
          get{return getProperty<System.String>("ProcCode");}
          set{setProperty("ProcCode",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ProcInstViewUrl
      {
          get{return getProperty<System.String>("ProcInstViewUrl");}
          set{setProperty("ProcInstViewUrl",value ,200);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ReceiveLoginName
      {
          get{return getProperty<System.String>("ReceiveLoginName");}
          set{setProperty("ReceiveLoginName",value ,3500);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ReceiveUserName
      {
          get{return getProperty<System.String>("ReceiveUserName");}
          set{setProperty("ReceiveUserName",value ,3500);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ReceiveCCLoginName
      {
          get{return getProperty<System.String>("ReceiveCCLoginName");}
          set{setProperty("ReceiveCCLoginName",value ,1550);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ReceiveCCUserName
      {
          get{return getProperty<System.String>("ReceiveCCUserName");}
          set{setProperty("ReceiveCCUserName",value ,1550);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String SendLoginName
      {
          get{return getProperty<System.String>("SendLoginName");}
          set{setProperty("SendLoginName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String SendUserName
      {
          get{return getProperty<System.String>("SendUserName");}
          set{setProperty("SendUserName",value ,200);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String MessageTitle
      {
          get{return getProperty<System.String>("MessageTitle");}
          set{setProperty("MessageTitle",value ,500);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String MessageContent
      {
          get{return getProperty<System.String>("MessageContent");}
          set{setProperty("MessageContent",value ,2147483647);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 MessageType
      {
          get{return getProperty<System.Int32>("MessageType");}
          set{setProperty("MessageType",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 MessageTemplateType
      {
          get{return getProperty<System.Int32>("MessageTemplateType");}
          set{setProperty("MessageTemplateType",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String IsDelete
      {
          get{return getProperty<System.String>("IsDelete");}
          set{setProperty("IsDelete",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String IsRead
      {
          get{return getProperty<System.String>("IsRead");}
          set{setProperty("IsRead",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String SendType
      {
          get{return getProperty<System.String>("SendType");}
          set{setProperty("SendType",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext1
      {
          get{return getProperty<System.String>("Ext1");}
          set{setProperty("Ext1",value ,1000);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext2
      {
          get{return getProperty<System.String>("Ext2");}
          set{setProperty("Ext2",value ,1000);}
      }


  }
}

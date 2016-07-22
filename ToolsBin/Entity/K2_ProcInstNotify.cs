
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
  public partial class K2_ProcInstNotify : EntityBase
  {
    public K2_ProcInstNotify()
    {
            TableName = "K2_ProcInstNotify";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("NotifyId");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "NotifyId","ProcInstId","ReceiveLoginName","ReceiveUserName","SendLoginName","SendUserName","MessageTitle","MessageContent","MessageType","NotifyStatus","CreateDate","ReadStatus" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Guid NotifyId
      {
          get{return getProperty<System.Guid>("NotifyId");}
          set{setProperty("NotifyId",value );}
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
      public System.String ReceiveLoginName
      {
          get{return getProperty<System.String>("ReceiveLoginName");}
          set{setProperty("ReceiveLoginName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ReceiveUserName
      {
          get{return getProperty<System.String>("ReceiveUserName");}
          set{setProperty("ReceiveUserName",value ,200);}
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
          set{setProperty("MessageTitle",value ,100);}
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
      public System.String MessageType
      {
          get{return getProperty<System.String>("MessageType");}
          set{setProperty("MessageType",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 NotifyStatus
      {
          get{return getProperty<System.Int32>("NotifyStatus");}
          set{setProperty("NotifyStatus",value );}
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
      public System.Int32 ReadStatus
      {
          get{return getProperty<System.Int32>("ReadStatus");}
          set{setProperty("ReadStatus",value );}
      }


  }
}


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
  public partial class K2_ProcInstComment : EntityBase
  {
    public K2_ProcInstComment()
    {
            TableName = "K2_ProcInstComment";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("CommentId");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "CommentId","ProcInstId","SN","ReceiveTime","ApproveTime","ApproveAction","ApproveActionName","ApproveContent","ApproveLoginName","ApproveUserName","ApprovePositionTitle","ActivityName","RoleName","IP","Ext1","Ext2","Ext3","Ext4","Ext5" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Guid CommentId
      {
          get{return getProperty<System.Guid>("CommentId");}
          set{setProperty("CommentId",value );}
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
      public System.String SN
      {
          get{return getProperty<System.String>("SN");}
          set{setProperty("SN",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime ReceiveTime
      {
          get{return getProperty<System.DateTime>("ReceiveTime");}
          set{setProperty("ReceiveTime",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime ApproveTime
      {
          get{return getProperty<System.DateTime>("ApproveTime");}
          set{setProperty("ApproveTime",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ApproveAction
      {
          get{return getProperty<System.String>("ApproveAction");}
          set{setProperty("ApproveAction",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ApproveActionName
      {
          get{return getProperty<System.String>("ApproveActionName");}
          set{setProperty("ApproveActionName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ApproveContent
      {
          get{return getProperty<System.String>("ApproveContent");}
          set{setProperty("ApproveContent",value ,4000);}
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
          set{setProperty("ApproveUserName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ApprovePositionTitle
      {
          get{return getProperty<System.String>("ApprovePositionTitle");}
          set{setProperty("ApprovePositionTitle",value ,100);}
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
      /// 
      /// </summary>
      public System.String RoleName
      {
          get{return getProperty<System.String>("RoleName");}
          set{setProperty("RoleName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String IP
      {
          get{return getProperty<System.String>("IP");}
          set{setProperty("IP",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext1
      {
          get{return getProperty<System.String>("Ext1");}
          set{setProperty("Ext1",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext2
      {
          get{return getProperty<System.String>("Ext2");}
          set{setProperty("Ext2",value ,5000);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext3
      {
          get{return getProperty<System.String>("Ext3");}
          set{setProperty("Ext3",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext4
      {
          get{return getProperty<System.String>("Ext4");}
          set{setProperty("Ext4",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext5
      {
          get{return getProperty<System.String>("Ext5");}
          set{setProperty("Ext5",value ,50);}
      }


  }
}


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
  public partial class K2_ProcessAssist : EntityBase
  {
    public K2_ProcessAssist()
    {
            TableName = "K2_ProcessAssist";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("AssistId");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "AssistId","ProcessId","LoginName","UserName","Assist1LoginName","Assist1UserName","Assist2LoginName","Assist2UserName","Assist3LoginName","Assist3UserName","Remark","CreateBy","CreateDate","LastModifyBy","LastModifyDate","Ext1","Ext2","Ext3","Ext4","Ext5","Ext6","Ext7","Ext8","Ext9","Ext0" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Guid AssistId
      {
          get{return getProperty<System.Guid>("AssistId");}
          set{setProperty("AssistId",value );}
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
      public System.String LoginName
      {
          get{return getProperty<System.String>("LoginName");}
          set{setProperty("LoginName",value ,500);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String UserName
      {
          get{return getProperty<System.String>("UserName");}
          set{setProperty("UserName",value ,500);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Assist1LoginName
      {
          get{return getProperty<System.String>("Assist1LoginName");}
          set{setProperty("Assist1LoginName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Assist1UserName
      {
          get{return getProperty<System.String>("Assist1UserName");}
          set{setProperty("Assist1UserName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Assist2LoginName
      {
          get{return getProperty<System.String>("Assist2LoginName");}
          set{setProperty("Assist2LoginName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Assist2UserName
      {
          get{return getProperty<System.String>("Assist2UserName");}
          set{setProperty("Assist2UserName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Assist3LoginName
      {
          get{return getProperty<System.String>("Assist3LoginName");}
          set{setProperty("Assist3LoginName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Assist3UserName
      {
          get{return getProperty<System.String>("Assist3UserName");}
          set{setProperty("Assist3UserName",value ,100);}
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
          set{setProperty("Ext2",value ,50);}
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

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext6
      {
          get{return getProperty<System.String>("Ext6");}
          set{setProperty("Ext6",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext7
      {
          get{return getProperty<System.String>("Ext7");}
          set{setProperty("Ext7",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext8
      {
          get{return getProperty<System.String>("Ext8");}
          set{setProperty("Ext8",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext9
      {
          get{return getProperty<System.String>("Ext9");}
          set{setProperty("Ext9",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext0
      {
          get{return getProperty<System.String>("Ext0");}
          set{setProperty("Ext0",value ,50);}
      }


  }
}

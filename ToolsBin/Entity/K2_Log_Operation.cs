
/* 
 本类由PWMIS 实体类生成工具(适用于 PWMIS.Core Version: 5.3 以上)自动生成
 http://www.pwmis.com/sqlmap
 使用前请先在项目工程中引用 PWMIS.Core.dll
 2016/7/22 17:10:45
*/

using System;
using PWMIS.Common;
using PWMIS.DataMap.Entity;

namespace BPM_K2Sln 
{
  [Serializable()]
  public partial class K2_Log_Operation : EntityBase
  {
    public K2_Log_Operation()
    {
            TableName = "K2_Log_Operation";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="LogId";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("LogId");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "LogId","TableName","RcdId","OperatorLoginName","OperatorUserName","OperateType","OperateTime","BeforeModify","AfterModify","Remark","Ext1","Ext2" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Int32 LogId
      {
          get{return getProperty<System.Int32>("LogId");}
          set{setProperty("LogId",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String TableName
      {
          get{return getProperty<System.String>("TableName");}
          set{setProperty("TableName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String RcdId
      {
          get{return getProperty<System.String>("RcdId");}
          set{setProperty("RcdId",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String OperatorLoginName
      {
          get{return getProperty<System.String>("OperatorLoginName");}
          set{setProperty("OperatorLoginName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String OperatorUserName
      {
          get{return getProperty<System.String>("OperatorUserName");}
          set{setProperty("OperatorUserName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 OperateType
      {
          get{return getProperty<System.Int32>("OperateType");}
          set{setProperty("OperateType",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime OperateTime
      {
          get{return getProperty<System.DateTime>("OperateTime");}
          set{setProperty("OperateTime",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String BeforeModify
      {
          get{return getProperty<System.String>("BeforeModify");}
          set{setProperty("BeforeModify",value ,3000);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String AfterModify
      {
          get{return getProperty<System.String>("AfterModify");}
          set{setProperty("AfterModify",value ,3000);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Remark
      {
          get{return getProperty<System.String>("Remark");}
          set{setProperty("Remark",value ,3000);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext1
      {
          get{return getProperty<System.String>("Ext1");}
          set{setProperty("Ext1",value ,3000);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext2
      {
          get{return getProperty<System.String>("Ext2");}
          set{setProperty("Ext2",value ,3000);}
      }


  }
}

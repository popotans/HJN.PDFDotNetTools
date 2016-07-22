
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
  public partial class K2_ProcInstAppovedChain : EntityBase
  {
    public K2_ProcInstAppovedChain()
    {
            TableName = "K2_ProcInstAppovedChain";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="ApprovedId";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("ApprovedId");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "ApprovedId","ProcGuid","ProcInstId","LoginName","UserName","PositionTilte","ActiveName","ApprovedContent","ApprovedTime","ApproveAction","IsApproved","Ext1","Ext2","CreateTime" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Int32 ApprovedId
      {
          get{return getProperty<System.Int32>("ApprovedId");}
          set{setProperty("ApprovedId",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Guid ProcGuid
      {
          get{return getProperty<System.Guid>("ProcGuid");}
          set{setProperty("ProcGuid",value );}
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
      public System.String LoginName
      {
          get{return getProperty<System.String>("LoginName");}
          set{setProperty("LoginName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String UserName
      {
          get{return getProperty<System.String>("UserName");}
          set{setProperty("UserName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String PositionTilte
      {
          get{return getProperty<System.String>("PositionTilte");}
          set{setProperty("PositionTilte",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ActiveName
      {
          get{return getProperty<System.String>("ActiveName");}
          set{setProperty("ActiveName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ApprovedContent
      {
          get{return getProperty<System.String>("ApprovedContent");}
          set{setProperty("ApprovedContent",value ,200);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime ApprovedTime
      {
          get{return getProperty<System.DateTime>("ApprovedTime");}
          set{setProperty("ApprovedTime",value );}
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
      public System.Int32 IsApproved
      {
          get{return getProperty<System.Int32>("IsApproved");}
          set{setProperty("IsApproved",value );}
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
      public System.DateTime CreateTime
      {
          get{return getProperty<System.DateTime>("CreateTime");}
          set{setProperty("CreateTime",value );}
      }


  }
}

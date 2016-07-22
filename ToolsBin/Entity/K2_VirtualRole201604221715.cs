
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
  public partial class K2_VirtualRole201604221715 : EntityBase
  {
    public K2_VirtualRole201604221715()
    {
            TableName = "K2_VirtualRole201604221715";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "RoleId","ProcessCode","ActivityName","ActivityCode","ActivityOrder","RoleOrder","RoleCode","RoleName","ApproveCondition","Operator","SpecApproveCondition","FinalCondition","ClassCode","ClassName","SpecialCode","SpecialName","LoginName","UserName","ScoreFrom","ScoreTo","CompanyCode","CompanyName","Remark","K2Version","IsDisabled","DisabledTime","CreateBy","CreateDate","LastModifyBy","LastModifyDate" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Int32 RoleId
      {
          get{return getProperty<System.Int32>("RoleId");}
          set{setProperty("RoleId",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ProcessCode
      {
          get{return getProperty<System.String>("ProcessCode");}
          set{setProperty("ProcessCode",value ,100);}
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
      public System.String ActivityCode
      {
          get{return getProperty<System.String>("ActivityCode");}
          set{setProperty("ActivityCode",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 ActivityOrder
      {
          get{return getProperty<System.Int32>("ActivityOrder");}
          set{setProperty("ActivityOrder",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 RoleOrder
      {
          get{return getProperty<System.Int32>("RoleOrder");}
          set{setProperty("RoleOrder",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String RoleCode
      {
          get{return getProperty<System.String>("RoleCode");}
          set{setProperty("RoleCode",value ,500);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String RoleName
      {
          get{return getProperty<System.String>("RoleName");}
          set{setProperty("RoleName",value ,500);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ApproveCondition
      {
          get{return getProperty<System.String>("ApproveCondition");}
          set{setProperty("ApproveCondition",value ,4000);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Operator
      {
          get{return getProperty<System.String>("Operator");}
          set{setProperty("Operator",value ,10);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String SpecApproveCondition
      {
          get{return getProperty<System.String>("SpecApproveCondition");}
          set{setProperty("SpecApproveCondition",value ,7999);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String FinalCondition
      {
          get{return getProperty<System.String>("FinalCondition");}
          set{setProperty("FinalCondition",value ,4000);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ClassCode
      {
          get{return getProperty<System.String>("ClassCode");}
          set{setProperty("ClassCode",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ClassName
      {
          get{return getProperty<System.String>("ClassName");}
          set{setProperty("ClassName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String SpecialCode
      {
          get{return getProperty<System.String>("SpecialCode");}
          set{setProperty("SpecialCode",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String SpecialName
      {
          get{return getProperty<System.String>("SpecialName");}
          set{setProperty("SpecialName",value ,50);}
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
      public System.Int32 ScoreFrom
      {
          get{return getProperty<System.Int32>("ScoreFrom");}
          set{setProperty("ScoreFrom",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 ScoreTo
      {
          get{return getProperty<System.Int32>("ScoreTo");}
          set{setProperty("ScoreTo",value );}
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
      public System.String Remark
      {
          get{return getProperty<System.String>("Remark");}
          set{setProperty("Remark",value ,2000);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String K2Version
      {
          get{return getProperty<System.String>("K2Version");}
          set{setProperty("K2Version",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Boolean IsDisabled
      {
          get{return getProperty<System.Boolean>("IsDisabled");}
          set{setProperty("IsDisabled",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime DisabledTime
      {
          get{return getProperty<System.DateTime>("DisabledTime");}
          set{setProperty("DisabledTime",value );}
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


  }
}

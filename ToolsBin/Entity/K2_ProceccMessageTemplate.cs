
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
  public partial class K2_ProceccMessageTemplate : EntityBase
  {
    public K2_ProceccMessageTemplate()
    {
            TableName = "K2_ProceccMessageTemplate";
            Schema="dbo";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("SettingId");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "SettingId","ProcName","ProcCode","IMType","IMTypeName","Ext1","Ext2","Ext3","Ext4","Ext5","Ext6","Ext7","Ext8","Ext9","Ext10","CreateBy","CreateDate","LastModifyBy","LastModifyDate" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Guid SettingId
      {
          get{return getProperty<System.Guid>("SettingId");}
          set{setProperty("SettingId",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ProcName
      {
          get{return getProperty<System.String>("ProcName");}
          set{setProperty("ProcName",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String ProcCode
      {
          get{return getProperty<System.String>("ProcCode");}
          set{setProperty("ProcCode",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String IMType
      {
          get{return getProperty<System.String>("IMType");}
          set{setProperty("IMType",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String IMTypeName
      {
          get{return getProperty<System.String>("IMTypeName");}
          set{setProperty("IMTypeName",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext1
      {
          get{return getProperty<System.String>("Ext1");}
          set{setProperty("Ext1",value ,2147483647);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext2
      {
          get{return getProperty<System.String>("Ext2");}
          set{setProperty("Ext2",value ,2147483647);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext3
      {
          get{return getProperty<System.String>("Ext3");}
          set{setProperty("Ext3",value ,2147483647);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext4
      {
          get{return getProperty<System.String>("Ext4");}
          set{setProperty("Ext4",value ,2147483647);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext5
      {
          get{return getProperty<System.String>("Ext5");}
          set{setProperty("Ext5",value ,2147483647);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext6
      {
          get{return getProperty<System.String>("Ext6");}
          set{setProperty("Ext6",value ,2147483647);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext7
      {
          get{return getProperty<System.String>("Ext7");}
          set{setProperty("Ext7",value ,2147483647);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext8
      {
          get{return getProperty<System.String>("Ext8");}
          set{setProperty("Ext8",value ,2147483647);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext9
      {
          get{return getProperty<System.String>("Ext9");}
          set{setProperty("Ext9",value ,2147483647);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String Ext10
      {
          get{return getProperty<System.String>("Ext10");}
          set{setProperty("Ext10",value ,2147483647);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String CreateBy
      {
          get{return getProperty<System.String>("CreateBy");}
          set{setProperty("CreateBy",value ,50);}
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
          set{setProperty("LastModifyBy",value ,50);}
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

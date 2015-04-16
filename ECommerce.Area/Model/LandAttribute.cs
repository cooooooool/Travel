/**  版本信息模板在安装目录下，可自行修改。
* LandAttribute.cs
*
* 功 能： N/A
* 类 名： LandAttribute
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/1/16 10:24:23   N/A    初版
*
* Copyright (c) 2013 Wiimedia Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：西安微媒软件有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace ECommerce.Area.Model
{
	/// <summary>
	/// LandAttribute:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LandAttribute
	{
		public LandAttribute()
		{}
		#region Model
		private int _laid;
		private string _laname;
		private int? _status;
		/// <summary>
		/// 
		/// </summary>
		public int LAId
		{
			set{ _laid=value;}
			get{return _laid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LAName
		{
			set{ _laname=value;}
			get{return _laname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		#endregion Model

	}
}


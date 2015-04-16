/**  版本信息模板在安装目录下，可自行修改。
* PointRule.cs
*
* 功 能： N/A
* 类 名： PointRule
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/2/25 10:22:31   N/A    初版
*
* Copyright (c) 2013 Wiimedia Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：西安微媒软件有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace ECommerce.CM.Model
{
	/// <summary>
	/// PointRule:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PointRule
	{
		public PointRule()
		{}
		#region Model
		private int _rid;
		private string _rname;
		private string _rxvalue;
		private string _ryvalue;
		/// <summary>
		/// 
		/// </summary>
		public int RID
		{
			set{ _rid=value;}
			get{return _rid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RName
		{
			set{ _rname=value;}
			get{return _rname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RxValue
		{
			set{ _rxvalue=value;}
			get{return _rxvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RyValue
		{
			set{ _ryvalue=value;}
			get{return _ryvalue;}
		}
		#endregion Model

	}
}


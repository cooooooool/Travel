/**  版本信息模板在安装目录下，可自行修改。
* CMArea.cs
*
* 功 能： N/A
* 类 名： CMArea
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/2/24 17:00:40   N/A    初版
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
	/// CMArea:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CMArea
	{
		public CMArea()
		{}
		#region Model
		private int? _aid;
		private string _areaid;
		/// <summary>
		/// 
		/// </summary>
		public int? AId
		{
			set{ _aid=value;}
			get{return _aid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AreaId
		{
			set{ _areaid=value;}
			get{return _areaid;}
		}
		#endregion Model

	}
}


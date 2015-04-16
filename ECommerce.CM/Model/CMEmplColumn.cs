﻿/**  版本信息模板在安装目录下，可自行修改。
* ProductBrand.cs
*
* 功 能： N/A
* 类 名： ProductBrand
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013/12/27 9:27:28   N/A    初版
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
	/// CMEmplColumn:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CMEmplColumn
	{
		public CMEmplColumn()
		{}
		#region Model
		private int _ecid;
		private int? _emplid;
		private int? _colid;
		/// <summary>
		/// 
		/// </summary>
		public int ECId
		{
			set{ _ecid=value;}
			get{return _ecid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EmplId
		{
			set{ _emplid=value;}
			get{return _emplid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ColId
		{
			set{ _colid=value;}
			get{return _colid;}
		}
		#endregion Model

	}
}


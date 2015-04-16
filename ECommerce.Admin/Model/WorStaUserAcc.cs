﻿/**  版本信息模板在安装目录下，可自行修改。
* WorStaUserAcc.cs
*
* 功 能： N/A
* 类 名： WorStaUserAcc
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014-02-24 15:22:23   N/A    初版
*
* Copyright (c) 2013 Wiimedia Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：西安微媒软件有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace ECommerce.Admin.Model
{
	/// <summary>
	/// WorStaUserAcc:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class WorStaUserAcc
	{
		public WorStaUserAcc()
		{}
		#region Model
		private int? _emplid;
		private int? _cid;
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
		public int? CId
		{
			set{ _cid=value;}
			get{return _cid;}
		}
		#endregion Model

	}
}


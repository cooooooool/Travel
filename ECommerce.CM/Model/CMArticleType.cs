﻿/**  版本信息模板在安装目录下，可自行修改。
* CMArticleType.cs
*
* 功 能： N/A
* 类 名： CMArticleType
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/2/28 11:19:50   N/A    初版
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
	/// CMArticleType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CMArticleType
	{
		public CMArticleType()
		{}
		#region Model
		private int _atid;
		private string _atname;
		private string _displaycss;
		private string _colorvalue;
		/// <summary>
		/// 
		/// </summary>
		public int ATId
		{
			set{ _atid=value;}
			get{return _atid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ATName
		{
			set{ _atname=value;}
			get{return _atname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DisplayCss
		{
			set{ _displaycss=value;}
			get{return _displaycss;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ColorValue
		{
			set{ _colorvalue=value;}
			get{return _colorvalue;}
		}
		#endregion Model

	}
}


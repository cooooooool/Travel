/**  版本信息模板在安装目录下，可自行修改。
* LandCustomer.cs
*
* 功 能： N/A
* 类 名： LandCustomer
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/6/24 10:04:31   N/A    初版
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
	/// LandCustomer:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LandCustomer
	{
		public LandCustomer()
		{}
		#region Model
		private int _lcid;
		private int? _lid;
		private int? _cid;
		private string _zwname;
		private decimal? _area;
		/// <summary>
		/// 
		/// </summary>
		public int LCId
		{
			set{ _lcid=value;}
			get{return _lcid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LId
		{
			set{ _lid=value;}
			get{return _lid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CId
		{
			set{ _cid=value;}
			get{return _cid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZwName
		{
			set{ _zwname=value;}
			get{return _zwname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Area
		{
			set{ _area=value;}
			get{return _area;}
		}
		#endregion Model

	}
}


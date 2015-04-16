﻿/**  版本信息模板在安装目录下，可自行修改。
* TemplatePar.cs
*
* 功 能： N/A
* 类 名： TemplatePar
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  1/1/2015 1:03:03 AM   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace ECommerce.Admin.DAL
{
    /// <summary>
    /// 数据访问类:TemplatePar
    /// </summary>
    public partial class TemplatePar
    {
        public TemplatePar()
        { }
        #region  Method

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            string strsql = "select max(TPID)+1 from TemplatePar";
            Database db = DatabaseFactory.CreateDatabase();
            object obj = db.ExecuteScalar(CommandType.Text, strsql);
            if (obj != null && obj != DBNull.Value)
            {
                return int.Parse(obj.ToString());
            }
            return 1;
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int TPID)
        {
            Database db = DatabaseFactory.CreateDatabase();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TemplatePar where TPID=@TPID ");
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());
            db.AddInParameter(dbCommand, "TPID", DbType.Int32, TPID);
            int cmdresult;
            object obj = db.ExecuteScalar(dbCommand);
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.TemplatePar model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TemplatePar(");
            strSql.Append("TID,SortNum,BgWidth,BgHeight)");

            strSql.Append(" values (");
            strSql.Append("@TID,@SortNum,@BgWidth,@BgHeight)");
            strSql.Append(";select @@IDENTITY");
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());
            db.AddInParameter(dbCommand, "TID", DbType.Int32, model.TID);
            db.AddInParameter(dbCommand, "SortNum", DbType.Int32, model.SortNum);
            db.AddInParameter(dbCommand, "BgWidth", DbType.Int32, model.BgWidth);
            db.AddInParameter(dbCommand, "BgHeight", DbType.Int32, model.BgHeight);
            int result;
            object obj = db.ExecuteScalar(dbCommand);
            if (!int.TryParse(obj.ToString(), out result))
            {
                return 0;
            }
            return result;
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.TemplatePar model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TemplatePar set ");
            strSql.Append("TID=@TID,");
            strSql.Append("SortNum=@SortNum,");
            strSql.Append("BgWidth=@BgWidth,");
            strSql.Append("BgHeight=@BgHeight");
            strSql.Append(" where TPID=@TPID ");
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());
            db.AddInParameter(dbCommand, "TPID", DbType.Int32, model.TPID);
            db.AddInParameter(dbCommand, "TID", DbType.Int32, model.TID);
            db.AddInParameter(dbCommand, "SortNum", DbType.Int32, model.SortNum);
            db.AddInParameter(dbCommand, "BgWidth", DbType.Int32, model.BgWidth);
            db.AddInParameter(dbCommand, "BgHeight", DbType.Int32, model.BgHeight);
            int rows = db.ExecuteNonQuery(dbCommand);

            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int TPID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TemplatePar ");
            strSql.Append(" where TPID=@TPID ");
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());
            db.AddInParameter(dbCommand, "TPID", DbType.Int32, TPID);
            int rows = db.ExecuteNonQuery(dbCommand);

            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string TPIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TemplatePar ");
            strSql.Append(" where TPID in (" + TPIDlist + ")  ");
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());
            int rows = db.ExecuteNonQuery(dbCommand);

            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.TemplatePar GetModel(int TPID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select TPID,TID,SortNum,BgWidth,BgHeight from TemplatePar ");
            strSql.Append(" where TPID=@TPID ");
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());
            db.AddInParameter(dbCommand, "TPID", DbType.Int32, TPID);
            Model.TemplatePar model = null;
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                if (dataReader.Read())
                {
                    model = ReaderBind(dataReader);
                }
            }
            return model;
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.TemplatePar DataRowToModel(DataRow row)
        {
            Model.TemplatePar model = new Model.TemplatePar();
            if (row != null)
            {
                if (row["TPID"] != null && row["TPID"].ToString() != "")
                {
                    model.TPID = Convert.ToInt32(row["TPID"].ToString());
                }
                if (row["TID"] != null && row["TID"].ToString() != "")
                {
                    model.TID = Convert.ToInt32(row["TID"].ToString());
                }
                if (row["SortNum"] != null && row["SortNum"].ToString() != "")
                {
                    model.SortNum = Convert.ToInt32(row["SortNum"].ToString());
                }
                if (row["BgWidth"] != null && row["BgWidth"].ToString() != "")
                {
                    model.BgWidth = Convert.ToInt32(row["BgWidth"].ToString());
                }
                if (row["BgHeight"] != null && row["BgHeight"].ToString() != "")
                {
                    model.BgHeight = Convert.ToInt32(row["BgHeight"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// <param name="strWhere">查询条件 Status=@Status and Cell=@Cell order by CreateDate Desc  like写法:'%'+@Cell+'%' </param>
        /// <param name="parameters">List<SqlParameter> parameters</param>
        /// </summary>
        public DataSet GetList(string strWhere, List<SqlParameter> parameters)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select TPID,TID,SortNum,BgWidth,BgHeight ");
            strSql.Append(" FROM TemplatePar ");
            Database db = DatabaseFactory.CreateDatabase();
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());
            if (parameters.Count > 0)
            {
                foreach (SqlParameter sqlParameter in parameters)
                {
                    dbCommand.Parameters.Add(sqlParameter);
                }
            }
            return db.ExecuteDataSet(dbCommand);
        }

        /// <summary>
        /// 获得前几行数据
        /// <param name="Top">int Top</param>
        /// <param name="strWhere">查询条件 Status=@Status and Cell=@Cell order by CreateDate Desc  like写法:'%'+@Cell+'%' </param>
        /// <param name="parameters">List<SqlParameter> parameters</param>
        /// </summary>
        public DataSet GetList(int Top, string strWhere, List<SqlParameter> parameters)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" TPID,TID,SortNum,BgWidth,BgHeight ");
            strSql.Append(" FROM TemplatePar ");
            Database db = DatabaseFactory.CreateDatabase();
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());
            if (parameters.Count > 0)
            {
                foreach (SqlParameter sqlParameter in parameters)
                {
                    dbCommand.Parameters.Add(sqlParameter);
                }
            }
            return db.ExecuteDataSet(dbCommand);
        }

        /*
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql=new StringBuilder();
            strSql.Append("select count(1) FROM TemplatePar ");
            if(strWhere.Trim()!="")
            {
                strSql.Append(" where "+strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }*/
        /// <summary>
        /// 分页获取数据列表
        /// <param name="strWhere">查询条件 Status=@Status and Cell=@Cell  like写法:'%'+@Cell+'%' </param>
        /// <param name="orderby">string orderby</param>
        /// <param name="startIndex">开始页码</param>
        /// <param name="endIndex">结束页码</param>
        /// <param name="parameters">List<SqlParameter> parameters</param>
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex, List<SqlParameter> parameters)
        {
            Database db = DatabaseFactory.CreateDatabase();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.TPID desc");
            }
            strSql.Append(")AS Row, T.*  from TemplatePar T ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());
            if (parameters.Count > 0)
            {
                foreach (SqlParameter sqlParameter in parameters)
                {
                    dbCommand.Parameters.Add(sqlParameter);
                }
            }
            return db.ExecuteDataSet(dbCommand);
        }


        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand dbCommand = db.GetStoredProcCommand("UP_GetRecordByPage");
            db.AddInParameter(dbCommand, "tblName", DbType.AnsiString, "TemplatePar");
            db.AddInParameter(dbCommand, "fldName", DbType.AnsiString, "TPID");
            db.AddInParameter(dbCommand, "PageSize", DbType.Int32, PageSize);
            db.AddInParameter(dbCommand, "PageIndex", DbType.Int32, PageIndex);
            db.AddInParameter(dbCommand, "IsReCount", DbType.Boolean, 0);
            db.AddInParameter(dbCommand, "OrderType", DbType.Boolean, 0);
            db.AddInParameter(dbCommand, "strWhere", DbType.AnsiString, strWhere);
            return db.ExecuteDataSet(dbCommand);
        }

        /// <summary>
        /// 获得数据列表（比DataSet效率高，推荐使用）
        /// <param name="strWhere">查询条件 Status=@Status and Cell=@Cell order by CreateDate Desc  like写法:'%'+@Cell+'%' </param>
        /// <param name="parameters">List<SqlParameter> parameters</param>
        /// </summary>
        public List<Model.TemplatePar> GetListArray(string strWhere, List<SqlParameter> parameters)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select TPID,TID,SortNum,BgWidth,BgHeight ");
            strSql.Append(" FROM TemplatePar ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());
            if (parameters.Count > 0)
            {
                foreach (SqlParameter sqlParameter in parameters)
                {
                    dbCommand.Parameters.Add(sqlParameter);
                }
            }
            List<Model.TemplatePar> list = new List<Model.TemplatePar>();
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    list.Add(ReaderBind(dataReader));
                }
            }
            return list;
        }


        /// <summary>
        /// 对象实体绑定数据
        /// </summary>
        public Model.TemplatePar ReaderBind(IDataReader dataReader)
        {
            Model.TemplatePar model = new Model.TemplatePar();
            object ojb;
            ojb = dataReader["TPID"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.TPID = Convert.ToInt32(ojb);
            }
            ojb = dataReader["TID"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.TID = Convert.ToInt32(ojb);
            }
            ojb = dataReader["SortNum"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.SortNum = Convert.ToInt32(ojb);
            }
            ojb = dataReader["BgWidth"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.BgWidth = Convert.ToInt32(ojb);
            }
            ojb = dataReader["BgHeight"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.BgHeight = Convert.ToInt32(ojb);
            }
            return model;
        }

        #endregion  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.TemplatePar GetModel(string strWhere, List<SqlParameter> parameters)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TemplatePar ");
            Database db = DatabaseFactory.CreateDatabase();
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());
            if (parameters.Count > 0)
            {
                foreach (SqlParameter sqlParameter in parameters)
                {
                    dbCommand.Parameters.Add(sqlParameter);
                }
            }
            Model.TemplatePar model = null;
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                if (dataReader.Read())
                {
                    model = ReaderBind(dataReader);
                }
            }
            return model;
        }

    }
}


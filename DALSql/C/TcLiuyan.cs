using Maticsoft.DBUtility;

/**
* Copyright (c) 2013-2020 GC.net. All rights reserved.
*┌──────────────────────────────────┐
*│  作者QQ:632029078  email: 632029078@qq.com
*│　版权所有：GC版权所有 http:
*└──────────────────────────────────┘
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Tc.DAL
{
    //TcLiuyan
    public partial class TcLiuyan
    {
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TcLiuyan");
            strSql.Append(" where ");
            strSql.Append(" ID = @ID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Tc.Model.TcLiuyan model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TcLiuyan(");
            strSql.Append("Xingming,QQ,GongsiMc,Email,Dianhua,Dizhi,Neirong,RukuSj");
            strSql.Append(") values (");
            strSql.Append("@Xingming,@QQ,@GongsiMc,@Email,@Dianhua,@Dizhi,@Neirong,@RukuSj");
            strSql.Append(") ");
            strSql.Append(";select IDENT_CURRENT('TcLiuyan')");
            SqlParameter[] parameters = {
			            new SqlParameter("@Xingming", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@QQ", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@GongsiMc", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@Email", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@Dianhua", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@Dizhi", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@Neirong", SqlDbType.NText) ,
                        new SqlParameter("@RukuSj", SqlDbType.DateTime)
            };

            parameters[0].Value = model.Xingming;
            parameters[1].Value = model.QQ;
            parameters[2].Value = model.GongsiMc;
            parameters[3].Value = model.Email;
            parameters[4].Value = model.Dianhua;
            parameters[5].Value = model.Dizhi;
            parameters[6].Value = model.Neirong;
            parameters[7].Value = model.RukuSj;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Tc.Model.TcLiuyan model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TcLiuyan set ");

            strSql.Append(" Xingming = @Xingming , ");
            strSql.Append(" QQ = @QQ , ");
            strSql.Append(" GongsiMc = @GongsiMc , ");
            strSql.Append(" Email = @Email , ");
            strSql.Append(" Dianhua = @Dianhua , ");
            strSql.Append(" Dizhi = @Dizhi , ");
            strSql.Append(" Neirong = @Neirong , ");
            strSql.Append(" RukuSj = @RukuSj  ");
            strSql.Append(" where ID=@ID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@ID", SqlDbType.Int,4) ,
                        new SqlParameter("@Xingming", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@QQ", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@GongsiMc", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@Email", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@Dianhua", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@Dizhi", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@Neirong", SqlDbType.NText) ,
                        new SqlParameter("@RukuSj", SqlDbType.DateTime)
            };

            parameters[0].Value = model.ID;
            parameters[1].Value = model.Xingming;
            parameters[2].Value = model.QQ;
            parameters[3].Value = model.GongsiMc;
            parameters[4].Value = model.Email;
            parameters[5].Value = model.Dianhua;
            parameters[6].Value = model.Dizhi;
            parameters[7].Value = model.Neirong;
            parameters[8].Value = model.RukuSj;
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TcLiuyan ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TcLiuyan ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        /// 批量删除一批数据
        /// </summary>
        public void Delete(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from  ");
            strSql.Append(" TcLiuyan ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Tc.Model.TcLiuyan GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID, Xingming, QQ, GongsiMc, Email, Dianhua, Dizhi, Neirong, RukuSj  ");
            strSql.Append("  from TcLiuyan ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            Tc.Model.TcLiuyan model = new Tc.Model.TcLiuyan();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.Xingming = ds.Tables[0].Rows[0]["Xingming"].ToString();
                model.QQ = ds.Tables[0].Rows[0]["QQ"].ToString();
                model.GongsiMc = ds.Tables[0].Rows[0]["GongsiMc"].ToString();
                model.Email = ds.Tables[0].Rows[0]["Email"].ToString();
                model.Dianhua = ds.Tables[0].Rows[0]["Dianhua"].ToString();
                model.Dizhi = ds.Tables[0].Rows[0]["Dizhi"].ToString();
                model.Neirong = ds.Tables[0].Rows[0]["Neirong"].ToString();
                if (ds.Tables[0].Rows[0]["RukuSj"].ToString() != "")
                {
                    model.RukuSj = DateTime.Parse(ds.Tables[0].Rows[0]["RukuSj"].ToString());
                }

                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TcLiuyan ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" * ");
            strSql.Append(" FROM TcLiuyan ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="orderby"></param>
        /// <param name="startrecordindex"></param>
        /// <param name="pagesize"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public DataSet Get_Page_List(string orderby, int startrecordindex, int pagesize, string where)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@tablename", SqlDbType.VarChar,200),
					new SqlParameter("@orderby", SqlDbType.VarChar,200),
					new SqlParameter("@pagestart", SqlDbType.Int),
					new SqlParameter("@pagesize", SqlDbType.Int),
                    new SqlParameter("@where",SqlDbType.VarChar)
					};
            parameters[0].Value = "TcLiuyan";
            parameters[1].Value = orderby;
            parameters[2].Value = startrecordindex;
            parameters[3].Value = pagesize;
            parameters[4].Value = where;
            return DbHelperSQL.RunProcedure("p_b_get_page", parameters, "ds");
        }
    }
}
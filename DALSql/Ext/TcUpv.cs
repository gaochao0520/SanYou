using Maticsoft.DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Tc.DAL
{
    public class TcUpv
    {
        /// <summary>
        /// 1.0升级2.0，更新数据库
        /// </summary>
        /// <returns></returns>
        public int ToV2()
        {
            var res = 0;
            try
            {
                string sql = @"alter table TcLinks add Types  nvarchar(200) null;
                                alter table TcDanye add Types  nvarchar(200) null;
                                alter table TcDanye add Url  nvarchar(200) null;
                                create table TcKuozhan (
                                   ID                   int                  identity,
                                   TabName              varchar(50)          null,
                                   Fid                  int                  null,
                                   Types                varchar(50)          null,
                                   Shuju                nvarchar(2000)       null,
                                   Addtime              datetime             null,
                                   constraint PK_TCKUOZHAN primary key (ID)
                                )
                        ";
                res = DbHelperSQL.ExecuteSql(sql);
            }

            catch
            {
                res = -99;
            }

            return res;
        }
    }
}
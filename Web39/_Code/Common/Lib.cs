using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tc
{
    public class Lib
    {
        public const string SysTitle = "GC企业建站系统- Powered by GC.net";

        private static string _theme = "";

        public static string theme
        {
            get
            {
                //if (_theme == "")
                //    _theme = "/themes/" + Cfg.Get("theme") + "/";
                //return _theme;
                return "/";
            }
        }

        /// <summary>
        /// 获取友情链接是否显示
        /// </summary>
        /// <param name="xianshi"></param>
        /// <returns></returns>
        public static string get_links_xianshis(int xianshi)
        {
            if (xianshi == 1)
            {
                return "显示";
            }
            else
            {
                return "不显示";
            }
        }

        /// <summary>
        /// 获取友情链接是否显示
        /// </summary>
        /// <param name="xianshi"></param>
        /// <returns></returns>
        public static string get_links_xianshis(object xianshi)
        {
            return get_links_xianshis(xianshi.GetString().GetInt());
        }
    }
}
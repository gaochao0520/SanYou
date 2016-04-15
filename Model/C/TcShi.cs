/**
* Copyright (c) 2013-2020 GC.net. All rights reserved.
*┌──────────────────────────────────┐
*│  作者QQ:632029078  email: 632029078@qq.com
*│　版权所有：GC版权所有(http:)　│
*└──────────────────────────────────┘
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Tc.Model
{
    //TcShi
    public partial class TcShi
    {
        public TcShi()
        {
            _id = 0;
            _code = "";
            _name = "";
            _shengcode = "";
            _paixu = 0;
        }

        /// <summary>
        /// ID
        /// </summary>
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Code
        /// </summary>
        private string _code;

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// Name
        /// </summary>
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// ShengCode
        /// </summary>
        private string _shengcode;

        public string ShengCode
        {
            get { return _shengcode; }
            set { _shengcode = value; }
        }

        /// <summary>
        /// Paixu
        /// </summary>
        private int? _paixu;

        public int? Paixu
        {
            get { return _paixu; }
            set { _paixu = value; }
        }
    }
}
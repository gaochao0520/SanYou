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
    //TcAdmin
    public partial class TcAdmin
    {
        public TcAdmin()
        {
            _id = 0;
            _name = "";
            _pwd = "";
            _role = 0;
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
        /// Name
        /// </summary>
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Pwd
        /// </summary>
        private string _pwd;

        public string Pwd
        {
            get { return _pwd; }
            set { _pwd = value; }
        }

        /// <summary>
        /// Role
        /// </summary>
        private int? _role;

        public int? Role
        {
            get { return _role; }
            set { _role = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using Easy.DataProxy;

namespace Services
{
    /// <summary>
    /// 系统用户 
    /// </summary>    
    public partial class SysUserService : BaseService<SysUser>
    {

        public SysUser Get(string account, string pwd)
        {
            var sql = @"
Select *
From SysUser
Where Account = @account And Pwd = @pwd
";
            return DbHelper.GetModel<SysUser>(sql, new DbField("account", account), new DbField("pwd", pwd));
        }

    }
}

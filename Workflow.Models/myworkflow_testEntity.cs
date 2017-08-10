using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuLu.ApplicationCore.Entity;

namespace Workflow.Models
{
    /// <summary>
    /// 版 本
    /// Copyright (c) 2013-2016 FuLu
    /// 创 建：shaomz
    /// 日 期：2017-08-09 18:22:30
    /// 描 述：myworkflow_test
    /// </summary>
    public class myworkflow_testEntity : BaseEntity
    {
        #region 实体成员
        /// <summary>
        /// id
        /// </summary>
        /// <returns></returns>
        public Guid id { get; set; }
        /// <summary>
        /// name
        /// </summary>
        /// <returns></returns>
        public string name { get; set; }
        /// <summary>
        /// sex
        /// </summary>
        /// <returns></returns>
        public byte? sex { get; set; }
        #endregion

        #region 扩展操作
        /// <summary>
        /// 新增调用
        /// </summary>
        public override void Create()
        {
            this. id= Guid.NewGuid();
        }
        /// <summary>
        /// 编辑调用
        /// </summary>
        /// <param name="keyValue"></param>
        public override void Modify(string keyValue)
        {
            this.id = new Guid(keyValue);
        }
        #endregion
    }

}

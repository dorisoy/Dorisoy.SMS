namespace SMS.Data
{
    /// <summary>
    /// 实体对象状态
    /// </summary>
    public enum ObjectState
    {
        /// <summary>
        /// 已添加
        /// </summary>
        Added,
        /// <summary>
        /// 已修改
        /// </summary>
        Modified,
        /// <summary>
        /// 已删除
        /// </summary>
        Deleted,
        /// <summary>
        /// 未更改
        /// </summary>
        Unchanged,
    }
}

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMS.Data
{
  /// <summary>
  /// 用于表示实体基类
  /// </summary>
  public abstract class BaseEntity
  {
    private DateTime _createdDate;
    private DateTime _modifiedDate;
    private DateTime? _deletedDate;


    [ForeignKey(name: "Id")]
    public Guid Id { get; set; } = Guid.NewGuid();


    /// <summary>
    /// 创建时间
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime CreatedDate
    {
      get => _createdDate.ToLocalTime();
      set => _createdDate = value.ToLocalTime();
    }

    /// <summary>
    /// 创建人
    /// </summary>
    public Guid CreatedBy { get; set; }


    /// <summary>
    /// 修改时间
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate
    {
      get => _modifiedDate.ToLocalTime();
      set => _modifiedDate = value.ToLocalTime();
    }

    /// <summary>
    /// 修改人
    /// </summary>
    public Guid ModifiedBy { get; set; }

    /// <summary>
    /// 删除时间
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? DeletedDate
    {
      get => _deletedDate?.ToLocalTime();
      set => _deletedDate = value?.ToLocalTime();
    }

    /// <summary>
    /// 删除人
    /// </summary>
    public Guid? DeletedBy { get; set; }


    /// <summary>
    /// 对象状态
    /// </summary>
    [NotMapped]
    public ObjectState ObjectState { get; set; }

    /// <summary>
    /// 标志是否已删除
    /// </summary>
    public bool IsDeleted { get; set; } = false;
  }
}

using System;
namespace TaskCategory.Core.Entities
{
	public abstract class EntityBase : IEntityBase
	{
		public virtual Guid Id { get; set; } = Guid.NewGuid();
		public virtual string CreatedBy { get; set; }
		public virtual string? ModifyBy { get; set; }
        public virtual string? DeleteBy { get; set; }
		public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime? ModifyDate { get; set; } = DateTime.Now;
        public virtual DateTime? DeleteDate { get; set; } = DateTime.Now;
		public virtual bool IsDeleted { get; set; }
	}
}


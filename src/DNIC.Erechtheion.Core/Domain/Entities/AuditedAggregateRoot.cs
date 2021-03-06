﻿using System;

namespace DNIC.Erechtheion.Core.Domain.Entities
{
	public abstract class AuditedAggregateRoot : AggregateRoot, IAudited
	{
		/// <summary>
		/// Last modification date of this entity.
		/// </summary>
		public virtual DateTime? LastModificationTime { get; set; }

		/// <summary>
		/// Last modifier user of this entity.
		/// </summary>
		public virtual long? LastModifierUserId { get; set; }

		/// <summary>
		/// Creation time of this entity.
		/// </summary>
		public virtual DateTime? CreationTime { get; set; }

		/// <summary>
		/// Creator of this entity.
		/// </summary>
		public virtual long? CreatorUserId { get; set; }
	}

	public abstract class AuditedAggregateRoot<TPrimaryKey, TAggregateId> : AggregateRoot<TPrimaryKey, TAggregateId>, IAudited
	{
		/// <summary>
		/// Last modification date of this entity.
		/// </summary>
		public virtual DateTime? LastModificationTime { get; set; }

		/// <summary>
		/// Last modifier user of this entity.
		/// </summary>
		public virtual long? LastModifierUserId { get; set; }

		/// <summary>
		/// Creation time of this entity.
		/// </summary>
		public virtual DateTime? CreationTime { get; set; }

		/// <summary>
		/// Creator of this entity.
		/// </summary>
		public virtual long? CreatorUserId { get; set; }

		protected AuditedAggregateRoot(TAggregateId aggregateId) : base(aggregateId)
		{
		}
	}
}
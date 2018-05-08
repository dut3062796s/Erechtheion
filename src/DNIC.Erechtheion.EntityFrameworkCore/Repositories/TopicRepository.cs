﻿using System.Threading.Tasks;
using DNIC.Erechtheion.Domain.Repositories;
using DNIC.Erechtheion.Domain.Entities;

namespace DNIC.Erechtheion.EntityFrameworkCore.Repositories
{
	public class TopicRepository : ITopicRepository
	{
		private ErechtheionDbContext dbContext;

		public TopicRepository(ErechtheionDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public Task<int> CreateAsync(Topic topic)
		{
			throw new System.NotImplementedException();
		}

		public Task<int> DeleteAsync(Topic topic)
		{
			throw new System.NotImplementedException();
		}

		public Task<int> UpdateAsync(Topic topic)
		{
			throw new System.NotImplementedException();
		}
	}
}
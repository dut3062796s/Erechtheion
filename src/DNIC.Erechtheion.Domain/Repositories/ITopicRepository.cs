﻿using System.Threading.Tasks;
using DNIC.Erechtheion.Domain.Entities;

namespace DNIC.Erechtheion.Domain.Repositories
{
	public interface ITopicRepository
	{
		Task<int> CreateAsync(Topic topic);

		Task<int> UpdateAsync(Topic topic);

		Task<int> DeleteAsync(Topic topic);
	}
}
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boards.Server.Models
{
	public class DatabaseSettings : IDatabaseSettings
	{
		public string BoardsDatabaseName { get; set; }
		public string BoardsConnectionString { get; set; }
		public string BoardsCollectionName { get; set; }
	}
	public interface IDatabaseSettings
	{
		string BoardsDatabaseName { get; set; }
		string BoardsConnectionString { get; set; }
		string BoardsCollectionName { get; set; }
	}
}

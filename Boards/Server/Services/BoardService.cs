using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boards.Server.Models;
using Boards.Server.Models.MD;
using MongoDB.Driver;

namespace Boards.Server.Services
{
	public class BoardService
	{
		private readonly IMongoCollection<Board> _board;

		public BoardService(IDatabaseSettings settings)
		{
			var client = new MongoClient(settings.BoardsConnectionString);
			var database = client.GetDatabase(settings.BoardsDatabaseName);

			_board = database.GetCollection<Board>(settings.BoardsCollectionName);
		}
		public List<Board> Get()
		{
			return _board.Find(board => true).ToList();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boards.Server.Models.DTO;
using Boards.Server.Services;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Boards.Server.Utilities
{
	public class Utils : IUtils
	{
		BoardService _boardService;
		public Utils(BoardService boardService)
		{
			_boardService = boardService;
		}
		public Guid SaveBoard(BoardDTO dto)
		{

			var test = _boardService.Get();
			throw new NotImplementedException();
		}
	}
}

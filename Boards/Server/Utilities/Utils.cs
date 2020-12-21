using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boards.Shared.Models.DTO;
using Boards.Server.Models.MD;
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
		public string SaveBoard(BoardDTO dto)
		{

			var test = _boardService.Get();
			Board board = new Board() { bytes = dto.bytes };
			var result = _boardService.create(board);
			return result.Id;
		}
	}
}

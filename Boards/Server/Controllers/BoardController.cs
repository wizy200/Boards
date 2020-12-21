using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boards.Shared.Models.DTO;
using Boards.Server.Utilities;
using Microsoft.AspNetCore.Mvc;
using Boards.Server.Models.MD;

namespace Boards.Server.Controllers
{
	public class BoardController : Controller
	{
		private IUtils _utils;
		public BoardController(IUtils utils)
		{
			_utils = utils;
		}
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet("SaveBoardData/{img}")]
		public IActionResult SaveBoardData(string img)
		{
			BoardDTO dto = new BoardDTO();
			dto.bytes = img;
			var result =_utils.SaveBoard(dto);
			return Ok(result);
		}
	}
}

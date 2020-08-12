using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boards.Server.Models.DTO;
using Boards.Server.Utilities;
using Microsoft.AspNetCore.Mvc;

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
		public IActionResult SaveBoardData(BoardDTO dto)
		{
			_utils.SaveBoard(dto);
			return Ok();
		}
	}
}

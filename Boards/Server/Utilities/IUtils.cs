using Boards.Shared.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boards.Server.Utilities
{
	public interface IUtils
	{
		string SaveBoard(BoardDTO dto);
	}
}

using Boards.Server.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boards.Server.Utilities
{
	public interface IUtils
	{
		Guid SaveBoard(BoardDTO dto);
	}
}

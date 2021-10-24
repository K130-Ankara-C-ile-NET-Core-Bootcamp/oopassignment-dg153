using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPAssignment.Structs;

namespace OOPAssignment.Interfaces
{
	public interface ICollidableSurface
	{
		bool IsCoordinatesEmpty(Coordinates coordinates);
	}
}

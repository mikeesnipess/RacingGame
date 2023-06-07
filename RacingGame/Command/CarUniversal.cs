using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Command
{
    class CarUniversal
    {
		private readonly Command _leftCommand;
		private readonly Command _rightCommand;

		public CarUniversal(Command leftCommand,Command rightCommand)
		{
			_rightCommand= rightCommand;
			_leftCommand= leftCommand;
		}

		public void Left(KeyEventArgs e)
		{
			_leftCommand.Execute(e);

		}
		public void Right(KeyEventArgs e)
		{
			_rightCommand.Execute(e);

		}
    }
}

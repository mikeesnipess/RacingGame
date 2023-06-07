using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Decorator
{
    abstract class WayDecorator : IWay
    {
		protected IWay _iWay;
		public WayDecorator(IWay iWay)
		{
			_iWay = iWay;
		}
		public abstract void GetLevel(int speed);
    }
}

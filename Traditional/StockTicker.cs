using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Observer2.Models;

namespace Observer2.Traditional
{
	public class StockTicker : AbstractSubject
	{
		private Stock stock;
		public Stock Stock
		{
			get { return stock; }
			set
			{
				stock = value;
				this.Notify();
			}
		}
	}
}

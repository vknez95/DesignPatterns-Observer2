using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Observer2.Models;

namespace Observer2.EventAndDelegate
{
	public class StockChangeEventArgs : EventArgs
	{
		public StockChangeEventArgs(Stock s)
		{
			this.Stock = s;
		}
		public Stock Stock { get; set; }
	}
}

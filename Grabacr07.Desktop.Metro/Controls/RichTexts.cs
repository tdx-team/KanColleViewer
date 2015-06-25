﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grabacr07.Desktop.Metro.Controls
{
	public abstract class RichText
	{
		public string Text { get; set; }
	}

	public abstract class Link : RichText
	{
		public abstract void Click();
	}

	public class Regular : RichText { }
}

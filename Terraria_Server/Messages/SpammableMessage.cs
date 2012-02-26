﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Terraria_Server.Messages
{
	public abstract class SpammableMessage<T, V> : SlotMessageHandler
	{
		public Dictionary<T, V> Register = new Dictionary<T, V>();

		public void AddOrUpdate(T key, V val)
		{
			lock (Register)
			{
				if (Register.ContainsKey(key))
					Register.Remove(key);

				Register.Add(key, val);
			}
		}
	}
}
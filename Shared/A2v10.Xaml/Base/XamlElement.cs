﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace A2v10.Xaml
{
	public class XamlElement : ISupportInitialize
	{
		IDictionary<String, Bind> _bindings;

		internal XamlElement Parent { get; private set; }

		protected virtual void OnEndInit()
		{
		}

		internal void SetParent(XamlElement parent)
		{
			Parent = parent;
		}

		public Bind SetBinding(String name, Bind bind)
		{
			if (_bindings == null)
				_bindings = new Dictionary<String, Bind>();
			_bindings.Add(name, bind);
			return bind;
		}

		#region ISupportInitialize
		public void BeginInit()
		{
			// do nothing
		}

		public void EndInit()
		{
			OnEndInit();
		}
		#endregion
	}
}

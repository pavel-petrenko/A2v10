﻿// Copyright © 2022 Alex Kukhtin. All rights reserved.

using System;
using System.Dynamic;
using System.IO;

namespace A2v10.Infrastructure
{
	public interface IPdfReportShim
	{
		void Inject(ILocalizer localizer, IUserLocale userLocale);
		Stream Build(String path, ExpandoObject data);
	}
}

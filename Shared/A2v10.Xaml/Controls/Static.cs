﻿// Copyright © 2015-2023 Oleksandr Kukhtin. All rights reserved.

using System;

namespace A2v10.Xaml;

public class Static : ValuedControl, ITableControl
{
	public TextAlign Align { get; set; }
	public UInt32 MaxChars { get; set; }

	public override void RenderElement(RenderContext context, Action<TagBuilder> onRender = null)
	{
		if (SkipRender(context))
			return;
		var input = new TagBuilder("static", null, IsInGrid);
		onRender?.Invoke(input);
		MergeAttributes(input, context);
		MergeValue(input, context); // item, prop for validator
		MergeAlign(input, context, Align);
		SetSize(input, nameof(Static));
		var valBind = GetBinding(nameof(Value));
		if (valBind != null)
		{
			// formatted
			input.MergeAttribute(":text", MaxChars > 0 ? $"$maxChars({valBind.GetPathFormat(context)}, {MaxChars})" : valBind.GetPathFormat(context));
			if (valBind.NegativeRed)
				input.MergeAttribute(":class", $"$getNegativeRedClass({valBind.GetPath(context)})");
			if (MaxChars > 0)
				input.MergeAttribute(":title", valBind.GetPathFormat(context));
		}
		input.RenderStart(context);
		RenderAddOns(context);
		input.RenderEnd(context);
	}
}

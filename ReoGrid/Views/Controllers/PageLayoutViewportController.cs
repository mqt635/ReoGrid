﻿/*****************************************************************************
 * 
 * ReoGrid - .NET Spreadsheet Control
 * 
 * https://reogrid.net/
 *
 * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
 * KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
 * PURPOSE.
 *
 * Author: Jingwood <jingwood at unvell.com>
 *
 * Copyright (c) 2012-2025 Jingwood, unvell.com, all rights reserved.
 * 
 ****************************************************************************/

#define VP_DEBUG

using System.Collections.Generic;
using System.Diagnostics;

#if WINFORM || ANDROID
using RGFloat = System.Single;
using RGIntDouble = System.Int32;

#elif WPF
using RGFloat = System.Double;
using RGIntDouble = System.Double;

#elif iOS
using RGFloat = System.Double;
using RGIntDouble = System.Double;

#endif

using unvell.ReoGrid.Graphics;
using unvell.ReoGrid.Rendering;
using unvell.ReoGrid.Interaction;
using unvell.ReoGrid.Main;

namespace unvell.ReoGrid.Views
{

	#region PageLayout ViewportController
	//class PageLayoutViewportController : AbstractViewportController
	//{
	//	public PageLayoutViewportController(Worksheet grid, RGRect bounds) : base(grid) { }

	//	public override void OnBoundsChange()
	//	{
	//		throw new NotImplementedException();
	//	}

	//	public override void ScrollViews(ScrollDirection dir, RGFloat x, RGFloat y)
	//	{
	//		throw new NotImplementedException();
	//	}
	//}
	#endregion // PageLayout ViewportController

}


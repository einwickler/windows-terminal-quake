﻿using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace WindowsTerminalQuake.Native
{
	public static class User32
	{
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

		[DllImport("user32.dll")]
		public static extern IntPtr GetForegroundWindow();

		[DllImport("user32.dll")]
		public static extern IntPtr GetDesktopWindow();

		[DllImport("user32.dll")]
		public static extern IntPtr GetShellWindow();

		[DllImport("user32.dll")]
		public static extern IntPtr SetForegroundWindow(IntPtr hWnd);

		[DllImport("user32.dll")]
		public static extern bool ShowWindow(IntPtr hWnd, NCmdShow nCmdShow);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

		[DllImport("user32.dll")]
		public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

		[DllImport("user32.dll")]
		public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);

		[DllImport("user32.dll")]
		public static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

		public struct Rect
		{
			public int Left { get; set; }
			public int Top { get; set; }
			public int Right { get; set; }
			public int Bottom { get; set; }
		}

		public const int GWL_EX_STYLE = -20;

		public const int LWA_ALPHA = 0x2;
		public const int LWA_COLORKEY = 0x1;

		public const int WS_EX_APPWINDOW = 0x00040000;
		public const int WS_EX_LAYERED = 0x80000;
		public const int WS_EX_TOOLWINDOW = 0x00000080;

		public static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
		public const UInt32 SWP_NOSIZE = 0x0001;
		public const UInt32 SWP_NOMOVE = 0x0002;
		public const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

		public static void ThrowIfError()
		{
			// Throws "Access Denied" :(
			//var err = Marshal.GetLastWin32Error();
			//if (err != 0)
			//	throw new Win32Exception(err);
		}
	}
}
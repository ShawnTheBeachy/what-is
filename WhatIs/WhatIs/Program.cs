using System;
using System.IO;

namespace WhatIs
{
	class Program
	{
		static void Main(string[] args)
		{
			var full = false;
			var path = string.Empty;

			foreach (var arg in args)
			{
				if (arg.StartsWith("-"))
				{
					if (arg == "-full")
					{
						full = true;
					}
				}

				else
				{
					path = arg;
				}
			}

			Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), path));
			var info = new DirectoryInfo(path);
			Console.WriteLine(full ? info.FullName : info.Name);
		}
	}
}

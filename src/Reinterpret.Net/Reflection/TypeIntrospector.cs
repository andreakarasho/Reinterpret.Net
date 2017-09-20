﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Reinterpret.Net
{
	internal static class TypeIntrospector<TType>
	{
		public static bool IsPrimitive { get; } =
#if !NETSTANDARD1_1
		typeof(TType).IsPrimitive;
#else
		typeof(TType).GetTypeInfo().IsPrimitive;
#endif

		public static UIntPtr ArrayTypeHeader { get; } = PointerHelper.GetTypeHeaderValue<TType>();
	}
}

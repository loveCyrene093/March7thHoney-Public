using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KNCBIMAAFJGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KNCBIMAAFJGReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFLTkNCSU1BQUZKRy5wcm90bxoRSkNHQk5QS0pLSEIucHJvdG8irQEKC0tO";
		buffer[1] = "Q0JJTUFBRkpHEhEKCXVuaXF1ZV9pZBgBIAEoDRITCgtCSEpQRE1KREpNThgF";
		buffer[2] = "IAEoDRITCgtEREdFT09MSEFQRxgHIAEoDRITCgtDSkFLRUJOUEdGQRgJIAEo";
		buffer[3] = "BRITCgtDQ05KS0lBT01GRhgMIAEoBRILCgNleHAYDSABKA0SKgoUZXF1aXBt";
		buffer[4] = "ZW50X2dvb2RzX2luZm8YDiABKAsyDC5KQ0dCTlBLSktIQkIWqgITTWFyY2g3";
		buffer[5] = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { JCGBNPKJKHBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KNCBIMAAFJG), KNCBIMAAFJG.Parser, new string[7] { "UniqueId", "BHJPDMJDJMN", "DDGEOOLHAPG", "CJAKEBNPGFA", "CCNJKIAOMFF", "Exp", "EquipmentGoodsInfo" }, null, null, null, null)
		}));
	}
}

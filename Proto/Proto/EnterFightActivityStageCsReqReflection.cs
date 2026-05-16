using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterFightActivityStageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterFightActivityStageCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiJFbnRlckZpZ2h0QWN0aXZpdHlTdGFnZUNzUmVxLnByb3RvGhFJTE5FQlBK";
		buffer[1] = "Q0dIQi5wcm90byKQAQocRW50ZXJGaWdodEFjdGl2aXR5U3RhZ2VDc1JlcRIT";
		buffer[2] = "CgthdmF0YXJfbGlzdBgDIAMoDRIRCglpdGVtX2xpc3QYCCADKA0SEAoIZ3Jv";
		buffer[3] = "dXBfaWQYCyABKA0SIQoLRkRISkNCTkFJQ0IYDiADKAsyDC5JTE5FQlBKQ0dI";
		buffer[4] = "QhITCgtJTk9NRkZBSUVPQRgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[5] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ILNEBPJCGHBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterFightActivityStageCsReq), EnterFightActivityStageCsReq.Parser, new string[5] { "AvatarList", "ItemList", "GroupId", "FDHJCBNAICB", "INOMFFAIEOA" }, null, null, null, null)
		}));
	}
}

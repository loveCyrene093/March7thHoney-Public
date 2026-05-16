using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FINPEANNNKBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FINPEANNNKBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGSU5QRUFOTk5LQi5wcm90byIxCgtGSU5QRUFOTk5LQhINCgVsZXZlbBgI" + "IAEoDRITCgtNUEJCSUpNQUNMTBgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FINPEANNNKB), FINPEANNNKB.Parser, new string[2] { "Level", "MPBBIJMACLL" }, null, null, null, null)
		}));
	}
}

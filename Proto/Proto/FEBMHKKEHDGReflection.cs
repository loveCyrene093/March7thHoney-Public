using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FEBMHKKEHDGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FEBMHKKEHDGReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFGRUJNSEtLRUhERy5wcm90byKHAQoLRkVCTUhLS0VIREcSDwoHcm9vbV9p";
		buffer[1] = "ZBgBIAEoBBITCgtNTUxLRkpJQUtLSBgCIAEoDRITCgtOREtBSUFGUE5CShgD";
		buffer[2] = "IAEoDRITCgtMREtHSkJBTEdLQxgEIAEoDRITCgtIQkVIS0lBTUdMSxgFIAEo";
		buffer[3] = "CRITCgtQRUhPTk5ITklOQRgGIAEoCUIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[4] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FEBMHKKEHDG), FEBMHKKEHDG.Parser, new string[6] { "RoomId", "MMLKFJIAKKH", "NDKAIAFPNBJ", "LDKGJBALGKC", "HBEHKIAMGLK", "PEHONNHNINA" }, null, null, null, null)
		}));
	}
}

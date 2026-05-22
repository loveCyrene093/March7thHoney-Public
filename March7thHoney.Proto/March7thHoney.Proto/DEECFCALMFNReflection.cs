using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DEECFCALMFNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DEECFCALMFNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFERUVDRkNBTE1GTi5wcm90byIiCgtERUVDRkNBTE1GThITCgtIS0JQRUhC" + "TElBQxgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DEECFCALMFN), DEECFCALMFN.Parser, new string[1] { "HKBPEHBLIAC" }, null, null, null, null)
		}));
	}
}

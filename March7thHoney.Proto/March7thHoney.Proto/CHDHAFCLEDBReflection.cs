using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CHDHAFCLEDBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CHDHAFCLEDBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDSERIQUZDTEVEQi5wcm90bxoRSkFGUE1MTE9HREkucHJvdG8iRQoLQ0hE" + "SEFGQ0xFREISIQoLSUVHRlBKRkZDQU0YASADKAsyDC5KQUZQTUxMT0dESRIT" + "CgtNQkNOQUVBSk1ETRgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { JAFPMLLOGDIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CHDHAFCLEDB), CHDHAFCLEDB.Parser, new string[2] { "IEGFPJFFCAM", "MBCNAEAJMDM" }, null, null, null, null)
		}));
	}
}

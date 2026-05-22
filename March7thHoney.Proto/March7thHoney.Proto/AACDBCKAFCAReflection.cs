using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AACDBCKAFCAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AACDBCKAFCAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBQUNEQkNLQUZDQS5wcm90byJGCgtBQUNEQkNLQUZDQRITCgtHRUZHT0lH" + "SkhGShgGIAEoBBITCgtNT09PUEFNQk9GSxgHIAEoDRINCgVsZXZlbBgJIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AACDBCKAFCA), AACDBCKAFCA.Parser, new string[3] { "GEFGOIGJHFJ", "MOOOPAMBOFK", "Level" }, null, null, null, null)
		}));
	}
}

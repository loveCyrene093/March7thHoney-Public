using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NDBDDEAPIDPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NDBDDEAPIDPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOREJEREVBUElEUC5wcm90byI0CgtOREJEREVBUElEUBIQCghzdGFnZV9p" + "ZBgBIAEoDRITCgtJRkdJQkxPQUNQTRgCIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NDBDDEAPIDP), NDBDDEAPIDP.Parser, new string[2] { "StageId", "IFGIBLOACPM" }, null, null, null, null)
		}));
	}
}

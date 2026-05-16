using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IHJENBGPFBFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IHJENBGPFBFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJSEpFTkJHUEZCRi5wcm90byIrCgtJSEpFTkJHUEZCRhIKCgJpZBgBIAEo" + "DRIQCghwcm9ncmVzcxgCIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IHJENBGPFBF), IHJENBGPFBF.Parser, new string[2] { "Id", "Progress" }, null, null, null, null)
		}));
	}
}

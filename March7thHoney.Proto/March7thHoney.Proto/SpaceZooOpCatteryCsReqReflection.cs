using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SpaceZooOpCatteryCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SpaceZooOpCatteryCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxTcGFjZVpvb09wQ2F0dGVyeUNzUmVxLnByb3RvIlMKFlNwYWNlWm9vT3BD" + "YXR0ZXJ5Q3NSZXESDwoHb3BfdHlwZRgDIAEoDRITCgtJS0FHQklNSlBPTRgE" + "IAEoDRITCgtCRkxLSUpEUFBBSRgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SpaceZooOpCatteryCsReq), SpaceZooOpCatteryCsReq.Parser, new string[3] { "OpType", "IKAGBIMJPOM", "BFLKIJDPPAI" }, null, null, null, null)
		}));
	}
}

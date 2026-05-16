using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetMultipleAvatarPathsCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetMultipleAvatarPathsCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFTZXRNdWx0aXBsZUF2YXRhclBhdGhzQ3NSZXEucHJvdG8aGU11bHRpUGF0" + "aEF2YXRhclR5cGUucHJvdG8iSwobU2V0TXVsdGlwbGVBdmF0YXJQYXRoc0Nz" + "UmVxEiwKDmF2YXRhcl9pZF9saXN0GAQgAygOMhQuTXVsdGlQYXRoQXZhdGFy" + "VHlwZUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { MultiPathAvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetMultipleAvatarPathsCsReq), SetMultipleAvatarPathsCsReq.Parser, new string[1] { "AvatarIdList" }, null, null, null, null)
		}));
	}
}

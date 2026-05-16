using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneEntityTeleportCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneEntityTeleportCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch5TY2VuZUVudGl0eVRlbGVwb3J0Q3NSZXEucHJvdG8aEkVudGl0eU1vdGlv";
		buffer[1] = "bi5wcm90byJnChhTY2VuZUVudGl0eVRlbGVwb3J0Q3NSZXESJAoNZW50aXR5";
		buffer[2] = "X21vdGlvbhgGIAEoCzINLkVudGl0eU1vdGlvbhITCgtpbnRlcmFjdF9pZBgJ";
		buffer[3] = "IAEoBBIQCghlbnRyeV9pZBgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[4] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { EntityMotionReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneEntityTeleportCsReq), SceneEntityTeleportCsReq.Parser, new string[3] { "EntityMotion", "InteractId", "EntryId" }, null, null, null, null)
		}));
	}
}

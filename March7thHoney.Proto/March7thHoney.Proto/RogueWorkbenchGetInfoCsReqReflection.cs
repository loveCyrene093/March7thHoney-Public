using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueWorkbenchGetInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueWorkbenchGetInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSb2d1ZVdvcmtiZW5jaEdldEluZm9Dc1JlcS5wcm90byI0ChpSb2d1ZVdv" + "cmtiZW5jaEdldEluZm9Dc1JlcRIWCg5wcm9wX2VudGl0eV9pZBgDIAEoDUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueWorkbenchGetInfoCsReq), RogueWorkbenchGetInfoCsReq.Parser, new string[1] { "PropEntityId" }, null, null, null, null)
		}));
	}
}

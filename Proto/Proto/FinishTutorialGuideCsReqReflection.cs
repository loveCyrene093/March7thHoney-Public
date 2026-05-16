using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishTutorialGuideCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishTutorialGuideCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5GaW5pc2hUdXRvcmlhbEd1aWRlQ3NSZXEucHJvdG8aF1R1dG9yaWFsR3Vp" + "ZGVUeXBlLnByb3RvIk4KGEZpbmlzaFR1dG9yaWFsR3VpZGVDc1JlcRIQCghn" + "cm91cF9pZBgGIAEoDRIgCgR0eXBlGA4gASgOMhIuVHV0b3JpYWxHdWlkZVR5" + "cGVCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { TutorialGuideTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishTutorialGuideCsReq), FinishTutorialGuideCsReq.Parser, new string[2] { "GroupId", "Type" }, null, null, null, null)
		}));
	}
}

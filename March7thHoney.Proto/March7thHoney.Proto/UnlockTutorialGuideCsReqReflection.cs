using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UnlockTutorialGuideCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UnlockTutorialGuideCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5VbmxvY2tUdXRvcmlhbEd1aWRlQ3NSZXEucHJvdG8aF1R1dG9yaWFsR3Vp" + "ZGVUeXBlLnByb3RvIk4KGFVubG9ja1R1dG9yaWFsR3VpZGVDc1JlcRIgCgR0" + "eXBlGAggASgOMhIuVHV0b3JpYWxHdWlkZVR5cGUSEAoIZ3JvdXBfaWQYCyAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { TutorialGuideTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UnlockTutorialGuideCsReq), UnlockTutorialGuideCsReq.Parser, new string[2] { "Type", "GroupId" }, null, null, null, null)
		}));
	}
}

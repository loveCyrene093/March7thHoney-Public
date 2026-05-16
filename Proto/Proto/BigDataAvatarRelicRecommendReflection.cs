using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BigDataAvatarRelicRecommendReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BigDataAvatarRelicRecommendReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		buffer[0] = "CiFCaWdEYXRhQXZhdGFyUmVsaWNSZWNvbW1lbmQucHJvdG8aEUJLT0RMRE9G";
		buffer[1] = "TU1KLnByb3RvGhFGTkJKUE1HTUpEUC5wcm90byK6AgobQmlnRGF0YUF2YXRh";
		buffer[2] = "clJlbGljUmVjb21tZW5kEhEKCWF2YXRhcl9pZBgBIAEoDRIkCg5vdXRlcl9z";
		buffer[3] = "ZXRfbGlzdBgCIAMoCzIMLkZOQkpQTUdNSkRQEi8KGXNwaGVyZV9tYWluX3By";
		buffer[4] = "b3BlcnR5X2xpc3QYBCADKAsyDC5CS09ETERPRk1NShItChdyb3BlX21haW5f";
		buffer[5] = "cHJvcGVydHlfbGlzdBgHIAMoCzIMLkJLT0RMRE9GTU1KEiQKDmlubmVyX3Nl";
		buffer[6] = "dF9saXN0GAkgAygLMgwuRk5CSlBNR01KRFASLQoXZm9vdF9tYWluX3Byb3Bl";
		buffer[7] = "cnR5X2xpc3QYDSADKAsyDC5CS09ETERPRk1NShItChdib2R5X21haW5fcHJv";
		buffer[8] = "cGVydHlfbGlzdBgPIAMoCzIMLkJLT0RMRE9GTU1KQhaqAhNNYXJjaDd0aEhv";
		buffer[9] = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			BKODLDOFMMJReflection.Descriptor,
			FNBJPMGMJDPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BigDataAvatarRelicRecommend), BigDataAvatarRelicRecommend.Parser, new string[7] { "AvatarId", "OuterSetList", "SphereMainPropertyList", "RopeMainPropertyList", "InnerSetList", "FootMainPropertyList", "BodyMainPropertyList" }, null, null, null, null)
		}));
	}
}

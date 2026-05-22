using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ADLDDMAIFAIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ADLDDMAIFAIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBRExERE1BSUZBSS5wcm90bxoRUENEQUhLR01HTkIucHJvdG8iMAoLQURM" + "RERNQUlGQUkSIQoLTUpETUxPSUhMUEEYDCABKA4yDC5QQ0RBSEtHTUdOQkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { PCDAHKGMGNBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ADLDDMAIFAI), ADLDDMAIFAI.Parser, new string[1] { "MJDMLOIHLPA" }, null, null, null, null)
		}));
	}
}

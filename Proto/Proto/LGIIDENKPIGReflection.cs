using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LGIIDENKPIGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LGIIDENKPIGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMR0lJREVOS1BJRy5wcm90byJCCgtMR0lJREVOS1BJRxIQCghncm91cF9p" + "ZBgCIAEoDRITCgtJTk9NRkZBSUVPQRgLIAEoDRIMCgRzdGFyGAwgASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LGIIDENKPIG), LGIIDENKPIG.Parser, new string[3] { "GroupId", "INOMFFAIEOA", "Star" }, null, null, null, null)
		}));
	}
}

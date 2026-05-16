using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BGKNEEHCGEBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BGKNEEHCGEBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCR0tORUVIQ0dFQi5wcm90byJvCgtCR0tORUVIQ0dFQhITCgtKSExHRURH" + "TVBHRRgBIAEoDRITCgtNR0ZPSFBIRUhBUBgCIAEoDRITCgtDQ01MUElFSUxF" + "RxgDIAEoARIMCgR3YXZlGAQgASgNEhMKC0lCRkJHRUZMT0pLGAUgASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BGKNEEHCGEB), BGKNEEHCGEB.Parser, new string[5] { "JHLGEDGMPGE", "MGFOHPHEHAP", "CCMLPIEILEG", "Wave", "IBFBGEFLOJK" }, null, null, null, null)
		}));
	}
}

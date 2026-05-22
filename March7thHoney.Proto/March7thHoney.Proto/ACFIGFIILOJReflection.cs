using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ACFIGFIILOJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ACFIGFIILOJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBQ0ZJR0ZJSUxPSi5wcm90byJECgtBQ0ZJR0ZJSUxPShILCgNleHAYAyAB" + "KA0SEwoLUE9QUEdJREtMTUYYCSADKA0SEwoLR0RJUEVHRkJMQUIYDCADKA1C" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ACFIGFIILOJ), ACFIGFIILOJ.Parser, new string[3] { "Exp", "POPPGIDKLMF", "GDIPEGFBLAB" }, null, null, null, null)
		}));
	}
}

using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class WaitDelResourceReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static WaitDelResourceReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVXYWl0RGVsUmVzb3VyY2UucHJvdG8iKwoPV2FpdERlbFJlc291cmNlEgsK" + "A251bRgIIAEoDRILCgN0aWQYCSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(WaitDelResource), WaitDelResource.Parser, new string[2] { "Num", "Tid" }, null, null, null, null)
		}));
	}
}

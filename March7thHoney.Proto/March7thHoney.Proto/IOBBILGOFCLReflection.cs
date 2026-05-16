using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IOBBILGOFCLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IOBBILGOFCLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJT0JCSUxHT0ZDTC5wcm90byI1CgtJT0JCSUxHT0ZDTBIMCgRzbG90GAEg" + "ASgNEgoKAmlkGAUgASgNEgwKBHR5cGUYCSABKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IOBBILGOFCL), IOBBILGOFCL.Parser, new string[3] { "Slot", "Id", "Type" }, null, null, null, null)
		}));
	}
}

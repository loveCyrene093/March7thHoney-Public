using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicDiscardTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicDiscardTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZSZWxpY0Rpc2NhcmRUeXBlLnByb3RvKmkKEFJlbGljRGlzY2FyZFR5cGUS" + "GwoXRUdFSkdOQURPSEdfSUZQRExDT0lFTkYQABIbChdFR0VKR05BRE9IR19M" + "Qk9PQkhBTU5CSxABEhsKF0VHRUpHTkFET0hHX1BCS0dGRkNOQkJIEAJCFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(RelicDiscardType) }, null, null));
	}
}

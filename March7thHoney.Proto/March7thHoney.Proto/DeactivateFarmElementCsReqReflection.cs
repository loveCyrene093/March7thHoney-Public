using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DeactivateFarmElementCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DeactivateFarmElementCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBEZWFjdGl2YXRlRmFybUVsZW1lbnRDc1JlcS5wcm90byIvChpEZWFjdGl2" + "YXRlRmFybUVsZW1lbnRDc1JlcRIRCgllbnRpdHlfaWQYDSABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DeactivateFarmElementCsReq), DeactivateFarmElementCsReq.Parser, new string[1] { "EntityId" }, null, null, null, null)
		}));
	}
}

using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightBackToPrepareReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightBackToPrepareReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9HcmlkRmlnaHRCYWNrVG9QcmVwYXJlUmVxLnByb3RvIhsKGUdyaWRGaWdo" + "dEJhY2tUb1ByZXBhcmVSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightBackToPrepareReq), GridFightBackToPrepareReq.Parser, null, null, null, null, null)
		}));
	}
}

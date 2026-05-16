using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightPortalServerDataUpdateReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightPortalServerDataUpdateReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVHcmlkRmlnaHRQb3J0YWxTZXJ2ZXJEYXRhVXBkYXRlLnByb3RvIk4KH0dy" + "aWRGaWdodFBvcnRhbFNlcnZlckRhdGFVcGRhdGUSFgoOcG9ydGFsX2J1ZmZf" + "aWQYCyABKA0SEwoLUEVPRlBQT0ZJR0kYDyADKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightPortalServerDataUpdate), GridFightPortalServerDataUpdate.Parser, new string[2] { "PortalBuffId", "PEOFPPOFIGI" }, null, null, null, null)
		}));
	}
}

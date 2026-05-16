using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFarmStageGachaInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFarmStageGachaInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBHZXRGYXJtU3RhZ2VHYWNoYUluZm9Dc1JlcS5wcm90byI+ChpHZXRGYXJt" + "U3RhZ2VHYWNoYUluZm9Dc1JlcRIgChhmYXJtX3N0YWdlX2dhY2hhX2lkX2xp" + "c3QYBiADKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFarmStageGachaInfoCsReq), GetFarmStageGachaInfoCsReq.Parser, new string[1] { "FarmStageGachaIdList" }, null, null, null, null)
		}));
	}
}

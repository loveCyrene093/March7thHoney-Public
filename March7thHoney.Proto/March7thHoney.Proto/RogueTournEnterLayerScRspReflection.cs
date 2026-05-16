using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournEnterLayerScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournEnterLayerScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Sb2d1ZVRvdXJuRW50ZXJMYXllclNjUnNwLnByb3RvGhFCRkVJUEVMRkNE" + "Ri5wcm90byJPChlSb2d1ZVRvdXJuRW50ZXJMYXllclNjUnNwEiEKC0FGTEpK" + "SkZDQklOGAcgASgLMgwuQkZFSVBFTEZDREYSDwoHcmV0Y29kZRgIIAEoDUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { BFEIPELFCDFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournEnterLayerScRsp), RogueTournEnterLayerScRsp.Parser, new string[2] { "AFLJJJFCBIN", "Retcode" }, null, null, null, null)
		}));
	}
}

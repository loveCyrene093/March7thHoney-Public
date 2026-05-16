using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DeleteFriendCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DeleteFriendCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdEZWxldGVGcmllbmRDc1JlcS5wcm90byI1ChFEZWxldGVGcmllbmRDc1Jl" + "cRITCgtJUEdDRUdQSkVIQxgJIAEoDRILCgN1aWQYCyABKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DeleteFriendCsReq), DeleteFriendCsReq.Parser, new string[2] { "IPGCEGPJEHC", "Uid" }, null, null, null, null)
		}));
	}
}

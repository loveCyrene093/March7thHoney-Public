using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TravelBrochureRemovePasterCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TravelBrochureRemovePasterCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVUcmF2ZWxCcm9jaHVyZVJlbW92ZVBhc3RlckNzUmVxLnByb3RvIloKH1Ry" + "YXZlbEJyb2NodXJlUmVtb3ZlUGFzdGVyQ3NSZXESEwoLSEJDSlBDTUpQSEUY" + "BiABKA0SEQoJdW5pcXVlX2lkGAggASgEEg8KB2l0ZW1faWQYDyABKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TravelBrochureRemovePasterCsReq), TravelBrochureRemovePasterCsReq.Parser, new string[3] { "HBCJPCMJPHE", "UniqueId", "ItemId" }, null, null, null, null)
		}));
	}
}

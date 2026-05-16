using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetBagScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetBagScRspReflection()
	{
		_003C_003Ey__InlineArray17<string> buffer = default(_003C_003Ey__InlineArray17<string>);
		buffer[0] = "ChFHZXRCYWdTY1JzcC5wcm90bxoRQU5ETUxJRUdQS0UucHJvdG8aD0VxdWlw";
		buffer[1] = "bWVudC5wcm90bxoRSkxBRURLTUJHRUsucHJvdG8aDk1hdGVyaWFsLnByb3Rv";
		buffer[2] = "GhFQRkZEQUZKTE5PTy5wcm90bxoOUGlsZUl0ZW0ucHJvdG8aC1JlbGljLnBy";
		buffer[3] = "b3RvGhRUdXJuRm9vZFN3aXRjaC5wcm90bxoVV2FpdERlbFJlc291cmNlLnBy";
		buffer[4] = "b3RvIvkDCgtHZXRCYWdTY1JzcBIiCg5lcXVpcG1lbnRfbGlzdBgBIAMoCzIK";
		buffer[5] = "LkVxdWlwbWVudBIhCgtNS0tERk5ERUdBQhgCIAMoCzIMLkpMQUVES01CR0VL";
		buffer[6] = "EhMKC0lGTkFPR0FLSFBOGAMgASgNEjAKFndhaXRfZGVsX3Jlc291cmNlX2xp";
		buffer[7] = "c3QYBCADKAsyEC5XYWl0RGVsUmVzb3VyY2USJAoLTUFPRE5ITkhMSUoYBSAD";
		buffer[8] = "KA4yDy5UdXJuRm9vZFN3aXRjaBIeCgtIR0hJSUtOTEpLSBgGIAMoCzIJLlBp";
		buffer[9] = "bGVJdGVtEh4KC0NCQU5BS0tPTU9GGAcgAygLMgkuTWF0ZXJpYWwSEwoLREJQ";
		buffer[10] = "RFBISU1CREoYCCADKA0SIQoLR0hHS0NGSUZNQkIYCSADKAsyDC5KTEFFREtN";
		buffer[11] = "QkdFSxITCgtGR0VLTEJNTEhFSxgKIAMoDRIPCgdyZXRjb2RlGAsgASgNEhoK";
		buffer[12] = "CnJlbGljX2xpc3QYDCADKAsyBi5SZWxpYxIhCgtPS0dDR01DTVBKShgNIAMo";
		buffer[13] = "CzIMLkFORE1MSUVHUEtFEhMKC0lLRUFGR0NQRUNLGA4gAygNEiAKDW1hdGVy";
		buffer[14] = "aWFsX2xpc3QYDyADKAsyCS5NYXRlcmlhbBIiCgtQRUZNS0xLS0NGShihAyAD";
		buffer[15] = "KAsyDC5QRkZEQUZKTE5PT0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[16] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[9]
		{
			ANDMLIEGPKEReflection.Descriptor,
			EquipmentReflection.Descriptor,
			JLAEDKMBGEKReflection.Descriptor,
			MaterialReflection.Descriptor,
			PFFDAFJLNOOReflection.Descriptor,
			PileItemReflection.Descriptor,
			RelicReflection.Descriptor,
			TurnFoodSwitchReflection.Descriptor,
			WaitDelResourceReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetBagScRsp), GetBagScRsp.Parser, new string[16]
			{
				"EquipmentList", "MKKDFNDEGAB", "IFNAOGAKHPN", "WaitDelResourceList", "MAODNHNHLIJ", "HGHIIKNLJKH", "CBANAKKOMOF", "DBPDPHIMBDJ", "GHGKCFIFMBB", "FGEKLBMLHEK",
				"Retcode", "RelicList", "OKGCGMCMPJJ", "IKEAFGCPECK", "MaterialList", "PEFMKLKKCFJ"
			}, null, null, null, null)
		}));
	}
}

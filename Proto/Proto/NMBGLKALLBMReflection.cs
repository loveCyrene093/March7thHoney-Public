using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NMBGLKALLBMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NMBGLKALLBMReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChFOTUJHTEtBTExCTS5wcm90bxoRR0tERUtKS09JSk4ucHJvdG8aDkl0ZW1M";
		buffer[1] = "aXN0LnByb3RvGhFLR0ZNQk5JSVBQQS5wcm90byKFAgoLTk1CR0xLQUxMQk0S";
		buffer[2] = "IQoLTE1MRk9FTERNSkQYASABKA4yDC5LR0ZNQk5JSVBQQRIPCgdyZXRjb2Rl";
		buffer[3] = "GAIgASgNEh4KC05JSUtIRUJFRElHGAMgASgLMgkuSXRlbUxpc3QSIQoLRk1Q";
		buffer[4] = "Tk5IRFBHS0QYBSADKAsyDC5HS0RFS0pLT0lKThIeCgtFS0ZDTEVKTkdLRRgG";
		buffer[5] = "IAEoCzIJLkl0ZW1MaXN0EiEKC0hFT0VLQVBCTklFGAcgAygLMgwuR0tERUtK";
		buffer[6] = "S09JSk4SGQoGcmV3YXJkGAogASgLMgkuSXRlbUxpc3QSIQoLTUVLTElCQVBH";
		buffer[7] = "T04YDiADKAsyDC5HS0RFS0pLT0lKTkIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[8] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			GKDEKJKOIJNReflection.Descriptor,
			ItemListReflection.Descriptor,
			KGFMBNIIPPAReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NMBGLKALLBM), NMBGLKALLBM.Parser, new string[8] { "LMLFOELDMJD", "Retcode", "NIIKHEBEDIG", "FMPNNHDPGKD", "EKFCLEJNGKE", "HEOEKAPBNIE", "Reward", "MEKLIBAPGON" }, null, null, null, null)
		}));
	}
}

using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournConfirmSettleScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournConfirmSettleScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "CiJSb2d1ZVRvdXJuQ29uZmlybVNldHRsZVNjUnNwLnByb3RvGhFCRkVJUEVM";
		buffer[1] = "RkNERi5wcm90bxoOSXRlbUxpc3QucHJvdG8aEU9KS0FIQ0VLREdOLnByb3Rv";
		buffer[2] = "IrUBChxSb2d1ZVRvdXJuQ29uZmlybVNldHRsZVNjUnNwEh4KC0ZOS0VCT0ZB";
		buffer[3] = "SE1FGAEgASgLMgkuSXRlbUxpc3QSHgoLTU5BREhHSU5EUEkYAyABKAsyCS5J";
		buffer[4] = "dGVtTGlzdBIhCgtHRk1OT01QRElORBgEIAEoCzIMLk9KS0FIQ0VLREdOEiEK";
		buffer[5] = "C0FGTEpKSkZDQklOGAYgASgLMgwuQkZFSVBFTEZDREYSDwoHcmV0Y29kZRgI";
		buffer[6] = "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			BFEIPELFCDFReflection.Descriptor,
			ItemListReflection.Descriptor,
			OJKAHCEKDGNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournConfirmSettleScRsp), RogueTournConfirmSettleScRsp.Parser, new string[5] { "FNKEBOFAHME", "MNADHGINDPI", "GFMNOMPDIND", "AFLJJJFCBIN", "Retcode" }, null, null, null, null)
		}));
	}
}

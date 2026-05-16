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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "CiJSb2d1ZVRvdXJuQ29uZmlybVNldHRsZVNjUnNwLnByb3RvGhFCRkVJUEVM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "RkNERi5wcm90bxoOSXRlbUxpc3QucHJvdG8aEU9KS0FIQ0VLREdOLnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "IrUBChxSb2d1ZVRvdXJuQ29uZmlybVNldHRsZVNjUnNwEh4KC0ZOS0VCT0ZB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "SE1FGAEgASgLMgkuSXRlbUxpc3QSHgoLTU5BREhHSU5EUEkYAyABKAsyCS5J";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "dGVtTGlzdBIhCgtHRk1OT01QRElORBgEIAEoCzIMLk9KS0FIQ0VLREdOEiEK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "C0FGTEpKSkZDQklOGAYgASgLMgwuQkZFSVBFTEZDREYSDwoHcmV0Y29kZRgI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[3]
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

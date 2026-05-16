using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MissionSyncReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MissionSyncReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChFNaXNzaW9uU3luYy5wcm90bxoRSUZCTE1DTkZJRU8ucHJvdG8aDU1pc3Np";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "b24ucHJvdG8aEU9LRVBGR01OSkFPLnByb3RvItkBCgtNaXNzaW9uU3luYxIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "CgtMTUxEQk9NQ0dBRBgCIAMoDRITCgtGRktPQk1CSkFQRxgEIAMoDRIeCgxt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "aXNzaW9uX2xpc3QYBSADKAsyCC5NaXNzaW9uEhMKC0lNQ0lPTERMT0xMGAcg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "AygNEiEKC09CSEdFS0tHQU9MGAsgAygLMgwuSUZCTE1DTkZJRU8SJQodZmlu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "aXNoZWRfbWFpbl9taXNzaW9uX2lkX2xpc3QYDCADKA0SIQoLRUlBRkNLRkdC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "T0EYDyADKAsyDC5PS0VQRkdNTkpBT0IWqgITTWFyY2g3dGhIb25leS5Qcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[3]
		{
			IFBLMCNFIEOReflection.Descriptor,
			MissionReflection.Descriptor,
			OKEPFGMNJAOReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MissionSync), MissionSync.Parser, new string[7] { "LMLDBOMCGAD", "FFKOBMBJAPG", "MissionList", "IMCIOLDLOLL", "OBHGEKKGAOL", "FinishedMainMissionIdList", "EIAFCKFGBOA" }, null, null, null, null)
		}));
	}
}

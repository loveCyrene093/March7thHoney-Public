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
		buffer[0] = "ChFNaXNzaW9uU3luYy5wcm90bxoRSUZCTE1DTkZJRU8ucHJvdG8aDU1pc3Np";
		buffer[1] = "b24ucHJvdG8aEU9LRVBGR01OSkFPLnByb3RvItkBCgtNaXNzaW9uU3luYxIT";
		buffer[2] = "CgtMTUxEQk9NQ0dBRBgCIAMoDRITCgtGRktPQk1CSkFQRxgEIAMoDRIeCgxt";
		buffer[3] = "aXNzaW9uX2xpc3QYBSADKAsyCC5NaXNzaW9uEhMKC0lNQ0lPTERMT0xMGAcg";
		buffer[4] = "AygNEiEKC09CSEdFS0tHQU9MGAsgAygLMgwuSUZCTE1DTkZJRU8SJQodZmlu";
		buffer[5] = "aXNoZWRfbWFpbl9taXNzaW9uX2lkX2xpc3QYDCADKA0SIQoLRUlBRkNLRkdC";
		buffer[6] = "T0EYDyADKAsyDC5PS0VQRkdNTkpBT0IWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[7] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
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

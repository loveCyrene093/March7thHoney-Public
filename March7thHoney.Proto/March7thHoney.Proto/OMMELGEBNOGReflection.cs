using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OMMELGEBNOGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OMMELGEBNOGReflection()
	{
		_003C_003Ey__InlineArray29<string> buffer = default(_003C_003Ey__InlineArray29<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 0) = "ChFPTU1FTEdFQk5PRy5wcm90bxoRQkJCSk1KSk9KRFAucHJvdG8aEUJCSUlO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 1) = "RUxOREtILnByb3RvGhFCQ01LQU5OSUtEUC5wcm90bxoRQ0FIUEJCTE1EQ0ou";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 2) = "cHJvdG8aEUNFT0VMRU9LUE9GLnByb3RvGhFDS0hGTktKTk1MTy5wcm90bxoR";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 3) = "Q05FTUNCSkhBQ0sucHJvdG8aEUZFQk1IS0tFSERHLnByb3RvGhFGSkpORk5B";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 4) = "TExHQS5wcm90bxoRRkxPRU1CSE5FUFAucHJvdG8aEUdOSkJNSUxNS01CLnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 5) = "b3RvGhFHT0RNSkdBR05QQS5wcm90bxoRSExOQ05DTkpHREwucHJvdG8aEUlI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 6) = "QkdBSE5ORUtJLnByb3RvGhFKRklBTU9EQk9JSi5wcm90bxoRT01CR09PREZJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 7) = "SEIucHJvdG8aEVBMRUNNQ0pOUElMLnByb3RvIpMHCgtPTU1FTEdFQk5PRxIW";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 8) = "Cg5xdWV1ZV9wb3NpdGlvbhgBIAEoDRITCgtDSE5ITEtLS0pIQRgCIAEoDRIp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 9) = "ChFtYXJibGVfZ2FtZV9iZWdpbhhlIAEoCzIMLkhMTkNOQ05KR0RMSAASJwoP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 10) = "bWFyYmxlX2dhbWVfZW5kGGYgASgLMgwuR05KQk1JTE1LTUJIABIpChFtYXJi";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 11) = "bGVfZ2FtZV9yb3VuZBhnIAEoCzIMLkNORU1DQkpIQUNLSAASKAoQbWFyYmxl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 12) = "X2dhbWVfdHVybhhoIAEoCzIMLkJCSUlORUxOREtISAASMAoXY2FrZV9yYWNl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 13) = "X3NlY3Rpb25fYmVnaW4YyQEgASgLMgwuRkpKTkZOQUxMR0FIABIuChVjYWtl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 14) = "X3JhY2Vfc2VjdGlvbl9lbmQYygEgASgLMgwuQkJCSk1KSk9KRFBIABI2Ch1j";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 15) = "YWtlX3JhY2Vfcm9vbV9zZWN0aW9uX3NldHRsZRjLASABKAsyDC5QTEVDTUNK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 16) = "TlBJTEgAEioKEWRpY2VfY29tYmF0X2JlZ2luGPsBIAEoCzIMLkNFT0VMRU9L";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 17) = "UE9GSAASLQoUZGljZV9jb21iYXRfdHVybl9lbmQY/AEgASgLMgwuQ0tIRk5L";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 18) = "Sk5NTE9IABIoCg9kaWNlX2NvbWJhdF9lbmQY/QEgASgLMgwuQ0FIUEJCTE1E";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 19) = "Q0pIABIuChVkaWNlX2NvbWJhdF92XzJfYmVnaW4YhQIgASgLMgwuSUhCR0FI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 20) = "Tk5FS0lIABIsChNkaWNlX2NvbWJhdF92XzJfZW5kGIYCIAEoCzIMLkpGSUFN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 21) = "T0RCT0lKSAASMQoYZGljZV9jb21iYXRfdl8yX3R1cm5fZW5kGIcCIAEoCzIM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 22) = "LkdPRE1KR0FHTlBBSAASPQokZGljZV9jb21iYXRfdl8yX3RhY3RpY3NfcG9p";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 23) = "bnRfY2hhbmdlGIgCIAEoCzIMLk9NQkdPT0RGSUhCSAASPAojZGljZV9jb21i";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 24) = "YXRfdl8yX3RhY3RpY3NfY2FyZF9jaGFuZ2UYiQIgASgLMgwuQkNNS0FOTklL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 25) = "RFBIABI8CiNkaWNlX2NvbWJhdF92XzJfZGljZV9jaGFuZ2VfcmVxdWVzdBiK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 26) = "AiABKAsyDC5GTE9FTUJITkVQUEgAEjQKG2RpY2VfY29tYmF0X3ZfMl9kaWNl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 27) = "X2NoYW5nZRiLAiABKAsyDC5GRUJNSEtLRUhER0gAQg0KC0dCRkNNUEFDT1BK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray29<string>, string>(ref buffer, 28) = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray29<string>, string>(in buffer, 29))), new FileDescriptor[17]
		{
			BBBJMJJOJDPReflection.Descriptor,
			BBIINELNDKHReflection.Descriptor,
			BCMKANNIKDPReflection.Descriptor,
			CAHPBBLMDCJReflection.Descriptor,
			CEOELEOKPOFReflection.Descriptor,
			CKHFNKJNMLOReflection.Descriptor,
			CNEMCBJHACKReflection.Descriptor,
			FEBMHKKEHDGReflection.Descriptor,
			FJJNFNALLGAReflection.Descriptor,
			FLOEMBHNEPPReflection.Descriptor,
			GNJBMILMKMBReflection.Descriptor,
			GODMJGAGNPAReflection.Descriptor,
			HLNCNCNJGDLReflection.Descriptor,
			IHBGAHNNEKIReflection.Descriptor,
			JFIAMODBOIJReflection.Descriptor,
			OMBGOODFIHBReflection.Descriptor,
			PLECMCJNPILReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OMMELGEBNOG), OMMELGEBNOG.Parser, new string[19]
			{
				"QueuePosition", "CHNHLKKKJHA", "MarbleGameBegin", "MarbleGameEnd", "MarbleGameRound", "MarbleGameTurn", "CakeRaceSectionBegin", "CakeRaceSectionEnd", "CakeRaceRoomSectionSettle", "DiceCombatBegin",
				"DiceCombatTurnEnd", "DiceCombatEnd", "DiceCombatV2Begin", "DiceCombatV2End", "DiceCombatV2TurnEnd", "DiceCombatV2TacticsPointChange", "DiceCombatV2TacticsCardChange", "DiceCombatV2DiceChangeRequest", "DiceCombatV2DiceChange"
			}, new string[1] { "GBFCMPACOPJ" }, null, null, null)
		}));
	}
}

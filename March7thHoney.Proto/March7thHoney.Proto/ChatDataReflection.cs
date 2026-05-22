using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChatDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChatDataReflection()
	{
		InlineArray13<string> buffer = default(InlineArray13<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 0) = "Cg5DaGF0RGF0YS5wcm90bxoRQ0hETEJEREhLREoucHJvdG8aEUNJS0RETE1K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 1) = "TEVOLnByb3RvGhFFQ0xFUEZLSkZMQy5wcm90bxoRSk5PQ0dGREdIRUIucHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 2) = "dG8aEU1FQkJFR0dGSk1JLnByb3RvGhFNTUxCSkZIRUFLTC5wcm90bxoRT0lK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 3) = "SkpLTE1GTk8ucHJvdG8aEVBFS05PQkRIQUtPLnByb3RvIu0CCghDaGF0RGF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 4) = "YRIjCgtFUEtJSktPSE5LQxhlIAEoCzIMLkNJS0RETE1KTEVOSAASIwoLTU9F";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 5) = "TEJQUElQREMYZiABKAsyDC5NTUxCSkZIRUFLTEgAEhYKDG1lc3NhZ2VfdGV4";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 6) = "dBhnIAEoCUgAEhIKCGV4dHJhX2lkGGggASgNSAASIwoLSU1PTEJHT0NORUkY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 7) = "aSABKAsyDC5QRUtOT0JESEFLT0gAEiMKC0JBRUFCTE9CRUdJGGogASgLMgwu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 8) = "TUVCQkVHR0ZKTUlIABIjCgtETEJOTU5DUEVFSBhrIAEoCzIMLk9JSkpKS0xN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 9) = "Rk5PSAASIwoLTVBHRUpEQUVPR0oYbCABKAsyDC5FQ0xFUEZLSkZMQ0gAEiMK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 10) = "C0NNRkRDS0FOUEdEGG0gASgLMgwuQ0hETEJEREhLREpIABIjCgtMRUdPSlBN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 11) = "TkNMTBhuIAEoCzIMLkpOT0NHRkRHSEVCSABCDQoLZXh0ZW5kX3R5cGVCFqoC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 12) = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray13<string>, string>(in buffer, 13))), new FileDescriptor[8]
		{
			CHDLBDDHKDJReflection.Descriptor,
			CIKDDLMJLENReflection.Descriptor,
			ECLEPFKJFLCReflection.Descriptor,
			JNOCGFDGHEBReflection.Descriptor,
			MEBBEGGFJMIReflection.Descriptor,
			MMLBJFHEAKLReflection.Descriptor,
			OIJJJKLMFNOReflection.Descriptor,
			PEKNOBDHAKOReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChatData), ChatData.Parser, new string[10] { "EPKIJKOHNKC", "MOELBPPIPDC", "MessageText", "ExtraId", "IMOLBGOCNEI", "BAEABLOBEGI", "DLBNMNCPEEH", "MPGEJDAEOGJ", "CMFDCKANPGD", "LEGOJPMNCLL" }, new string[1] { "ExtendType" }, null, null, null)
		}));
	}
}

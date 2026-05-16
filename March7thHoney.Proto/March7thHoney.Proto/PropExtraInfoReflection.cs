using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PropExtraInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PropExtraInfoReflection()
	{
		InlineArray14<string> buffer = default(InlineArray14<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 0) = "ChNQcm9wRXh0cmFJbmZvLnByb3RvGhFBR0xCR0ZMS0lNRS5wcm90bxoRSERL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 1) = "SUFITUxJQ0QucHJvdG8aEUpJT05FQklIT0lQLnByb3RvGhFMQUNMR01GSFBG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 2) = "Ry5wcm90bxoRTEtMSEtMTUVQQ00ucHJvdG8aEU1HQkhISUxLR0dELnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 3) = "GhFQSElFSEpNR0dNSC5wcm90bxoTUHJvcFJvZ3VlSW5mby5wcm90bxoWUHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 4) = "cFRpbWVsaW5lSW5mby5wcm90byL2AgoNUHJvcEV4dHJhSW5mbxIoCg10aW1l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 5) = "bGluZV9pbmZvGAwgASgLMhEuUHJvcFRpbWVsaW5lSW5mbxIjCgtQQkRKSUxP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 6) = "SkZNSBgBIAEoCzIMLkxBQ0xHTUZIUEZHSAASIwoLRUlMTk5ISU5KSE4YAiAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 7) = "KAsyDC5QSElFSEpNR0dNSEgAEikKD3JvZ3VlX2dhbWVfaW5mbxgEIAEoCzIO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 8) = "LlByb3BSb2d1ZUluZm9IABIjCgtHQUpLRURMS0dNTBgFIAEoCzIMLk1HQkhI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 9) = "SUxLR0dESAASIwoLQUhFQUZNTk5CSkgYBiABKAsyDC5MS0xIS0xNRVBDTUgA";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 10) = "EiMKC0lNUEJFTEpHREpIGAcgASgLMgwuSERLSUFITUxJQ0RIABIjCgtMS0dK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 11) = "Q0tNSkZHTBgKIAEoCzIMLkpJT05FQklIT0lQSAASIwoLSUFGTUNGSlBKT0EY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 12) = "DiABKAsyDC5BR0xCR0ZMS0lNRUgAQg0KC0JQSUhGQUpDTE9DQhaqAhNNYXJj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray14<string>, string>(ref buffer, 13) = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray14<string>, string>(in buffer, 14))), new FileDescriptor[9]
		{
			AGLBGFLKIMEReflection.Descriptor,
			HDKIAHMLICDReflection.Descriptor,
			JIONEBIHOIPReflection.Descriptor,
			LACLGMFHPFGReflection.Descriptor,
			LKLHKLMEPCMReflection.Descriptor,
			MGBHHILKGGDReflection.Descriptor,
			PHIEHJMGGMHReflection.Descriptor,
			PropRogueInfoReflection.Descriptor,
			PropTimelineInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PropExtraInfo), PropExtraInfo.Parser, new string[9] { "TimelineInfo", "PBDJILOJFMH", "EILNNHINJHN", "RogueGameInfo", "GAJKEDLKGML", "AHEAFMNNBJH", "IMPBELJGDJH", "LKGJCKMJFGL", "IAFMCFJPJOA" }, new string[1] { "BPIHFAJCLOC" }, null, null, null)
		}));
	}
}

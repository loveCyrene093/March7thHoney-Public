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
		buffer[0] = "ChNQcm9wRXh0cmFJbmZvLnByb3RvGhFBR0xCR0ZMS0lNRS5wcm90bxoRSERL";
		buffer[1] = "SUFITUxJQ0QucHJvdG8aEUpJT05FQklIT0lQLnByb3RvGhFMQUNMR01GSFBG";
		buffer[2] = "Ry5wcm90bxoRTEtMSEtMTUVQQ00ucHJvdG8aEU1HQkhISUxLR0dELnByb3Rv";
		buffer[3] = "GhFQSElFSEpNR0dNSC5wcm90bxoTUHJvcFJvZ3VlSW5mby5wcm90bxoWUHJv";
		buffer[4] = "cFRpbWVsaW5lSW5mby5wcm90byL2AgoNUHJvcEV4dHJhSW5mbxIoCg10aW1l";
		buffer[5] = "bGluZV9pbmZvGAwgASgLMhEuUHJvcFRpbWVsaW5lSW5mbxIjCgtQQkRKSUxP";
		buffer[6] = "SkZNSBgBIAEoCzIMLkxBQ0xHTUZIUEZHSAASIwoLRUlMTk5ISU5KSE4YAiAB";
		buffer[7] = "KAsyDC5QSElFSEpNR0dNSEgAEikKD3JvZ3VlX2dhbWVfaW5mbxgEIAEoCzIO";
		buffer[8] = "LlByb3BSb2d1ZUluZm9IABIjCgtHQUpLRURMS0dNTBgFIAEoCzIMLk1HQkhI";
		buffer[9] = "SUxLR0dESAASIwoLQUhFQUZNTk5CSkgYBiABKAsyDC5MS0xIS0xNRVBDTUgA";
		buffer[10] = "EiMKC0lNUEJFTEpHREpIGAcgASgLMgwuSERLSUFITUxJQ0RIABIjCgtMS0dK";
		buffer[11] = "Q0tNSkZHTBgKIAEoCzIMLkpJT05FQklIT0lQSAASIwoLSUFGTUNGSlBKT0EY";
		buffer[12] = "DiABKAsyDC5BR0xCR0ZMS0lNRUgAQg0KC0JQSUhGQUpDTE9DQhaqAhNNYXJj";
		buffer[13] = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[9]
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

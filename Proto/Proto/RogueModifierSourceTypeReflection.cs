using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueModifierSourceTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueModifierSourceTypeReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		buffer[0] = "Ch1Sb2d1ZU1vZGlmaWVyU291cmNlVHlwZS5wcm90byrYAgoXUm9ndWVNb2Rp";
		buffer[1] = "ZmllclNvdXJjZVR5cGUSGwoXS0lFTExCS09BTE9fQ0hPRE5NT0hMUE4QABIb";
		buffer[2] = "ChdLSUVMTEJLT0FMT19JSUxKRkpITUJJTxABEhsKF0tJRUxMQktPQUxPX0JG";
		buffer[3] = "SENHRUNMQ0dPEAISGwoXS0lFTExCS09BTE9fSENPQUdBUEpLQUkQAxIbChdL";
		buffer[4] = "SUVMTEJLT0FMT19FRU9LR05CREZBRRAEEhsKF0tJRUxMQktPQUxPX0pPQUpI";
		buffer[5] = "SkNCSURFEAUSGwoXS0lFTExCS09BTE9fSFBDSktQQURPUEkQBhIbChdLSUVM";
		buffer[6] = "TEJLT0FMT19KREtDS0ZJQktPQRAHEhsKF0tJRUxMQktPQUxPX0lOS0xLUENI";
		buffer[7] = "TEhJEAgSGwoXS0lFTExCS09BTE9fSElLTENMUEpNREsQCRIbChdLSUVMTEJL";
		buffer[8] = "T0FMT19CQ05NRE1IRUxOQxAKQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[9] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(RogueModifierSourceType) }, null, null));
	}
}

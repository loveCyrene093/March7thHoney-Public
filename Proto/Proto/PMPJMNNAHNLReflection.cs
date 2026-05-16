using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PMPJMNNAHNLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PMPJMNNAHNLReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFQTVBKTU5OQUhOTC5wcm90bxoRS05DQklNQUFGSkcucHJvdG8iuwEKC1BN";
		buffer[1] = "UEpNTk5BSE5MEhMKC09GRklETUVKQkdJGAEgASgNEiEKC01OTkRNUEJGUEpF";
		buffer[2] = "GAMgAygLMgwuS05DQklNQUFGSkcSEAoIbmlja25hbWUYBSABKAkSCwoDdWlk";
		buffer[3] = "GAYgASgNEgwKBHJhbmsYCCABKA0SEwoLTUVLTElLTEdBRkkYCSADKA0SEwoL";
		buffer[4] = "SUpFRUpOQk5HT00YCiABKA0SCgoCaHAYCyABKA0SEQoJaGVhZF9pY29uGA0g";
		buffer[5] = "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { KNCBIMAAFJGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PMPJMNNAHNL), PMPJMNNAHNL.Parser, new string[9] { "OFFIDMEJBGI", "MNNDMPBFPJE", "Nickname", "Uid", "Rank", "MEKLIKLGAFI", "IJEEJNBNGOM", "Hp", "HeadIcon" }, null, null, null, null)
		}));
	}
}

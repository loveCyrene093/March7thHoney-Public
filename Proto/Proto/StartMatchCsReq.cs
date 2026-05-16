using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StartMatchCsReq : IMessage<StartMatchCsReq>, IMessage, IEquatable<StartMatchCsReq>, IDeepCloneable<StartMatchCsReq>, IBufferMessage
{
	private static readonly MessageParser<StartMatchCsReq> _parser = new MessageParser<StartMatchCsReq>(() => new StartMatchCsReq());

	private UnknownFieldSet _unknownFields;

	public const int JHCJMKDDNNFFieldNumber = 8;

	private LobbyGameExtInfo jHCJMKDDNNF_;

	public const int PLOBMBFPNFKFieldNumber = 14;

	private FightGameMode pLOBMBFPNFK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StartMatchCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StartMatchCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyGameExtInfo JHCJMKDDNNF
	{
		get
		{
			return jHCJMKDDNNF_;
		}
		set
		{
			jHCJMKDDNNF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightGameMode PLOBMBFPNFK
	{
		get
		{
			return pLOBMBFPNFK_;
		}
		set
		{
			pLOBMBFPNFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartMatchCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartMatchCsReq(StartMatchCsReq other)
		: this()
	{
		jHCJMKDDNNF_ = ((other.jHCJMKDDNNF_ != null) ? other.jHCJMKDDNNF_.Clone() : null);
		pLOBMBFPNFK_ = other.pLOBMBFPNFK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartMatchCsReq Clone()
	{
		return new StartMatchCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StartMatchCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StartMatchCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(JHCJMKDDNNF, other.JHCJMKDDNNF))
		{
			return false;
		}
		if (PLOBMBFPNFK != other.PLOBMBFPNFK)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (jHCJMKDDNNF_ != null)
		{
			num ^= JHCJMKDDNNF.GetHashCode();
		}
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num ^= PLOBMBFPNFK.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (jHCJMKDDNNF_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(JHCJMKDDNNF);
		}
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)PLOBMBFPNFK);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (jHCJMKDDNNF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JHCJMKDDNNF);
		}
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)PLOBMBFPNFK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StartMatchCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.jHCJMKDDNNF_ != null)
		{
			if (jHCJMKDDNNF_ == null)
			{
				JHCJMKDDNNF = new LobbyGameExtInfo();
			}
			JHCJMKDDNNF.MergeFrom(other.JHCJMKDDNNF);
		}
		if (other.PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			PLOBMBFPNFK = other.PLOBMBFPNFK;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 66u:
				if (jHCJMKDDNNF_ == null)
				{
					JHCJMKDDNNF = new LobbyGameExtInfo();
				}
				input.ReadMessage(JHCJMKDDNNF);
				break;
			case 112u:
				PLOBMBFPNFK = (FightGameMode)input.ReadEnum();
				break;
			}
		}
	}
}

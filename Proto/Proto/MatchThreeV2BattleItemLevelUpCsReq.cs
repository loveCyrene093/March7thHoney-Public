using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MatchThreeV2BattleItemLevelUpCsReq : IMessage<MatchThreeV2BattleItemLevelUpCsReq>, IMessage, IEquatable<MatchThreeV2BattleItemLevelUpCsReq>, IDeepCloneable<MatchThreeV2BattleItemLevelUpCsReq>, IBufferMessage
{
	private static readonly MessageParser<MatchThreeV2BattleItemLevelUpCsReq> _parser = new MessageParser<MatchThreeV2BattleItemLevelUpCsReq>(() => new MatchThreeV2BattleItemLevelUpCsReq());

	private UnknownFieldSet _unknownFields;

	public const int PANFIPHAGPBFieldNumber = 10;

	private uint pANFIPHAGPB_;

	public const int ODADJILOEKOFieldNumber = 13;

	private uint oDADJILOEKO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MatchThreeV2BattleItemLevelUpCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MatchThreeV2BattleItemLevelUpCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PANFIPHAGPB
	{
		get
		{
			return pANFIPHAGPB_;
		}
		set
		{
			pANFIPHAGPB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ODADJILOEKO
	{
		get
		{
			return oDADJILOEKO_;
		}
		set
		{
			oDADJILOEKO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeV2BattleItemLevelUpCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeV2BattleItemLevelUpCsReq(MatchThreeV2BattleItemLevelUpCsReq other)
		: this()
	{
		pANFIPHAGPB_ = other.pANFIPHAGPB_;
		oDADJILOEKO_ = other.oDADJILOEKO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeV2BattleItemLevelUpCsReq Clone()
	{
		return new MatchThreeV2BattleItemLevelUpCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MatchThreeV2BattleItemLevelUpCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MatchThreeV2BattleItemLevelUpCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PANFIPHAGPB != other.PANFIPHAGPB)
		{
			return false;
		}
		if (ODADJILOEKO != other.ODADJILOEKO)
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
		if (PANFIPHAGPB != 0)
		{
			num ^= PANFIPHAGPB.GetHashCode();
		}
		if (ODADJILOEKO != 0)
		{
			num ^= ODADJILOEKO.GetHashCode();
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
		if (PANFIPHAGPB != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(PANFIPHAGPB);
		}
		if (ODADJILOEKO != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ODADJILOEKO);
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
		if (PANFIPHAGPB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PANFIPHAGPB);
		}
		if (ODADJILOEKO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ODADJILOEKO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MatchThreeV2BattleItemLevelUpCsReq other)
	{
		if (other != null)
		{
			if (other.PANFIPHAGPB != 0)
			{
				PANFIPHAGPB = other.PANFIPHAGPB;
			}
			if (other.ODADJILOEKO != 0)
			{
				ODADJILOEKO = other.ODADJILOEKO;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 80u:
				PANFIPHAGPB = input.ReadUInt32();
				break;
			case 104u:
				ODADJILOEKO = input.ReadUInt32();
				break;
			}
		}
	}
}

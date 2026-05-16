using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MatchThreeV2BattleItemLevelUpScRsp : IMessage<MatchThreeV2BattleItemLevelUpScRsp>, IMessage, IEquatable<MatchThreeV2BattleItemLevelUpScRsp>, IDeepCloneable<MatchThreeV2BattleItemLevelUpScRsp>, IBufferMessage
{
	private static readonly MessageParser<MatchThreeV2BattleItemLevelUpScRsp> _parser = new MessageParser<MatchThreeV2BattleItemLevelUpScRsp>(() => new MatchThreeV2BattleItemLevelUpScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int PANFIPHAGPBFieldNumber = 8;

	private uint pANFIPHAGPB_;

	public const int ODADJILOEKOFieldNumber = 12;

	private uint oDADJILOEKO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MatchThreeV2BattleItemLevelUpScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MatchThreeV2BattleItemLevelUpScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

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
	public MatchThreeV2BattleItemLevelUpScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeV2BattleItemLevelUpScRsp(MatchThreeV2BattleItemLevelUpScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		pANFIPHAGPB_ = other.pANFIPHAGPB_;
		oDADJILOEKO_ = other.oDADJILOEKO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeV2BattleItemLevelUpScRsp Clone()
	{
		return new MatchThreeV2BattleItemLevelUpScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MatchThreeV2BattleItemLevelUpScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MatchThreeV2BattleItemLevelUpScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
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
		if (Retcode != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		if (PANFIPHAGPB != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(PANFIPHAGPB);
		}
		if (ODADJILOEKO != 0)
		{
			output.WriteRawTag(96);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
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
	public void MergeFrom(MatchThreeV2BattleItemLevelUpScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
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
			case 16u:
				Retcode = input.ReadUInt32();
				break;
			case 64u:
				PANFIPHAGPB = input.ReadUInt32();
				break;
			case 96u:
				ODADJILOEKO = input.ReadUInt32();
				break;
			}
		}
	}
}

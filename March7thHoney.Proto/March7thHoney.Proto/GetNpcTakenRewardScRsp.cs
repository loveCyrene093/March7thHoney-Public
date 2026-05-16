using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetNpcTakenRewardScRsp : IMessage<GetNpcTakenRewardScRsp>, IMessage, IEquatable<GetNpcTakenRewardScRsp>, IDeepCloneable<GetNpcTakenRewardScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetNpcTakenRewardScRsp> _parser = new MessageParser<GetNpcTakenRewardScRsp>(() => new GetNpcTakenRewardScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int TalkEventListFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_talkEventList_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> talkEventList_ = new RepeatedField<uint>();

	public const int NpcIdFieldNumber = 15;

	private uint npcId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetNpcTakenRewardScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetNpcTakenRewardScRspReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<uint> TalkEventList => talkEventList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NpcId
	{
		get
		{
			return npcId_;
		}
		set
		{
			npcId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetNpcTakenRewardScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetNpcTakenRewardScRsp(GetNpcTakenRewardScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		talkEventList_ = other.talkEventList_.Clone();
		npcId_ = other.npcId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetNpcTakenRewardScRsp Clone()
	{
		return new GetNpcTakenRewardScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetNpcTakenRewardScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetNpcTakenRewardScRsp other)
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
		if (!talkEventList_.Equals(other.talkEventList_))
		{
			return false;
		}
		if (NpcId != other.NpcId)
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
		num ^= talkEventList_.GetHashCode();
		if (NpcId != 0)
		{
			num ^= NpcId.GetHashCode();
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
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		talkEventList_.WriteTo(ref output, _repeated_talkEventList_codec);
		if (NpcId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(NpcId);
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
		num += talkEventList_.CalculateSize(_repeated_talkEventList_codec);
		if (NpcId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NpcId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetNpcTakenRewardScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			talkEventList_.Add(other.talkEventList_);
			if (other.NpcId != 0)
			{
				NpcId = other.NpcId;
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
			case 24u:
				Retcode = input.ReadUInt32();
				break;
			case 32u:
			case 34u:
				talkEventList_.AddEntriesFrom(ref input, _repeated_talkEventList_codec);
				break;
			case 120u:
				NpcId = input.ReadUInt32();
				break;
			}
		}
	}
}

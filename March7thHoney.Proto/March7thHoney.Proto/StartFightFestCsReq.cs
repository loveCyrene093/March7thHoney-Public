using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StartFightFestCsReq : IMessage<StartFightFestCsReq>, IMessage, IEquatable<StartFightFestCsReq>, IDeepCloneable<StartFightFestCsReq>, IBufferMessage
{
	private static readonly MessageParser<StartFightFestCsReq> _parser = new MessageParser<StartFightFestCsReq>(() => new StartFightFestCsReq());

	private UnknownFieldSet _unknownFields;

	public const int AvatarListFieldNumber = 3;

	private static readonly FieldCodec<BLKGDGAPBKC> _repeated_avatarList_codec = FieldCodec.ForMessage(26u, BLKGDGAPBKC.Parser);

	private readonly RepeatedField<BLKGDGAPBKC> avatarList_ = new RepeatedField<BLKGDGAPBKC>();

	public const int IdFieldNumber = 4;

	private uint id_;

	public const int TypeFieldNumber = 5;

	private FightFestType type_;

	public const int EventIdFieldNumber = 8;

	private uint eventId_;

	public const int GIGPHJEBDFLFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_gIGPHJEBDFL_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> gIGPHJEBDFL_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StartFightFestCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StartFightFestCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BLKGDGAPBKC> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightFestType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EventId
	{
		get
		{
			return eventId_;
		}
		set
		{
			eventId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GIGPHJEBDFL => gIGPHJEBDFL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartFightFestCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartFightFestCsReq(StartFightFestCsReq other)
		: this()
	{
		avatarList_ = other.avatarList_.Clone();
		id_ = other.id_;
		type_ = other.type_;
		eventId_ = other.eventId_;
		gIGPHJEBDFL_ = other.gIGPHJEBDFL_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartFightFestCsReq Clone()
	{
		return new StartFightFestCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StartFightFestCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StartFightFestCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (EventId != other.EventId)
		{
			return false;
		}
		if (!gIGPHJEBDFL_.Equals(other.gIGPHJEBDFL_))
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
		num ^= avatarList_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Type != FightFestType.MhkeafapmfpPcpdhelpkem)
		{
			num ^= Type.GetHashCode();
		}
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
		}
		num ^= gIGPHJEBDFL_.GetHashCode();
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
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		if (Id != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Id);
		}
		if (Type != FightFestType.MhkeafapmfpPcpdhelpkem)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)Type);
		}
		if (EventId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(EventId);
		}
		gIGPHJEBDFL_.WriteTo(ref output, _repeated_gIGPHJEBDFL_codec);
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
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (Type != FightFestType.MhkeafapmfpPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EventId);
		}
		num += gIGPHJEBDFL_.CalculateSize(_repeated_gIGPHJEBDFL_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StartFightFestCsReq other)
	{
		if (other != null)
		{
			avatarList_.Add(other.avatarList_);
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Type != FightFestType.MhkeafapmfpPcpdhelpkem)
			{
				Type = other.Type;
			}
			if (other.EventId != 0)
			{
				EventId = other.EventId;
			}
			gIGPHJEBDFL_.Add(other.gIGPHJEBDFL_);
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
			case 26u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 32u:
				Id = input.ReadUInt32();
				break;
			case 40u:
				Type = (FightFestType)input.ReadEnum();
				break;
			case 64u:
				EventId = input.ReadUInt32();
				break;
			case 80u:
			case 82u:
				gIGPHJEBDFL_.AddEntriesFrom(ref input, _repeated_gIGPHJEBDFL_codec);
				break;
			}
		}
	}
}

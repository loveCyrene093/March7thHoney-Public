using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueArcadeStartCsReq : IMessage<RogueArcadeStartCsReq>, IMessage, IEquatable<RogueArcadeStartCsReq>, IDeepCloneable<RogueArcadeStartCsReq>, IBufferMessage
{
	private static readonly MessageParser<RogueArcadeStartCsReq> _parser = new MessageParser<RogueArcadeStartCsReq>(() => new RogueArcadeStartCsReq());

	private UnknownFieldSet _unknownFields;

	public const int RoomIdFieldNumber = 10;

	private uint roomId_;

	public const int BaseAvatarIdListFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueArcadeStartCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueArcadeStartCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RoomId
	{
		get
		{
			return roomId_;
		}
		set
		{
			roomId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BaseAvatarIdList => baseAvatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueArcadeStartCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueArcadeStartCsReq(RogueArcadeStartCsReq other)
		: this()
	{
		roomId_ = other.roomId_;
		baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueArcadeStartCsReq Clone()
	{
		return new RogueArcadeStartCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueArcadeStartCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueArcadeStartCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoomId != other.RoomId)
		{
			return false;
		}
		if (!baseAvatarIdList_.Equals(other.baseAvatarIdList_))
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
		if (RoomId != 0)
		{
			num ^= RoomId.GetHashCode();
		}
		num ^= baseAvatarIdList_.GetHashCode();
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
		if (RoomId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(RoomId);
		}
		baseAvatarIdList_.WriteTo(ref output, _repeated_baseAvatarIdList_codec);
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
		if (RoomId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoomId);
		}
		num += baseAvatarIdList_.CalculateSize(_repeated_baseAvatarIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueArcadeStartCsReq other)
	{
		if (other != null)
		{
			if (other.RoomId != 0)
			{
				RoomId = other.RoomId;
			}
			baseAvatarIdList_.Add(other.baseAvatarIdList_);
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
				RoomId = input.ReadUInt32();
				break;
			case 88u:
			case 90u:
				baseAvatarIdList_.AddEntriesFrom(ref input, _repeated_baseAvatarIdList_codec);
				break;
			}
		}
	}
}

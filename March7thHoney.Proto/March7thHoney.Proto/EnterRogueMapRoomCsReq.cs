using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnterRogueMapRoomCsReq : IMessage<EnterRogueMapRoomCsReq>, IMessage, IEquatable<EnterRogueMapRoomCsReq>, IDeepCloneable<EnterRogueMapRoomCsReq>, IBufferMessage
{
	private static readonly MessageParser<EnterRogueMapRoomCsReq> _parser = new MessageParser<EnterRogueMapRoomCsReq>(() => new EnterRogueMapRoomCsReq());

	private UnknownFieldSet _unknownFields;

	public const int HCMJDMFNENEFieldNumber = 14;

	private uint hCMJDMFNENE_;

	public const int RoomIdFieldNumber = 15;

	private uint roomId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnterRogueMapRoomCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EnterRogueMapRoomCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HCMJDMFNENE
	{
		get
		{
			return hCMJDMFNENE_;
		}
		set
		{
			hCMJDMFNENE_ = value;
		}
	}

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
	public EnterRogueMapRoomCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterRogueMapRoomCsReq(EnterRogueMapRoomCsReq other)
		: this()
	{
		hCMJDMFNENE_ = other.hCMJDMFNENE_;
		roomId_ = other.roomId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterRogueMapRoomCsReq Clone()
	{
		return new EnterRogueMapRoomCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EnterRogueMapRoomCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EnterRogueMapRoomCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HCMJDMFNENE != other.HCMJDMFNENE)
		{
			return false;
		}
		if (RoomId != other.RoomId)
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
		if (HCMJDMFNENE != 0)
		{
			num ^= HCMJDMFNENE.GetHashCode();
		}
		if (RoomId != 0)
		{
			num ^= RoomId.GetHashCode();
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
		if (HCMJDMFNENE != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(HCMJDMFNENE);
		}
		if (RoomId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(RoomId);
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
		if (HCMJDMFNENE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HCMJDMFNENE);
		}
		if (RoomId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoomId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EnterRogueMapRoomCsReq other)
	{
		if (other != null)
		{
			if (other.HCMJDMFNENE != 0)
			{
				HCMJDMFNENE = other.HCMJDMFNENE;
			}
			if (other.RoomId != 0)
			{
				RoomId = other.RoomId;
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
			case 112u:
				HCMJDMFNENE = input.ReadUInt32();
				break;
			case 120u:
				RoomId = input.ReadUInt32();
				break;
			}
		}
	}
}

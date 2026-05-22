using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MuseumRandomEventSelectCsReq : IMessage<MuseumRandomEventSelectCsReq>, IMessage, IEquatable<MuseumRandomEventSelectCsReq>, IDeepCloneable<MuseumRandomEventSelectCsReq>, IBufferMessage
{
	private static readonly MessageParser<MuseumRandomEventSelectCsReq> _parser = new MessageParser<MuseumRandomEventSelectCsReq>(() => new MuseumRandomEventSelectCsReq());

	private UnknownFieldSet _unknownFields;

	public const int EventIdFieldNumber = 6;

	private uint eventId_;

	public const int ILHABFJKEGDFieldNumber = 13;

	private uint iLHABFJKEGD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MuseumRandomEventSelectCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MuseumRandomEventSelectCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint ILHABFJKEGD
	{
		get
		{
			return iLHABFJKEGD_;
		}
		set
		{
			iLHABFJKEGD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MuseumRandomEventSelectCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MuseumRandomEventSelectCsReq(MuseumRandomEventSelectCsReq other)
		: this()
	{
		eventId_ = other.eventId_;
		iLHABFJKEGD_ = other.iLHABFJKEGD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MuseumRandomEventSelectCsReq Clone()
	{
		return new MuseumRandomEventSelectCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MuseumRandomEventSelectCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MuseumRandomEventSelectCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EventId != other.EventId)
		{
			return false;
		}
		if (ILHABFJKEGD != other.ILHABFJKEGD)
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
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
		}
		if (ILHABFJKEGD != 0)
		{
			num ^= ILHABFJKEGD.GetHashCode();
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
		if (EventId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(EventId);
		}
		if (ILHABFJKEGD != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ILHABFJKEGD);
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
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EventId);
		}
		if (ILHABFJKEGD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ILHABFJKEGD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MuseumRandomEventSelectCsReq other)
	{
		if (other != null)
		{
			if (other.EventId != 0)
			{
				EventId = other.EventId;
			}
			if (other.ILHABFJKEGD != 0)
			{
				ILHABFJKEGD = other.ILHABFJKEGD;
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
			case 48u:
				EventId = input.ReadUInt32();
				break;
			case 104u:
				ILHABFJKEGD = input.ReadUInt32();
				break;
			}
		}
	}
}

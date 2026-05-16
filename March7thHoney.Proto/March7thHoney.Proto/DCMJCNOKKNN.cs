using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DCMJCNOKKNN : IMessage<DCMJCNOKKNN>, IMessage, IEquatable<DCMJCNOKKNN>, IDeepCloneable<DCMJCNOKKNN>, IBufferMessage
{
	private static readonly MessageParser<DCMJCNOKKNN> _parser = new MessageParser<DCMJCNOKKNN>(() => new DCMJCNOKKNN());

	private UnknownFieldSet _unknownFields;

	public const int EventIdFieldNumber = 7;

	private uint eventId_;

	public const int StateFieldNumber = 12;

	private AlleyEventState state_;

	public const int EIAAKEGPKMEFieldNumber = 13;

	private uint eIAAKEGPKME_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DCMJCNOKKNN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DCMJCNOKKNNReflection.Descriptor.MessageTypes[0];

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
	public AlleyEventState State
	{
		get
		{
			return state_;
		}
		set
		{
			state_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EIAAKEGPKME
	{
		get
		{
			return eIAAKEGPKME_;
		}
		set
		{
			eIAAKEGPKME_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCMJCNOKKNN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCMJCNOKKNN(DCMJCNOKKNN other)
		: this()
	{
		eventId_ = other.eventId_;
		state_ = other.state_;
		eIAAKEGPKME_ = other.eIAAKEGPKME_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCMJCNOKKNN Clone()
	{
		return new DCMJCNOKKNN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DCMJCNOKKNN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DCMJCNOKKNN other)
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
		if (State != other.State)
		{
			return false;
		}
		if (EIAAKEGPKME != other.EIAAKEGPKME)
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
		if (State != AlleyEventState.HebaghleechMfdplaoekfe)
		{
			num ^= State.GetHashCode();
		}
		if (EIAAKEGPKME != 0)
		{
			num ^= EIAAKEGPKME.GetHashCode();
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
			output.WriteRawTag(56);
			output.WriteUInt32(EventId);
		}
		if (State != AlleyEventState.HebaghleechMfdplaoekfe)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)State);
		}
		if (EIAAKEGPKME != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(EIAAKEGPKME);
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
		if (State != AlleyEventState.HebaghleechMfdplaoekfe)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)State);
		}
		if (EIAAKEGPKME != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EIAAKEGPKME);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DCMJCNOKKNN other)
	{
		if (other != null)
		{
			if (other.EventId != 0)
			{
				EventId = other.EventId;
			}
			if (other.State != AlleyEventState.HebaghleechMfdplaoekfe)
			{
				State = other.State;
			}
			if (other.EIAAKEGPKME != 0)
			{
				EIAAKEGPKME = other.EIAAKEGPKME;
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
			case 56u:
				EventId = input.ReadUInt32();
				break;
			case 96u:
				State = (AlleyEventState)input.ReadEnum();
				break;
			case 104u:
				EIAAKEGPKME = input.ReadUInt32();
				break;
			}
		}
	}
}

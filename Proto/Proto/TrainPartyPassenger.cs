using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartyPassenger : IMessage<TrainPartyPassenger>, IMessage, IEquatable<TrainPartyPassenger>, IDeepCloneable<TrainPartyPassenger>, IBufferMessage
{
	private static readonly MessageParser<TrainPartyPassenger> _parser = new MessageParser<TrainPartyPassenger>(() => new TrainPartyPassenger());

	private UnknownFieldSet _unknownFields;

	public const int PassengerIdFieldNumber = 2;

	private uint passengerId_;

	public const int RecordIdFieldNumber = 6;

	private uint recordId_;

	public const int DELEKCIJMILFieldNumber = 13;

	private bool dELEKCIJMIL_;

	public const int DACEDNGJLBMFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_dACEDNGJLBM_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> dACEDNGJLBM_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartyPassenger> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartyPassengerReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PassengerId
	{
		get
		{
			return passengerId_;
		}
		set
		{
			passengerId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RecordId
	{
		get
		{
			return recordId_;
		}
		set
		{
			recordId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DELEKCIJMIL
	{
		get
		{
			return dELEKCIJMIL_;
		}
		set
		{
			dELEKCIJMIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DACEDNGJLBM => dACEDNGJLBM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyPassenger()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyPassenger(TrainPartyPassenger other)
		: this()
	{
		passengerId_ = other.passengerId_;
		recordId_ = other.recordId_;
		dELEKCIJMIL_ = other.dELEKCIJMIL_;
		dACEDNGJLBM_ = other.dACEDNGJLBM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyPassenger Clone()
	{
		return new TrainPartyPassenger(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainPartyPassenger);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartyPassenger other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PassengerId != other.PassengerId)
		{
			return false;
		}
		if (RecordId != other.RecordId)
		{
			return false;
		}
		if (DELEKCIJMIL != other.DELEKCIJMIL)
		{
			return false;
		}
		if (!dACEDNGJLBM_.Equals(other.dACEDNGJLBM_))
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
		if (PassengerId != 0)
		{
			num ^= PassengerId.GetHashCode();
		}
		if (RecordId != 0)
		{
			num ^= RecordId.GetHashCode();
		}
		if (DELEKCIJMIL)
		{
			num ^= DELEKCIJMIL.GetHashCode();
		}
		num ^= dACEDNGJLBM_.GetHashCode();
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
		if (PassengerId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PassengerId);
		}
		if (RecordId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(RecordId);
		}
		if (DELEKCIJMIL)
		{
			output.WriteRawTag(104);
			output.WriteBool(DELEKCIJMIL);
		}
		dACEDNGJLBM_.WriteTo(ref output, _repeated_dACEDNGJLBM_codec);
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
		if (PassengerId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PassengerId);
		}
		if (RecordId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RecordId);
		}
		if (DELEKCIJMIL)
		{
			num += 2;
		}
		num += dACEDNGJLBM_.CalculateSize(_repeated_dACEDNGJLBM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainPartyPassenger other)
	{
		if (other != null)
		{
			if (other.PassengerId != 0)
			{
				PassengerId = other.PassengerId;
			}
			if (other.RecordId != 0)
			{
				RecordId = other.RecordId;
			}
			if (other.DELEKCIJMIL)
			{
				DELEKCIJMIL = other.DELEKCIJMIL;
			}
			dACEDNGJLBM_.Add(other.dACEDNGJLBM_);
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
				PassengerId = input.ReadUInt32();
				break;
			case 48u:
				RecordId = input.ReadUInt32();
				break;
			case 104u:
				DELEKCIJMIL = input.ReadBool();
				break;
			case 112u:
			case 114u:
				dACEDNGJLBM_.AddEntriesFrom(ref input, _repeated_dACEDNGJLBM_codec);
				break;
			}
		}
	}
}

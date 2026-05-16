using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartyGamePlaySettleNotify : IMessage<TrainPartyGamePlaySettleNotify>, IMessage, IEquatable<TrainPartyGamePlaySettleNotify>, IDeepCloneable<TrainPartyGamePlaySettleNotify>, IBufferMessage
{
	private static readonly MessageParser<TrainPartyGamePlaySettleNotify> _parser = new MessageParser<TrainPartyGamePlaySettleNotify>(() => new TrainPartyGamePlaySettleNotify());

	private UnknownFieldSet _unknownFields;

	public const int IENGEPCHHMCFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_iENGEPCHHMC_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> iENGEPCHHMC_ = new RepeatedField<uint>();

	public const int UnlockAreaNumFieldNumber = 9;

	private uint unlockAreaNum_;

	public const int RecordIdFieldNumber = 10;

	private uint recordId_;

	public const int FIJHIEOANNMFieldNumber = 12;

	private TrainPartyPassengerInfo fIJHIEOANNM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartyGamePlaySettleNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartyGamePlaySettleNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IENGEPCHHMC => iENGEPCHHMC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UnlockAreaNum
	{
		get
		{
			return unlockAreaNum_;
		}
		set
		{
			unlockAreaNum_ = value;
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
	public TrainPartyPassengerInfo FIJHIEOANNM
	{
		get
		{
			return fIJHIEOANNM_;
		}
		set
		{
			fIJHIEOANNM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyGamePlaySettleNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyGamePlaySettleNotify(TrainPartyGamePlaySettleNotify other)
		: this()
	{
		iENGEPCHHMC_ = other.iENGEPCHHMC_.Clone();
		unlockAreaNum_ = other.unlockAreaNum_;
		recordId_ = other.recordId_;
		fIJHIEOANNM_ = ((other.fIJHIEOANNM_ != null) ? other.fIJHIEOANNM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyGamePlaySettleNotify Clone()
	{
		return new TrainPartyGamePlaySettleNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainPartyGamePlaySettleNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartyGamePlaySettleNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iENGEPCHHMC_.Equals(other.iENGEPCHHMC_))
		{
			return false;
		}
		if (UnlockAreaNum != other.UnlockAreaNum)
		{
			return false;
		}
		if (RecordId != other.RecordId)
		{
			return false;
		}
		if (!object.Equals(FIJHIEOANNM, other.FIJHIEOANNM))
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
		num ^= iENGEPCHHMC_.GetHashCode();
		if (UnlockAreaNum != 0)
		{
			num ^= UnlockAreaNum.GetHashCode();
		}
		if (RecordId != 0)
		{
			num ^= RecordId.GetHashCode();
		}
		if (fIJHIEOANNM_ != null)
		{
			num ^= FIJHIEOANNM.GetHashCode();
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
		iENGEPCHHMC_.WriteTo(ref output, _repeated_iENGEPCHHMC_codec);
		if (UnlockAreaNum != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(UnlockAreaNum);
		}
		if (RecordId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(RecordId);
		}
		if (fIJHIEOANNM_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(FIJHIEOANNM);
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
		num += iENGEPCHHMC_.CalculateSize(_repeated_iENGEPCHHMC_codec);
		if (UnlockAreaNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UnlockAreaNum);
		}
		if (RecordId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RecordId);
		}
		if (fIJHIEOANNM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FIJHIEOANNM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainPartyGamePlaySettleNotify other)
	{
		if (other == null)
		{
			return;
		}
		iENGEPCHHMC_.Add(other.iENGEPCHHMC_);
		if (other.UnlockAreaNum != 0)
		{
			UnlockAreaNum = other.UnlockAreaNum;
		}
		if (other.RecordId != 0)
		{
			RecordId = other.RecordId;
		}
		if (other.fIJHIEOANNM_ != null)
		{
			if (fIJHIEOANNM_ == null)
			{
				FIJHIEOANNM = new TrainPartyPassengerInfo();
			}
			FIJHIEOANNM.MergeFrom(other.FIJHIEOANNM);
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
			case 40u:
			case 42u:
				iENGEPCHHMC_.AddEntriesFrom(ref input, _repeated_iENGEPCHHMC_codec);
				break;
			case 72u:
				UnlockAreaNum = input.ReadUInt32();
				break;
			case 80u:
				RecordId = input.ReadUInt32();
				break;
			case 98u:
				if (fIJHIEOANNM_ == null)
				{
					FIJHIEOANNM = new TrainPartyPassengerInfo();
				}
				input.ReadMessage(FIJHIEOANNM);
				break;
			}
		}
	}
}

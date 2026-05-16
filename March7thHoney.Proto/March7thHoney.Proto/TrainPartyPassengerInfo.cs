using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartyPassengerInfo : IMessage<TrainPartyPassengerInfo>, IMessage, IEquatable<TrainPartyPassengerInfo>, IDeepCloneable<TrainPartyPassengerInfo>, IBufferMessage
{
	private static readonly MessageParser<TrainPartyPassengerInfo> _parser = new MessageParser<TrainPartyPassengerInfo>(() => new TrainPartyPassengerInfo());

	private UnknownFieldSet _unknownFields;

	public const int PassengerInfoListFieldNumber = 2;

	private static readonly FieldCodec<TrainPartyPassenger> _repeated_passengerInfoList_codec = FieldCodec.ForMessage(18u, TrainPartyPassenger.Parser);

	private readonly RepeatedField<TrainPartyPassenger> passengerInfoList_ = new RepeatedField<TrainPartyPassenger>();

	public const int DACEDNGJLBMFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_dACEDNGJLBM_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> dACEDNGJLBM_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartyPassengerInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartyPassengerInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<TrainPartyPassenger> PassengerInfoList => passengerInfoList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DACEDNGJLBM => dACEDNGJLBM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyPassengerInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyPassengerInfo(TrainPartyPassengerInfo other)
		: this()
	{
		passengerInfoList_ = other.passengerInfoList_.Clone();
		dACEDNGJLBM_ = other.dACEDNGJLBM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyPassengerInfo Clone()
	{
		return new TrainPartyPassengerInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainPartyPassengerInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartyPassengerInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!passengerInfoList_.Equals(other.passengerInfoList_))
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
		num ^= passengerInfoList_.GetHashCode();
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
		passengerInfoList_.WriteTo(ref output, _repeated_passengerInfoList_codec);
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
		num += passengerInfoList_.CalculateSize(_repeated_passengerInfoList_codec);
		num += dACEDNGJLBM_.CalculateSize(_repeated_dACEDNGJLBM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainPartyPassengerInfo other)
	{
		if (other != null)
		{
			passengerInfoList_.Add(other.passengerInfoList_);
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
			case 18u:
				passengerInfoList_.AddEntriesFrom(ref input, _repeated_passengerInfoList_codec);
				break;
			case 104u:
			case 106u:
				dACEDNGJLBM_.AddEntriesFrom(ref input, _repeated_dACEDNGJLBM_codec);
				break;
			}
		}
	}
}

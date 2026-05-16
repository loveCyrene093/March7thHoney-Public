using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartyMoveScNotify : IMessage<TrainPartyMoveScNotify>, IMessage, IEquatable<TrainPartyMoveScNotify>, IDeepCloneable<TrainPartyMoveScNotify>, IBufferMessage
{
	private static readonly MessageParser<TrainPartyMoveScNotify> _parser = new MessageParser<TrainPartyMoveScNotify>(() => new TrainPartyMoveScNotify());

	private UnknownFieldSet _unknownFields;

	public const int HACAPEDIPABFieldNumber = 2;

	private static readonly FieldCodec<ANBOFKHHDNE> _repeated_hACAPEDIPAB_codec = FieldCodec.ForMessage(18u, ANBOFKHHDNE.Parser);

	private readonly RepeatedField<ANBOFKHHDNE> hACAPEDIPAB_ = new RepeatedField<ANBOFKHHDNE>();

	public const int DGBNFMAEMKMFieldNumber = 14;

	private uint dGBNFMAEMKM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartyMoveScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartyMoveScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ANBOFKHHDNE> HACAPEDIPAB => hACAPEDIPAB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DGBNFMAEMKM
	{
		get
		{
			return dGBNFMAEMKM_;
		}
		set
		{
			dGBNFMAEMKM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyMoveScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyMoveScNotify(TrainPartyMoveScNotify other)
		: this()
	{
		hACAPEDIPAB_ = other.hACAPEDIPAB_.Clone();
		dGBNFMAEMKM_ = other.dGBNFMAEMKM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyMoveScNotify Clone()
	{
		return new TrainPartyMoveScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainPartyMoveScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartyMoveScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hACAPEDIPAB_.Equals(other.hACAPEDIPAB_))
		{
			return false;
		}
		if (DGBNFMAEMKM != other.DGBNFMAEMKM)
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
		num ^= hACAPEDIPAB_.GetHashCode();
		if (DGBNFMAEMKM != 0)
		{
			num ^= DGBNFMAEMKM.GetHashCode();
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
		hACAPEDIPAB_.WriteTo(ref output, _repeated_hACAPEDIPAB_codec);
		if (DGBNFMAEMKM != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(DGBNFMAEMKM);
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
		num += hACAPEDIPAB_.CalculateSize(_repeated_hACAPEDIPAB_codec);
		if (DGBNFMAEMKM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DGBNFMAEMKM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainPartyMoveScNotify other)
	{
		if (other != null)
		{
			hACAPEDIPAB_.Add(other.hACAPEDIPAB_);
			if (other.DGBNFMAEMKM != 0)
			{
				DGBNFMAEMKM = other.DGBNFMAEMKM;
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
			case 18u:
				hACAPEDIPAB_.AddEntriesFrom(ref input, _repeated_hACAPEDIPAB_codec);
				break;
			case 112u:
				DGBNFMAEMKM = input.ReadUInt32();
				break;
			}
		}
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartyGamePlayStartCsReq : IMessage<TrainPartyGamePlayStartCsReq>, IMessage, IEquatable<TrainPartyGamePlayStartCsReq>, IDeepCloneable<TrainPartyGamePlayStartCsReq>, IBufferMessage
{
	private static readonly MessageParser<TrainPartyGamePlayStartCsReq> _parser = new MessageParser<TrainPartyGamePlayStartCsReq>(() => new TrainPartyGamePlayStartCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DMMNCNGGPHLFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_dMMNCNGGPHL_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> dMMNCNGGPHL_ = new RepeatedField<uint>();

	public const int MAONLHBKOFKFieldNumber = 13;

	private uint mAONLHBKOFK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartyGamePlayStartCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartyGamePlayStartCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DMMNCNGGPHL => dMMNCNGGPHL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MAONLHBKOFK
	{
		get
		{
			return mAONLHBKOFK_;
		}
		set
		{
			mAONLHBKOFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyGamePlayStartCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyGamePlayStartCsReq(TrainPartyGamePlayStartCsReq other)
		: this()
	{
		dMMNCNGGPHL_ = other.dMMNCNGGPHL_.Clone();
		mAONLHBKOFK_ = other.mAONLHBKOFK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyGamePlayStartCsReq Clone()
	{
		return new TrainPartyGamePlayStartCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainPartyGamePlayStartCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartyGamePlayStartCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dMMNCNGGPHL_.Equals(other.dMMNCNGGPHL_))
		{
			return false;
		}
		if (MAONLHBKOFK != other.MAONLHBKOFK)
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
		num ^= dMMNCNGGPHL_.GetHashCode();
		if (MAONLHBKOFK != 0)
		{
			num ^= MAONLHBKOFK.GetHashCode();
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
		dMMNCNGGPHL_.WriteTo(ref output, _repeated_dMMNCNGGPHL_codec);
		if (MAONLHBKOFK != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(MAONLHBKOFK);
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
		num += dMMNCNGGPHL_.CalculateSize(_repeated_dMMNCNGGPHL_codec);
		if (MAONLHBKOFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MAONLHBKOFK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainPartyGamePlayStartCsReq other)
	{
		if (other != null)
		{
			dMMNCNGGPHL_.Add(other.dMMNCNGGPHL_);
			if (other.MAONLHBKOFK != 0)
			{
				MAONLHBKOFK = other.MAONLHBKOFK;
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
			case 40u:
			case 42u:
				dMMNCNGGPHL_.AddEntriesFrom(ref input, _repeated_dMMNCNGGPHL_codec);
				break;
			case 104u:
				MAONLHBKOFK = input.ReadUInt32();
				break;
			}
		}
	}
}

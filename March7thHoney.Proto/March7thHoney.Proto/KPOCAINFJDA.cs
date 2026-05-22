using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KPOCAINFJDA : IMessage<KPOCAINFJDA>, IMessage, IEquatable<KPOCAINFJDA>, IDeepCloneable<KPOCAINFJDA>, IBufferMessage
{
	private static readonly MessageParser<KPOCAINFJDA> _parser = new MessageParser<KPOCAINFJDA>(() => new KPOCAINFJDA());

	private UnknownFieldSet _unknownFields;

	public const int MOHHIJGHPNBFieldNumber = 3;

	private uint mOHHIJGHPNB_;

	public const int LHFMNAHIDOMFieldNumber = 6;

	private static readonly FieldCodec<ADMCMFIINIH> _repeated_lHFMNAHIDOM_codec = FieldCodec.ForMessage(50u, ADMCMFIINIH.Parser);

	private readonly RepeatedField<ADMCMFIINIH> lHFMNAHIDOM_ = new RepeatedField<ADMCMFIINIH>();

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KPOCAINFJDA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KPOCAINFJDAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MOHHIJGHPNB
	{
		get
		{
			return mOHHIJGHPNB_;
		}
		set
		{
			mOHHIJGHPNB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ADMCMFIINIH> LHFMNAHIDOM => lHFMNAHIDOM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPOCAINFJDA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPOCAINFJDA(KPOCAINFJDA other)
		: this()
	{
		mOHHIJGHPNB_ = other.mOHHIJGHPNB_;
		lHFMNAHIDOM_ = other.lHFMNAHIDOM_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPOCAINFJDA Clone()
	{
		return new KPOCAINFJDA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KPOCAINFJDA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KPOCAINFJDA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MOHHIJGHPNB != other.MOHHIJGHPNB)
		{
			return false;
		}
		if (!lHFMNAHIDOM_.Equals(other.lHFMNAHIDOM_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (MOHHIJGHPNB != 0)
		{
			num ^= MOHHIJGHPNB.GetHashCode();
		}
		num ^= lHFMNAHIDOM_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (MOHHIJGHPNB != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(MOHHIJGHPNB);
		}
		lHFMNAHIDOM_.WriteTo(ref output, _repeated_lHFMNAHIDOM_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Retcode);
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
		if (MOHHIJGHPNB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MOHHIJGHPNB);
		}
		num += lHFMNAHIDOM_.CalculateSize(_repeated_lHFMNAHIDOM_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KPOCAINFJDA other)
	{
		if (other != null)
		{
			if (other.MOHHIJGHPNB != 0)
			{
				MOHHIJGHPNB = other.MOHHIJGHPNB;
			}
			lHFMNAHIDOM_.Add(other.lHFMNAHIDOM_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 24u:
				MOHHIJGHPNB = input.ReadUInt32();
				break;
			case 50u:
				lHFMNAHIDOM_.AddEntriesFrom(ref input, _repeated_lHFMNAHIDOM_codec);
				break;
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}

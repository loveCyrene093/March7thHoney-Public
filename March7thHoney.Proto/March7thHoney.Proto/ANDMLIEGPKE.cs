using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ANDMLIEGPKE : IMessage<ANDMLIEGPKE>, IMessage, IEquatable<ANDMLIEGPKE>, IDeepCloneable<ANDMLIEGPKE>, IBufferMessage
{
	private static readonly MessageParser<ANDMLIEGPKE> _parser = new MessageParser<ANDMLIEGPKE>(() => new ANDMLIEGPKE());

	private UnknownFieldSet _unknownFields;

	public const int OIOFPADOGFCFieldNumber = 14;

	private static readonly FieldCodec<DPBEGBNICPG> _repeated_oIOFPADOGFC_codec = FieldCodec.ForMessage(114u, DPBEGBNICPG.Parser);

	private readonly RepeatedField<DPBEGBNICPG> oIOFPADOGFC_ = new RepeatedField<DPBEGBNICPG>();

	public const int TimeFieldNumber = 15;

	private ulong time_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ANDMLIEGPKE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ANDMLIEGPKEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DPBEGBNICPG> OIOFPADOGFC => oIOFPADOGFC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong Time
	{
		get
		{
			return time_;
		}
		set
		{
			time_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ANDMLIEGPKE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ANDMLIEGPKE(ANDMLIEGPKE other)
		: this()
	{
		oIOFPADOGFC_ = other.oIOFPADOGFC_.Clone();
		time_ = other.time_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ANDMLIEGPKE Clone()
	{
		return new ANDMLIEGPKE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ANDMLIEGPKE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ANDMLIEGPKE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!oIOFPADOGFC_.Equals(other.oIOFPADOGFC_))
		{
			return false;
		}
		if (Time != other.Time)
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
		num ^= oIOFPADOGFC_.GetHashCode();
		if (Time != 0L)
		{
			num ^= Time.GetHashCode();
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
		oIOFPADOGFC_.WriteTo(ref output, _repeated_oIOFPADOGFC_codec);
		if (Time != 0L)
		{
			output.WriteRawTag(120);
			output.WriteUInt64(Time);
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
		num += oIOFPADOGFC_.CalculateSize(_repeated_oIOFPADOGFC_codec);
		if (Time != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Time);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ANDMLIEGPKE other)
	{
		if (other != null)
		{
			oIOFPADOGFC_.Add(other.oIOFPADOGFC_);
			if (other.Time != 0L)
			{
				Time = other.Time;
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
			case 114u:
				oIOFPADOGFC_.AddEntriesFrom(ref input, _repeated_oIOFPADOGFC_codec);
				break;
			case 120u:
				Time = input.ReadUInt64();
				break;
			}
		}
	}
}

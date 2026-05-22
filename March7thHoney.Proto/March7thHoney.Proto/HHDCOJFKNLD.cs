using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HHDCOJFKNLD : IMessage<HHDCOJFKNLD>, IMessage, IEquatable<HHDCOJFKNLD>, IDeepCloneable<HHDCOJFKNLD>, IBufferMessage
{
	private static readonly MessageParser<HHDCOJFKNLD> _parser = new MessageParser<HHDCOJFKNLD>(() => new HHDCOJFKNLD());

	private UnknownFieldSet _unknownFields;

	public const int MBMICCJEBJBFieldNumber = 4;

	private uint mBMICCJEBJB_;

	public const int NNJCHJDEKELFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_nNJCHJDEKEL_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> nNJCHJDEKEL_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HHDCOJFKNLD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HHDCOJFKNLDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MBMICCJEBJB
	{
		get
		{
			return mBMICCJEBJB_;
		}
		set
		{
			mBMICCJEBJB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NNJCHJDEKEL => nNJCHJDEKEL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHDCOJFKNLD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHDCOJFKNLD(HHDCOJFKNLD other)
		: this()
	{
		mBMICCJEBJB_ = other.mBMICCJEBJB_;
		nNJCHJDEKEL_ = other.nNJCHJDEKEL_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHDCOJFKNLD Clone()
	{
		return new HHDCOJFKNLD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HHDCOJFKNLD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HHDCOJFKNLD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MBMICCJEBJB != other.MBMICCJEBJB)
		{
			return false;
		}
		if (!nNJCHJDEKEL_.Equals(other.nNJCHJDEKEL_))
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
		if (MBMICCJEBJB != 0)
		{
			num ^= MBMICCJEBJB.GetHashCode();
		}
		num ^= nNJCHJDEKEL_.GetHashCode();
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
		if (MBMICCJEBJB != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MBMICCJEBJB);
		}
		nNJCHJDEKEL_.WriteTo(ref output, _repeated_nNJCHJDEKEL_codec);
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
		if (MBMICCJEBJB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MBMICCJEBJB);
		}
		num += nNJCHJDEKEL_.CalculateSize(_repeated_nNJCHJDEKEL_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HHDCOJFKNLD other)
	{
		if (other != null)
		{
			if (other.MBMICCJEBJB != 0)
			{
				MBMICCJEBJB = other.MBMICCJEBJB;
			}
			nNJCHJDEKEL_.Add(other.nNJCHJDEKEL_);
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
			case 32u:
				MBMICCJEBJB = input.ReadUInt32();
				break;
			case 112u:
			case 114u:
				nNJCHJDEKEL_.AddEntriesFrom(ref input, _repeated_nNJCHJDEKEL_codec);
				break;
			}
		}
	}
}

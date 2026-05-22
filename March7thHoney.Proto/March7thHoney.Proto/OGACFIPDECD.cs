using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OGACFIPDECD : IMessage<OGACFIPDECD>, IMessage, IEquatable<OGACFIPDECD>, IDeepCloneable<OGACFIPDECD>, IBufferMessage
{
	private static readonly MessageParser<OGACFIPDECD> _parser = new MessageParser<OGACFIPDECD>(() => new OGACFIPDECD());

	private UnknownFieldSet _unknownFields;

	public const int JMNOPLMHJLEFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_jMNOPLMHJLE_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> jMNOPLMHJLE_ = new RepeatedField<uint>();

	public const int ALJIBCCDHPJFieldNumber = 6;

	private long aLJIBCCDHPJ_;

	public const int ODMBJOHLADGFieldNumber = 10;

	private uint oDMBJOHLADG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OGACFIPDECD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OGACFIPDECDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JMNOPLMHJLE => jMNOPLMHJLE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ALJIBCCDHPJ
	{
		get
		{
			return aLJIBCCDHPJ_;
		}
		set
		{
			aLJIBCCDHPJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ODMBJOHLADG
	{
		get
		{
			return oDMBJOHLADG_;
		}
		set
		{
			oDMBJOHLADG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGACFIPDECD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGACFIPDECD(OGACFIPDECD other)
		: this()
	{
		jMNOPLMHJLE_ = other.jMNOPLMHJLE_.Clone();
		aLJIBCCDHPJ_ = other.aLJIBCCDHPJ_;
		oDMBJOHLADG_ = other.oDMBJOHLADG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGACFIPDECD Clone()
	{
		return new OGACFIPDECD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OGACFIPDECD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OGACFIPDECD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jMNOPLMHJLE_.Equals(other.jMNOPLMHJLE_))
		{
			return false;
		}
		if (ALJIBCCDHPJ != other.ALJIBCCDHPJ)
		{
			return false;
		}
		if (ODMBJOHLADG != other.ODMBJOHLADG)
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
		num ^= jMNOPLMHJLE_.GetHashCode();
		if (ALJIBCCDHPJ != 0L)
		{
			num ^= ALJIBCCDHPJ.GetHashCode();
		}
		if (ODMBJOHLADG != 0)
		{
			num ^= ODMBJOHLADG.GetHashCode();
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
		jMNOPLMHJLE_.WriteTo(ref output, _repeated_jMNOPLMHJLE_codec);
		if (ALJIBCCDHPJ != 0L)
		{
			output.WriteRawTag(48);
			output.WriteInt64(ALJIBCCDHPJ);
		}
		if (ODMBJOHLADG != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(ODMBJOHLADG);
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
		num += jMNOPLMHJLE_.CalculateSize(_repeated_jMNOPLMHJLE_codec);
		if (ALJIBCCDHPJ != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(ALJIBCCDHPJ);
		}
		if (ODMBJOHLADG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ODMBJOHLADG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OGACFIPDECD other)
	{
		if (other != null)
		{
			jMNOPLMHJLE_.Add(other.jMNOPLMHJLE_);
			if (other.ALJIBCCDHPJ != 0L)
			{
				ALJIBCCDHPJ = other.ALJIBCCDHPJ;
			}
			if (other.ODMBJOHLADG != 0)
			{
				ODMBJOHLADG = other.ODMBJOHLADG;
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
				jMNOPLMHJLE_.AddEntriesFrom(ref input, _repeated_jMNOPLMHJLE_codec);
				break;
			case 48u:
				ALJIBCCDHPJ = input.ReadInt64();
				break;
			case 80u:
				ODMBJOHLADG = input.ReadUInt32();
				break;
			}
		}
	}
}

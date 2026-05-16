using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HCJDNKBGDFA : IMessage<HCJDNKBGDFA>, IMessage, IEquatable<HCJDNKBGDFA>, IDeepCloneable<HCJDNKBGDFA>, IBufferMessage
{
	private static readonly MessageParser<HCJDNKBGDFA> _parser = new MessageParser<HCJDNKBGDFA>(() => new HCJDNKBGDFA());

	private UnknownFieldSet _unknownFields;

	public const int OFHCNGHJFHIFieldNumber = 3;

	private uint oFHCNGHJFHI_;

	public const int OIMIPDOMDAAFieldNumber = 4;

	private static readonly FieldCodec<HJGFDIKDIHO> _repeated_oIMIPDOMDAA_codec = FieldCodec.ForMessage(34u, HJGFDIKDIHO.Parser);

	private readonly RepeatedField<HJGFDIKDIHO> oIMIPDOMDAA_ = new RepeatedField<HJGFDIKDIHO>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HCJDNKBGDFA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HCJDNKBGDFAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OFHCNGHJFHI
	{
		get
		{
			return oFHCNGHJFHI_;
		}
		set
		{
			oFHCNGHJFHI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HJGFDIKDIHO> OIMIPDOMDAA => oIMIPDOMDAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HCJDNKBGDFA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HCJDNKBGDFA(HCJDNKBGDFA other)
		: this()
	{
		oFHCNGHJFHI_ = other.oFHCNGHJFHI_;
		oIMIPDOMDAA_ = other.oIMIPDOMDAA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HCJDNKBGDFA Clone()
	{
		return new HCJDNKBGDFA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HCJDNKBGDFA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HCJDNKBGDFA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OFHCNGHJFHI != other.OFHCNGHJFHI)
		{
			return false;
		}
		if (!oIMIPDOMDAA_.Equals(other.oIMIPDOMDAA_))
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
		if (OFHCNGHJFHI != 0)
		{
			num ^= OFHCNGHJFHI.GetHashCode();
		}
		num ^= oIMIPDOMDAA_.GetHashCode();
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
		if (OFHCNGHJFHI != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(OFHCNGHJFHI);
		}
		oIMIPDOMDAA_.WriteTo(ref output, _repeated_oIMIPDOMDAA_codec);
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
		if (OFHCNGHJFHI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OFHCNGHJFHI);
		}
		num += oIMIPDOMDAA_.CalculateSize(_repeated_oIMIPDOMDAA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HCJDNKBGDFA other)
	{
		if (other != null)
		{
			if (other.OFHCNGHJFHI != 0)
			{
				OFHCNGHJFHI = other.OFHCNGHJFHI;
			}
			oIMIPDOMDAA_.Add(other.oIMIPDOMDAA_);
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
				OFHCNGHJFHI = input.ReadUInt32();
				break;
			case 34u:
				oIMIPDOMDAA_.AddEntriesFrom(ref input, _repeated_oIMIPDOMDAA_codec);
				break;
			}
		}
	}
}

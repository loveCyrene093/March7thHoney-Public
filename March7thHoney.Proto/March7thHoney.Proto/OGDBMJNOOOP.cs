using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OGDBMJNOOOP : IMessage<OGDBMJNOOOP>, IMessage, IEquatable<OGDBMJNOOOP>, IDeepCloneable<OGDBMJNOOOP>, IBufferMessage
{
	private static readonly MessageParser<OGDBMJNOOOP> _parser = new MessageParser<OGDBMJNOOOP>(() => new OGDBMJNOOOP());

	private UnknownFieldSet _unknownFields;

	public const int FEKAFHIDDAHFieldNumber = 1;

	private static readonly FieldCodec<OLJJJBCKLDK> _repeated_fEKAFHIDDAH_codec = FieldCodec.ForMessage(10u, OLJJJBCKLDK.Parser);

	private readonly RepeatedField<OLJJJBCKLDK> fEKAFHIDDAH_ = new RepeatedField<OLJJJBCKLDK>();

	public const int OFHCNGHJFHIFieldNumber = 11;

	private uint oFHCNGHJFHI_;

	public const int OIMIPDOMDAAFieldNumber = 14;

	private static readonly FieldCodec<OLJJJBCKLDK> _repeated_oIMIPDOMDAA_codec = FieldCodec.ForMessage(114u, OLJJJBCKLDK.Parser);

	private readonly RepeatedField<OLJJJBCKLDK> oIMIPDOMDAA_ = new RepeatedField<OLJJJBCKLDK>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OGDBMJNOOOP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OGDBMJNOOOPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OLJJJBCKLDK> FEKAFHIDDAH => fEKAFHIDDAH_;

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
	public RepeatedField<OLJJJBCKLDK> OIMIPDOMDAA => oIMIPDOMDAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGDBMJNOOOP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGDBMJNOOOP(OGDBMJNOOOP other)
		: this()
	{
		fEKAFHIDDAH_ = other.fEKAFHIDDAH_.Clone();
		oFHCNGHJFHI_ = other.oFHCNGHJFHI_;
		oIMIPDOMDAA_ = other.oIMIPDOMDAA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGDBMJNOOOP Clone()
	{
		return new OGDBMJNOOOP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OGDBMJNOOOP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OGDBMJNOOOP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fEKAFHIDDAH_.Equals(other.fEKAFHIDDAH_))
		{
			return false;
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
		num ^= fEKAFHIDDAH_.GetHashCode();
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
		fEKAFHIDDAH_.WriteTo(ref output, _repeated_fEKAFHIDDAH_codec);
		if (OFHCNGHJFHI != 0)
		{
			output.WriteRawTag(88);
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
		num += fEKAFHIDDAH_.CalculateSize(_repeated_fEKAFHIDDAH_codec);
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
	public void MergeFrom(OGDBMJNOOOP other)
	{
		if (other != null)
		{
			fEKAFHIDDAH_.Add(other.fEKAFHIDDAH_);
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
			case 10u:
				fEKAFHIDDAH_.AddEntriesFrom(ref input, _repeated_fEKAFHIDDAH_codec);
				break;
			case 88u:
				OFHCNGHJFHI = input.ReadUInt32();
				break;
			case 114u:
				oIMIPDOMDAA_.AddEntriesFrom(ref input, _repeated_oIMIPDOMDAA_codec);
				break;
			}
		}
	}
}

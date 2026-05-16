using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NMAJCDOJOII : IMessage<NMAJCDOJOII>, IMessage, IEquatable<NMAJCDOJOII>, IDeepCloneable<NMAJCDOJOII>, IBufferMessage
{
	private static readonly MessageParser<NMAJCDOJOII> _parser = new MessageParser<NMAJCDOJOII>(() => new NMAJCDOJOII());

	private UnknownFieldSet _unknownFields;

	public const int FEKAFHIDDAHFieldNumber = 3;

	private static readonly FieldCodec<HJGFDIKDIHO> _repeated_fEKAFHIDDAH_codec = FieldCodec.ForMessage(26u, HJGFDIKDIHO.Parser);

	private readonly RepeatedField<HJGFDIKDIHO> fEKAFHIDDAH_ = new RepeatedField<HJGFDIKDIHO>();

	public const int OFHCNGHJFHIFieldNumber = 4;

	private uint oFHCNGHJFHI_;

	public const int OIMIPDOMDAAFieldNumber = 10;

	private static readonly FieldCodec<HJGFDIKDIHO> _repeated_oIMIPDOMDAA_codec = FieldCodec.ForMessage(82u, HJGFDIKDIHO.Parser);

	private readonly RepeatedField<HJGFDIKDIHO> oIMIPDOMDAA_ = new RepeatedField<HJGFDIKDIHO>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NMAJCDOJOII> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NMAJCDOJOIIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HJGFDIKDIHO> FEKAFHIDDAH => fEKAFHIDDAH_;

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
	public NMAJCDOJOII()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NMAJCDOJOII(NMAJCDOJOII other)
		: this()
	{
		fEKAFHIDDAH_ = other.fEKAFHIDDAH_.Clone();
		oFHCNGHJFHI_ = other.oFHCNGHJFHI_;
		oIMIPDOMDAA_ = other.oIMIPDOMDAA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NMAJCDOJOII Clone()
	{
		return new NMAJCDOJOII(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NMAJCDOJOII);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NMAJCDOJOII other)
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
			output.WriteRawTag(32);
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
	public void MergeFrom(NMAJCDOJOII other)
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
			case 26u:
				fEKAFHIDDAH_.AddEntriesFrom(ref input, _repeated_fEKAFHIDDAH_codec);
				break;
			case 32u:
				OFHCNGHJFHI = input.ReadUInt32();
				break;
			case 82u:
				oIMIPDOMDAA_.AddEntriesFrom(ref input, _repeated_oIMIPDOMDAA_codec);
				break;
			}
		}
	}
}

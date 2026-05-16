using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EBCFBKHCHJE : IMessage<EBCFBKHCHJE>, IMessage, IEquatable<EBCFBKHCHJE>, IDeepCloneable<EBCFBKHCHJE>, IBufferMessage
{
	private static readonly MessageParser<EBCFBKHCHJE> _parser = new MessageParser<EBCFBKHCHJE>(() => new EBCFBKHCHJE());

	private UnknownFieldSet _unknownFields;

	public const int OFHCNGHJFHIFieldNumber = 7;

	private uint oFHCNGHJFHI_;

	public const int PHMDMIDKBANFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_pHMDMIDKBAN_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> pHMDMIDKBAN_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EBCFBKHCHJE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EBCFBKHCHJEReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<uint> PHMDMIDKBAN => pHMDMIDKBAN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBCFBKHCHJE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBCFBKHCHJE(EBCFBKHCHJE other)
		: this()
	{
		oFHCNGHJFHI_ = other.oFHCNGHJFHI_;
		pHMDMIDKBAN_ = other.pHMDMIDKBAN_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBCFBKHCHJE Clone()
	{
		return new EBCFBKHCHJE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EBCFBKHCHJE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EBCFBKHCHJE other)
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
		if (!pHMDMIDKBAN_.Equals(other.pHMDMIDKBAN_))
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
		num ^= pHMDMIDKBAN_.GetHashCode();
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
			output.WriteRawTag(56);
			output.WriteUInt32(OFHCNGHJFHI);
		}
		pHMDMIDKBAN_.WriteTo(ref output, _repeated_pHMDMIDKBAN_codec);
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
		num += pHMDMIDKBAN_.CalculateSize(_repeated_pHMDMIDKBAN_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EBCFBKHCHJE other)
	{
		if (other != null)
		{
			if (other.OFHCNGHJFHI != 0)
			{
				OFHCNGHJFHI = other.OFHCNGHJFHI;
			}
			pHMDMIDKBAN_.Add(other.pHMDMIDKBAN_);
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
			case 56u:
				OFHCNGHJFHI = input.ReadUInt32();
				break;
			case 104u:
			case 106u:
				pHMDMIDKBAN_.AddEntriesFrom(ref input, _repeated_pHMDMIDKBAN_codec);
				break;
			}
		}
	}
}

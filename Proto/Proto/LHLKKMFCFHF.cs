using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LHLKKMFCFHF : IMessage<LHLKKMFCFHF>, IMessage, IEquatable<LHLKKMFCFHF>, IDeepCloneable<LHLKKMFCFHF>, IBufferMessage
{
	private static readonly MessageParser<LHLKKMFCFHF> _parser = new MessageParser<LHLKKMFCFHF>(() => new LHLKKMFCFHF());

	private UnknownFieldSet _unknownFields;

	public const int OFHCNGHJFHIFieldNumber = 1;

	private uint oFHCNGHJFHI_;

	public const int NCNJNKFBKLAFieldNumber = 12;

	private static readonly FieldCodec<ILLBNKFBNBP> _repeated_nCNJNKFBKLA_codec = FieldCodec.ForMessage(98u, ILLBNKFBNBP.Parser);

	private readonly RepeatedField<ILLBNKFBNBP> nCNJNKFBKLA_ = new RepeatedField<ILLBNKFBNBP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LHLKKMFCFHF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LHLKKMFCFHFReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<ILLBNKFBNBP> NCNJNKFBKLA => nCNJNKFBKLA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHLKKMFCFHF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHLKKMFCFHF(LHLKKMFCFHF other)
		: this()
	{
		oFHCNGHJFHI_ = other.oFHCNGHJFHI_;
		nCNJNKFBKLA_ = other.nCNJNKFBKLA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHLKKMFCFHF Clone()
	{
		return new LHLKKMFCFHF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LHLKKMFCFHF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LHLKKMFCFHF other)
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
		if (!nCNJNKFBKLA_.Equals(other.nCNJNKFBKLA_))
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
		num ^= nCNJNKFBKLA_.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(OFHCNGHJFHI);
		}
		nCNJNKFBKLA_.WriteTo(ref output, _repeated_nCNJNKFBKLA_codec);
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
		num += nCNJNKFBKLA_.CalculateSize(_repeated_nCNJNKFBKLA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LHLKKMFCFHF other)
	{
		if (other != null)
		{
			if (other.OFHCNGHJFHI != 0)
			{
				OFHCNGHJFHI = other.OFHCNGHJFHI;
			}
			nCNJNKFBKLA_.Add(other.nCNJNKFBKLA_);
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
			case 8u:
				OFHCNGHJFHI = input.ReadUInt32();
				break;
			case 98u:
				nCNJNKFBKLA_.AddEntriesFrom(ref input, _repeated_nCNJNKFBKLA_codec);
				break;
			}
		}
	}
}

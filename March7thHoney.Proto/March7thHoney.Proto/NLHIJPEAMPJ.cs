using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NLHIJPEAMPJ : IMessage<NLHIJPEAMPJ>, IMessage, IEquatable<NLHIJPEAMPJ>, IDeepCloneable<NLHIJPEAMPJ>, IBufferMessage
{
	private static readonly MessageParser<NLHIJPEAMPJ> _parser = new MessageParser<NLHIJPEAMPJ>(() => new NLHIJPEAMPJ());

	private UnknownFieldSet _unknownFields;

	public const int PCOHPGGPIICFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_pCOHPGGPIIC_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> pCOHPGGPIIC_ = new RepeatedField<uint>();

	public const int BNODCFHHNHLFieldNumber = 8;

	private PCHJABAFADH bNODCFHHNHL_;

	public const int CICPHFNEJEBFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_cICPHFNEJEB_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> cICPHFNEJEB_ = new RepeatedField<uint>();

	public const int OFHCNGHJFHIFieldNumber = 15;

	private uint oFHCNGHJFHI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NLHIJPEAMPJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NLHIJPEAMPJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PCOHPGGPIIC => pCOHPGGPIIC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCHJABAFADH BNODCFHHNHL
	{
		get
		{
			return bNODCFHHNHL_;
		}
		set
		{
			bNODCFHHNHL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CICPHFNEJEB => cICPHFNEJEB_;

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
	public NLHIJPEAMPJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLHIJPEAMPJ(NLHIJPEAMPJ other)
		: this()
	{
		pCOHPGGPIIC_ = other.pCOHPGGPIIC_.Clone();
		bNODCFHHNHL_ = ((other.bNODCFHHNHL_ != null) ? other.bNODCFHHNHL_.Clone() : null);
		cICPHFNEJEB_ = other.cICPHFNEJEB_.Clone();
		oFHCNGHJFHI_ = other.oFHCNGHJFHI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLHIJPEAMPJ Clone()
	{
		return new NLHIJPEAMPJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NLHIJPEAMPJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NLHIJPEAMPJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!pCOHPGGPIIC_.Equals(other.pCOHPGGPIIC_))
		{
			return false;
		}
		if (!object.Equals(BNODCFHHNHL, other.BNODCFHHNHL))
		{
			return false;
		}
		if (!cICPHFNEJEB_.Equals(other.cICPHFNEJEB_))
		{
			return false;
		}
		if (OFHCNGHJFHI != other.OFHCNGHJFHI)
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
		num ^= pCOHPGGPIIC_.GetHashCode();
		if (bNODCFHHNHL_ != null)
		{
			num ^= BNODCFHHNHL.GetHashCode();
		}
		num ^= cICPHFNEJEB_.GetHashCode();
		if (OFHCNGHJFHI != 0)
		{
			num ^= OFHCNGHJFHI.GetHashCode();
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
		pCOHPGGPIIC_.WriteTo(ref output, _repeated_pCOHPGGPIIC_codec);
		if (bNODCFHHNHL_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(BNODCFHHNHL);
		}
		cICPHFNEJEB_.WriteTo(ref output, _repeated_cICPHFNEJEB_codec);
		if (OFHCNGHJFHI != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(OFHCNGHJFHI);
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
		num += pCOHPGGPIIC_.CalculateSize(_repeated_pCOHPGGPIIC_codec);
		if (bNODCFHHNHL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BNODCFHHNHL);
		}
		num += cICPHFNEJEB_.CalculateSize(_repeated_cICPHFNEJEB_codec);
		if (OFHCNGHJFHI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OFHCNGHJFHI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NLHIJPEAMPJ other)
	{
		if (other == null)
		{
			return;
		}
		pCOHPGGPIIC_.Add(other.pCOHPGGPIIC_);
		if (other.bNODCFHHNHL_ != null)
		{
			if (bNODCFHHNHL_ == null)
			{
				BNODCFHHNHL = new PCHJABAFADH();
			}
			BNODCFHHNHL.MergeFrom(other.BNODCFHHNHL);
		}
		cICPHFNEJEB_.Add(other.cICPHFNEJEB_);
		if (other.OFHCNGHJFHI != 0)
		{
			OFHCNGHJFHI = other.OFHCNGHJFHI;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 16u:
			case 18u:
				pCOHPGGPIIC_.AddEntriesFrom(ref input, _repeated_pCOHPGGPIIC_codec);
				break;
			case 66u:
				if (bNODCFHHNHL_ == null)
				{
					BNODCFHHNHL = new PCHJABAFADH();
				}
				input.ReadMessage(BNODCFHHNHL);
				break;
			case 88u:
			case 90u:
				cICPHFNEJEB_.AddEntriesFrom(ref input, _repeated_cICPHFNEJEB_codec);
				break;
			case 120u:
				OFHCNGHJFHI = input.ReadUInt32();
				break;
			}
		}
	}
}

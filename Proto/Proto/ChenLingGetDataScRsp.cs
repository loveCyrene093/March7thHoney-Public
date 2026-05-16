using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChenLingGetDataScRsp : IMessage<ChenLingGetDataScRsp>, IMessage, IEquatable<ChenLingGetDataScRsp>, IDeepCloneable<ChenLingGetDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<ChenLingGetDataScRsp> _parser = new MessageParser<ChenLingGetDataScRsp>(() => new ChenLingGetDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int JJABPPDILOKFieldNumber = 6;

	private uint jJABPPDILOK_;

	public const int POGCGMLPEONFieldNumber = 7;

	private FMEMPPNNKJH pOGCGMLPEON_;

	public const int IKKMNDMELLNFieldNumber = 12;

	private FCLDNHOHPII iKKMNDMELLN_;

	public const int DOAIHFIFFNOFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_dOAIHFIFFNO_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> dOAIHFIFFNO_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChenLingGetDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChenLingGetDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JJABPPDILOK
	{
		get
		{
			return jJABPPDILOK_;
		}
		set
		{
			jJABPPDILOK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FMEMPPNNKJH POGCGMLPEON
	{
		get
		{
			return pOGCGMLPEON_;
		}
		set
		{
			pOGCGMLPEON_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCLDNHOHPII IKKMNDMELLN
	{
		get
		{
			return iKKMNDMELLN_;
		}
		set
		{
			iKKMNDMELLN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DOAIHFIFFNO => dOAIHFIFFNO_;

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
	public ChenLingGetDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingGetDataScRsp(ChenLingGetDataScRsp other)
		: this()
	{
		jJABPPDILOK_ = other.jJABPPDILOK_;
		pOGCGMLPEON_ = ((other.pOGCGMLPEON_ != null) ? other.pOGCGMLPEON_.Clone() : null);
		iKKMNDMELLN_ = ((other.iKKMNDMELLN_ != null) ? other.iKKMNDMELLN_.Clone() : null);
		dOAIHFIFFNO_ = other.dOAIHFIFFNO_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingGetDataScRsp Clone()
	{
		return new ChenLingGetDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChenLingGetDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChenLingGetDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JJABPPDILOK != other.JJABPPDILOK)
		{
			return false;
		}
		if (!object.Equals(POGCGMLPEON, other.POGCGMLPEON))
		{
			return false;
		}
		if (!object.Equals(IKKMNDMELLN, other.IKKMNDMELLN))
		{
			return false;
		}
		if (!dOAIHFIFFNO_.Equals(other.dOAIHFIFFNO_))
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
		if (JJABPPDILOK != 0)
		{
			num ^= JJABPPDILOK.GetHashCode();
		}
		if (pOGCGMLPEON_ != null)
		{
			num ^= POGCGMLPEON.GetHashCode();
		}
		if (iKKMNDMELLN_ != null)
		{
			num ^= IKKMNDMELLN.GetHashCode();
		}
		num ^= dOAIHFIFFNO_.GetHashCode();
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
		if (JJABPPDILOK != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(JJABPPDILOK);
		}
		if (pOGCGMLPEON_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(POGCGMLPEON);
		}
		if (iKKMNDMELLN_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(IKKMNDMELLN);
		}
		dOAIHFIFFNO_.WriteTo(ref output, _repeated_dOAIHFIFFNO_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
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
		if (JJABPPDILOK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JJABPPDILOK);
		}
		if (pOGCGMLPEON_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(POGCGMLPEON);
		}
		if (iKKMNDMELLN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IKKMNDMELLN);
		}
		num += dOAIHFIFFNO_.CalculateSize(_repeated_dOAIHFIFFNO_codec);
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
	public void MergeFrom(ChenLingGetDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.JJABPPDILOK != 0)
		{
			JJABPPDILOK = other.JJABPPDILOK;
		}
		if (other.pOGCGMLPEON_ != null)
		{
			if (pOGCGMLPEON_ == null)
			{
				POGCGMLPEON = new FMEMPPNNKJH();
			}
			POGCGMLPEON.MergeFrom(other.POGCGMLPEON);
		}
		if (other.iKKMNDMELLN_ != null)
		{
			if (iKKMNDMELLN_ == null)
			{
				IKKMNDMELLN = new FCLDNHOHPII();
			}
			IKKMNDMELLN.MergeFrom(other.IKKMNDMELLN);
		}
		dOAIHFIFFNO_.Add(other.dOAIHFIFFNO_);
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 48u:
				JJABPPDILOK = input.ReadUInt32();
				break;
			case 58u:
				if (pOGCGMLPEON_ == null)
				{
					POGCGMLPEON = new FMEMPPNNKJH();
				}
				input.ReadMessage(POGCGMLPEON);
				break;
			case 98u:
				if (iKKMNDMELLN_ == null)
				{
					IKKMNDMELLN = new FCLDNHOHPII();
				}
				input.ReadMessage(IKKMNDMELLN);
				break;
			case 104u:
			case 106u:
				dOAIHFIFFNO_.AddEntriesFrom(ref input, _repeated_dOAIHFIFFNO_codec);
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HLIBFMJMDAH : IMessage<HLIBFMJMDAH>, IMessage, IEquatable<HLIBFMJMDAH>, IDeepCloneable<HLIBFMJMDAH>, IBufferMessage
{
	private static readonly MessageParser<HLIBFMJMDAH> _parser = new MessageParser<HLIBFMJMDAH>(() => new HLIBFMJMDAH());

	private UnknownFieldSet _unknownFields;

	public const int JADGOJLEKKKFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_jADGOJLEKKK_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> jADGOJLEKKK_ = new RepeatedField<uint>();

	public const int NODLNKMMBIJFieldNumber = 4;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_nODLNKMMBIJ_codec = FieldCodec.ForMessage(34u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> nODLNKMMBIJ_ = new RepeatedField<GKDEKJKOIJN>();

	public const int KGAOHBBGPDFFieldNumber = 9;

	private static readonly FieldCodec<LKNOFJHGGAD> _repeated_kGAOHBBGPDF_codec = FieldCodec.ForMessage(74u, LKNOFJHGGAD.Parser);

	private readonly RepeatedField<LKNOFJHGGAD> kGAOHBBGPDF_ = new RepeatedField<LKNOFJHGGAD>();

	public const int NMNOCJDJKOGFieldNumber = 14;

	private CNPOHCGPDFP nMNOCJDJKOG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HLIBFMJMDAH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HLIBFMJMDAHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JADGOJLEKKK => jADGOJLEKKK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> NODLNKMMBIJ => nODLNKMMBIJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LKNOFJHGGAD> KGAOHBBGPDF => kGAOHBBGPDF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNPOHCGPDFP NMNOCJDJKOG
	{
		get
		{
			return nMNOCJDJKOG_;
		}
		set
		{
			nMNOCJDJKOG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLIBFMJMDAH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLIBFMJMDAH(HLIBFMJMDAH other)
		: this()
	{
		jADGOJLEKKK_ = other.jADGOJLEKKK_.Clone();
		nODLNKMMBIJ_ = other.nODLNKMMBIJ_.Clone();
		kGAOHBBGPDF_ = other.kGAOHBBGPDF_.Clone();
		nMNOCJDJKOG_ = ((other.nMNOCJDJKOG_ != null) ? other.nMNOCJDJKOG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLIBFMJMDAH Clone()
	{
		return new HLIBFMJMDAH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HLIBFMJMDAH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HLIBFMJMDAH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jADGOJLEKKK_.Equals(other.jADGOJLEKKK_))
		{
			return false;
		}
		if (!nODLNKMMBIJ_.Equals(other.nODLNKMMBIJ_))
		{
			return false;
		}
		if (!kGAOHBBGPDF_.Equals(other.kGAOHBBGPDF_))
		{
			return false;
		}
		if (!object.Equals(NMNOCJDJKOG, other.NMNOCJDJKOG))
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
		num ^= jADGOJLEKKK_.GetHashCode();
		num ^= nODLNKMMBIJ_.GetHashCode();
		num ^= kGAOHBBGPDF_.GetHashCode();
		if (nMNOCJDJKOG_ != null)
		{
			num ^= NMNOCJDJKOG.GetHashCode();
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
		jADGOJLEKKK_.WriteTo(ref output, _repeated_jADGOJLEKKK_codec);
		nODLNKMMBIJ_.WriteTo(ref output, _repeated_nODLNKMMBIJ_codec);
		kGAOHBBGPDF_.WriteTo(ref output, _repeated_kGAOHBBGPDF_codec);
		if (nMNOCJDJKOG_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(NMNOCJDJKOG);
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
		num += jADGOJLEKKK_.CalculateSize(_repeated_jADGOJLEKKK_codec);
		num += nODLNKMMBIJ_.CalculateSize(_repeated_nODLNKMMBIJ_codec);
		num += kGAOHBBGPDF_.CalculateSize(_repeated_kGAOHBBGPDF_codec);
		if (nMNOCJDJKOG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NMNOCJDJKOG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HLIBFMJMDAH other)
	{
		if (other == null)
		{
			return;
		}
		jADGOJLEKKK_.Add(other.jADGOJLEKKK_);
		nODLNKMMBIJ_.Add(other.nODLNKMMBIJ_);
		kGAOHBBGPDF_.Add(other.kGAOHBBGPDF_);
		if (other.nMNOCJDJKOG_ != null)
		{
			if (nMNOCJDJKOG_ == null)
			{
				NMNOCJDJKOG = new CNPOHCGPDFP();
			}
			NMNOCJDJKOG.MergeFrom(other.NMNOCJDJKOG);
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
				jADGOJLEKKK_.AddEntriesFrom(ref input, _repeated_jADGOJLEKKK_codec);
				break;
			case 34u:
				nODLNKMMBIJ_.AddEntriesFrom(ref input, _repeated_nODLNKMMBIJ_codec);
				break;
			case 74u:
				kGAOHBBGPDF_.AddEntriesFrom(ref input, _repeated_kGAOHBBGPDF_codec);
				break;
			case 114u:
				if (nMNOCJDJKOG_ == null)
				{
					NMNOCJDJKOG = new CNPOHCGPDFP();
				}
				input.ReadMessage(NMNOCJDJKOG);
				break;
			}
		}
	}
}

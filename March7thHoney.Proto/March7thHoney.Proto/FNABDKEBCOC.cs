using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FNABDKEBCOC : IMessage<FNABDKEBCOC>, IMessage, IEquatable<FNABDKEBCOC>, IDeepCloneable<FNABDKEBCOC>, IBufferMessage
{
	private static readonly MessageParser<FNABDKEBCOC> _parser = new MessageParser<FNABDKEBCOC>(() => new FNABDKEBCOC());

	private UnknownFieldSet _unknownFields;

	public const int CLKAILDCPJCFieldNumber = 2;

	private static readonly FieldCodec<EKOIHOMFMDE> _repeated_cLKAILDCPJC_codec = FieldCodec.ForMessage(18u, EKOIHOMFMDE.Parser);

	private readonly RepeatedField<EKOIHOMFMDE> cLKAILDCPJC_ = new RepeatedField<EKOIHOMFMDE>();

	public const int OOPCHIHIIFEFieldNumber = 4;

	private uint oOPCHIHIIFE_;

	public const int ALCBHJEMCPCFieldNumber = 5;

	private uint aLCBHJEMCPC_;

	public const int ODHJKLKICFLFieldNumber = 6;

	private uint oDHJKLKICFL_;

	public const int JHKMLGJKIIMFieldNumber = 7;

	private EKOIHOMFMDE jHKMLGJKIIM_;

	public const int GFDDBPAEAOIFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_gFDDBPAEAOI_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> gFDDBPAEAOI_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FNABDKEBCOC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FNABDKEBCOCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EKOIHOMFMDE> CLKAILDCPJC => cLKAILDCPJC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OOPCHIHIIFE
	{
		get
		{
			return oOPCHIHIIFE_;
		}
		set
		{
			oOPCHIHIIFE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ALCBHJEMCPC
	{
		get
		{
			return aLCBHJEMCPC_;
		}
		set
		{
			aLCBHJEMCPC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ODHJKLKICFL
	{
		get
		{
			return oDHJKLKICFL_;
		}
		set
		{
			oDHJKLKICFL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EKOIHOMFMDE JHKMLGJKIIM
	{
		get
		{
			return jHKMLGJKIIM_;
		}
		set
		{
			jHKMLGJKIIM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GFDDBPAEAOI => gFDDBPAEAOI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNABDKEBCOC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNABDKEBCOC(FNABDKEBCOC other)
		: this()
	{
		cLKAILDCPJC_ = other.cLKAILDCPJC_.Clone();
		oOPCHIHIIFE_ = other.oOPCHIHIIFE_;
		aLCBHJEMCPC_ = other.aLCBHJEMCPC_;
		oDHJKLKICFL_ = other.oDHJKLKICFL_;
		jHKMLGJKIIM_ = ((other.jHKMLGJKIIM_ != null) ? other.jHKMLGJKIIM_.Clone() : null);
		gFDDBPAEAOI_ = other.gFDDBPAEAOI_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNABDKEBCOC Clone()
	{
		return new FNABDKEBCOC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FNABDKEBCOC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FNABDKEBCOC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cLKAILDCPJC_.Equals(other.cLKAILDCPJC_))
		{
			return false;
		}
		if (OOPCHIHIIFE != other.OOPCHIHIIFE)
		{
			return false;
		}
		if (ALCBHJEMCPC != other.ALCBHJEMCPC)
		{
			return false;
		}
		if (ODHJKLKICFL != other.ODHJKLKICFL)
		{
			return false;
		}
		if (!object.Equals(JHKMLGJKIIM, other.JHKMLGJKIIM))
		{
			return false;
		}
		if (!gFDDBPAEAOI_.Equals(other.gFDDBPAEAOI_))
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
		num ^= cLKAILDCPJC_.GetHashCode();
		if (OOPCHIHIIFE != 0)
		{
			num ^= OOPCHIHIIFE.GetHashCode();
		}
		if (ALCBHJEMCPC != 0)
		{
			num ^= ALCBHJEMCPC.GetHashCode();
		}
		if (ODHJKLKICFL != 0)
		{
			num ^= ODHJKLKICFL.GetHashCode();
		}
		if (jHKMLGJKIIM_ != null)
		{
			num ^= JHKMLGJKIIM.GetHashCode();
		}
		num ^= gFDDBPAEAOI_.GetHashCode();
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
		cLKAILDCPJC_.WriteTo(ref output, _repeated_cLKAILDCPJC_codec);
		if (OOPCHIHIIFE != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(OOPCHIHIIFE);
		}
		if (ALCBHJEMCPC != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(ALCBHJEMCPC);
		}
		if (ODHJKLKICFL != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(ODHJKLKICFL);
		}
		if (jHKMLGJKIIM_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(JHKMLGJKIIM);
		}
		gFDDBPAEAOI_.WriteTo(ref output, _repeated_gFDDBPAEAOI_codec);
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
		num += cLKAILDCPJC_.CalculateSize(_repeated_cLKAILDCPJC_codec);
		if (OOPCHIHIIFE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OOPCHIHIIFE);
		}
		if (ALCBHJEMCPC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ALCBHJEMCPC);
		}
		if (ODHJKLKICFL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ODHJKLKICFL);
		}
		if (jHKMLGJKIIM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JHKMLGJKIIM);
		}
		num += gFDDBPAEAOI_.CalculateSize(_repeated_gFDDBPAEAOI_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FNABDKEBCOC other)
	{
		if (other == null)
		{
			return;
		}
		cLKAILDCPJC_.Add(other.cLKAILDCPJC_);
		if (other.OOPCHIHIIFE != 0)
		{
			OOPCHIHIIFE = other.OOPCHIHIIFE;
		}
		if (other.ALCBHJEMCPC != 0)
		{
			ALCBHJEMCPC = other.ALCBHJEMCPC;
		}
		if (other.ODHJKLKICFL != 0)
		{
			ODHJKLKICFL = other.ODHJKLKICFL;
		}
		if (other.jHKMLGJKIIM_ != null)
		{
			if (jHKMLGJKIIM_ == null)
			{
				JHKMLGJKIIM = new EKOIHOMFMDE();
			}
			JHKMLGJKIIM.MergeFrom(other.JHKMLGJKIIM);
		}
		gFDDBPAEAOI_.Add(other.gFDDBPAEAOI_);
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
			case 18u:
				cLKAILDCPJC_.AddEntriesFrom(ref input, _repeated_cLKAILDCPJC_codec);
				break;
			case 32u:
				OOPCHIHIIFE = input.ReadUInt32();
				break;
			case 40u:
				ALCBHJEMCPC = input.ReadUInt32();
				break;
			case 48u:
				ODHJKLKICFL = input.ReadUInt32();
				break;
			case 58u:
				if (jHKMLGJKIIM_ == null)
				{
					JHKMLGJKIIM = new EKOIHOMFMDE();
				}
				input.ReadMessage(JHKMLGJKIIM);
				break;
			case 120u:
			case 122u:
				gFDDBPAEAOI_.AddEntriesFrom(ref input, _repeated_gFDDBPAEAOI_codec);
				break;
			}
		}
	}
}

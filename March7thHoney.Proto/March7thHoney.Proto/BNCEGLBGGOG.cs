using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BNCEGLBGGOG : IMessage<BNCEGLBGGOG>, IMessage, IEquatable<BNCEGLBGGOG>, IDeepCloneable<BNCEGLBGGOG>, IBufferMessage
{
	private static readonly MessageParser<BNCEGLBGGOG> _parser = new MessageParser<BNCEGLBGGOG>(() => new BNCEGLBGGOG());

	private UnknownFieldSet _unknownFields;

	public const int PFDKKFPPAAAFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_pFDKKFPPAAA_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> pFDKKFPPAAA_ = new RepeatedField<uint>();

	public const int EOMPAOGAABOFieldNumber = 3;

	private ByteString eOMPAOGAABO_ = ByteString.Empty;

	public const int DEOFAJNJIFLFieldNumber = 4;

	private static readonly FieldCodec<OBJGGJPFLAE> _repeated_dEOFAJNJIFL_codec = FieldCodec.ForMessage(34u, OBJGGJPFLAE.Parser);

	private readonly RepeatedField<OBJGGJPFLAE> dEOFAJNJIFL_ = new RepeatedField<OBJGGJPFLAE>();

	public const int GJJPEPBPCKMFieldNumber = 5;

	private uint gJJPEPBPCKM_;

	public const int FCBPJKAPPLFFieldNumber = 7;

	private static readonly FieldCodec<NLDJBMBDCHE> _repeated_fCBPJKAPPLF_codec = FieldCodec.ForMessage(58u, NLDJBMBDCHE.Parser);

	private readonly RepeatedField<NLDJBMBDCHE> fCBPJKAPPLF_ = new RepeatedField<NLDJBMBDCHE>();

	public const int AKIFPPJCNACFieldNumber = 11;

	private ByteString aKIFPPJCNAC_ = ByteString.Empty;

	public const int EDOAIEMIODHFieldNumber = 14;

	private static readonly FieldCodec<HEHGNIICKAA> _repeated_eDOAIEMIODH_codec = FieldCodec.ForMessage(114u, HEHGNIICKAA.Parser);

	private readonly RepeatedField<HEHGNIICKAA> eDOAIEMIODH_ = new RepeatedField<HEHGNIICKAA>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BNCEGLBGGOG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BNCEGLBGGOGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PFDKKFPPAAA => pFDKKFPPAAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ByteString EOMPAOGAABO
	{
		get
		{
			return eOMPAOGAABO_;
		}
		set
		{
			eOMPAOGAABO_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OBJGGJPFLAE> DEOFAJNJIFL => dEOFAJNJIFL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GJJPEPBPCKM
	{
		get
		{
			return gJJPEPBPCKM_;
		}
		set
		{
			gJJPEPBPCKM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NLDJBMBDCHE> FCBPJKAPPLF => fCBPJKAPPLF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ByteString AKIFPPJCNAC
	{
		get
		{
			return aKIFPPJCNAC_;
		}
		set
		{
			aKIFPPJCNAC_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HEHGNIICKAA> EDOAIEMIODH => eDOAIEMIODH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNCEGLBGGOG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNCEGLBGGOG(BNCEGLBGGOG other)
		: this()
	{
		pFDKKFPPAAA_ = other.pFDKKFPPAAA_.Clone();
		eOMPAOGAABO_ = other.eOMPAOGAABO_;
		dEOFAJNJIFL_ = other.dEOFAJNJIFL_.Clone();
		gJJPEPBPCKM_ = other.gJJPEPBPCKM_;
		fCBPJKAPPLF_ = other.fCBPJKAPPLF_.Clone();
		aKIFPPJCNAC_ = other.aKIFPPJCNAC_;
		eDOAIEMIODH_ = other.eDOAIEMIODH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNCEGLBGGOG Clone()
	{
		return new BNCEGLBGGOG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BNCEGLBGGOG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BNCEGLBGGOG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!pFDKKFPPAAA_.Equals(other.pFDKKFPPAAA_))
		{
			return false;
		}
		if (EOMPAOGAABO != other.EOMPAOGAABO)
		{
			return false;
		}
		if (!dEOFAJNJIFL_.Equals(other.dEOFAJNJIFL_))
		{
			return false;
		}
		if (GJJPEPBPCKM != other.GJJPEPBPCKM)
		{
			return false;
		}
		if (!fCBPJKAPPLF_.Equals(other.fCBPJKAPPLF_))
		{
			return false;
		}
		if (AKIFPPJCNAC != other.AKIFPPJCNAC)
		{
			return false;
		}
		if (!eDOAIEMIODH_.Equals(other.eDOAIEMIODH_))
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
		num ^= pFDKKFPPAAA_.GetHashCode();
		if (EOMPAOGAABO.Length != 0)
		{
			num ^= EOMPAOGAABO.GetHashCode();
		}
		num ^= dEOFAJNJIFL_.GetHashCode();
		if (GJJPEPBPCKM != 0)
		{
			num ^= GJJPEPBPCKM.GetHashCode();
		}
		num ^= fCBPJKAPPLF_.GetHashCode();
		if (AKIFPPJCNAC.Length != 0)
		{
			num ^= AKIFPPJCNAC.GetHashCode();
		}
		num ^= eDOAIEMIODH_.GetHashCode();
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
		pFDKKFPPAAA_.WriteTo(ref output, _repeated_pFDKKFPPAAA_codec);
		if (EOMPAOGAABO.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteBytes(EOMPAOGAABO);
		}
		dEOFAJNJIFL_.WriteTo(ref output, _repeated_dEOFAJNJIFL_codec);
		if (GJJPEPBPCKM != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(GJJPEPBPCKM);
		}
		fCBPJKAPPLF_.WriteTo(ref output, _repeated_fCBPJKAPPLF_codec);
		if (AKIFPPJCNAC.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteBytes(AKIFPPJCNAC);
		}
		eDOAIEMIODH_.WriteTo(ref output, _repeated_eDOAIEMIODH_codec);
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
		num += pFDKKFPPAAA_.CalculateSize(_repeated_pFDKKFPPAAA_codec);
		if (EOMPAOGAABO.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(EOMPAOGAABO);
		}
		num += dEOFAJNJIFL_.CalculateSize(_repeated_dEOFAJNJIFL_codec);
		if (GJJPEPBPCKM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GJJPEPBPCKM);
		}
		num += fCBPJKAPPLF_.CalculateSize(_repeated_fCBPJKAPPLF_codec);
		if (AKIFPPJCNAC.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(AKIFPPJCNAC);
		}
		num += eDOAIEMIODH_.CalculateSize(_repeated_eDOAIEMIODH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BNCEGLBGGOG other)
	{
		if (other != null)
		{
			pFDKKFPPAAA_.Add(other.pFDKKFPPAAA_);
			if (other.EOMPAOGAABO.Length != 0)
			{
				EOMPAOGAABO = other.EOMPAOGAABO;
			}
			dEOFAJNJIFL_.Add(other.dEOFAJNJIFL_);
			if (other.GJJPEPBPCKM != 0)
			{
				GJJPEPBPCKM = other.GJJPEPBPCKM;
			}
			fCBPJKAPPLF_.Add(other.fCBPJKAPPLF_);
			if (other.AKIFPPJCNAC.Length != 0)
			{
				AKIFPPJCNAC = other.AKIFPPJCNAC;
			}
			eDOAIEMIODH_.Add(other.eDOAIEMIODH_);
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
			case 10u:
				pFDKKFPPAAA_.AddEntriesFrom(ref input, _repeated_pFDKKFPPAAA_codec);
				break;
			case 26u:
				EOMPAOGAABO = input.ReadBytes();
				break;
			case 34u:
				dEOFAJNJIFL_.AddEntriesFrom(ref input, _repeated_dEOFAJNJIFL_codec);
				break;
			case 40u:
				GJJPEPBPCKM = input.ReadUInt32();
				break;
			case 58u:
				fCBPJKAPPLF_.AddEntriesFrom(ref input, _repeated_fCBPJKAPPLF_codec);
				break;
			case 90u:
				AKIFPPJCNAC = input.ReadBytes();
				break;
			case 114u:
				eDOAIEMIODH_.AddEntriesFrom(ref input, _repeated_eDOAIEMIODH_codec);
				break;
			}
		}
	}
}

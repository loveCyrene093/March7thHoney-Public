using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChimeraFinishRoundCsReq : IMessage<ChimeraFinishRoundCsReq>, IMessage, IEquatable<ChimeraFinishRoundCsReq>, IDeepCloneable<ChimeraFinishRoundCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChimeraFinishRoundCsReq> _parser = new MessageParser<ChimeraFinishRoundCsReq>(() => new ChimeraFinishRoundCsReq());

	private UnknownFieldSet _unknownFields;

	public const int EndReasonFieldNumber = 1;

	private ChimeraRoundWorkEndReason endReason_;

	public const int SttFieldNumber = 2;

	private HAMEJPGCIJI stt_;

	public const int LNAOHDBGENOFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_lNAOHDBGENO_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> lNAOHDBGENO_ = new RepeatedField<uint>();

	public const int PGEGMMBINIDFieldNumber = 6;

	private bool pGEGMMBINID_;

	public const int LineupFieldNumber = 10;

	private FHCCCHJHHKL lineup_;

	public const int KMAFDFBJCJIFieldNumber = 11;

	private static readonly FieldCodec<PCAOLJLFPBA> _repeated_kMAFDFBJCJI_codec = FieldCodec.ForMessage(90u, PCAOLJLFPBA.Parser);

	private readonly RepeatedField<PCAOLJLFPBA> kMAFDFBJCJI_ = new RepeatedField<PCAOLJLFPBA>();

	public const int JHDKOBKNPDEFieldNumber = 12;

	private uint jHDKOBKNPDE_;

	public const int PKIPMNNDIPAFieldNumber = 13;

	private static readonly MapField<uint, uint>.Codec _map_pKIPMNNDIPA_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 106u);

	private readonly MapField<uint, uint> pKIPMNNDIPA_ = new MapField<uint, uint>();

	public const int KMOCHCFLDCMFieldNumber = 15;

	private static readonly MapField<uint, BCMMLADBEAM>.Codec _map_kMOCHCFLDCM_codec = new MapField<uint, BCMMLADBEAM>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForMessage(18u, BCMMLADBEAM.Parser), 122u);

	private readonly MapField<uint, BCMMLADBEAM> kMOCHCFLDCM_ = new MapField<uint, BCMMLADBEAM>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChimeraFinishRoundCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChimeraFinishRoundCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraRoundWorkEndReason EndReason
	{
		get
		{
			return endReason_;
		}
		set
		{
			endReason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HAMEJPGCIJI Stt
	{
		get
		{
			return stt_;
		}
		set
		{
			stt_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LNAOHDBGENO => lNAOHDBGENO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PGEGMMBINID
	{
		get
		{
			return pGEGMMBINID_;
		}
		set
		{
			pGEGMMBINID_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FHCCCHJHHKL Lineup
	{
		get
		{
			return lineup_;
		}
		set
		{
			lineup_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PCAOLJLFPBA> KMAFDFBJCJI => kMAFDFBJCJI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JHDKOBKNPDE
	{
		get
		{
			return jHDKOBKNPDE_;
		}
		set
		{
			jHDKOBKNPDE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> PKIPMNNDIPA => pKIPMNNDIPA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, BCMMLADBEAM> KMOCHCFLDCM => kMOCHCFLDCM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraFinishRoundCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraFinishRoundCsReq(ChimeraFinishRoundCsReq other)
		: this()
	{
		endReason_ = other.endReason_;
		stt_ = ((other.stt_ != null) ? other.stt_.Clone() : null);
		lNAOHDBGENO_ = other.lNAOHDBGENO_.Clone();
		pGEGMMBINID_ = other.pGEGMMBINID_;
		lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
		kMAFDFBJCJI_ = other.kMAFDFBJCJI_.Clone();
		jHDKOBKNPDE_ = other.jHDKOBKNPDE_;
		pKIPMNNDIPA_ = other.pKIPMNNDIPA_.Clone();
		kMOCHCFLDCM_ = other.kMOCHCFLDCM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraFinishRoundCsReq Clone()
	{
		return new ChimeraFinishRoundCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChimeraFinishRoundCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChimeraFinishRoundCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EndReason != other.EndReason)
		{
			return false;
		}
		if (!object.Equals(Stt, other.Stt))
		{
			return false;
		}
		if (!lNAOHDBGENO_.Equals(other.lNAOHDBGENO_))
		{
			return false;
		}
		if (PGEGMMBINID != other.PGEGMMBINID)
		{
			return false;
		}
		if (!object.Equals(Lineup, other.Lineup))
		{
			return false;
		}
		if (!kMAFDFBJCJI_.Equals(other.kMAFDFBJCJI_))
		{
			return false;
		}
		if (JHDKOBKNPDE != other.JHDKOBKNPDE)
		{
			return false;
		}
		if (!PKIPMNNDIPA.Equals(other.PKIPMNNDIPA))
		{
			return false;
		}
		if (!KMOCHCFLDCM.Equals(other.KMOCHCFLDCM))
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
		if (EndReason != ChimeraRoundWorkEndReason.DjfficeebaaOdceomjacme)
		{
			num ^= EndReason.GetHashCode();
		}
		if (stt_ != null)
		{
			num ^= Stt.GetHashCode();
		}
		num ^= lNAOHDBGENO_.GetHashCode();
		if (PGEGMMBINID)
		{
			num ^= PGEGMMBINID.GetHashCode();
		}
		if (lineup_ != null)
		{
			num ^= Lineup.GetHashCode();
		}
		num ^= kMAFDFBJCJI_.GetHashCode();
		if (JHDKOBKNPDE != 0)
		{
			num ^= JHDKOBKNPDE.GetHashCode();
		}
		num ^= PKIPMNNDIPA.GetHashCode();
		num ^= KMOCHCFLDCM.GetHashCode();
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
		if (EndReason != ChimeraRoundWorkEndReason.DjfficeebaaOdceomjacme)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)EndReason);
		}
		if (stt_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Stt);
		}
		lNAOHDBGENO_.WriteTo(ref output, _repeated_lNAOHDBGENO_codec);
		if (PGEGMMBINID)
		{
			output.WriteRawTag(48);
			output.WriteBool(PGEGMMBINID);
		}
		if (lineup_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(Lineup);
		}
		kMAFDFBJCJI_.WriteTo(ref output, _repeated_kMAFDFBJCJI_codec);
		if (JHDKOBKNPDE != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(JHDKOBKNPDE);
		}
		pKIPMNNDIPA_.WriteTo(ref output, _map_pKIPMNNDIPA_codec);
		kMOCHCFLDCM_.WriteTo(ref output, _map_kMOCHCFLDCM_codec);
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
		if (EndReason != ChimeraRoundWorkEndReason.DjfficeebaaOdceomjacme)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EndReason);
		}
		if (stt_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Stt);
		}
		num += lNAOHDBGENO_.CalculateSize(_repeated_lNAOHDBGENO_codec);
		if (PGEGMMBINID)
		{
			num += 2;
		}
		if (lineup_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Lineup);
		}
		num += kMAFDFBJCJI_.CalculateSize(_repeated_kMAFDFBJCJI_codec);
		if (JHDKOBKNPDE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JHDKOBKNPDE);
		}
		num += pKIPMNNDIPA_.CalculateSize(_map_pKIPMNNDIPA_codec);
		num += kMOCHCFLDCM_.CalculateSize(_map_kMOCHCFLDCM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChimeraFinishRoundCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.EndReason != ChimeraRoundWorkEndReason.DjfficeebaaOdceomjacme)
		{
			EndReason = other.EndReason;
		}
		if (other.stt_ != null)
		{
			if (stt_ == null)
			{
				Stt = new HAMEJPGCIJI();
			}
			Stt.MergeFrom(other.Stt);
		}
		lNAOHDBGENO_.Add(other.lNAOHDBGENO_);
		if (other.PGEGMMBINID)
		{
			PGEGMMBINID = other.PGEGMMBINID;
		}
		if (other.lineup_ != null)
		{
			if (lineup_ == null)
			{
				Lineup = new FHCCCHJHHKL();
			}
			Lineup.MergeFrom(other.Lineup);
		}
		kMAFDFBJCJI_.Add(other.kMAFDFBJCJI_);
		if (other.JHDKOBKNPDE != 0)
		{
			JHDKOBKNPDE = other.JHDKOBKNPDE;
		}
		pKIPMNNDIPA_.MergeFrom(other.pKIPMNNDIPA_);
		kMOCHCFLDCM_.MergeFrom(other.kMOCHCFLDCM_);
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
			case 8u:
				EndReason = (ChimeraRoundWorkEndReason)input.ReadEnum();
				break;
			case 18u:
				if (stt_ == null)
				{
					Stt = new HAMEJPGCIJI();
				}
				input.ReadMessage(Stt);
				break;
			case 24u:
			case 26u:
				lNAOHDBGENO_.AddEntriesFrom(ref input, _repeated_lNAOHDBGENO_codec);
				break;
			case 48u:
				PGEGMMBINID = input.ReadBool();
				break;
			case 82u:
				if (lineup_ == null)
				{
					Lineup = new FHCCCHJHHKL();
				}
				input.ReadMessage(Lineup);
				break;
			case 90u:
				kMAFDFBJCJI_.AddEntriesFrom(ref input, _repeated_kMAFDFBJCJI_codec);
				break;
			case 96u:
				JHDKOBKNPDE = input.ReadUInt32();
				break;
			case 106u:
				pKIPMNNDIPA_.AddEntriesFrom(ref input, _map_pKIPMNNDIPA_codec);
				break;
			case 122u:
				kMOCHCFLDCM_.AddEntriesFrom(ref input, _map_kMOCHCFLDCM_codec);
				break;
			}
		}
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChimeraDoFinalRoundCsReq : IMessage<ChimeraDoFinalRoundCsReq>, IMessage, IEquatable<ChimeraDoFinalRoundCsReq>, IDeepCloneable<ChimeraDoFinalRoundCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChimeraDoFinalRoundCsReq> _parser = new MessageParser<ChimeraDoFinalRoundCsReq>(() => new ChimeraDoFinalRoundCsReq());

	private UnknownFieldSet _unknownFields;

	public const int KMAFDFBJCJIFieldNumber = 1;

	private static readonly FieldCodec<PCAOLJLFPBA> _repeated_kMAFDFBJCJI_codec = FieldCodec.ForMessage(10u, PCAOLJLFPBA.Parser);

	private readonly RepeatedField<PCAOLJLFPBA> kMAFDFBJCJI_ = new RepeatedField<PCAOLJLFPBA>();

	public const int LineupFieldNumber = 3;

	private FHCCCHJHHKL lineup_;

	public const int SttFieldNumber = 6;

	private HAMEJPGCIJI stt_;

	public const int LNAOHDBGENOFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_lNAOHDBGENO_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> lNAOHDBGENO_ = new RepeatedField<uint>();

	public const int OIPLJJIODILFieldNumber = 11;

	private bool oIPLJJIODIL_;

	public const int NKBDDIDFPNEFieldNumber = 12;

	private uint nKBDDIDFPNE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChimeraDoFinalRoundCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChimeraDoFinalRoundCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PCAOLJLFPBA> KMAFDFBJCJI => kMAFDFBJCJI_;

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
	public bool OIPLJJIODIL
	{
		get
		{
			return oIPLJJIODIL_;
		}
		set
		{
			oIPLJJIODIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NKBDDIDFPNE
	{
		get
		{
			return nKBDDIDFPNE_;
		}
		set
		{
			nKBDDIDFPNE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDoFinalRoundCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDoFinalRoundCsReq(ChimeraDoFinalRoundCsReq other)
		: this()
	{
		kMAFDFBJCJI_ = other.kMAFDFBJCJI_.Clone();
		lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
		stt_ = ((other.stt_ != null) ? other.stt_.Clone() : null);
		lNAOHDBGENO_ = other.lNAOHDBGENO_.Clone();
		oIPLJJIODIL_ = other.oIPLJJIODIL_;
		nKBDDIDFPNE_ = other.nKBDDIDFPNE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDoFinalRoundCsReq Clone()
	{
		return new ChimeraDoFinalRoundCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChimeraDoFinalRoundCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChimeraDoFinalRoundCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!kMAFDFBJCJI_.Equals(other.kMAFDFBJCJI_))
		{
			return false;
		}
		if (!object.Equals(Lineup, other.Lineup))
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
		if (OIPLJJIODIL != other.OIPLJJIODIL)
		{
			return false;
		}
		if (NKBDDIDFPNE != other.NKBDDIDFPNE)
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
		num ^= kMAFDFBJCJI_.GetHashCode();
		if (lineup_ != null)
		{
			num ^= Lineup.GetHashCode();
		}
		if (stt_ != null)
		{
			num ^= Stt.GetHashCode();
		}
		num ^= lNAOHDBGENO_.GetHashCode();
		if (OIPLJJIODIL)
		{
			num ^= OIPLJJIODIL.GetHashCode();
		}
		if (NKBDDIDFPNE != 0)
		{
			num ^= NKBDDIDFPNE.GetHashCode();
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
		kMAFDFBJCJI_.WriteTo(ref output, _repeated_kMAFDFBJCJI_codec);
		if (lineup_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Lineup);
		}
		if (stt_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(Stt);
		}
		lNAOHDBGENO_.WriteTo(ref output, _repeated_lNAOHDBGENO_codec);
		if (OIPLJJIODIL)
		{
			output.WriteRawTag(88);
			output.WriteBool(OIPLJJIODIL);
		}
		if (NKBDDIDFPNE != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(NKBDDIDFPNE);
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
		num += kMAFDFBJCJI_.CalculateSize(_repeated_kMAFDFBJCJI_codec);
		if (lineup_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Lineup);
		}
		if (stt_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Stt);
		}
		num += lNAOHDBGENO_.CalculateSize(_repeated_lNAOHDBGENO_codec);
		if (OIPLJJIODIL)
		{
			num += 2;
		}
		if (NKBDDIDFPNE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NKBDDIDFPNE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChimeraDoFinalRoundCsReq other)
	{
		if (other == null)
		{
			return;
		}
		kMAFDFBJCJI_.Add(other.kMAFDFBJCJI_);
		if (other.lineup_ != null)
		{
			if (lineup_ == null)
			{
				Lineup = new FHCCCHJHHKL();
			}
			Lineup.MergeFrom(other.Lineup);
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
		if (other.OIPLJJIODIL)
		{
			OIPLJJIODIL = other.OIPLJJIODIL;
		}
		if (other.NKBDDIDFPNE != 0)
		{
			NKBDDIDFPNE = other.NKBDDIDFPNE;
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
			case 10u:
				kMAFDFBJCJI_.AddEntriesFrom(ref input, _repeated_kMAFDFBJCJI_codec);
				break;
			case 26u:
				if (lineup_ == null)
				{
					Lineup = new FHCCCHJHHKL();
				}
				input.ReadMessage(Lineup);
				break;
			case 50u:
				if (stt_ == null)
				{
					Stt = new HAMEJPGCIJI();
				}
				input.ReadMessage(Stt);
				break;
			case 72u:
			case 74u:
				lNAOHDBGENO_.AddEntriesFrom(ref input, _repeated_lNAOHDBGENO_codec);
				break;
			case 88u:
				OIPLJJIODIL = input.ReadBool();
				break;
			case 96u:
				NKBDDIDFPNE = input.ReadUInt32();
				break;
			}
		}
	}
}

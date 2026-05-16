using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChimeraFinishEndlessRoundCsReq : IMessage<ChimeraFinishEndlessRoundCsReq>, IMessage, IEquatable<ChimeraFinishEndlessRoundCsReq>, IDeepCloneable<ChimeraFinishEndlessRoundCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChimeraFinishEndlessRoundCsReq> _parser = new MessageParser<ChimeraFinishEndlessRoundCsReq>(() => new ChimeraFinishEndlessRoundCsReq());

	private UnknownFieldSet _unknownFields;

	public const int SttFieldNumber = 5;

	private HAMEJPGCIJI stt_;

	public const int OIPLJJIODILFieldNumber = 6;

	private bool oIPLJJIODIL_;

	public const int LineupFieldNumber = 10;

	private FHCCCHJHHKL lineup_;

	public const int NKBDDIDFPNEFieldNumber = 11;

	private uint nKBDDIDFPNE_;

	public const int KMAFDFBJCJIFieldNumber = 14;

	private static readonly FieldCodec<PCAOLJLFPBA> _repeated_kMAFDFBJCJI_codec = FieldCodec.ForMessage(114u, PCAOLJLFPBA.Parser);

	private readonly RepeatedField<PCAOLJLFPBA> kMAFDFBJCJI_ = new RepeatedField<PCAOLJLFPBA>();

	public const int LNAOHDBGENOFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_lNAOHDBGENO_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> lNAOHDBGENO_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChimeraFinishEndlessRoundCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChimeraFinishEndlessRoundCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<PCAOLJLFPBA> KMAFDFBJCJI => kMAFDFBJCJI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LNAOHDBGENO => lNAOHDBGENO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraFinishEndlessRoundCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraFinishEndlessRoundCsReq(ChimeraFinishEndlessRoundCsReq other)
		: this()
	{
		stt_ = ((other.stt_ != null) ? other.stt_.Clone() : null);
		oIPLJJIODIL_ = other.oIPLJJIODIL_;
		lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
		nKBDDIDFPNE_ = other.nKBDDIDFPNE_;
		kMAFDFBJCJI_ = other.kMAFDFBJCJI_.Clone();
		lNAOHDBGENO_ = other.lNAOHDBGENO_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraFinishEndlessRoundCsReq Clone()
	{
		return new ChimeraFinishEndlessRoundCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChimeraFinishEndlessRoundCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChimeraFinishEndlessRoundCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Stt, other.Stt))
		{
			return false;
		}
		if (OIPLJJIODIL != other.OIPLJJIODIL)
		{
			return false;
		}
		if (!object.Equals(Lineup, other.Lineup))
		{
			return false;
		}
		if (NKBDDIDFPNE != other.NKBDDIDFPNE)
		{
			return false;
		}
		if (!kMAFDFBJCJI_.Equals(other.kMAFDFBJCJI_))
		{
			return false;
		}
		if (!lNAOHDBGENO_.Equals(other.lNAOHDBGENO_))
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
		if (stt_ != null)
		{
			num ^= Stt.GetHashCode();
		}
		if (OIPLJJIODIL)
		{
			num ^= OIPLJJIODIL.GetHashCode();
		}
		if (lineup_ != null)
		{
			num ^= Lineup.GetHashCode();
		}
		if (NKBDDIDFPNE != 0)
		{
			num ^= NKBDDIDFPNE.GetHashCode();
		}
		num ^= kMAFDFBJCJI_.GetHashCode();
		num ^= lNAOHDBGENO_.GetHashCode();
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
		if (stt_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(Stt);
		}
		if (OIPLJJIODIL)
		{
			output.WriteRawTag(48);
			output.WriteBool(OIPLJJIODIL);
		}
		if (lineup_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(Lineup);
		}
		if (NKBDDIDFPNE != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(NKBDDIDFPNE);
		}
		kMAFDFBJCJI_.WriteTo(ref output, _repeated_kMAFDFBJCJI_codec);
		lNAOHDBGENO_.WriteTo(ref output, _repeated_lNAOHDBGENO_codec);
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
		if (stt_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Stt);
		}
		if (OIPLJJIODIL)
		{
			num += 2;
		}
		if (lineup_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Lineup);
		}
		if (NKBDDIDFPNE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NKBDDIDFPNE);
		}
		num += kMAFDFBJCJI_.CalculateSize(_repeated_kMAFDFBJCJI_codec);
		num += lNAOHDBGENO_.CalculateSize(_repeated_lNAOHDBGENO_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChimeraFinishEndlessRoundCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.stt_ != null)
		{
			if (stt_ == null)
			{
				Stt = new HAMEJPGCIJI();
			}
			Stt.MergeFrom(other.Stt);
		}
		if (other.OIPLJJIODIL)
		{
			OIPLJJIODIL = other.OIPLJJIODIL;
		}
		if (other.lineup_ != null)
		{
			if (lineup_ == null)
			{
				Lineup = new FHCCCHJHHKL();
			}
			Lineup.MergeFrom(other.Lineup);
		}
		if (other.NKBDDIDFPNE != 0)
		{
			NKBDDIDFPNE = other.NKBDDIDFPNE;
		}
		kMAFDFBJCJI_.Add(other.kMAFDFBJCJI_);
		lNAOHDBGENO_.Add(other.lNAOHDBGENO_);
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
			case 42u:
				if (stt_ == null)
				{
					Stt = new HAMEJPGCIJI();
				}
				input.ReadMessage(Stt);
				break;
			case 48u:
				OIPLJJIODIL = input.ReadBool();
				break;
			case 82u:
				if (lineup_ == null)
				{
					Lineup = new FHCCCHJHHKL();
				}
				input.ReadMessage(Lineup);
				break;
			case 88u:
				NKBDDIDFPNE = input.ReadUInt32();
				break;
			case 114u:
				kMAFDFBJCJI_.AddEntriesFrom(ref input, _repeated_kMAFDFBJCJI_codec);
				break;
			case 120u:
			case 122u:
				lNAOHDBGENO_.AddEntriesFrom(ref input, _repeated_lNAOHDBGENO_codec);
				break;
			}
		}
	}
}

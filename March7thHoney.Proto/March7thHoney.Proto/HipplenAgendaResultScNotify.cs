using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HipplenAgendaResultScNotify : IMessage<HipplenAgendaResultScNotify>, IMessage, IEquatable<HipplenAgendaResultScNotify>, IDeepCloneable<HipplenAgendaResultScNotify>, IBufferMessage
{
	private static readonly MessageParser<HipplenAgendaResultScNotify> _parser = new MessageParser<HipplenAgendaResultScNotify>(() => new HipplenAgendaResultScNotify());

	private UnknownFieldSet _unknownFields;

	public const int GridFightTraitInfoFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_gridFightTraitInfo_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> gridFightTraitInfo_ = new RepeatedField<uint>();

	public const int JPFBGFIHDDHFieldNumber = 3;

	private DGKNDMAHMAP jPFBGFIHDDH_;

	public const int AEPDGDLMPMDFieldNumber = 8;

	private bool aEPDGDLMPMD_;

	public const int FCCEHOLHFOCFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_fCCEHOLHFOC_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> fCCEHOLHFOC_ = new RepeatedField<uint>();

	public const int KBNLIPOGOLEFieldNumber = 10;

	private EOKOFFPBJME kBNLIPOGOLE_;

	public const int CLKAILDCPJCFieldNumber = 12;

	private static readonly FieldCodec<EKOIHOMFMDE> _repeated_cLKAILDCPJC_codec = FieldCodec.ForMessage(98u, EKOIHOMFMDE.Parser);

	private readonly RepeatedField<EKOIHOMFMDE> cLKAILDCPJC_ = new RepeatedField<EKOIHOMFMDE>();

	public const int ACJHGLGHEAHFieldNumber = 14;

	private OOLHNFNKOHN aCJHGLGHEAH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HipplenAgendaResultScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HipplenAgendaResultScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GridFightTraitInfo => gridFightTraitInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGKNDMAHMAP JPFBGFIHDDH
	{
		get
		{
			return jPFBGFIHDDH_;
		}
		set
		{
			jPFBGFIHDDH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool AEPDGDLMPMD
	{
		get
		{
			return aEPDGDLMPMD_;
		}
		set
		{
			aEPDGDLMPMD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FCCEHOLHFOC => fCCEHOLHFOC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EOKOFFPBJME KBNLIPOGOLE
	{
		get
		{
			return kBNLIPOGOLE_;
		}
		set
		{
			kBNLIPOGOLE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EKOIHOMFMDE> CLKAILDCPJC => cLKAILDCPJC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOLHNFNKOHN ACJHGLGHEAH
	{
		get
		{
			return aCJHGLGHEAH_;
		}
		set
		{
			aCJHGLGHEAH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HipplenAgendaResultScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HipplenAgendaResultScNotify(HipplenAgendaResultScNotify other)
		: this()
	{
		gridFightTraitInfo_ = other.gridFightTraitInfo_.Clone();
		jPFBGFIHDDH_ = ((other.jPFBGFIHDDH_ != null) ? other.jPFBGFIHDDH_.Clone() : null);
		aEPDGDLMPMD_ = other.aEPDGDLMPMD_;
		fCCEHOLHFOC_ = other.fCCEHOLHFOC_.Clone();
		kBNLIPOGOLE_ = ((other.kBNLIPOGOLE_ != null) ? other.kBNLIPOGOLE_.Clone() : null);
		cLKAILDCPJC_ = other.cLKAILDCPJC_.Clone();
		aCJHGLGHEAH_ = ((other.aCJHGLGHEAH_ != null) ? other.aCJHGLGHEAH_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HipplenAgendaResultScNotify Clone()
	{
		return new HipplenAgendaResultScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HipplenAgendaResultScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HipplenAgendaResultScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gridFightTraitInfo_.Equals(other.gridFightTraitInfo_))
		{
			return false;
		}
		if (!object.Equals(JPFBGFIHDDH, other.JPFBGFIHDDH))
		{
			return false;
		}
		if (AEPDGDLMPMD != other.AEPDGDLMPMD)
		{
			return false;
		}
		if (!fCCEHOLHFOC_.Equals(other.fCCEHOLHFOC_))
		{
			return false;
		}
		if (!object.Equals(KBNLIPOGOLE, other.KBNLIPOGOLE))
		{
			return false;
		}
		if (!cLKAILDCPJC_.Equals(other.cLKAILDCPJC_))
		{
			return false;
		}
		if (!object.Equals(ACJHGLGHEAH, other.ACJHGLGHEAH))
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
		num ^= gridFightTraitInfo_.GetHashCode();
		if (jPFBGFIHDDH_ != null)
		{
			num ^= JPFBGFIHDDH.GetHashCode();
		}
		if (AEPDGDLMPMD)
		{
			num ^= AEPDGDLMPMD.GetHashCode();
		}
		num ^= fCCEHOLHFOC_.GetHashCode();
		if (kBNLIPOGOLE_ != null)
		{
			num ^= KBNLIPOGOLE.GetHashCode();
		}
		num ^= cLKAILDCPJC_.GetHashCode();
		if (aCJHGLGHEAH_ != null)
		{
			num ^= ACJHGLGHEAH.GetHashCode();
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
		gridFightTraitInfo_.WriteTo(ref output, _repeated_gridFightTraitInfo_codec);
		if (jPFBGFIHDDH_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(JPFBGFIHDDH);
		}
		if (AEPDGDLMPMD)
		{
			output.WriteRawTag(64);
			output.WriteBool(AEPDGDLMPMD);
		}
		fCCEHOLHFOC_.WriteTo(ref output, _repeated_fCCEHOLHFOC_codec);
		if (kBNLIPOGOLE_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(KBNLIPOGOLE);
		}
		cLKAILDCPJC_.WriteTo(ref output, _repeated_cLKAILDCPJC_codec);
		if (aCJHGLGHEAH_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(ACJHGLGHEAH);
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
		num += gridFightTraitInfo_.CalculateSize(_repeated_gridFightTraitInfo_codec);
		if (jPFBGFIHDDH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JPFBGFIHDDH);
		}
		if (AEPDGDLMPMD)
		{
			num += 2;
		}
		num += fCCEHOLHFOC_.CalculateSize(_repeated_fCCEHOLHFOC_codec);
		if (kBNLIPOGOLE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KBNLIPOGOLE);
		}
		num += cLKAILDCPJC_.CalculateSize(_repeated_cLKAILDCPJC_codec);
		if (aCJHGLGHEAH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ACJHGLGHEAH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HipplenAgendaResultScNotify other)
	{
		if (other == null)
		{
			return;
		}
		gridFightTraitInfo_.Add(other.gridFightTraitInfo_);
		if (other.jPFBGFIHDDH_ != null)
		{
			if (jPFBGFIHDDH_ == null)
			{
				JPFBGFIHDDH = new DGKNDMAHMAP();
			}
			JPFBGFIHDDH.MergeFrom(other.JPFBGFIHDDH);
		}
		if (other.AEPDGDLMPMD)
		{
			AEPDGDLMPMD = other.AEPDGDLMPMD;
		}
		fCCEHOLHFOC_.Add(other.fCCEHOLHFOC_);
		if (other.kBNLIPOGOLE_ != null)
		{
			if (kBNLIPOGOLE_ == null)
			{
				KBNLIPOGOLE = new EOKOFFPBJME();
			}
			KBNLIPOGOLE.MergeFrom(other.KBNLIPOGOLE);
		}
		cLKAILDCPJC_.Add(other.cLKAILDCPJC_);
		if (other.aCJHGLGHEAH_ != null)
		{
			if (aCJHGLGHEAH_ == null)
			{
				ACJHGLGHEAH = new OOLHNFNKOHN();
			}
			ACJHGLGHEAH.MergeFrom(other.ACJHGLGHEAH);
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
			case 8u:
			case 10u:
				gridFightTraitInfo_.AddEntriesFrom(ref input, _repeated_gridFightTraitInfo_codec);
				break;
			case 26u:
				if (jPFBGFIHDDH_ == null)
				{
					JPFBGFIHDDH = new DGKNDMAHMAP();
				}
				input.ReadMessage(JPFBGFIHDDH);
				break;
			case 64u:
				AEPDGDLMPMD = input.ReadBool();
				break;
			case 72u:
			case 74u:
				fCCEHOLHFOC_.AddEntriesFrom(ref input, _repeated_fCCEHOLHFOC_codec);
				break;
			case 82u:
				if (kBNLIPOGOLE_ == null)
				{
					KBNLIPOGOLE = new EOKOFFPBJME();
				}
				input.ReadMessage(KBNLIPOGOLE);
				break;
			case 98u:
				cLKAILDCPJC_.AddEntriesFrom(ref input, _repeated_cLKAILDCPJC_codec);
				break;
			case 114u:
				if (aCJHGLGHEAH_ == null)
				{
					ACJHGLGHEAH = new OOLHNFNKOHN();
				}
				input.ReadMessage(ACJHGLGHEAH);
				break;
			}
		}
	}
}

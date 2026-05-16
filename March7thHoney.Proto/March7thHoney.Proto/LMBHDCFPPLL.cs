using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LMBHDCFPPLL : IMessage<LMBHDCFPPLL>, IMessage, IEquatable<LMBHDCFPPLL>, IDeepCloneable<LMBHDCFPPLL>, IBufferMessage
{
	private static readonly MessageParser<LMBHDCFPPLL> _parser = new MessageParser<LMBHDCFPPLL>(() => new LMBHDCFPPLL());

	private UnknownFieldSet _unknownFields;

	public const int ECNPHJBCLBDFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_eCNPHJBCLBD_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> eCNPHJBCLBD_ = new RepeatedField<uint>();

	public const int JJBEJEFDJHOFieldNumber = 2;

	private KABLGALHMHN jJBEJEFDJHO_;

	public const int IMBOKGFIACAFieldNumber = 4;

	private uint iMBOKGFIACA_;

	public const int ENHEIBHHAIDFieldNumber = 6;

	private JHFIFNOEMDJ eNHEIBHHAID_;

	public const int PendingActionFieldNumber = 7;

	private PIAJHGDIGFF pendingAction_;

	public const int IBCIBNHJDFEFieldNumber = 9;

	private CJPFNAFLAPD iBCIBNHJDFE_;

	public const int PKCHIMBEBPEFieldNumber = 10;

	private PPIHPDIPLLD pKCHIMBEBPE_;

	public const int SkillInfoFieldNumber = 14;

	private DLGLHKKIJJK skillInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LMBHDCFPPLL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LMBHDCFPPLLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> ECNPHJBCLBD => eCNPHJBCLBD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KABLGALHMHN JJBEJEFDJHO
	{
		get
		{
			return jJBEJEFDJHO_;
		}
		set
		{
			jJBEJEFDJHO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IMBOKGFIACA
	{
		get
		{
			return iMBOKGFIACA_;
		}
		set
		{
			iMBOKGFIACA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JHFIFNOEMDJ ENHEIBHHAID
	{
		get
		{
			return eNHEIBHHAID_;
		}
		set
		{
			eNHEIBHHAID_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PIAJHGDIGFF PendingAction
	{
		get
		{
			return pendingAction_;
		}
		set
		{
			pendingAction_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CJPFNAFLAPD IBCIBNHJDFE
	{
		get
		{
			return iBCIBNHJDFE_;
		}
		set
		{
			iBCIBNHJDFE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PPIHPDIPLLD PKCHIMBEBPE
	{
		get
		{
			return pKCHIMBEBPE_;
		}
		set
		{
			pKCHIMBEBPE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLGLHKKIJJK SkillInfo
	{
		get
		{
			return skillInfo_;
		}
		set
		{
			skillInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LMBHDCFPPLL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LMBHDCFPPLL(LMBHDCFPPLL other)
		: this()
	{
		eCNPHJBCLBD_ = other.eCNPHJBCLBD_.Clone();
		jJBEJEFDJHO_ = ((other.jJBEJEFDJHO_ != null) ? other.jJBEJEFDJHO_.Clone() : null);
		iMBOKGFIACA_ = other.iMBOKGFIACA_;
		eNHEIBHHAID_ = ((other.eNHEIBHHAID_ != null) ? other.eNHEIBHHAID_.Clone() : null);
		pendingAction_ = ((other.pendingAction_ != null) ? other.pendingAction_.Clone() : null);
		iBCIBNHJDFE_ = ((other.iBCIBNHJDFE_ != null) ? other.iBCIBNHJDFE_.Clone() : null);
		pKCHIMBEBPE_ = ((other.pKCHIMBEBPE_ != null) ? other.pKCHIMBEBPE_.Clone() : null);
		skillInfo_ = ((other.skillInfo_ != null) ? other.skillInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LMBHDCFPPLL Clone()
	{
		return new LMBHDCFPPLL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LMBHDCFPPLL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LMBHDCFPPLL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!eCNPHJBCLBD_.Equals(other.eCNPHJBCLBD_))
		{
			return false;
		}
		if (!object.Equals(JJBEJEFDJHO, other.JJBEJEFDJHO))
		{
			return false;
		}
		if (IMBOKGFIACA != other.IMBOKGFIACA)
		{
			return false;
		}
		if (!object.Equals(ENHEIBHHAID, other.ENHEIBHHAID))
		{
			return false;
		}
		if (!object.Equals(PendingAction, other.PendingAction))
		{
			return false;
		}
		if (!object.Equals(IBCIBNHJDFE, other.IBCIBNHJDFE))
		{
			return false;
		}
		if (!object.Equals(PKCHIMBEBPE, other.PKCHIMBEBPE))
		{
			return false;
		}
		if (!object.Equals(SkillInfo, other.SkillInfo))
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
		num ^= eCNPHJBCLBD_.GetHashCode();
		if (jJBEJEFDJHO_ != null)
		{
			num ^= JJBEJEFDJHO.GetHashCode();
		}
		if (IMBOKGFIACA != 0)
		{
			num ^= IMBOKGFIACA.GetHashCode();
		}
		if (eNHEIBHHAID_ != null)
		{
			num ^= ENHEIBHHAID.GetHashCode();
		}
		if (pendingAction_ != null)
		{
			num ^= PendingAction.GetHashCode();
		}
		if (iBCIBNHJDFE_ != null)
		{
			num ^= IBCIBNHJDFE.GetHashCode();
		}
		if (pKCHIMBEBPE_ != null)
		{
			num ^= PKCHIMBEBPE.GetHashCode();
		}
		if (skillInfo_ != null)
		{
			num ^= SkillInfo.GetHashCode();
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
		eCNPHJBCLBD_.WriteTo(ref output, _repeated_eCNPHJBCLBD_codec);
		if (jJBEJEFDJHO_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(JJBEJEFDJHO);
		}
		if (IMBOKGFIACA != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(IMBOKGFIACA);
		}
		if (eNHEIBHHAID_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(ENHEIBHHAID);
		}
		if (pendingAction_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(PendingAction);
		}
		if (iBCIBNHJDFE_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(IBCIBNHJDFE);
		}
		if (pKCHIMBEBPE_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(PKCHIMBEBPE);
		}
		if (skillInfo_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(SkillInfo);
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
		num += eCNPHJBCLBD_.CalculateSize(_repeated_eCNPHJBCLBD_codec);
		if (jJBEJEFDJHO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JJBEJEFDJHO);
		}
		if (IMBOKGFIACA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IMBOKGFIACA);
		}
		if (eNHEIBHHAID_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ENHEIBHHAID);
		}
		if (pendingAction_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PendingAction);
		}
		if (iBCIBNHJDFE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IBCIBNHJDFE);
		}
		if (pKCHIMBEBPE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PKCHIMBEBPE);
		}
		if (skillInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SkillInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LMBHDCFPPLL other)
	{
		if (other == null)
		{
			return;
		}
		eCNPHJBCLBD_.Add(other.eCNPHJBCLBD_);
		if (other.jJBEJEFDJHO_ != null)
		{
			if (jJBEJEFDJHO_ == null)
			{
				JJBEJEFDJHO = new KABLGALHMHN();
			}
			JJBEJEFDJHO.MergeFrom(other.JJBEJEFDJHO);
		}
		if (other.IMBOKGFIACA != 0)
		{
			IMBOKGFIACA = other.IMBOKGFIACA;
		}
		if (other.eNHEIBHHAID_ != null)
		{
			if (eNHEIBHHAID_ == null)
			{
				ENHEIBHHAID = new JHFIFNOEMDJ();
			}
			ENHEIBHHAID.MergeFrom(other.ENHEIBHHAID);
		}
		if (other.pendingAction_ != null)
		{
			if (pendingAction_ == null)
			{
				PendingAction = new PIAJHGDIGFF();
			}
			PendingAction.MergeFrom(other.PendingAction);
		}
		if (other.iBCIBNHJDFE_ != null)
		{
			if (iBCIBNHJDFE_ == null)
			{
				IBCIBNHJDFE = new CJPFNAFLAPD();
			}
			IBCIBNHJDFE.MergeFrom(other.IBCIBNHJDFE);
		}
		if (other.pKCHIMBEBPE_ != null)
		{
			if (pKCHIMBEBPE_ == null)
			{
				PKCHIMBEBPE = new PPIHPDIPLLD();
			}
			PKCHIMBEBPE.MergeFrom(other.PKCHIMBEBPE);
		}
		if (other.skillInfo_ != null)
		{
			if (skillInfo_ == null)
			{
				SkillInfo = new DLGLHKKIJJK();
			}
			SkillInfo.MergeFrom(other.SkillInfo);
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
				eCNPHJBCLBD_.AddEntriesFrom(ref input, _repeated_eCNPHJBCLBD_codec);
				break;
			case 18u:
				if (jJBEJEFDJHO_ == null)
				{
					JJBEJEFDJHO = new KABLGALHMHN();
				}
				input.ReadMessage(JJBEJEFDJHO);
				break;
			case 32u:
				IMBOKGFIACA = input.ReadUInt32();
				break;
			case 50u:
				if (eNHEIBHHAID_ == null)
				{
					ENHEIBHHAID = new JHFIFNOEMDJ();
				}
				input.ReadMessage(ENHEIBHHAID);
				break;
			case 58u:
				if (pendingAction_ == null)
				{
					PendingAction = new PIAJHGDIGFF();
				}
				input.ReadMessage(PendingAction);
				break;
			case 74u:
				if (iBCIBNHJDFE_ == null)
				{
					IBCIBNHJDFE = new CJPFNAFLAPD();
				}
				input.ReadMessage(IBCIBNHJDFE);
				break;
			case 82u:
				if (pKCHIMBEBPE_ == null)
				{
					PKCHIMBEBPE = new PPIHPDIPLLD();
				}
				input.ReadMessage(PKCHIMBEBPE);
				break;
			case 114u:
				if (skillInfo_ == null)
				{
					SkillInfo = new DLGLHKKIJJK();
				}
				input.ReadMessage(SkillInfo);
				break;
			}
		}
	}
}

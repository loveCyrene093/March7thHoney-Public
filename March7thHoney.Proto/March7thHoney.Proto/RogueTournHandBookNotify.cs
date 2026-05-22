using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournHandBookNotify : IMessage<RogueTournHandBookNotify>, IMessage, IEquatable<RogueTournHandBookNotify>, IDeepCloneable<RogueTournHandBookNotify>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		BBFOLFIINCM = 2,
		PJHGGHAPKCK = 4,
		HMLPFKAPFJB = 7,
		BAAANBEIPBG = 8,
		ABIJBGENKHA = 9,
		GLNJOAHBBKK = 13
	}

	private static readonly MessageParser<RogueTournHandBookNotify> _parser = new MessageParser<RogueTournHandBookNotify>(() => new RogueTournHandBookNotify());

	private UnknownFieldSet _unknownFields;

	public const int BBFOLFIINCMFieldNumber = 2;

	public const int PJHGGHAPKCKFieldNumber = 4;

	public const int HMLPFKAPFJBFieldNumber = 7;

	public const int BAAANBEIPBGFieldNumber = 8;

	public const int ABIJBGENKHAFieldNumber = 9;

	public const int GLNJOAHBBKKFieldNumber = 13;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournHandBookNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournHandBookNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ALABNDBMKBI BBFOLFIINCM
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.BBFOLFIINCM)
			{
				return null;
			}
			return (ALABNDBMKBI)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.BBFOLFIINCM : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGCPHIPOBJF PJHGGHAPKCK
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.PJHGGHAPKCK)
			{
				return null;
			}
			return (CGCPHIPOBJF)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.PJHGGHAPKCK : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EHNENCJAJPC HMLPFKAPFJB
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.HMLPFKAPFJB)
			{
				return null;
			}
			return (EHNENCJAJPC)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.HMLPFKAPFJB : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LCALDPAIJDO BAAANBEIPBG
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.BAAANBEIPBG)
			{
				return null;
			}
			return (LCALDPAIJDO)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.BAAANBEIPBG : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IAJOKPOPGCJ ABIJBGENKHA
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.ABIJBGENKHA)
			{
				return null;
			}
			return (IAJOKPOPGCJ)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.ABIJBGENKHA : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGOAODDFPBP GLNJOAHBBKK
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.GLNJOAHBBKK)
			{
				return null;
			}
			return (KGOAODDFPBP)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.GLNJOAHBBKK : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournHandBookNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournHandBookNotify(RogueTournHandBookNotify other)
		: this()
	{
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.BBFOLFIINCM:
			BBFOLFIINCM = other.BBFOLFIINCM.Clone();
			break;
		case BPIHFAJCLOCOneofCase.PJHGGHAPKCK:
			PJHGGHAPKCK = other.PJHGGHAPKCK.Clone();
			break;
		case BPIHFAJCLOCOneofCase.HMLPFKAPFJB:
			HMLPFKAPFJB = other.HMLPFKAPFJB.Clone();
			break;
		case BPIHFAJCLOCOneofCase.BAAANBEIPBG:
			BAAANBEIPBG = other.BAAANBEIPBG.Clone();
			break;
		case BPIHFAJCLOCOneofCase.ABIJBGENKHA:
			ABIJBGENKHA = other.ABIJBGENKHA.Clone();
			break;
		case BPIHFAJCLOCOneofCase.GLNJOAHBBKK:
			GLNJOAHBBKK = other.GLNJOAHBBKK.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournHandBookNotify Clone()
	{
		return new RogueTournHandBookNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBPIHFAJCLOC()
	{
		bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.None;
		bPIHFAJCLOC_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournHandBookNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournHandBookNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BBFOLFIINCM, other.BBFOLFIINCM))
		{
			return false;
		}
		if (!object.Equals(PJHGGHAPKCK, other.PJHGGHAPKCK))
		{
			return false;
		}
		if (!object.Equals(HMLPFKAPFJB, other.HMLPFKAPFJB))
		{
			return false;
		}
		if (!object.Equals(BAAANBEIPBG, other.BAAANBEIPBG))
		{
			return false;
		}
		if (!object.Equals(ABIJBGENKHA, other.ABIJBGENKHA))
		{
			return false;
		}
		if (!object.Equals(GLNJOAHBBKK, other.GLNJOAHBBKK))
		{
			return false;
		}
		if (BPIHFAJCLOCCase != other.BPIHFAJCLOCCase)
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BBFOLFIINCM)
		{
			num ^= BBFOLFIINCM.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PJHGGHAPKCK)
		{
			num ^= PJHGGHAPKCK.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HMLPFKAPFJB)
		{
			num ^= HMLPFKAPFJB.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BAAANBEIPBG)
		{
			num ^= BAAANBEIPBG.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ABIJBGENKHA)
		{
			num ^= ABIJBGENKHA.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GLNJOAHBBKK)
		{
			num ^= GLNJOAHBBKK.GetHashCode();
		}
		num ^= (int)bPIHFAJCLOCCase_;
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BBFOLFIINCM)
		{
			output.WriteRawTag(18);
			output.WriteMessage(BBFOLFIINCM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PJHGGHAPKCK)
		{
			output.WriteRawTag(34);
			output.WriteMessage(PJHGGHAPKCK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HMLPFKAPFJB)
		{
			output.WriteRawTag(58);
			output.WriteMessage(HMLPFKAPFJB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BAAANBEIPBG)
		{
			output.WriteRawTag(66);
			output.WriteMessage(BAAANBEIPBG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ABIJBGENKHA)
		{
			output.WriteRawTag(74);
			output.WriteMessage(ABIJBGENKHA);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GLNJOAHBBKK)
		{
			output.WriteRawTag(106);
			output.WriteMessage(GLNJOAHBBKK);
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BBFOLFIINCM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BBFOLFIINCM);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PJHGGHAPKCK)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PJHGGHAPKCK);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HMLPFKAPFJB)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HMLPFKAPFJB);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BAAANBEIPBG)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BAAANBEIPBG);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ABIJBGENKHA)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ABIJBGENKHA);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GLNJOAHBBKK)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GLNJOAHBBKK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournHandBookNotify other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.BBFOLFIINCM:
			if (BBFOLFIINCM == null)
			{
				BBFOLFIINCM = new ALABNDBMKBI();
			}
			BBFOLFIINCM.MergeFrom(other.BBFOLFIINCM);
			break;
		case BPIHFAJCLOCOneofCase.PJHGGHAPKCK:
			if (PJHGGHAPKCK == null)
			{
				PJHGGHAPKCK = new CGCPHIPOBJF();
			}
			PJHGGHAPKCK.MergeFrom(other.PJHGGHAPKCK);
			break;
		case BPIHFAJCLOCOneofCase.HMLPFKAPFJB:
			if (HMLPFKAPFJB == null)
			{
				HMLPFKAPFJB = new EHNENCJAJPC();
			}
			HMLPFKAPFJB.MergeFrom(other.HMLPFKAPFJB);
			break;
		case BPIHFAJCLOCOneofCase.BAAANBEIPBG:
			if (BAAANBEIPBG == null)
			{
				BAAANBEIPBG = new LCALDPAIJDO();
			}
			BAAANBEIPBG.MergeFrom(other.BAAANBEIPBG);
			break;
		case BPIHFAJCLOCOneofCase.ABIJBGENKHA:
			if (ABIJBGENKHA == null)
			{
				ABIJBGENKHA = new IAJOKPOPGCJ();
			}
			ABIJBGENKHA.MergeFrom(other.ABIJBGENKHA);
			break;
		case BPIHFAJCLOCOneofCase.GLNJOAHBBKK:
			if (GLNJOAHBBKK == null)
			{
				GLNJOAHBBKK = new KGOAODDFPBP();
			}
			GLNJOAHBBKK.MergeFrom(other.GLNJOAHBBKK);
			break;
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
			case 18u:
			{
				ALABNDBMKBI aLABNDBMKBI = new ALABNDBMKBI();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BBFOLFIINCM)
				{
					aLABNDBMKBI.MergeFrom(BBFOLFIINCM);
				}
				input.ReadMessage(aLABNDBMKBI);
				BBFOLFIINCM = aLABNDBMKBI;
				break;
			}
			case 34u:
			{
				CGCPHIPOBJF cGCPHIPOBJF = new CGCPHIPOBJF();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PJHGGHAPKCK)
				{
					cGCPHIPOBJF.MergeFrom(PJHGGHAPKCK);
				}
				input.ReadMessage(cGCPHIPOBJF);
				PJHGGHAPKCK = cGCPHIPOBJF;
				break;
			}
			case 58u:
			{
				EHNENCJAJPC eHNENCJAJPC = new EHNENCJAJPC();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HMLPFKAPFJB)
				{
					eHNENCJAJPC.MergeFrom(HMLPFKAPFJB);
				}
				input.ReadMessage(eHNENCJAJPC);
				HMLPFKAPFJB = eHNENCJAJPC;
				break;
			}
			case 66u:
			{
				LCALDPAIJDO lCALDPAIJDO = new LCALDPAIJDO();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.BAAANBEIPBG)
				{
					lCALDPAIJDO.MergeFrom(BAAANBEIPBG);
				}
				input.ReadMessage(lCALDPAIJDO);
				BAAANBEIPBG = lCALDPAIJDO;
				break;
			}
			case 74u:
			{
				IAJOKPOPGCJ iAJOKPOPGCJ = new IAJOKPOPGCJ();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.ABIJBGENKHA)
				{
					iAJOKPOPGCJ.MergeFrom(ABIJBGENKHA);
				}
				input.ReadMessage(iAJOKPOPGCJ);
				ABIJBGENKHA = iAJOKPOPGCJ;
				break;
			}
			case 106u:
			{
				KGOAODDFPBP kGOAODDFPBP = new KGOAODDFPBP();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GLNJOAHBBKK)
				{
					kGOAODDFPBP.MergeFrom(GLNJOAHBBKK);
				}
				input.ReadMessage(kGOAODDFPBP);
				GLNJOAHBBKK = kGOAODDFPBP;
				break;
			}
			}
		}
	}
}

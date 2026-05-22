using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BLIJEKKOIJH : IMessage<BLIJEKKOIJH>, IMessage, IEquatable<BLIJEKKOIJH>, IDeepCloneable<BLIJEKKOIJH>, IBufferMessage
{
	public enum EGKEAPEHOEIOneofCase
	{
		None = 0,
		OMEFKECBCNA = 1,
		DKCKDCLCPEL = 2,
		ABIJHKNBGHJ = 5,
		EJIFPEEGIBK = 7,
		ShopSyncInfo = 11,
		HJGODNJBEHN = 12,
		FIGGALLELNM = 13,
		HCHIFBCIPPC = 14,
		BMKAEFAKNFJ = 15
	}

	private static readonly MessageParser<BLIJEKKOIJH> _parser = new MessageParser<BLIJEKKOIJH>(() => new BLIJEKKOIJH());

	private UnknownFieldSet _unknownFields;

	public const int COEBHKFJJGOFieldNumber = 6;

	private uint cOEBHKFJJGO_;

	public const int OMEFKECBCNAFieldNumber = 1;

	public const int DKCKDCLCPELFieldNumber = 2;

	public const int ABIJHKNBGHJFieldNumber = 5;

	public const int EJIFPEEGIBKFieldNumber = 7;

	public const int ShopSyncInfoFieldNumber = 11;

	public const int HJGODNJBEHNFieldNumber = 12;

	public const int FIGGALLELNMFieldNumber = 13;

	public const int HCHIFBCIPPCFieldNumber = 14;

	public const int BMKAEFAKNFJFieldNumber = 15;

	private object eGKEAPEHOEI_;

	private EGKEAPEHOEIOneofCase eGKEAPEHOEICase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BLIJEKKOIJH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BLIJEKKOIJHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint COEBHKFJJGO
	{
		get
		{
			return cOEBHKFJJGO_;
		}
		set
		{
			cOEBHKFJJGO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EACGOHFOCJC OMEFKECBCNA
	{
		get
		{
			if (eGKEAPEHOEICase_ != EGKEAPEHOEIOneofCase.OMEFKECBCNA)
			{
				return null;
			}
			return (EACGOHFOCJC)eGKEAPEHOEI_;
		}
		set
		{
			eGKEAPEHOEI_ = value;
			eGKEAPEHOEICase_ = ((value != null) ? EGKEAPEHOEIOneofCase.OMEFKECBCNA : EGKEAPEHOEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LFNDHPMOFLH DKCKDCLCPEL
	{
		get
		{
			if (eGKEAPEHOEICase_ != EGKEAPEHOEIOneofCase.DKCKDCLCPEL)
			{
				return null;
			}
			return (LFNDHPMOFLH)eGKEAPEHOEI_;
		}
		set
		{
			eGKEAPEHOEI_ = value;
			eGKEAPEHOEICase_ = ((value != null) ? EGKEAPEHOEIOneofCase.DKCKDCLCPEL : EGKEAPEHOEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PFCKOAKLANF ABIJHKNBGHJ
	{
		get
		{
			if (eGKEAPEHOEICase_ != EGKEAPEHOEIOneofCase.ABIJHKNBGHJ)
			{
				return null;
			}
			return (PFCKOAKLANF)eGKEAPEHOEI_;
		}
		set
		{
			eGKEAPEHOEI_ = value;
			eGKEAPEHOEICase_ = ((value != null) ? EGKEAPEHOEIOneofCase.ABIJHKNBGHJ : EGKEAPEHOEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMKDMDNCNKC EJIFPEEGIBK
	{
		get
		{
			if (eGKEAPEHOEICase_ != EGKEAPEHOEIOneofCase.EJIFPEEGIBK)
			{
				return null;
			}
			return (JMKDMDNCNKC)eGKEAPEHOEI_;
		}
		set
		{
			eGKEAPEHOEI_ = value;
			eGKEAPEHOEICase_ = ((value != null) ? EGKEAPEHOEIOneofCase.EJIFPEEGIBK : EGKEAPEHOEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KLKJIBBIBIM ShopSyncInfo
	{
		get
		{
			if (eGKEAPEHOEICase_ != EGKEAPEHOEIOneofCase.ShopSyncInfo)
			{
				return null;
			}
			return (KLKJIBBIBIM)eGKEAPEHOEI_;
		}
		set
		{
			eGKEAPEHOEI_ = value;
			eGKEAPEHOEICase_ = ((value != null) ? EGKEAPEHOEIOneofCase.ShopSyncInfo : EGKEAPEHOEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KIEGBDIBDCE HJGODNJBEHN
	{
		get
		{
			if (eGKEAPEHOEICase_ != EGKEAPEHOEIOneofCase.HJGODNJBEHN)
			{
				return null;
			}
			return (KIEGBDIBDCE)eGKEAPEHOEI_;
		}
		set
		{
			eGKEAPEHOEI_ = value;
			eGKEAPEHOEICase_ = ((value != null) ? EGKEAPEHOEIOneofCase.HJGODNJBEHN : EGKEAPEHOEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DODFLOBPGGL FIGGALLELNM
	{
		get
		{
			if (eGKEAPEHOEICase_ != EGKEAPEHOEIOneofCase.FIGGALLELNM)
			{
				return null;
			}
			return (DODFLOBPGGL)eGKEAPEHOEI_;
		}
		set
		{
			eGKEAPEHOEI_ = value;
			eGKEAPEHOEICase_ = ((value != null) ? EGKEAPEHOEIOneofCase.FIGGALLELNM : EGKEAPEHOEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EEGKAEAIPMC HCHIFBCIPPC
	{
		get
		{
			if (eGKEAPEHOEICase_ != EGKEAPEHOEIOneofCase.HCHIFBCIPPC)
			{
				return null;
			}
			return (EEGKAEAIPMC)eGKEAPEHOEI_;
		}
		set
		{
			eGKEAPEHOEI_ = value;
			eGKEAPEHOEICase_ = ((value != null) ? EGKEAPEHOEIOneofCase.HCHIFBCIPPC : EGKEAPEHOEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNMHGGHGPBE BMKAEFAKNFJ
	{
		get
		{
			if (eGKEAPEHOEICase_ != EGKEAPEHOEIOneofCase.BMKAEFAKNFJ)
			{
				return null;
			}
			return (CNMHGGHGPBE)eGKEAPEHOEI_;
		}
		set
		{
			eGKEAPEHOEI_ = value;
			eGKEAPEHOEICase_ = ((value != null) ? EGKEAPEHOEIOneofCase.BMKAEFAKNFJ : EGKEAPEHOEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EGKEAPEHOEIOneofCase EGKEAPEHOEICase => eGKEAPEHOEICase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BLIJEKKOIJH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BLIJEKKOIJH(BLIJEKKOIJH other)
		: this()
	{
		cOEBHKFJJGO_ = other.cOEBHKFJJGO_;
		switch (other.EGKEAPEHOEICase)
		{
		case EGKEAPEHOEIOneofCase.OMEFKECBCNA:
			OMEFKECBCNA = other.OMEFKECBCNA.Clone();
			break;
		case EGKEAPEHOEIOneofCase.DKCKDCLCPEL:
			DKCKDCLCPEL = other.DKCKDCLCPEL.Clone();
			break;
		case EGKEAPEHOEIOneofCase.ABIJHKNBGHJ:
			ABIJHKNBGHJ = other.ABIJHKNBGHJ.Clone();
			break;
		case EGKEAPEHOEIOneofCase.EJIFPEEGIBK:
			EJIFPEEGIBK = other.EJIFPEEGIBK.Clone();
			break;
		case EGKEAPEHOEIOneofCase.ShopSyncInfo:
			ShopSyncInfo = other.ShopSyncInfo.Clone();
			break;
		case EGKEAPEHOEIOneofCase.HJGODNJBEHN:
			HJGODNJBEHN = other.HJGODNJBEHN.Clone();
			break;
		case EGKEAPEHOEIOneofCase.FIGGALLELNM:
			FIGGALLELNM = other.FIGGALLELNM.Clone();
			break;
		case EGKEAPEHOEIOneofCase.HCHIFBCIPPC:
			HCHIFBCIPPC = other.HCHIFBCIPPC.Clone();
			break;
		case EGKEAPEHOEIOneofCase.BMKAEFAKNFJ:
			BMKAEFAKNFJ = other.BMKAEFAKNFJ.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BLIJEKKOIJH Clone()
	{
		return new BLIJEKKOIJH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearEGKEAPEHOEI()
	{
		eGKEAPEHOEICase_ = EGKEAPEHOEIOneofCase.None;
		eGKEAPEHOEI_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BLIJEKKOIJH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BLIJEKKOIJH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (COEBHKFJJGO != other.COEBHKFJJGO)
		{
			return false;
		}
		if (!object.Equals(OMEFKECBCNA, other.OMEFKECBCNA))
		{
			return false;
		}
		if (!object.Equals(DKCKDCLCPEL, other.DKCKDCLCPEL))
		{
			return false;
		}
		if (!object.Equals(ABIJHKNBGHJ, other.ABIJHKNBGHJ))
		{
			return false;
		}
		if (!object.Equals(EJIFPEEGIBK, other.EJIFPEEGIBK))
		{
			return false;
		}
		if (!object.Equals(ShopSyncInfo, other.ShopSyncInfo))
		{
			return false;
		}
		if (!object.Equals(HJGODNJBEHN, other.HJGODNJBEHN))
		{
			return false;
		}
		if (!object.Equals(FIGGALLELNM, other.FIGGALLELNM))
		{
			return false;
		}
		if (!object.Equals(HCHIFBCIPPC, other.HCHIFBCIPPC))
		{
			return false;
		}
		if (!object.Equals(BMKAEFAKNFJ, other.BMKAEFAKNFJ))
		{
			return false;
		}
		if (EGKEAPEHOEICase != other.EGKEAPEHOEICase)
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
		if (COEBHKFJJGO != 0)
		{
			num ^= COEBHKFJJGO.GetHashCode();
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.OMEFKECBCNA)
		{
			num ^= OMEFKECBCNA.GetHashCode();
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.DKCKDCLCPEL)
		{
			num ^= DKCKDCLCPEL.GetHashCode();
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.ABIJHKNBGHJ)
		{
			num ^= ABIJHKNBGHJ.GetHashCode();
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.EJIFPEEGIBK)
		{
			num ^= EJIFPEEGIBK.GetHashCode();
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.ShopSyncInfo)
		{
			num ^= ShopSyncInfo.GetHashCode();
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.HJGODNJBEHN)
		{
			num ^= HJGODNJBEHN.GetHashCode();
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.FIGGALLELNM)
		{
			num ^= FIGGALLELNM.GetHashCode();
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.HCHIFBCIPPC)
		{
			num ^= HCHIFBCIPPC.GetHashCode();
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.BMKAEFAKNFJ)
		{
			num ^= BMKAEFAKNFJ.GetHashCode();
		}
		num ^= (int)eGKEAPEHOEICase_;
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
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.OMEFKECBCNA)
		{
			output.WriteRawTag(10);
			output.WriteMessage(OMEFKECBCNA);
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.DKCKDCLCPEL)
		{
			output.WriteRawTag(18);
			output.WriteMessage(DKCKDCLCPEL);
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.ABIJHKNBGHJ)
		{
			output.WriteRawTag(42);
			output.WriteMessage(ABIJHKNBGHJ);
		}
		if (COEBHKFJJGO != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(COEBHKFJJGO);
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.EJIFPEEGIBK)
		{
			output.WriteRawTag(58);
			output.WriteMessage(EJIFPEEGIBK);
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.ShopSyncInfo)
		{
			output.WriteRawTag(90);
			output.WriteMessage(ShopSyncInfo);
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.HJGODNJBEHN)
		{
			output.WriteRawTag(98);
			output.WriteMessage(HJGODNJBEHN);
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.FIGGALLELNM)
		{
			output.WriteRawTag(106);
			output.WriteMessage(FIGGALLELNM);
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.HCHIFBCIPPC)
		{
			output.WriteRawTag(114);
			output.WriteMessage(HCHIFBCIPPC);
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.BMKAEFAKNFJ)
		{
			output.WriteRawTag(122);
			output.WriteMessage(BMKAEFAKNFJ);
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
		if (COEBHKFJJGO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(COEBHKFJJGO);
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.OMEFKECBCNA)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OMEFKECBCNA);
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.DKCKDCLCPEL)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DKCKDCLCPEL);
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.ABIJHKNBGHJ)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ABIJHKNBGHJ);
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.EJIFPEEGIBK)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EJIFPEEGIBK);
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.ShopSyncInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ShopSyncInfo);
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.HJGODNJBEHN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HJGODNJBEHN);
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.FIGGALLELNM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FIGGALLELNM);
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.HCHIFBCIPPC)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HCHIFBCIPPC);
		}
		if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.BMKAEFAKNFJ)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BMKAEFAKNFJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BLIJEKKOIJH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.COEBHKFJJGO != 0)
		{
			COEBHKFJJGO = other.COEBHKFJJGO;
		}
		switch (other.EGKEAPEHOEICase)
		{
		case EGKEAPEHOEIOneofCase.OMEFKECBCNA:
			if (OMEFKECBCNA == null)
			{
				OMEFKECBCNA = new EACGOHFOCJC();
			}
			OMEFKECBCNA.MergeFrom(other.OMEFKECBCNA);
			break;
		case EGKEAPEHOEIOneofCase.DKCKDCLCPEL:
			if (DKCKDCLCPEL == null)
			{
				DKCKDCLCPEL = new LFNDHPMOFLH();
			}
			DKCKDCLCPEL.MergeFrom(other.DKCKDCLCPEL);
			break;
		case EGKEAPEHOEIOneofCase.ABIJHKNBGHJ:
			if (ABIJHKNBGHJ == null)
			{
				ABIJHKNBGHJ = new PFCKOAKLANF();
			}
			ABIJHKNBGHJ.MergeFrom(other.ABIJHKNBGHJ);
			break;
		case EGKEAPEHOEIOneofCase.EJIFPEEGIBK:
			if (EJIFPEEGIBK == null)
			{
				EJIFPEEGIBK = new JMKDMDNCNKC();
			}
			EJIFPEEGIBK.MergeFrom(other.EJIFPEEGIBK);
			break;
		case EGKEAPEHOEIOneofCase.ShopSyncInfo:
			if (ShopSyncInfo == null)
			{
				ShopSyncInfo = new KLKJIBBIBIM();
			}
			ShopSyncInfo.MergeFrom(other.ShopSyncInfo);
			break;
		case EGKEAPEHOEIOneofCase.HJGODNJBEHN:
			if (HJGODNJBEHN == null)
			{
				HJGODNJBEHN = new KIEGBDIBDCE();
			}
			HJGODNJBEHN.MergeFrom(other.HJGODNJBEHN);
			break;
		case EGKEAPEHOEIOneofCase.FIGGALLELNM:
			if (FIGGALLELNM == null)
			{
				FIGGALLELNM = new DODFLOBPGGL();
			}
			FIGGALLELNM.MergeFrom(other.FIGGALLELNM);
			break;
		case EGKEAPEHOEIOneofCase.HCHIFBCIPPC:
			if (HCHIFBCIPPC == null)
			{
				HCHIFBCIPPC = new EEGKAEAIPMC();
			}
			HCHIFBCIPPC.MergeFrom(other.HCHIFBCIPPC);
			break;
		case EGKEAPEHOEIOneofCase.BMKAEFAKNFJ:
			if (BMKAEFAKNFJ == null)
			{
				BMKAEFAKNFJ = new CNMHGGHGPBE();
			}
			BMKAEFAKNFJ.MergeFrom(other.BMKAEFAKNFJ);
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
			case 10u:
			{
				EACGOHFOCJC eACGOHFOCJC = new EACGOHFOCJC();
				if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.OMEFKECBCNA)
				{
					eACGOHFOCJC.MergeFrom(OMEFKECBCNA);
				}
				input.ReadMessage(eACGOHFOCJC);
				OMEFKECBCNA = eACGOHFOCJC;
				break;
			}
			case 18u:
			{
				LFNDHPMOFLH lFNDHPMOFLH = new LFNDHPMOFLH();
				if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.DKCKDCLCPEL)
				{
					lFNDHPMOFLH.MergeFrom(DKCKDCLCPEL);
				}
				input.ReadMessage(lFNDHPMOFLH);
				DKCKDCLCPEL = lFNDHPMOFLH;
				break;
			}
			case 42u:
			{
				PFCKOAKLANF pFCKOAKLANF = new PFCKOAKLANF();
				if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.ABIJHKNBGHJ)
				{
					pFCKOAKLANF.MergeFrom(ABIJHKNBGHJ);
				}
				input.ReadMessage(pFCKOAKLANF);
				ABIJHKNBGHJ = pFCKOAKLANF;
				break;
			}
			case 48u:
				COEBHKFJJGO = input.ReadUInt32();
				break;
			case 58u:
			{
				JMKDMDNCNKC jMKDMDNCNKC = new JMKDMDNCNKC();
				if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.EJIFPEEGIBK)
				{
					jMKDMDNCNKC.MergeFrom(EJIFPEEGIBK);
				}
				input.ReadMessage(jMKDMDNCNKC);
				EJIFPEEGIBK = jMKDMDNCNKC;
				break;
			}
			case 90u:
			{
				KLKJIBBIBIM kLKJIBBIBIM = new KLKJIBBIBIM();
				if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.ShopSyncInfo)
				{
					kLKJIBBIBIM.MergeFrom(ShopSyncInfo);
				}
				input.ReadMessage(kLKJIBBIBIM);
				ShopSyncInfo = kLKJIBBIBIM;
				break;
			}
			case 98u:
			{
				KIEGBDIBDCE kIEGBDIBDCE = new KIEGBDIBDCE();
				if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.HJGODNJBEHN)
				{
					kIEGBDIBDCE.MergeFrom(HJGODNJBEHN);
				}
				input.ReadMessage(kIEGBDIBDCE);
				HJGODNJBEHN = kIEGBDIBDCE;
				break;
			}
			case 106u:
			{
				DODFLOBPGGL dODFLOBPGGL = new DODFLOBPGGL();
				if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.FIGGALLELNM)
				{
					dODFLOBPGGL.MergeFrom(FIGGALLELNM);
				}
				input.ReadMessage(dODFLOBPGGL);
				FIGGALLELNM = dODFLOBPGGL;
				break;
			}
			case 114u:
			{
				EEGKAEAIPMC eEGKAEAIPMC = new EEGKAEAIPMC();
				if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.HCHIFBCIPPC)
				{
					eEGKAEAIPMC.MergeFrom(HCHIFBCIPPC);
				}
				input.ReadMessage(eEGKAEAIPMC);
				HCHIFBCIPPC = eEGKAEAIPMC;
				break;
			}
			case 122u:
			{
				CNMHGGHGPBE cNMHGGHGPBE = new CNMHGGHGPBE();
				if (eGKEAPEHOEICase_ == EGKEAPEHOEIOneofCase.BMKAEFAKNFJ)
				{
					cNMHGGHGPBE.MergeFrom(BMKAEFAKNFJ);
				}
				input.ReadMessage(cNMHGGHGPBE);
				BMKAEFAKNFJ = cNMHGGHGPBE;
				break;
			}
			}
		}
	}
}

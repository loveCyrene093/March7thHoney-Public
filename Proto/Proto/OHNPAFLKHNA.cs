using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OHNPAFLKHNA : IMessage<OHNPAFLKHNA>, IMessage, IEquatable<OHNPAFLKHNA>, IDeepCloneable<OHNPAFLKHNA>, IBufferMessage
{
	public enum IFJMBNFCNBDOneofCase
	{
		None = 0,
		CMBPHAHDIAN = 131,
		IGJOLIJJLCK = 145,
		GINOJJFADPO = 330,
		AAJCDFDLDEH = 371,
		PanelId = 423,
		HLBKICJNAGK = 589,
		AvatarId = 608,
		KCPCJBIBDCA = 621,
		NCEKBKLNDDM = 659,
		HOKJFKNPKAJ = 918,
		KHNIJFNOELC = 1003
	}

	private static readonly MessageParser<OHNPAFLKHNA> _parser = new MessageParser<OHNPAFLKHNA>(() => new OHNPAFLKHNA());

	private UnknownFieldSet _unknownFields;

	public const int TimeFieldNumber = 8;

	private long time_;

	public const int FKGPLPGKDHNFieldNumber = 12;

	private DevelopmentType fKGPLPGKDHN_;

	public const int CMBPHAHDIANFieldNumber = 131;

	public const int IGJOLIJJLCKFieldNumber = 145;

	public const int GINOJJFADPOFieldNumber = 330;

	public const int AAJCDFDLDEHFieldNumber = 371;

	public const int PanelIdFieldNumber = 423;

	public const int HLBKICJNAGKFieldNumber = 589;

	public const int AvatarIdFieldNumber = 608;

	public const int KCPCJBIBDCAFieldNumber = 621;

	public const int NCEKBKLNDDMFieldNumber = 659;

	public const int HOKJFKNPKAJFieldNumber = 918;

	public const int KHNIJFNOELCFieldNumber = 1003;

	private object iFJMBNFCNBD_;

	private IFJMBNFCNBDOneofCase iFJMBNFCNBDCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OHNPAFLKHNA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OHNPAFLKHNAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Time
	{
		get
		{
			return time_;
		}
		set
		{
			time_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DevelopmentType FKGPLPGKDHN
	{
		get
		{
			return fKGPLPGKDHN_;
		}
		set
		{
			fKGPLPGKDHN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AALMEANBKAE CMBPHAHDIAN
	{
		get
		{
			if (iFJMBNFCNBDCase_ != IFJMBNFCNBDOneofCase.CMBPHAHDIAN)
			{
				return null;
			}
			return (AALMEANBKAE)iFJMBNFCNBD_;
		}
		set
		{
			iFJMBNFCNBD_ = value;
			iFJMBNFCNBDCase_ = ((value != null) ? IFJMBNFCNBDOneofCase.CMBPHAHDIAN : IFJMBNFCNBDOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HEBDKFOFKMN IGJOLIJJLCK
	{
		get
		{
			if (iFJMBNFCNBDCase_ != IFJMBNFCNBDOneofCase.IGJOLIJJLCK)
			{
				return null;
			}
			return (HEBDKFOFKMN)iFJMBNFCNBD_;
		}
		set
		{
			iFJMBNFCNBD_ = value;
			iFJMBNFCNBDCase_ = ((value != null) ? IFJMBNFCNBDOneofCase.IGJOLIJJLCK : IFJMBNFCNBDOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FMGHCDKFNDL GINOJJFADPO
	{
		get
		{
			if (iFJMBNFCNBDCase_ != IFJMBNFCNBDOneofCase.GINOJJFADPO)
			{
				return null;
			}
			return (FMGHCDKFNDL)iFJMBNFCNBD_;
		}
		set
		{
			iFJMBNFCNBD_ = value;
			iFJMBNFCNBDCase_ = ((value != null) ? IFJMBNFCNBDOneofCase.GINOJJFADPO : IFJMBNFCNBDOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CBGICNOFHCJ AAJCDFDLDEH
	{
		get
		{
			if (iFJMBNFCNBDCase_ != IFJMBNFCNBDOneofCase.AAJCDFDLDEH)
			{
				return null;
			}
			return (CBGICNOFHCJ)iFJMBNFCNBD_;
		}
		set
		{
			iFJMBNFCNBD_ = value;
			iFJMBNFCNBDCase_ = ((value != null) ? IFJMBNFCNBDOneofCase.AAJCDFDLDEH : IFJMBNFCNBDOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PanelId
	{
		get
		{
			if (!HasPanelId)
			{
				return 0u;
			}
			return (uint)iFJMBNFCNBD_;
		}
		set
		{
			iFJMBNFCNBD_ = value;
			iFJMBNFCNBDCase_ = IFJMBNFCNBDOneofCase.PanelId;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPanelId => iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.PanelId;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JGIJGAICGHE HLBKICJNAGK
	{
		get
		{
			if (iFJMBNFCNBDCase_ != IFJMBNFCNBDOneofCase.HLBKICJNAGK)
			{
				return null;
			}
			return (JGIJGAICGHE)iFJMBNFCNBD_;
		}
		set
		{
			iFJMBNFCNBD_ = value;
			iFJMBNFCNBDCase_ = ((value != null) ? IFJMBNFCNBDOneofCase.HLBKICJNAGK : IFJMBNFCNBDOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			if (!HasAvatarId)
			{
				return 0u;
			}
			return (uint)iFJMBNFCNBD_;
		}
		set
		{
			iFJMBNFCNBD_ = value;
			iFJMBNFCNBDCase_ = IFJMBNFCNBDOneofCase.AvatarId;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasAvatarId => iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.AvatarId;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KCPCJBIBDCA
	{
		get
		{
			if (!HasKCPCJBIBDCA)
			{
				return 0u;
			}
			return (uint)iFJMBNFCNBD_;
		}
		set
		{
			iFJMBNFCNBD_ = value;
			iFJMBNFCNBDCase_ = IFJMBNFCNBDOneofCase.KCPCJBIBDCA;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasKCPCJBIBDCA => iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.KCPCJBIBDCA;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DJLGCHBNMAC NCEKBKLNDDM
	{
		get
		{
			if (iFJMBNFCNBDCase_ != IFJMBNFCNBDOneofCase.NCEKBKLNDDM)
			{
				return null;
			}
			return (DJLGCHBNMAC)iFJMBNFCNBD_;
		}
		set
		{
			iFJMBNFCNBD_ = value;
			iFJMBNFCNBDCase_ = ((value != null) ? IFJMBNFCNBDOneofCase.NCEKBKLNDDM : IFJMBNFCNBDOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HOKJFKNPKAJ
	{
		get
		{
			if (!HasHOKJFKNPKAJ)
			{
				return 0u;
			}
			return (uint)iFJMBNFCNBD_;
		}
		set
		{
			iFJMBNFCNBD_ = value;
			iFJMBNFCNBDCase_ = IFJMBNFCNBDOneofCase.HOKJFKNPKAJ;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasHOKJFKNPKAJ => iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.HOKJFKNPKAJ;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMBOJMFJBKD KHNIJFNOELC
	{
		get
		{
			if (iFJMBNFCNBDCase_ != IFJMBNFCNBDOneofCase.KHNIJFNOELC)
			{
				return null;
			}
			return (DMBOJMFJBKD)iFJMBNFCNBD_;
		}
		set
		{
			iFJMBNFCNBD_ = value;
			iFJMBNFCNBDCase_ = ((value != null) ? IFJMBNFCNBDOneofCase.KHNIJFNOELC : IFJMBNFCNBDOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFJMBNFCNBDOneofCase IFJMBNFCNBDCase => iFJMBNFCNBDCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OHNPAFLKHNA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OHNPAFLKHNA(OHNPAFLKHNA other)
		: this()
	{
		time_ = other.time_;
		fKGPLPGKDHN_ = other.fKGPLPGKDHN_;
		switch (other.IFJMBNFCNBDCase)
		{
		case IFJMBNFCNBDOneofCase.CMBPHAHDIAN:
			CMBPHAHDIAN = other.CMBPHAHDIAN.Clone();
			break;
		case IFJMBNFCNBDOneofCase.IGJOLIJJLCK:
			IGJOLIJJLCK = other.IGJOLIJJLCK.Clone();
			break;
		case IFJMBNFCNBDOneofCase.GINOJJFADPO:
			GINOJJFADPO = other.GINOJJFADPO.Clone();
			break;
		case IFJMBNFCNBDOneofCase.AAJCDFDLDEH:
			AAJCDFDLDEH = other.AAJCDFDLDEH.Clone();
			break;
		case IFJMBNFCNBDOneofCase.PanelId:
			PanelId = other.PanelId;
			break;
		case IFJMBNFCNBDOneofCase.HLBKICJNAGK:
			HLBKICJNAGK = other.HLBKICJNAGK.Clone();
			break;
		case IFJMBNFCNBDOneofCase.AvatarId:
			AvatarId = other.AvatarId;
			break;
		case IFJMBNFCNBDOneofCase.KCPCJBIBDCA:
			KCPCJBIBDCA = other.KCPCJBIBDCA;
			break;
		case IFJMBNFCNBDOneofCase.NCEKBKLNDDM:
			NCEKBKLNDDM = other.NCEKBKLNDDM.Clone();
			break;
		case IFJMBNFCNBDOneofCase.HOKJFKNPKAJ:
			HOKJFKNPKAJ = other.HOKJFKNPKAJ;
			break;
		case IFJMBNFCNBDOneofCase.KHNIJFNOELC:
			KHNIJFNOELC = other.KHNIJFNOELC.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OHNPAFLKHNA Clone()
	{
		return new OHNPAFLKHNA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearPanelId()
	{
		if (HasPanelId)
		{
			ClearIFJMBNFCNBD();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearAvatarId()
	{
		if (HasAvatarId)
		{
			ClearIFJMBNFCNBD();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearKCPCJBIBDCA()
	{
		if (HasKCPCJBIBDCA)
		{
			ClearIFJMBNFCNBD();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearHOKJFKNPKAJ()
	{
		if (HasHOKJFKNPKAJ)
		{
			ClearIFJMBNFCNBD();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearIFJMBNFCNBD()
	{
		iFJMBNFCNBDCase_ = IFJMBNFCNBDOneofCase.None;
		iFJMBNFCNBD_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OHNPAFLKHNA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OHNPAFLKHNA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Time != other.Time)
		{
			return false;
		}
		if (FKGPLPGKDHN != other.FKGPLPGKDHN)
		{
			return false;
		}
		if (!object.Equals(CMBPHAHDIAN, other.CMBPHAHDIAN))
		{
			return false;
		}
		if (!object.Equals(IGJOLIJJLCK, other.IGJOLIJJLCK))
		{
			return false;
		}
		if (!object.Equals(GINOJJFADPO, other.GINOJJFADPO))
		{
			return false;
		}
		if (!object.Equals(AAJCDFDLDEH, other.AAJCDFDLDEH))
		{
			return false;
		}
		if (PanelId != other.PanelId)
		{
			return false;
		}
		if (!object.Equals(HLBKICJNAGK, other.HLBKICJNAGK))
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (KCPCJBIBDCA != other.KCPCJBIBDCA)
		{
			return false;
		}
		if (!object.Equals(NCEKBKLNDDM, other.NCEKBKLNDDM))
		{
			return false;
		}
		if (HOKJFKNPKAJ != other.HOKJFKNPKAJ)
		{
			return false;
		}
		if (!object.Equals(KHNIJFNOELC, other.KHNIJFNOELC))
		{
			return false;
		}
		if (IFJMBNFCNBDCase != other.IFJMBNFCNBDCase)
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
		if (Time != 0L)
		{
			num ^= Time.GetHashCode();
		}
		if (FKGPLPGKDHN != DevelopmentType.KghodpfjgliMjfldkhkdab)
		{
			num ^= FKGPLPGKDHN.GetHashCode();
		}
		if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.CMBPHAHDIAN)
		{
			num ^= CMBPHAHDIAN.GetHashCode();
		}
		if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.IGJOLIJJLCK)
		{
			num ^= IGJOLIJJLCK.GetHashCode();
		}
		if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.GINOJJFADPO)
		{
			num ^= GINOJJFADPO.GetHashCode();
		}
		if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.AAJCDFDLDEH)
		{
			num ^= AAJCDFDLDEH.GetHashCode();
		}
		if (HasPanelId)
		{
			num ^= PanelId.GetHashCode();
		}
		if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.HLBKICJNAGK)
		{
			num ^= HLBKICJNAGK.GetHashCode();
		}
		if (HasAvatarId)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (HasKCPCJBIBDCA)
		{
			num ^= KCPCJBIBDCA.GetHashCode();
		}
		if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.NCEKBKLNDDM)
		{
			num ^= NCEKBKLNDDM.GetHashCode();
		}
		if (HasHOKJFKNPKAJ)
		{
			num ^= HOKJFKNPKAJ.GetHashCode();
		}
		if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.KHNIJFNOELC)
		{
			num ^= KHNIJFNOELC.GetHashCode();
		}
		num ^= (int)iFJMBNFCNBDCase_;
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
		if (Time != 0L)
		{
			output.WriteRawTag(64);
			output.WriteInt64(Time);
		}
		if (FKGPLPGKDHN != DevelopmentType.KghodpfjgliMjfldkhkdab)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)FKGPLPGKDHN);
		}
		if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.CMBPHAHDIAN)
		{
			output.WriteRawTag(154, 8);
			output.WriteMessage(CMBPHAHDIAN);
		}
		if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.IGJOLIJJLCK)
		{
			output.WriteRawTag(138, 9);
			output.WriteMessage(IGJOLIJJLCK);
		}
		if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.GINOJJFADPO)
		{
			output.WriteRawTag(210, 20);
			output.WriteMessage(GINOJJFADPO);
		}
		if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.AAJCDFDLDEH)
		{
			output.WriteRawTag(154, 23);
			output.WriteMessage(AAJCDFDLDEH);
		}
		if (HasPanelId)
		{
			output.WriteRawTag(184, 26);
			output.WriteUInt32(PanelId);
		}
		if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.HLBKICJNAGK)
		{
			output.WriteRawTag(234, 36);
			output.WriteMessage(HLBKICJNAGK);
		}
		if (HasAvatarId)
		{
			output.WriteRawTag(128, 38);
			output.WriteUInt32(AvatarId);
		}
		if (HasKCPCJBIBDCA)
		{
			output.WriteRawTag(232, 38);
			output.WriteUInt32(KCPCJBIBDCA);
		}
		if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.NCEKBKLNDDM)
		{
			output.WriteRawTag(154, 41);
			output.WriteMessage(NCEKBKLNDDM);
		}
		if (HasHOKJFKNPKAJ)
		{
			output.WriteRawTag(176, 57);
			output.WriteUInt32(HOKJFKNPKAJ);
		}
		if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.KHNIJFNOELC)
		{
			output.WriteRawTag(218, 62);
			output.WriteMessage(KHNIJFNOELC);
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
		if (Time != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Time);
		}
		if (FKGPLPGKDHN != DevelopmentType.KghodpfjgliMjfldkhkdab)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)FKGPLPGKDHN);
		}
		if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.CMBPHAHDIAN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CMBPHAHDIAN);
		}
		if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.IGJOLIJJLCK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(IGJOLIJJLCK);
		}
		if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.GINOJJFADPO)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GINOJJFADPO);
		}
		if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.AAJCDFDLDEH)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AAJCDFDLDEH);
		}
		if (HasPanelId)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(PanelId);
		}
		if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.HLBKICJNAGK)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HLBKICJNAGK);
		}
		if (HasAvatarId)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (HasKCPCJBIBDCA)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(KCPCJBIBDCA);
		}
		if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.NCEKBKLNDDM)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NCEKBKLNDDM);
		}
		if (HasHOKJFKNPKAJ)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(HOKJFKNPKAJ);
		}
		if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.KHNIJFNOELC)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KHNIJFNOELC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OHNPAFLKHNA other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Time != 0L)
		{
			Time = other.Time;
		}
		if (other.FKGPLPGKDHN != DevelopmentType.KghodpfjgliMjfldkhkdab)
		{
			FKGPLPGKDHN = other.FKGPLPGKDHN;
		}
		switch (other.IFJMBNFCNBDCase)
		{
		case IFJMBNFCNBDOneofCase.CMBPHAHDIAN:
			if (CMBPHAHDIAN == null)
			{
				CMBPHAHDIAN = new AALMEANBKAE();
			}
			CMBPHAHDIAN.MergeFrom(other.CMBPHAHDIAN);
			break;
		case IFJMBNFCNBDOneofCase.IGJOLIJJLCK:
			if (IGJOLIJJLCK == null)
			{
				IGJOLIJJLCK = new HEBDKFOFKMN();
			}
			IGJOLIJJLCK.MergeFrom(other.IGJOLIJJLCK);
			break;
		case IFJMBNFCNBDOneofCase.GINOJJFADPO:
			if (GINOJJFADPO == null)
			{
				GINOJJFADPO = new FMGHCDKFNDL();
			}
			GINOJJFADPO.MergeFrom(other.GINOJJFADPO);
			break;
		case IFJMBNFCNBDOneofCase.AAJCDFDLDEH:
			if (AAJCDFDLDEH == null)
			{
				AAJCDFDLDEH = new CBGICNOFHCJ();
			}
			AAJCDFDLDEH.MergeFrom(other.AAJCDFDLDEH);
			break;
		case IFJMBNFCNBDOneofCase.PanelId:
			PanelId = other.PanelId;
			break;
		case IFJMBNFCNBDOneofCase.HLBKICJNAGK:
			if (HLBKICJNAGK == null)
			{
				HLBKICJNAGK = new JGIJGAICGHE();
			}
			HLBKICJNAGK.MergeFrom(other.HLBKICJNAGK);
			break;
		case IFJMBNFCNBDOneofCase.AvatarId:
			AvatarId = other.AvatarId;
			break;
		case IFJMBNFCNBDOneofCase.KCPCJBIBDCA:
			KCPCJBIBDCA = other.KCPCJBIBDCA;
			break;
		case IFJMBNFCNBDOneofCase.NCEKBKLNDDM:
			if (NCEKBKLNDDM == null)
			{
				NCEKBKLNDDM = new DJLGCHBNMAC();
			}
			NCEKBKLNDDM.MergeFrom(other.NCEKBKLNDDM);
			break;
		case IFJMBNFCNBDOneofCase.HOKJFKNPKAJ:
			HOKJFKNPKAJ = other.HOKJFKNPKAJ;
			break;
		case IFJMBNFCNBDOneofCase.KHNIJFNOELC:
			if (KHNIJFNOELC == null)
			{
				KHNIJFNOELC = new DMBOJMFJBKD();
			}
			KHNIJFNOELC.MergeFrom(other.KHNIJFNOELC);
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
			case 64u:
				Time = input.ReadInt64();
				break;
			case 96u:
				FKGPLPGKDHN = (DevelopmentType)input.ReadEnum();
				break;
			case 1050u:
			{
				AALMEANBKAE aALMEANBKAE = new AALMEANBKAE();
				if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.CMBPHAHDIAN)
				{
					aALMEANBKAE.MergeFrom(CMBPHAHDIAN);
				}
				input.ReadMessage(aALMEANBKAE);
				CMBPHAHDIAN = aALMEANBKAE;
				break;
			}
			case 1162u:
			{
				HEBDKFOFKMN hEBDKFOFKMN = new HEBDKFOFKMN();
				if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.IGJOLIJJLCK)
				{
					hEBDKFOFKMN.MergeFrom(IGJOLIJJLCK);
				}
				input.ReadMessage(hEBDKFOFKMN);
				IGJOLIJJLCK = hEBDKFOFKMN;
				break;
			}
			case 2642u:
			{
				FMGHCDKFNDL fMGHCDKFNDL = new FMGHCDKFNDL();
				if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.GINOJJFADPO)
				{
					fMGHCDKFNDL.MergeFrom(GINOJJFADPO);
				}
				input.ReadMessage(fMGHCDKFNDL);
				GINOJJFADPO = fMGHCDKFNDL;
				break;
			}
			case 2970u:
			{
				CBGICNOFHCJ cBGICNOFHCJ = new CBGICNOFHCJ();
				if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.AAJCDFDLDEH)
				{
					cBGICNOFHCJ.MergeFrom(AAJCDFDLDEH);
				}
				input.ReadMessage(cBGICNOFHCJ);
				AAJCDFDLDEH = cBGICNOFHCJ;
				break;
			}
			case 3384u:
				PanelId = input.ReadUInt32();
				break;
			case 4714u:
			{
				JGIJGAICGHE jGIJGAICGHE = new JGIJGAICGHE();
				if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.HLBKICJNAGK)
				{
					jGIJGAICGHE.MergeFrom(HLBKICJNAGK);
				}
				input.ReadMessage(jGIJGAICGHE);
				HLBKICJNAGK = jGIJGAICGHE;
				break;
			}
			case 4864u:
				AvatarId = input.ReadUInt32();
				break;
			case 4968u:
				KCPCJBIBDCA = input.ReadUInt32();
				break;
			case 5274u:
			{
				DJLGCHBNMAC dJLGCHBNMAC = new DJLGCHBNMAC();
				if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.NCEKBKLNDDM)
				{
					dJLGCHBNMAC.MergeFrom(NCEKBKLNDDM);
				}
				input.ReadMessage(dJLGCHBNMAC);
				NCEKBKLNDDM = dJLGCHBNMAC;
				break;
			}
			case 7344u:
				HOKJFKNPKAJ = input.ReadUInt32();
				break;
			case 8026u:
			{
				DMBOJMFJBKD dMBOJMFJBKD = new DMBOJMFJBKD();
				if (iFJMBNFCNBDCase_ == IFJMBNFCNBDOneofCase.KHNIJFNOELC)
				{
					dMBOJMFJBKD.MergeFrom(KHNIJFNOELC);
				}
				input.ReadMessage(dMBOJMFJBKD);
				KHNIJFNOELC = dMBOJMFJBKD;
				break;
			}
			}
		}
	}
}

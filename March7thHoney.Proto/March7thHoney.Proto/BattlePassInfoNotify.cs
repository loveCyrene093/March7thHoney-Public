using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BattlePassInfoNotify : IMessage<BattlePassInfoNotify>, IMessage, IEquatable<BattlePassInfoNotify>, IDeepCloneable<BattlePassInfoNotify>, IBufferMessage
{
	private static readonly MessageParser<BattlePassInfoNotify> _parser = new MessageParser<BattlePassInfoNotify>(() => new BattlePassInfoNotify());

	private UnknownFieldSet _unknownFields;

	public const int HEBILJIIICGFieldNumber = 1;

	private ulong hEBILJIIICG_;

	public const int IHMNMNBKJPGFieldNumber = 2;

	private ulong iHMNMNBKJPG_;

	public const int EDGECHCLDHGFieldNumber = 3;

	private uint eDGECHCLDHG_;

	public const int KBCPNAMDBJEFieldNumber = 4;

	private ulong kBCPNAMDBJE_;

	public const int ExpFieldNumber = 5;

	private uint exp_;

	public const int OKNMGHGAEIGFieldNumber = 7;

	private ulong oKNMGHGAEIG_;

	public const int CDKCGAKABALFieldNumber = 8;

	private ulong cDKCGAKABAL_;

	public const int BpTierTypeFieldNumber = 9;

	private BpTierType bpTierType_;

	public const int LevelFieldNumber = 10;

	private uint level_;

	public const int GCLPLAOIJEOFieldNumber = 11;

	private uint gCLPLAOIJEO_;

	public const int AEGLOAAPHEBFieldNumber = 12;

	private ulong aEGLOAAPHEB_;

	public const int GENINOGKLAPFieldNumber = 14;

	private ulong gENINOGKLAP_;

	public const int KPOGAJBLDNCFieldNumber = 15;

	private ulong kPOGAJBLDNC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattlePassInfoNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattlePassInfoNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong HEBILJIIICG
	{
		get
		{
			return hEBILJIIICG_;
		}
		set
		{
			hEBILJIIICG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong IHMNMNBKJPG
	{
		get
		{
			return iHMNMNBKJPG_;
		}
		set
		{
			iHMNMNBKJPG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EDGECHCLDHG
	{
		get
		{
			return eDGECHCLDHG_;
		}
		set
		{
			eDGECHCLDHG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong KBCPNAMDBJE
	{
		get
		{
			return kBCPNAMDBJE_;
		}
		set
		{
			kBCPNAMDBJE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Exp
	{
		get
		{
			return exp_;
		}
		set
		{
			exp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong OKNMGHGAEIG
	{
		get
		{
			return oKNMGHGAEIG_;
		}
		set
		{
			oKNMGHGAEIG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong CDKCGAKABAL
	{
		get
		{
			return cDKCGAKABAL_;
		}
		set
		{
			cDKCGAKABAL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BpTierType BpTierType
	{
		get
		{
			return bpTierType_;
		}
		set
		{
			bpTierType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GCLPLAOIJEO
	{
		get
		{
			return gCLPLAOIJEO_;
		}
		set
		{
			gCLPLAOIJEO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong AEGLOAAPHEB
	{
		get
		{
			return aEGLOAAPHEB_;
		}
		set
		{
			aEGLOAAPHEB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong GENINOGKLAP
	{
		get
		{
			return gENINOGKLAP_;
		}
		set
		{
			gENINOGKLAP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong KPOGAJBLDNC
	{
		get
		{
			return kPOGAJBLDNC_;
		}
		set
		{
			kPOGAJBLDNC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattlePassInfoNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattlePassInfoNotify(BattlePassInfoNotify other)
		: this()
	{
		hEBILJIIICG_ = other.hEBILJIIICG_;
		iHMNMNBKJPG_ = other.iHMNMNBKJPG_;
		eDGECHCLDHG_ = other.eDGECHCLDHG_;
		kBCPNAMDBJE_ = other.kBCPNAMDBJE_;
		exp_ = other.exp_;
		oKNMGHGAEIG_ = other.oKNMGHGAEIG_;
		cDKCGAKABAL_ = other.cDKCGAKABAL_;
		bpTierType_ = other.bpTierType_;
		level_ = other.level_;
		gCLPLAOIJEO_ = other.gCLPLAOIJEO_;
		aEGLOAAPHEB_ = other.aEGLOAAPHEB_;
		gENINOGKLAP_ = other.gENINOGKLAP_;
		kPOGAJBLDNC_ = other.kPOGAJBLDNC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattlePassInfoNotify Clone()
	{
		return new BattlePassInfoNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattlePassInfoNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattlePassInfoNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HEBILJIIICG != other.HEBILJIIICG)
		{
			return false;
		}
		if (IHMNMNBKJPG != other.IHMNMNBKJPG)
		{
			return false;
		}
		if (EDGECHCLDHG != other.EDGECHCLDHG)
		{
			return false;
		}
		if (KBCPNAMDBJE != other.KBCPNAMDBJE)
		{
			return false;
		}
		if (Exp != other.Exp)
		{
			return false;
		}
		if (OKNMGHGAEIG != other.OKNMGHGAEIG)
		{
			return false;
		}
		if (CDKCGAKABAL != other.CDKCGAKABAL)
		{
			return false;
		}
		if (BpTierType != other.BpTierType)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (GCLPLAOIJEO != other.GCLPLAOIJEO)
		{
			return false;
		}
		if (AEGLOAAPHEB != other.AEGLOAAPHEB)
		{
			return false;
		}
		if (GENINOGKLAP != other.GENINOGKLAP)
		{
			return false;
		}
		if (KPOGAJBLDNC != other.KPOGAJBLDNC)
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
		if (HEBILJIIICG != 0L)
		{
			num ^= HEBILJIIICG.GetHashCode();
		}
		if (IHMNMNBKJPG != 0L)
		{
			num ^= IHMNMNBKJPG.GetHashCode();
		}
		if (EDGECHCLDHG != 0)
		{
			num ^= EDGECHCLDHG.GetHashCode();
		}
		if (KBCPNAMDBJE != 0L)
		{
			num ^= KBCPNAMDBJE.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		if (OKNMGHGAEIG != 0L)
		{
			num ^= OKNMGHGAEIG.GetHashCode();
		}
		if (CDKCGAKABAL != 0L)
		{
			num ^= CDKCGAKABAL.GetHashCode();
		}
		if (BpTierType != BpTierType.AnmmopchjdiPcpdhelpkem)
		{
			num ^= BpTierType.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (GCLPLAOIJEO != 0)
		{
			num ^= GCLPLAOIJEO.GetHashCode();
		}
		if (AEGLOAAPHEB != 0L)
		{
			num ^= AEGLOAAPHEB.GetHashCode();
		}
		if (GENINOGKLAP != 0L)
		{
			num ^= GENINOGKLAP.GetHashCode();
		}
		if (KPOGAJBLDNC != 0L)
		{
			num ^= KPOGAJBLDNC.GetHashCode();
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
		if (HEBILJIIICG != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(HEBILJIIICG);
		}
		if (IHMNMNBKJPG != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(IHMNMNBKJPG);
		}
		if (EDGECHCLDHG != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(EDGECHCLDHG);
		}
		if (KBCPNAMDBJE != 0L)
		{
			output.WriteRawTag(32);
			output.WriteUInt64(KBCPNAMDBJE);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Exp);
		}
		if (OKNMGHGAEIG != 0L)
		{
			output.WriteRawTag(56);
			output.WriteUInt64(OKNMGHGAEIG);
		}
		if (CDKCGAKABAL != 0L)
		{
			output.WriteRawTag(64);
			output.WriteUInt64(CDKCGAKABAL);
		}
		if (BpTierType != BpTierType.AnmmopchjdiPcpdhelpkem)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)BpTierType);
		}
		if (Level != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Level);
		}
		if (GCLPLAOIJEO != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(GCLPLAOIJEO);
		}
		if (AEGLOAAPHEB != 0L)
		{
			output.WriteRawTag(96);
			output.WriteUInt64(AEGLOAAPHEB);
		}
		if (GENINOGKLAP != 0L)
		{
			output.WriteRawTag(112);
			output.WriteUInt64(GENINOGKLAP);
		}
		if (KPOGAJBLDNC != 0L)
		{
			output.WriteRawTag(120);
			output.WriteUInt64(KPOGAJBLDNC);
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
		if (HEBILJIIICG != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(HEBILJIIICG);
		}
		if (IHMNMNBKJPG != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(IHMNMNBKJPG);
		}
		if (EDGECHCLDHG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EDGECHCLDHG);
		}
		if (KBCPNAMDBJE != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(KBCPNAMDBJE);
		}
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		if (OKNMGHGAEIG != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(OKNMGHGAEIG);
		}
		if (CDKCGAKABAL != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(CDKCGAKABAL);
		}
		if (BpTierType != BpTierType.AnmmopchjdiPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BpTierType);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (GCLPLAOIJEO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GCLPLAOIJEO);
		}
		if (AEGLOAAPHEB != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(AEGLOAAPHEB);
		}
		if (GENINOGKLAP != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(GENINOGKLAP);
		}
		if (KPOGAJBLDNC != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(KPOGAJBLDNC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattlePassInfoNotify other)
	{
		if (other != null)
		{
			if (other.HEBILJIIICG != 0L)
			{
				HEBILJIIICG = other.HEBILJIIICG;
			}
			if (other.IHMNMNBKJPG != 0L)
			{
				IHMNMNBKJPG = other.IHMNMNBKJPG;
			}
			if (other.EDGECHCLDHG != 0)
			{
				EDGECHCLDHG = other.EDGECHCLDHG;
			}
			if (other.KBCPNAMDBJE != 0L)
			{
				KBCPNAMDBJE = other.KBCPNAMDBJE;
			}
			if (other.Exp != 0)
			{
				Exp = other.Exp;
			}
			if (other.OKNMGHGAEIG != 0L)
			{
				OKNMGHGAEIG = other.OKNMGHGAEIG;
			}
			if (other.CDKCGAKABAL != 0L)
			{
				CDKCGAKABAL = other.CDKCGAKABAL;
			}
			if (other.BpTierType != BpTierType.AnmmopchjdiPcpdhelpkem)
			{
				BpTierType = other.BpTierType;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.GCLPLAOIJEO != 0)
			{
				GCLPLAOIJEO = other.GCLPLAOIJEO;
			}
			if (other.AEGLOAAPHEB != 0L)
			{
				AEGLOAAPHEB = other.AEGLOAAPHEB;
			}
			if (other.GENINOGKLAP != 0L)
			{
				GENINOGKLAP = other.GENINOGKLAP;
			}
			if (other.KPOGAJBLDNC != 0L)
			{
				KPOGAJBLDNC = other.KPOGAJBLDNC;
			}
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
				HEBILJIIICG = input.ReadUInt64();
				break;
			case 16u:
				IHMNMNBKJPG = input.ReadUInt64();
				break;
			case 24u:
				EDGECHCLDHG = input.ReadUInt32();
				break;
			case 32u:
				KBCPNAMDBJE = input.ReadUInt64();
				break;
			case 40u:
				Exp = input.ReadUInt32();
				break;
			case 56u:
				OKNMGHGAEIG = input.ReadUInt64();
				break;
			case 64u:
				CDKCGAKABAL = input.ReadUInt64();
				break;
			case 72u:
				BpTierType = (BpTierType)input.ReadEnum();
				break;
			case 80u:
				Level = input.ReadUInt32();
				break;
			case 88u:
				GCLPLAOIJEO = input.ReadUInt32();
				break;
			case 96u:
				AEGLOAAPHEB = input.ReadUInt64();
				break;
			case 112u:
				GENINOGKLAP = input.ReadUInt64();
				break;
			case 120u:
				KPOGAJBLDNC = input.ReadUInt64();
				break;
			}
		}
	}
}

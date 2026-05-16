using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerRecordInfo : IMessage<PlayerRecordInfo>, IMessage, IEquatable<PlayerRecordInfo>, IDeepCloneable<PlayerRecordInfo>, IBufferMessage
{
	private static readonly MessageParser<PlayerRecordInfo> _parser = new MessageParser<PlayerRecordInfo>(() => new PlayerRecordInfo());

	private UnknownFieldSet _unknownFields;

	public const int MMFGIPPNEEFFieldNumber = 3;

	private uint mMFGIPPNEEF_;

	public const int LCEEKBAJPHAFieldNumber = 4;

	private uint lCEEKBAJPHA_;

	public const int KEBOJOIBOKEFieldNumber = 6;

	private uint kEBOJOIBOKE_;

	public const int LBKCIEBGMAJFieldNumber = 9;

	private uint lBKCIEBGMAJ_;

	public const int CEAKOOAOJLFFieldNumber = 10;

	private BJKJKGAGDAC cEAKOOAOJLF_;

	public const int GPJGLLANPIFFieldNumber = 11;

	private uint gPJGLLANPIF_;

	public const int KHDJDCELNPFFieldNumber = 12;

	private uint kHDJDCELNPF_;

	public const int MIMIPDMIPNOFieldNumber = 13;

	private uint mIMIPDMIPNO_;

	public const int MPNIKBAFPEMFieldNumber = 14;

	private uint mPNIKBAFPEM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerRecordInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerRecordInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MMFGIPPNEEF
	{
		get
		{
			return mMFGIPPNEEF_;
		}
		set
		{
			mMFGIPPNEEF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LCEEKBAJPHA
	{
		get
		{
			return lCEEKBAJPHA_;
		}
		set
		{
			lCEEKBAJPHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KEBOJOIBOKE
	{
		get
		{
			return kEBOJOIBOKE_;
		}
		set
		{
			kEBOJOIBOKE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LBKCIEBGMAJ
	{
		get
		{
			return lBKCIEBGMAJ_;
		}
		set
		{
			lBKCIEBGMAJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJKJKGAGDAC CEAKOOAOJLF
	{
		get
		{
			return cEAKOOAOJLF_;
		}
		set
		{
			cEAKOOAOJLF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GPJGLLANPIF
	{
		get
		{
			return gPJGLLANPIF_;
		}
		set
		{
			gPJGLLANPIF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KHDJDCELNPF
	{
		get
		{
			return kHDJDCELNPF_;
		}
		set
		{
			kHDJDCELNPF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MIMIPDMIPNO
	{
		get
		{
			return mIMIPDMIPNO_;
		}
		set
		{
			mIMIPDMIPNO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MPNIKBAFPEM
	{
		get
		{
			return mPNIKBAFPEM_;
		}
		set
		{
			mPNIKBAFPEM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerRecordInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerRecordInfo(PlayerRecordInfo other)
		: this()
	{
		mMFGIPPNEEF_ = other.mMFGIPPNEEF_;
		lCEEKBAJPHA_ = other.lCEEKBAJPHA_;
		kEBOJOIBOKE_ = other.kEBOJOIBOKE_;
		lBKCIEBGMAJ_ = other.lBKCIEBGMAJ_;
		cEAKOOAOJLF_ = ((other.cEAKOOAOJLF_ != null) ? other.cEAKOOAOJLF_.Clone() : null);
		gPJGLLANPIF_ = other.gPJGLLANPIF_;
		kHDJDCELNPF_ = other.kHDJDCELNPF_;
		mIMIPDMIPNO_ = other.mIMIPDMIPNO_;
		mPNIKBAFPEM_ = other.mPNIKBAFPEM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerRecordInfo Clone()
	{
		return new PlayerRecordInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerRecordInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerRecordInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MMFGIPPNEEF != other.MMFGIPPNEEF)
		{
			return false;
		}
		if (LCEEKBAJPHA != other.LCEEKBAJPHA)
		{
			return false;
		}
		if (KEBOJOIBOKE != other.KEBOJOIBOKE)
		{
			return false;
		}
		if (LBKCIEBGMAJ != other.LBKCIEBGMAJ)
		{
			return false;
		}
		if (!object.Equals(CEAKOOAOJLF, other.CEAKOOAOJLF))
		{
			return false;
		}
		if (GPJGLLANPIF != other.GPJGLLANPIF)
		{
			return false;
		}
		if (KHDJDCELNPF != other.KHDJDCELNPF)
		{
			return false;
		}
		if (MIMIPDMIPNO != other.MIMIPDMIPNO)
		{
			return false;
		}
		if (MPNIKBAFPEM != other.MPNIKBAFPEM)
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
		if (MMFGIPPNEEF != 0)
		{
			num ^= MMFGIPPNEEF.GetHashCode();
		}
		if (LCEEKBAJPHA != 0)
		{
			num ^= LCEEKBAJPHA.GetHashCode();
		}
		if (KEBOJOIBOKE != 0)
		{
			num ^= KEBOJOIBOKE.GetHashCode();
		}
		if (LBKCIEBGMAJ != 0)
		{
			num ^= LBKCIEBGMAJ.GetHashCode();
		}
		if (cEAKOOAOJLF_ != null)
		{
			num ^= CEAKOOAOJLF.GetHashCode();
		}
		if (GPJGLLANPIF != 0)
		{
			num ^= GPJGLLANPIF.GetHashCode();
		}
		if (KHDJDCELNPF != 0)
		{
			num ^= KHDJDCELNPF.GetHashCode();
		}
		if (MIMIPDMIPNO != 0)
		{
			num ^= MIMIPDMIPNO.GetHashCode();
		}
		if (MPNIKBAFPEM != 0)
		{
			num ^= MPNIKBAFPEM.GetHashCode();
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
		if (MMFGIPPNEEF != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(MMFGIPPNEEF);
		}
		if (LCEEKBAJPHA != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(LCEEKBAJPHA);
		}
		if (KEBOJOIBOKE != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(KEBOJOIBOKE);
		}
		if (LBKCIEBGMAJ != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(LBKCIEBGMAJ);
		}
		if (cEAKOOAOJLF_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(CEAKOOAOJLF);
		}
		if (GPJGLLANPIF != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(GPJGLLANPIF);
		}
		if (KHDJDCELNPF != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(KHDJDCELNPF);
		}
		if (MIMIPDMIPNO != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(MIMIPDMIPNO);
		}
		if (MPNIKBAFPEM != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(MPNIKBAFPEM);
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
		if (MMFGIPPNEEF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MMFGIPPNEEF);
		}
		if (LCEEKBAJPHA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LCEEKBAJPHA);
		}
		if (KEBOJOIBOKE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KEBOJOIBOKE);
		}
		if (LBKCIEBGMAJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LBKCIEBGMAJ);
		}
		if (cEAKOOAOJLF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CEAKOOAOJLF);
		}
		if (GPJGLLANPIF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GPJGLLANPIF);
		}
		if (KHDJDCELNPF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KHDJDCELNPF);
		}
		if (MIMIPDMIPNO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MIMIPDMIPNO);
		}
		if (MPNIKBAFPEM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MPNIKBAFPEM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerRecordInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MMFGIPPNEEF != 0)
		{
			MMFGIPPNEEF = other.MMFGIPPNEEF;
		}
		if (other.LCEEKBAJPHA != 0)
		{
			LCEEKBAJPHA = other.LCEEKBAJPHA;
		}
		if (other.KEBOJOIBOKE != 0)
		{
			KEBOJOIBOKE = other.KEBOJOIBOKE;
		}
		if (other.LBKCIEBGMAJ != 0)
		{
			LBKCIEBGMAJ = other.LBKCIEBGMAJ;
		}
		if (other.cEAKOOAOJLF_ != null)
		{
			if (cEAKOOAOJLF_ == null)
			{
				CEAKOOAOJLF = new BJKJKGAGDAC();
			}
			CEAKOOAOJLF.MergeFrom(other.CEAKOOAOJLF);
		}
		if (other.GPJGLLANPIF != 0)
		{
			GPJGLLANPIF = other.GPJGLLANPIF;
		}
		if (other.KHDJDCELNPF != 0)
		{
			KHDJDCELNPF = other.KHDJDCELNPF;
		}
		if (other.MIMIPDMIPNO != 0)
		{
			MIMIPDMIPNO = other.MIMIPDMIPNO;
		}
		if (other.MPNIKBAFPEM != 0)
		{
			MPNIKBAFPEM = other.MPNIKBAFPEM;
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
			case 24u:
				MMFGIPPNEEF = input.ReadUInt32();
				break;
			case 32u:
				LCEEKBAJPHA = input.ReadUInt32();
				break;
			case 48u:
				KEBOJOIBOKE = input.ReadUInt32();
				break;
			case 72u:
				LBKCIEBGMAJ = input.ReadUInt32();
				break;
			case 82u:
				if (cEAKOOAOJLF_ == null)
				{
					CEAKOOAOJLF = new BJKJKGAGDAC();
				}
				input.ReadMessage(CEAKOOAOJLF);
				break;
			case 88u:
				GPJGLLANPIF = input.ReadUInt32();
				break;
			case 96u:
				KHDJDCELNPF = input.ReadUInt32();
				break;
			case 104u:
				MIMIPDMIPNO = input.ReadUInt32();
				break;
			case 112u:
				MPNIKBAFPEM = input.ReadUInt32();
				break;
			}
		}
	}
}

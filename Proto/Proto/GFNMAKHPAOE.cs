using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GFNMAKHPAOE : IMessage<GFNMAKHPAOE>, IMessage, IEquatable<GFNMAKHPAOE>, IDeepCloneable<GFNMAKHPAOE>, IBufferMessage
{
	private static readonly MessageParser<GFNMAKHPAOE> _parser = new MessageParser<GFNMAKHPAOE>(() => new GFNMAKHPAOE());

	private UnknownFieldSet _unknownFields;

	public const int PJCGAJPDOBNFieldNumber = 1;

	private uint pJCGAJPDOBN_;

	public const int GEMHDNHDAFBFieldNumber = 2;

	private uint gEMHDNHDAFB_;

	public const int FOOLMIADMMHFieldNumber = 3;

	private uint fOOLMIADMMH_;

	public const int IHPGCAAAGBCFieldNumber = 4;

	private uint iHPGCAAAGBC_;

	public const int CJECINJPIIJFieldNumber = 5;

	private static readonly FieldCodec<BJOBDLDHOCC> _repeated_cJECINJPIIJ_codec = FieldCodec.ForMessage(42u, BJOBDLDHOCC.Parser);

	private readonly RepeatedField<BJOBDLDHOCC> cJECINJPIIJ_ = new RepeatedField<BJOBDLDHOCC>();

	public const int MNIOANAMFMKFieldNumber = 6;

	private uint mNIOANAMFMK_;

	public const int GPBDPOOPAADFieldNumber = 7;

	private uint gPBDPOOPAAD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GFNMAKHPAOE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GFNMAKHPAOEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PJCGAJPDOBN
	{
		get
		{
			return pJCGAJPDOBN_;
		}
		set
		{
			pJCGAJPDOBN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GEMHDNHDAFB
	{
		get
		{
			return gEMHDNHDAFB_;
		}
		set
		{
			gEMHDNHDAFB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FOOLMIADMMH
	{
		get
		{
			return fOOLMIADMMH_;
		}
		set
		{
			fOOLMIADMMH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IHPGCAAAGBC
	{
		get
		{
			return iHPGCAAAGBC_;
		}
		set
		{
			iHPGCAAAGBC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BJOBDLDHOCC> CJECINJPIIJ => cJECINJPIIJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MNIOANAMFMK
	{
		get
		{
			return mNIOANAMFMK_;
		}
		set
		{
			mNIOANAMFMK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GPBDPOOPAAD
	{
		get
		{
			return gPBDPOOPAAD_;
		}
		set
		{
			gPBDPOOPAAD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFNMAKHPAOE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFNMAKHPAOE(GFNMAKHPAOE other)
		: this()
	{
		pJCGAJPDOBN_ = other.pJCGAJPDOBN_;
		gEMHDNHDAFB_ = other.gEMHDNHDAFB_;
		fOOLMIADMMH_ = other.fOOLMIADMMH_;
		iHPGCAAAGBC_ = other.iHPGCAAAGBC_;
		cJECINJPIIJ_ = other.cJECINJPIIJ_.Clone();
		mNIOANAMFMK_ = other.mNIOANAMFMK_;
		gPBDPOOPAAD_ = other.gPBDPOOPAAD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFNMAKHPAOE Clone()
	{
		return new GFNMAKHPAOE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GFNMAKHPAOE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GFNMAKHPAOE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PJCGAJPDOBN != other.PJCGAJPDOBN)
		{
			return false;
		}
		if (GEMHDNHDAFB != other.GEMHDNHDAFB)
		{
			return false;
		}
		if (FOOLMIADMMH != other.FOOLMIADMMH)
		{
			return false;
		}
		if (IHPGCAAAGBC != other.IHPGCAAAGBC)
		{
			return false;
		}
		if (!cJECINJPIIJ_.Equals(other.cJECINJPIIJ_))
		{
			return false;
		}
		if (MNIOANAMFMK != other.MNIOANAMFMK)
		{
			return false;
		}
		if (GPBDPOOPAAD != other.GPBDPOOPAAD)
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
		if (PJCGAJPDOBN != 0)
		{
			num ^= PJCGAJPDOBN.GetHashCode();
		}
		if (GEMHDNHDAFB != 0)
		{
			num ^= GEMHDNHDAFB.GetHashCode();
		}
		if (FOOLMIADMMH != 0)
		{
			num ^= FOOLMIADMMH.GetHashCode();
		}
		if (IHPGCAAAGBC != 0)
		{
			num ^= IHPGCAAAGBC.GetHashCode();
		}
		num ^= cJECINJPIIJ_.GetHashCode();
		if (MNIOANAMFMK != 0)
		{
			num ^= MNIOANAMFMK.GetHashCode();
		}
		if (GPBDPOOPAAD != 0)
		{
			num ^= GPBDPOOPAAD.GetHashCode();
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
		if (PJCGAJPDOBN != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(PJCGAJPDOBN);
		}
		if (GEMHDNHDAFB != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GEMHDNHDAFB);
		}
		if (FOOLMIADMMH != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(FOOLMIADMMH);
		}
		if (IHPGCAAAGBC != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(IHPGCAAAGBC);
		}
		cJECINJPIIJ_.WriteTo(ref output, _repeated_cJECINJPIIJ_codec);
		if (MNIOANAMFMK != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(MNIOANAMFMK);
		}
		if (GPBDPOOPAAD != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(GPBDPOOPAAD);
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
		if (PJCGAJPDOBN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PJCGAJPDOBN);
		}
		if (GEMHDNHDAFB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GEMHDNHDAFB);
		}
		if (FOOLMIADMMH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FOOLMIADMMH);
		}
		if (IHPGCAAAGBC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IHPGCAAAGBC);
		}
		num += cJECINJPIIJ_.CalculateSize(_repeated_cJECINJPIIJ_codec);
		if (MNIOANAMFMK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MNIOANAMFMK);
		}
		if (GPBDPOOPAAD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GPBDPOOPAAD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GFNMAKHPAOE other)
	{
		if (other != null)
		{
			if (other.PJCGAJPDOBN != 0)
			{
				PJCGAJPDOBN = other.PJCGAJPDOBN;
			}
			if (other.GEMHDNHDAFB != 0)
			{
				GEMHDNHDAFB = other.GEMHDNHDAFB;
			}
			if (other.FOOLMIADMMH != 0)
			{
				FOOLMIADMMH = other.FOOLMIADMMH;
			}
			if (other.IHPGCAAAGBC != 0)
			{
				IHPGCAAAGBC = other.IHPGCAAAGBC;
			}
			cJECINJPIIJ_.Add(other.cJECINJPIIJ_);
			if (other.MNIOANAMFMK != 0)
			{
				MNIOANAMFMK = other.MNIOANAMFMK;
			}
			if (other.GPBDPOOPAAD != 0)
			{
				GPBDPOOPAAD = other.GPBDPOOPAAD;
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
				PJCGAJPDOBN = input.ReadUInt32();
				break;
			case 16u:
				GEMHDNHDAFB = input.ReadUInt32();
				break;
			case 24u:
				FOOLMIADMMH = input.ReadUInt32();
				break;
			case 32u:
				IHPGCAAAGBC = input.ReadUInt32();
				break;
			case 42u:
				cJECINJPIIJ_.AddEntriesFrom(ref input, _repeated_cJECINJPIIJ_codec);
				break;
			case 48u:
				MNIOANAMFMK = input.ReadUInt32();
				break;
			case 56u:
				GPBDPOOPAAD = input.ReadUInt32();
				break;
			}
		}
	}
}

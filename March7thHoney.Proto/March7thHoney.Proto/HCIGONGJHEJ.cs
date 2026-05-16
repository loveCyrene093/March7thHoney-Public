using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HCIGONGJHEJ : IMessage<HCIGONGJHEJ>, IMessage, IEquatable<HCIGONGJHEJ>, IDeepCloneable<HCIGONGJHEJ>, IBufferMessage
{
	private static readonly MessageParser<HCIGONGJHEJ> _parser = new MessageParser<HCIGONGJHEJ>(() => new HCIGONGJHEJ());

	private UnknownFieldSet _unknownFields;

	public const int EPDAFICMJAOFieldNumber = 1;

	private uint ePDAFICMJAO_;

	public const int JDLBMFNHBIIFieldNumber = 2;

	private double jDLBMFNHBII_;

	public const int HJLOLCGILJLFieldNumber = 3;

	private double hJLOLCGILJL_;

	public const int WaveFieldNumber = 4;

	private uint wave_;

	public const int IBFBGEFLOJKFieldNumber = 5;

	private uint iBFBGEFLOJK_;

	public const int MECHDOHDNFPFieldNumber = 6;

	private double mECHDOHDNFP_;

	public const int KAEMFEGJGMPFieldNumber = 7;

	private double kAEMFEGJGMP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HCIGONGJHEJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HCIGONGJHEJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EPDAFICMJAO
	{
		get
		{
			return ePDAFICMJAO_;
		}
		set
		{
			ePDAFICMJAO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double JDLBMFNHBII
	{
		get
		{
			return jDLBMFNHBII_;
		}
		set
		{
			jDLBMFNHBII_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double HJLOLCGILJL
	{
		get
		{
			return hJLOLCGILJL_;
		}
		set
		{
			hJLOLCGILJL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Wave
	{
		get
		{
			return wave_;
		}
		set
		{
			wave_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IBFBGEFLOJK
	{
		get
		{
			return iBFBGEFLOJK_;
		}
		set
		{
			iBFBGEFLOJK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double MECHDOHDNFP
	{
		get
		{
			return mECHDOHDNFP_;
		}
		set
		{
			mECHDOHDNFP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double KAEMFEGJGMP
	{
		get
		{
			return kAEMFEGJGMP_;
		}
		set
		{
			kAEMFEGJGMP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HCIGONGJHEJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HCIGONGJHEJ(HCIGONGJHEJ other)
		: this()
	{
		ePDAFICMJAO_ = other.ePDAFICMJAO_;
		jDLBMFNHBII_ = other.jDLBMFNHBII_;
		hJLOLCGILJL_ = other.hJLOLCGILJL_;
		wave_ = other.wave_;
		iBFBGEFLOJK_ = other.iBFBGEFLOJK_;
		mECHDOHDNFP_ = other.mECHDOHDNFP_;
		kAEMFEGJGMP_ = other.kAEMFEGJGMP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HCIGONGJHEJ Clone()
	{
		return new HCIGONGJHEJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HCIGONGJHEJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HCIGONGJHEJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EPDAFICMJAO != other.EPDAFICMJAO)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(JDLBMFNHBII, other.JDLBMFNHBII))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(HJLOLCGILJL, other.HJLOLCGILJL))
		{
			return false;
		}
		if (Wave != other.Wave)
		{
			return false;
		}
		if (IBFBGEFLOJK != other.IBFBGEFLOJK)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MECHDOHDNFP, other.MECHDOHDNFP))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(KAEMFEGJGMP, other.KAEMFEGJGMP))
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
		if (EPDAFICMJAO != 0)
		{
			num ^= EPDAFICMJAO.GetHashCode();
		}
		if (JDLBMFNHBII != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(JDLBMFNHBII);
		}
		if (HJLOLCGILJL != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(HJLOLCGILJL);
		}
		if (Wave != 0)
		{
			num ^= Wave.GetHashCode();
		}
		if (IBFBGEFLOJK != 0)
		{
			num ^= IBFBGEFLOJK.GetHashCode();
		}
		if (MECHDOHDNFP != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MECHDOHDNFP);
		}
		if (KAEMFEGJGMP != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(KAEMFEGJGMP);
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
		if (EPDAFICMJAO != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(EPDAFICMJAO);
		}
		if (JDLBMFNHBII != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(JDLBMFNHBII);
		}
		if (HJLOLCGILJL != 0.0)
		{
			output.WriteRawTag(25);
			output.WriteDouble(HJLOLCGILJL);
		}
		if (Wave != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Wave);
		}
		if (IBFBGEFLOJK != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(IBFBGEFLOJK);
		}
		if (MECHDOHDNFP != 0.0)
		{
			output.WriteRawTag(49);
			output.WriteDouble(MECHDOHDNFP);
		}
		if (KAEMFEGJGMP != 0.0)
		{
			output.WriteRawTag(57);
			output.WriteDouble(KAEMFEGJGMP);
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
		if (EPDAFICMJAO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EPDAFICMJAO);
		}
		if (JDLBMFNHBII != 0.0)
		{
			num += 9;
		}
		if (HJLOLCGILJL != 0.0)
		{
			num += 9;
		}
		if (Wave != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Wave);
		}
		if (IBFBGEFLOJK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IBFBGEFLOJK);
		}
		if (MECHDOHDNFP != 0.0)
		{
			num += 9;
		}
		if (KAEMFEGJGMP != 0.0)
		{
			num += 9;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HCIGONGJHEJ other)
	{
		if (other != null)
		{
			if (other.EPDAFICMJAO != 0)
			{
				EPDAFICMJAO = other.EPDAFICMJAO;
			}
			if (other.JDLBMFNHBII != 0.0)
			{
				JDLBMFNHBII = other.JDLBMFNHBII;
			}
			if (other.HJLOLCGILJL != 0.0)
			{
				HJLOLCGILJL = other.HJLOLCGILJL;
			}
			if (other.Wave != 0)
			{
				Wave = other.Wave;
			}
			if (other.IBFBGEFLOJK != 0)
			{
				IBFBGEFLOJK = other.IBFBGEFLOJK;
			}
			if (other.MECHDOHDNFP != 0.0)
			{
				MECHDOHDNFP = other.MECHDOHDNFP;
			}
			if (other.KAEMFEGJGMP != 0.0)
			{
				KAEMFEGJGMP = other.KAEMFEGJGMP;
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
				EPDAFICMJAO = input.ReadUInt32();
				break;
			case 17u:
				JDLBMFNHBII = input.ReadDouble();
				break;
			case 25u:
				HJLOLCGILJL = input.ReadDouble();
				break;
			case 32u:
				Wave = input.ReadUInt32();
				break;
			case 40u:
				IBFBGEFLOJK = input.ReadUInt32();
				break;
			case 49u:
				MECHDOHDNFP = input.ReadDouble();
				break;
			case 57u:
				KAEMFEGJGMP = input.ReadDouble();
				break;
			}
		}
	}
}

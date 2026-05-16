using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IJOKCGLBBMI : IMessage<IJOKCGLBBMI>, IMessage, IEquatable<IJOKCGLBBMI>, IDeepCloneable<IJOKCGLBBMI>, IBufferMessage
{
	private static readonly MessageParser<IJOKCGLBBMI> _parser = new MessageParser<IJOKCGLBBMI>(() => new IJOKCGLBBMI());

	private UnknownFieldSet _unknownFields;

	public const int NEKJKMKEJLJFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_nEKJKMKEJLJ_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> nEKJKMKEJLJ_ = new RepeatedField<uint>();

	public const int JKPGACLKEECFieldNumber = 5;

	private uint jKPGACLKEEC_;

	public const int NHGPIMOFEKBFieldNumber = 7;

	private uint nHGPIMOFEKB_;

	public const int BICBJMPAAANFieldNumber = 9;

	private MLOFJFBHGLG bICBJMPAAAN_;

	public const int DHFKOKJIBNEFieldNumber = 10;

	private uint dHFKOKJIBNE_;

	public const int EJGNGLILFCPFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_eJGNGLILFCP_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> eJGNGLILFCP_ = new RepeatedField<uint>();

	public const int ELGOICHACDNFieldNumber = 15;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_eLGOICHACDN_codec = FieldCodec.ForMessage(122u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> eLGOICHACDN_ = new RepeatedField<GKDEKJKOIJN>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IJOKCGLBBMI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IJOKCGLBBMIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NEKJKMKEJLJ => nEKJKMKEJLJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JKPGACLKEEC
	{
		get
		{
			return jKPGACLKEEC_;
		}
		set
		{
			jKPGACLKEEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NHGPIMOFEKB
	{
		get
		{
			return nHGPIMOFEKB_;
		}
		set
		{
			nHGPIMOFEKB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MLOFJFBHGLG BICBJMPAAAN
	{
		get
		{
			return bICBJMPAAAN_;
		}
		set
		{
			bICBJMPAAAN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DHFKOKJIBNE
	{
		get
		{
			return dHFKOKJIBNE_;
		}
		set
		{
			dHFKOKJIBNE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EJGNGLILFCP => eJGNGLILFCP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> ELGOICHACDN => eLGOICHACDN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IJOKCGLBBMI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IJOKCGLBBMI(IJOKCGLBBMI other)
		: this()
	{
		nEKJKMKEJLJ_ = other.nEKJKMKEJLJ_.Clone();
		jKPGACLKEEC_ = other.jKPGACLKEEC_;
		nHGPIMOFEKB_ = other.nHGPIMOFEKB_;
		bICBJMPAAAN_ = other.bICBJMPAAAN_;
		dHFKOKJIBNE_ = other.dHFKOKJIBNE_;
		eJGNGLILFCP_ = other.eJGNGLILFCP_.Clone();
		eLGOICHACDN_ = other.eLGOICHACDN_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IJOKCGLBBMI Clone()
	{
		return new IJOKCGLBBMI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IJOKCGLBBMI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IJOKCGLBBMI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!nEKJKMKEJLJ_.Equals(other.nEKJKMKEJLJ_))
		{
			return false;
		}
		if (JKPGACLKEEC != other.JKPGACLKEEC)
		{
			return false;
		}
		if (NHGPIMOFEKB != other.NHGPIMOFEKB)
		{
			return false;
		}
		if (BICBJMPAAAN != other.BICBJMPAAAN)
		{
			return false;
		}
		if (DHFKOKJIBNE != other.DHFKOKJIBNE)
		{
			return false;
		}
		if (!eJGNGLILFCP_.Equals(other.eJGNGLILFCP_))
		{
			return false;
		}
		if (!eLGOICHACDN_.Equals(other.eLGOICHACDN_))
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
		num ^= nEKJKMKEJLJ_.GetHashCode();
		if (JKPGACLKEEC != 0)
		{
			num ^= JKPGACLKEEC.GetHashCode();
		}
		if (NHGPIMOFEKB != 0)
		{
			num ^= NHGPIMOFEKB.GetHashCode();
		}
		if (BICBJMPAAAN != MLOFJFBHGLG.Kbdoljnphnc)
		{
			num ^= BICBJMPAAAN.GetHashCode();
		}
		if (DHFKOKJIBNE != 0)
		{
			num ^= DHFKOKJIBNE.GetHashCode();
		}
		num ^= eJGNGLILFCP_.GetHashCode();
		num ^= eLGOICHACDN_.GetHashCode();
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
		nEKJKMKEJLJ_.WriteTo(ref output, _repeated_nEKJKMKEJLJ_codec);
		if (JKPGACLKEEC != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(JKPGACLKEEC);
		}
		if (NHGPIMOFEKB != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(NHGPIMOFEKB);
		}
		if (BICBJMPAAAN != MLOFJFBHGLG.Kbdoljnphnc)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)BICBJMPAAAN);
		}
		if (DHFKOKJIBNE != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(DHFKOKJIBNE);
		}
		eJGNGLILFCP_.WriteTo(ref output, _repeated_eJGNGLILFCP_codec);
		eLGOICHACDN_.WriteTo(ref output, _repeated_eLGOICHACDN_codec);
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
		num += nEKJKMKEJLJ_.CalculateSize(_repeated_nEKJKMKEJLJ_codec);
		if (JKPGACLKEEC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JKPGACLKEEC);
		}
		if (NHGPIMOFEKB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NHGPIMOFEKB);
		}
		if (BICBJMPAAAN != MLOFJFBHGLG.Kbdoljnphnc)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BICBJMPAAAN);
		}
		if (DHFKOKJIBNE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DHFKOKJIBNE);
		}
		num += eJGNGLILFCP_.CalculateSize(_repeated_eJGNGLILFCP_codec);
		num += eLGOICHACDN_.CalculateSize(_repeated_eLGOICHACDN_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IJOKCGLBBMI other)
	{
		if (other != null)
		{
			nEKJKMKEJLJ_.Add(other.nEKJKMKEJLJ_);
			if (other.JKPGACLKEEC != 0)
			{
				JKPGACLKEEC = other.JKPGACLKEEC;
			}
			if (other.NHGPIMOFEKB != 0)
			{
				NHGPIMOFEKB = other.NHGPIMOFEKB;
			}
			if (other.BICBJMPAAAN != MLOFJFBHGLG.Kbdoljnphnc)
			{
				BICBJMPAAAN = other.BICBJMPAAAN;
			}
			if (other.DHFKOKJIBNE != 0)
			{
				DHFKOKJIBNE = other.DHFKOKJIBNE;
			}
			eJGNGLILFCP_.Add(other.eJGNGLILFCP_);
			eLGOICHACDN_.Add(other.eLGOICHACDN_);
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
			case 10u:
				nEKJKMKEJLJ_.AddEntriesFrom(ref input, _repeated_nEKJKMKEJLJ_codec);
				break;
			case 40u:
				JKPGACLKEEC = input.ReadUInt32();
				break;
			case 56u:
				NHGPIMOFEKB = input.ReadUInt32();
				break;
			case 72u:
				BICBJMPAAAN = (MLOFJFBHGLG)input.ReadEnum();
				break;
			case 80u:
				DHFKOKJIBNE = input.ReadUInt32();
				break;
			case 104u:
			case 106u:
				eJGNGLILFCP_.AddEntriesFrom(ref input, _repeated_eJGNGLILFCP_codec);
				break;
			case 122u:
				eLGOICHACDN_.AddEntriesFrom(ref input, _repeated_eLGOICHACDN_codec);
				break;
			}
		}
	}
}

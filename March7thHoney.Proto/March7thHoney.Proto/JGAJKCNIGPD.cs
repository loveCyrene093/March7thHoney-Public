using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JGAJKCNIGPD : IMessage<JGAJKCNIGPD>, IMessage, IEquatable<JGAJKCNIGPD>, IDeepCloneable<JGAJKCNIGPD>, IBufferMessage
{
	private static readonly MessageParser<JGAJKCNIGPD> _parser = new MessageParser<JGAJKCNIGPD>(() => new JGAJKCNIGPD());

	private UnknownFieldSet _unknownFields;

	public const int BICBJMPAAANFieldNumber = 1;

	private MLOFJFBHGLG bICBJMPAAAN_;

	public const int OMFKIFADFOCFieldNumber = 5;

	private bool oMFKIFADFOC_;

	public const int JKPGACLKEECFieldNumber = 8;

	private ulong jKPGACLKEEC_;

	public const int BIODAJLLINOFieldNumber = 11;

	private bool bIODAJLLINO_;

	public const int DamageFieldNumber = 15;

	private uint damage_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JGAJKCNIGPD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JGAJKCNIGPDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public bool OMFKIFADFOC
	{
		get
		{
			return oMFKIFADFOC_;
		}
		set
		{
			oMFKIFADFOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong JKPGACLKEEC
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
	public bool BIODAJLLINO
	{
		get
		{
			return bIODAJLLINO_;
		}
		set
		{
			bIODAJLLINO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Damage
	{
		get
		{
			return damage_;
		}
		set
		{
			damage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JGAJKCNIGPD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JGAJKCNIGPD(JGAJKCNIGPD other)
		: this()
	{
		bICBJMPAAAN_ = other.bICBJMPAAAN_;
		oMFKIFADFOC_ = other.oMFKIFADFOC_;
		jKPGACLKEEC_ = other.jKPGACLKEEC_;
		bIODAJLLINO_ = other.bIODAJLLINO_;
		damage_ = other.damage_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JGAJKCNIGPD Clone()
	{
		return new JGAJKCNIGPD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JGAJKCNIGPD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JGAJKCNIGPD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BICBJMPAAAN != other.BICBJMPAAAN)
		{
			return false;
		}
		if (OMFKIFADFOC != other.OMFKIFADFOC)
		{
			return false;
		}
		if (JKPGACLKEEC != other.JKPGACLKEEC)
		{
			return false;
		}
		if (BIODAJLLINO != other.BIODAJLLINO)
		{
			return false;
		}
		if (Damage != other.Damage)
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
		if (BICBJMPAAAN != MLOFJFBHGLG.Kbdoljnphnc)
		{
			num ^= BICBJMPAAAN.GetHashCode();
		}
		if (OMFKIFADFOC)
		{
			num ^= OMFKIFADFOC.GetHashCode();
		}
		if (JKPGACLKEEC != 0L)
		{
			num ^= JKPGACLKEEC.GetHashCode();
		}
		if (BIODAJLLINO)
		{
			num ^= BIODAJLLINO.GetHashCode();
		}
		if (Damage != 0)
		{
			num ^= Damage.GetHashCode();
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
		if (BICBJMPAAAN != MLOFJFBHGLG.Kbdoljnphnc)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)BICBJMPAAAN);
		}
		if (OMFKIFADFOC)
		{
			output.WriteRawTag(40);
			output.WriteBool(OMFKIFADFOC);
		}
		if (JKPGACLKEEC != 0L)
		{
			output.WriteRawTag(64);
			output.WriteUInt64(JKPGACLKEEC);
		}
		if (BIODAJLLINO)
		{
			output.WriteRawTag(88);
			output.WriteBool(BIODAJLLINO);
		}
		if (Damage != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Damage);
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
		if (BICBJMPAAAN != MLOFJFBHGLG.Kbdoljnphnc)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BICBJMPAAAN);
		}
		if (OMFKIFADFOC)
		{
			num += 2;
		}
		if (JKPGACLKEEC != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(JKPGACLKEEC);
		}
		if (BIODAJLLINO)
		{
			num += 2;
		}
		if (Damage != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Damage);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JGAJKCNIGPD other)
	{
		if (other != null)
		{
			if (other.BICBJMPAAAN != MLOFJFBHGLG.Kbdoljnphnc)
			{
				BICBJMPAAAN = other.BICBJMPAAAN;
			}
			if (other.OMFKIFADFOC)
			{
				OMFKIFADFOC = other.OMFKIFADFOC;
			}
			if (other.JKPGACLKEEC != 0L)
			{
				JKPGACLKEEC = other.JKPGACLKEEC;
			}
			if (other.BIODAJLLINO)
			{
				BIODAJLLINO = other.BIODAJLLINO;
			}
			if (other.Damage != 0)
			{
				Damage = other.Damage;
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
				BICBJMPAAAN = (MLOFJFBHGLG)input.ReadEnum();
				break;
			case 40u:
				OMFKIFADFOC = input.ReadBool();
				break;
			case 64u:
				JKPGACLKEEC = input.ReadUInt64();
				break;
			case 88u:
				BIODAJLLINO = input.ReadBool();
				break;
			case 120u:
				Damage = input.ReadUInt32();
				break;
			}
		}
	}
}

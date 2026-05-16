using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HFHMIKIFLPO : IMessage<HFHMIKIFLPO>, IMessage, IEquatable<HFHMIKIFLPO>, IDeepCloneable<HFHMIKIFLPO>, IBufferMessage
{
	private static readonly MessageParser<HFHMIKIFLPO> _parser = new MessageParser<HFHMIKIFLPO>(() => new HFHMIKIFLPO());

	private UnknownFieldSet _unknownFields;

	public const int AvatarIdFieldNumber = 3;

	private uint avatarId_;

	public const int LevelFieldNumber = 12;

	private uint level_;

	public const int RoleStarFieldNumber = 13;

	private uint roleStar_;

	public const int JLHPIMJPDLOFieldNumber = 14;

	private uint jLHPIMJPDLO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HFHMIKIFLPO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HFHMIKIFLPOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
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
	public uint RoleStar
	{
		get
		{
			return roleStar_;
		}
		set
		{
			roleStar_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JLHPIMJPDLO
	{
		get
		{
			return jLHPIMJPDLO_;
		}
		set
		{
			jLHPIMJPDLO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HFHMIKIFLPO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HFHMIKIFLPO(HFHMIKIFLPO other)
		: this()
	{
		avatarId_ = other.avatarId_;
		level_ = other.level_;
		roleStar_ = other.roleStar_;
		jLHPIMJPDLO_ = other.jLHPIMJPDLO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HFHMIKIFLPO Clone()
	{
		return new HFHMIKIFLPO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HFHMIKIFLPO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HFHMIKIFLPO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (RoleStar != other.RoleStar)
		{
			return false;
		}
		if (JLHPIMJPDLO != other.JLHPIMJPDLO)
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
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (RoleStar != 0)
		{
			num ^= RoleStar.GetHashCode();
		}
		if (JLHPIMJPDLO != 0)
		{
			num ^= JLHPIMJPDLO.GetHashCode();
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
		if (AvatarId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(AvatarId);
		}
		if (Level != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Level);
		}
		if (RoleStar != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(RoleStar);
		}
		if (JLHPIMJPDLO != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(JLHPIMJPDLO);
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
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (RoleStar != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoleStar);
		}
		if (JLHPIMJPDLO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JLHPIMJPDLO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HFHMIKIFLPO other)
	{
		if (other != null)
		{
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.RoleStar != 0)
			{
				RoleStar = other.RoleStar;
			}
			if (other.JLHPIMJPDLO != 0)
			{
				JLHPIMJPDLO = other.JLHPIMJPDLO;
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
			case 24u:
				AvatarId = input.ReadUInt32();
				break;
			case 96u:
				Level = input.ReadUInt32();
				break;
			case 104u:
				RoleStar = input.ReadUInt32();
				break;
			case 112u:
				JLHPIMJPDLO = input.ReadUInt32();
				break;
			}
		}
	}
}

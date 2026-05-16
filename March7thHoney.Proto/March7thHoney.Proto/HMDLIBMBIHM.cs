using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HMDLIBMBIHM : IMessage<HMDLIBMBIHM>, IMessage, IEquatable<HMDLIBMBIHM>, IDeepCloneable<HMDLIBMBIHM>, IBufferMessage
{
	private static readonly MessageParser<HMDLIBMBIHM> _parser = new MessageParser<HMDLIBMBIHM>(() => new HMDLIBMBIHM());

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 8;

	private uint level_;

	public const int AvatarTypeFieldNumber = 11;

	private AvatarType avatarType_;

	public const int IdFieldNumber = 14;

	private uint id_;

	public const int JLFLCDCGCOLFieldNumber = 15;

	private bool jLFLCDCGCOL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HMDLIBMBIHM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HMDLIBMBIHMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public AvatarType AvatarType
	{
		get
		{
			return avatarType_;
		}
		set
		{
			avatarType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JLFLCDCGCOL
	{
		get
		{
			return jLFLCDCGCOL_;
		}
		set
		{
			jLFLCDCGCOL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMDLIBMBIHM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMDLIBMBIHM(HMDLIBMBIHM other)
		: this()
	{
		level_ = other.level_;
		avatarType_ = other.avatarType_;
		id_ = other.id_;
		jLFLCDCGCOL_ = other.jLFLCDCGCOL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMDLIBMBIHM Clone()
	{
		return new HMDLIBMBIHM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HMDLIBMBIHM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HMDLIBMBIHM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (AvatarType != other.AvatarType)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (JLFLCDCGCOL != other.JLFLCDCGCOL)
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
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (AvatarType != AvatarType.None)
		{
			num ^= AvatarType.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (JLFLCDCGCOL)
		{
			num ^= JLFLCDCGCOL.GetHashCode();
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
		if (Level != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Level);
		}
		if (AvatarType != AvatarType.None)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)AvatarType);
		}
		if (Id != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Id);
		}
		if (JLFLCDCGCOL)
		{
			output.WriteRawTag(120);
			output.WriteBool(JLFLCDCGCOL);
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
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (AvatarType != AvatarType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AvatarType);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (JLFLCDCGCOL)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HMDLIBMBIHM other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.AvatarType != AvatarType.None)
			{
				AvatarType = other.AvatarType;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.JLFLCDCGCOL)
			{
				JLFLCDCGCOL = other.JLFLCDCGCOL;
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
			case 64u:
				Level = input.ReadUInt32();
				break;
			case 88u:
				AvatarType = (AvatarType)input.ReadEnum();
				break;
			case 112u:
				Id = input.ReadUInt32();
				break;
			case 120u:
				JLFLCDCGCOL = input.ReadBool();
				break;
			}
		}
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PGLFACHCGCB : IMessage<PGLFACHCGCB>, IMessage, IEquatable<PGLFACHCGCB>, IDeepCloneable<PGLFACHCGCB>, IBufferMessage
{
	private static readonly MessageParser<PGLFACHCGCB> _parser = new MessageParser<PGLFACHCGCB>(() => new PGLFACHCGCB());

	private UnknownFieldSet _unknownFields;

	public const int SubAffixListFieldNumber = 2;

	private static readonly FieldCodec<RelicAffix> _repeated_subAffixList_codec = FieldCodec.ForMessage(18u, RelicAffix.Parser);

	private readonly RepeatedField<RelicAffix> subAffixList_ = new RepeatedField<RelicAffix>();

	public const int MainAffixIdFieldNumber = 4;

	private uint mainAffixId_;

	public const int ExpFieldNumber = 6;

	private uint exp_;

	public const int TidFieldNumber = 10;

	private uint tid_;

	public const int TypeFieldNumber = 11;

	private uint type_;

	public const int LevelFieldNumber = 12;

	private uint level_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PGLFACHCGCB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PGLFACHCGCBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<RelicAffix> SubAffixList => subAffixList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MainAffixId
	{
		get
		{
			return mainAffixId_;
		}
		set
		{
			mainAffixId_ = value;
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
	public uint Tid
	{
		get
		{
			return tid_;
		}
		set
		{
			tid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
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
	public PGLFACHCGCB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGLFACHCGCB(PGLFACHCGCB other)
		: this()
	{
		subAffixList_ = other.subAffixList_.Clone();
		mainAffixId_ = other.mainAffixId_;
		exp_ = other.exp_;
		tid_ = other.tid_;
		type_ = other.type_;
		level_ = other.level_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGLFACHCGCB Clone()
	{
		return new PGLFACHCGCB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PGLFACHCGCB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PGLFACHCGCB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!subAffixList_.Equals(other.subAffixList_))
		{
			return false;
		}
		if (MainAffixId != other.MainAffixId)
		{
			return false;
		}
		if (Exp != other.Exp)
		{
			return false;
		}
		if (Tid != other.Tid)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (Level != other.Level)
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
		num ^= subAffixList_.GetHashCode();
		if (MainAffixId != 0)
		{
			num ^= MainAffixId.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		if (Tid != 0)
		{
			num ^= Tid.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
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
		subAffixList_.WriteTo(ref output, _repeated_subAffixList_codec);
		if (MainAffixId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MainAffixId);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Exp);
		}
		if (Tid != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Tid);
		}
		if (Type != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Type);
		}
		if (Level != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Level);
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
		num += subAffixList_.CalculateSize(_repeated_subAffixList_codec);
		if (MainAffixId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MainAffixId);
		}
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		if (Tid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Tid);
		}
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Type);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PGLFACHCGCB other)
	{
		if (other != null)
		{
			subAffixList_.Add(other.subAffixList_);
			if (other.MainAffixId != 0)
			{
				MainAffixId = other.MainAffixId;
			}
			if (other.Exp != 0)
			{
				Exp = other.Exp;
			}
			if (other.Tid != 0)
			{
				Tid = other.Tid;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
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
			case 18u:
				subAffixList_.AddEntriesFrom(ref input, _repeated_subAffixList_codec);
				break;
			case 32u:
				MainAffixId = input.ReadUInt32();
				break;
			case 48u:
				Exp = input.ReadUInt32();
				break;
			case 80u:
				Tid = input.ReadUInt32();
				break;
			case 88u:
				Type = input.ReadUInt32();
				break;
			case 96u:
				Level = input.ReadUInt32();
				break;
			}
		}
	}
}

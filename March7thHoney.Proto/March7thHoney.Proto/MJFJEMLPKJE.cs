using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MJFJEMLPKJE : IMessage<MJFJEMLPKJE>, IMessage, IEquatable<MJFJEMLPKJE>, IDeepCloneable<MJFJEMLPKJE>, IBufferMessage
{
	private static readonly MessageParser<MJFJEMLPKJE> _parser = new MessageParser<MJFJEMLPKJE>(() => new MJFJEMLPKJE());

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 1;

	private uint level_;

	public const int ExpFieldNumber = 3;

	private uint exp_;

	public const int MainAffixIdFieldNumber = 7;

	private uint mainAffixId_;

	public const int TidFieldNumber = 13;

	private uint tid_;

	public const int SubAffixListFieldNumber = 15;

	private static readonly FieldCodec<RelicAffix> _repeated_subAffixList_codec = FieldCodec.ForMessage(122u, RelicAffix.Parser);

	private readonly RepeatedField<RelicAffix> subAffixList_ = new RepeatedField<RelicAffix>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MJFJEMLPKJE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MJFJEMLPKJEReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<RelicAffix> SubAffixList => subAffixList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJFJEMLPKJE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJFJEMLPKJE(MJFJEMLPKJE other)
		: this()
	{
		level_ = other.level_;
		exp_ = other.exp_;
		mainAffixId_ = other.mainAffixId_;
		tid_ = other.tid_;
		subAffixList_ = other.subAffixList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJFJEMLPKJE Clone()
	{
		return new MJFJEMLPKJE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MJFJEMLPKJE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MJFJEMLPKJE other)
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
		if (Exp != other.Exp)
		{
			return false;
		}
		if (MainAffixId != other.MainAffixId)
		{
			return false;
		}
		if (Tid != other.Tid)
		{
			return false;
		}
		if (!subAffixList_.Equals(other.subAffixList_))
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
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		if (MainAffixId != 0)
		{
			num ^= MainAffixId.GetHashCode();
		}
		if (Tid != 0)
		{
			num ^= Tid.GetHashCode();
		}
		num ^= subAffixList_.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(Level);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Exp);
		}
		if (MainAffixId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(MainAffixId);
		}
		if (Tid != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Tid);
		}
		subAffixList_.WriteTo(ref output, _repeated_subAffixList_codec);
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
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		if (MainAffixId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MainAffixId);
		}
		if (Tid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Tid);
		}
		num += subAffixList_.CalculateSize(_repeated_subAffixList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MJFJEMLPKJE other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.Exp != 0)
			{
				Exp = other.Exp;
			}
			if (other.MainAffixId != 0)
			{
				MainAffixId = other.MainAffixId;
			}
			if (other.Tid != 0)
			{
				Tid = other.Tid;
			}
			subAffixList_.Add(other.subAffixList_);
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
				Level = input.ReadUInt32();
				break;
			case 24u:
				Exp = input.ReadUInt32();
				break;
			case 56u:
				MainAffixId = input.ReadUInt32();
				break;
			case 104u:
				Tid = input.ReadUInt32();
				break;
			case 122u:
				subAffixList_.AddEntriesFrom(ref input, _repeated_subAffixList_codec);
				break;
			}
		}
	}
}

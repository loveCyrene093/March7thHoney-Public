using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PLDMGGBPHPB : IMessage<PLDMGGBPHPB>, IMessage, IEquatable<PLDMGGBPHPB>, IDeepCloneable<PLDMGGBPHPB>, IBufferMessage
{
	private static readonly MessageParser<PLDMGGBPHPB> _parser = new MessageParser<PLDMGGBPHPB>(() => new PLDMGGBPHPB());

	private UnknownFieldSet _unknownFields;

	public const int SkillIdFieldNumber = 1;

	private uint skillId_;

	public const int JHFKANKGLJNFieldNumber = 2;

	private double jHFKANKGLJN_;

	public const int BattleTargetListFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_battleTargetList_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> battleTargetList_ = new RepeatedField<uint>();

	public const int DamageFieldNumber = 4;

	private double damage_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PLDMGGBPHPB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PLDMGGBPHPBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SkillId
	{
		get
		{
			return skillId_;
		}
		set
		{
			skillId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double JHFKANKGLJN
	{
		get
		{
			return jHFKANKGLJN_;
		}
		set
		{
			jHFKANKGLJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BattleTargetList => battleTargetList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double Damage
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
	public PLDMGGBPHPB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLDMGGBPHPB(PLDMGGBPHPB other)
		: this()
	{
		skillId_ = other.skillId_;
		jHFKANKGLJN_ = other.jHFKANKGLJN_;
		battleTargetList_ = other.battleTargetList_.Clone();
		damage_ = other.damage_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLDMGGBPHPB Clone()
	{
		return new PLDMGGBPHPB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PLDMGGBPHPB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PLDMGGBPHPB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SkillId != other.SkillId)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(JHFKANKGLJN, other.JHFKANKGLJN))
		{
			return false;
		}
		if (!battleTargetList_.Equals(other.battleTargetList_))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Damage, other.Damage))
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
		if (SkillId != 0)
		{
			num ^= SkillId.GetHashCode();
		}
		if (JHFKANKGLJN != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(JHFKANKGLJN);
		}
		num ^= battleTargetList_.GetHashCode();
		if (Damage != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Damage);
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
		if (SkillId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(SkillId);
		}
		if (JHFKANKGLJN != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(JHFKANKGLJN);
		}
		battleTargetList_.WriteTo(ref output, _repeated_battleTargetList_codec);
		if (Damage != 0.0)
		{
			output.WriteRawTag(33);
			output.WriteDouble(Damage);
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
		if (SkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SkillId);
		}
		if (JHFKANKGLJN != 0.0)
		{
			num += 9;
		}
		num += battleTargetList_.CalculateSize(_repeated_battleTargetList_codec);
		if (Damage != 0.0)
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
	public void MergeFrom(PLDMGGBPHPB other)
	{
		if (other != null)
		{
			if (other.SkillId != 0)
			{
				SkillId = other.SkillId;
			}
			if (other.JHFKANKGLJN != 0.0)
			{
				JHFKANKGLJN = other.JHFKANKGLJN;
			}
			battleTargetList_.Add(other.battleTargetList_);
			if (other.Damage != 0.0)
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
				SkillId = input.ReadUInt32();
				break;
			case 17u:
				JHFKANKGLJN = input.ReadDouble();
				break;
			case 24u:
			case 26u:
				battleTargetList_.AddEntriesFrom(ref input, _repeated_battleTargetList_codec);
				break;
			case 33u:
				Damage = input.ReadDouble();
				break;
			}
		}
	}
}

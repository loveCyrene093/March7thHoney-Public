using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AvatarProperty : IMessage<AvatarProperty>, IMessage, IEquatable<AvatarProperty>, IDeepCloneable<AvatarProperty>, IBufferMessage
{
	private static readonly MessageParser<AvatarProperty> _parser = new MessageParser<AvatarProperty>(() => new AvatarProperty());

	private UnknownFieldSet _unknownFields;

	public const int MaxHpFieldNumber = 1;

	private double maxHp_;

	public const int AttackFieldNumber = 2;

	private double attack_;

	public const int DefenceFieldNumber = 3;

	private double defence_;

	public const int SpeedFieldNumber = 4;

	private double speed_;

	public const int LeftHpFieldNumber = 5;

	private double leftHp_;

	public const int LeftSpFieldNumber = 6;

	private double leftSp_;

	public const int MaxSpFieldNumber = 7;

	private double maxSp_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AvatarProperty> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AvatarPropertyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double MaxHp
	{
		get
		{
			return maxHp_;
		}
		set
		{
			maxHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double Attack
	{
		get
		{
			return attack_;
		}
		set
		{
			attack_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double Defence
	{
		get
		{
			return defence_;
		}
		set
		{
			defence_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double Speed
	{
		get
		{
			return speed_;
		}
		set
		{
			speed_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double LeftHp
	{
		get
		{
			return leftHp_;
		}
		set
		{
			leftHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double LeftSp
	{
		get
		{
			return leftSp_;
		}
		set
		{
			leftSp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double MaxSp
	{
		get
		{
			return maxSp_;
		}
		set
		{
			maxSp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarProperty()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarProperty(AvatarProperty other)
		: this()
	{
		maxHp_ = other.maxHp_;
		attack_ = other.attack_;
		defence_ = other.defence_;
		speed_ = other.speed_;
		leftHp_ = other.leftHp_;
		leftSp_ = other.leftSp_;
		maxSp_ = other.maxSp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AvatarProperty Clone()
	{
		return new AvatarProperty(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AvatarProperty);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AvatarProperty other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MaxHp, other.MaxHp))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Attack, other.Attack))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Defence, other.Defence))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Speed, other.Speed))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(LeftHp, other.LeftHp))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(LeftSp, other.LeftSp))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MaxSp, other.MaxSp))
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
		if (MaxHp != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MaxHp);
		}
		if (Attack != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Attack);
		}
		if (Defence != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Defence);
		}
		if (Speed != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Speed);
		}
		if (LeftHp != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(LeftHp);
		}
		if (LeftSp != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(LeftSp);
		}
		if (MaxSp != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MaxSp);
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
		if (MaxHp != 0.0)
		{
			output.WriteRawTag(9);
			output.WriteDouble(MaxHp);
		}
		if (Attack != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(Attack);
		}
		if (Defence != 0.0)
		{
			output.WriteRawTag(25);
			output.WriteDouble(Defence);
		}
		if (Speed != 0.0)
		{
			output.WriteRawTag(33);
			output.WriteDouble(Speed);
		}
		if (LeftHp != 0.0)
		{
			output.WriteRawTag(41);
			output.WriteDouble(LeftHp);
		}
		if (LeftSp != 0.0)
		{
			output.WriteRawTag(49);
			output.WriteDouble(LeftSp);
		}
		if (MaxSp != 0.0)
		{
			output.WriteRawTag(57);
			output.WriteDouble(MaxSp);
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
		if (MaxHp != 0.0)
		{
			num += 9;
		}
		if (Attack != 0.0)
		{
			num += 9;
		}
		if (Defence != 0.0)
		{
			num += 9;
		}
		if (Speed != 0.0)
		{
			num += 9;
		}
		if (LeftHp != 0.0)
		{
			num += 9;
		}
		if (LeftSp != 0.0)
		{
			num += 9;
		}
		if (MaxSp != 0.0)
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
	public void MergeFrom(AvatarProperty other)
	{
		if (other != null)
		{
			if (other.MaxHp != 0.0)
			{
				MaxHp = other.MaxHp;
			}
			if (other.Attack != 0.0)
			{
				Attack = other.Attack;
			}
			if (other.Defence != 0.0)
			{
				Defence = other.Defence;
			}
			if (other.Speed != 0.0)
			{
				Speed = other.Speed;
			}
			if (other.LeftHp != 0.0)
			{
				LeftHp = other.LeftHp;
			}
			if (other.LeftSp != 0.0)
			{
				LeftSp = other.LeftSp;
			}
			if (other.MaxSp != 0.0)
			{
				MaxSp = other.MaxSp;
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
			case 9u:
				MaxHp = input.ReadDouble();
				break;
			case 17u:
				Attack = input.ReadDouble();
				break;
			case 25u:
				Defence = input.ReadDouble();
				break;
			case 33u:
				Speed = input.ReadDouble();
				break;
			case 41u:
				LeftHp = input.ReadDouble();
				break;
			case 49u:
				LeftSp = input.ReadDouble();
				break;
			case 57u:
				MaxSp = input.ReadDouble();
				break;
			}
		}
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AMBFIEKDCEL : IMessage<AMBFIEKDCEL>, IMessage, IEquatable<AMBFIEKDCEL>, IDeepCloneable<AMBFIEKDCEL>, IBufferMessage
{
	private static readonly MessageParser<AMBFIEKDCEL> _parser = new MessageParser<AMBFIEKDCEL>(() => new AMBFIEKDCEL());

	private UnknownFieldSet _unknownFields;

	public const int MaxHpFieldNumber = 1;

	private double maxHp_;

	public const int AttackFieldNumber = 2;

	private double attack_;

	public const int DefenceFieldNumber = 3;

	private double defence_;

	public const int MAAHELIACOJFieldNumber = 4;

	private double mAAHELIACOJ_;

	public const int SpeedFieldNumber = 5;

	private double speed_;

	public const int LeftHpFieldNumber = 6;

	private double leftHp_;

	public const int KEJCBOAPDDBFieldNumber = 7;

	private double kEJCBOAPDDB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AMBFIEKDCEL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AMBFIEKDCELReflection.Descriptor.MessageTypes[0];

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
	public double MAAHELIACOJ
	{
		get
		{
			return mAAHELIACOJ_;
		}
		set
		{
			mAAHELIACOJ_ = value;
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
	public double KEJCBOAPDDB
	{
		get
		{
			return kEJCBOAPDDB_;
		}
		set
		{
			kEJCBOAPDDB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AMBFIEKDCEL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AMBFIEKDCEL(AMBFIEKDCEL other)
		: this()
	{
		maxHp_ = other.maxHp_;
		attack_ = other.attack_;
		defence_ = other.defence_;
		mAAHELIACOJ_ = other.mAAHELIACOJ_;
		speed_ = other.speed_;
		leftHp_ = other.leftHp_;
		kEJCBOAPDDB_ = other.kEJCBOAPDDB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AMBFIEKDCEL Clone()
	{
		return new AMBFIEKDCEL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AMBFIEKDCEL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AMBFIEKDCEL other)
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
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MAAHELIACOJ, other.MAAHELIACOJ))
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
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(KEJCBOAPDDB, other.KEJCBOAPDDB))
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
		if (MAAHELIACOJ != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MAAHELIACOJ);
		}
		if (Speed != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Speed);
		}
		if (LeftHp != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(LeftHp);
		}
		if (KEJCBOAPDDB != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(KEJCBOAPDDB);
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
		if (MAAHELIACOJ != 0.0)
		{
			output.WriteRawTag(33);
			output.WriteDouble(MAAHELIACOJ);
		}
		if (Speed != 0.0)
		{
			output.WriteRawTag(41);
			output.WriteDouble(Speed);
		}
		if (LeftHp != 0.0)
		{
			output.WriteRawTag(49);
			output.WriteDouble(LeftHp);
		}
		if (KEJCBOAPDDB != 0.0)
		{
			output.WriteRawTag(57);
			output.WriteDouble(KEJCBOAPDDB);
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
		if (MAAHELIACOJ != 0.0)
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
		if (KEJCBOAPDDB != 0.0)
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
	public void MergeFrom(AMBFIEKDCEL other)
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
			if (other.MAAHELIACOJ != 0.0)
			{
				MAAHELIACOJ = other.MAAHELIACOJ;
			}
			if (other.Speed != 0.0)
			{
				Speed = other.Speed;
			}
			if (other.LeftHp != 0.0)
			{
				LeftHp = other.LeftHp;
			}
			if (other.KEJCBOAPDDB != 0.0)
			{
				KEJCBOAPDDB = other.KEJCBOAPDDB;
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
				MAAHELIACOJ = input.ReadDouble();
				break;
			case 41u:
				Speed = input.ReadDouble();
				break;
			case 49u:
				LeftHp = input.ReadDouble();
				break;
			case 57u:
				KEJCBOAPDDB = input.ReadDouble();
				break;
			}
		}
	}
}

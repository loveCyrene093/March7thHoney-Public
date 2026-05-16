using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IMPEJAJCHPC : IMessage<IMPEJAJCHPC>, IMessage, IEquatable<IMPEJAJCHPC>, IDeepCloneable<IMPEJAJCHPC>, IBufferMessage
{
	private static readonly MessageParser<IMPEJAJCHPC> _parser = new MessageParser<IMPEJAJCHPC>(() => new IMPEJAJCHPC());

	private UnknownFieldSet _unknownFields;

	public const int AugmentIdFieldNumber = 1;

	private uint augmentId_;

	public const int DamageFieldNumber = 3;

	private double damage_;

	public const int BOIEGPAPHOPFieldNumber = 4;

	private double bOIEGPAPHOP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IMPEJAJCHPC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IMPEJAJCHPCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AugmentId
	{
		get
		{
			return augmentId_;
		}
		set
		{
			augmentId_ = value;
		}
	}

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
	public double BOIEGPAPHOP
	{
		get
		{
			return bOIEGPAPHOP_;
		}
		set
		{
			bOIEGPAPHOP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IMPEJAJCHPC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IMPEJAJCHPC(IMPEJAJCHPC other)
		: this()
	{
		augmentId_ = other.augmentId_;
		damage_ = other.damage_;
		bOIEGPAPHOP_ = other.bOIEGPAPHOP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IMPEJAJCHPC Clone()
	{
		return new IMPEJAJCHPC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IMPEJAJCHPC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IMPEJAJCHPC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AugmentId != other.AugmentId)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Damage, other.Damage))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(BOIEGPAPHOP, other.BOIEGPAPHOP))
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
		if (AugmentId != 0)
		{
			num ^= AugmentId.GetHashCode();
		}
		if (Damage != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Damage);
		}
		if (BOIEGPAPHOP != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(BOIEGPAPHOP);
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
		if (AugmentId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(AugmentId);
		}
		if (Damage != 0.0)
		{
			output.WriteRawTag(25);
			output.WriteDouble(Damage);
		}
		if (BOIEGPAPHOP != 0.0)
		{
			output.WriteRawTag(33);
			output.WriteDouble(BOIEGPAPHOP);
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
		if (AugmentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AugmentId);
		}
		if (Damage != 0.0)
		{
			num += 9;
		}
		if (BOIEGPAPHOP != 0.0)
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
	public void MergeFrom(IMPEJAJCHPC other)
	{
		if (other != null)
		{
			if (other.AugmentId != 0)
			{
				AugmentId = other.AugmentId;
			}
			if (other.Damage != 0.0)
			{
				Damage = other.Damage;
			}
			if (other.BOIEGPAPHOP != 0.0)
			{
				BOIEGPAPHOP = other.BOIEGPAPHOP;
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
				AugmentId = input.ReadUInt32();
				break;
			case 25u:
				Damage = input.ReadDouble();
				break;
			case 33u:
				BOIEGPAPHOP = input.ReadDouble();
				break;
			}
		}
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class INMOMCDOPHF : IMessage<INMOMCDOPHF>, IMessage, IEquatable<INMOMCDOPHF>, IDeepCloneable<INMOMCDOPHF>, IBufferMessage
{
	private static readonly MessageParser<INMOMCDOPHF> _parser = new MessageParser<INMOMCDOPHF>(() => new INMOMCDOPHF());

	private UnknownFieldSet _unknownFields;

	public const int IBNELAJJOAOFieldNumber = 1;

	private uint iBNELAJJOAO_;

	public const int DamageFieldNumber = 2;

	private double damage_;

	public const int IHKEJOEHIKKFieldNumber = 3;

	private double iHKEJOEHIKK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<INMOMCDOPHF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => INMOMCDOPHFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IBNELAJJOAO
	{
		get
		{
			return iBNELAJJOAO_;
		}
		set
		{
			iBNELAJJOAO_ = value;
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
	public double IHKEJOEHIKK
	{
		get
		{
			return iHKEJOEHIKK_;
		}
		set
		{
			iHKEJOEHIKK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public INMOMCDOPHF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public INMOMCDOPHF(INMOMCDOPHF other)
		: this()
	{
		iBNELAJJOAO_ = other.iBNELAJJOAO_;
		damage_ = other.damage_;
		iHKEJOEHIKK_ = other.iHKEJOEHIKK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public INMOMCDOPHF Clone()
	{
		return new INMOMCDOPHF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as INMOMCDOPHF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(INMOMCDOPHF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IBNELAJJOAO != other.IBNELAJJOAO)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Damage, other.Damage))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(IHKEJOEHIKK, other.IHKEJOEHIKK))
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
		if (IBNELAJJOAO != 0)
		{
			num ^= IBNELAJJOAO.GetHashCode();
		}
		if (Damage != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Damage);
		}
		if (IHKEJOEHIKK != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(IHKEJOEHIKK);
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
		if (IBNELAJJOAO != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(IBNELAJJOAO);
		}
		if (Damage != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(Damage);
		}
		if (IHKEJOEHIKK != 0.0)
		{
			output.WriteRawTag(25);
			output.WriteDouble(IHKEJOEHIKK);
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
		if (IBNELAJJOAO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IBNELAJJOAO);
		}
		if (Damage != 0.0)
		{
			num += 9;
		}
		if (IHKEJOEHIKK != 0.0)
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
	public void MergeFrom(INMOMCDOPHF other)
	{
		if (other != null)
		{
			if (other.IBNELAJJOAO != 0)
			{
				IBNELAJJOAO = other.IBNELAJJOAO;
			}
			if (other.Damage != 0.0)
			{
				Damage = other.Damage;
			}
			if (other.IHKEJOEHIKK != 0.0)
			{
				IHKEJOEHIKK = other.IHKEJOEHIKK;
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
				IBNELAJJOAO = input.ReadUInt32();
				break;
			case 17u:
				Damage = input.ReadDouble();
				break;
			case 25u:
				IHKEJOEHIKK = input.ReadDouble();
				break;
			}
		}
	}
}

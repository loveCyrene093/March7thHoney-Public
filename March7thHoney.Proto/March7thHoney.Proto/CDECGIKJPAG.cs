using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CDECGIKJPAG : IMessage<CDECGIKJPAG>, IMessage, IEquatable<CDECGIKJPAG>, IDeepCloneable<CDECGIKJPAG>, IBufferMessage
{
	private static readonly MessageParser<CDECGIKJPAG> _parser = new MessageParser<CDECGIKJPAG>(() => new CDECGIKJPAG());

	private UnknownFieldSet _unknownFields;

	public const int RoleIdFieldNumber = 1;

	private uint roleId_;

	public const int DamageFieldNumber = 2;

	private double damage_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CDECGIKJPAG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CDECGIKJPAGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RoleId
	{
		get
		{
			return roleId_;
		}
		set
		{
			roleId_ = value;
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
	public CDECGIKJPAG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CDECGIKJPAG(CDECGIKJPAG other)
		: this()
	{
		roleId_ = other.roleId_;
		damage_ = other.damage_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CDECGIKJPAG Clone()
	{
		return new CDECGIKJPAG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CDECGIKJPAG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CDECGIKJPAG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoleId != other.RoleId)
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
		if (RoleId != 0)
		{
			num ^= RoleId.GetHashCode();
		}
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
		if (RoleId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(RoleId);
		}
		if (Damage != 0.0)
		{
			output.WriteRawTag(17);
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
		if (RoleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoleId);
		}
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
	public void MergeFrom(CDECGIKJPAG other)
	{
		if (other != null)
		{
			if (other.RoleId != 0)
			{
				RoleId = other.RoleId;
			}
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
				RoleId = input.ReadUInt32();
				break;
			case 17u:
				Damage = input.ReadDouble();
				break;
			}
		}
	}
}

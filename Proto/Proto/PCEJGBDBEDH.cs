using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PCEJGBDBEDH : IMessage<PCEJGBDBEDH>, IMessage, IEquatable<PCEJGBDBEDH>, IDeepCloneable<PCEJGBDBEDH>, IBufferMessage
{
	private static readonly MessageParser<PCEJGBDBEDH> _parser = new MessageParser<PCEJGBDBEDH>(() => new PCEJGBDBEDH());

	private UnknownFieldSet _unknownFields;

	public const int KGKFADDEGNJFieldNumber = 4;

	private uint kGKFADDEGNJ_;

	public const int DressRoleUniqueIdFieldNumber = 6;

	private uint dressRoleUniqueId_;

	public const int RoleIdFieldNumber = 15;

	private uint roleId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PCEJGBDBEDH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PCEJGBDBEDHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KGKFADDEGNJ
	{
		get
		{
			return kGKFADDEGNJ_;
		}
		set
		{
			kGKFADDEGNJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DressRoleUniqueId
	{
		get
		{
			return dressRoleUniqueId_;
		}
		set
		{
			dressRoleUniqueId_ = value;
		}
	}

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
	public PCEJGBDBEDH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCEJGBDBEDH(PCEJGBDBEDH other)
		: this()
	{
		kGKFADDEGNJ_ = other.kGKFADDEGNJ_;
		dressRoleUniqueId_ = other.dressRoleUniqueId_;
		roleId_ = other.roleId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCEJGBDBEDH Clone()
	{
		return new PCEJGBDBEDH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PCEJGBDBEDH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PCEJGBDBEDH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KGKFADDEGNJ != other.KGKFADDEGNJ)
		{
			return false;
		}
		if (DressRoleUniqueId != other.DressRoleUniqueId)
		{
			return false;
		}
		if (RoleId != other.RoleId)
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
		if (KGKFADDEGNJ != 0)
		{
			num ^= KGKFADDEGNJ.GetHashCode();
		}
		if (DressRoleUniqueId != 0)
		{
			num ^= DressRoleUniqueId.GetHashCode();
		}
		if (RoleId != 0)
		{
			num ^= RoleId.GetHashCode();
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
		if (KGKFADDEGNJ != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(KGKFADDEGNJ);
		}
		if (DressRoleUniqueId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(DressRoleUniqueId);
		}
		if (RoleId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(RoleId);
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
		if (KGKFADDEGNJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KGKFADDEGNJ);
		}
		if (DressRoleUniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DressRoleUniqueId);
		}
		if (RoleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoleId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PCEJGBDBEDH other)
	{
		if (other != null)
		{
			if (other.KGKFADDEGNJ != 0)
			{
				KGKFADDEGNJ = other.KGKFADDEGNJ;
			}
			if (other.DressRoleUniqueId != 0)
			{
				DressRoleUniqueId = other.DressRoleUniqueId;
			}
			if (other.RoleId != 0)
			{
				RoleId = other.RoleId;
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
			case 32u:
				KGKFADDEGNJ = input.ReadUInt32();
				break;
			case 48u:
				DressRoleUniqueId = input.ReadUInt32();
				break;
			case 120u:
				RoleId = input.ReadUInt32();
				break;
			}
		}
	}
}

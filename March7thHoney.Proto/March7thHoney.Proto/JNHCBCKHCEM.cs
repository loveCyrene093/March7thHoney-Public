using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JNHCBCKHCEM : IMessage<JNHCBCKHCEM>, IMessage, IEquatable<JNHCBCKHCEM>, IDeepCloneable<JNHCBCKHCEM>, IBufferMessage
{
	private static readonly MessageParser<JNHCBCKHCEM> _parser = new MessageParser<JNHCBCKHCEM>(() => new JNHCBCKHCEM());

	private UnknownFieldSet _unknownFields;

	public const int BHDHIIBCDIJFieldNumber = 1;

	private uint bHDHIIBCDIJ_;

	public const int AvatarIdFieldNumber = 15;

	private uint avatarId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JNHCBCKHCEM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JNHCBCKHCEMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BHDHIIBCDIJ
	{
		get
		{
			return bHDHIIBCDIJ_;
		}
		set
		{
			bHDHIIBCDIJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JNHCBCKHCEM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JNHCBCKHCEM(JNHCBCKHCEM other)
		: this()
	{
		bHDHIIBCDIJ_ = other.bHDHIIBCDIJ_;
		avatarId_ = other.avatarId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JNHCBCKHCEM Clone()
	{
		return new JNHCBCKHCEM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JNHCBCKHCEM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JNHCBCKHCEM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BHDHIIBCDIJ != other.BHDHIIBCDIJ)
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
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
		if (BHDHIIBCDIJ != 0)
		{
			num ^= BHDHIIBCDIJ.GetHashCode();
		}
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
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
		if (BHDHIIBCDIJ != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(BHDHIIBCDIJ);
		}
		if (AvatarId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(AvatarId);
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
		if (BHDHIIBCDIJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BHDHIIBCDIJ);
		}
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JNHCBCKHCEM other)
	{
		if (other != null)
		{
			if (other.BHDHIIBCDIJ != 0)
			{
				BHDHIIBCDIJ = other.BHDHIIBCDIJ;
			}
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
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
				BHDHIIBCDIJ = input.ReadUInt32();
				break;
			case 120u:
				AvatarId = input.ReadUInt32();
				break;
			}
		}
	}
}

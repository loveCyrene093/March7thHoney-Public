using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ANHLFCJGPEE : IMessage<ANHLFCJGPEE>, IMessage, IEquatable<ANHLFCJGPEE>, IDeepCloneable<ANHLFCJGPEE>, IBufferMessage
{
	private static readonly MessageParser<ANHLFCJGPEE> _parser = new MessageParser<ANHLFCJGPEE>(() => new ANHLFCJGPEE());

	private UnknownFieldSet _unknownFields;

	public const int AvatarIdFieldNumber = 1;

	private uint avatarId_;

	public const int DKNJIKJDHBMFieldNumber = 2;

	private int dKNJIKJDHBM_;

	public const int EnhancedIdFieldNumber = 3;

	private uint enhancedId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ANHLFCJGPEE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ANHLFCJGPEEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public int DKNJIKJDHBM
	{
		get
		{
			return dKNJIKJDHBM_;
		}
		set
		{
			dKNJIKJDHBM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EnhancedId
	{
		get
		{
			return enhancedId_;
		}
		set
		{
			enhancedId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ANHLFCJGPEE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ANHLFCJGPEE(ANHLFCJGPEE other)
		: this()
	{
		avatarId_ = other.avatarId_;
		dKNJIKJDHBM_ = other.dKNJIKJDHBM_;
		enhancedId_ = other.enhancedId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ANHLFCJGPEE Clone()
	{
		return new ANHLFCJGPEE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ANHLFCJGPEE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ANHLFCJGPEE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (DKNJIKJDHBM != other.DKNJIKJDHBM)
		{
			return false;
		}
		if (EnhancedId != other.EnhancedId)
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
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (DKNJIKJDHBM != 0)
		{
			num ^= DKNJIKJDHBM.GetHashCode();
		}
		if (EnhancedId != 0)
		{
			num ^= EnhancedId.GetHashCode();
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
		if (AvatarId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(AvatarId);
		}
		if (DKNJIKJDHBM != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(DKNJIKJDHBM);
		}
		if (EnhancedId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(EnhancedId);
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
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (DKNJIKJDHBM != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DKNJIKJDHBM);
		}
		if (EnhancedId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EnhancedId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ANHLFCJGPEE other)
	{
		if (other != null)
		{
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			if (other.DKNJIKJDHBM != 0)
			{
				DKNJIKJDHBM = other.DKNJIKJDHBM;
			}
			if (other.EnhancedId != 0)
			{
				EnhancedId = other.EnhancedId;
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
				AvatarId = input.ReadUInt32();
				break;
			case 16u:
				DKNJIKJDHBM = input.ReadInt32();
				break;
			case 24u:
				EnhancedId = input.ReadUInt32();
				break;
			}
		}
	}
}

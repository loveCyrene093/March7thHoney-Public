using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EIBOBKEJAKM : IMessage<EIBOBKEJAKM>, IMessage, IEquatable<EIBOBKEJAKM>, IDeepCloneable<EIBOBKEJAKM>, IBufferMessage
{
	private static readonly MessageParser<EIBOBKEJAKM> _parser = new MessageParser<EIBOBKEJAKM>(() => new EIBOBKEJAKM());

	private UnknownFieldSet _unknownFields;

	public const int AvatarIdFieldNumber = 1;

	private uint avatarId_;

	public const int FKMNABLAMFPFieldNumber = 2;

	private uint fKMNABLAMFP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EIBOBKEJAKM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EIBOBKEJAKMReflection.Descriptor.MessageTypes[0];

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
	public uint FKMNABLAMFP
	{
		get
		{
			return fKMNABLAMFP_;
		}
		set
		{
			fKMNABLAMFP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EIBOBKEJAKM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EIBOBKEJAKM(EIBOBKEJAKM other)
		: this()
	{
		avatarId_ = other.avatarId_;
		fKMNABLAMFP_ = other.fKMNABLAMFP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EIBOBKEJAKM Clone()
	{
		return new EIBOBKEJAKM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EIBOBKEJAKM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EIBOBKEJAKM other)
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
		if (FKMNABLAMFP != other.FKMNABLAMFP)
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
		if (FKMNABLAMFP != 0)
		{
			num ^= FKMNABLAMFP.GetHashCode();
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
		if (FKMNABLAMFP != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(FKMNABLAMFP);
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
		if (FKMNABLAMFP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FKMNABLAMFP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EIBOBKEJAKM other)
	{
		if (other != null)
		{
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			if (other.FKMNABLAMFP != 0)
			{
				FKMNABLAMFP = other.FKMNABLAMFP;
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
				FKMNABLAMFP = input.ReadUInt32();
				break;
			}
		}
	}
}

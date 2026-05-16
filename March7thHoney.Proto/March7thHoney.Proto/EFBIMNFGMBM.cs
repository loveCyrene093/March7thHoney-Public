using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EFBIMNFGMBM : IMessage<EFBIMNFGMBM>, IMessage, IEquatable<EFBIMNFGMBM>, IDeepCloneable<EFBIMNFGMBM>, IBufferMessage
{
	private static readonly MessageParser<EFBIMNFGMBM> _parser = new MessageParser<EFBIMNFGMBM>(() => new EFBIMNFGMBM());

	private UnknownFieldSet _unknownFields;

	public const int AFAHDBPGJLLFieldNumber = 2;

	private uint aFAHDBPGJLL_;

	public const int AvatarIdFieldNumber = 9;

	private uint avatarId_;

	public const int LNNNCEILCAAFieldNumber = 11;

	private uint lNNNCEILCAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EFBIMNFGMBM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EFBIMNFGMBMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AFAHDBPGJLL
	{
		get
		{
			return aFAHDBPGJLL_;
		}
		set
		{
			aFAHDBPGJLL_ = value;
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
	public uint LNNNCEILCAA
	{
		get
		{
			return lNNNCEILCAA_;
		}
		set
		{
			lNNNCEILCAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFBIMNFGMBM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFBIMNFGMBM(EFBIMNFGMBM other)
		: this()
	{
		aFAHDBPGJLL_ = other.aFAHDBPGJLL_;
		avatarId_ = other.avatarId_;
		lNNNCEILCAA_ = other.lNNNCEILCAA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFBIMNFGMBM Clone()
	{
		return new EFBIMNFGMBM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EFBIMNFGMBM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EFBIMNFGMBM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AFAHDBPGJLL != other.AFAHDBPGJLL)
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (LNNNCEILCAA != other.LNNNCEILCAA)
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
		if (AFAHDBPGJLL != 0)
		{
			num ^= AFAHDBPGJLL.GetHashCode();
		}
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (LNNNCEILCAA != 0)
		{
			num ^= LNNNCEILCAA.GetHashCode();
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
		if (AFAHDBPGJLL != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(AFAHDBPGJLL);
		}
		if (AvatarId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(AvatarId);
		}
		if (LNNNCEILCAA != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(LNNNCEILCAA);
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
		if (AFAHDBPGJLL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AFAHDBPGJLL);
		}
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (LNNNCEILCAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LNNNCEILCAA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EFBIMNFGMBM other)
	{
		if (other != null)
		{
			if (other.AFAHDBPGJLL != 0)
			{
				AFAHDBPGJLL = other.AFAHDBPGJLL;
			}
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			if (other.LNNNCEILCAA != 0)
			{
				LNNNCEILCAA = other.LNNNCEILCAA;
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
			case 16u:
				AFAHDBPGJLL = input.ReadUInt32();
				break;
			case 72u:
				AvatarId = input.ReadUInt32();
				break;
			case 88u:
				LNNNCEILCAA = input.ReadUInt32();
				break;
			}
		}
	}
}

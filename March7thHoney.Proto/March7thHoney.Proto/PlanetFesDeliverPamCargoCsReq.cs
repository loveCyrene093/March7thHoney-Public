using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesDeliverPamCargoCsReq : IMessage<PlanetFesDeliverPamCargoCsReq>, IMessage, IEquatable<PlanetFesDeliverPamCargoCsReq>, IDeepCloneable<PlanetFesDeliverPamCargoCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesDeliverPamCargoCsReq> _parser = new MessageParser<PlanetFesDeliverPamCargoCsReq>(() => new PlanetFesDeliverPamCargoCsReq());

	private UnknownFieldSet _unknownFields;

	public const int AvatarIdFieldNumber = 2;

	private uint avatarId_;

	public const int AFAHDBPGJLLFieldNumber = 14;

	private uint aFAHDBPGJLL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesDeliverPamCargoCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesDeliverPamCargoCsReqReflection.Descriptor.MessageTypes[0];

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
	public PlanetFesDeliverPamCargoCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesDeliverPamCargoCsReq(PlanetFesDeliverPamCargoCsReq other)
		: this()
	{
		avatarId_ = other.avatarId_;
		aFAHDBPGJLL_ = other.aFAHDBPGJLL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesDeliverPamCargoCsReq Clone()
	{
		return new PlanetFesDeliverPamCargoCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesDeliverPamCargoCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesDeliverPamCargoCsReq other)
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
		if (AFAHDBPGJLL != other.AFAHDBPGJLL)
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
		if (AFAHDBPGJLL != 0)
		{
			num ^= AFAHDBPGJLL.GetHashCode();
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
			output.WriteRawTag(16);
			output.WriteUInt32(AvatarId);
		}
		if (AFAHDBPGJLL != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(AFAHDBPGJLL);
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
		if (AFAHDBPGJLL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AFAHDBPGJLL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesDeliverPamCargoCsReq other)
	{
		if (other != null)
		{
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			if (other.AFAHDBPGJLL != 0)
			{
				AFAHDBPGJLL = other.AFAHDBPGJLL;
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
				AvatarId = input.ReadUInt32();
				break;
			case 112u:
				AFAHDBPGJLL = input.ReadUInt32();
				break;
			}
		}
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BGKIEFCLGDF : IMessage<BGKIEFCLGDF>, IMessage, IEquatable<BGKIEFCLGDF>, IDeepCloneable<BGKIEFCLGDF>, IBufferMessage
{
	private static readonly MessageParser<BGKIEFCLGDF> _parser = new MessageParser<BGKIEFCLGDF>(() => new BGKIEFCLGDF());

	private UnknownFieldSet _unknownFields;

	public const int RoomIdFieldNumber = 2;

	private uint roomId_;

	public const int AONGOEAFKOCFieldNumber = 4;

	private uint aONGOEAFKOC_;

	public const int PLOBMBFPNFKFieldNumber = 6;

	private FightGameMode pLOBMBFPNFK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BGKIEFCLGDF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BGKIEFCLGDFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RoomId
	{
		get
		{
			return roomId_;
		}
		set
		{
			roomId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AONGOEAFKOC
	{
		get
		{
			return aONGOEAFKOC_;
		}
		set
		{
			aONGOEAFKOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightGameMode PLOBMBFPNFK
	{
		get
		{
			return pLOBMBFPNFK_;
		}
		set
		{
			pLOBMBFPNFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGKIEFCLGDF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGKIEFCLGDF(BGKIEFCLGDF other)
		: this()
	{
		roomId_ = other.roomId_;
		aONGOEAFKOC_ = other.aONGOEAFKOC_;
		pLOBMBFPNFK_ = other.pLOBMBFPNFK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGKIEFCLGDF Clone()
	{
		return new BGKIEFCLGDF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BGKIEFCLGDF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BGKIEFCLGDF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoomId != other.RoomId)
		{
			return false;
		}
		if (AONGOEAFKOC != other.AONGOEAFKOC)
		{
			return false;
		}
		if (PLOBMBFPNFK != other.PLOBMBFPNFK)
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
		if (RoomId != 0)
		{
			num ^= RoomId.GetHashCode();
		}
		if (AONGOEAFKOC != 0)
		{
			num ^= AONGOEAFKOC.GetHashCode();
		}
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num ^= PLOBMBFPNFK.GetHashCode();
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
		if (RoomId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(RoomId);
		}
		if (AONGOEAFKOC != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(AONGOEAFKOC);
		}
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)PLOBMBFPNFK);
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
		if (RoomId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoomId);
		}
		if (AONGOEAFKOC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AONGOEAFKOC);
		}
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)PLOBMBFPNFK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BGKIEFCLGDF other)
	{
		if (other != null)
		{
			if (other.RoomId != 0)
			{
				RoomId = other.RoomId;
			}
			if (other.AONGOEAFKOC != 0)
			{
				AONGOEAFKOC = other.AONGOEAFKOC;
			}
			if (other.PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
			{
				PLOBMBFPNFK = other.PLOBMBFPNFK;
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
				RoomId = input.ReadUInt32();
				break;
			case 32u:
				AONGOEAFKOC = input.ReadUInt32();
				break;
			case 48u:
				PLOBMBFPNFK = (FightGameMode)input.ReadEnum();
				break;
			}
		}
	}
}

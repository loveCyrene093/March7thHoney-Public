using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PreCheckEnterRoomReq : IMessage<PreCheckEnterRoomReq>, IMessage, IEquatable<PreCheckEnterRoomReq>, IDeepCloneable<PreCheckEnterRoomReq>, IBufferMessage
{
	private static readonly MessageParser<PreCheckEnterRoomReq> _parser = new MessageParser<PreCheckEnterRoomReq>(() => new PreCheckEnterRoomReq());

	private UnknownFieldSet _unknownFields;

	public const int TeleportIdFieldNumber = 2;

	private uint teleportId_;

	public const int EntryIdFieldNumber = 5;

	private uint entryId_;

	public const int PLOBMBFPNFKFieldNumber = 14;

	private FEDLKANFNBH pLOBMBFPNFK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PreCheckEnterRoomReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PreCheckEnterRoomReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TeleportId
	{
		get
		{
			return teleportId_;
		}
		set
		{
			teleportId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EntryId
	{
		get
		{
			return entryId_;
		}
		set
		{
			entryId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FEDLKANFNBH PLOBMBFPNFK
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
	public PreCheckEnterRoomReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PreCheckEnterRoomReq(PreCheckEnterRoomReq other)
		: this()
	{
		teleportId_ = other.teleportId_;
		entryId_ = other.entryId_;
		pLOBMBFPNFK_ = other.pLOBMBFPNFK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PreCheckEnterRoomReq Clone()
	{
		return new PreCheckEnterRoomReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PreCheckEnterRoomReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PreCheckEnterRoomReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TeleportId != other.TeleportId)
		{
			return false;
		}
		if (EntryId != other.EntryId)
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
		if (TeleportId != 0)
		{
			num ^= TeleportId.GetHashCode();
		}
		if (EntryId != 0)
		{
			num ^= EntryId.GetHashCode();
		}
		if (PLOBMBFPNFK != FEDLKANFNBH.Labncgcmmlm)
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
		if (TeleportId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(TeleportId);
		}
		if (EntryId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(EntryId);
		}
		if (PLOBMBFPNFK != FEDLKANFNBH.Labncgcmmlm)
		{
			output.WriteRawTag(112);
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
		if (TeleportId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TeleportId);
		}
		if (EntryId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EntryId);
		}
		if (PLOBMBFPNFK != FEDLKANFNBH.Labncgcmmlm)
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
	public void MergeFrom(PreCheckEnterRoomReq other)
	{
		if (other != null)
		{
			if (other.TeleportId != 0)
			{
				TeleportId = other.TeleportId;
			}
			if (other.EntryId != 0)
			{
				EntryId = other.EntryId;
			}
			if (other.PLOBMBFPNFK != FEDLKANFNBH.Labncgcmmlm)
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
				TeleportId = input.ReadUInt32();
				break;
			case 40u:
				EntryId = input.ReadUInt32();
				break;
			case 112u:
				PLOBMBFPNFK = (FEDLKANFNBH)input.ReadEnum();
				break;
			}
		}
	}
}

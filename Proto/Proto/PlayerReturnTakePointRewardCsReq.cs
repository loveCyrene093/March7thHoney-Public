using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerReturnTakePointRewardCsReq : IMessage<PlayerReturnTakePointRewardCsReq>, IMessage, IEquatable<PlayerReturnTakePointRewardCsReq>, IDeepCloneable<PlayerReturnTakePointRewardCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlayerReturnTakePointRewardCsReq> _parser = new MessageParser<PlayerReturnTakePointRewardCsReq>(() => new PlayerReturnTakePointRewardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int HDABMKCNJJKFieldNumber = 3;

	private uint hDABMKCNJJK_;

	public const int EDIGJGGPPONFieldNumber = 11;

	private uint eDIGJGGPPON_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerReturnTakePointRewardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerReturnTakePointRewardCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HDABMKCNJJK
	{
		get
		{
			return hDABMKCNJJK_;
		}
		set
		{
			hDABMKCNJJK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EDIGJGGPPON
	{
		get
		{
			return eDIGJGGPPON_;
		}
		set
		{
			eDIGJGGPPON_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnTakePointRewardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnTakePointRewardCsReq(PlayerReturnTakePointRewardCsReq other)
		: this()
	{
		hDABMKCNJJK_ = other.hDABMKCNJJK_;
		eDIGJGGPPON_ = other.eDIGJGGPPON_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnTakePointRewardCsReq Clone()
	{
		return new PlayerReturnTakePointRewardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerReturnTakePointRewardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerReturnTakePointRewardCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HDABMKCNJJK != other.HDABMKCNJJK)
		{
			return false;
		}
		if (EDIGJGGPPON != other.EDIGJGGPPON)
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
		if (HDABMKCNJJK != 0)
		{
			num ^= HDABMKCNJJK.GetHashCode();
		}
		if (EDIGJGGPPON != 0)
		{
			num ^= EDIGJGGPPON.GetHashCode();
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
		if (HDABMKCNJJK != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(HDABMKCNJJK);
		}
		if (EDIGJGGPPON != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(EDIGJGGPPON);
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
		if (HDABMKCNJJK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HDABMKCNJJK);
		}
		if (EDIGJGGPPON != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EDIGJGGPPON);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerReturnTakePointRewardCsReq other)
	{
		if (other != null)
		{
			if (other.HDABMKCNJJK != 0)
			{
				HDABMKCNJJK = other.HDABMKCNJJK;
			}
			if (other.EDIGJGGPPON != 0)
			{
				EDIGJGGPPON = other.EDIGJGGPPON;
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
			case 24u:
				HDABMKCNJJK = input.ReadUInt32();
				break;
			case 88u:
				EDIGJGGPPON = input.ReadUInt32();
				break;
			}
		}
	}
}

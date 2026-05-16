using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerReturnTakePointRewardScRsp : IMessage<PlayerReturnTakePointRewardScRsp>, IMessage, IEquatable<PlayerReturnTakePointRewardScRsp>, IDeepCloneable<PlayerReturnTakePointRewardScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlayerReturnTakePointRewardScRsp> _parser = new MessageParser<PlayerReturnTakePointRewardScRsp>(() => new PlayerReturnTakePointRewardScRsp());

	private UnknownFieldSet _unknownFields;

	public const int BGPKPKHCGKEFieldNumber = 1;

	private ItemList bGPKPKHCGKE_;

	public const int EDIGJGGPPONFieldNumber = 3;

	private uint eDIGJGGPPON_;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int HDABMKCNJJKFieldNumber = 9;

	private uint hDABMKCNJJK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerReturnTakePointRewardScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerReturnTakePointRewardScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList BGPKPKHCGKE
	{
		get
		{
			return bGPKPKHCGKE_;
		}
		set
		{
			bGPKPKHCGKE_ = value;
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
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

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
	public PlayerReturnTakePointRewardScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnTakePointRewardScRsp(PlayerReturnTakePointRewardScRsp other)
		: this()
	{
		bGPKPKHCGKE_ = ((other.bGPKPKHCGKE_ != null) ? other.bGPKPKHCGKE_.Clone() : null);
		eDIGJGGPPON_ = other.eDIGJGGPPON_;
		retcode_ = other.retcode_;
		hDABMKCNJJK_ = other.hDABMKCNJJK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnTakePointRewardScRsp Clone()
	{
		return new PlayerReturnTakePointRewardScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerReturnTakePointRewardScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerReturnTakePointRewardScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BGPKPKHCGKE, other.BGPKPKHCGKE))
		{
			return false;
		}
		if (EDIGJGGPPON != other.EDIGJGGPPON)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (HDABMKCNJJK != other.HDABMKCNJJK)
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
		if (bGPKPKHCGKE_ != null)
		{
			num ^= BGPKPKHCGKE.GetHashCode();
		}
		if (EDIGJGGPPON != 0)
		{
			num ^= EDIGJGGPPON.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (HDABMKCNJJK != 0)
		{
			num ^= HDABMKCNJJK.GetHashCode();
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
		if (bGPKPKHCGKE_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(BGPKPKHCGKE);
		}
		if (EDIGJGGPPON != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(EDIGJGGPPON);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		if (HDABMKCNJJK != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(HDABMKCNJJK);
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
		if (bGPKPKHCGKE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BGPKPKHCGKE);
		}
		if (EDIGJGGPPON != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EDIGJGGPPON);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (HDABMKCNJJK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HDABMKCNJJK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerReturnTakePointRewardScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.bGPKPKHCGKE_ != null)
		{
			if (bGPKPKHCGKE_ == null)
			{
				BGPKPKHCGKE = new ItemList();
			}
			BGPKPKHCGKE.MergeFrom(other.BGPKPKHCGKE);
		}
		if (other.EDIGJGGPPON != 0)
		{
			EDIGJGGPPON = other.EDIGJGGPPON;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.HDABMKCNJJK != 0)
		{
			HDABMKCNJJK = other.HDABMKCNJJK;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 10u:
				if (bGPKPKHCGKE_ == null)
				{
					BGPKPKHCGKE = new ItemList();
				}
				input.ReadMessage(BGPKPKHCGKE);
				break;
			case 24u:
				EDIGJGGPPON = input.ReadUInt32();
				break;
			case 32u:
				Retcode = input.ReadUInt32();
				break;
			case 72u:
				HDABMKCNJJK = input.ReadUInt32();
				break;
			}
		}
	}
}

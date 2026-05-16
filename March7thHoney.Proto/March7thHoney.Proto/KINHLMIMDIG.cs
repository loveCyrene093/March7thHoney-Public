using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KINHLMIMDIG : IMessage<KINHLMIMDIG>, IMessage, IEquatable<KINHLMIMDIG>, IDeepCloneable<KINHLMIMDIG>, IBufferMessage
{
	private static readonly MessageParser<KINHLMIMDIG> _parser = new MessageParser<KINHLMIMDIG>(() => new KINHLMIMDIG());

	private UnknownFieldSet _unknownFields;

	public const int KHCPCKIBNKBFieldNumber = 8;

	private int kHCPCKIBNKB_;

	public const int MGNGPGPPIAAFieldNumber = 9;

	private uint mGNGPGPPIAA_;

	public const int TotalDamageFieldNumber = 12;

	private int totalDamage_;

	public const int PHLEIBBBDDNFieldNumber = 13;

	private int pHLEIBBBDDN_;

	public const int ItemIdFieldNumber = 15;

	private uint itemId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KINHLMIMDIG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KINHLMIMDIGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int KHCPCKIBNKB
	{
		get
		{
			return kHCPCKIBNKB_;
		}
		set
		{
			kHCPCKIBNKB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MGNGPGPPIAA
	{
		get
		{
			return mGNGPGPPIAA_;
		}
		set
		{
			mGNGPGPPIAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TotalDamage
	{
		get
		{
			return totalDamage_;
		}
		set
		{
			totalDamage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PHLEIBBBDDN
	{
		get
		{
			return pHLEIBBBDDN_;
		}
		set
		{
			pHLEIBBBDDN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemId
	{
		get
		{
			return itemId_;
		}
		set
		{
			itemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KINHLMIMDIG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KINHLMIMDIG(KINHLMIMDIG other)
		: this()
	{
		kHCPCKIBNKB_ = other.kHCPCKIBNKB_;
		mGNGPGPPIAA_ = other.mGNGPGPPIAA_;
		totalDamage_ = other.totalDamage_;
		pHLEIBBBDDN_ = other.pHLEIBBBDDN_;
		itemId_ = other.itemId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KINHLMIMDIG Clone()
	{
		return new KINHLMIMDIG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KINHLMIMDIG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KINHLMIMDIG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KHCPCKIBNKB != other.KHCPCKIBNKB)
		{
			return false;
		}
		if (MGNGPGPPIAA != other.MGNGPGPPIAA)
		{
			return false;
		}
		if (TotalDamage != other.TotalDamage)
		{
			return false;
		}
		if (PHLEIBBBDDN != other.PHLEIBBBDDN)
		{
			return false;
		}
		if (ItemId != other.ItemId)
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
		if (KHCPCKIBNKB != 0)
		{
			num ^= KHCPCKIBNKB.GetHashCode();
		}
		if (MGNGPGPPIAA != 0)
		{
			num ^= MGNGPGPPIAA.GetHashCode();
		}
		if (TotalDamage != 0)
		{
			num ^= TotalDamage.GetHashCode();
		}
		if (PHLEIBBBDDN != 0)
		{
			num ^= PHLEIBBBDDN.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
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
		if (KHCPCKIBNKB != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(KHCPCKIBNKB);
		}
		if (MGNGPGPPIAA != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(MGNGPGPPIAA);
		}
		if (TotalDamage != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(TotalDamage);
		}
		if (PHLEIBBBDDN != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(PHLEIBBBDDN);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(ItemId);
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
		if (KHCPCKIBNKB != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(KHCPCKIBNKB);
		}
		if (MGNGPGPPIAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MGNGPGPPIAA);
		}
		if (TotalDamage != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TotalDamage);
		}
		if (PHLEIBBBDDN != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PHLEIBBBDDN);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KINHLMIMDIG other)
	{
		if (other != null)
		{
			if (other.KHCPCKIBNKB != 0)
			{
				KHCPCKIBNKB = other.KHCPCKIBNKB;
			}
			if (other.MGNGPGPPIAA != 0)
			{
				MGNGPGPPIAA = other.MGNGPGPPIAA;
			}
			if (other.TotalDamage != 0)
			{
				TotalDamage = other.TotalDamage;
			}
			if (other.PHLEIBBBDDN != 0)
			{
				PHLEIBBBDDN = other.PHLEIBBBDDN;
			}
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
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
			case 64u:
				KHCPCKIBNKB = input.ReadInt32();
				break;
			case 72u:
				MGNGPGPPIAA = input.ReadUInt32();
				break;
			case 96u:
				TotalDamage = input.ReadInt32();
				break;
			case 104u:
				PHLEIBBBDDN = input.ReadInt32();
				break;
			case 120u:
				ItemId = input.ReadUInt32();
				break;
			}
		}
	}
}

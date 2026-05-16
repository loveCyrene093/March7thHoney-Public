using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DestroyItemCsReq : IMessage<DestroyItemCsReq>, IMessage, IEquatable<DestroyItemCsReq>, IDeepCloneable<DestroyItemCsReq>, IBufferMessage
{
	private static readonly MessageParser<DestroyItemCsReq> _parser = new MessageParser<DestroyItemCsReq>(() => new DestroyItemCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ItemCountFieldNumber = 8;

	private uint itemCount_;

	public const int ItemIdFieldNumber = 12;

	private uint itemId_;

	public const int PIAFCPCDCDFFieldNumber = 14;

	private uint pIAFCPCDCDF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DestroyItemCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DestroyItemCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemCount
	{
		get
		{
			return itemCount_;
		}
		set
		{
			itemCount_ = value;
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
	public uint PIAFCPCDCDF
	{
		get
		{
			return pIAFCPCDCDF_;
		}
		set
		{
			pIAFCPCDCDF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DestroyItemCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DestroyItemCsReq(DestroyItemCsReq other)
		: this()
	{
		itemCount_ = other.itemCount_;
		itemId_ = other.itemId_;
		pIAFCPCDCDF_ = other.pIAFCPCDCDF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DestroyItemCsReq Clone()
	{
		return new DestroyItemCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DestroyItemCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DestroyItemCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ItemCount != other.ItemCount)
		{
			return false;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (PIAFCPCDCDF != other.PIAFCPCDCDF)
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
		if (ItemCount != 0)
		{
			num ^= ItemCount.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (PIAFCPCDCDF != 0)
		{
			num ^= PIAFCPCDCDF.GetHashCode();
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
		if (ItemCount != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(ItemCount);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(ItemId);
		}
		if (PIAFCPCDCDF != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(PIAFCPCDCDF);
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
		if (ItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemCount);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemId);
		}
		if (PIAFCPCDCDF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PIAFCPCDCDF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DestroyItemCsReq other)
	{
		if (other != null)
		{
			if (other.ItemCount != 0)
			{
				ItemCount = other.ItemCount;
			}
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.PIAFCPCDCDF != 0)
			{
				PIAFCPCDCDF = other.PIAFCPCDCDF;
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
				ItemCount = input.ReadUInt32();
				break;
			case 96u:
				ItemId = input.ReadUInt32();
				break;
			case 112u:
				PIAFCPCDCDF = input.ReadUInt32();
				break;
			}
		}
	}
}

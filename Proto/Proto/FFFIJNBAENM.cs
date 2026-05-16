using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FFFIJNBAENM : IMessage<FFFIJNBAENM>, IMessage, IEquatable<FFFIJNBAENM>, IDeepCloneable<FFFIJNBAENM>, IBufferMessage
{
	private static readonly MessageParser<FFFIJNBAENM> _parser = new MessageParser<FFFIJNBAENM>(() => new FFFIJNBAENM());

	private UnknownFieldSet _unknownFields;

	public const int MAGPAONJOBDFieldNumber = 6;

	private uint mAGPAONJOBD_;

	public const int ItemIdFieldNumber = 11;

	private uint itemId_;

	public const int BMNDBKBHIOCFieldNumber = 13;

	private OIDHAGNGKLG bMNDBKBHIOC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FFFIJNBAENM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FFFIJNBAENMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MAGPAONJOBD
	{
		get
		{
			return mAGPAONJOBD_;
		}
		set
		{
			mAGPAONJOBD_ = value;
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
	public OIDHAGNGKLG BMNDBKBHIOC
	{
		get
		{
			return bMNDBKBHIOC_;
		}
		set
		{
			bMNDBKBHIOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFFIJNBAENM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFFIJNBAENM(FFFIJNBAENM other)
		: this()
	{
		mAGPAONJOBD_ = other.mAGPAONJOBD_;
		itemId_ = other.itemId_;
		bMNDBKBHIOC_ = ((other.bMNDBKBHIOC_ != null) ? other.bMNDBKBHIOC_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFFIJNBAENM Clone()
	{
		return new FFFIJNBAENM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FFFIJNBAENM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FFFIJNBAENM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MAGPAONJOBD != other.MAGPAONJOBD)
		{
			return false;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (!object.Equals(BMNDBKBHIOC, other.BMNDBKBHIOC))
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
		if (MAGPAONJOBD != 0)
		{
			num ^= MAGPAONJOBD.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (bMNDBKBHIOC_ != null)
		{
			num ^= BMNDBKBHIOC.GetHashCode();
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
		if (MAGPAONJOBD != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(MAGPAONJOBD);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(ItemId);
		}
		if (bMNDBKBHIOC_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(BMNDBKBHIOC);
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
		if (MAGPAONJOBD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MAGPAONJOBD);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemId);
		}
		if (bMNDBKBHIOC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BMNDBKBHIOC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FFFIJNBAENM other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MAGPAONJOBD != 0)
		{
			MAGPAONJOBD = other.MAGPAONJOBD;
		}
		if (other.ItemId != 0)
		{
			ItemId = other.ItemId;
		}
		if (other.bMNDBKBHIOC_ != null)
		{
			if (bMNDBKBHIOC_ == null)
			{
				BMNDBKBHIOC = new OIDHAGNGKLG();
			}
			BMNDBKBHIOC.MergeFrom(other.BMNDBKBHIOC);
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
			case 48u:
				MAGPAONJOBD = input.ReadUInt32();
				break;
			case 88u:
				ItemId = input.ReadUInt32();
				break;
			case 106u:
				if (bMNDBKBHIOC_ == null)
				{
					BMNDBKBHIOC = new OIDHAGNGKLG();
				}
				input.ReadMessage(BMNDBKBHIOC);
				break;
			}
		}
	}
}

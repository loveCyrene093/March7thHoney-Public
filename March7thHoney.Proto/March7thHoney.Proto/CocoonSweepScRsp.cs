using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CocoonSweepScRsp : IMessage<CocoonSweepScRsp>, IMessage, IEquatable<CocoonSweepScRsp>, IDeepCloneable<CocoonSweepScRsp>, IBufferMessage
{
	private static readonly MessageParser<CocoonSweepScRsp> _parser = new MessageParser<CocoonSweepScRsp>(() => new CocoonSweepScRsp());

	private UnknownFieldSet _unknownFields;

	public const int CocoonIdFieldNumber = 1;

	private uint cocoonId_;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int DropDataFieldNumber = 5;

	private ItemList dropData_;

	public const int MultipleDropDataFieldNumber = 12;

	private ItemList multipleDropData_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CocoonSweepScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CocoonSweepScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CocoonId
	{
		get
		{
			return cocoonId_;
		}
		set
		{
			cocoonId_ = value;
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
	public ItemList DropData
	{
		get
		{
			return dropData_;
		}
		set
		{
			dropData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList MultipleDropData
	{
		get
		{
			return multipleDropData_;
		}
		set
		{
			multipleDropData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CocoonSweepScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CocoonSweepScRsp(CocoonSweepScRsp other)
		: this()
	{
		cocoonId_ = other.cocoonId_;
		retcode_ = other.retcode_;
		dropData_ = ((other.dropData_ != null) ? other.dropData_.Clone() : null);
		multipleDropData_ = ((other.multipleDropData_ != null) ? other.multipleDropData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CocoonSweepScRsp Clone()
	{
		return new CocoonSweepScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CocoonSweepScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CocoonSweepScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CocoonId != other.CocoonId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(DropData, other.DropData))
		{
			return false;
		}
		if (!object.Equals(MultipleDropData, other.MultipleDropData))
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
		if (CocoonId != 0)
		{
			num ^= CocoonId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (dropData_ != null)
		{
			num ^= DropData.GetHashCode();
		}
		if (multipleDropData_ != null)
		{
			num ^= MultipleDropData.GetHashCode();
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
		if (CocoonId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(CocoonId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		if (dropData_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(DropData);
		}
		if (multipleDropData_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(MultipleDropData);
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
		if (CocoonId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CocoonId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (dropData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DropData);
		}
		if (multipleDropData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MultipleDropData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CocoonSweepScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.CocoonId != 0)
		{
			CocoonId = other.CocoonId;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.dropData_ != null)
		{
			if (dropData_ == null)
			{
				DropData = new ItemList();
			}
			DropData.MergeFrom(other.DropData);
		}
		if (other.multipleDropData_ != null)
		{
			if (multipleDropData_ == null)
			{
				MultipleDropData = new ItemList();
			}
			MultipleDropData.MergeFrom(other.MultipleDropData);
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
			case 8u:
				CocoonId = input.ReadUInt32();
				break;
			case 32u:
				Retcode = input.ReadUInt32();
				break;
			case 42u:
				if (dropData_ == null)
				{
					DropData = new ItemList();
				}
				input.ReadMessage(DropData);
				break;
			case 98u:
				if (multipleDropData_ == null)
				{
					MultipleDropData = new ItemList();
				}
				input.ReadMessage(MultipleDropData);
				break;
			}
		}
	}
}

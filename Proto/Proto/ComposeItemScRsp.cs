using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ComposeItemScRsp : IMessage<ComposeItemScRsp>, IMessage, IEquatable<ComposeItemScRsp>, IDeepCloneable<ComposeItemScRsp>, IBufferMessage
{
	private static readonly MessageParser<ComposeItemScRsp> _parser = new MessageParser<ComposeItemScRsp>(() => new ComposeItemScRsp());

	private UnknownFieldSet _unknownFields;

	public const int CountFieldNumber = 1;

	private uint count_;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int ReturnItemListFieldNumber = 5;

	private ItemList returnItemList_;

	public const int ComposeIdFieldNumber = 13;

	private uint composeId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ComposeItemScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ComposeItemScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Count
	{
		get
		{
			return count_;
		}
		set
		{
			count_ = value;
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
	public ItemList ReturnItemList
	{
		get
		{
			return returnItemList_;
		}
		set
		{
			returnItemList_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ComposeId
	{
		get
		{
			return composeId_;
		}
		set
		{
			composeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ComposeItemScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ComposeItemScRsp(ComposeItemScRsp other)
		: this()
	{
		count_ = other.count_;
		retcode_ = other.retcode_;
		returnItemList_ = ((other.returnItemList_ != null) ? other.returnItemList_.Clone() : null);
		composeId_ = other.composeId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ComposeItemScRsp Clone()
	{
		return new ComposeItemScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ComposeItemScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ComposeItemScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Count != other.Count)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(ReturnItemList, other.ReturnItemList))
		{
			return false;
		}
		if (ComposeId != other.ComposeId)
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
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (returnItemList_ != null)
		{
			num ^= ReturnItemList.GetHashCode();
		}
		if (ComposeId != 0)
		{
			num ^= ComposeId.GetHashCode();
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
		if (Count != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Count);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		if (returnItemList_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(ReturnItemList);
		}
		if (ComposeId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ComposeId);
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
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Count);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (returnItemList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ReturnItemList);
		}
		if (ComposeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ComposeId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ComposeItemScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Count != 0)
		{
			Count = other.Count;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.returnItemList_ != null)
		{
			if (returnItemList_ == null)
			{
				ReturnItemList = new ItemList();
			}
			ReturnItemList.MergeFrom(other.ReturnItemList);
		}
		if (other.ComposeId != 0)
		{
			ComposeId = other.ComposeId;
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
				Count = input.ReadUInt32();
				break;
			case 32u:
				Retcode = input.ReadUInt32();
				break;
			case 42u:
				if (returnItemList_ == null)
				{
					ReturnItemList = new ItemList();
				}
				input.ReadMessage(ReturnItemList);
				break;
			case 104u:
				ComposeId = input.ReadUInt32();
				break;
			}
		}
	}
}

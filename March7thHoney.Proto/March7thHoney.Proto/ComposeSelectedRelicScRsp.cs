using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ComposeSelectedRelicScRsp : IMessage<ComposeSelectedRelicScRsp>, IMessage, IEquatable<ComposeSelectedRelicScRsp>, IDeepCloneable<ComposeSelectedRelicScRsp>, IBufferMessage
{
	private static readonly MessageParser<ComposeSelectedRelicScRsp> _parser = new MessageParser<ComposeSelectedRelicScRsp>(() => new ComposeSelectedRelicScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ComposeIdFieldNumber = 2;

	private uint composeId_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int ReturnItemListFieldNumber = 10;

	private ItemList returnItemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ComposeSelectedRelicScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ComposeSelectedRelicScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public ComposeSelectedRelicScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ComposeSelectedRelicScRsp(ComposeSelectedRelicScRsp other)
		: this()
	{
		composeId_ = other.composeId_;
		retcode_ = other.retcode_;
		returnItemList_ = ((other.returnItemList_ != null) ? other.returnItemList_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ComposeSelectedRelicScRsp Clone()
	{
		return new ComposeSelectedRelicScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ComposeSelectedRelicScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ComposeSelectedRelicScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ComposeId != other.ComposeId)
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (ComposeId != 0)
		{
			num ^= ComposeId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (returnItemList_ != null)
		{
			num ^= ReturnItemList.GetHashCode();
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
		if (ComposeId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(ComposeId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		if (returnItemList_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(ReturnItemList);
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
		if (ComposeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ComposeId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (returnItemList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ReturnItemList);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ComposeSelectedRelicScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ComposeId != 0)
		{
			ComposeId = other.ComposeId;
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
			case 16u:
				ComposeId = input.ReadUInt32();
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 82u:
				if (returnItemList_ == null)
				{
					ReturnItemList = new ItemList();
				}
				input.ReadMessage(ReturnItemList);
				break;
			}
		}
	}
}
